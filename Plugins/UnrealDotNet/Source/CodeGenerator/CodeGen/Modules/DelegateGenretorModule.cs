using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen.Modules
{
    internal class DelegateGenretorModule : CodeGenretorModule<Delegate>
    {
        public DelegateGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Delegate> GetPrimitives(Domain domain)
        {
            return domain.Delegates;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputH = Path.Combine(PathOutputH, "Export");
            CreateDirectoryIfNotExist(PathOutputH);
        }

        #region H

        protected override void GenerateH(IReadOnlyList<Delegate> delegates)
        {
            var cw = new CodeWriter();

            cw.WriteLine("#pragma once");
            cw.WriteLine();
            GenerateFileHeader(cw);
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

            foreach (var dlg in delegates) GenerateDelegateSender(dlg, cw);

            cw.CloseBlock();
            cw.WriteLine(";");

            cw.SaveToFile(Path.Combine(PathOutputH, "ManageEventSender.h"));
        }

        private void GenerateDelegateSender(Delegate dlg, CodeWriter cw)
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

            cw.WriteLine(
                $"UCoreShell::GetInstance()->InvokeEventInObject{signature}(SourceObject, ManageDelegateName{call});");
            cw.CloseBlock();
            cw.WriteLine();
        }

        private string GetTypeForManageInvoke(Variable variable)
        {
            if (Cfg.Filter.GetConvertToManageType(variable.Type, out var toType)) 
                return toType;

            return variable.GetTypeCppOgiginal(true);
        }

        private string GenerateGetForManageInvoke(Variable variable, string manualName = null)
        {
            var result = "";
            var bCloseCount = 0;

            if (manualName == null) manualName = variable.Name;

            if (Cfg.Filter.GetConvertToManageType(variable.Type, out var toType))
            {
                result += $"ConvertToManage_{toType}(";
                bCloseCount++;
            }

            result += manualName;
            result += new string(')', bCloseCount);

            return result;
        }

        #endregion

        #region CS

        protected override void GenerateCs(IReadOnlyList<Delegate> delegates)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            foreach (var dlg in delegates)
            {
                GenerateSummaty(cw, dlg);

                GenerateSourceInfo(cw, dlg);

                var param = string.Join(", ", dlg.Parametrs.Select(m => ExportVariable(m, false)));
                cw.Write($"public delegate void {dlg.Name}({param});");

                cw.WriteLine();
            }

            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputCs, "Delegates.cs"));
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