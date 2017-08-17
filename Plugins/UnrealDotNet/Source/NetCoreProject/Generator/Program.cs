using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Generator
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var files = new[] { @"C:\Users\vladi\Desktop\Actor.h" };

            var visitor = new GenMetadataVisitor();
            foreach (var file in files)
            {
                AppendFile(file, visitor);
            }

            var metadata = visitor.GetClasses();

            metadata.ForEach(Console.WriteLine);
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

                //foreach (var ch in context.children)
                //{
                //    Dump(ch, 0);
                //}

                //Console.Read();
            }
        }

        private static void Dump(IParseTree Tree, int tab)
        {
            Console.WriteLine($"{new string(' ', tab)}{Tree.GetType().Name}");

            if (Tree.ChildCount == 0)
            {
                var old = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{new string(' ', tab)}{Tree.GetText()}");
                Console.ForegroundColor = old;
            }
            else
            {
                for (var i = 0; i < Tree.ChildCount; i++)
                {
                    Dump(Tree.GetChild(i), tab + 1);
                }
            }
        }
    }
}