using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Generator.Metadata;

namespace Generator
{
    internal partial class Codegenretor
    {
        protected const string DllEditorImportName = "UE4Editor-UnrealDotNetRuntime";
        protected const string DllPaksImportName = "DotUnrealExample.exe";
        protected const string EnginePathSeg = @"Engine\Source\Runtime";

        protected const string ExportPrefix = "E_";
        protected const string ExportOperatorPrefix = ExportPrefix + "OP_";
        protected const string ExportPropertyPrefix = ExportPrefix + "PR_";
        protected const string CPP_API = "DOTNET_EXPORT";

        public static void GenarateDomain(Domain domain, string OutputDir)
        {
            var outputCS = Path.Combine(OutputDir, "NetCoreProject", "UnrealEngine", "Generate");
            var outputCPP = Path.Combine(OutputDir, "UnrealDotNetRuntime", "Private", "Generate");

            CS.GenarateDomain(domain, outputCS);
            CPP.GenarateDomain(domain, outputCPP);
        }

        private static bool DefaultClassFilter(Class cl)
        {
            return cl.IsImplemented &&
                   !cl.IsTemplate && // TODO: поддержка шаблоннх классов
                   cl.BaseClass?.IsImplemented != false &&
                   cl.NamespaceBaseClass == null && // TODO: поддержка вложенных классов
                   cl.Methods.Count + cl.Property.Count != 0;
        }

        private static bool DefaultMethodFilter(Method m)
        {
            return !m.IsTemplate &&
                   m.Dependent.All(c => c.IsImplemented && c.NamespaceBaseClass == null) &&
                   m.OwnerClass.Methods.Count(_m => _m.Name == m.Name) == 1 && // TODO: поддержка перегрузок
                   m.Operator?.Contains("=") != true && // TODO: поддержка операторов с присвоением
                   (m.Operator == null || m.InputTypes.Count != 0) && // TODO: поддержка унарных операторов
                   !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                   !m.IsOverride &&
                   !m.IsFriend;
        }

        private static bool DefaultPropertyFilter(Variable m)
        {
            return (!(m is ClassVariable) || DefaultClassFilter(((ClassVariable)m).ClassType)) &&
                   !m.IsConst; // TODO: константные поля
        }

        private static string GetCPPMethodName(Method method)
        {
            if (method.Operator == null)
            {
                return ExportPrefix + method.OwnerClass.Name + "_" + method.Name;
            }

            return ExportOperatorPrefix + method.OwnerClass.Name + "_" + GetOperatorName(method);
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