using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FMTDResult : NativeStructWrapper
	{
		internal FMTDResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FMTDResult() :
			base(E_CreateStruct_FMTDResult(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMTDResult();
		
		#endregion
		
		public static implicit operator IntPtr(FMTDResult Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMTDResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMTDResult(Adress, false);
		}}}
