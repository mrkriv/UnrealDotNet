using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FInterpControlPoint : NativeStructWrapper
	{
		public FInterpControlPoint() : base(E_CreateStruct_FInterpControlPoint(), false)
		{
		}

		internal FInterpControlPoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FInterpControlPoint();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FInterpControlPoint_bPositionIsRelative_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInterpControlPoint_bPositionIsRelative_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FInterpControlPoint_DistanceToNext_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInterpControlPoint_DistanceToNext_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FInterpControlPoint_Percentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInterpControlPoint_Percentage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FInterpControlPoint_PositionControlPoint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInterpControlPoint_PositionControlPoint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FInterpControlPoint_StartTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FInterpControlPoint_StartTime_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public bool bPositionIsRelative
		{
			get => E_PROP_FInterpControlPoint_bPositionIsRelative_GET(NativePointer);
			set => E_PROP_FInterpControlPoint_bPositionIsRelative_SET(NativePointer, value);
		}

		public float DistanceToNext
		{
			get => E_PROP_FInterpControlPoint_DistanceToNext_GET(NativePointer);
			set => E_PROP_FInterpControlPoint_DistanceToNext_SET(NativePointer, value);
		}

		public float Percentage
		{
			get => E_PROP_FInterpControlPoint_Percentage_GET(NativePointer);
			set => E_PROP_FInterpControlPoint_Percentage_SET(NativePointer, value);
		}

		public FVector PositionControlPoint
		{
			get => E_PROP_FInterpControlPoint_PositionControlPoint_GET(NativePointer);
			set => E_PROP_FInterpControlPoint_PositionControlPoint_SET(NativePointer, value);
		}

		public float StartTime
		{
			get => E_PROP_FInterpControlPoint_StartTime_GET(NativePointer);
			set => E_PROP_FInterpControlPoint_StartTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInterpControlPoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInterpControlPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInterpControlPoint(Adress, false);
		}}}
