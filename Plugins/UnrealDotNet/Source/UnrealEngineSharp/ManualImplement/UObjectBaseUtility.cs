using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class UObjectBaseUtility
    {
        #region DllImport

        [DllImport(NativeManager.UnrealDotNetDll)]
        private static extern void E_Call_UFunction(IntPtr Object, string NameWithArguments);

        #endregion DllImport

        public void CallFunction(string Function) => E_Call_UFunction(NativePointer, Function);

        public void CallFunction(string Function, params object[] Params)
        {
            E_Call_UFunction(NativePointer, Function + " " + string.Join(' ', Params));
        }

        public override string ToString() => GetName();
    }
}