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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(cl.IsImplemented ? cl.Name : $"{cl.Name} (Not Implemented)");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
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