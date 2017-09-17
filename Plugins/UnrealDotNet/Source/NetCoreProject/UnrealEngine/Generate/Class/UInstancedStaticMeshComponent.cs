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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
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

		public static implicit operator UInstancedStaticMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UInstancedStaticMeshComponent ?? new UInstancedStaticMeshComponent(Adress);
		}}}
