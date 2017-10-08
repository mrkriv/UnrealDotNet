using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FClassRedirect : NativeStructWrapper
	{
		internal FClassRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClassRedirect() :
			base(E_CreateStruct_FClassRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClassRedirect();
		
		#endregion
		
		public static implicit operator IntPtr(FClassRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClassRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClassRedirect(Adress, false);
		}}}
