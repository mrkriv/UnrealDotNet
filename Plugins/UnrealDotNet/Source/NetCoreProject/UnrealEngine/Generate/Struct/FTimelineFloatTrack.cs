using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineFloatTrack : NativeStructWrapper
	{
		internal FTimelineFloatTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineFloatTrack() :
			base(E_CreateStruct_FTimelineFloatTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineFloatTrack();
		
		#endregion
		
		public static implicit operator IntPtr(FTimelineFloatTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineFloatTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineFloatTrack(Adress, false);
		}}}
