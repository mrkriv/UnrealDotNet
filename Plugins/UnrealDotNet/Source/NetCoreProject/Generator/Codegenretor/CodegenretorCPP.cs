using Generator.Metadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Delegate = Generator.Metadata.Delegate;
using Type = Generator.Metadata.Type;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CPP
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                var OutputPriveteGen = Path.Combine(OutputDir, "Private", "Generate");
                var OutputPublicGen = Path.Combine(OutputDir, "Public", "Generate");

                var OutputPriveteExport = Path.Combine(OutputPriveteGen, "Export");
                var OutputPriveteManage = Path.Combine(OutputPriveteGen, "Manage");
                var OutputPublicManage = Path.Combine(OutputPublicGen, "Manage");

                Directory.GetFiles(OutputPriveteGen, "*.h", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
                Directory.GetFiles(OutputPublicGen, "*.cpp", SearchOption.AllDirectories).ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes.Where(c => !c.IsStructure))
                {
                    GenerateClass(cl, Path.Combine(OutputPriveteExport, cl.Name));
                }

                GenerateStructs(domain.Classes.Where(c => c.IsStructure), Path.Combine(OutputPriveteExport, "Structures"));
                GenerateCPPIndex(domain.Classes.Where(c => !c.IsStructure), Path.Combine(OutputPriveteExport, "Index"));

                foreach (var cl in domain.Classes.Where(Filter.IsManageClass))
                {
                    GenerateManageClassH(cl, OutputPublicManage);
                    GenerateManageClassCPP(cl, OutputPriveteManage);
                }

                GenerateManageEventSender(domain.Delegates, Path.Combine(OutputPublicGen, "ManageEventSender"));
            }

            #region Class

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreMinimal.h\"");
                cw.WriteLine("#include \"ManagerObject.h\"");
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

                if (!Filter.NewObjectBlackList.Contains(Class.Name))
                {
                    GenegateNewObjectMethod(cw, Class);
                }

                foreach (var method in Class.Methods)
                {
                    GenerateMethod(cw, method);
                }

                cw.CloseBlock();
                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateManageClassH(Class Class, string OutputPath)
            {
                var methods = Filter.GetVirtualMethods(Class);

                var liter = Class.Name.First();
                var baseName = Class.Name.Substring(1);

                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreShell.h\"");
                cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
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
                cw.WriteLine("UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = \"C#\")");
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
                    cw.WriteLine("bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>(\"UnrealEngine.NativeManager\", \"AddWrapper\", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));");
                    cw.CloseBlock();
                    cw.WriteLine();
                    cw.WriteLine($"if(bIsManageAttach) UCoreShell::InvokeInObject(this, \"{method.Name}\"{callInObject});");
                }

                cw.WriteLine($"Super::{method.Name}({call});");     // todo: убрать это отсюда и вызывать из управляемого кода

                if (method.Name != "BeginPlay")
                {
                    if (method.ReturnType.Type.Name != "void")
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

            private static void GenegateNewObjectMethod(CoreWriter cw, Class Class)
            {
                cw.WriteLine();
                cw.WriteLine($"{CPP_API} INT_PTR {ExportPrefix}NewObject_{Class.Name}(UObject* Parent, char* Name)");
                cw.OpenBlock();
                cw.WriteLine($"return (INT_PTR)NewObject<{Class.Name}>(Parent, FName(UTF8_TO_TCHAR(Name)));");
                cw.CloseBlock();
                cw.WriteLine();
            }
            private static void GenerateMethod(CoreWriter cw, Method method)
            {
                if (method.OwnerClass.IsFinal && method.AccessModifier != AccessModifier.Public)
                    return;

                var param = GetMethodSignatuteParam(method);
                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i => "_p" + i));

                cw.WriteLine($"{CPP_API} auto {GetCPPMethodName(method)}({param})");
                cw.OpenBlock();

                for (var i = 0; i < method.InputTypes.Count; i++)
                {
                    var m = method.InputTypes[i];
                    cw.WriteLine($"auto _p{i} = {GenerateGet(m)};");
                }

                var ret = method.AccessModifier == AccessModifier.Public
                    ? $"Self->{method.Name}({call})"
                    : $"(({ExportProtectedPrefix}{method.OwnerClass.Name}*)Self)->{method.Name}{ExportProtectedPostfix}({call})";

                cw.WriteLine(GenerateReturn(method.ReturnType.Type, ret, false));

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static string GetMethodSignatuteParam(Method method)
            {
                var inputs = method.InputTypes.Select(ExportVariableCPP).ToList();
                inputs.Insert(0, $"{method.OwnerClass.Name}* Self");

                return string.Join(", ", inputs);
            }

            private static void GenerateMethodProtctedWrap(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCPPOgiginal()));

                cw.WriteLine(
                    $"{method.ReturnType.GetTypeCPPOgiginal()} {method.Name}{ExportProtectedPostfix}({param})");
                cw.OpenBlock();

                cw.Write(method.ReturnType.Type.Name != "void", "return ");

                cw.Write($"{method.Name}({string.Join(", ", method.InputTypes.Select(p => p.Name))})");
                cw.WriteLine(";");

                cw.CloseBlock();
                cw.WriteLine();
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
                GenerateStructConstructors(cw, Class);

                foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                {
                    GenerateProperty(cw, Class, prop);
                }
            }

            private static void GenerateStructConstructors(CoreWriter cw, Class Class)
            {
                foreach (var ctr in Class.Constructors)
                {
                    var param = string.Join(", ", ctr.InputTypes.Select(ExportVariableCPP));
                    var call = string.Join(", ", ctr.InputTypes.Select(x => GenerateGet(x)));

                    var ctrFullName = GetExportConstructorFullName(ctr);

                    cw.Write($"{CPP_API} INT_PTR {ctrFullName}({param}) {{ ");
                    cw.WriteLine($"return (INT_PTR) new {Class.Name}({call}); }}");
                    cw.WriteLine();
                }
            }

            private static void GenerateProperty(CoreWriter cw, Class Class, Variable prop)
            {
                if (prop is DelegateVariable)
                {
                    GeneratePropertyDelegate(cw, Class, prop);
                }
                else
                {
                    GeneratePropertyStandart(cw, Class, prop);
                }
            }

            private static void GeneratePropertyStandart(CoreWriter cw, Class Class, Variable prop)
            {
                var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                cw.WriteLine(
                    $"{CPP_API} auto {baseName}_GET({Class.Name}* Ptr) {{ {GenerateReturn(prop.Type, $"Ptr->{prop.Name}", true)} }}");

                if (!prop.IsReadOnly())
                {
                    cw.WriteLine(
                        $"{CPP_API} void {baseName}_SET({Class.Name}* Ptr, {prop.GetTypeCPP()} Value) {{ Ptr->{prop.Name} = {GenerateGet(prop, "Value")}; }}");
                }

                cw.WriteLine();
            }

            private static void GeneratePropertyDelegate(CoreWriter cw, Class Class, Variable prop)
            {
                var name = prop.GetDisplayName();

                cw.WriteLine($"{CPP_API} void {ExportEventAddPrefix}{Class.Name}_{name}({Class.Name}* Obj)");
                cw.OpenBlock();

                cw.WriteLine($"auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());");
                cw.WriteLine($"wrapper->ManageDelegateName = \"{EventInvokePrefix}{prop.Name}\";");
                cw.WriteLine($"wrapper->SourceObject = Obj;");

                cw.WriteLine($"Obj->{prop.Name}.AddDynamic(wrapper, &UManageEventSender::Wrapper_{prop.Type.Name});");

                cw.CloseBlock();
                cw.WriteLine();

                cw.WriteLine($"{CPP_API} void {ExportEventRemovePrefix}{Class.Name}_{name}({Class.Name}* Obj)");
                cw.OpenBlock();

                // todo: реализовать отписку

                cw.CloseBlock();
                cw.WriteLine();
            }

            #endregion Struct

            #region Delegate
            private static void GenerateManageEventSender(IEnumerable<Metadata.Delegate> Delegates, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreShell.h\"");
                cw.WriteLine("#include \"ManageEventSender.generated.h\"");
                cw.WriteLine();
                cw.WriteLine("UCLASS()");
                cw.WriteLine("class UNREALDOTNETRUNTIME_API UManageEventSender : public UObject");
                cw.OpenBlock();
                cw.WriteLine("GENERATED_BODY()");
                cw.WriteLine();
                cw.WriteLine("public:");
                cw.WriteLine();
                cw.WriteLine("UPROPERTY()");
                cw.WriteLine("UObject* SourceObject;");
                cw.WriteLine();
                cw.WriteLine("UPROPERTY()");
                cw.WriteLine("FString ManageDelegateName;");
                cw.WriteLine();

                foreach (var dlg in Delegates)
                {
                    GenerateDelegateSender(dlg, cw);
                }

                cw.CloseBlock();
                cw.WriteLine(";");

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateDelegateSender(Delegate dlg, CoreWriter cw)
            {
                var call = string.Join(", ", dlg.Parametrs.Select(x => x.Name));
                var param = string.Join(", ", dlg.Parametrs.Select(x => x.GetTypeCPPOgiginal()));
                var signature = string.Join(", ", dlg.Parametrs.Select(x => x.GetTypeCPPOgiginal(true)));

                if (call.Any())
                    call = ", " + call;

                if (signature.Any())
                    signature = $"<{signature}>";

                cw.WriteLine($"UFUNCTION()");
                cw.WriteLine($"void Wrapper_{dlg.Name}({param})");
                cw.OpenBlock();
                cw.WriteLine($"UCoreShell::InvokeEventInObject{signature}(SourceObject, ManageDelegateName{call});");
                cw.CloseBlock();
                cw.WriteLine();
            }

            #endregion

            private static string GenerateGet(Variable variable, string ManualName = null)
            {
                var result = "";
                var bCloseCount = 0;
                var type = variable.Type;

                if (ManualName == null)
                {
                    ManualName = variable.Name;
                }

                if ((type as Class)?.IsStructure == true)
                {
                    if (!variable.IsPointer)
                        result += "*";

                    result += $"({type.Name}*)";
                }
                else if (Filter.IsUseConvertFromManageType(type))
                {
                    result += $"ConvertFromManage_{type}(";
                    bCloseCount++;
                }

                result += ManualName;
                result += new string(')', bCloseCount);

                return result;
            }

            private static string GenerateReturn(Type type, string Expression, bool ForProperty)
            {
                if (type.IsVoid)
                {
                    return Expression + ";";
                }

                var result = "return ";
                var bCloseCount = 0;

                if ((type as Class)?.IsStructure == true)
                {
                    if (ForProperty)
                        result += $"(INT_PTR)&(";
                    else
                        result += $"(INT_PTR) new {type.Name}(";

                    bCloseCount++;
                }
                else if (Filter.GetConvertToManageType(type, out var toType))
                {
                    result += $"ConvertToManage_{toType}(";
                    bCloseCount++;
                }

                result += Expression;
                result += new string(')', bCloseCount);
                result += ";";

                return result;
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