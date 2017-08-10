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
        public static string Main()
        {
            try
            {
                return "123";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}