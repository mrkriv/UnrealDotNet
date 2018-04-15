using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Generator.Metadata;

namespace Generator
{
    public static class Filter
    {
        private static readonly Regex ReplaceRegex = new Regex("(,?[A-Z_]+_API)|(PRAGMA_[A-Z_]+)");

        public static readonly string[] ClassBlackList =
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

            "FWorldDelegates",
            "FSkelMeshSkinWeightInfo",

            "FRenderStateRecreator",

            "FNamedNetDriver",  // todo:: "xxx *" в "const xxx &"
            "FTickPrerequisite",

            "EOptimizeMode",
            
            "FCollisionImpactData",  // todo:: не линкует
            "FRigidBodyContactInfo",
            "FSwarmDebugOptions",
            "FAnimUpdateRateParameters",
            "FTimerHandle",

            "FCompareFActorPriority",   // todo: переименовывать поля с именами, которые совподают с ключивыми словами C# (метод operator)

            "UActorChannel",    // todo: не генерировать manage оболочку для классов не наследованных от UObject

            "FExampleArray",    // необъявленный идентификатор
            "FExampleItemEntry",
            "FExampleStruct",

            "FQueuedDemoPacket",
            "FNetGUIDCache",

            "UAssetManager",

            "FQueuedReplayTask", // todo: не экспортировать абстрактные структруты

            "APlanarReflection", // невозможно преобразовать "UPlanarReflectionComponent *" в "UObject *", но почему?
            "ULevelActorContainer", // невозможно преобразовать "ULevelActorContainer *" в "UObject *"

            "IBlendableInterface", // todo: различать интерфейсы
            "IImportantToggleSettingInterface",

            "FPrimitiveComponentPostPhysicsTickFunction",   // ExecuteTick абстрактный
            "FCharacterMovementComponentPostPhysicsTickFunction",
            "FSkeletalMeshComponentEndPhysicsTickFunction",
            "FSkeletalMeshComponentClothTickFunction",
            "FStartPhysicsTickFunction",
            "FEndPhysicsTickFunction",
            "FStartAsyncSimulationFunction",
        };

        public static readonly Regex[] ManualImplementedClassMasks =
        {
            new Regex(@"TArray__\w+"),
        };

        public static readonly string[] ManageClassBlackList =
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

            "UAssetManager",
            "UTexture",

