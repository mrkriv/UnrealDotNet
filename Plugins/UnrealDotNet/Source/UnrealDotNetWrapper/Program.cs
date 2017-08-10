using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealDotNetWrapper
{
    public class Program
    {
        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        public static extern bool Call_WasRecentlyRendered();

        public static string Main()
        {
            try
            {
                return Call_WasRecentlyRendered() ? "1" : "0";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}