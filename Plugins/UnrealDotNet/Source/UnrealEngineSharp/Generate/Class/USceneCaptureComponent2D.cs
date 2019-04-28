// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent2D : USceneCaptureComponent
	{
		public USceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponent2D(UObject Parent = null, string Name = "SceneCaptureComponent2D")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent2D(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USceneCaptureComponent2D_bEnableClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_bEnableClipPlane_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneCaptureComponent2D_ClipPlaneBase_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_ClipPlaneBase_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USceneCaptureComponent2D_FOVAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_FOVAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USceneCaptureComponent2D_OrthoWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_OrthoWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneCaptureComponent2D_PostProcessSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent2D_PostProcessSettings_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent2D(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent2D_CaptureScene(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent2D_CaptureSceneDeferred(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent2D_UpdateContent(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Enables a clip plane while rendering the scene capture which is useful for portals.
		/// <para>The global clip plane must be enabled in the renderer project settings for this to work. </para>
		/// </summary>
		public bool bEnableClipPlane
		{
			get => E_PROP_USceneCaptureComponent2D_bEnableClipPlane_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_bEnableClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether a custom projection matrix will be used during rendering. Use with caution. Does not currently affect culling
		/// </summary>
		public bool bUseCustomProjectionMatrix
		{
			get => E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Base position for the clip plane, can be any position on the plane.
		/// </summary>
		public FVector ClipPlaneBase
		{
			get => E_PROP_USceneCaptureComponent2D_ClipPlaneBase_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_ClipPlaneBase_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Normal for the plane.
		/// </summary>
		public FVector ClipPlaneNormal
		{
			get => E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The custom projection matrix to use
		/// </summary>
		public FMatrix CustomProjectionMatrix
		{
			get => E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Camera field of view (in degrees).
		/// </summary>
		public float FieldofView
		{
			get => E_PROP_USceneCaptureComponent2D_FOVAngle_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_FOVAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The desired width (in world units) of the orthographic view (ignored in Perspective mode)
		/// </summary>
		public float OrthoWidth
		{
			get => E_PROP_USceneCaptureComponent2D_OrthoWidth_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_OrthoWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Range (0.0, 1.0) where 0 indicates no effect, 1 indicates full effect.
		/// </summary>
		public float PostProcessBlendWeight
		{
			get => E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_SET(NativePointer, value);
		}

		public FPostProcessSettings PostProcessSettings
		{
			get => E_PROP_USceneCaptureComponent2D_PostProcessSettings_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent2D_PostProcessSettings_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Render the scene to the texture target immediately.
		/// <para>This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly. </para>
		/// </summary>
		public void CaptureScene()
			=> E_USceneCaptureComponent2D_CaptureScene(this);
		
		
		/// <summary>
		/// Render the scene to the texture the next time the main view is rendered.
		/// </summary>
		public void CaptureSceneDeferred()
			=> E_USceneCaptureComponent2D_CaptureSceneDeferred(this);
		
		public void UpdateContent()
			=> E_USceneCaptureComponent2D_UpdateContent(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent2D>(PtrDesc);
		}}}
