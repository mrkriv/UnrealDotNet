using System.Collections.Generic;
using System.IO;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen.Modules
{
    internal class EnumGenretorModule : CodeGenretorModule<Enum>
    {
        public EnumGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Enum> GetPrimitives(Domain domain)
        {
            return domain.Enums;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputH = Path.Combine(PathOutputH, "Export");
            CreateDirectoryIfNotExist(PathOutputH);
        }

        #region CS

        protected override void GenerateCs(IReadOnlyList<Enum> enums)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            foreach (var enm in enums)
            {
                GenerateSummaty(cw, enm);

                GenerateSourceInfo(cw, enm);

                cw.WriteLine($"public enum {enm.Name} : byte");
                cw.OpenBlock();

                foreach (var field in enm.Fields)
                {
                    GenerateSummaty(cw, field);

                    cw.Write(field.Name);

                    if (!string.IsNullOrEmpty(field.Value)) cw.Write($" = {field.Value}");

                    cw.WriteLine(",");
                }

                cw.CloseBlock();
                cw.WriteLine();
            }

            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputCs, "Enums.cs"));
        }

        #endregion
    }
}