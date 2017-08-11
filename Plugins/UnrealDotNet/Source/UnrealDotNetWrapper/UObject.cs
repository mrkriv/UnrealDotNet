using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace UnrealEngine
{
    public partial class UObject
    {
        #region DllImport

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_E(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_W(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_L(string Message);

        #endregion DllImport

        private static readonly Assembly GameLogicAssembly = Assembly.Load(new AssemblyName("GameLogic, Version=1.0.0.0, Culture=neutral"));

        public static Dictionary<IntPtr, object> Wrappers = new Dictionary<IntPtr, object>();

        public static bool AddWrapper(IntPtr Adress, string ClassName)
        {
            if (Wrappers.ContainsKey(Adress))
            {
                ULog_Warning($"Object is already registered. Type:{ClassName}, Adress:{Adress}");
                return false;
            }

            var type = GameLogicAssembly.GetType(ClassName);
            if (type == null)
            {
                ULog_Error($"Failed create object, type {ClassName} not found");
                return false;
            }

            var constructor = type.GetConstructor(new[] { typeof(IntPtr) });
            if (constructor == null)
            {
                ULog_Error($"Failed create object, type {ClassName} not have IntPtr constructor");
                return false;
            }

            var obj = constructor.Invoke(new object[] { Adress });
            Wrappers.Add(Adress, obj);

            ULog_Debug($"Create object, Type:{ClassName}, Adress:{Adress}");
            return true;
        }

        public static void CallMethod(IntPtr Adress, string MethodName)
        {
            if (!Wrappers.TryGetValue(Adress, out var obj))
            {
                ULog_Error($"Failed call method {MethodName}, {Adress} not found");
                return;
            }

            var method = obj.GetType().GetMethod(MethodName);
            if (method == null)
            {
                ULog_Error($"Failed call method {MethodName} in {Adress}, method not found in {obj.GetType()}");
                return;
            }

            //ULog_Debug($"Call method {MethodName} in {Adress}"); // disable spam
            method.Invoke(obj, null);
        }

        public static void RemoveWrapper(IntPtr Adress)
        {
            if (Wrappers.Remove(Adress))
            {
                ULog_Debug($"Free object {Adress}");
            }
            else
            {
                ULog_Warning($"Failed free object, {Adress} not found");
            }
        }

        public static void ULog_Debug(string Message)
        {
#if DEBUG
            Call_ULOG_L(Message);
#endif
        }

        public static void ULog(string Message) => Call_ULOG_L(Message);

        public static void ULog_Warning(string Message) => Call_ULOG_W(Message);

        public static void ULog_Error(string Message) => Call_ULOG_E(Message);
    }
}