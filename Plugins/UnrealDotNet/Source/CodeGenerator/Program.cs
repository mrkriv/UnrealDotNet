using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CodeGenerator.CodeGen;
using CodeGenerator.CodeGen.Modules;
using CodeGenerator.Metadata;
using CommandLine;
using Newtonsoft.Json;

namespace CodeGenerator
{
    public static class Program
    {
        private static readonly Stopwatch Watch = new Stopwatch();

        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineArguments>(args).WithParsed(Run);
        }

        private static void Run(CommandLineArguments args)
        {
            if (!File.Exists(args.HeaderScanListFile))
            {
                PrintError($"File '{args.HeaderScanListFile}' is not exists");
                return;
            }

            if (!File.Exists(args.ConfigPath))
            {
                PrintError($"Project directory '{args.ConfigPath}' is not exists");
                return;
            }

            var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(args.ConfigPath));
            var files = GetScanFiles(args);

            if (!Directory.Exists(args.Output))
            {
                PrintError($"Project directory '{args.Output}' is not exists");
                return;
            }

            Watch.Start();

            var domain = ParceManager.Parce(files, config);
            GenarateDomain(domain, args.Output, config);

            Watch.Stop();

            Console.WriteLine();
            domain.PrintTotal();
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");
        }

        public static void GenarateDomain(Domain domain, string outputDir, Config config)
        {
            var outputCs = Path.Combine(outputDir, "UnrealEngineSharp");
            var outputCpp = Path.Combine(outputDir, "UnrealDotNetRuntime");

            var generatorStack = new List<ICodeGenretorModule>
            {
                new ClassGenretorModule(config),
                new CppIndexGenretorModule(config),
                new DelegateGenretorModule(config),
                new EnumGenretorModule(config),
                new ManageClassGenretorModule(config),
                new StructGenretorModule(config),
            };

            var watch = new Stopwatch();
            watch.Start();

            foreach (var genretor in generatorStack)
            {
                genretor.Generate(domain, outputCpp, outputCs);
            }

            Console.WriteLine($"Total generate time {watch.ElapsedMilliseconds / 1000.0}s");
        }

        private static List<string> GetScanFiles(CommandLineArguments commandLineArguments)
        {
            var scanMasks = File.ReadAllLines(commandLineArguments.HeaderScanListFile)
                .Where(x => !x.StartsWith("//") && x.Any()).ToList();

            var include = scanMasks.Where(x => !x.StartsWith("~"));
            var exclude = scanMasks.Where(x => x.StartsWith("~"));

            var files = new List<string>();

            foreach (var path in include)
                files.AddRange(Directory.GetFiles(commandLineArguments.UnrealEngine, path, SearchOption.AllDirectories));

            foreach (var path in exclude)
            foreach (var file in Directory.GetFiles(commandLineArguments.UnrealEngine, path, SearchOption.AllDirectories))
                files.Remove(file);

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