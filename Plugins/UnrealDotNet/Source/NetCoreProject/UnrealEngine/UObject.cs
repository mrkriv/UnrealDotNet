using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

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

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern IntPtr Call_GetTranferBufferPtr();

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern Int64 Call_GetTranferBufferOffest();

        #endregion DllImport

        public static void ULog_Debug(string Message)
        {
#if DEBUG
            Call_ULOG_L(Message);
#endif
        }

        public static void ULog(string Message) => Call_ULOG_L(Message);

        public static void ULog_Warning(string Message) => Call_ULOG_W(Message);

        public static void ULog_Error(string Message) => Call_ULOG_E(Message);

        public static IntPtr GetTranferBufferPtr() => Call_GetTranferBufferPtr();

        public static Int64 GetTranferBufferOffest() => Call_GetTranferBufferOffest();
    }
}