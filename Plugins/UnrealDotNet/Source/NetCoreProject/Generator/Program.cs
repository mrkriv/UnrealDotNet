using Antlr4.Runtime;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Generator
{
    internal static class Program
    {
        private static readonly Stopwatch Watch = new Stopwatch();

        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                PrintError("The first command line parameter must be the path to UnrealDotNet plugin.");
                PrintError("The second parameter must point to the engine folder");
                return;
            }

            var output = Path.Combine(args[0], "Source");
            var files = Directory.GetFiles(args[1], "*.h", SearchOption.AllDirectories);

            if (!Directory.Exists(output))
            {
                PrintError($"Project directory '{output}' is not exists");
            }

            Watch.Start();
            var domain = ParceManager.Parce(files);
            Watch.Stop();

            var parceTime = Watch.ElapsedMilliseconds;

            Console.WriteLine($"Total parce time {Watch.ElapsedMilliseconds / 1000.0}s");

            Filter.FiltreDomainForExport(domain);

            domain.Print(false);

            Watch.Start();
            Codegenretor.GenarateDomain(domain, output);
            Watch.Stop();

            var genTime = Watch.ElapsedMilliseconds - parceTime;
            Console.WriteLine($"Total generate time {genTime / 1000.0}s");
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");

            Console.ReadKey();
        }

        private static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}