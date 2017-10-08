using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFontRenderInfo : NativeStructWrapper
	{
		internal FFontRenderInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFontRenderInfo() :
			base(E_CreateStruct_FFontRenderInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFontRenderInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FFontRenderInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFontRenderInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFontRenderInfo(Adress, false);
		}}}
