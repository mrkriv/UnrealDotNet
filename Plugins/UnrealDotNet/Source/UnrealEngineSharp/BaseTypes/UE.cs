using System.Drawing;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class Ue
    {
        #region DllImport

        [DllImport(NativeManager.UnrealDotNetDll)]
        private static extern void E_ULOG_E(string message);

        [DllImport(NativeManager.UnrealDotNetDll)]
        private static extern void E_ULOG_W(string message);

        [DllImport(NativeManager.UnrealDotNetDll)]
        private static extern void E_ULOG_L(string message);

        [DllImport(NativeManager.UnrealDotNetDll)]
        private static extern void E_ScreenDebugMessage(string message, float time, byte r, byte g, byte b);

        #endregion DllImport

        public static void LogDebug(string message)
        {
            //#if DEBUG
            E_ULOG_L(message);
            //#endif
        }

        public static void Log(string message) => E_ULOG_L(message ?? "null");

        public static void LogWarning(string message) => E_ULOG_W(message ?? "null");

        public static void LogError(string message) => E_ULOG_E(message ?? "null");

        public static void ScreenDebugMessage(string message, float time = 2.0f) => ScreenDebugMessage(message ?? "null", time, Color.Gold);

        public static void ScreenDebugMessage(string message, float time, Color color)
        {
            E_ScreenDebugMessage(message ?? "null", time, color.R, color.G, color.B);
        }
    }
}