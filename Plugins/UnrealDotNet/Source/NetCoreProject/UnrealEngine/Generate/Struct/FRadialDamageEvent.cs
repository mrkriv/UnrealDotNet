using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRadialDamageEvent : FDamageEvent
	{
		internal FRadialDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRadialDamageEvent() :
			base(E_CreateStruct_FRadialDamageEvent(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageEvent();
		
		#endregion
		
		public static implicit operator IntPtr(FRadialDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRadialDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRadialDamageEvent(Adress, false);
		}}}
