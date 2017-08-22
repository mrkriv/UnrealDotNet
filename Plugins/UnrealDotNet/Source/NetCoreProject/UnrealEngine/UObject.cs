using System;
using System.Collections.Generic;
using System.Drawing;
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
        private static extern void E_ScreenDebugMessage(string Message, float Time, byte R, byte G, byte B);
#else

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_E(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_W(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ULOG_L(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void E_ScreenDebugMessage(string Message, float Time, byte R, byte G, byte B);

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

        public static void ScreenDebugMessage(string Message, float Time = 2.0f) => ScreenDebugMessage(Message, Time, Color.Gold);

        public static void ScreenDebugMessage(string Message, float Time, Color Color)
        {
            E_ScreenDebugMessage(Message, Time, Color.R, Color.G, Color.B);
        }
    }
}