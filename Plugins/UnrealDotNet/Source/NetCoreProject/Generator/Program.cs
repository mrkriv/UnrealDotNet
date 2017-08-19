using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Generator
{
    internal static class Program
    {
        private static bool CreateJsonDump = false;

        public static void Main(string[] args)
        {
            var files = new[] { @"C:\Users\vladi\Desktop\Actor.h" };

            var visitor = new GenMetadataVisitor();
            foreach (var file in files)
            {
                AppendFile(file, visitor);
            }

            var metadata = visitor.GetClasses();

            foreach (var cl in metadata)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(cl.IsImplemented ? cl.Name : $"{cl.Name} (Not Implemented)");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var method in cl.Methods)
                {
                    Console.WriteLine("\t" + method);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void AppendFile(string file, GenMetadataVisitor visitor)
        {
            using (var fileStream = new StreamReader(file))
            {
                var inputStream = new AntlrInputStream(fileStream);

                var lexer = new CPP14Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);

                var parser = new CPP14Parser(commonTokenStream);
                var context = parser.translationunit();

                visitor.Append(context);

                if (!CreateJsonDump)
                    return;

                using (var jsonDump = new StreamWriter($"{Path.GetFileName(file)}.json"))
                {
                    jsonDump.Write("{");

                    for (var i = 0; i < context.ChildCount; i++)
                    {
                        if (i != 0)
                            jsonDump.Write(",");

                        Dump(jsonDump, context.GetChild(i));
                    }

                    jsonDump.Write("}");
                }
            }
        }

        private static void Dump(TextWriter file, IParseTree Tree)
        {
            if (Tree.ChildCount == 0)
            {
                file.Write($"\"Terminal\": \"{Tree.GetText()}\"");
            }
            else
            {
                var name = Tree.GetType().Name.Replace("Context", "");
                file.Write($"\"{name}\":");
                file.Write("{");

                for (var i = 0; i < Tree.ChildCount; i++)
                {
                    if (i != 0)
                        file.Write(",");

                    Dump(file, Tree.GetChild(i));
                }

                file.Write("}");
            }
        }
    }
}