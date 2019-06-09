using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class AActor
    {
        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern ObjectPointerDescription E_AActor_CreateDefaultSubobject(IntPtr ptr, string className, string componentName);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern ObjectPointerDescription E_AActor_SpawnActor(IntPtr ptr, string className, IntPtr transform);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern ObjectPointerDescription E_AActor_SpawnActorManage(IntPtr ptr, string className, IntPtr transform, string manageClassName);

        public T CreateDefaultSubobject<T>(string subobjectName) where T : UActorComponent
        {
            return (T) E_AActor_CreateDefaultSubobject(this, typeof(T).Name.Substring(1), subobjectName);
        }

        public T SpawnActor<T>(string className, FTransform transform = null) where T : AActor
        {
            return (T) E_AActor_SpawnActor(NativePointer, className, transform);
        }
        
        public T SpawnActor<T>(FTransform transform = null) where T : AActor
        {
            transform = transform ?? new FTransform();

            var type = typeof(T);

            //if (type.BaseType.Name.StartsWith("Manage"))
            //    type = type.BaseType;

            if (type.BaseType.Name.StartsWith("Manage"))
            {
                return (T) E_AActor_SpawnActorManage(NativePointer, type.BaseType.Name, transform, typeof(T).Name);
            }

            return (T) E_AActor_SpawnActor(NativePointer, type.Name.Substring(1), transform);
        }
    }
}