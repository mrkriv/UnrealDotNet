using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class NativeStructWrapper : NativeWrapper//, IDisposable
    {
        protected readonly bool IsRef;

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern void E_DeleteStruct(IntPtr adress);
        
        internal NativeStructWrapper(IntPtr nativePointer, bool isRef) : base(nativePointer)
        {
            IsRef = isRef;
        }
        
        //public void Dispose()
        //{
        //    UE.LogDebug("Dispose " + GetType().FullName);

        //    if (!IsRef)
        //        E_DeleteStruct(NativePointer);
        //}

        //~NativeStructWrapper()
        //{
        //    Dispose();
        //}
    }
}