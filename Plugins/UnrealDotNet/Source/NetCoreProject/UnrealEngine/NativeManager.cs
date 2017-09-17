using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.ComponentModel;

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

        public static object GetWrapper(IntPtr Adress)
        {
            Wrappers.TryGetValue(Adress, out var result);
            return result;
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

                //UObjectBaseUtility.ULog_Debug($"Call method {MethodName} in {Adress}");
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
                            if (spec[i].ParameterType == typeof(IntPtr))
                            {
                                Params[i] = Marshal.SizeOf<IntPtr>() == Marshal.SizeOf<Int32>()
                                    ? (IntPtr)br.ReadInt32()
                                    : (IntPtr)br.ReadInt64();
                            }
                            else
                            {
                                switch (Type.GetTypeCode(spec[i].ParameterType))
                                {
                                    case TypeCode.String:
                                        Params[i] = br.ReadString();
                                        break;

                                    case TypeCode.Boolean:
                                        Params[i] = br.ReadBoolean();
                                        break;

                                    case TypeCode.Single:
                                        Params[i] = br.ReadSingle();
                                        break;

                                    case TypeCode.Byte:
                                        Params[i] = br.ReadByte();
                                        break;

                                    case TypeCode.Char:
                                        Params[i] = br.ReadChar();
                                        break;

                                    case TypeCode.Int16:
                                        Params[i] = br.ReadInt16();
                                        break;

                                    case TypeCode.Int32:
                                        Params[i] = br.ReadInt32();
                                        break;

                                    case TypeCode.Int64:
                                        Params[i] = br.ReadInt64();
                                        break;

                                    case TypeCode.Double:
                                        Params[i] = br.ReadDouble();
                                        break;
                                }
                            }
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
    }
}