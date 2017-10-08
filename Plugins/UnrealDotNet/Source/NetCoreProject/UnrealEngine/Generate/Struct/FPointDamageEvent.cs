using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPointDamageEvent : FDamageEvent
	{
		internal FPointDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPointDamageEvent() :
			base(E_CreateStruct_FPointDamageEvent(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPointDamageEvent();
		
		#endregion
		
		public static implicit operator IntPtr(FPointDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPointDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPointDamageEvent(Adress, false);
		}}}
