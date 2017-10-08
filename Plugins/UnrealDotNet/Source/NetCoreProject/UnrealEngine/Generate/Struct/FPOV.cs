using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPOV : NativeStructWrapper
	{
		internal FPOV(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPOV() :
			base(E_CreateStruct_FPOV(), false)
		{
		}

		public FPOV(FVector InLocation, FRotator InRotation, float InFOV) :
			base(E_CreateStruct_FPOV_FVector_FRotator_float(InLocation, InRotation, InFOV), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPOV();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPOV_FVector_FRotator_float(IntPtr InLocation, IntPtr InRotation, float InFOV);
		
		#endregion
		
		public static implicit operator IntPtr(FPOV Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPOV(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPOV(Adress, false);
		}}}
