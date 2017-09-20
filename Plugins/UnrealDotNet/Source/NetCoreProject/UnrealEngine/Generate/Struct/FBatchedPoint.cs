using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedPoint : NativeStructWrapper
	{
		internal FBatchedPoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedPoint() :
			base(E_CreateStruct_FBatchedPoint(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedPoint();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBatchedPoint_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedPoint_PointSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_PointSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedPoint_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_Position_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedPoint_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public byte DepthPriority
		{
			get => E_PROP_FBatchedPoint_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedPoint_DepthPriority_SET(NativePointer, value);
		}

		public float PointSize
		{
			get => E_PROP_FBatchedPoint_PointSize_GET(NativePointer);
			set => E_PROP_FBatchedPoint_PointSize_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FBatchedPoint_Position_GET(NativePointer);
			set => E_PROP_FBatchedPoint_Position_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedPoint_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedPoint_RemainingLifeTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedPoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedPoint(Adress, false);
		}
}
}
