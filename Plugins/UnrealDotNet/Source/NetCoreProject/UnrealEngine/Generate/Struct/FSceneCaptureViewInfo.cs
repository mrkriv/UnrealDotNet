using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSceneCaptureViewInfo : NativeStructWrapper
	{
		internal FSceneCaptureViewInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSceneCaptureViewInfo() :
			base(E_CreateStruct_FSceneCaptureViewInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSceneCaptureViewInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FSceneCaptureViewInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSceneCaptureViewInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSceneCaptureViewInfo(Adress, false);
		}}}
