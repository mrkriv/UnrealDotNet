using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Generator.Metadata;

namespace Generator
{
    internal class Codegenretor
    {
        public static void GenarateTo(Domain domain, string OutputDir)
        {
            foreach (var cl in domain.Classes)
            {
                GenerateCS(cl, Path.Combine(OutputDir, cl.Name + ".cs"));
                GenerateCPP(cl, Path.Combine(OutputDir, cl.Name + ".cpp"));
            }
        }

        private static void GenerateCS(Class Class, string OutputPath)
        {
        }

        private static void GenerateCPP(Class Class, string OutputPath)
        {
        }
    }
}