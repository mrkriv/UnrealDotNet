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

            var visitor = new MetadataVisitor();
            foreach (var file in files)
            {
                AppendFile(file, visitor);
            }

            Watch.Stop();
            var parceTime = Watch.ElapsedMilliseconds;

            Console.WriteLine($"Total parce time {Watch.ElapsedMilliseconds / 1000.0}s");

            var domain = visitor.GetDomain();
            domain.Print(false);

            Watch.Start();
            Codegenretor.GenarateDomain(domain, output);
            Watch.Stop();

            var genTime = Watch.ElapsedMilliseconds - parceTime;
            Console.WriteLine($"Total generate time {genTime / 1000.0}s");
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");

            Console.ReadKey();
        }

        private static void AppendFile(string file, MetadataVisitor visitor)
        {
            var code = File.ReadAllText(file);

            var replaceRegex = new Regex("(,?[A-Z_]+_API)|(PRAGMA_[A-Z_]+)"); // Remove fucking API
            code = replaceRegex.Replace(code, "");

            using (var ms = new MemoryStream(Encoding.ASCII.GetBytes(code)))
            {
                var watch = new Stopwatch();
                watch.Start();

                var inputStream = new AntlrInputStream(ms);

                var lexer = new UHeaderLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);

                var parser = new UHeaderParser(commonTokenStream);
                var context = parser.translationUnit();

                var parceTime = watch.ElapsedMilliseconds;

                visitor.Append(context, file);

                watch.Stop();

                //PrintTokens(commonTokenStream);

                var visitTime = watch.ElapsedMilliseconds - parceTime;
                Console.WriteLine($"{file}: Parce {parceTime}ms, Visit {visitTime}ms");
            }
        }

        private static void PrintTokens(BufferedTokenStream commonTokenStream)
        {
            foreach (var token in commonTokenStream.GetTokens())
            {
                Console.Write(token.Type == -1 ? "n/a" : UHeaderLexer.ruleNames[token.Type - 1]);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t" + token.Text);
                Console.ResetColor();
            }
        }

        private static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}