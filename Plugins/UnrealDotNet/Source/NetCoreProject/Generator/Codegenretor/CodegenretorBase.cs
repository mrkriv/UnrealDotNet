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
                   !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                   !m.IsOverride &&
                   m.Operator == null && // TODO: экспортировать операторы
                   !m.isFriend;
        }

        private static bool DefaultPropertyFilter(Variable m)
        {
            return (m as ClassVariable)?.ClassType.IsImplemented != false &&
                   !m.IsConst; // TODO: константные поля
        }

        private static string GetCPPMethodName(Method method)
        {
            if (method.Operator == null)
            {
                return ExportPrefix + method.OwnerClass.Name + "_" + method.Name;
            }

            return ExportOperatorPrefix + method.OwnerClass.Name + "_" + method.Name;
        }
    }
}