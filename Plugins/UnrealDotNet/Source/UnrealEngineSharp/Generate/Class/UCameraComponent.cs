// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraComponent.h:21

namespace UnrealEngine
{
	public partial class UCameraComponent : USceneComponent
	{
		public UCameraComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraComponent(UObject Parent = null, string Name = "CameraComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_AspectRatio_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_AspectRatio_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraComponent_bConstrainAspectRatio_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_bConstrainAspectRatio_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraComponent_bLockToHmd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_bLockToHmd_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraComponent_bUseFieldOfViewForLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_bUseFieldOfViewForLOD_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraComponent_bUsePawnControlRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_bUsePawnControlRotation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_FieldOfView_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_FieldOfView_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_OrthoFarClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_OrthoFarClipPlane_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_OrthoNearClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_OrthoNearClipPlane_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_OrthoWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_OrthoWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraComponent_PostProcessBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_PostProcessBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraComponent_PostProcessSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraComponent_PostProcessSettings_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_AddAdditiveOffset(IntPtr self, IntPtr transform, float fOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_AddExtraPostProcessBlend(IntPtr self, IntPtr pPSettings, float pPBlendWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_ClearAdditiveOffset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_ClearExtraPostProcessBlends(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_GetAdditiveOffset(IntPtr self, IntPtr outAdditiveOffset, float outAdditiveFOVOffset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_GetCameraView(IntPtr self, float deltaTime, IntPtr desiredView);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_NotifyCameraCut(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetAspectRatio(IntPtr self, float inAspectRatio);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetConstraintAspectRatio(IntPtr self, bool bInConstrainAspectRatio);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetFieldOfView(IntPtr self, float inFieldOfView);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetOrthoFarClipPlane(IntPtr self, float inOrthoFarClipPlane);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetOrthoNearClipPlane(IntPtr self, float inOrthoNearClipPlane);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetOrthoWidth(IntPtr self, float inOrthoWidth);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetPostProcessBlendWeight(IntPtr self, float inPostProcessBlendWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraComponent_SetUseFieldOfViewForLOD(IntPtr self, bool bInUseFieldOfViewForLOD);
		
		#endregion
		
		#region Property
		public float AspectRatio
		{
			get => E_PROP_UCameraComponent_AspectRatio_GET(NativePointer);
			set => E_PROP_UCameraComponent_AspectRatio_SET(NativePointer, value);
		}

		public byte bConstrainAspectRatio
		{
			get => E_PROP_UCameraComponent_bConstrainAspectRatio_GET(NativePointer);
			set => E_PROP_UCameraComponent_bConstrainAspectRatio_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if the camera's orientation and position should be locked to the HMD
		/// </summary>
		public byte bLockToHmd
		{
			get => E_PROP_UCameraComponent_bLockToHmd_GET(NativePointer);
			set => E_PROP_UCameraComponent_bLockToHmd_SET(NativePointer, value);
		}

		public byte bUseFieldOfViewForLOD
		{
			get => E_PROP_UCameraComponent_bUseFieldOfViewForLOD_GET(NativePointer);
			set => E_PROP_UCameraComponent_bUseFieldOfViewForLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If this camera component is placed on a pawn, should it use the view/control rotation of the pawn where possible?
		/// <see cref="APawn"/>
		/// </summary>
		public byte bUsePawnControlRotation
		{
			get => E_PROP_UCameraComponent_bUsePawnControlRotation_GET(NativePointer);
			set => E_PROP_UCameraComponent_bUsePawnControlRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The horizontal field of view (in degrees) in perspective mode (ignored in Orthographic mode)
		/// </summary>
		public float FieldOfView
		{
			get => E_PROP_UCameraComponent_FieldOfView_GET(NativePointer);
			set => E_PROP_UCameraComponent_FieldOfView_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The far plane distance of the orthographic view (in world units)
		/// </summary>
		public float OrthoFarClipPlane
		{
			get => E_PROP_UCameraComponent_OrthoFarClipPlane_GET(NativePointer);
			set => E_PROP_UCameraComponent_OrthoFarClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The near plane distance of the orthographic view (in world units)
		/// </summary>
		public float OrthoNearClipPlane
		{
			get => E_PROP_UCameraComponent_OrthoNearClipPlane_GET(NativePointer);
			set => E_PROP_UCameraComponent_OrthoNearClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The desired width (in world units) of the orthographic view (ignored in Perspective mode)
		/// </summary>
		public float OrthoWidth
		{
			get => E_PROP_UCameraComponent_OrthoWidth_GET(NativePointer);
			set => E_PROP_UCameraComponent_OrthoWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates if PostProcessSettings should be used when using this Camera to view through.
		/// </summary>
		public float PostProcessBlendWeight
		{
			get => E_PROP_UCameraComponent_PostProcessBlendWeight_GET(NativePointer);
			set => E_PROP_UCameraComponent_PostProcessBlendWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Post process settings to use for this camera. Don't forget to check the properties you want to override
		/// </summary>
		public FPostProcessSettings PostProcessSettings
		{
			get => E_PROP_UCameraComponent_PostProcessSettings_GET(NativePointer);
			set => E_PROP_UCameraComponent_PostProcessSettings_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Applies the given additive offset, preserving any existing offset
		/// </summary>
		public void AddAdditiveOffset(FTransform transform, float fOV)
			=> E_UCameraComponent_AddAdditiveOffset(this, transform, fOV);
		
		
		/// <summary>
		/// Stores a given PP and weight to be later applied when the final PP is computed. Used for things like in-editor camera animation preview.
		/// </summary>
		public void AddExtraPostProcessBlend(FPostProcessSettings pPSettings, float pPBlendWeight)
			=> E_UCameraComponent_AddExtraPostProcessBlend(this, pPSettings, pPBlendWeight);
		
		
		/// <summary>
		/// Removes any additive offset.
		/// </summary>
		public void ClearAdditiveOffset()
			=> E_UCameraComponent_ClearAdditiveOffset(this);
		
		
		/// <summary>
		/// Removes any extra PP blends.
		/// </summary>
		public void ClearExtraPostProcessBlends()
			=> E_UCameraComponent_ClearExtraPostProcessBlends(this);
		
		
		/// <summary>
		/// Get the additive offset
		/// </summary>
		public void GetAdditiveOffset(FTransform outAdditiveOffset, float outAdditiveFOVOffset)
			=> E_UCameraComponent_GetAdditiveOffset(this, outAdditiveOffset, outAdditiveFOVOffset);
		
		
		/// <summary>
		/// Returns camera's Point of View.
		/// <para>Called by Camera class. Subclass and postprocess to add any effects. </para>
		/// </summary>
		public virtual void GetCameraView(float deltaTime, FMinimalViewInfo desiredView)
			=> E_UCameraComponent_GetCameraView(this, deltaTime, desiredView);
		
		
		/// <summary>
		/// Can be called from external code to notify that this camera was cut to, so it can update
		/// <para>things like interpolation if necessary. </para>
		/// </summary>
		public virtual void NotifyCameraCut()
			=> E_UCameraComponent_NotifyCameraCut(this);
		
		public void SetAspectRatio(float inAspectRatio)
			=> E_UCameraComponent_SetAspectRatio(this, inAspectRatio);
		
		public void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
			=> E_UCameraComponent_SetConstraintAspectRatio(this, bInConstrainAspectRatio);
		
		public virtual void SetFieldOfView(float inFieldOfView)
			=> E_UCameraComponent_SetFieldOfView(this, inFieldOfView);
		
		public void SetOrthoFarClipPlane(float inOrthoFarClipPlane)
			=> E_UCameraComponent_SetOrthoFarClipPlane(this, inOrthoFarClipPlane);
		
		public void SetOrthoNearClipPlane(float inOrthoNearClipPlane)
			=> E_UCameraComponent_SetOrthoNearClipPlane(this, inOrthoNearClipPlane);
		
		public void SetOrthoWidth(float inOrthoWidth)
			=> E_UCameraComponent_SetOrthoWidth(this, inOrthoWidth);
		
		public void SetPostProcessBlendWeight(float inPostProcessBlendWeight)
			=> E_UCameraComponent_SetPostProcessBlendWeight(this, inPostProcessBlendWeight);
		
		public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
			=> E_UCameraComponent_SetUseFieldOfViewForLOD(this, bInUseFieldOfViewForLOD);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraComponent>(PtrDesc);
		}}}
