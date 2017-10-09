using System;

namespace UnrealEngine
{
    public class TArray<T> : NativeWrapper
    {
        public TArray(IntPtr Adress) : base(Adress)
        {
        }

        public static implicit operator IntPtr(TArray<T> Self)
        {
            return Self.NativePointer;
        }

        public static implicit operator TArray<T>(TemplatePointerDescription desc)
        {
            return desc.Pointer == IntPtr.Zero ? null : new TArray<T>(desc.Pointer);
        }
    }
}