using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Generator
{
    internal static class Program
    {
        private static readonly Stopwatch Watch = new Stopwatch();
        private const string HeaderScanListFile = @"..\\..\\..\\Config\\HeaderScanList.txt";

        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                PrintError("The first command line parameter must be the path to UnrealDotNet plugin.");
                PrintError("The second parameter must point to the engine folder");
                return;
            }

            var output = Path.Combine(args[0], "Source");
            var files = GetScanFiles(args[1]);

            if (!Directory.Exists(output))
            {
                PrintError($"Project directory '{output}' is not exists");
            }

            Watch.Start();

            var domain = ParceManager.Parce(files);
            Codegenretor.GenarateDomain(domain, output);

            Watch.Stop();
            
            Console.WriteLine();
            domain.PrintTotal();
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");
        }

        private static List<string> GetScanFiles(string PathToEngine)
        {
            var scanMasks = File.ReadAllLines(HeaderScanListFile)
                .Where(x => !x.StartsWith("//") && x.Any());

            var include = scanMasks.Where(x => !x.StartsWith("~"));
            var exclude = scanMasks.Where(x => x.StartsWith("~"));

            var files = new List<string>();

            foreach (var path in include)
            {
                files.AddRange(Directory.GetFiles(PathToEngine, path, SearchOption.AllDirectories));
            }

            foreach (var path in exclude)
            {
                foreach (var file in Directory.GetFiles(PathToEngine, path, SearchOption.AllDirectories))
                {
                    files.Remove(file);
                }
            }

            return files.Distinct().ToList();
        }

        private static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}