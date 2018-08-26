using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen
{
    public interface ICodeGenretorModule
    {
        void Generate(Domain domain, string outputCppDir, string outputCsDir);
    }
}