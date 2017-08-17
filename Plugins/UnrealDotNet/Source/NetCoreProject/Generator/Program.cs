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
            using (var fileStream = new StreamReader(@"C:\Users\vladi\Desktop\Actor.h"))
            {
                var inputStream = new AntlrInputStream(fileStream);

                var lexer = new CPP14Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);

                var parser = new CPP14Parser(commonTokenStream);
                var context = parser.translationunit();

                //foreach (var ch in context.children)
                //{
                //    Dump(ch, 0);
                //}

                //Console.Read();

                var visitor = new GeneratorVisitor();
                visitor.Visit(context);
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