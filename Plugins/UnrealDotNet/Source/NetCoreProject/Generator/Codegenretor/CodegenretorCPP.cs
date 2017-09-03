using Generator.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CPP
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                var OutputPriveteGen = Path.Combine(OutputDir, "Private", "Generate");
                var OutputPublicGet = Path.Combine(OutputDir, "Public", "Generate");

                var OutputPriveteExport = Path.Combine(OutputPriveteGen, "Export");
                var OutputPriveteManage = Path.Combine(OutputPriveteGen, "Manage");
                var OutputPublicManage = Path.Combine(OutputPublicGet, "Manage");

                Directory.GetFiles(OutputPriveteGen, "*.h", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
                Directory.GetFiles(OutputPublicGet, "*.cpp", SearchOption.AllDirectories).ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes.Where(c => !c.IsStructure))
                {
                    GenerateClass(cl, Path.Combine(OutputPriveteExport, cl.Name));
                }

                GenerateStructs(domain.Classes.Where(c => c.IsStructure), Path.Combine(OutputPriveteExport, "Structures"));
                GenerateCPPIndex(domain.Classes.Where(c => !c.IsStructure), Path.Combine(OutputPriveteExport, "Index"));

                foreach (var cl in domain.Classes.Where(c => !c.IsStructure && !c.IsFinal))
                {
                    GenerateManageClassH(cl, OutputPublicManage);
                    GenerateManageClassCPP(cl, OutputPriveteManage);
                }
            }

            #region Class

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreMinimal.h\"");
                cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");

                if (!Class.IsFinal)
                {
                    GenerateProtctedWrap(cw, Class);
                }

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                {
                    GenerateProperty(cw, Class, prop);
                }

                foreach (var method in Class.Methods)
                {
                    GenerateMethod(cw, method);
                }

                if (Class.Name == "UObject")
                {
                    foreach (var cl in Class.Domain.Classes.Where(cl => cl.UMeta.ContainsKey("BlueprintSpawnableComponent")))
                    {
                        GenereteSubobjectUtilitsMethods(cw, cl);
                    }
                }

                cw.CloseBlock();
                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateManageClassH(Class Class, string OutputPath)
            {
                var methods = Filter.GetVirtualMethods(Class);

                if (!methods.Any())
                    return;

                var liter = Class.Name.First();
                var baseName = Class.Name.Substring(1);

                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreShell.h\"");
                cw.WriteLine($"#include \"Manage{baseName}.generated.h\"");
                cw.WriteLine();

                cw.WriteLine("UCLASS()");
                cw.WriteLine($"class {CPP_API_UE} {liter}Manage{baseName} : public {Class.Name}");
                cw.OpenBlock();

                cw.WriteLine("GENERATED_BODY()");
                cw.WriteLine();
                cw.WriteLine("bool bIsManageAttach = false;");
                cw.WriteLine();

                cw.WriteLine("public:");
                cw.WriteLine("UPROPERTY(EditDefaultsOnly, Category = \"C#\")");
                cw.WriteLine("FDotnetTypeName ManageClassName;");
                cw.WriteLine();

                var publicM = methods.Where(m => m.AccessModifier == AccessModifier.Public);
                var protectedM = methods.Where(m => m.AccessModifier == AccessModifier.Protected);

                if (publicM.Any())
                {
                    cw.WriteLine();
                    cw.WriteLineNoTab("public:");
                    cw.WriteLine();
                    publicM.ForEach(m => GenerateManageMethodHead(cw, m));
                }

                if (protectedM.Any())
                {
                    cw.WriteLineNoTab("protected:");
                    cw.WriteLine();
                    protectedM.ForEach(m => GenerateManageMethodHead(cw, m));
                }

                cw.CloseBlock();
                cw.Write(";");
                cw.WriteLine();

                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(Path.Combine(OutputPath, "Manage" + baseName + ".h"));
            }

            private static void GenerateManageClassCPP(Class Class, string OutputPath)
            {
                var methods = Filter.GetVirtualMethods(Class);

                if (!methods.Any())
                    return;

                var baseName = Class.Name.Substring(1);

                var cw = new CoreWriter();

                cw.WriteLine($"#include \"{CPP_PCH}.h\"");
                cw.WriteLine($"#include \"Generate/Manage/Manage{baseName}.h\"");
                cw.WriteLine();
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();

                methods.ForEach(m => GenerateManageMethod(cw, m));

                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(Path.Combine(OutputPath, "Manage" + baseName + ".cpp"));
            }

            private static void GenerateManageMethodHead(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCPPOgiginal()));

                cw.WriteLine($"virtual {method.ReturnType.GetTypeCPPOgiginal()} {method.Name}({param}) override;");
                cw.WriteLine();
            }

            private static void GenerateManageMethod(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCPPOgiginal()));
                var call = string.Join(", ", method.InputTypes.Select(v => v.Name));
                var callInObject = string.IsNullOrEmpty(call) ? call : ", " + call;

                var liter = method.OwnerClass.Name.First();
                var baseName = method.OwnerClass.Name.Substring(1);

                cw.WriteLine($"{method.ReturnType.GetTypeCPPOgiginal()} {liter}Manage{baseName}::{method.Name}({param})");
                cw.OpenBlock();

                if (method.Name == "BeginPlay")
                {
                    cw.WriteLine("if (!ManageClassName.FullName.IsEmpty())");
                    cw.OpenBlock();
                    cw.WriteLine("bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>(\"UnrealEngine.NativeManager\", \"AddWrapper\", this, TCHAR_TO_UTF8(*ManageClassName.FullName));");
                    cw.CloseBlock();
                    cw.WriteLine();
                    cw.WriteLine($"if(bIsManageAttach) UCoreShell::InvokeInObject(this, \"{method.Name}\"{callInObject});");
                }

                cw.WriteLine($"Super::{method.Name}({call});");     // todo: убрать это отсюда и вызывать из управляемого кода

                if (method.Name != "BeginPlay")
                {
                    if (method.ReturnType.Type != "void")
                        cw.Write("return ");

                    cw.WriteLine(
                        $"if(bIsManageAttach) UCoreShell::InvokeInObject(this, \"{method.Name}\"{callInObject});");
                }

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateProtctedWrap(CoreWriter cw, Class Class)
            {
                var methods = Class.Methods.Where(m => m.AccessModifier == AccessModifier.Protected);

                if (!methods.Any() || Class.IsFinal)
                    return;

                cw.WriteLine();
                cw.WriteLine($"class {ExportProtectedPrefix}{Class.Name} : protected {Class.Name}");
                cw.OpenBlock();
                cw.WriteLineNoTab("public:");

                foreach (var mt in methods)
                {
                    GenerateMethodProtctedWrap(cw, mt);
                }

                cw.CloseBlock();
                cw.Write(";");
                cw.WriteLine();
            }

            private static string GetSourceFileName(Class Class)
            {
                var index = Class.SourceFile.IndexOf(EnginePathSeg, StringComparison.Ordinal);
                var SourceFile = index == -1
                    ? Class.SourceFile
                    : Class.SourceFile.Substring(index + EnginePathSeg.Length + 1);

                SourceFile = SourceFile.Replace("\\", "/");
                return SourceFile;
            }

            private static void GenerateMethod(CoreWriter cw, Method method)
            {
                if (method.OwnerClass.IsFinal && method.AccessModifier != AccessModifier.Public)
                    return;

                var genStringWrap = method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName" ||
                                    method.ReturnType.Type == "FString";

                var inputs = method.InputTypes.Select(ExportVariableCPP).ToList();
                inputs.Insert(0, "INT_PTR Self");

                if (genStringWrap)
                {
                    inputs.Add("int& ResultStringLen");
                }

                var param = string.Join(", ", inputs);

                cw.WriteLine($"{CPP_API} {ExportVariableCPP(method.ReturnType)} {GetCPPMethodName(method)}({param})");
                cw.OpenBlock();

                for (var i = 0; i < method.InputTypes.Count; i++)
                {
                    var m = method.InputTypes[i];
                    cw.WriteLine($"auto _p{i} = {VarNameForCall(m)};");
                }

                if (method.ReturnType.Type != "void")
                {
                    cw.Write(genStringWrap ? "auto _result = " : "return ");
                }

                var bCloseCount = 0;
                var retClass = method.ReturnType as ClassVariable;
                if (retClass != null && retClass.ClassType.IsStructure)
                {
                    cw.Write($"(INT_PTR) new {retClass.ClassType.Name}(");
                    bCloseCount++;
                }

                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i =>
                {
                    if (method.InputTypes[i].NeedRefOperator())
                        return "&_p" + i;
                    return "_p" + i;
                }));

                cw.Write(method.AccessModifier == AccessModifier.Public
                    ? $"(({method.OwnerClass.Name}*)Self)->{method.Name}({call})"
                    : $"(({ExportProtectedPrefix}{method.OwnerClass.Name}*)Self)->{method.Name}{ExportProtectedPostfix}({call})");

                if (method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName")
                {
                    cw.Write(".ToString()");
                }

                cw.Write(new string(')', bCloseCount));
                cw.WriteLine(";");

                if (genStringWrap)
                {
                    cw.WriteLine("ResultStringLen = _result.Len();");
                    cw.WriteLine("return TCHAR_TO_UTF8(*_result);");
                }

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenereteSubobjectUtilitsMethods(CoreWriter cw, Class Class)
            {
                cw.WriteLine(
                    $"{CPP_API} INT_PTR {ExportPrefix}CreateOptionalDefaultSubobject_{Class.Name}(INT_PTR Self, char* Name)");
                cw.OpenBlock();

                cw.WriteLine(
                    $"return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class {Class.Name}>(FName(UTF8_TO_TCHAR(Name)));");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateMethodProtctedWrap(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCPPOgiginal()));

                cw.WriteLine(
                    $"{method.ReturnType.GetTypeCPPOgiginal()} {method.Name}{ExportProtectedPostfix}({param})");
                cw.OpenBlock();

                cw.Write(method.ReturnType.Type != "void", "return ");

                cw.Write($"{method.Name}({string.Join(", ", method.InputTypes.Select(p => p.Name))})");
                cw.WriteLine(";");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static string VarNameForCall(Variable variable)
            {
                var varClass = variable as ClassVariable;
                if (varClass != null)
                {
                    if (!varClass.ClassType.IsStructure)
                        return varClass.Name;

                    return $"*({varClass.ClassType.Name}*){varClass.Name}";
                }

                var result = "";
                var bCloseCount = 1;

                switch (variable.Type)
                {
                    case "TCHAR":
                        result += "UTF8_TO_TCHAR(";
                        break;

                    case "FString":
                        result += "FString(";
                        break;

                    case "FName":
                        result += "FName(UTF8_TO_TCHAR(";
                        bCloseCount = 2;
                        break;

                    case "FText":
                        result += "FText::FromString(FString(";
                        bCloseCount = 2;
                        break;

                    default:
                        bCloseCount = 0;
                        break;
                }

                result += variable.Name;
                result += new string(')', bCloseCount);

                return result;
            }

            #endregion Class

            #region Struct

            private static void GenerateStructs(IEnumerable<Class> Structures, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreMinimal.h\"");

                foreach (var header in Structures.Select(GetSourceFileName).Distinct())
                {
                    cw.WriteLine($"#include \"{header}\"");
                }

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var Class in Structures)
                {
                    cw.WriteLine();
                    cw.WriteLine($"/*\t{Class.Name}\t*/");
                    cw.WriteLine();

                    GenerateStructUtilites(cw, Class);

                    foreach (var method in Class.Methods.Where(m => m.AccessModifier == AccessModifier.Public))
                    {
                        GenerateMethod(cw, method);
                    }
                }

                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateStructUtilites(CoreWriter cw, Class Class)
            {
                cw.Write($"{CPP_API} INT_PTR E_CreateStruct_{Class.Name}() {{ ");
                cw.WriteLine($"return (INT_PTR) new {Class.Name}(); }}");
                cw.WriteLine();

                foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                {
                    GenerateProperty(cw, Class, prop);
                }
            }

            private static void GenerateProperty(CoreWriter cw, Class Class, Variable prop)
            {
                var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                var propClass = prop as ClassVariable;
                if (propClass?.ClassType.IsStructure == true)
                {
                    var clName = propClass.ClassType.Name;
                    cw.WriteLine(
                        $"{CPP_API} {prop.GetTypeCPP()} {baseName}_GET(INT_PTR Ptr) {{ return (INT_PTR)&(({Class.Name}*)Ptr)->{prop.Name}; }}");

                    if (!prop.IsReadOnly())
                    {
                        cw.WriteLine(
                            $"{CPP_API} void {baseName}_SET(INT_PTR Ptr, {prop.GetTypeCPP()} Value) {{ (({Class.Name}*)Ptr)->{prop.Name} = *({clName}*)Value; }}");
                    }
                }
                else
                {
                    if (prop.Type == "FText" || prop.Type == "FName" || prop.Type == "FString")
                    {
                        cw.WriteLine($"{CPP_API} char* {baseName}_GET(INT_PTR Ptr, int& ResultStringLen)");
                        cw.OpenBlock();

                        cw.WriteLine(prop.Type == "FString"
                            ? $"auto _result = (({Class.Name}*)Ptr)->{prop.Name};"
                            : $"auto _result = (({Class.Name}*)Ptr)->{prop.Name}.ToString();");

                        cw.WriteLine("ResultStringLen = _result.Len();");
                        cw.WriteLine("return TCHAR_TO_UTF8(*_result);");
                        cw.CloseBlock();

                        if (!prop.IsReadOnly())
                        {
                            cw.Write(
                                $"\t{CPP_API} void {baseName}_SET(INT_PTR Ptr, {prop.GetTypeCPP()} Value) {{ (({Class.Name}*)Ptr)->{prop.Name} = ");
                            switch (prop.Type)
                            {
                                case "FText":
                                    cw.Write("FText::FromString(UTF8_TO_TCHAR(Value))");
                                    break;

                                case "FName":
                                    cw.Write("FName(UTF8_TO_TCHAR(Value))");
                                    break;

                                case "FString":
                                    cw.Write("UTF8_TO_TCHAR(Value)");
                                    break;
                            }

                            cw.WriteLine("; }");
                        }
                    }
                    else
                    {
                        cw.WriteLine(
                            $"{CPP_API} {prop.GetTypeCPP()} {baseName}_GET(INT_PTR Ptr) {{ return (({Class.Name}*)Ptr)->{prop.Name}; }}");

                        if (!prop.IsReadOnly())
                        {
                            cw.WriteLine(
                                $"{CPP_API} void {baseName}_SET(INT_PTR Ptr, {prop.GetTypeCPP()} Value) {{ (({Class.Name}*)Ptr)->{prop.Name} = Value; }}");
                        }
                    }
                }

                cw.WriteLine();
            }

            #endregion Struct

            private static void GenerateCPPIndex(IEnumerable<Class> Classes, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"Structures.h\"");

                foreach (var Class in Classes)
                {
                    cw.WriteLine($"#include \"{Class.Name}.h\"");
                }

                cw.WriteLine();
                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(OutputPath + ".h");
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
}