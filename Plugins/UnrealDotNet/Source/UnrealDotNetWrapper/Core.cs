using System;

namespace UnrealDotNetWrapper
{
    public static class CPPManager
    {
        public static IntPtr MethodMap { get; private set; }
        public static IntPtr PropertyMap { get; private set; }

        public static void BindMap(IntPtr methodMap, IntPtr propertyMap)
        {
            MethodMap = methodMap;
            PropertyMap = propertyMap;
        }
    }
}