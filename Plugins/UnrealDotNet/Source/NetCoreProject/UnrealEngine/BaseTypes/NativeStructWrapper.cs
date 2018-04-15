using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class NativeStructWrapper : NativeWrapper//, IDisposable
    {
        protected readonly bool IsRef;

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern void E_DeleteStruct(IntPtr Adress);

        public NativeStructWrapper(IntPtr NativePointer) : base(NativePointer)
        {
            IsRef = false;
        }

        internal NativeStructWrapper(IntPtr NativePointer, bool IsRef) : base(NativePointer)
        {
            this.IsRef = IsRef;
        }
        
        //public void Dispose()
        //{
        //    UObjectBaseUtility.ULog_Debug("Dispose " + GetType().FullName);

        //    if (!IsRef)
        //        E_DeleteStruct(NativePointer);
        //}

        //~NativeStructWrapper()
        //{
        //    Dispose();
        //}
    }
}