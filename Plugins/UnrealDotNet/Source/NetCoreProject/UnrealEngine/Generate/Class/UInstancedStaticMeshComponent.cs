using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UInstancedStaticMeshComponent : UStaticMeshComponent
	{
		public UInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInstancedStaticMeshComponent(UObject Parent = null, string Name = "InstancedStaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInstancedStaticMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInstancedStaticMeshComponent>(PtrDesc);
		}}}
