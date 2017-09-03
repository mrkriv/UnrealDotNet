using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedMesh : NativeStructWrapper
	{
		public FBatchedMesh() : base(E_CreateStruct_FBatchedMesh(), false)
		{
		}

		internal FBatchedMesh(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBatchedMesh();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_FBatchedMesh_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedMesh_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FBatchedMesh_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedMesh_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public byte DepthPriority
		{
			get => E_PROP_FBatchedMesh_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedMesh_DepthPriority_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedMesh_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedMesh_RemainingLifeTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedMesh Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedMesh(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedMesh(Adress, false);
		}}}
