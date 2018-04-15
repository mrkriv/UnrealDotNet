using Antlr4.Runtime;
using CommandLine;
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

        class Options
        {
            [Option('o', "output", Required = true, HelpText = "Output code folder")]
            public string Output { get; set; }

            [Option("ue", Required = true, HelpText = "Unreal engine 4 root folder")]
            public string UnrealEngine { get; set; }

            [Option('h', "headers", HelpText = "Path to header filters", Default = @"..\\..\\..\\Config\\HeaderScanList.txt")]
            public string HeaderScanListFile { get; set; }
        }

        public static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
              .WithParsed(Run);
        }

        private static void Run(Options options)
        {
            var output = Path.Combine(options.Output, "Source");
            var files = GetScanFiles(options);

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

        private static List<string> GetScanFiles(Options options)
        {
            var scanMasks = File.ReadAllLines(options.HeaderScanListFile)
                .Where(x => !x.StartsWith("//") && x.Any()).ToList();

            var include = scanMasks.Where(x => !x.StartsWith("~"));
            var exclude = scanMasks.Where(x => x.StartsWith("~"));

            var files = new List<string>();

            foreach (var path in include)
            {
                files.AddRange(Directory.GetFiles(options.UnrealEngine, path, SearchOption.AllDirectories));
            }

            foreach (var path in exclude)
            {
                foreach (var file in Directory.GetFiles(options.UnrealEngine, path, SearchOption.AllDirectories))
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