using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FNamedNetDriver : NativeStructWrapper
	{
		internal FNamedNetDriver(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FNamedNetDriver() :
			base(E_CreateStruct_FNamedNetDriver(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FNamedNetDriver();
		
		#endregion
		
		public static implicit operator IntPtr(FNamedNetDriver Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNamedNetDriver(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNamedNetDriver(Adress, false);
		}}}
