using System;

namespace UnrealEngine
{
    public class TArray<T> : NativeWrapper
    {
        public TArray(IntPtr adress) : base(adress)
        {
        }

        public static implicit operator IntPtr(TArray<T> self)
        {
            return self.NativePointer;
        }

        public static implicit operator TArray<T>(TemplatePointerDescription desc)
        {
            return desc.Pointer == IntPtr.Zero ? null : new TArray<T>(desc.Pointer);
        }
    }
}