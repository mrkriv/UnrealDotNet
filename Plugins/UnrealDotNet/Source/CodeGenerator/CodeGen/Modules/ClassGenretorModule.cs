using CodeGenerator.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeGenerator.CodeGen.Modules
{
    internal class ClassGenretorModule : CodeGenretorModule<Class>
    {
        public ClassGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Class> GetPrimitives(Domain domain)
        {
            return domain.Classes;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputH = Path.Combine(PathOutputH, "Export");
            PathOutputCs = Path.Combine(PathOutputCs, "Class");

            CreateDirectoryIfNotExist(PathOutputH);
            CreateDirectoryIfNotExist(PathOutputCs);
        }

        protected override bool CanGenerate(Class Class)
        {
            if (Class.IsStructure)
                return false;

            return true;
        }

        #region H

        protected override void GenerateH(Class Class)
        {
            var cw = new CodeWriter();

            cw.WriteLine("#pragma once");
            GenerateFileHeader(cw);
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();
            cw.WriteLine("#include \"CoreMinimal.h\"");
            cw.WriteLine("#include \"ManageEventSender.h\"");
            cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            if (!Class.IsFinal)
                GenerateProtctedWrap(cw, Class);

            cw.WriteLine("extern \"C\"");
            cw.OpenBlock();

            foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                GeneratePropertyH(cw, Class, prop);

            if (!Cfg.Filter.NewObjectBlackList.Contains(Class.Name))
            {
                GenegateNewObjectMethod(cw, Class);
            }

            foreach (var method in Class.Methods)
                GenerateMethod(cw, method);

            if (Cfg.Filter.CanGenerateManageType(Class))
            {
                foreach (var method in Class.Methods.Where(x => Cfg.Filter.CanGenerateManageOverride(x)))
                {
                    //todo::
                }
            }

            cw.CloseBlock();
            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputH, Class.Name + ".h"));
        }

        private void GeneratePropertyH(CodeWriter cw, Class Class, Variable prop)
        {
            if (prop.IsStatic)
                GeneratePropertyHStatic(cw, Class, prop);
            else if (prop is DelegateVariable)
                GeneratePropertyHDelegate(cw, Class, prop);
            else
                GeneratePropertyHStandart(cw, Class, prop);
        }

        private void GeneratePropertyHStatic(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            cw.WriteLine(
                $"{Cfg.CppApi} auto {baseName}{Cfg.EventPropertyGetPostfix}() {{ {GenerateReturn(prop, $"{Class.Name}::{prop.Name}", true)} }}");

            cw.WriteLine();
        }

        private static void GeneratePropertyHDelegate(CodeWriter cw, Class Class, Variable prop)
        {
            var name = prop.GetDisplayName();

            cw.WriteLine($"{Cfg.CppApi} void {Cfg.ExportEventAddPrefix}{Class.Name}_{name}({Class.Name}* Obj)");
            cw.OpenBlock();

            cw.WriteLine($"auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());");
            cw.WriteLine($"wrapper->ManageDelegateName = \"{Cfg.EventInvokePrefix}{prop.Name}\";");
            cw.WriteLine($"wrapper->SourceObject = Obj;");

            cw.WriteLine($"Obj->{prop.Name}.AddDynamic(wrapper, &UManageEventSender::Wrapper_{prop.Type.Name});");

            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"{Cfg.CppApi} void {Cfg.ExportEventRemovePrefix}{Class.Name}_{name}({Class.Name}* Obj)");
            cw.OpenBlock();

            // todo: реализовать отписку

            cw.CloseBlock();
            cw.WriteLine();
        }

        private void GeneratePropertyHStandart(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            cw.WriteLine(
                $"{Cfg.CppApi} auto {baseName}{Cfg.EventPropertyGetPostfix}({Class.Name}* Ptr) {{ {GenerateReturn(prop, $"Ptr->{prop.Name}", true)} }}");

            cw.WriteLine(!prop.IsReadOnly(),
                $"{Cfg.CppApi} void {baseName}{Cfg.EventPropertySetPostfix}({Class.Name}* Ptr, {prop.GetTypeCpp()} Value) {{ Ptr->{prop.Name} = {GenerateGet(prop, "Value")}; }}");

            cw.WriteLine();
        }

        private void GenerateProtctedWrap(CodeWriter cw, Class Class)
        {
            var methods = Class.Methods.Where(m => m.AccessModifier == AccessModifier.Protected).ToList();

            if (!methods.Any() || Class.IsFinal)
                return;

            cw.WriteLine($"class {Cfg.ExportProtectedPrefix}{Class.Name} : protected {Class.Name}");
            cw.OpenBlock();
            cw.WriteLineNoTab("public:");

            foreach (var mt in methods) GenerateMethodProtctedWrap(cw, mt);

            cw.CloseBlock(";");
            cw.WriteLine();
            cw.WriteLine();
        }

        private void GenegateNewObjectMethod(CodeWriter cw, Class Class)
        {
            cw.WriteLine();
            cw.WriteLine($"{Cfg.CppApi} INT_PTR {Cfg.ExportPrefix}NewObject_{Class.Name}(UObject* Parent, char* Name)");
            cw.OpenBlock();
            cw.WriteLine($"return (INT_PTR)NewObject<{Class.Name}>(Parent, FName(UTF8_TO_TCHAR(Name)));");
            cw.CloseBlock();
            cw.WriteLine();
        }

        private void GenerateMethod(CodeWriter cw, Method method)
        {
            if (method.AccessModifier == AccessModifier.Private)
                return;

            if (method.OwnerClass.IsFinal && method.AccessModifier == AccessModifier.Protected)
                return;

            var param = GetMethodSignatuteParam(method);
            var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i => "_p" + i));

            cw.WriteLine($"{Cfg.CppApi} auto {GetCppMethodName(method)}({param})");
            cw.OpenBlock();

            for (var i = 0; i < method.InputTypes.Count; i++)
            {
                var m = method.InputTypes[i];
                var reference = m.IsReference && !Cfg.Filter.IsUseConvertFromManageType(m.Type) ? "&" : "";

                cw.WriteLine($"auto{reference} _p{i} = {GenerateGet(m)};");
            }

            var ret = method.AccessModifier == AccessModifier.Public
                ? $"Self->{method.Name}({call})"
                : $"(({Cfg.ExportProtectedPrefix}{method.OwnerClass.Name}*)Self)->{method.Name}{Cfg.ExportProtectedPostfix}({call})";

            cw.WriteLine(GenerateReturn(method.ReturnType, ret, false));

            cw.CloseBlock();
            cw.WriteLine();
        }

        private string GetMethodSignatuteParam(Method method)
        {
            var inputs = method.InputTypes.Select(ExportVariableCpp).ToList();
            inputs.Insert(0, $"{method.OwnerClass.Name}* Self");

            return string.Join(", ", inputs);
        }

        private void GenerateMethodProtctedWrap(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));

            cw.WriteLine(
                $"{method.ReturnType.GetTypeCppOgiginal()} {method.Name}{Cfg.ExportProtectedPostfix}({param})");
            cw.OpenBlock();

            cw.Write(method.ReturnType.Type.Name != "void", "return ");

            cw.Write($"{method.Name}({string.Join(", ", method.InputTypes.Select(p => p.Name))})");
            cw.WriteLine(";");

            cw.CloseBlock();
            cw.WriteLine();
        }

        private string GenerateGet(Variable variable, string manualName = null)
        {
            var result = "";
            var bCloseCount = 0;
            var type = variable.Type;
            var isStruct = (variable.Type as Class)?.IsStructure == true;

            if (isStruct)
            {
                if (!variable.IsPointer)
                    result += "*";

                result += $"({type.Name}*)";
            }
            else if (type.IsTemplate)
            {
                var name = variable.GetTypeCppOgiginal(true).TrimEnd('&');
                result += $"*({name}*)";
            }
            else if (Cfg.Filter.IsUseConvertFromManageType(type))
            {
                result += $"ConvertFromManage_{type}(";
                bCloseCount++;
            }

            result += manualName ?? variable.Name;
            result += new string(')', bCloseCount);

            return result;
        }

        private static string GenerateReturn(Variable variable, string expression, bool forProperty)
        {
            if (variable.Type.IsVoid) return expression + ";";

            var result = "return ";
            var bCloseCount = 0;
            var isStruct = (variable.Type as Class)?.IsStructure == true;

            if (isStruct)
            {
                if (forProperty)
                {
                    result += $"(INT_PTR)&(";
                }
                else if (variable.IsConst && variable.IsPointer)
                {
                    result += $"(INT_PTR) const_cast<{variable.Type.Name}*>(";
                }
                else if (variable.IsConst && !variable.IsPointer)
                {
                    result += $"(INT_PTR) const_cast<{variable.Type.Name}*>(&(";
                    bCloseCount++;
                }
                else if (variable.IsPointer)
                {
                    result += $"(INT_PTR) (";
                }
                else
                {
                    result += $"(INT_PTR) new {variable.Type.Name}(";
                }

                bCloseCount++;
            }
            //else if (type.IsTemplate)
            //{
            //    // todo: 
            //}
            else if (Cfg.Filter.GetConvertToManageType(variable.Type, out var toType))
            {
                result += $"ConvertToManage_{toType}(";
                bCloseCount++;
            }

            result += expression;
            result += new string(')', bCloseCount);
            result += ";";

            return result;
        }

        private string ExportVariableCpp(Variable variable)
        {
            var result = variable.GetTypeCpp();

            if (!string.IsNullOrEmpty(variable.Name))
                result += " " + variable.Name;

            return result;
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

            GenerateSummaty(cw, Class,
                "Класс не может быть наследован в Вашем коде, используйте Manage" + Class.BaseName);

            var baseClass = Class.BaseClass != null
                ? Class.BaseClass.Name
                : (Class.IsStructure ? "NativeStructWrapper" : "NativeWrapper");

            cw.WriteLine($"public {(Class.IsFinal ? "sealed" : "")} partial class {Class.Name} : {baseClass}");
            cw.OpenBlock();

            cw.WriteLine($"public {Class.Name}(IntPtr adress)");
            cw.WriteLine("\t: base(adress)");
            cw.OpenBlock();
            cw.CloseBlock();
            cw.WriteLine();

            if (!Cfg.Filter.NewObjectBlackList.Contains(Class.Name))
            {
                cw.WriteLine($"public {Class.Name}(UObject Parent = null, string Name = \"{Class.BaseName}\")");
                cw.WriteLine("\t: base(IntPtr.Zero)");
                cw.OpenBlock();
                cw.WriteLine($"NativePointer = {Cfg.ExportPrefix}NewObject_{Class.Name}(Parent, Name);");
                cw.WriteLine($"NativeManager.AddNativeWrapper(NativePointer, this);");
                cw.CloseBlock();
                cw.WriteLine();
            }

            var cwDllImport = new CodeWriter(cw);
            var cwExternMethods = new CodeWriter(cw);
            var cwProperty = new CodeWriter(cw);
            var cwEvent = new CodeWriter(cw);

            GenerateClassDllImport(cwDllImport, Class);
            GenerateClassPropertyDllImport(cw, Class);

            Class.Property.ForEach(p => GenerateProperty(cwProperty, cwEvent, Class, p));

            foreach (var method in Class.Methods)
            {
                GenerateMethodDllImport(cwDllImport, Class, method);
                GenerateMethodBody(cwExternMethods, Class, method);
            }

            if (!cwDllImport.IsEmpty())
            {
                cw.WriteLine("#region DLLInmport");
                cw.Write(cwDllImport);
                cw.WriteLine("#endregion");
                cw.WriteLine();
            }

            if (!cwProperty.IsEmpty())
            {
                cw.WriteLine("#region Property");
                cw.Write(cwProperty);
                cw.WriteLine("#endregion");
                cw.WriteLine();
            }

            if (!cwEvent.IsEmpty())
            {
                cw.WriteLine("#region Events");
                cw.Write(cwEvent);
                cw.WriteLine("#endregion");
                cw.WriteLine();
            }

            if (!cwExternMethods.IsEmpty())
            {
                cw.WriteLine("#region ExternMethods");
                cw.Write(cwExternMethods);
                cw.WriteLine("#endregion");
                cw.WriteLine();
            }

            cw.WriteLine($"public static implicit operator IntPtr({Class.Name} self)");
            cw.OpenBlock();
            cw.WriteLine("return self?.NativePointer ?? IntPtr.Zero;");
            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"public static implicit operator {Class.Name}(ObjectPointerDescription PtrDesc)");
            cw.OpenBlock();
            cw.WriteLine($"return NativeManager.GetWrapper<{Class.Name}>(PtrDesc);");
            cw.CloseBlock();

            cw.CloseBlock();
            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputCs, Class.Name + ".cs"));
        }

        private void GenerateMethodDllImport(CodeWriter cw, Class Class, Method method)
        {
            var inputs = method.InputTypes.Select(m => ExportVariable(m, false, true)).ToList();
            inputs.Insert(0, "IntPtr self");

            var param = string.Join(", ", inputs);
            var ret = ExportVariable(method.ReturnType, false, true, true);

            WriteDllImport(cw);
            cw.WriteLine($"private static extern {ret} {GetCppMethodName(method)}({param});");
            cw.WriteLine();
        }

        private void GenerateMethodBody(CodeWriter cw, Class Class, Method method)
        {
            var inputs = method.InputTypes.Select(VarNameForCall).ToList();

            var genDefault = !method.IsVirtual &&
                             ValidateDefaultValue(method.InputTypes.LastOrDefault()?.Default) != null;

            var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, genDefault)));

            GenerateSummaty(cw, method);
            cw.Write(method.AccessModifier.ToString().ToLower() + " ");
            cw.Write(method.IsVirtual, "virtual ");

            if (method.Name == "ToString" && !method.InputTypes.Any())
                cw.Write("override ");

            inputs.Insert(0, "this");
            cw.WriteLine($"{ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param})");

            cw.Write("\t=> ");

            if (method.ReturnType is EnumVariable) cw.Write($"({method.ReturnType.Type})");

            cw.WriteLine($"{GetCppMethodName(method)}({string.Join(", ", inputs)});");

            cw.WriteLine();
        }

        private void GenerateClassDllImport(CodeWriter cw, Class Class)
        {
            if (!Cfg.Filter.NewObjectBlackList.Contains(Class.Name))
            {
                WriteDllImport(cw);
                cw.WriteLine(
                    $"private static extern IntPtr {Cfg.ExportPrefix}NewObject_{Class.Name}(IntPtr Parent, string Name);");
                cw.WriteLine();
            }
        }

        private void GenerateClassPropertyDllImport(CodeWriter cw, Class Class)
        {
            foreach (var prop in Class.Property)
                if (prop.IsStatic)
                    GenerateClassPropertyStaticDllImport(cw, Class, prop);
                else if (prop is DelegateVariable)
                    GenerateClassPropertyEventDllImport(cw, Class, prop);
                else
                    GenerateClassPropertyStandartDllImport(cw, Class, prop);
        }

        private void GenerateClassPropertyEventDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var name = prop.GetDisplayName();

            WriteDllImport(cw);
            cw.WriteLine($"private static extern void {Cfg.ExportEventAddPrefix}{Class.Name}_{name}(IntPtr Ptr);");
            cw.WriteLine();

            WriteDllImport(cw);
            cw.WriteLine($"private static extern void {Cfg.ExportEventRemovePrefix}{Class.Name}_{name}(IntPtr Ptr);");
            cw.WriteLine();
        }

        private void GenerateClassPropertyStaticDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            WriteDllImport(cw);
            cw.WriteLine(
                $"private static extern {prop.GetTypeCsForExtend(true)} {baseName}{Cfg.EventPropertyGetPostfix}();");

            cw.WriteLine();
        }

        private void GenerateClassPropertyStandartDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            WriteDllImport(cw);
            cw.WriteLine(
                $"private static extern {prop.GetTypeCsForExtend(true)} {baseName}{Cfg.EventPropertyGetPostfix}(IntPtr Ptr);");

            if (!prop.IsReadOnly())
            {
                WriteDllImport(cw);
                cw.WriteLine(
                    $"private static extern void {baseName}{Cfg.EventPropertySetPostfix}(IntPtr Ptr, {prop.GetTypeCsForExtend()} Value);");
            }

            cw.WriteLine();
        }

        private void GenerateProperty(CodeWriter cwStandart, CodeWriter cwEvent, Class Class, Variable prop)
        {
            if (prop.IsStatic)
                GeneratePropertyStatic(cwStandart, Class, prop);
            else if (prop is DelegateVariable)
                GeneratePropertyEvent(cwEvent, Class, prop);
            else
                GeneratePropertyStandart(cwStandart, Class, prop);
        }

        private void GeneratePropertyEvent(CodeWriter cw, Class Class, Variable prop)
        {
            var type = prop.GetTypeCs();
            var name = prop.GetDisplayName();
            var dlg = (Delegate)prop.Type;

            GenerateSummaty(cw, prop);

            cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} event {type} {name}");
            cw.OpenBlock();

            cw.WriteLine($"add");
            cw.OpenBlock();
            cw.WriteLine($"{Cfg.ExportEventAddPrefix}{Class.Name}_{name}(NativePointer);");
            cw.WriteLine($"{Cfg.EventPrivatePrefix}{name} += value;");
            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"remove");
            cw.OpenBlock();
            cw.WriteLine($"{Cfg.ExportEventRemovePrefix}{Class.Name}_{name}(NativePointer);");
            cw.WriteLine($"{Cfg.EventPrivatePrefix}{name} -= value;");
            cw.CloseBlock();
            cw.WriteLine();

            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"private event {type} {Cfg.EventPrivatePrefix}{name};");
            cw.WriteLine();

            var param = string.Join(", ", dlg.Parametrs.Select(ExportVariableForDelegateCall));
            var call = string.Join(", ", dlg.Parametrs.Select(m => ToLowerCamelCase(m.GetDisplayName())));

            cw.WriteLine($"internal void {Cfg.EventInvokePrefix}{name}({param})");
            cw.OpenBlock();
            cw.WriteLine($"{Cfg.EventPrivatePrefix}{name}?.Invoke({call});");
            cw.CloseBlock();
            cw.WriteLine();
        }

        private void GeneratePropertyStatic(CodeWriter cw, Class Class, Variable prop)
        {
            GenerateSummaty(cw, prop);

            cw.WriteLine(
                $"{prop.AccessModifier.ToString().ToLower()} static {prop.GetTypeCs()} {prop.GetDisplayName()}");
            cw.OpenBlock();

            var convGet = prop is EnumVariable ? $"({prop.Type})" : "";

            cw.WriteLine(
                $"get => {convGet}{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{Cfg.EventPropertyGetPostfix}();");

            cw.CloseBlock();

            cw.WriteLine();
        }

        private void GeneratePropertyStandart(CodeWriter cw, Class Class, Variable prop)
        {
            GenerateSummaty(cw, prop);

            var convGet = prop is EnumVariable ? $"({prop.Type})" : "";
            var convSet = prop is EnumVariable ? $"(byte)" : "";

            cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} {prop.GetTypeCs()} {prop.GetDisplayName()}");
            cw.OpenBlock();

            cw.WriteLine(
                $"get => {convGet}{Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{Cfg.EventPropertyGetPostfix}(NativePointer);");

            if (!prop.IsReadOnly())
                cw.WriteLine(
                    $"set => {Cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{Cfg.EventPropertySetPostfix}(NativePointer, {convSet}value);");

            cw.CloseBlock();

            cw.WriteLine();
        }

        private string ExportVariableForDelegateCall(Variable variable)
        {
            string result;

            if (Cfg.Filter.GetConvertToManageType(variable.Type, out var toType))
                result = toType;
            else
                result = variable.GetTypeCs();

            result += " " + ToLowerCamelCase(variable.GetDisplayName());

            return result;
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

        private string VarNameForCall(Variable variable)
        {
            var name = ToLowerCamelCase(variable.Name);

            if (variable is EnumVariable)
                return $"(byte){name}";

            return name;
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
    }
}