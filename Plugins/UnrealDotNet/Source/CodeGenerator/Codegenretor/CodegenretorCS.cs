using System.Collections.Generic;
using System.IO;
using System.Linq;
using Generator.Metadata;
using Enum = Generator.Metadata.Enum;
using Delegate = Generator.Metadata.Delegate;

namespace Generator.Codegenretor
{
    // ReSharper disable once InconsistentNaming
    public class CodegenretorCS : CodegenretorBase
    {
        public CodegenretorCS(Config config) : base(config)
        {
        }

        public void GenarateDomain(Domain domain, string outputDir)
        {
            outputDir = Path.Combine(outputDir, "Generate");

            try
            {
                Directory.GetFiles(outputDir, "*.cs", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
            }
            catch
            {
                // ignored
            }

            foreach (var cl in domain.Classes)
            {
                var subdir = cl.IsStructure ? "Struct" : "Class";
                GenerateClass(cl, Path.Combine(outputDir, subdir, cl.Name));

                if (cfg.Filter.IsManageClass(cl))
                    GenerateManageClass(cl, Path.Combine(outputDir, "Manage"));
            }

            GenerateDelegates(domain.Delegates, Path.Combine(outputDir, "Delegates"));
            GenerateEnums(domain.Enums, Path.Combine(outputDir, "Enums"));
        }

        private void GenerateClass(Class Class, string outputPath)
        {
            var cw = new CodeWriter();
            cw.WriteLine("using System;");
            cw.WriteLine("using System.Runtime.InteropServices;");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            GenerateSummaty(cw, Class,
                "Класс не может быть наследован в Вашем коде, используйте Manage" + Class.Name.Substring(1));

            var baseClass = Class.BaseClass != null
                ? Class.BaseClass.Name
                : (Class.IsStructure ? "NativeStructWrapper" : "NativeWrapper");

            cw.WriteLine($"public {(Class.IsFinal ? "sealed" : "")} partial class {Class.Name} : {baseClass}");
            cw.OpenBlock();

            GenerateClassUtilitesTop(cw, Class, false);

            var cwDllImport = new CodeWriter(cw);
            var cwExternMethods = new CodeWriter(cw);
            var cwProperty = new CodeWriter(cw);
            var cwEvent = new CodeWriter(cw);

            GenerateClassDllImport(cwDllImport, Class);
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

            GenerateClassUtilitesButtom(cw, Class);

            cw.CloseBlock();
            cw.CloseBlock();

            cw.SaveToFile(outputPath + ".cs");
        }

        private void GenerateManageClass(Class Class, string outputPath)
        {
            var cw = new CodeWriter();
            cw.WriteLine("using System;");
            cw.WriteLine("using System.Runtime.InteropServices;");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            var manageClass = new Class("Manage" + Class.Name.Substring(1));

            GenerateSummaty(cw, Class, "Этот класс может быть наследованн");

            cw.WriteLine($"public partial class {manageClass.Name} : {Class.Name}");
            cw.OpenBlock();

            GenerateClassUtilitesTop(cw, manageClass, true);

            foreach (var method in cfg.Filter.GetVirtualMethods(Class))
            {
                GenerateManageMethod(cw, method);
            }

            GenerateClassUtilitesButtom(cw, manageClass);

            cw.CloseBlock();
            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(outputPath, manageClass.Name + ".cs"));
        }

