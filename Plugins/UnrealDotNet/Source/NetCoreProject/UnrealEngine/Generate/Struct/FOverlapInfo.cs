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

		public FOverlapInfo(UPrimitiveComponent InComponent, int InBodyIndex) :
			base(E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(InComponent, InBodyIndex), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(IntPtr InComponent, int InBodyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FOverlapInfo_bFromSweep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOverlapInfo_bFromSweep_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FOverlapInfo_GetBodyIndex(IntPtr Self);
		
		#endregion
		
		#region Property
		public bool bFromSweep
		{
			get => E_PROP_FOverlapInfo_bFromSweep_GET(NativePointer);
			set => E_PROP_FOverlapInfo_bFromSweep_SET(NativePointer, value);
		}

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
