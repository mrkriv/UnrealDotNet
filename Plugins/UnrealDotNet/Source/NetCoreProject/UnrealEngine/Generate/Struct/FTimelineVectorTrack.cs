using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineVectorTrack : NativeStructWrapper
	{
		internal FTimelineVectorTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineVectorTrack() :
			base(E_CreateStruct_FTimelineVectorTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineVectorTrack();
		
		#endregion
		
		public static implicit operator IntPtr(FTimelineVectorTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineVectorTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineVectorTrack(Adress, false);
		}}}
