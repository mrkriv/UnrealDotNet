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

        public static void Main(string[] args)
        {
            if (Process.GetProcessesByName("UE4Editor").Any())
            {
                switch (args[0])
                {
                    case "-pre": PreHotBuild(args); break;
                    case "-post": PostHotBuild(args); break;
                }
            }
            else
            {
                switch (args[0])
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

            SetAssemblyName(args[1] + $"\\{GameLogic}.dll", "");

            File.Copy(args[1] + $"\\{GameLogic}.dll", args[1] + $"\\..\\GameLogic.dll", true);
            File.Copy(args[1] + $"\\{Wrapper}.dll", args[1] + $"\\..\\{Wrapper}.dll", true);

            if (Directory.Exists(args[1] + HotDir))
                Directory.Delete(args[1] + HotDir, true);
        }


        private static void PreHotBuild(IReadOnlyList<string> args)
        {
            var guid = Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine("Preparation of assembly for hot reload GUID:" + guid);
            
            var hotrelod = Path.Combine(args[1], HotreloadTmp);
            if (!Directory.Exists(Path.GetDirectoryName(hotrelod)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(hotrelod));
            }

            File.WriteAllText(hotrelod, guid);
        }

        private static void PostHotBuild(IReadOnlyList<string> args)
        {
            var guid = File.ReadAllText(args[1] + "\\" + HotreloadTmp);

            Console.WriteLine("Completion of assembly for hot reload GUID:" + guid);

            SetAssemblyName(args[1] + $"\\{GameLogic}.dll", guid);

            File.Copy(args[1] + $"\\{GameLogic}.dll", args[1] + HotDir + $"\\GameLogic{guid}.dll", true);
            File.WriteAllText(args[1] + "\\" + Hotreload, guid);
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