using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSceneCaptureViewInfo : NativeStructWrapper
	{
		public FSceneCaptureViewInfo() : base(E_CreateStruct_FSceneCaptureViewInfo(), false)
		{
		}

		internal FSceneCaptureViewInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSceneCaptureViewInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public FVector ViewLocation
		{
			get => E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSceneCaptureViewInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSceneCaptureViewInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSceneCaptureViewInfo(Adress, false);
		}}}
