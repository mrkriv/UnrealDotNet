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

            "FPrimitiveComponentPostPhysicsTickFunction", // TODO: не экспортировать структуры без конструктора по умочанию
            "FStartPhysicsTickFunction",
            "FEndPhysicsTickFunction",
            "FStartAsyncSimulationFunction",
            "FSkeletalMeshComponentEndPhysicsTickFunction",
            "FSkeletalMeshComponentClothTickFunction",
            "FAsyncPreRegisterDDCRequest",
            "FFixedUObjectArray",
            "FScopedLevelCollectionContextSwitch",

            "FWorldDelegates",
            "FSkelMeshSkinWeightInfo",

            "FRenderStateRecreator",
        };

        public static string[] ManageClassBlackList =
        {
            "UScene",
            "UWorldProxy",
            "UObject",
            "UObjectBase",
            "UObjectBaseUtility",
            "UEngineBaseTypes",

            "UPostProcessComponent",    // TODO: понять почему не линкует перегруженные методы в базовых классах
            "UBrushComponent",
            "UDrawFrustumComponent",
            "UDrawSphereComponent",
            "UVectorFieldComponent",
            "UReflectionCaptureComponent",
            "UBoxReflectionCaptureComponent",
            "UPlaneReflectionCaptureComponent",
            "USphereReflectionCaptureComponent",
            "UTimelineComponent",
            "ULightmassPortalComponent",
            "UPlanarReflectionComponent",
        };

        public static string[] NewObjectBlackList =
        {
            "UScene",
            "UWorldProxy",
            "UObjectBase",
            "UObjectBaseUtility",
            "UEngineBaseTypes",
        };

        public static string[] EnumBlackList =
        {
            "Type",
        };

        public static string[] UseConvertFromManageTypeList =
        {
            "TCHAR",
            "FText",
            "FName",
            "FString",
        };


        public static string[] DelegateBlackList =
        {
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

            { "AActor", new[] { "ActorGetDistanceToCollision" }}, // TODO: указатель на указатель **
            

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
            var classes = Classes.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();

            foreach (var cl in classes)
            {
                cl.IsReadOnly = ReadOnlyClass.Any(name => cl.IsChild(name));

                cl.Methods = cl.Methods.Where(MethodFilter).OrderBy(m => m.Name).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).OrderBy(p => p.Name).ToList();

                FilterConstructors(cl);

                RemoveMethodDublicatedName(cl);
            }

            return classes;
        }

        public static List<Delegate> FilterDelegates(IEnumerable<Delegate> Delegates)
        {
            var delegates = Delegates.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();
            return delegates;
        }

        public static List<Enum> FilterEnum(IEnumerable<Enum> enums)
        {
            return enums.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();
        }

        private static void FilterConstructors(Class cl)
        {
            if (!cl.Constructors.Any())
            {
                var ctr = new Method(cl.Name)
                {
                    ReturnType = new ClassVariable(cl),
                    OwnerClass = cl,
                };

                cl.Constructors.Add(ctr);
            }
            else
            {
                cl.Constructors = cl.Constructors.Where(MethodFilter)
                    .Where(m=>m.AccessModifier == AccessModifier.Public).OrderBy(m => m.Name).ToList();

                foreach (var m in cl.Constructors)
                {
                    var counter = 0;
                    foreach (var t in m.InputTypes)
                    {
                        t.Name = t.Name ?? "_p" + counter++;
                    }
                }
            }
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

        private static bool ClassFilter(Class cl)
        {
            return (cl.BaseClass == null || TypeFilter(cl.BaseClass)) &&
                   !ClassBlackList.Contains(cl.Name);
        }

        private static bool EunmFilter(Enum en)
        {
            return en.Fields.Any() &&
                    !EnumBlackList.Contains(en.Name);
        }

        public static bool FilterDelegate(Delegate dlg)
        {
            return 
                dlg.Dependent.All(TypeFilter) &&
                !DelegateBlackList.Contains(dlg.Name);
        }

        public static bool TypeFilter(Type type)
        {
            if (!type.IsImplemented ||
                type.IsTemplate ||
                type.NamespaceBaseType != null)
                return false;

            var en = type as Enum;
            if (en != null)
                return EunmFilter(en);

            var cl = type as Class;
            if (cl != null)
                return ClassFilter(cl);

            var dlg = type as Delegate;
            if (dlg != null)
                return FilterDelegate(dlg);

            return true;
        }

        public static bool MethodFilter(Method m)
        {
            return !m.IsTemplate &&
                    !m.ReturnType.IsConst && // TODO: возвращать константные ссылки
                    !m.IsOverride &&
                    !m.IsFriend &&
                    !m.InputTypes.Any(v => (v.IsPointer && v.IsReference) || v.Type == "void" || v.IsReadOnly()) &&
                    (!m.IsVirtual || m.Operator == null && !m.OwnerClass.IsFinal && m.ReturnType.Type == "void") &&
                    m.Dependent.All(TypeFilter) &&
                    m.OwnerClass.Methods.Count(_m => _m.Name == m.Name) <= 1 && // TODO: поддержка перегрузок
                    m.Operator == null &&
                    (m.AccessModifier == AccessModifier.Public || !m.OwnerClass.IsStructure && !m.OwnerClass.IsFinal) &&
                    (!MethodBlackList.ContainsKey(m.OwnerClass.Name) || !MethodBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public static bool PropertyFilter(Variable m)
        {
            if (m.IsConst)
                return false;

            if (m is ClassVariable && !TypeFilter(((ClassVariable)m).Class))
                return false;

            if (m is ClassVariable && m.IsPointer && ((ClassVariable)m).Class.IsStructure)
                return false;

            if (m is EnumVariable && !TypeFilter(((EnumVariable)m).Enum))
                return false;

            if (m is DelegateVariable && !TypeFilter(((DelegateVariable)m).Delegate))
                return false;

            return true;
        }

        public static IEnumerable<Method> GetVirtualMethods(Class Class)
        {
            if (!IsManageClass(Class))
                return new Method[0];

            return Class.Methods.Where(m => m.IsVirtual && !m.IsOverride && !m.IsConst && m.ReturnType.Type == "void" && m.InputTypes.All(t => !t.IsReadOnly()));
        }

        public static bool IsManageClass(Class Class)
        {
            if (ManageClassBlackList.Contains(Class.Name))
                return false;

            if (Class.IsFinal || Class.IsStructure)
                return false;

            while (Class != null)
            {
                if (Class.Methods.Any(m => m.IsVirtual))
                    return true;

                Class = Class.BaseClass;
            }

            return false;
        }
    }
}