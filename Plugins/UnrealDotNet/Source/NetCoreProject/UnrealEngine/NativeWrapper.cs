using System;

namespace UnrealEngine
{
    public abstract class NativeWrapper
    {
        protected readonly IntPtr NativePointer;

        protected NativeWrapper(IntPtr Adress)
        {
            NativePointer = Adress;
        }
    }
}