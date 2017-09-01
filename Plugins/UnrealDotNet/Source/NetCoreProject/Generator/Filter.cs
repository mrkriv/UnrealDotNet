using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Generator.Metadata;

namespace Generator
{
    public static class Filter
    {
        private static readonly Regex replaceRegex = new Regex("(,?[A-Z_]+_API)|(PRAGMA_[A-Z_]+)");

        public static string[] ClassBlackList =
        {
            "FSeamlessTravelHandler",
            "FLevelCollection",
            "FWorldAsyncTraceState",
            "FMarkActorIsBeingDestroyed",
            "FSplinePositionLinearApproximation",
            "FStaticMeshComponentLODInfo",
            "FGaussianSumBloomSettings",
            "FPendingAutoReceiveInputActor",
            "FPrecomputedVolumeDistanceField",
            "FPrecomputedVisibilityHandler",
        };

        public static string[] ClassImplementedList =
        {
            //"UObjectBaseUtility",
        };

        public static Dictionary<string, string[]> MethodBlackList = new Dictionary<string, string[]>
        {
            { "UObjectBase", new[] { "Register" }},
            { "UObject", new[] { "PreSaveRoot" }},

            { "UObjectBaseUtility", new[] { "CreateClusterFromObject" }},
            { "UModelComponent", new[] { "CommitSurfaces" }},
            { "ULightmassPortalComponent", new[] { "UpdatePreviewShape" }},
            { "UWindDirectionalSourceComponent", new[] { "SetStrength" }},
            { "USceneCaptureComponent", new[] { "GetSettingForShowFlag" }},
        };

        public static string FilterSourceCode(string code)
        {
            return replaceRegex.Replace(code, "");
        }

        public static void FiltreDomainForExport(Domain domain)
        {
            domain.Classes = domain.Classes.Where(ClassFilter).ToList();

            foreach (var cl in domain.Classes)
            {
                cl.Methods = cl.Methods.Where(MethodFilter).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).ToList();

                RemoveMethodDublicatedName(cl);
            }
        }

        private static void RemoveMethodDublicatedName(Class cl)
        {
            foreach (var method in cl.Methods)
            {
                if (!method.UMeta.TryGetValue("DisplayName", out var name))
                    continue;

                var dublicated = cl.Methods.Where(m => m.Name == name || m.UMeta.ContainsKey("DisplayName") && m.UMeta["DisplayName"] == name)
                    .ToList();

                if (dublicated.Count > 1)
                {
                    dublicated.ForEach(m => m.UMeta.Remove("DisplayName"));
                }
            }
        }

        public static bool ClassFilter(Class cl)
        {
            return cl.IsImplemented &&
                   !cl.IsTemplate && // TODO: поддержка шаблоннх классов
                   (cl.BaseClass == null || ClassFilter(cl.BaseClass) || ClassImplementedList.Contains(cl.BaseClass.Name)) &&
                   cl.NamespaceBaseClass == null && // TODO: поддержка вложенных классов
                   !ClassBlackList.Contains(cl.Name);
        }

        public static bool MethodFilter(Method m)
        {
            return !m.IsTemplate &&
                    m.InputTypes.All(v => (v.IsPointer && v.IsReference) != true && v.Type != "void") &&
                    m.Dependent.All(ClassFilter) &&
                    m.OwnerClass.Methods.Count(_m => _m.Name == m.Name) == 1 && // TODO: поддержка перегрузок
                    m.Operator == null && // TODO: поддержка операторов
                                          //(m.Operator == null || m.InputTypes.Count != 0) && // TODO: поддержка унарных операторов
                    !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                    !m.IsOverride &&
                    !m.IsFriend &&
                    (!MethodBlackList.ContainsKey(m.OwnerClass.Name) || !MethodBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public static bool PropertyFilter(Variable m)
        {
            return (!(m is ClassVariable) || ClassFilter(((ClassVariable)m).ClassType)) &&
                    m.NeedRefOperator() == false &&
                   !m.IsConst; // TODO: константные поля
        }
    }
}