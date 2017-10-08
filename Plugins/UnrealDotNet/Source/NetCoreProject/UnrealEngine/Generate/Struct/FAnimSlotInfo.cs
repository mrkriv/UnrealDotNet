using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAnimSlotInfo : NativeStructWrapper
	{
		internal FAnimSlotInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimSlotInfo() :
			base(E_CreateStruct_FAnimSlotInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimSlotInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FAnimSlotInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimSlotInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimSlotInfo(Adress, false);
		}}}
