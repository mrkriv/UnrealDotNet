using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineLinearColorTrack : NativeStructWrapper
	{
		internal FTimelineLinearColorTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineLinearColorTrack() :
			base(E_CreateStruct_FTimelineLinearColorTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineLinearColorTrack();
		
		#endregion
		
		public static implicit operator IntPtr(FTimelineLinearColorTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineLinearColorTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineLinearColorTrack(Adress, false);
		}}}
