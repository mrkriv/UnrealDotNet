using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class NativeStructWrapper : NativeWrapper
    {
        protected readonly bool IsRef;

        [DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern void E_DeleteStruct(IntPtr Adress);

        public NativeStructWrapper(IntPtr NativePointer) : base(NativePointer)
        {
            IsRef = false;
        }

        internal NativeStructWrapper(IntPtr NativePointer, bool IsRef) : base(NativePointer)
        {
            this.IsRef = IsRef;
        }
    }
}