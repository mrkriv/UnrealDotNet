using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class AActor
    {
        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern ObjectPointerDescription E_AActor_CreateDefaultSubobject(IntPtr Ptr, string ClassName,
            string ComponentName);

        public T CreateDefaultSubobject<T>(string SubobjectName) where T : UActorComponent
        {
            return (T)E_AActor_CreateDefaultSubobject(this, typeof(T).Name.Substring(1), SubobjectName);
        }
    }
}