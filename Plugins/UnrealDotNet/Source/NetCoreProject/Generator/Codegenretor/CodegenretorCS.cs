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
                Directory.GetFiles(OutputDir, "*.cs", SearchOption.AllDirectories).ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes)
                {
                    var subdir = cl.IsStructure ? "Struct" : "Class";
                    GenerateClass(cl, Path.Combine(OutputDir, subdir, cl.Name));
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

                cw.Write($"public partial class {Class.Name}");

                if (Class.BaseClass != null)
                    cw.Write($" : {Class.BaseClass.Name}");

                cw.WriteLine();
                cw.OpenBlock();

                GenerateClassUtilitesTop(cw, Class);

                var cw_DllImport = new CoreWriter(cw);
                var cw_ExternMethods = new CoreWriter(cw);
                var cw_Property = new CoreWriter(cw);

                GenerateClassDLLImport(cw_DllImport, Class);
                Class.Property.ForEach(p => GenerateProperty(cw_Property, Class, p));

                foreach (var method in Class.Methods)
                {
                    GenerateMethodDLLImport(cw_DllImport, Class, method);
                    GenerateMethodBody(cw_ExternMethods, Class, method);
                }

                if (Class.Name == "UObject")
                {
                    foreach (var cl in Class.Domain.Classes.Where(cl => cl.IsChild("UPrimitiveComponent")))
                    {
                        GenereteSubobjectUtilitsDLL(cw_DllImport, cl);
                        GenereteSubobjectUtilitsMethods(cw_ExternMethods, cl);
                    }
                }

                cw.WriteLine();

                if (!cw_DllImport.IsEmpty())
                {
                    cw.WriteLine("#region DLLInmport");
                    cw.Write(cw_DllImport);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                if (!cw_Property.IsEmpty())
                {
                    cw.WriteLine("#region Property");
                    cw.Write(cw_Property);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                if (!cw_ExternMethods.IsEmpty())
                {
                    cw.WriteLine("#region ExternMethods");
                    cw.Write(cw_ExternMethods);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                GenerateClassUtilitesButtom(cw, Class);

                cw.CloseBlock();
                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".cs");
            }

            private static void GenerateProperty(CoreWriter cw, Class Class, Variable prop)
            {
                if (Class.IsStructure && prop.AccessModifier != AccessModifier.Public)
                    return;

                GenerateSummaty(cw, prop.Description);
                cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} {ExportVariable(prop, false)}");
                cw.OpenBlock();

                cw.WriteLine($"get => {ExportPropertyPrefix}{Class.Name}_{prop.Name}_GET(NativePointer);");
                cw.WriteLine($"set => {ExportPropertyPrefix}{Class.Name}_{prop.Name}_SET(NativePointer, value);");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateClassUtilitesTop(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                    cw.WriteLine("private readonly IntPtr NativePointer;");
                    cw.WriteLine("private readonly bool IsRef;");
                    cw.WriteLine();
                    cw.WriteLine($"public {Class.Name}()");
                    cw.OpenBlock();
                    cw.WriteLine($"NativePointer = E_CreateStruct_{Class.Name}();");
                    cw.WriteLine("IsRef = false;");
                    cw.CloseBlock();
                    cw.WriteLine();
                    cw.WriteLine($"internal {Class.Name}(IntPtr NativePointer, bool IsRef)");
                    cw.OpenBlock();
                    cw.WriteLine("this.NativePointer = NativePointer;");
                    cw.WriteLine("this.IsRef = IsRef;");
                    cw.CloseBlock();
                    cw.WriteLine();
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

            private static void GenerateClassDLLImport(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern IntPtr E_CreateStruct_{Class.Name}();");
                    cw.WriteLine();

                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern void E_DeleteStruct(IntPtr Adress);");
                    cw.WriteLine();
                }
                else
                {
                }

                foreach (var prop in Class.Property.Where(p => !p.IsConst))
                {
                    var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern {prop.GetTypeCS()} {baseName}_GET(IntPtr Ptr);");

                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern void {baseName}_SET(IntPtr Ptr, {prop.GetTypeCS()} Value);");

                    cw.WriteLine();
                }
            }

            private static void GenerateMethodDLLImport(CoreWriter cw, Class Class, Method method)
            {
                if (Class.IsStructure && method.AccessModifier != AccessModifier.Public)
                    return;

                var genStringWrap = method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName" ||
                                    method.ReturnType.Type == "FString";

                var inputs = method.InputTypes.Select(m => ExportVariable(m, false, true)).ToList();
                inputs.Insert(0, (Class.IsStructure ? Class.Name : "IntPtr") + " Self");

                if (genStringWrap)
                    inputs.Add("out int ResultStringLen");

                var param = string.Join(", ", inputs);
                var ret = genStringWrap ? "IntPtr" : ExportVariable(method.ReturnType, false, true);

                WriteDLLImport(cw);
                cw.WriteLine(
                    $"private static extern {ret} {GetCPPMethodName(method)}({param});");
                cw.WriteLine();
            }

            private static void WriteDLLImport(CoreWriter cw)
            {
                cw.WriteLine(
                    "[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]");
            }

            private static void GenerateMethodBody(CoreWriter cw, Class Class, Method method)
            {
                if (Class.IsStructure && method.AccessModifier != AccessModifier.Public)
                    return;

                var genStringWrap = method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName" ||
                                    method.ReturnType.Type == "FString";

                var inputs = method.InputTypes.Select(t => t.Name).ToList();

                var genDefault = ValidateDefaultValue(method.InputTypes.LastOrDefault()?.Default) != null;
                var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, genDefault)));
                var name = GetMethodDisplayName(method);

                GenerateSummaty(cw, method.Description);
                cw.Write(method.AccessModifier.ToString().ToLower() + " ");

                if (method.Name == "ToString")
                    cw.Write("override ");

                var haveBody = true;
                if (method.Operator != null)
                {
                    haveBody = GenerateOperatorHead(cw, method, param, inputs);
                }
                else
                {
                    inputs.Insert(0, Class.IsStructure ? "this" : "NativePointer");
                    cw.WriteLine($"{ExportVariable(method.ReturnType)} {name}({param})");
                }

                if (haveBody)
                {
                    if (genStringWrap)
                    {
                        inputs.Add("out int ResultStringLen");
                        cw.WriteLine(
                            $"\t=> Marshal.PtrToStringUTF8({GetCPPMethodName(method)}({string.Join(", ", inputs)}), ResultStringLen);");
                    }
                    else
                    {
                        cw.WriteLine($"\t=> {GetCPPMethodName(method)}({string.Join(", ", inputs)});");
                    }
                }

                cw.WriteLine();
            }

            private static string GetMethodDisplayName(Method method)
            {
                if (method.UMeta.ContainsKey("DisplayName"))
                {
                    return DisplayNameRegex.Replace(method.UMeta["DisplayName"], "");
                }
                return method.Name;
            }

            private static bool GenerateOperatorHead(CoreWriter cw, Method method, string param, IList<string> inputs)
            {
                if (method.Operator == "[]")
                {
                    cw.WriteLine($"{ExportVariable(method.ReturnType)} this[{param}]");
                    cw.OpenBlock();
                    cw.WriteLine("get => throw new NotImplementedException();");
                    cw.WriteLine("set => throw new NotImplementedException();");
                    cw.CloseBlock();
                    return false;
                }
                inputs.Insert(0, "Self");
                cw.WriteLine(
                    $"static {ExportVariable(method.ReturnType)} operator{method.Operator}({method.OwnerClass.Name} Self, {param})");
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
                cw.WriteLine($"public static implicit operator IntPtr({Class.Name} Self)");
                cw.OpenBlock();
                cw.WriteLine("return Self.NativePointer;");
                cw.CloseBlock();
                cw.WriteLine();

                if (Class.IsStructure)
                {
                    cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress, false);");
                    cw.CloseBlock();
                }
                else
                {
                    cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress);");
                    cw.CloseBlock();
                }
            }

            private static void GenereteSubobjectUtilitsDLL(CoreWriter cw, Class Class)
            {
                WriteDLLImport(cw);
                cw.WriteLine(
                    $"private static extern IntPtr {ExportPrefix}CreateOptionalDefaultSubobject_{Class.Name}(IntPtr Self, string Name);");
                cw.WriteLine();
            }

            private static void GenereteSubobjectUtilitsMethods(CoreWriter cw, Class Class)
            {
                cw.WriteLine($"public {Class.Name} CreateOptionalDefaultSubobject_{Class.Name}(string Name) ");
                cw.WriteLine($"\t=> {ExportPrefix}CreateOptionalDefaultSubobject_{Class.Name}(NativePointer, Name);");
                cw.WriteLine();
            }

            private static string ExportVariable(Variable variable, bool IncludeDefault = true, bool ForExtern = false)
            {
                var result = ForExtern ? variable.GetTypeCSForExtend() : variable.GetTypeCS();

                if (!string.IsNullOrEmpty(variable.Name))
                {
                    var name = variable.UMeta.ContainsKey("DisplayName")
                        ? variable.UMeta["DisplayName"].Replace(" ", "")
                        : variable.Name;
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
                if (bool.TryParse(value, out var _))
                    return value;

                if (int.TryParse(value, out var _))
                    return value;

                if (float.TryParse(value, out var _))
                    return value;

                if (value == "nullptr" || value == "NULL")
                    return "null";

                return null;
            }
        }
    }
}