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

    [StructLayout(LayoutKind.Sequential)]
    public struct StringWrapper
    {
        public IntPtr Pointer;
        public int Len;

        public static implicit operator string(StringWrapper Self)
        {
            return Marshal.PtrToStringUTF8(Self.Pointer, Self.Len);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TemplatePointerDescription
    {
        public IntPtr Pointer;
        public IntPtr TypeName;
        public int TypeNameLen;
    }
}
