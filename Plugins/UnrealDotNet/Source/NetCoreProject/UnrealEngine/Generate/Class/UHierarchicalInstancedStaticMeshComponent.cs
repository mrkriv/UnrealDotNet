using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent
	{
		public UHierarchicalInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UHierarchicalInstancedStaticMeshComponent(UObject Parent = null, string Name = "HierarchicalInstancedStaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UHierarchicalInstancedStaticMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UHierarchicalInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UHierarchicalInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UHierarchicalInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UHierarchicalInstancedStaticMeshComponent>(PtrDesc);
		}}}
