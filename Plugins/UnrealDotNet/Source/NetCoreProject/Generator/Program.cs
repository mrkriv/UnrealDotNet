using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Generator.Metadata;

namespace Generator
{
    internal static class Program
    {
        private static readonly Stopwatch Watch = new Stopwatch();

        public static void Main(string[] args)
        {
            var output = @"C:\Users\vladi\Desktop";
            var files = new[]
            {
                @"C:\Users\vladi\Desktop\Actor.h"
            };

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
            domain.Print();

            Watch.Start();
            Codegenretor.GenarateTo(domain, output);
            Watch.Stop();

            var genTime = Watch.ElapsedMilliseconds - parceTime;
            Console.WriteLine($"Total generate time {genTime / 1000.0}s");
            Console.WriteLine($"Total time {Watch.ElapsedMilliseconds / 1000.0}s");

            //Console.ReadKey();
        }

        private static void AppendFile(string file, MetadataVisitor visitor)
        {
            using (var fileStream = new StreamReader(file))
            {
                var watch = new Stopwatch();
                watch.Start();

                var inputStream = new AntlrInputStream(fileStream);

                var lexer = new CPP14Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);

                var parser = new CPP14Parser(commonTokenStream);
                var context = parser.translationunit();

                var parceTime = watch.ElapsedMilliseconds;

                visitor.Append(context);

                watch.Stop();

                var visitTime = watch.ElapsedMilliseconds - parceTime;
                Console.WriteLine($"{file}: Parce {parceTime}ms, Visit {visitTime}ms");
            }
        }
    }
}