using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen
{
    public abstract class CodeGenretorModule<T> : ICodeGenretorModule where T : Primitive
    {
        protected static readonly Regex SummaryParamRegex = new Regex(@"@param\W+(\w+)\W+(.*)");
        protected static readonly Regex SummaryReturnRegex = new Regex(@"@return\W+(.*)");

        protected static Config Cfg;

        protected string PathOutputCpp;
        protected string PathOutputCs;
        protected string PathOutputH;

        public CodeGenretorModule(Config config)
        {
            Cfg = config;
        }

        protected abstract IEnumerable<T> GetPrimitives(Domain domain);

        public virtual void Generate(Domain domain, string outputCppDir, string outputCsDir)
        {
            SetOutputPath(outputCppDir, outputCsDir);

            var primitives = GetPrimitives(domain).Where(CanGenerate).ToList();

            PreGenerate(primitives);
            GenerateCs(primitives);
            GenerateH(primitives);
            GenerateCpp(primitives);

            foreach (var cl in primitives)
            {
                PreGenerate(cl);

                GenerateCs(cl);
                GenerateH(cl);
                GenerateCpp(cl);
            }
        }

        protected virtual void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            outputCppDir = new DirectoryInfo(outputCppDir).FullName;
            outputCsDir = new DirectoryInfo(outputCsDir).FullName;

            PathOutputCpp = Path.Combine(outputCppDir, "Private", "Generate");
            PathOutputH = Path.Combine(outputCppDir, "Public", "Generate");
            PathOutputCs = Path.Combine(outputCsDir, "Generate");

            CreateDirectoryIfNotExist(PathOutputCpp);
            CreateDirectoryIfNotExist(PathOutputH);
            CreateDirectoryIfNotExist(PathOutputCs);

            //Directory.GetFiles(PathOutputCpp, "*.cpp", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
            //Directory.GetFiles(PathOutputH, "*.h", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
            //Directory.GetFiles(PathOutputCs, "*.cpp", SearchOption.AllDirectories).ToList().ForEach(File.Delete);
        }

        protected virtual bool CanGenerate(T Class)
        {
            return true;
        }

        protected virtual void PreGenerate(T Class)
        {
        }

        protected virtual void GenerateCpp(T Class)
        {
        }

        protected virtual void GenerateH(T Class)
        {
        }

        protected virtual void GenerateCs(T Class)
        {
        }

        protected virtual void PreGenerate(IReadOnlyList<T> classes)
        {
        }

        protected virtual void GenerateCpp(IReadOnlyList<T> classes)
        {
        }

        protected virtual void GenerateH(IReadOnlyList<T> classes)
        {
        }

        protected virtual void GenerateCs(IReadOnlyList<T> classes)
        {
        }

        protected static string GetCppMethodName(Method method)
        {
            var overloadPostfix = method.OverloadIndex > 0 ? $"_o{method.OverloadIndex}" : "";

            return Cfg.ExportPrefix + method.OwnerClass.Name + "_" + method.Name + overloadPostfix;
        }

        protected static string GetExportConstructorFullName(Method ctr)
        {
            var signature = string.Join("_", ctr.InputTypes.Select(m => m.Type));
            if (signature.Any())
                signature = "_" + signature;

            return $"{Cfg.ExportPrefix}CreateStruct_{ctr.OwnerClass.Name}{signature}";
        }

        protected static void GenerateSourceInfo(CodeWriter cw, Primitive primitive)
        {
            if (Cfg.IsWriteSourceFileName)
            {
                cw.WriteLine($"// Source file {primitive.SourceFile}:{primitive.SourceLine}");
                cw.WriteLine();
            }
        }

        protected static void GenerateFileHeader(CodeWriter cw)
        {
            if (Cfg.IsGenerateFileHeader)
            {
                cw.WriteLine($"// This file was created automatically, do not modify the contents of this file.");
                cw.WriteLine();
            }
        }

        protected void CreateDirectoryIfNotExist(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        protected void WriteDllImport(CodeWriter cw)
        {
            cw.WriteLine("[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]");
        }

        protected void GenerateSummaty(CodeWriter cw, Primitive primitive, string insert = "")
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
                        cw.WriteLine($"/// <return>{match.Groups[1]} </return>");
                    else
                        cw.WriteLine($"/// <para>{format} </para>");
                }
            }

            cw.WriteLine("/// </summary>");
        }

        protected string GetSourceFileName(Class Class)
        {
            var index = Class.SourceFile.IndexOf(Cfg.EnginePathSeg, StringComparison.Ordinal);
            var sourceFile = index == -1
                ? Class.SourceFile
                : Class.SourceFile.Substring(index + Cfg.EnginePathSeg.Length + 1);

            sourceFile = sourceFile.Replace("\\", "/");
            return sourceFile;
        }

        protected static string ToLowerCamelCase(string str)
        {
            str = char.ToLower(str[0]) + str.Substring(1);

            if (str == "in" || str == "object" || str == "out" || str == "class" || str == "event" || str == "delegate")
                str = "@" + str;

            return str;
        }
    }
}