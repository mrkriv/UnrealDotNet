using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSubtitleCue : NativeStructWrapper
	{
		internal FSubtitleCue(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSubtitleCue() :
			base(E_CreateStruct_FSubtitleCue(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSubtitleCue();
		
		#endregion
		
		public static implicit operator IntPtr(FSubtitleCue Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSubtitleCue(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSubtitleCue(Adress, false);
		}}}
