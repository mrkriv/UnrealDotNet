using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectPointerDescription
    {
        public IntPtr Pointer;
        public IntPtr TypeName;
        public int TypeNameLen;
    }
}