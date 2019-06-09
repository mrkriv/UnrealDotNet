using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using CodeGenerator.Metadata;
using Type = CodeGenerator.Metadata.Type;

namespace CodeGenerator
{
    internal class ParceManager
    {
        public static Domain Parce(IReadOnlyList<string> files, Config config)
        {
            var types = new ConcurrentDictionary<string, Type>();
            var tasks = new List<Task>();

            var watch = new Stopwatch();
            watch.Start();

            foreach (var file in files)
            {
                AppendFile(file, types, config);
                //tasks.Add(Task.Run(() => { AppendFile(file, types, config); }));
            }

            //Task.WaitAll(tasks.ToArray());

            Console.WriteLine($"Total parce time {watch.ElapsedMilliseconds / 1000.0}s");

            return new Domain(types.Values, config);
        }

        private static void AppendFile(string file, ConcurrentDictionary<string, Type> types, Config config)
        {
            var code = config.Filter.FilterSourceCode(File.ReadAllText(file));
            var visitor = new MetadataVisitor(types);

            using (var ms = new MemoryStream(Encoding.ASCII.GetBytes(code)))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
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

                var visitTime = watch.ElapsedMilliseconds - parceTime;
                Console.ResetColor();
                Console.WriteLine($"{file}: Parce {parceTime}ms, Visit {visitTime}ms");
            }
        }
    }
}