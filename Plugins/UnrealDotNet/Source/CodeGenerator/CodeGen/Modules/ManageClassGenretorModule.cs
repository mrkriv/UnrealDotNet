using CodeGenerator.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeGenerator.CodeGen.Modules
{
    internal class ManageClassGenretorModule : CodeGenretorModule<Class>
    {
        private List<Method> _virtualMethods;

        public ManageClassGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Class> GetPrimitives(Domain domain)
        {
            return domain.Classes;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputCpp = Path.Combine(PathOutputCpp, "Manage");
            PathOutputH = Path.Combine(PathOutputH, "Manage");
            PathOutputCs = Path.Combine(PathOutputCs, "Manage");

            CreateDirectoryIfNotExist(PathOutputCpp);
            CreateDirectoryIfNotExist(PathOutputH);
            CreateDirectoryIfNotExist(PathOutputCs);
        }

        protected override bool CanGenerate(Class Class)
        {
            return Cfg.Filter.CanGenerateManageType(Class);
        }

        protected override void PreGenerate(Class Class)
        {
            var types = new List<Class>();

            while (Class != null)
            {
                types.Add(Class);
                Class = Class.BaseClass;
            }

            _virtualMethods = types.SelectMany(x => x.Methods)
                .Where(m => Cfg.Filter.CanGenerateManageOverride(m))
                .GroupBy(x => x.Name)
                .Where(x => x.All(m => !m.IsFinal))
                .Select(x => x.First())
                .ToList();
        }

        #region H

        protected override void GenerateH(Class Class)
        {
            var cw = new CodeWriter();

            cw.WriteLine("#pragma once");
            cw.WriteLine();
            GenerateFileHeader(cw);
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();
            cw.WriteLine("#include \"CoreShell.h\"");
            cw.WriteLine("#include \"IManageObject.h\"");
            cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
            cw.WriteLine($"#include \"Manage{Class.BaseName}.generated.h\"");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            var cppClassName = $"{Class.Litera}Manage{Class.BaseName}";

            cw.WriteLine("UCLASS()");
            cw.WriteLine(
                $"class {Cfg.CppApiUe} {cppClassName} : public {Class.Name}, public IManageObject");
            cw.OpenBlock();

            cw.WriteLine(Class.IsChild("AActor") ? "GENERATED_UCLASS_BODY()" : "GENERATED_BODY()");
            cw.WriteLine();
            cw.WriteLine("bool bIsManageAttach = false;");
            cw.WriteLine("bool AddWrapperIfNotAttach();");
            cw.WriteLine();

            cw.WriteLineNoTab("public:");
            cw.WriteLine();
            cw.WriteLine("UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = \"C#\")");
            cw.WriteLine("FDotnetTypeName ManageClassName;");
            cw.WriteLine();
            
            foreach (var method in _virtualMethods.Where(m => m.AccessModifier != AccessModifier.Private))
                GenerateManageMethodHead(cw, method);

            /*cw.WriteLine();
            cw.WriteLineNoTab("protected:");

            foreach (var method in _virtualMethods.Where(m => m.AccessModifier == AccessModifier.Protected))
                GenerateManageMethodHead(cw, method);*/

            cw.CloseBlock(";");
            cw.WriteLine();

            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputH, "Manage" + Class.BaseName + ".h"));
        }

        #endregion

        #region CS

        protected override void GenerateCs(Class Class)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine("using System;");
            cw.WriteLine("using System.Runtime.InteropServices;");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            var manageClassName = "Manage" + Class.BaseName;

            cw.WriteLine($"[ManageType(\"{manageClassName}\")]");
            cw.WriteLine($"public partial class {manageClassName} : {Class.Name}");
            cw.OpenBlock();

            cw.WriteLine($"public {manageClassName}(IntPtr adress)");
            cw.WriteLine("\t: base(adress)");
            cw.OpenBlock();
            cw.CloseBlock();
            cw.WriteLine();

            /*foreach (var method in _virtualMethods)
            {
                GenerateManageMethodCs(cw, method);
            }*/

            cw.WriteLine($"public static implicit operator IntPtr({manageClassName} self)");
            cw.OpenBlock();
            cw.WriteLine("return self?.NativePointer ?? IntPtr.Zero;");
            cw.CloseBlock();
            cw.WriteLine();
            cw.WriteLine($"public static implicit operator {manageClassName}(ObjectPointerDescription PtrDesc)");
            cw.OpenBlock();
            cw.WriteLine($"return NativeManager.GetWrapper<{manageClassName}>(PtrDesc);");
            cw.CloseBlock();

            cw.CloseBlock();
            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputCs, manageClassName + ".cs"));
        }

        private void GenerateManageMethodCs(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, false)));

            GenerateSummaty(cw, method);

            cw.Write(method.AccessModifier.ToString().ToLower() + " ");
            cw.WriteLine($"override {ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param}) {{ }}");
            // cw.WriteLine($"\t=> base.{name}({string.Join(", ", inputs)});"); // todo: доделать виртуальные методы

            cw.WriteLine();
        }

        private string ExportVariable(Variable variable, bool includeDefault = true, bool forExtern = false,
            bool forReturn = false)
        {
            var result = forExtern ? variable.GetTypeCsForExtend(forReturn) : variable.GetTypeCs();

            if (!string.IsNullOrEmpty(variable.Name))
            {
                result += " " + ToLowerCamelCase(variable.GetDisplayName());

                if (includeDefault)
                {
                    var val = ValidateDefaultValue(variable.Default);
                    if (val != null)
                        result += " = " + val;
                }
            }

            return result;
        }

        private string ValidateDefaultValue(string value)
        {
            if (bool.TryParse(value, out _))
                return value;

            if (int.TryParse(value, out _))
                return value;

            if (float.TryParse(value, out _))
                return value;

            if (value == "nullptr" || value == "NULL")
                return "null";

            return null;
        }

        #endregion

        #region CPP

        protected override void GenerateCpp(Class Class)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine($"#include \"{Cfg.CppPch}.h\"");
            cw.WriteLine($"#include \"DotnetTypeName.h\"");
            cw.WriteLine($"#include \"Generate/Manage/Manage{Class.BaseName}.h\"");
            cw.WriteLine();
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            var cppClassName = $"{Class.Litera}Manage{Class.BaseName}";

            if (Class.IsChild("AActor"))
            {
                cw.WriteLine($"{cppClassName}::{cppClassName}(const FObjectInitializer& ObjectInitializer)");
                cw.WriteLine($" : Super(ObjectInitializer)");
                cw.OpenBlock();
                cw.WriteLine(
                    "RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());");
                cw.WriteLine("RootComponent->Mobility = EComponentMobility::Movable;");
                cw.WriteLine("RootComponent->bVisualizeComponent = true;");
                cw.WriteLine();
                cw.WriteLine("AddWrapperIfNotAttach();");
                cw.CloseBlock();
                cw.WriteLine();
            }

            cw.WriteLine($"bool {cppClassName}::AddWrapperIfNotAttach()");
            cw.OpenBlock();
            cw.WriteLine("if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())");
            cw.OpenBlock();
            cw.WriteLine("auto dotnetTypeName = ManageClassName.PackJSON();");
            cw.WriteLine("auto core = UCoreShell::GetInstance();");
            cw.WriteLine();
            cw.WriteLine(
                "bIsManageAttach = core->InvokeInWrapper<bool, 0>(\"UnrealEngine.NativeManager\", \"AddWrapper\", this, TCHAR_TO_UTF8(*dotnetTypeName));");
            cw.CloseBlock();
            cw.WriteLine();
            cw.WriteLine("return bIsManageAttach;");
            cw.CloseBlock();
            cw.WriteLine();

            _virtualMethods.ForEach(m => GenerateManageMethod(cw, Class, m));

            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputCpp, "Manage" + Class.BaseName + ".cpp"));
        }

        private void GenerateManageMethodHead(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));

            cw.WriteLine($"virtual {method.ReturnType.GetTypeCppOgiginal()} {method.Name}({param}) override;");
        }

        private void GenerateManageMethod(CodeWriter cw, Class Class, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));
            var call = string.Join(", ", method.InputTypes.Select(v => v.Name));
            var callInObject = string.IsNullOrEmpty(call) ? call : ", " + call;
            var cppClassName = $"{Class.Litera}Manage{Class.BaseName}";

            cw.WriteLine(
                $"{method.ReturnType.GetTypeCppOgiginal()} {cppClassName}::{method.Name}({param})");
            cw.OpenBlock();

            cw.WriteLine($"Super::{method.Name}({call});"); // todo: убрать это отсюда и вызывать из управляемого кода

            if (method.ReturnType.Type.Name != "void")
                cw.Write("return ");

            cw.WriteLine("");
            cw.WriteLine("if(AddWrapperIfNotAttach())");
            cw.WriteLine($"\tUCoreShell::GetInstance()->InvokeInObject(this, \"{method.Name}\"{callInObject});");

            cw.CloseBlock();
            cw.WriteLine();
        }

        #endregion
    }
}