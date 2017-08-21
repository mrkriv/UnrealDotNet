using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class UObject
    {
        protected IntPtr NativePointer { get; }

        #region DllImport

#if PACING
		[DllImport("DotUnrealExample.exe")]
        private static extern void E_ULOG_E(string Message);

        [DllImport("DotUnrealExample.exe")]
        private static extern void E_ULOG_W(string Message);

        [DllImport("DotUnrealExample.exe")]
        private static extern void E_ULOG_L(string Message);

        [DllImport("DotUnrealExample.exe")]
        private static extern IntPtr E_GetTranferBufferPtr();

        [DllImport("DotUnrealExample.exe")]
        private static extern Int64 E_GetTranferBufferOffest();
#else

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_E(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_W(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_L(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern IntPtr E_GetTranferBufferPtr();

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern Int64 E_GetTranferBufferOffest();

#endif

        #endregion DllImport

        public UObject(IntPtr Adress)
        {
            NativePointer = Adress;
        }

        public static void ULog_Debug(string Message)
        {
            //#if DEBUG
            E_ULOG_L(Message);
            //#endif
        }

        public static void ULog(string Message) => E_ULOG_L(Message);

        public static void ULog_Warning(string Message) => E_ULOG_W(Message);

        public static void ULog_Error(string Message) => E_ULOG_E(Message);

        public static IntPtr GetTranferBufferPtr() => E_GetTranferBufferPtr();

        public static Int64 GetTranferBufferOffest() => E_GetTranferBufferOffest();
    }
}