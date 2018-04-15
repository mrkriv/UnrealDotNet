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
        private class Cpp
        {
            public static void GenarateDomain(Domain domain, string outputDir)
            {
                outputDir = new DirectoryInfo(outputDir).FullName;
                
                var outputPriveteGen = Path.Combine(outputDir, "Private", "Generate");
                var outputPublicGen = Path.Combine(outputDir, "Public", "Generate");

                var outputPriveteExport = Path.Combine(outputPriveteGen, "Export");
                var outputPriveteManage = Path.Combine(outputPriveteGen, "Manage");
                var outputPublicManage = Path.Combine(outputPublicGen, "Manage");

                CreateDirectoryIfNotExist(outputPriveteGen);
                CreateDirectoryIfNotExist(outputPublicGen);
                CreateDirectoryIfNotExist(outputPriveteExport);
                CreateDirectoryIfNotExist(outputPriveteManage);
                CreateDirectoryIfNotExist(outputPublicManage);

                Directory.GetFiles(outputPriveteGen, "*.h", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
                Directory.GetFiles(outputPublicGen, "*.cpp", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
                
                foreach (var cl in domain.Classes.Where(c => !c.IsStructure))
                {
                    GenerateClass(cl, Path.Combine(outputPriveteExport, cl.Name));
                }

                GenerateStructs(domain.Classes.Where(c => c.IsStructure), Path.Combine(outputPriveteExport, "Structures"));
                GenerateCppIndex(domain.Classes.Where(c => !c.IsStructure), Path.Combine(outputPriveteExport, "Index"));

                foreach (var cl in domain.Classes.Where(Filter.IsManageClass))
                {
                    GenerateManageClassH(cl, outputPublicManage);
                    GenerateManageClassCpp(cl, outputPriveteManage);
                }

                GenerateManageEventSender(domain.Delegates, Path.Combine(outputPublicGen, "ManageEventSender"));
            }

            private static void CreateDirectoryIfNotExist(string path)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            #region Class

            private static void GenerateClass(Class Class, string outputPath)
            {
                var cw = new CodeWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreMinimal.h\"");
                cw.WriteLine("#include \"ManagerObject.h\"");
                cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
                cw.WriteLine();

                GenerateSourceInfo(cw, Class);

                if (!Class.IsFinal)
                {
                    GenerateProtctedWrap(cw, Class);
                }

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

                cw.SaveToFile(outputPath + ".h");
            }

            private static void GenerateManageClassH(Class Class, string outputPath)
            {
                var methods = Filter.GetVirtualMethods(Class).ToList();

                var liter = Class.Name.First();
                var baseName = Class.Name.Substring(1);

                var cw = new CodeWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreShell.h\"");
                cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
                cw.WriteLine($"#include \"Manage{baseName}.generated.h\"");
                cw.WriteLine();

                GenerateSourceInfo(cw, Class);

                cw.WriteLine("UCLASS()");
                cw.WriteLine($"class {CppApiUe} {liter}Manage{baseName} : public {Class.Name}");
                cw.OpenBlock();

                cw.WriteLine("GENERATED_BODY()");
                cw.WriteLine();
                cw.WriteLine("bool bIsManageAttach = false;");
                cw.WriteLine();

                cw.WriteLine("public:");
                cw.WriteLine("UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = \"C#\")");
                cw.WriteLine("FDotnetTypeName ManageClassName;");
                cw.WriteLine();

                var publicM = methods.Where(m => m.AccessModifier == AccessModifier.Public).ToList();
                var protectedM = methods.Where(m => m.AccessModifier == AccessModifier.Protected).ToList();

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

                cw.SaveToFile(Path.Combine(outputPath, "Manage" + baseName + ".h"));
            }

            private static void GenerateManageClassCpp(Class Class, string outputPath)
            {
                var methods = Filter.GetVirtualMethods(Class);

                var baseName = Class.Name.Substring(1);

                var cw = new CodeWriter();

                cw.WriteLine($"#include \"{CppPch}.h\"");
                cw.WriteLine($"#include \"DotnetTypeName.h\"");
                cw.WriteLine($"#include \"Generate/Manage/Manage{baseName}.h\"");
                cw.WriteLine();
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();

                GenerateSourceInfo(cw, Class);

                methods.ForEach(m => GenerateManageMethod(cw, m));

                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(Path.Combine(outputPath, "Manage" + baseName + ".cpp"));
            }

            private static void GenerateManageMethodHead(CodeWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));

                cw.WriteLine($"virtual {method.ReturnType.GetTypeCppOgiginal()} {method.Name}({param}) override;");
                cw.WriteLine();
            }

            private static void GenerateManageMethod(CodeWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));
                var call = string.Join(", ", method.InputTypes.Select(v => v.Name));
                var callInObject = string.IsNullOrEmpty(call) ? call : ", " + call;

                var liter = method.OwnerClass.Name.First();
                var baseName = method.OwnerClass.Name.Substring(1);

                cw.WriteLine($"{method.ReturnType.GetTypeCppOgiginal()} {liter}Manage{baseName}::{method.Name}({param})");
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

            private static void GenerateProtctedWrap(CodeWriter cw, Class Class)
            {
                var methods = Class.Methods.Where(m => m.AccessModifier == AccessModifier.Protected).ToList();

                if (!methods.Any() || Class.IsFinal)
                    return;

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
                cw.WriteLine();
            }

            private static void GenegateNewObjectMethod(CodeWriter cw, Class Class)
            {
                cw.WriteLine();
                cw.WriteLine($"{CppApi} INT_PTR {ExportPrefix}NewObject_{Class.Name}(UObject* Parent, char* Name)");
                cw.OpenBlock();
                cw.WriteLine($"return (INT_PTR)NewObject<{Class.Name}>(Parent, FName(UTF8_TO_TCHAR(Name)));");
                cw.CloseBlock();
                cw.WriteLine();
            }
            private static void GenerateMethod(CodeWriter cw, Method method)
            {
                if (method.OwnerClass.IsFinal && method.AccessModifier != AccessModifier.Public)
                    return;

                var param = GetMethodSignatuteParam(method);
                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i => "_p" + i));

                cw.WriteLine($"{CppApi} auto {GetCppMethodName(method)}({param})");
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
                var inputs = method.InputTypes.Select(ExportVariableCpp).ToList();
                inputs.Insert(0, $"{method.OwnerClass.Name}* Self");

                return string.Join(", ", inputs);
            }

            private static void GenerateMethodProtctedWrap(CodeWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));

                cw.WriteLine(
                    $"{method.ReturnType.GetTypeCppOgiginal()} {method.Name}{ExportProtectedPostfix}({param})");
                cw.OpenBlock();

                cw.Write(method.ReturnType.Type.Name != "void", "return ");

                cw.Write($"{method.Name}({string.Join(", ", method.InputTypes.Select(p => p.Name))})");
                cw.WriteLine(";");

                cw.CloseBlock();
                cw.WriteLine();
            }

            #endregion Class

            #region Struct

            private static void GenerateStructs(IEnumerable<Class> structures, string outputPath)
            {
                structures = structures.ToList();
                
                var cw = new CodeWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine("#include \"CoreMinimal.h\"");

                foreach (var header in structures.Select(GetSourceFileName).Distinct())
                {
                    cw.WriteLine($"#include \"{header}\"");
                }

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var Class in structures)
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

                cw.SaveToFile(outputPath + ".h");
            }

            private static void GenerateStructUtilites(CodeWriter cw, Class Class)
            {
                GenerateStructConstructors(cw, Class);

                foreach (var prop in Class.Property)
                {
                    GenerateProperty(cw, Class, prop);
                }
            }

            private static void GenerateStructConstructors(CodeWriter cw, Class Class)
            {
                foreach (var ctr in Class.Constructors)
                {
                    var param = string.Join(", ", ctr.InputTypes.Select(ExportVariableCpp));
                    var call = string.Join(", ", ctr.InputTypes.Select(x => GenerateGet(x)));

                    var ctrFullName = GetExportConstructorFullName(ctr);

                    cw.Write($"{CppApi} INT_PTR {ctrFullName}({param}) {{ ");
                    cw.WriteLine($"return (INT_PTR) new {Class.Name}({call}); }}");
                    cw.WriteLine();
                }
            }

            private static void GenerateProperty(CodeWriter cw, Class Class, Variable prop)
            {
                if (prop.IsStatic)
                {
                    GeneratePropertyStatic(cw, Class, prop);
                }
                else if (prop is DelegateVariable)
                {
                    GeneratePropertyDelegate(cw, Class, prop);
                }
                else
                {
                    GeneratePropertyStandart(cw, Class, prop);
                }
            }

            private static void GeneratePropertyStatic(CodeWriter cw, Class Class, Variable prop)
            {
                var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                cw.WriteLine(
                    $"{CppApi} auto {baseName}{EventPropertyGetPostfix}() {{ {GenerateReturn(prop.Type, $"{Class.Name}::{prop.Name}", true)} }}");
                
                cw.WriteLine();
            }

            private static void GeneratePropertyStandart(CodeWriter cw, Class Class, Variable prop)
            {
                var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                cw.WriteLine(
                    $"{CppApi} auto {baseName}{EventPropertyGetPostfix}({Class.Name}* Ptr) {{ {GenerateReturn(prop.Type, $"Ptr->{prop.Name}", true)} }}");

                if (!prop.IsReadOnly())
                {
                    cw.WriteLine(
                        $"{CppApi} void {baseName}{EventPropertySetPostfix}({Class.Name}* Ptr, {prop.GetTypeCpp()} Value) {{ Ptr->{prop.Name} = {GenerateGet(prop, "Value")}; }}");
                }

                cw.WriteLine();
            }

            #endregion Struct

            #region Delegate

            private static void GeneratePropertyDelegate(CodeWriter cw, Class Class, Variable prop)
            {
                var name = prop.GetDisplayName();

                cw.WriteLine($"{CppApi} void {ExportEventAddPrefix}{Class.Name}_{name}({Class.Name}* Obj)");
                cw.OpenBlock();

                cw.WriteLine($"auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());");
                cw.WriteLine($"wrapper->ManageDelegateName = \"{EventInvokePrefix}{prop.Name}\";");
                cw.WriteLine($"wrapper->SourceObject = Obj;");

                cw.WriteLine($"Obj->{prop.Name}.AddDynamic(wrapper, &UManageEventSender::Wrapper_{prop.Type.Name});");

                cw.CloseBlock();
                cw.WriteLine();

                cw.WriteLine($"{CppApi} void {ExportEventRemovePrefix}{Class.Name}_{name}({Class.Name}* Obj)");
                cw.OpenBlock();

                // todo: реализовать отписку

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateManageEventSender(IEnumerable<Delegate> delegates, string outputPath)
            {
                var cw = new CodeWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine("#include \"TypeConvertor.h\"");
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

                foreach (var dlg in delegates)
                {
                    GenerateDelegateSender(dlg, cw);
                }

                cw.CloseBlock();
                cw.WriteLine(";");

                cw.SaveToFile(outputPath + ".h");
            }

            private static void GenerateDelegateSender(Delegate dlg, CodeWriter cw)
            {
                var param = string.Join(", ", dlg.Parametrs.Select(x => x.GetTypeCppOgiginal()));
                var signature = string.Join(", ", dlg.Parametrs.Select(GetTypeForManageInvoke));
                
                if (signature.Any())
                    signature = $"<{signature}>";

                var call = string.Join(", ", Enumerable.Range(0, dlg.Parametrs.Count).Select(i => "_p" + i));

                if (call.Any())
                    call = ", " + call;

                cw.WriteLine($"UFUNCTION()");
                cw.WriteLine($"void Wrapper_{dlg.Name}({param})");
                cw.OpenBlock();

                for (var i = 0; i < dlg.Parametrs.Count; i++)
                {
                    var m = dlg.Parametrs[i];
                    cw.WriteLine($"auto _p{i} = {GenerateGetForManageInvoke(m)};");
                }

                cw.WriteLine($"UCoreShell::InvokeEventInObject{signature}(SourceObject, ManageDelegateName{call});");
                cw.CloseBlock();
                cw.WriteLine();
            }

            #endregion

            private static string GetTypeForManageInvoke(Variable variable)
            {
                if (Filter.GetConvertToManageType(variable.Type, out var toType))
                {
                    return toType;
                }

                return variable.GetTypeCppOgiginal(true);
            }

            private static string GenerateGetForManageInvoke(Variable variable, string manualName = null)
            {
                var result = "";
                var bCloseCount = 0;

                if (manualName == null)
                {
                    manualName = variable.Name;
                }

                if (Filter.GetConvertToManageType(variable.Type, out var toType))
                {
                    result += $"ConvertToManage_{toType}(";
                    bCloseCount++;
                }

                result += manualName;
                result += new string(')', bCloseCount);

                return result;
            }

            private static string GenerateGet(Variable variable, string manualName = null)
            {
                var result = "";
                var bCloseCount = 0;
                var type = variable.Type;

                if (manualName == null)
                {
                    manualName = variable.Name;
                }

                if ((type as Class)?.IsStructure == true)
                {
                    if (!variable.IsPointer)
                        result += "*";

                    result += $"({type.Name}*)";
                }
                else if (type.IsTemplate)
                {
                    if (!variable.IsPointer)
                        result += "*";

                    var name = variable.GetTypeCppOgiginal(true).TrimEnd('&');

                    result += $"({name}*)";
                }
                else if (Filter.IsUseConvertFromManageType(type))
                {
                    result += $"ConvertFromManage_{type}(";
                    bCloseCount++;
                }

                result += manualName;
                result += new string(')', bCloseCount);

                return result;
            }

            private static string GenerateReturn(Type type, string expression, bool forProperty)
            {
                if (type.IsVoid)
                {
                    return expression + ";";
                }

                var result = "return ";
                var bCloseCount = 0;

                if ((type as Class)?.IsStructure == true)
                {
                    if (forProperty)
                        result += $"(INT_PTR)&(";
                    else
                        result += $"(INT_PTR) new {type.Name}(";

                    bCloseCount++;
                }
                //else if (type.IsTemplate)
                //{
                //    // todo: 
                //}
                else if (Filter.GetConvertToManageType(type, out var toType))
                {
                    result += $"ConvertToManage_{toType}(";
                    bCloseCount++;
                }

                result += expression;
                result += new string(')', bCloseCount);
                result += ";";

                return result;
            }

            private static string GetSourceFileName(Class Class)
            {
                var index = Class.SourceFile.IndexOf(EnginePathSeg, StringComparison.Ordinal);
                var sourceFile = index == -1
                    ? Class.SourceFile
                    : Class.SourceFile.Substring(index + EnginePathSeg.Length + 1);

                sourceFile = sourceFile.Replace("\\", "/");
                return sourceFile;
            }
            
            private static void GenerateCppIndex(IEnumerable<Class> classes, string outputPath)
            {
                var cw = new CodeWriter();
                cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
                cw.WriteLine();
                cw.WriteLine("#include \"Structures.h\"");

                foreach (var Class in classes)
                {
                    cw.WriteLine($"#include \"{Class.Name}.h\"");
                }

                cw.WriteLine();
                cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

                cw.SaveToFile(outputPath + ".h");
            }

            private static string ExportVariableCpp(Variable variable)
            {
                var result = variable.GetTypeCpp();

                if (!string.IsNullOrEmpty(variable.Name))
                    result += " " + variable.Name;

                return result;
            }
        }
    }
}