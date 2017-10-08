using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FOverlapInfo : NativeStructWrapper
	{
		internal FOverlapInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FOverlapInfo() :
			base(E_CreateStruct_FOverlapInfo(), false)
		{
		}

		public FOverlapInfo(FHitResult InSweepResult) :
			base(E_CreateStruct_FOverlapInfo_FHitResult(InSweepResult), false)
		{
		}

		public FOverlapInfo(UPrimitiveComponent InComponent, int InBodyIndex) :
			base(E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(InComponent, InBodyIndex), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo_FHitResult(IntPtr InSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(IntPtr InComponent, int InBodyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FOverlapInfo_GetBodyIndex(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public int GetBodyIndex()
			=> E_FOverlapInfo_GetBodyIndex(this);
		
		#endregion
		
		public static implicit operator IntPtr(FOverlapInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FOverlapInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FOverlapInfo(Adress, false);
		}}}
