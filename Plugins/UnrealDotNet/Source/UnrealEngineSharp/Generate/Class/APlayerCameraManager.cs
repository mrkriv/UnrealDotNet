// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\PlayerCameraManager.h:172

namespace UnrealEngine
{
	public partial class APlayerCameraManager : AActor
	{
		public APlayerCameraManager(IntPtr adress)
			: base(adress)
		{
		}

		public APlayerCameraManager(UObject Parent = null, string Name = "PlayerCameraManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_APlayerCameraManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_BlendParams_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_BlendParams_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_BlendTimeToGo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_BlendTimeToGo_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_CameraCache_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_CameraCache_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_APlayerCameraManager_CameraStyle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_CameraStyle_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_ColorScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_ColorScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_ColorScaleInterpDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_ColorScaleInterpDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_DefaultAspectRatio_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_DefaultAspectRatio_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_DefaultFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_DefaultFOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_DefaultOrthoWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_DefaultOrthoWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_DesiredColorScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_DesiredColorScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_FadeAlpha_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FadeAlpha_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_FadeAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FadeAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_FadeColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FadeColor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_FadeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FadeTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_FadeTimeRemaining_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FadeTimeRemaining_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerCameraManager_FreeCamDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FreeCamDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_FreeCamOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_FreeCamOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_LastFrameCameraCache_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_LastFrameCameraCache_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_OriginalColorScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_OriginalColorScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerCameraManager_PCOwner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_PCOwner_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_PendingViewTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_PendingViewTarget_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_ViewTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_ViewTarget_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerCameraManager_ViewTargetOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerCameraManager_ViewTargetOffset_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_APlayerCameraManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_AddCachedPPBlend(IntPtr self, IntPtr pPSettings, float blendWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_ClearCachedPPBlends(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APlayerCameraManager_GetCameraCachePOV(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APlayerCameraManager_GetCameraCacheTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APlayerCameraManager_GetLastFrameCameraCachePOV(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APlayerCameraManager_GetLastFrameCameraCacheTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APlayerCameraManager_GetLockedFOV(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_SetCameraCachePOV(IntPtr self, IntPtr inPOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_SetCameraCacheTime(IntPtr self, float inTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_SetLastFrameCameraCachePOV(IntPtr self, IntPtr inPOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerCameraManager_SetLastFrameCameraCacheTime(IntPtr self, float inTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Current view target transition blend parameters.
		/// </summary>
		public FViewTargetTransitionParams BlendParams
		{
			get => E_PROP_APlayerCameraManager_BlendParams_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_BlendParams_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time remaining in viewtarget blend.
		/// </summary>
		public float BlendTimeToGo
		{
			get => E_PROP_APlayerCameraManager_BlendTimeToGo_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_BlendTimeToGo_SET(NativePointer, value);
		}

		public FCameraCacheEntry CameraCache
		{
			get => E_PROP_APlayerCameraManager_CameraCache_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_CameraCache_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Usable to define different camera behaviors. A few simple styles are implemented by default.
		/// </summary>
		public string CameraStyle
		{
			get => E_PROP_APlayerCameraManager_CameraStyle_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_CameraStyle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows control over scaling individual color channels in the final image (when bEnableColorScaling == true).
		/// </summary>
		public FVector ColorScale
		{
			get => E_PROP_APlayerCameraManager_ColorScale_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_ColorScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total time for color scale interpolation to complete (when bEnableColorScaling and bEnableColorScaleInterp == true)
		/// </summary>
		public float ColorScaleInterpDuration
		{
			get => E_PROP_APlayerCameraManager_ColorScaleInterpDuration_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_ColorScaleInterpDuration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time at which interpolation started (when bEnableColorScaling and bEnableColorScaleInterp == true)
		/// </summary>
		public float ColorScaleInterpStartTime
		{
			get => E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Default aspect ratio (used when a view target override the aspect ratio and bConstrainAspectRatio is set; most of the time the value from a camera component will be used instead)
		/// </summary>
		public float DefaultAspectRatio
		{
			get => E_PROP_APlayerCameraManager_DefaultAspectRatio_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_DefaultAspectRatio_SET(NativePointer, value);
		}

		
		/// <summary>
		/// FOV to use by default.
		/// </summary>
		public float DefaultFOV
		{
			get => E_PROP_APlayerCameraManager_DefaultFOV_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_DefaultFOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The default desired width (in world units) of the orthographic view (ignored in Perspective mode)
		/// </summary>
		public float DefaultOrthoWidth
		{
			get => E_PROP_APlayerCameraManager_DefaultOrthoWidth_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_DefaultOrthoWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Desired color scale which ColorScale will interpolate to (when bEnableColorScaling and bEnableColorScaleInterp == true)
		/// </summary>
		public FVector DesiredColorScale
		{
			get => E_PROP_APlayerCameraManager_DesiredColorScale_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_DesiredColorScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current camera fade alpha range, where X = starting alpha and Y = final alpha (when bEnableFading == true)
		/// </summary>
		public FVector2D FadeAlpha
		{
			get => E_PROP_APlayerCameraManager_FadeAlpha_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FadeAlpha_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount of fading to apply (when bEnableFading == true).
		/// </summary>
		public float FadeAmount
		{
			get => E_PROP_APlayerCameraManager_FadeAmount_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FadeAmount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Color to fade to (when bEnableFading == true).
		/// </summary>
		public FLinearColor FadeColor
		{
			get => E_PROP_APlayerCameraManager_FadeColor_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FadeColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total duration of the camera fade (when bEnableFading == true)
		/// </summary>
		public float FadeTime
		{
			get => E_PROP_APlayerCameraManager_FadeTime_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FadeTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time remaining in camera fade (when bEnableFading == true)
		/// </summary>
		public float FadeTimeRemaining
		{
			get => E_PROP_APlayerCameraManager_FadeTimeRemaining_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FadeTimeRemaining_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance to place free camera from view target (used in certain CameraStyles)
		/// </summary>
		public float FreeCamDistance
		{
			get => E_PROP_APlayerCameraManager_FreeCamDistance_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FreeCamDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Offset to Z free camera position (used in certain CameraStyles)
		/// </summary>
		public FVector FreeCamOffset
		{
			get => E_PROP_APlayerCameraManager_FreeCamOffset_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_FreeCamOffset_SET(NativePointer, value);
		}

		public FCameraCacheEntry LastFrameCameraCache
		{
			get => E_PROP_APlayerCameraManager_LastFrameCameraCache_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_LastFrameCameraCache_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Color scale value at start of interpolation (when bEnableColorScaling and bEnableColorScaleInterp == true)
		/// </summary>
		public FVector OriginalColorScale
		{
			get => E_PROP_APlayerCameraManager_OriginalColorScale_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_OriginalColorScale_SET(NativePointer, value);
		}

		public APlayerController PCOwner
		{
			get => E_PROP_APlayerCameraManager_PCOwner_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_PCOwner_SET(NativePointer, value);
		}

		public FTViewTarget PendingViewTarget
		{
			get => E_PROP_APlayerCameraManager_PendingViewTarget_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_PendingViewTarget_SET(NativePointer, value);
		}

		public FTViewTarget ViewTarget
		{
			get => E_PROP_APlayerCameraManager_ViewTarget_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_ViewTarget_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Offset to view target (used in certain CameraStyles)
		/// </summary>
		public FVector ViewTargetOffset
		{
			get => E_PROP_APlayerCameraManager_ViewTargetOffset_GET(NativePointer);
			set => E_PROP_APlayerCameraManager_ViewTargetOffset_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds a postprocess effect at the given weight.
		/// </summary>
		public void AddCachedPPBlend(FPostProcessSettings pPSettings, float blendWeight)
			=> E_APlayerCameraManager_AddCachedPPBlend(this, pPSettings, blendWeight);
		
		
		/// <summary>
		/// Removes all postprocess effects.
		/// </summary>
		protected void ClearCachedPPBlends()
			=> E_APlayerCameraManager_ClearCachedPPBlends(this);
		
		
		/// <summary>
		/// Gets value of CameraCachePrivate.POV
		/// </summary>
		public virtual FMinimalViewInfo GetCameraCachePOV()
			=> E_APlayerCameraManager_GetCameraCachePOV(this);
		
		
		/// <summary>
		/// Get value of CameraCachePrivate.Time
		/// </summary>
		public float GetCameraCacheTime()
			=> E_APlayerCameraManager_GetCameraCacheTime(this);
		
		
		/// <summary>
		/// Gets value of LastFrameCameraCachePrivate.POV
		/// </summary>
		public virtual FMinimalViewInfo GetLastFrameCameraCachePOV()
			=> E_APlayerCameraManager_GetLastFrameCameraCachePOV(this);
		
		
		/// <summary>
		/// Get value of LastFrameCameraCachePrivate.Time
		/// </summary>
		public float GetLastFrameCameraCacheTime()
			=> E_APlayerCameraManager_GetLastFrameCameraCacheTime(this);
		
		public float GetLockedFOV()
			=> E_APlayerCameraManager_GetLockedFOV(this);
		
		
		/// <summary>
		/// Sets value of CameraCachePrivate.POV
		/// </summary>
		public virtual void SetCameraCachePOV(FMinimalViewInfo inPOV)
			=> E_APlayerCameraManager_SetCameraCachePOV(this, inPOV);
		
		
		/// <summary>
		/// Get value of CameraCachePrivate.Time
		/// </summary>
		protected void SetCameraCacheTime(float inTime)
			=> E_APlayerCameraManager_SetCameraCacheTime(this, inTime);
		
		
		/// <summary>
		/// Sets value of LastFrameCameraCachePrivate.POV
		/// </summary>
		public virtual void SetLastFrameCameraCachePOV(FMinimalViewInfo inPOV)
			=> E_APlayerCameraManager_SetLastFrameCameraCachePOV(this, inPOV);
		
		
		/// <summary>
		/// Get value of LastFrameCameraCachePrivate.Time
		/// </summary>
		protected void SetLastFrameCameraCacheTime(float inTime)
			=> E_APlayerCameraManager_SetLastFrameCameraCacheTime(this, inTime);
		
		#endregion
		
		public static implicit operator IntPtr(APlayerCameraManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator APlayerCameraManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<APlayerCameraManager>(PtrDesc);
		}}}