            "UShapeComponent",  // todo: не найдена соответствующая перегруженная функция
        };

        public static readonly string[] NewObjectBlackList =
        {
            "UScene",
            "UWorldProxy",
            "UObjectBase",
            "UObjectBaseUtility",
            "UEngineBaseTypes",
        };

        public static readonly string[] EnumBlackList =
        {
            "Type",
            "EShrinkCapsuleExtent",
        };

        public static readonly Dictionary<string, string> UseConvertToManageType = new Dictionary<string, string>
        {
            { "TCHAR", "StringWrapper"},
            { "FName", "StringWrapper"},
            { "FText", "StringWrapper"},
            { "FString", "StringWrapper"},
        };

        public static readonly Dictionary<string, string> UseConvertFromManageType = new Dictionary<string, string>
        {
            { "TCHAR", "char*"},
            { "FName", "char*"},
            { "FText", "char*"},
            { "FString", "char*"},
        };

        public static readonly string[] DelegateBlackList =
        {
        };

        public static readonly Dictionary<string, string[]> MethodInClassBlackList = new Dictionary<string, string[]>
        {
            { "UObjectBase", new[] { "Register" }},
            { "UObject", new[] { "PreSaveRoot", "Implements" }},

            { "UObjectBaseUtility", new[] { "CreateClusterFromObject" }},
            { "UModelComponent", new[] { "CommitSurfaces" }},
            { "ULightmassPortalComponent", new[] { "UpdatePreviewShape" }},
            { "UWindDirectionalSourceComponent", new[] { "SetStrength" }},
            { "USceneCaptureComponent", new[] { "GetSettingForShowFlag" }},
            { "UAudioComponent", new[] { "UpdateInteriorSettings" }},
            { "UTimelineComponent", new[] { "OnRep_Timeline" }},
            { "UPlanarReflectionComponent", new[] { "UpdatePreviewShape" }},
            { "FNamedNetDriver", new[] { "NetDriverDef" }},
            { "UPrimitiveComponent", new[] { "DispatchBlockingHit" }},
            { "FCollisionResponseContainer", new[] { "UpdateResponsesFromArray", "FillArrayFromResponses" }},

            { "AActor", new[] { "ActorGetDistanceToCollision" }}, // TODO: указатель на указатель **
            { "UTexture", new[] { "GetRunningPlatformData" }},


            { "FURL", new[] { "ToString" }},    // TODO: конвертировать 0 в false
            { "FPoly", new[] { "CalcNormal" }},
        };

        public static readonly Dictionary<string, string[]> PropertyInClassBlackList = new Dictionary<string, string[]>
        {
            { "FWorldContext", new[] { "ExternalReferences" }},
        };

        public static readonly string[] ReadOnlyClass =  // TODO: находить удаленный оператор присваивания
        {
            "FTickFunction",
        };

        public static string FilterSourceCode(string code)
        {
            return ReplaceRegex.Replace(code, "");
        }

        public static List<Class> FilterClasses(IEnumerable<Class> classes)
        {
            var result = classes.Where(MathClass).Where(TypeFilter).OrderBy(cl => cl.Name).ToList();

            foreach (var cl in result)
            {
                cl.IsReadOnly = ReadOnlyClass.Any(name => cl.IsChild(name));

                cl.Methods = cl.Methods.Where(MethodFilter).OrderBy(m => m.Name).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).OrderBy(p => p.Name).ToList();

                FilterConstructors(cl);

                RemoveMethodDublicatedName(cl);
            }

            return result;
        }

        private static bool MathClass(Class cl)
        {
            if (ManualImplementedClassMasks.Any(filter => filter.IsMatch(cl.Name)))
            {
                cl.IsManualImplemented = true;
                cl.IsImplemented = true;
                return false;
            }

            if(cl.IsTemplate)
            {
                return false;
            }

            return true;
        }

        public static List<Delegate> FilterDelegates(IEnumerable<Delegate> delegates)
        {
            var result = delegates.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();
            return result;
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
                    .Where(m => m.AccessModifier == AccessModifier.Public).OrderBy(m => m.Name).ToList();

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
            var primitivs = cl.Methods.Cast<Primitive>().Concat(cl.Property).ToList();

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
            {
                return false;
            }

            if (type.TemplateTypes.Any(x => !TypeFilter(x.Type)))
            {
                return false;
            }

            switch (type)
            {
                case Enum en:
                    return EunmFilter(en);
                case Class cl:
                    return ClassFilter(cl);
                case Delegate dlg:
                    return FilterDelegate(dlg);
            }

            return true;
        }

        public static bool MethodFilter(Method m)
        {
            return !m.ReturnType.IsConst &&
                   !m.IsOverride &&
                   !m.IsFriend &&
                   !m.IsTemplate &&
                   !m.InputTypes.Any(v => (v.IsPointer && v.IsReference) || v.Type.IsVoid || v.IsReadOnly()) &&
                   (!m.IsVirtual || !m.OwnerClass.IsFinal) &&
                   m.Dependent.All(TypeFilter) &&
                   m.OwnerClass.Methods.Count(x => x.Name == m.Name) <= 1 && // TODO: поддержка перегрузок
                   m.Operator == null &&
                   (m.AccessModifier == AccessModifier.Public || !m.OwnerClass.IsStructure && !m.OwnerClass.IsFinal) &&
                   (!MethodInClassBlackList.ContainsKey(m.OwnerClass.Name) ||
                    !MethodInClassBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public static bool PropertyFilter(Variable m)
        {
            if (m.AccessModifier != AccessModifier.Public) // todo: экспортировать protected свойства
                return false;

            if (m.IsPointer && (m.Type as Class)?.IsStructure != false)
                return false;

            if (m.IsConst)
                return false;

            if (PropertyInClassBlackList.ContainsKey(m.OwnerClass.Name) &&
                PropertyInClassBlackList[m.OwnerClass.Name].Contains(m.Name))
                return false;

            if (!TypeFilter(m.Type))
                return false;

            return true;
        }

        public static IEnumerable<Method> GetVirtualMethods(Class Class)
        {
            if (!IsManageClass(Class))
                return new Method[0];

            return Class.Methods.Where(m => m.IsVirtual &&
                                            !m.IsOverride &&
                                            !m.IsConst &&
                                            m.ReturnType.Type.IsVoid &&
                                            m.InputTypes.All(t => !t.IsReadOnly()));
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

        public static bool GetConvertToManageType(Type type, out string toType)
        {
            if (type.IsTemplate)
            {
                toType = "TemplatePointerDescription";
                return true;
            }

            if ((type as Class)?.IsStructure == false)
            {
                toType = "ObjectPointerDescription";
                return true;
            }

            if (UseConvertToManageType.TryGetValue(type.Name, out toType))
                return true;

            return false;
        }

        public static bool IsUseConvertFromManageType(Type type)
        {
            if (UseConvertFromManageType.ContainsKey(type.Name))
                return true;

            return false;
        }
    }
}