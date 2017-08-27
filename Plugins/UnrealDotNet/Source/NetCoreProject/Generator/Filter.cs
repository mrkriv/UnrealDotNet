using System.Collections.Generic;
using System.Linq;
using Generator.Metadata;

namespace Generator
{
    public static class Filter
    {
        public static string[] ClassBlackList =
        {
            "FSeamlessTravelHandler"
        };

        public static Dictionary<string, string[]> MethodBlackList = new Dictionary<string, string[]>
        {
            //{
            //    "Class", new[]
            //    {
            //        "Method1",
            //        "Method2"
            //    }
            //}
        };

        public static void FiltreDomainForExport(Domain domain)
        {
            domain.Classes = domain.Classes.Where(ClassFilter).ToList();

            foreach (var cl in domain.Classes)
            {
                cl.Methods = cl.Methods.Where(MethodFilter).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).ToList();
            }
        }

        public static bool ClassFilter(Class cl)
        {
            return cl.IsImplemented &&
                   !cl.IsTemplate && // TODO: поддержка шаблоннх классов
                   cl.BaseClass?.IsImplemented != false &&
                   cl.NamespaceBaseClass == null && // TODO: поддержка вложенных классов
                   cl.Methods.Count + cl.Property.Count != 0 &&
                   !ClassBlackList.Contains(cl.Name);
        }

        public static bool MethodFilter(Method m)
        {
            return !m.IsTemplate &&
                   m.Dependent.All(c => c.IsImplemented && c.NamespaceBaseClass == null) &&
                   m.OwnerClass.Methods.Count(_m => _m.Name == m.Name) == 1 && // TODO: поддержка перегрузок
                   m.Operator?.Contains("=") != true && // TODO: поддержка операторов с присвоением
                   (m.Operator == null || m.InputTypes.Count != 0) && // TODO: поддержка унарных операторов
                   !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                   !m.IsOverride &&
                   !m.IsFriend &&
                   (!MethodBlackList.ContainsKey(m.OwnerClass.Name) || !MethodBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public static bool PropertyFilter(Variable m)
        {
            return (!(m is ClassVariable) || ClassFilter(((ClassVariable)m).ClassType)) &&
                   !m.IsConst; // TODO: константные поля
        }
    }
}