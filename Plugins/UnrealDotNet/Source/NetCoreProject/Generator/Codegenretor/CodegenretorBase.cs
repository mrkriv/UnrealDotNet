using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Generator.Metadata;

namespace Generator
{
    internal partial class Codegenretor
    {
        protected const string DllEditorImportName = "UE4Editor-UnrealDotNetRuntime";
        protected const string DllPaksImportName = "DotUnrealExample.exe";
        protected const string EnginePathSeg = @"Engine\Source\Runtime";

        protected const string ExportPrefix = "E_";
        protected const string ExportOperatorPrefix = ExportPrefix + "OPER_";
        protected const string ExportPropertyPrefix = ExportPrefix + "PROP_";
        protected const string ExportProtectedPrefix = ExportPrefix + "PROTECTED_WRAP_";
        protected const string ExportProtectedPostfix = "_WRAP";
        protected const string CPP_PCH = "UnrealDotNetRuntime";
        protected const string CPP_API = "DOTNET_EXPORT";
        protected const string CPP_API_UE = "UNREALDOTNETRUNTIME_API";

        protected static readonly Regex SummaryParamRegex = new Regex(@"@param\s+(\w+)\s+(.*)");
        protected static readonly Regex SummaryReturnRegex = new Regex(@"@return\s+(.*)");

        public static void GenarateDomain(Domain domain, string OutputDir)
        {
            var outputCS = Path.Combine(OutputDir, "NetCoreProject", "UnrealEngine", "Generate");
            var outputCPP = Path.Combine(OutputDir, "UnrealDotNetRuntime");

            var Watch = new Stopwatch();
            Watch.Start();

            CS.GenarateDomain(domain, outputCS);
            CPP.GenarateDomain(domain, outputCPP);

            Console.WriteLine($"Total generate time {Watch.ElapsedMilliseconds / 1000.0}s");
        }

        private static string GetCPPMethodName(Method method)
        {
            if (method.Operator == null)
            {
                return ExportPrefix + method.OwnerClass.Name + "_" + method.Name;
            }

            return ExportOperatorPrefix + method.OwnerClass.Name + "_" + GetOperatorName(method);
        }

        private static string GetExportConstructorFullName(Method ctr)
        {
            var signature = string.Join("_", ctr.InputTypes.Select(m => m.Type));
            if (signature.Any())
                signature = "_" + signature;

            return $"{ExportPrefix}CreateStruct_{ctr.OwnerClass.Name}{signature}";
        }


        private static string GetOperatorName(Method method)
        {
            return method.Operator
                .Replace('=', 'e')
                .Replace('!', 'n')
                .Replace('+', 'p')
                .Replace('-', 'm')
                .Replace('/', 'd')
                .Replace('*', 'm')
                .Replace('|', 'i')
                .Replace('^', 'u')
                .Replace('[', 'o')
                .Replace(']', 'c');
        }
    }
}