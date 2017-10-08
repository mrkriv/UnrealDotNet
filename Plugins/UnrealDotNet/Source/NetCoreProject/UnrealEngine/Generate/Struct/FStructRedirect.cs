using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FStructRedirect : NativeStructWrapper
	{
		internal FStructRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStructRedirect() :
			base(E_CreateStruct_FStructRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStructRedirect();
		
		#endregion
		
		public static implicit operator IntPtr(FStructRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStructRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStructRedirect(Adress, false);
		}}}
