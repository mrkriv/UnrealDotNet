using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDropNoteInfo : NativeStructWrapper
	{
		internal FDropNoteInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDropNoteInfo() :
			base(E_CreateStruct_FDropNoteInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDropNoteInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FDropNoteInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDropNoteInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDropNoteInfo(Adress, false);
		}}}
