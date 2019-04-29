using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen.Modules
{
    internal class StructGenretorModule : CodeGenretorModule<Class>
    {
        public StructGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Class> GetPrimitives(Domain domain)
        {
            return domain.Classes;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputCs = Path.Combine(PathOutputCs, "Struct");

            CreateDirectoryIfNotExist(PathOutputCs);
        }

        protected override bool CanGenerate(Class Class)
        {
            if (!Class.IsStructure)
                return false;

            return true;
        }

        #region H

        protected override void GenerateH(IReadOnlyList<Class> classes)
        {
            var cw = new CodeWriter();

            cw.WriteLine("#pragma once");
            cw.WriteLine();
            GenerateFileHeader(cw);
            cw.WriteLine("#include \"CoreMinimal.h\"");

            foreach (var header in classes.Select(GetSourceFileName).Distinct()) cw.WriteLine($"#include \"{header}\"");

            cw.WriteLine();
            cw.WriteLine("extern \"C\"");
            cw.OpenBlock();

            foreach (var Class in classes)
            {
                cw.WriteLine();
                cw.WriteLine($"/*\t{Class.Name}\t*/");
                cw.WriteLine();

                GenerateStructHConstructors(cw, Class);

                foreach (var prop in Class.Property) GeneratePropertyH(cw, Class, prop);

                foreach (var method in Class.Methods.Where(m => m.AccessModifier == AccessModifier.Public))
                    GenerateMethod(cw, method);
            }

            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputH, "Export", "Structures.h"));
        }

        private void GenerateStructHConstructors(CodeWriter cw, Class Class)
        {
            foreach (var ctr in Class.Constructors)
            {
                var param = string.Join(", ", ctr.InputTypes.Select(ExportVariableCpp));
                var call = string.Join(", ", ctr.InputTypes.Select(x => GenerateGet(x)));

                var ctrFullName = GetExportConstructorFullName(ctr);

                cw.Write($"{Cfg.CppApi} INT_PTR {ctrFullName}({param}) {{ ");
                cw.WriteLine($"return (INT_PTR) new {Class.Name}({call}); }}");
                cw.WriteLine();
            }
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

            if (!prop.IsReadOnly())
                cw.WriteLine(
                    $"{Cfg.CppApi} void {baseName}{Cfg.EventPropertySetPostfix}({Class.Name}* Ptr, {prop.GetTypeCpp()} Value) {{ Ptr->{prop.Name} = {GenerateGet(prop, "Value")}; }}");

            cw.WriteLine();
        }

        private void GenerateMethod(CodeWriter cw, Method method)
        {
            if (method.OwnerClass.IsFinal && method.AccessModifier != AccessModifier.Public)
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

            var baseClass = Class.BaseClass != null
                ? Class.BaseClass.Name
                : "NativeStructWrapper";

            cw.WriteLine($"public {(Class.IsFinal ? "sealed" : "")} partial class {Class.Name} : {baseClass}");
            cw.OpenBlock();

            var cwDllImport = new CodeWriter(cw);
            var cwExternMethods = new CodeWriter(cw);
            var cwProperty = new CodeWriter(cw);
            var cwEvent = new CodeWriter(cw);

            GenerateStructConstructors(cw, Class);
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

            cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
            cw.OpenBlock();
            cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress, false);");
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

        private void GenerateStructConstructors(CodeWriter cw, Class Class)
        {
            cw.WriteLine($"internal {Class.Name}(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)");
            cw.OpenBlock();
            cw.CloseBlock();
            cw.WriteLine();

            foreach (var ctr in Class.Constructors)
            {
                var ctrFullName = GetExportConstructorFullName(ctr);
                var call = string.Join(", ", ctr.InputTypes.Select(VarNameForCall).ToList());
                var param = string.Join(", ", ctr.InputTypes.Select(m => ExportVariable(m, false)));

                GenerateSummaty(cw, ctr);

                cw.WriteLine($"public {Class.Name}({param}) :");
                cw.WriteLine($"\tbase({ctrFullName}({call}), false)");

                cw.OpenBlock();
                cw.CloseBlock();
                cw.WriteLine();
            }
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
            foreach (var ctr in Class.Constructors)
            {
                var param = string.Join(", ", ctr.InputTypes.Select(m => ExportVariable(m, false, true)));

                var ctrFullName = GetExportConstructorFullName(ctr);

                WriteDllImport(cw);
                cw.WriteLine($"private static extern IntPtr {ctrFullName}({param});");
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
            var dlg = (Delegate) prop.Type;

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