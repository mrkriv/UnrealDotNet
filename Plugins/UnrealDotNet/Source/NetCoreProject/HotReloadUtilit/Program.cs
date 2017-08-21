using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotReloadUtilit
{
    public static class Program
    {
        private const string HotDir = "..\\HotReload\\";
        private const string Hotreload = HotDir + "hotreload";
        private const string HotreloadTmp = Hotreload + ".tmp";
        private const string GameLogic = "GameLogicXXXXXXXX";
        private const string Wrapper = "UnrealEngine";

        private static string Mode;
        private static string OutDir;
        private static string Configuration;

        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Comand line format:");
                Console.WriteLine("-pre|-post <OutDir> <Configuration>");
                return;
            }

            Mode = args[0];
            OutDir = args[1];
            Configuration = args[2];

            var isHotReload = Configuration == "Debug" && Process.GetProcessesByName("UE4Editor").Any();

            if (isHotReload)
            {
                switch (Mode)
                {
                    case "-pre": PreHotBuild(args); break;
                    case "-post": PostHotBuild(args); break;
                }
            }
            else
            {
                switch (Mode)
                {
                    case "-pre": PreBuild(args); break;
                    case "-post": PostBuild(args); break;
                }
            }
        }

        private static void PreBuild(IReadOnlyList<string> args)
        {
            Console.WriteLine("Preparation of assembly");
        }

        private static void PostBuild(IReadOnlyList<string> args)
        {
            Console.WriteLine("Completion of assembly");

            SetAssemblyName(OutDir + $"\\{GameLogic}.dll", "");

            File.Copy(OutDir + $"\\{GameLogic}.dll", OutDir + $"\\..\\GameLogic.dll", true);
            File.Copy(OutDir + $"\\{Wrapper}.dll", OutDir + $"\\..\\{Wrapper}.dll", true);

            if (Directory.Exists(OutDir + HotDir))
                Directory.Delete(OutDir + HotDir, true);
        }

        private static void PreHotBuild(IReadOnlyList<string> args)
        {
            var guid = Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine("Preparation of assembly for hot reload GUID:" + guid);

            var hotrelod = Path.Combine(OutDir, HotreloadTmp);
            if (!Directory.Exists(Path.GetDirectoryName(hotrelod)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(hotrelod));
            }

            File.WriteAllText(hotrelod, guid);
        }

        private static void PostHotBuild(IReadOnlyList<string> args)
        {
            var guid = File.ReadAllText(OutDir + "\\" + HotreloadTmp);

            Console.WriteLine("Completion of assembly for hot reload GUID:" + guid);

            SetAssemblyName(OutDir + $"\\{GameLogic}.dll", guid);

            File.Copy(OutDir + $"\\{GameLogic}.dll", OutDir + HotDir + $"\\GameLogic{guid}.dll", true);
            File.WriteAllText(OutDir + "\\" + Hotreload, guid);
        }

        private static void SetAssemblyName(string path, string guid)
        {
            var asm = File.ReadAllBytes(path);
            var find = Encoding.UTF8.GetBytes("GameLogicXXXXXXXX");
            var replace = Encoding.UTF8.GetBytes("GameLogic" + guid);

            if (find.Length < replace.Length)
                throw new Exception("Achtung!");

            // TODO: заменять только в секции потока таблиц, не забивать нопами а удалять лишнее

            for (var i = 0; i <= (asm.Length - find.Length); i++)
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