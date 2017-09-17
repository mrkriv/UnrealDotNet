using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshInstanceData : NativeStructWrapper
	{
		public FInstancedStaticMeshInstanceData() : base(E_CreateStruct_FInstancedStaticMeshInstanceData(), false)
		{
		}

		internal FInstancedStaticMeshInstanceData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public FVector2D LightmapUVBias_DEPRECATED
		{
			get => E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_GET(NativePointer);
			set => E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_SET(NativePointer, value);
		}

		public FVector2D ShadowmapUVBias_DEPRECATED
		{
			get => E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_GET(NativePointer);
			set => E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshInstanceData Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshInstanceData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshInstanceData(Adress, false);
		}}}
