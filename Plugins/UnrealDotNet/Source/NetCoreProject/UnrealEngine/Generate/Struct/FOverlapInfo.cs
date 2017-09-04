using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FOverlapInfo : NativeStructWrapper
	{
		public FOverlapInfo() : base(E_CreateStruct_FOverlapInfo(), false)
		{
		}

		internal FOverlapInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FOverlapInfo_bFromSweep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FOverlapInfo_bFromSweep_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FOverlapInfo_GetBodyIndex(FOverlapInfo Self);
		
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
