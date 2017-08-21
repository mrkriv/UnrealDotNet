using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Generator.Metadata;

namespace Generator
{
    internal class Codegenretor
    {
        private const string DllEditorImportName = "UE4Editor-UnrealDotNetRuntime";
        private const string DllPaksImportName = "DotUnrealExample.exe";
        private const string ExportPrefix = "E_";
        private const string EnginePathSeg = @"Engine\Source\Runtime";
        private const string CPP_API = "DOTNET_EXPORT";

        public static void GenarateTo(Domain domain, string OutputDir)
        {
            var outputCS = Path.Combine(OutputDir, "NetCoreProject", "UnrealEngine", "Generate");
            var outputCPP = Path.Combine(OutputDir, "UnrealDotNetRuntime", "Private", "Generate");

            var Classes = domain.Classes.Where(cl => cl.IsImplemented);

            foreach (var cl in Classes)
            {
                GenerateCS(cl, Path.Combine(outputCS, cl.Name));
                GenerateCPP(cl, Path.Combine(outputCPP, cl.Name));
            }

            GenerateCPPIndex(Classes, Path.Combine(outputCPP, "Index"));
        }

        private static void GenerateCS(Class Class, string OutputPath)
        {
            using (var cw = new CoreWriter(OutputPath + ".cs"))
            {
                cw.WriteLine("using System;");
                cw.WriteLine("using System.Runtime.InteropServices;");
                cw.WriteLine();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                cw.Write($"public partial class {Class.Name}");
                if (Class.BaseClass != null)
                    cw.Write($" : {Class.BaseClass.Name}");

                cw.WriteLine();
                cw.OpenBlock();

                if (Class.BaseClass == null)
                {
                    cw.WriteLine("protected readonly IntPtr NativePointer;");
                    cw.WriteLine();
                    cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine("NativePointer = Adress;");
                    cw.CloseBlock();
                }
                else
                {
                    cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                    cw.WriteLine("\t: base(Adress)");
                    cw.OpenBlock();
                    cw.CloseBlock();
                }

                cw.WriteLine();

                var methods = Class.Methods.Where(m => m.Dependent.All(c => c.IsImplemented));

                cw.WriteLine("#region DLLInmport");
                foreach (var method in methods)
                {
                    var inputs = method.InputTypes.Select(ExportVariableCS).ToList();
                    inputs.Insert(0, "IntPtr Self");

                    var param = string.Join(", ", inputs);

                    cw.WriteLine("#if PACING");
                    cw.WriteLine($"[DllImport(\"{DllPaksImportName}\")]");
                    cw.WriteLine("#else");
                    cw.WriteLine($"[DllImport(\"{DllEditorImportName}\")]");
                    cw.WriteLine("#endif");
                    cw.WriteLine(
                        $"private static extern {ExportVariableCS(method.ReturnType)} {ExportPrefix}{method.Name}({param});");
                    cw.WriteLine();
                }

                cw.WriteLine("#endregion");
                cw.WriteLine();
                cw.WriteLine("#region ExternMethods");

                foreach (var method in methods)
                {
                    var inputs = method.InputTypes.Select(t => t.Name).ToList();
                    inputs.Insert(0, "NativePointer");

                    var param = string.Join(", ", method.InputTypes.Select(ExportVariableCS));
                    var call = string.Join(", ", inputs);

                    cw.WriteLine(
                        $"public {ExportVariableCS(method.ReturnType)} {method.Name}({param})");

                    cw.OpenBlock();

                    cw.Write(!method.ReturnType.IsVoid, "return ");
                    cw.WriteLine($"{ExportPrefix}{method.Name}({call});");

                    cw.CloseBlock();
                    cw.WriteLine();
                }

                cw.WriteLine("#endregion");
                cw.WriteLine();

                cw.WriteLine($"public static explicit operator IntPtr({Class.Name} Self)");
                cw.OpenBlock();
                cw.WriteLine("return Self.NativePointer;");
                cw.CloseBlock();
                cw.WriteLine();

                cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                cw.OpenBlock();
                cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress);");
                cw.CloseBlock();

                cw.CloseBlock();
                cw.CloseBlock();
            }
        }

        private static void GenerateCPP(Class Class, string OutputPath)
        {
            using (var cw = new CoreWriter(OutputPath + ".inl"))
            {
                var methods = Class.Methods.Where(m => m.Dependent.All(c => c.IsImplemented));

                var index = Class.SourceFile.IndexOf(EnginePathSeg, StringComparison.Ordinal);
                var SourceFile = index == -1 ? Class.SourceFile : Class.SourceFile.Substring(index + EnginePathSeg.Length + 1);
                SourceFile = SourceFile.Replace("\\", "/");

                cw.WriteLine($"#include \"{SourceFile}\"");
                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var method in methods)
                {
                    var inputs = method.InputTypes.Select(ExportVariableCPP).ToList();

                    inputs.Insert(0, "INT_PTR Self");

                    var param = string.Join(", ", inputs);
                    var call = string.Join(", ", method.InputTypes.Select(t => t.Name));

                    cw.WriteLine($"{CPP_API} {ExportVariableCPP(method.ReturnType)} {ExportPrefix}{method.Name}({param})");
                    cw.OpenBlock();

                    cw.Write(!method.ReturnType.IsVoid, "return ");
                    cw.WriteLine($"(({Class.Name}*)Self)->{method.Name}({call});");

                    cw.CloseBlock();
                    cw.WriteLine();
                }

                cw.CloseBlock();
            }
        }

        private static void GenerateCPPIndex(IEnumerable<Class> Classes, string OutputPath)
        {
            using (var cw = new CoreWriter(OutputPath + ".inl"))
            {
                cw.WriteLine("#pragma warning(push)");
                cw.WriteLine("#pragma warning(disable:4996)");
                cw.WriteLine();

                foreach (var Class in Classes)
                {
                    cw.WriteLine($"#include \"{Class.Name}.inl\"");
                }

                cw.WriteLine();
                cw.WriteLine("#pragma warning(pop)");
            }
        }

        private static string ExportVariableCS(Variable variable)
        {
            var result = variable.GetTypeCS();

            if (!string.IsNullOrEmpty(variable.Name))
                result += " " + variable.Name;

            return result;
        }

        private static string ExportVariableCPP(Variable variable)
        {
            var result = variable.GetTypeCPP();

            if (!string.IsNullOrEmpty(variable.Name))
                result += " " + variable.Name;

            return result;
        }
    }
}