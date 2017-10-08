using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineEventEntry : NativeStructWrapper
	{
		internal FTimelineEventEntry(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineEventEntry() :
			base(E_CreateStruct_FTimelineEventEntry(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineEventEntry();
		
		#endregion
		
		public static implicit operator IntPtr(FTimelineEventEntry Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineEventEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineEventEntry(Adress, false);
		}}}
