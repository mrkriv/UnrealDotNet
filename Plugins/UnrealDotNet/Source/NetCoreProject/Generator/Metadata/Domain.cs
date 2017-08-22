using System;
using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Domain
    {
        public List<Class> Classes = new List<Class>();

        public void Print()
        {
            Console.WriteLine();

            foreach (var cl in Classes)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(cl.IsStructure ? "Struct " : "Class ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(cl.Name);

                if (cl.BaseClass != null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" base of ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(cl.BaseClass.Name);
                }

                if (!cl.IsImplemented)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" (Not Implemented)");
                }

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                foreach (var method in cl.Methods)
                {
                    Console.WriteLine("\t" + method);
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}