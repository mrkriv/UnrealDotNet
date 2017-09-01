using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FInstancedStaticMeshInstanceData
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FInstancedStaticMeshInstanceData()
		{
			NativePointer = E_CreateStruct_FInstancedStaticMeshInstanceData();
			IsRef = false;
		}

		internal FInstancedStaticMeshInstanceData(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_SET(IntPtr Ptr, FVector2D Value);
		
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
