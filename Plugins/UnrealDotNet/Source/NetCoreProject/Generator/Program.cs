using CommandLine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Generator.Codegenretor;
using Generator.Metadata;
using Newtonsoft.Json;

namespace Generator
{
    public static class Program
    {
        private static readonly Stopwatch Watch = new Stopwatch();

        public class Options
        {
            [Option('o', "output", Required = true, HelpText = "Output code folder")]
            public string Output { get; set; }

            [Option("ue", Required = true, HelpText = "Unreal engine 4 root folder")]
            public string UnrealEngine { get; set; }

            [Option('h', "headers", HelpText = "Path to header filters", Default = @"..\\..\\..\\Config\\HeaderScanList.txt")]
            public string HeaderScanListFile { get; set; }

            [Option('c', "config", HelpText = "Path to config file", Default = @"..\\..\\..\\Config\\CodeGenerator.json")]
            public string ConfigPath { get; set; }
        }

        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(Run);
        }

        private static void Run(Options options)
        {
            if (!File.Exists(options.HeaderScanListFile))
            {
                PrintError($"File '{options.HeaderScanListFile}' is not exists");
                return;
            }

            if (!File.Exists(options.ConfigPath))
            {
                PrintError($"Project directory '{options.ConfigPath}' is not exists");
                return;
            }

            var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(options.ConfigPath));
            var output = Path.Combine(options.Output, "Source");
            var files = GetScanFiles(options);

            if (!Directory.Exists(output))
            {
                PrintError($"Project directory '{output}' is not exists");
                return;
            }

            Watch.Start();

            var domain = ParceManager.Parce(files, config);
            GenarateDomain(domain, output, config);

            Watch.Stop();

            Console.WriteLine();
            domain.PrintTotal();
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");
        }

        public static void GenarateDomain(Domain domain, string outputDir, Config config)
        {
            var outputCs = Path.Combine(outputDir, "NetCoreProject", "UnrealEngine", "Generate");
            var outputCpp = Path.Combine(outputDir, "UnrealDotNetRuntime");

            var cpp = new CodegenretorCPP(config);
            var cs = new CodegenretorCS(config);

            var watch = new Stopwatch();
            watch.Start();

            cpp.GenarateDomain(domain, outputCpp);
            cs.GenarateDomain(domain, outputCs);

            Console.WriteLine($"Total generate time {watch.ElapsedMilliseconds / 1000.0}s");
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