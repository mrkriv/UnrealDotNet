using Newtonsoft.Json;
using System;
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
        public const string UnrealDotNetDll = "UE4Editor-UnrealDotNetRuntime";
#endif

        private static Assembly _gameLogicAssembly;
        private static Dictionary<IntPtr, object> _wrappers = new Dictionary<IntPtr, object>();

        static NativeManager()
        {
            try
            {
                _gameLogicAssembly = Assembly.Load(new AssemblyName("GameLogic, Version=1.0.0.0, Culture=neutral"));
            }
            catch (Exception e)
            {
                Ue.LogError(e.ToString());
            }
        }

        public static void ReloadGameLogicAssembly(string assemblyPath)
        {
            try
            {
                _gameLogicAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
                _wrappers = new Dictionary<IntPtr, object>();
            }
            catch (Exception e)
            {
                Ue.LogError(e.ToString());
            }
        }

        public static string GetGameLogicAssemblyName()
        {
            try
            {
                return _gameLogicAssembly?.FullName ?? "null";
            }
            catch (Exception e)
            {
                Ue.LogError(e.ToString());
                return "";
            }
        }

        public static T GetWrapper<T>(ObjectPointerDescription ptrDesc) where T : NativeWrapper
        {
            if (ptrDesc.Pointer == IntPtr.Zero)
                return null;

            if (_wrappers.TryGetValue(ptrDesc.Pointer, out var result))
                return result as T;

            var cppClass = Marshal.PtrToStringUTF8(ptrDesc.TypeName, ptrDesc.TypeNameLen);

            var asm = typeof(NativeWrapper).Assembly;
            var type = asm.GetType("UnrealEngine." + cppClass);

            if (type == null)
                type = typeof(T);

            var ctor = type.GetConstructor(new[] { typeof(IntPtr) });

            if (ctor == null)
            {
                Ue.LogError($"Type {type.FullName} not contains constructor {type.Name}(IntPtr)");
                return null;
            }

            var obj = ctor.Invoke(new[] { (object)ptrDesc.Pointer }) as T;

            return obj;
        }

        public static void AddNativeWrapper(IntPtr adress, NativeWrapper manageObject)
        {
            _wrappers.Add(adress, manageObject);
        }

        public static bool AddWrapper(IntPtr adress, string dotnetTypeName)
        {
            var typeName = JsonConvert.DeserializeObject<FDotnetTypeName>(dotnetTypeName);
            var className = _gameLogicAssembly.GetName().Name + "." + typeName.FullName;

            if (_wrappers.ContainsKey(adress))
            {
                Ue.LogWarning($"Object is already registered. Type:{className}, Adress:{adress}");
                return false;
            }

            var type = _gameLogicAssembly.GetType(className);
            if (type == null)
            {
                Ue.LogError($"Failed create object, type {className} not found");
                return false;
            }

            var constructor = type.GetConstructor(new[] { typeof(IntPtr) });
            if (constructor == null)
            {
                Ue.LogError($"Failed create object, type {className} not have IntPtr constructor");
                return false;
            }

            try
            {
                var obj = constructor.Invoke(new object[] { adress });
                foreach (var prop in typeName.PropertyValue)
                {
                    var pi = obj.GetType().GetProperty(prop.Name);

                    if (pi == null)
                    {
                        Ue.LogError($"Type {className} have not {prop.Name}");
                        continue;
                    }

                    try
                    {
                        pi.SetValue(obj, Convert.ChangeType(prop.Value, pi.PropertyType), null);
                    }
                    catch
                    {
                        Ue.LogError($"Failed convert '{prop.Value}' to {pi.PropertyType.FullName} (In {className}.{prop.Name})");
                    }
                }

                _wrappers.Add(adress, obj);
            }
            catch (Exception e)
            {
                Ue.LogError($"Failed create object, exception:{e}\n{e.StackTrace}");
                return false;
            }

            Ue.LogDebug($"Create object, Type:{className}, Adress:{adress}");
            return true;
        }

        public static void InvokeEvent(IntPtr adress, string eventFieldName, IntPtr arguments, int size)
        {
            try
            {
                if (!_wrappers.TryGetValue(adress, out var obj))
                {
                    Ue.LogError($"Failed call event {eventFieldName}, {adress} not found");
                    return;
                }

                var method = obj.GetType().GetMethod(eventFieldName, BindingFlags.Instance | BindingFlags.NonPublic);

                if (method == null)
                {
                    Ue.LogError(
                        $"Failed call event {eventFieldName} in {adress}, event not found in {obj.GetType()}");
                    return;
                }

                var Params = ParceParams(method, arguments, size, out var isSuccess);
                if (!isSuccess)
                {
                    Ue.LogError(
                        $"Failed call method {method.Name}, method have {method.GetParameters().Length} arguments, size not match");
                    return;
                }

                method.Invoke(obj, Params);
            }
            catch (Exception e)
            {
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
            }
        }

        public static string InvokeStatic(string className, string methodName, string argument)
        {
            try
            {
                className = _gameLogicAssembly.GetName().Name + "." + className;
                var type = _gameLogicAssembly.GetType(className, false, true);

                if (type == null)
                {
                    Ue.LogError($"Failed call method {className}.{methodName}, type {className} id not define");
                    return null;
                }

                var method = type.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                if (method == null)
                {
                    Ue.LogError($"Failed call method {className}.{methodName}, method not found in type {className}");
                    return null;
                }

                var Params = method.GetParameters();
                if (Params.Length > 1)
                {
                    Ue.LogError($"Failed call method {className}.{methodName}, method have {method.GetParameters().Length} arguments, supported 0 or 1 string argument");
                    return null;
                }

                if (Params.Length == 1 && Params[0].ParameterType != typeof(string))
                {
                    Ue.LogError($"Failed call method {className}.{methodName}, only string argument");
                    return null;
                }

                var ags = Params.Length == 1 ? new object[] { argument } : new object[] { };
                var result = method.Invoke(null, ags);
                return result?.ToString();
            }
            catch (Exception e)
            {
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
                return null;
            }
        }

        public static void Invoke(IntPtr adress, string methodName, IntPtr arguments, int size)
        {
            try
            {
                if (!_wrappers.TryGetValue(adress, out var obj))
                {
                    Ue.LogError($"Failed call method {methodName}, {adress} not found");
                    return;
                }

                var method = obj.GetType().GetMethod(methodName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                if (method == null)
                {
                    Ue.LogError(
                        $"Failed call method {methodName} in {adress}, method not found in {obj.GetType()}");
                    return;
                }

                var Params = ParceParams(method, arguments, size, out var isSuccess);
                if (!isSuccess)
                {
                    Ue.LogError(
                        $"Failed call method {method.Name}, method have {method.GetParameters().Length} arguments, size not match");
                    return;
                }

                method.Invoke(obj, Params);
            }
            catch (Exception e)
            {
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
            }
        }

        private static object[] ParceParams(MethodBase method, IntPtr arguments, int size, out bool isSuccess)
        {
            var spec = method.GetParameters();
            var Params = spec.Length == 0 ? null : new object[spec.Length];

            if (Params != null)
            {
                var buff = new byte[size];
                Marshal.Copy(arguments, buff, 0, size);

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
                        isSuccess = false;
                        return null;
                    }
                }
            }

            isSuccess = true;
            return Params;
        }

        public static void RemoveWrapper(IntPtr adress)
        {
            if (_wrappers.Remove(adress))
            {
                Ue.LogDebug($"Free object {adress}");
            }
            else
            {
                Ue.LogWarning($"Failed free object, {adress} not found");
            }
        }

        public static string GetAssemblys()
        {
            try
            {
                var asms = AppDomain.CurrentDomain.GetAssemblies().OrderBy(x => x.FullName).Select(x => x.FullName);
                return string.Join("\n", asms);
            }
            catch (Exception e)
            {
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
                return "";
            }
        }

        public static string GetVersion()
        {
            try
            {
                return Environment.Version.ToString();
            }
            catch (Exception e)
            {
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
                return "";
            }
        }

        public static string GetMetadata()
        {
            try
            {
                var classes = _gameLogicAssembly.GetTypes().Where(t => t.IsSubclassOf(typeof(UObject)));
                var asmName = _gameLogicAssembly.GetName().Name;

                return JsonConvert.SerializeObject(
                    new
                    {
                        Types = classes.Select(t => new
                        {
                            Name = t.FullName.Substring(asmName.Length + 1),
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
                Ue.LogError($"Exception:{e}\n{e.StackTrace}");
                return "";
            }
        }
    }
}