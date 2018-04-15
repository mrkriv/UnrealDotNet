using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:74

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>This was prebuilt, grass system use it, never destroy it. </para>
		/// </summary>
		public bool bPerInstanceRenderDataWasPrebuilt
		{
			get => E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(NativePointer);
			set => E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInstancedStaticMeshComponent>(PtrDesc);
		}}}
