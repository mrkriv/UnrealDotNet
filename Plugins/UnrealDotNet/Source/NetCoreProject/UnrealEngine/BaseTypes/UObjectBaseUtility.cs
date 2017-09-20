using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class UObjectBaseUtility
    {
        #region DllImport

        [DllImport(NativeManager.UnrealDotNetDLL)]
        private static extern void E_ULOG_E(string Message);

        [DllImport(NativeManager.UnrealDotNetDLL)]
        private static extern void E_ULOG_W(string Message);

        [DllImport(NativeManager.UnrealDotNetDLL)]
        private static extern void E_ULOG_L(string Message);

        [DllImport(NativeManager.UnrealDotNetDLL)]
        private static extern void E_ScreenDebugMessage(string Message, float Time, byte R, byte G, byte B);

        [DllImport(NativeManager.UnrealDotNetDLL)]
        private static extern void E_Call_UFunction(IntPtr Object, string NameWithArguments);

        #endregion DllImport

        public static void ULog_Debug(string Message)
        {
            //#if DEBUG
            E_ULOG_L(Message);
            //#endif
        }

        public void CallFunction(string Function) => E_Call_UFunction(NativePointer, Function);

        public void CallFunction(string Function, params object[] Params) => E_Call_UFunction(NativePointer, Function + " " + string.Join(' ', Params));

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