using System.Collections.Generic;
using Generator.Metadata;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CS
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                Directory.GetFiles(OutputDir, "*.cs").ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes)
                {
                    GenerateClass(cl, Path.Combine(OutputDir, cl.Name));
                }
            }

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("using System;");
                cw.WriteLine("using System.Runtime.InteropServices;");
                cw.WriteLine();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                GenerateSummaty(cw, Class.Description);

                cw.Write($"public partial {(Class.IsStructure ? "struct" : "class")} {Class.Name}");

                if (Class.BaseClass != null)
                    cw.Write($" : {Class.BaseClass.Name}");

                cw.WriteLine();
                cw.OpenBlock();

                GenerateClassUtilitesTop(cw, Class);

                var cw_DllImport = new CoreWriter(cw);
                var cw_ExternMethods = new CoreWriter(cw);

                foreach (var method in Class.Methods)
                {
                    GenerateMethodDLLImport(cw_DllImport, Class, method);
                    GenerateMethodBody(cw_ExternMethods, Class, method);
                }

                cw.WriteLine();

                cw.WriteLine("#region DLLInmport");
                cw.Write(cw_DllImport);
                cw.WriteLine("#endregion");
                cw.WriteLine();

                cw.WriteLine("#region Property");
                Class.Property.ForEach(p => GenerateProperty(cw, p));
                cw.WriteLine("#endregion");
                cw.WriteLine();

                cw.WriteLine("#region ExternMethods");
                cw.Write(cw_ExternMethods);
                cw.WriteLine("#endregion");
                cw.WriteLine();

                GenerateClassUtilitesButtom(cw, Class);

                cw.CloseBlock();
                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".cs");
            }

            private static void GenerateProperty(CoreWriter cw, Variable prop)
            {
                GenerateSummaty(cw, prop.Description);
                cw.WriteLine($"public {ExportVariable(prop, false)} {{ get; set; }} ");
            }

            private static void GenerateClassUtilitesTop(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                }
                else
                {
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
                }
            }

            private static void GenerateMethodDLLImport(CoreWriter cw, Class Class, Method method)
            {
                var inputs = method.InputTypes.Select(m => ExportVariable(m, false)).ToList();
                inputs.Insert(0, (Class.IsStructure ? Class.Name : "IntPtr") + " Self");

                var param = string.Join(", ", inputs);

                cw.WriteLine("#if PACING");
                cw.WriteLine($"[DllImport(\"{DllPaksImportName}\")]");
                cw.WriteLine("#else");
                cw.WriteLine($"[DllImport(\"{DllEditorImportName}\")]");
                cw.WriteLine("#endif");
                cw.WriteLine(
                    $"private static extern {ExportVariable(method.ReturnType)} {GetCPPMethodName(method)}({param});");
                cw.WriteLine();
            }

            private static void GenerateMethodBody(CoreWriter cw, Class Class, Method method)
            {
                var inputs = method.InputTypes.Select(t => t.Name).ToList();

                var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m)));
                var name = method.UMeta.ContainsKey("DisplayName") ? method.UMeta["DisplayName"].Replace(" ", "") : method.Name;

                GenerateSummaty(cw, method.Description);

                bool haveBody = true;
                if (method.Operator != null)
                {
                    haveBody = GenerateOperatorHead(cw, method, param, inputs);
                }
                else
                {
                    inputs.Insert(0, Class.IsStructure ? "this" : "NativePointer");
                    cw.WriteLine($"public {ExportVariable(method.ReturnType)} {name}({param})");
                }

                if (haveBody)
                {
                    cw.WriteLine($"\t=> {GetCPPMethodName(method)}({string.Join(", ", inputs)});");
                }

                cw.WriteLine();
            }

            private static bool GenerateOperatorHead(CoreWriter cw, Method method, string param, IList<string> inputs)
            {
                if (method.Operator == "[]")
                {
                    cw.WriteLine($"public {ExportVariable(method.ReturnType)} this[{param}]");
                    cw.OpenBlock();
                    cw.WriteLine("get => throw new NotImplementedException();");
                    cw.WriteLine("set => throw new NotImplementedException();");
                    cw.CloseBlock();
                    return false;
                }
                else
                {
                    inputs.Insert(0, "Self");
                    cw.WriteLine(
                        $"public static {ExportVariable(method.ReturnType)} operator{method.Operator}({method.OwnerClass.Name} Self, {param})");
                }
                return true;
            }

            private static void GenerateSummaty(CoreWriter cw, string Description)
            {
                if (string.IsNullOrEmpty(Description))
                    return;

                var rows = Description.Split('\n');

                cw.WriteLine();
                cw.WriteLine("/// <summary>");

                foreach (var row in rows)
                {
                    var format = row.Trim(' ', '\t', '*', '/', '\\', '\n', '\r');

                    if (format != "")
                        cw.WriteLine("/// " + format);
                }

                cw.WriteLine("/// </summary>");
            }

            private static void GenerateClassUtilitesButtom(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                }
                else
                {
                    cw.WriteLine($"public static explicit operator IntPtr({Class.Name} Self)");
                    cw.OpenBlock();
                    cw.WriteLine("return Self.NativePointer;");
                    cw.CloseBlock();
                    cw.WriteLine();

                    cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress);");
                    cw.CloseBlock();
                }
            }

            private static string ExportVariable(Variable variable, bool IncludeDefault = true)
            {
                var result = variable.GetTypeCS();

                if (!string.IsNullOrEmpty(variable.Name))
                {
                    var name = variable.UMeta.ContainsKey("DisplayName") ? variable.UMeta["DisplayName"].Replace(" ", "") : variable.Name;
                    result += " " + name;

                    if (IncludeDefault)
                    {
                        var val = ValidateDefaultValue(variable.Default);
                        if (val != null)
                            result += " = " + val;
                    }
                }

                return result;
            }

            private static string ValidateDefaultValue(string value)
            {
                if (bool.TryParse(value, out var _r1))
                    return value;

                if (int.TryParse(value, out var _r3))
                    return value;

                if (float.TryParse(value, out var _r2))
                    return value;

                if (value == "nullptr" || value == "NULL")
                    return "null";

                return null;
            }
        }
    }
}