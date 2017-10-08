using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FGameNameRedirect : NativeStructWrapper
	{
		internal FGameNameRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FGameNameRedirect() :
			base(E_CreateStruct_FGameNameRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGameNameRedirect();
		
		#endregion
		
		public static implicit operator IntPtr(FGameNameRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FGameNameRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameNameRedirect(Adress, false);
		}}}
