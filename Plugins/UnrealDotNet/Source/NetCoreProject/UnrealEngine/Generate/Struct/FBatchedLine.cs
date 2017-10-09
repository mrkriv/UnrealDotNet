using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedLine : NativeStructWrapper
	{
		internal FBatchedLine(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedLine() :
			base(E_CreateStruct_FBatchedLine(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedLine();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBatchedLine_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedLine_End_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_End_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedLine_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedLine_Start_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_Start_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedLine_Thickness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_Thickness_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public byte DepthPriority
		{
			get => E_PROP_FBatchedLine_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedLine_DepthPriority_SET(NativePointer, value);
		}

		public FVector End
		{
			get => E_PROP_FBatchedLine_End_GET(NativePointer);
			set => E_PROP_FBatchedLine_End_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedLine_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedLine_RemainingLifeTime_SET(NativePointer, value);
		}

		public FVector Start
		{
			get => E_PROP_FBatchedLine_Start_GET(NativePointer);
			set => E_PROP_FBatchedLine_Start_SET(NativePointer, value);
		}

		public float Thickness
		{
			get => E_PROP_FBatchedLine_Thickness_GET(NativePointer);
			set => E_PROP_FBatchedLine_Thickness_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedLine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedLine(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedLine(Adress, false);
		}}}
