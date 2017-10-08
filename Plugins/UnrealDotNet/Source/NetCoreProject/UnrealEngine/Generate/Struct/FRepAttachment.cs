using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepAttachment : NativeStructWrapper
	{
		internal FRepAttachment(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepAttachment() :
			base(E_CreateStruct_FRepAttachment(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepAttachment();
		
		#endregion
		
		public static implicit operator IntPtr(FRepAttachment Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepAttachment(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepAttachment(Adress, false);
		}}}
