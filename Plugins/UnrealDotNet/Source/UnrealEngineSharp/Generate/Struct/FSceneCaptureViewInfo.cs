// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:19

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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ProjectionMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ProjectionMatrix_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSceneCaptureViewInfo_StereoIPD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSceneCaptureViewInfo_StereoIPD_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ViewRect_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ViewRect_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSceneCaptureViewInfo_ViewRotationMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ViewRotationMatrix_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSceneCaptureViewInfo();
		
		#endregion
		
		#region Property
		public FMatrix ProjectionMatrix
		{
			get => E_PROP_FSceneCaptureViewInfo_ProjectionMatrix_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ProjectionMatrix_SET(NativePointer, value);
		}

		public float StereoIPD
		{
			get => E_PROP_FSceneCaptureViewInfo_StereoIPD_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_StereoIPD_SET(NativePointer, value);
		}

		public FVector ViewLocation
		{
			get => E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(NativePointer, value);
		}

		public FIntRect ViewRect
		{
			get => E_PROP_FSceneCaptureViewInfo_ViewRect_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ViewRect_SET(NativePointer, value);
		}

		public FMatrix ViewRotationMatrix
		{
			get => E_PROP_FSceneCaptureViewInfo_ViewRotationMatrix_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ViewRotationMatrix_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSceneCaptureViewInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSceneCaptureViewInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSceneCaptureViewInfo(Adress, false);
		}}}
