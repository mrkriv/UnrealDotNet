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
        private const string DllImportName = "UE4Editor-UnrealDotNetRuntime";
        private const string ExportPrefix = "E_";

        public static void GenarateTo(Domain domain, string OutputDir)
        {
            foreach (var cl in domain.Classes)
            {
                if (!cl.IsImplemented)
                    continue;

                GenerateCS(cl, Path.Combine(OutputDir, cl.Name));
                //GenerateCPP(cl, Path.Combine(OutputDir, cl.Name));
            }
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

                cw.WriteLine("private readonly IntPtr NativePointer;");
                cw.WriteLine();
                cw.WriteLine($"public {Class.Name}(IntPtr Adress)");

                if (Class.BaseClass != null)
                    cw.WriteLine("\t: base(Adress)");

                cw.OpenBlock();
                cw.WriteLine("NativePointer = Adress;");
                cw.CloseBlock();
                cw.WriteLine();

                var methods = Class.Methods.Where(m => m.Dependent.All(c => c.IsImplemented));

                cw.WriteLine("#region DLLInmport");
                foreach (var method in methods)
                {
                    var inputs = method.InputTypes.Select(ExportVariable).ToList();
                    inputs.Insert(0, "IntPtr Self");

                    var param = string.Join(", ", inputs);

                    cw.WriteLine($"[DllImport(\"{DllImportName}\")]");
                    cw.WriteLine(
                        $"private static extern {ExportVariable(method.ReturnType)} {ExportPrefix}{method.Name}({param});");
                    cw.WriteLine();
                }

                cw.WriteLine("#endregion");
                cw.WriteLine();
                cw.WriteLine("#region ExternMethods");

                foreach (var method in methods)
                {
                    var inputs = method.InputTypes.Select(t => t.Name).ToList();
                    inputs.Insert(0, "NativePointer");

                    var param = string.Join(", ", method.InputTypes.Select(ExportVariable));
                    var call = string.Join(", ", inputs);

                    cw.WriteLine(
                        $"public {ExportVariable(method.ReturnType)} {method.Name}({param})");

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
            var cw = new CoreWriter(OutputPath + ".cpp");
        }

        private static string ExportVariable(Variable variable)
        {
            var result = ReplaceTypeCPPtoCS(variable);

            if (!string.IsNullOrEmpty(variable.Name))
                result += " " + variable.Name;

            return result;
        }

        private static string ReplaceTypeCPPtoCS(Variable variable)
        {
            switch (variable.Type)
            {
                case "uint8":
                    return "byte";

                case "int32":
                    return "Int32";

                case "FString":
                case "FText":
                case "FName":
                    return "string";

                case "INT_PTR":
                    return "IntPtr";

                default:
                    return variable.Type;
            }
        }
    }
}