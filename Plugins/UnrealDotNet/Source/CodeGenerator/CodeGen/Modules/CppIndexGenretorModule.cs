using System.Collections.Generic;
using System.IO;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen.Modules
{
    internal class CppIndexGenretorModule : CodeGenretorModule<Class>
    {
        public CppIndexGenretorModule(Config config) : base(config)
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
            CreateDirectoryIfNotExist(PathOutputH);
        }

        protected override bool CanGenerate(Class Class)
        {
            if (Class.IsStructure)
                return false;

            return true;
        }

        #region H

        protected override void GenerateH(IReadOnlyList<Class> classes)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            GenerateReSharperDisablesCpp(cw);
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();
            cw.WriteLine("#include \"Structures.h\"");

            foreach (var Class in classes) cw.WriteLine($"#include \"{Class.Name}.h\"");

            cw.WriteLine();
            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputH, "Index.h"));
        }

        #endregion
    }
}