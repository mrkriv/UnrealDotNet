using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FBatchedPoint
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FBatchedPoint()
		{
			NativePointer = E_CreateStruct_FBatchedPoint();
			IsRef = false;
		}

		internal FBatchedPoint(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBatchedPoint();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FBatchedPoint_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedPoint_Position_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FBatchedPoint_PointSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedPoint_PointSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FBatchedPoint_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedPoint_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_FBatchedPoint_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBatchedPoint_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		#endregion
		
		#region Property
		public FVector Position
		{
			get => E_PROP_FBatchedPoint_Position_GET(NativePointer);
			set => E_PROP_FBatchedPoint_Position_SET(NativePointer, value);
		}

		public float PointSize
		{
			get => E_PROP_FBatchedPoint_PointSize_GET(NativePointer);
			set => E_PROP_FBatchedPoint_PointSize_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedPoint_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedPoint_RemainingLifeTime_SET(NativePointer, value);
		}

		public byte DepthPriority
		{
			get => E_PROP_FBatchedPoint_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedPoint_DepthPriority_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedPoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedPoint(Adress, false);
		}}}
