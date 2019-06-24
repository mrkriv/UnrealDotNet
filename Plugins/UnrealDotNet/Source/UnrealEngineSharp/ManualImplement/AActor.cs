using System;
using System.Reflection;
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

        public T SpawnActor<T>(string className, FTransform transform) where T : AActor
        {
            var type = typeof(T);
            
            var manageAttr = type.GetCustomAttribute<ManageTypeAttribute>();
            if (manageAttr != null)
            {
                return (T) E_AActor_SpawnActorManage(NativePointer, className, transform, type.FullName);
            }

            return (T) E_AActor_SpawnActor(NativePointer, className, transform);
        }

        public T SpawnActor<T>(FTransform transform) where T : AActor
        {
            transform = transform ?? new FTransform();

            var type = typeof(T);
            
            var manageAttr = type.GetCustomAttribute<ManageTypeAttribute>();
            if (manageAttr != null)
            {
                return (T) E_AActor_SpawnActorManage(NativePointer, manageAttr.CppTypeName, transform, type.FullName);
            }

            return (T) E_AActor_SpawnActor(NativePointer, type.Name.Substring(1), transform);
        }
    }
}