        private void GenerateManageMethod(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, false)));

            GenerateSummaty(cw, method);

            cw.Write(method.AccessModifier.ToString().ToLower() + " ");
            cw.WriteLine($"override {ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param}) {{ }}");
            // cw.WriteLine($"\t=> base.{name}({string.Join(", ", inputs)});"); // todo: доделать виртуальные методы

            cw.WriteLine();
        }

        private void GenerateProperty(CodeWriter cwStandart, CodeWriter cwEvent, Class Class, Variable prop)
        {
            if (prop.IsStatic)
            {
                GeneratePropertyStatic(cwStandart, Class, prop);
            }
            else if (prop is DelegateVariable)
            {
                GeneratePropertyEvent(cwEvent, Class, prop);
            }
            else
            {
                GeneratePropertyStandart(cwStandart, Class, prop);
            }
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
            cw.WriteLine($"{cfg.ExportEventAddPrefix}{Class.Name}_{name}(NativePointer);");
            cw.WriteLine($"{cfg.EventPrivatePrefix}{name} += value;");
            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"remove");
            cw.OpenBlock();
            cw.WriteLine($"{cfg.ExportEventRemovePrefix}{Class.Name}_{name}(NativePointer);");
            cw.WriteLine($"{cfg.EventPrivatePrefix}{name} -= value;");
            cw.CloseBlock();
            cw.WriteLine();

            cw.CloseBlock();
            cw.WriteLine();

            cw.WriteLine($"private event {type} {cfg.EventPrivatePrefix}{name};");
            cw.WriteLine();

            var param = string.Join(", ", dlg.Parametrs.Select(ExportVariableForDelegateCall));
            var call = string.Join(", ", dlg.Parametrs.Select(m => m.Name));

            cw.WriteLine($"internal void {cfg.EventInvokePrefix}{name}({param})");
            cw.OpenBlock();
            cw.WriteLine($"{cfg.EventPrivatePrefix}{name}?.Invoke({call});");
            cw.CloseBlock();
            cw.WriteLine();
        }

        private void GeneratePropertyStatic(CodeWriter cw, Class Class, Variable prop)
        {
            GenerateSummaty(cw, prop);
            
            cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} static {ExportVariable(prop, false)}");
            cw.OpenBlock();

            var convGet = prop is EnumVariable ? $"({prop.Type})" : "";

            cw.WriteLine(
                $"get => {convGet}{cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{cfg.EventPropertyGetPostfix}();");

            cw.CloseBlock();

            cw.WriteLine();
        }

        private void GeneratePropertyStandart(CodeWriter cw, Class Class, Variable prop)
        {
            GenerateSummaty(cw, prop);

            cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} {ExportVariable(prop, false)}");
            cw.OpenBlock();

            var convGet = prop is EnumVariable ? $"({prop.Type})" : "";
            var convSet = prop is EnumVariable ? $"(byte)" : "";

            cw.WriteLine(
                $"get => {convGet}{cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{cfg.EventPropertyGetPostfix}(NativePointer);");

            if (!prop.IsReadOnly())
                cw.WriteLine(
                    $"set => {cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}{cfg.EventPropertySetPostfix}(NativePointer, {convSet}value);");

            cw.CloseBlock();

            cw.WriteLine();
        }

        private void GenerateClassUtilitesTop(CodeWriter cw, Class Class, bool forManage)
        {
            if (Class.IsStructure)
            {
                GenerateStructConstructors(cw, Class);
            }
            else
            {
                cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                cw.WriteLine("\t: base(Adress)");
                cw.OpenBlock();
                cw.CloseBlock();
                cw.WriteLine();

                if (!forManage && !cfg.Filter.NewObjectBlackList.Contains(Class.Name))
                {
                    cw.WriteLine(
                        $"public {Class.Name}(UObject Parent = null, string Name = \"{Class.Name.Substring(1)}\")");
                    cw.WriteLine("\t: base(IntPtr.Zero)");
                    cw.OpenBlock();
                    cw.WriteLine($"NativePointer = {cfg.ExportPrefix}NewObject_{Class.Name}(Parent, Name);");
                    cw.WriteLine($"NativeManager.AddNativeWrapper(NativePointer, this);");
                    cw.CloseBlock();
                    cw.WriteLine();
                }
            }
        }

        private void GenerateClassDllImport(CodeWriter cw, Class Class)
        {
            if (Class.IsStructure)
            {
                GenerateStructConstructorsDllImport(cw, Class);
            }
            else
            {
                if (!cfg.Filter.NewObjectBlackList.Contains(Class.Name))
                {
                    WriteDllImport(cw);
                    cw.WriteLine($"private static extern IntPtr {cfg.ExportPrefix}NewObject_{Class.Name}(IntPtr Parent, string Name);");
                    cw.WriteLine();
                }
            }

            GenerateClassPropertyDllImport(cw, Class);
        }

        private void GenerateClassPropertyDllImport(CodeWriter cw, Class Class)
        {
            foreach (var prop in Class.Property)
            {
                if (prop.IsStatic)
                {
                    GenerateClassPropertyStaticDllImport(cw, Class, prop);
                }
                else if (prop is DelegateVariable)
                {
                    GenerateClassPropertyEventDllImport(cw, Class, prop);
                }
                else
                {
                    GenerateClassPropertyStandartDllImport(cw, Class, prop);
                }
            }
        }

        private void GenerateClassPropertyEventDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var name = prop.GetDisplayName();

                WriteDllImport(cw);
                cw.WriteLine($"private static extern void {cfg.ExportEventAddPrefix}{Class.Name}_{name}(IntPtr Ptr);");
                cw.WriteLine();

                WriteDllImport(cw);
                cw.WriteLine($"private static extern void {cfg.ExportEventRemovePrefix}{Class.Name}_{name}(IntPtr Ptr);");
                cw.WriteLine();
            }

        private void GenerateClassPropertyStaticDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            WriteDllImport(cw);
            cw.WriteLine(
                $"private static extern {prop.GetTypeCsForExtend(true)} {baseName}{cfg.EventPropertyGetPostfix}();");

            cw.WriteLine();
        }

        private void GenerateClassPropertyStandartDllImport(CodeWriter cw, Class Class, Variable prop)
        {
            var baseName = $"{cfg.ExportPropertyPrefix}{Class.Name}_{prop.Name}";

            WriteDllImport(cw);
            cw.WriteLine(
                $"private static extern {prop.GetTypeCsForExtend(true)} {baseName}{cfg.EventPropertyGetPostfix}(IntPtr Ptr);");

            if (!prop.IsReadOnly())
            {
                WriteDllImport(cw);
                cw.WriteLine(
                    $"private static extern void {baseName}{cfg.EventPropertySetPostfix}(IntPtr Ptr, {prop.GetTypeCsForExtend()} Value);");
            }

            cw.WriteLine();
        }

        private void GenerateStructConstructors(CodeWriter cw, Class Class)
        {
            cw.WriteLine(
                $"internal {Class.Name}(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)");
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

        private void GenerateStructConstructorsDllImport(CodeWriter cw, Class Class)
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

        private void GenerateMethodDllImport(CodeWriter cw, Class Class, Method method)
        {
            var inputs = method.InputTypes.Select(m => ExportVariable(m, false, true)).ToList();
            inputs.Insert(0, "IntPtr Self");

            var param = string.Join(", ", inputs);
            var ret = ExportVariable(method.ReturnType, false, true, true);

            WriteDllImport(cw);
            cw.WriteLine(
                $"private static extern {ret} {GetCppMethodName(method)}({param});");
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

            if (method.ReturnType is EnumVariable)
            {
                cw.Write($"({method.ReturnType.Type})");
            }

            cw.WriteLine($"{GetCppMethodName(method)}({string.Join(", ", inputs)});");

            cw.WriteLine();
        }

        private void GenerateDelegates(IEnumerable<Delegate> delegates, string outputPath)
        {
            var cw = new CodeWriter();
            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            delegates.ForEach(dlg => GenerateDelegate(cw, dlg));

            cw.CloseBlock();

            cw.SaveToFile(outputPath + ".cs");
        }

        private void GenerateDelegate(CodeWriter cw, Delegate dlg)
        {
            GenerateSummaty(cw, dlg);

            GenerateSourceInfo(cw, dlg);

            var param = string.Join(", ", dlg.Parametrs.Select(m => ExportVariable(m, false)));
            cw.Write($"public delegate void {dlg.Name}({param});");

            cw.WriteLine();
        }

        private void GenerateEnums(IEnumerable<Enum> enums, string outputPath)
        {
            var cw = new CodeWriter();
            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            enums.ForEach(en => GenerateEnum(cw, en));

            cw.CloseBlock();

            cw.SaveToFile(outputPath + ".cs");
        }

        private void GenerateEnum(CodeWriter cw, Enum Enum)
        {
            GenerateSummaty(cw, Enum);

            GenerateSourceInfo(cw, Enum);

            cw.WriteLine($"public enum {Enum.Name} : byte");
            cw.OpenBlock();

            foreach (var field in Enum.Fields)
            {
                GenerateSummaty(cw, field);

                cw.Write(field.Name);

                if (!string.IsNullOrEmpty(field.Value))
                {
                    cw.Write($" = {field.Value}");
                }

                cw.WriteLine(",");
            }

            cw.CloseBlock();
            cw.WriteLine();
        }

        private void GenerateSummaty(CodeWriter cw, Primitive primitive, string insert = "")
        {
            if (string.IsNullOrEmpty(primitive.Description))
                return;

            var rows = primitive.Description.Split('\n');

            cw.WriteLine();
            cw.WriteLine("/// <summary>");

            cw.WriteLine(!string.IsNullOrEmpty(insert), "/// " + insert);

            foreach (var row in rows)
            {
                var format = row.Trim(' ', '\t', '*', '/', '\\', '\n', '\r');

                if (format == "")
                    continue;

                var match = SummaryParamRegex.Match(format);
                if (match.Success)
                {
                    cw.WriteLine($"/// <param name=\"{match.Groups[1]}\">{match.Groups[2]} </param>");
                }
                else
                {
                    match = SummaryReturnRegex.Match(format);
                    if (match.Success)
                    {
                        cw.WriteLine($"/// <return>{match.Groups[1]} </return>");
                    }
                    else
                        cw.WriteLine($"/// <para>{format} </para>");
                }
            }

            cw.WriteLine("/// </summary>");
        }

        private void GenerateClassUtilitesButtom(CodeWriter cw, Class Class)
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
                cw.WriteLine($"public static implicit operator {Class.Name}(ObjectPointerDescription PtrDesc)");
                cw.OpenBlock();
                cw.WriteLine($"return NativeManager.GetWrapper<{Class.Name}>(PtrDesc);");
                cw.CloseBlock();
            }
        }

        private void WriteDllImport(CodeWriter cw)
        {
            cw.WriteLine(
                "[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]");
        }

        private string ExportVariable(Variable variable, bool includeDefault = true, bool forExtern = false,
            bool forReturn = false)
        {
            var result = forExtern ? variable.GetTypeCsForExtend(forReturn) : variable.GetTypeCs();

            if (!string.IsNullOrEmpty(variable.Name))
            {
                result += " " + variable.GetDisplayName();

                if (includeDefault)
                {
                    var val = ValidateDefaultValue(variable.Default);
                    if (val != null)
                        result += " = " + val;
                }
            }

            return result;
        }

        private string ExportVariableForDelegateCall(Variable variable)
        {
            string result;

            if (cfg.Filter.GetConvertToManageType(variable.Type, out var toType))
            {
                result = toType;
            }
            else
            {
                result = variable.GetTypeCs();
            }

            result += " " + variable.GetDisplayName();

            return result;
        }

        private string VarNameForCall(Variable variable)
        {
            if (variable is EnumVariable)
                return $"(byte){variable.Name}";

            return variable.Name;
        }

        private string ValidateDefaultValue(string value)
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