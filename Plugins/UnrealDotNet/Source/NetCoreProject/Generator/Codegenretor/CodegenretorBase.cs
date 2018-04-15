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
        protected const string EnginePathSeg = @"Engine\Source";

        protected const string ExportPrefix = "E_";
        protected const string ExportOperatorPrefix = ExportPrefix + "OPER_";
        protected const string ExportPropertyPrefix = ExportPrefix + "PROP_";
        protected const string ExportProtectedPrefix = ExportPrefix + "PROTECTED_WRAP_";
        protected const string ExportProtectedPostfix = "_WRAP";
        protected const string ExportEventAddPrefix = ExportPrefix + "EVENT_ADD_";
        protected const string ExportEventRemovePrefix = ExportPrefix + "EVENT_DEL_";
        protected const string EventPrivatePrefix = "_Event_";
        protected const string EventInvokePrefix = "InvokeEvent_";
        protected const string EventPropertyGetPostfix = "_GET";
        protected const string EventPropertySetPostfix = "_SET";
        protected const string CppPch = "UnrealDotNetRuntime";
        protected const string CppApi = "DOTNET_EXPORT";
        protected const string CppApiUe = "UNREALDOTNETRUNTIME_API";
        protected const bool IsWriteSourceFileName = true;

        protected static readonly Regex SummaryParamRegex = new Regex(@"@param\W+(\w+)\W+(.*)");
        protected static readonly Regex SummaryReturnRegex = new Regex(@"@return\W+(.*)");

        public static void GenarateDomain(Domain domain, string outputDir)
        {
            var outputCs = Path.Combine(outputDir, "NetCoreProject", "UnrealEngine", "Generate");
            var outputCpp = Path.Combine(outputDir, "UnrealDotNetRuntime");

            var watch = new Stopwatch();
            watch.Start();

            Cs.GenarateDomain(domain, outputCs);
            Cpp.GenarateDomain(domain, outputCpp);

            Console.WriteLine($"Total generate time {watch.ElapsedMilliseconds / 1000.0}s");
        }

        private static string GetCppMethodName(Method method)
        {
            return ExportPrefix + method.OwnerClass.Name + "_" + method.Name;
        }

        private static string GetExportConstructorFullName(Method ctr)
        {
            var signature = string.Join("_", ctr.InputTypes.Select(m => m.Type));
            if (signature.Any())
                signature = "_" + signature;

            return $"{ExportPrefix}CreateStruct_{ctr.OwnerClass.Name}{signature}";
        }

        private static void GenerateSourceInfo(CoreWriter cw, Primitive primitive)
        {
            if (IsWriteSourceFileName)
            {
                cw.WriteLine($"// Source file {primitive.SourceFile}:{primitive.SourceLine}");
                cw.WriteLine();
            }
        }
    }
}