using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using CommandLine;

namespace HotReloadUtilit
{
    public static class Program
    {
        public enum Mode
        {
            PreBuild,
            PostBuild
        }

        public class Options
        {
            [Option('m', "mode", Required = true, HelpText = "Runing mode")]
            public Mode Mode { get; set; }

            [Option('o', "output", Required = true, HelpText = "Build output folder")]
            public string OutDir { get; set; }

            [Option('c', "configuration", HelpText = "Build configuration (Debug, Release)", Default = @"Debug")]
            public string Configuration { get; set; }

            [Option("hotDir", Default = "..\\temp\\")]
            public string HotDir { get; set; }

            [Option("hotreload", Default = "hotreload")]
            public string Hotreload { get; set; }

            [Option("hotreloadTmp", Default = ".tmp")]
            public string HotreloadTmp { get; set; }

            [Option("gameLogic", Default = "GameLogic")]
            public string GameLogic { get; set; }

            [Option("wrapper", Default = "UnrealEngine")]
            public string Wrapper { get; set; }
        }

        private static Options opt;

        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(Run);
        }

        public static void Run(Options options)
        {
            var isHotReload = options.Configuration == "Debug" && IsUeEditorRun();
            opt = options;

            switch (options.Mode)
            {
                case Mode.PreBuild:
                    if (isHotReload)
                        PreHotBuild();
                    else
                        PreBuild();
                    break;
                case Mode.PostBuild:
                    if (isHotReload)
                        PostHotBuild();
                    else
                        PostBuild();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static bool IsUeEditorRun()
        {
            return Process.GetProcessesByName("UE4Editor").Any();
        }

        private static void PreBuild()
        {
            Console.WriteLine("Preparation of assembly");
        }

        private static void PostBuild()
        {
            Console.WriteLine("Completion of assembly");

            if (opt.Configuration == "Debug")
            {
                File.Copy(opt.OutDir + $"\\{opt.GameLogic}.dll", opt.OutDir + $"\\..\\{opt.GameLogic}.dll", true);
                File.Copy(opt.OutDir + $"\\{opt.GameLogic}.pdb", opt.OutDir + $"\\..\\{opt.GameLogic}.pdb", true);
            }
            else
            {
                var dir = Path.Combine(opt.OutDir, "..", "..", "..", "Dotnet", "GameLogic");

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                File.Copy(opt.OutDir + $"\\{opt.GameLogic}.dll", dir + $"\\{opt.GameLogic}.dll", true);
                File.Copy(opt.OutDir + $"\\{opt.Wrapper}.dll", dir + $"\\{opt.Wrapper}.dll", true);
            }

            if (!IsUeEditorRun() && Directory.Exists(opt.OutDir + opt.HotDir))
                Directory.Delete(opt.OutDir + opt.HotDir, true);
        }

        private static void PreHotBuild()
        {
            var guid = Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine("Preparation of assembly for hot reload GUID:" + guid);

            var hotrelod = Path.Combine(opt.OutDir, opt.HotDir, opt.Hotreload + opt.HotreloadTmp);
            if (!Directory.Exists(Path.GetDirectoryName(hotrelod)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(hotrelod));
            }

            File.WriteAllText(hotrelod, guid);
        }

        private static void PostHotBuild()
        {
            var guid = File.ReadAllText(Path.Combine(opt.OutDir, opt.HotDir, opt.Hotreload + opt.HotreloadTmp));

            Console.WriteLine("Completion of assembly for hot reload GUID:" + guid);

            SetAssemblyName(opt.OutDir + $"\\{opt.GameLogic}.dll", guid);

            File.Copy(opt.OutDir + $"\\{opt.GameLogic}.dll", opt.OutDir + opt.HotDir + $"\\g{guid}.dll", true);
            File.Copy(opt.OutDir + $"\\{opt.GameLogic}.pdb", opt.OutDir + opt.HotDir + $"\\g{guid}.pdb", true);
            File.WriteAllText(Path.Combine(opt.OutDir, opt.HotDir, opt.Hotreload), guid);
        }

        private static void SetAssemblyName(string path, string guid)
        {
            var asm = File.ReadAllBytes(path);
            var find = opt.GameLogic;
            var replace = Encoding.UTF8.GetBytes("g" + guid);

            if (find.Length < replace.Length)
                throw new Exception($"GameLogic assembly name length < {replace.Length}");

            // TODO: заменять только в секции таблиц, не забивать нопами а удалять лишнее

            for (var i = 0; i <= asm.Length - find.Length; i++)
            {
                if (asm[i] != find[0])
                    continue;

                int j;
                for (j = 1; j < find.Length && asm[i + j] == find[j]; j++)
                {
                }

                if (j != find.Length)
                    continue;

                for (j = 0; j < replace.Length; j++)
                {
                    asm[i + j] = replace[j];
                }

                for (; j < find.Length; j++)
                {
                    asm[i + j] = 0;
                }
            }

            File.WriteAllBytes(path, asm);
        }
    }
}