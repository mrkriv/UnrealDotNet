using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:19

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSceneCaptureViewInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
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
