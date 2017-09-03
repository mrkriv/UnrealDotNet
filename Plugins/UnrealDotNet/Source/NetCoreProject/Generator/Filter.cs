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
            "FUObjectItem",

            "UForceFeedbackComponent",
            "USplineComponent",
            "USplineMeshComponent",
            "UApplicationLifecycleComponent",
            "UPlatformEventsComponent",
            "UStereoLayerComponent",
            "UModelComponent",
            "UWindDirectionalSourceComponent",

            "FPrimitiveComponentPostPhysicsTickFunction",
            "FStartPhysicsTickFunction",
            "FEndPhysicsTickFunction",
            "FStartAsyncSimulationFunction",
            "FSkeletalMeshComponentEndPhysicsTickFunction",
            "FSkeletalMeshComponentClothTickFunction",
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
            { "UAudioComponent", new[] { "UpdateInteriorSettings" }},
            { "UTimelineComponent", new[] { "OnRep_Timeline" }},
            { "UPlanarReflectionComponent", new[] { "UpdatePreviewShape" }},

            { "FURL", new[] { "ToString" }},    // TODO: конвертировать 0 в false
        };

        public static string[] ReadOnlyClass =  // TODO: находить удаленный оператор присваивания
        {
            "FTickFunction",
        };

        public static string FilterSourceCode(string code)
        {
            return replaceRegex.Replace(code, "");
        }

        public static List<Class> FilterClasses(IEnumerable<Class> Classes)
        {
            var classes = Classes.Where(ClassFilter).OrderBy(cl => cl.Name).ToList();

            foreach (var cl in classes)
            {
                cl.IsReadOnly = ReadOnlyClass.Any(name => cl.IsChild(name));

                cl.Methods = cl.Methods.Where(MethodFilter).OrderBy(m => m.Name).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).OrderBy(p => p.Name).ToList();

                RemoveMethodDublicatedName(cl);
            }

            return classes;
        }

        private static void RemoveMethodDublicatedName(Class cl)
        {
            var primitivs = cl.Methods.Cast<Primitive>().Concat(cl.Property);

            foreach (var prim in primitivs)
            {
                if (!prim.UMeta.ContainsKey("DisplayName"))
                    continue;

                var name = prim.GetDisplayName();
                var dublicated = primitivs.Where(m => name == m.GetDisplayName()).ToList();

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
                    !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                    !m.IsOverride &&
                    !m.IsFriend &&
                    !m.InputTypes.Any(v => (v.IsPointer && v.IsReference) || v.Type == "void" || v.IsReadOnly()) &&
                    (!m.IsVirtual || m.Operator == null && !m.OwnerClass.IsFinal && m.ReturnType.Type == "void") &&
                    m.Dependent.All(ClassFilter) &&
                    m.OwnerClass.Methods.Count(_m => _m.Name == m.Name) == 1 && // TODO: поддержка перегрузок
                    m.Operator == null && // TODO: поддержка операторов
                                          //(m.Operator == null || m.InputTypes.Count != 0) && // TODO: поддержка унарных операторов
                    (m.AccessModifier == AccessModifier.Public || !m.OwnerClass.IsStructure && !m.OwnerClass.IsFinal) &&
                    (!MethodBlackList.ContainsKey(m.OwnerClass.Name) || !MethodBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public static bool PropertyFilter(Variable m)
        {
            return (!(m is ClassVariable) || ClassFilter(((ClassVariable)m).ClassType)) &&
                    m.NeedRefOperator() == false &&
                   !m.IsConst; // TODO: константные поля
        }

        public static IEnumerable<Method> GetVirtualMethods(Class Class)
        {
            if (Class.IsFinal || Class.IsStructure || Class.Name == "UObjectBase" || Class.Name == "UObjectBaseUtility")
                return new Method[0];

            return Class.Methods.Where(m => m.IsVirtual && !m.IsConst && m.ReturnType.Type == "void");
        }
    }
}