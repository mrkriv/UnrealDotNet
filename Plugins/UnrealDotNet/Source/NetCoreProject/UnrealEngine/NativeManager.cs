using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace UnrealEngine
{
    public static class NativeManager
    {
#if PACING
        public const string UnrealDotNetDLL = "DotUnrealExample.exe";
#else
        public const string UnrealDotNetDLL = "UE4Editor-UnrealDotNetRuntime";
#endif

        private static Assembly GameLogicAssembly;
        private static Dictionary<IntPtr, object> Wrappers = new Dictionary<IntPtr, object>();

        static NativeManager()
        {
            try
            {
                GameLogicAssembly =
                    Assembly.Load(new AssemblyName("GameLogicXXXXXXXX, Version=1.0.0.0, Culture=neutral"));
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error(e.ToString());
            }
        }

        public static string UpdateGameLib(string BinariesPath, string guid)
        {
            try
            {
                GameLogicAssembly =
                    AssemblyLoadContext.Default.LoadFromAssemblyPath(BinariesPath + @"\HotReload\GameLogic" + guid +
                                                                     ".dll");
                Wrappers = new Dictionary<IntPtr, object>();

                return GameLogicAssembly?.FullName ?? "";
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error(e.ToString());
                return "";
            }
        }

        public static T GetWrapper<T>(ObjectPointerDescription PtrDesc) where T : NativeWrapper
        {
            if (PtrDesc.Pointer == IntPtr.Zero)
                return null;

            if (Wrappers.TryGetValue(PtrDesc.Pointer, out var result))
                return result as T;

            var CppClass = Marshal.PtrToStringUTF8(PtrDesc.TypeName, PtrDesc.TypeNameLen);

            var asm = typeof(NativeWrapper).Assembly;
            var type = asm.GetType("UnrealEngine." + CppClass);

            if (type == null)
            {
                UObjectBaseUtility.ULog_Warning($"Manage type {CppClass} not found, use {typeof(T).FullName}");
                type = typeof(T);
            }

            var ctor = type.GetConstructor(new[] { typeof(IntPtr) });

            if (ctor == null)
            {
                UObjectBaseUtility.ULog_Error($"Type {type.FullName} not contains constructor {type.Name}(IntPtr)");
                return null;
            }

            var obj = ctor.Invoke(new[] { (object)PtrDesc.Pointer }) as T;

            return obj;
        }

        public static void AddNativeWrapper(IntPtr Adress, NativeWrapper ManageObject)
        {
            Wrappers.Add(Adress, ManageObject);
        }

        public static bool AddWrapper(IntPtr Adress, string DotnetTypeName)
        {
            var TypeName = JsonConvert.DeserializeObject<FDotnetTypeName>(DotnetTypeName);
            var ClassName = TypeName.FullName;

            if (Wrappers.ContainsKey(Adress))
            {
                UObjectBaseUtility.ULog_Warning($"Object is already registered. Type:{ClassName}, Adress:{Adress}");
                return false;
            }

            var type = GameLogicAssembly.GetType(ClassName);
            if (type == null)
            {
                UObjectBaseUtility.ULog_Error($"Failed create object, type {ClassName} not found");
                return false;
            }

            var constructor = type.GetConstructor(new[] { typeof(IntPtr) });
            if (constructor == null)
            {
                UObjectBaseUtility.ULog_Error($"Failed create object, type {ClassName} not have IntPtr constructor");
                return false;
            }

            try
            {
                var obj = constructor.Invoke(new object[] { Adress });
                foreach (var prop in TypeName.PropertyValue)
                {
                    var pi = obj.GetType().GetProperty(prop.Name);

                    if (pi == null)
                    {
                        UObjectBaseUtility.ULog_Error($"Type {ClassName} have not {prop.Name}");
                        continue;
                    }

                    try
                    {
                        pi.SetValue(obj, Convert.ChangeType(prop.Value, pi.PropertyType), null);
                    }
                    catch
                    {
                        UObjectBaseUtility.ULog_Error($"Failed convert '{prop.Value}' to {pi.PropertyType.FullName} (In {ClassName}.{prop.Name})");
                    }
                }

                Wrappers.Add(Adress, obj);
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error($"Failed create object, exception:{e}\n{e.StackTrace}");
                return false;
            }

            UObjectBaseUtility.ULog_Debug($"Create object, Type:{ClassName}, Adress:{Adress}");
            return true;
        }

        public static void InvokeEvent(IntPtr Adress, string EventFieldName, IntPtr Arguments, int Size)
        {
            try
            {
                if (!Wrappers.TryGetValue(Adress, out var obj))
                {
                    UObjectBaseUtility.ULog_Error($"Failed call event {EventFieldName}, {Adress} not found");
                    return;
                }

                var method = obj.GetType().GetMethod(EventFieldName, BindingFlags.Instance | BindingFlags.NonPublic);
                
                if (method == null)
                {
                    UObjectBaseUtility.ULog_Error(
                        $"Failed call event {EventFieldName} in {Adress}, event not found in {obj.GetType()}");
                    return;
                }

                var Params = ParceParams(method, Arguments, Size, out var IsSuccess);
                if (!IsSuccess)
                {
                    UObjectBaseUtility.ULog_Error(
                        $"Failed call method {method.Name}, method have {method.GetParameters().Length} arguments, size not match");
                    return;
                }

                method.Invoke(obj, Params);
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error($"Exception:{e}\n{e.StackTrace}");
            }
        }

        public static void Invoke(IntPtr Adress, string MethodName, IntPtr Arguments, int Size)
        {
            try
            {
                if (!Wrappers.TryGetValue(Adress, out var obj))
                {
                    UObjectBaseUtility.ULog_Error($"Failed call method {MethodName}, {Adress} not found");
                    return;
                }

                var method = obj.GetType().GetMethod(MethodName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                if (method == null)
                {
                    UObjectBaseUtility.ULog_Error(
                        $"Failed call method {MethodName} in {Adress}, method not found in {obj.GetType()}");
                    return;
                }

                var Params = ParceParams(method, Arguments, Size, out var IsSuccess);
                if (!IsSuccess)
                {
                    UObjectBaseUtility.ULog_Error(
                        $"Failed call method {method.Name}, method have {method.GetParameters().Length} arguments, size not match");
                    return;
                }
                
                method.Invoke(obj, Params);
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error($"Exception:{e}\n{e.StackTrace}");
            }
        }

        private static object[] ParceParams(MethodBase Method, IntPtr Arguments, int Size, out bool IsSuccess)
        {
            var spec = Method.GetParameters();
            var Params = spec.Length == 0 ? null : new object[spec.Length];

            if (Params != null)
            {
                var buff = new byte[Size];
                Marshal.Copy(Arguments, buff, 0, Size);

                using (var br = new BinaryReader(new MemoryStream(buff)))
                {
                    try
                    {
                        for (var i = 0; i < spec.Length; i++)
                        {
                            Params[i] = PropertyConvert.ParceObjectFromByteStream(spec[i].ParameterType, br);
                        }
                    }
                    catch (EndOfStreamException)
                    {
                        IsSuccess = false;
                        return null;
                    }
                }
            }

            IsSuccess = true;
            return Params;
        }

        public static void RemoveWrapper(IntPtr Adress)
        {
            if (Wrappers.Remove(Adress))
            {
                UObjectBaseUtility.ULog_Debug($"Free object {Adress}");
            }
            else
            {
                UObjectBaseUtility.ULog_Warning($"Failed free object, {Adress} not found");
            }
        }

        public static string GetMetadata()
        {
            try
            {
                var classes = GameLogicAssembly.GetTypes().Where(t => t.IsSubclassOf(typeof(UObject)));

                return JsonConvert.SerializeObject(
                    new
                    {
                        Types = classes.Select(t => new
                        {
                            Name = t.FullName,
                            Base = t.BaseType.Name,
                            Propertys = t.GetProperties().Where(PropertyConvert.FilterPropertyForEditor).Select(p => new
                            {
                                Name = p.Name,
                                Type = p.PropertyType.FullName,
                                CanEdit = PropertyConvert.CanEditPropertyInEditor(p),
                                Default = p.GetDefaultValue<object>()?.ToString() ?? ""
                            })
                        })
                    });
            }
            catch (Exception e)
            {
                UObjectBaseUtility.ULog_Error($"Exception:{e}\n{e.StackTrace}");
                return "";
            }
        }
    }
}