using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAnimSlotDesc : NativeStructWrapper
	{
		internal FAnimSlotDesc(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimSlotDesc() :
			base(E_CreateStruct_FAnimSlotDesc(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimSlotDesc();
		
		#endregion
		
		public static implicit operator IntPtr(FAnimSlotDesc Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimSlotDesc(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimSlotDesc(Adress, false);
		}}}
