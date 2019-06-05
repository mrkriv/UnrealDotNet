// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraTypes.h:38

namespace UnrealEngine
{
	public partial class FMinimalViewInfo : NativeStructWrapper
	{
		public FMinimalViewInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FMinimalViewInfo() :
			base(E_CreateStruct_FMinimalViewInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_AspectRatio_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_AspectRatio_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_DesiredFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_DesiredFOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_FOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_FOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMinimalViewInfo_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMinimalViewInfo_OffCenterProjectionOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_OffCenterProjectionOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_OrthoFarClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_OrthoFarClipPlane_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_OrthoNearClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_OrthoNearClipPlane_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_OrthoWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_OrthoWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMinimalViewInfo_PostProcessBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_PostProcessBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMinimalViewInfo_PostProcessSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_PostProcessSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMinimalViewInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMinimalViewInfo_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMinimalViewInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FMinimalViewInfo_AddWeightedViewInfo(IntPtr self, IntPtr otherView, float weight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FMinimalViewInfo_ApplyBlendWeight(IntPtr self, float weight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FMinimalViewInfo_BlendViewInfo(IntPtr self, IntPtr otherInfo, float otherWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMinimalViewInfo_CalculateProjectionMatrix(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FMinimalViewInfo_Equals(IntPtr self, IntPtr otherInfo);
		
		#endregion
		
		#region Property
		public float AspectRatio
		{
			get => E_PROP_FMinimalViewInfo_AspectRatio_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_AspectRatio_SET(NativePointer, value);
		}

		public float DesiredFOV
		{
			get => E_PROP_FMinimalViewInfo_DesiredFOV_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_DesiredFOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The field of view (in degrees) in perspective mode (ignored in Orthographic mode)
		/// </summary>
		public float FOV
		{
			get => E_PROP_FMinimalViewInfo_FOV_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_FOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Location
		/// </summary>
		public FVector Location
		{
			get => E_PROP_FMinimalViewInfo_Location_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_Location_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Off-axis / off-center projection offset as proportion of screen dimensions
		/// </summary>
		public FVector2D OffCenterProjectionOffset
		{
			get => E_PROP_FMinimalViewInfo_OffCenterProjectionOffset_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_OffCenterProjectionOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The far plane distance of the orthographic view (in world units)
		/// </summary>
		public float OrthoFarClipPlane
		{
			get => E_PROP_FMinimalViewInfo_OrthoFarClipPlane_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_OrthoFarClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The near plane distance of the orthographic view (in world units)
		/// </summary>
		public float OrthoNearClipPlane
		{
			get => E_PROP_FMinimalViewInfo_OrthoNearClipPlane_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_OrthoNearClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The desired width (in world units) of the orthographic view (ignored in Perspective mode)
		/// </summary>
		public float OrthoWidth
		{
			get => E_PROP_FMinimalViewInfo_OrthoWidth_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_OrthoWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates if PostProcessSettings should be applied.
		/// </summary>
		public float PostProcessBlendWeight
		{
			get => E_PROP_FMinimalViewInfo_PostProcessBlendWeight_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_PostProcessBlendWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Post-process settings to use if PostProcessBlendWeight is non-zero.
		/// </summary>
		public FPostProcessSettings PostProcessSettings
		{
			get => E_PROP_FMinimalViewInfo_PostProcessSettings_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_PostProcessSettings_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Rotation
		/// </summary>
		public FRotator Rotation
		{
			get => E_PROP_FMinimalViewInfo_Rotation_GET(NativePointer);
			set => E_PROP_FMinimalViewInfo_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Combines this view with another one which will be weighted. Equals to this += OtherView * Weight.
		/// </summary>
		public void AddWeightedViewInfo(FMinimalViewInfo otherView, float weight)
			=> E_FMinimalViewInfo_AddWeightedViewInfo(this, otherView, weight);
		
		
		/// <summary>
		/// Applies weighting to this view, in order to be blended with another one. Equals to this *= Weight.
		/// </summary>
		public void ApplyBlendWeight(float weight)
			=> E_FMinimalViewInfo_ApplyBlendWeight(this, weight);
		
		public void BlendViewInfo(FMinimalViewInfo otherInfo, float otherWeight)
			=> E_FMinimalViewInfo_BlendViewInfo(this, otherInfo, otherWeight);
		
		
		/// <summary>
		/// Calculates the projection matrix using this view info's aspect ratio (regardless of bConstrainAspectRatio)
		/// </summary>
		public FMatrix CalculateProjectionMatrix()
			=> E_FMinimalViewInfo_CalculateProjectionMatrix(this);
		
		public bool Equals(FMinimalViewInfo otherInfo)
			=> E_FMinimalViewInfo_Equals(this, otherInfo);
		
		#endregion
		
		public static implicit operator IntPtr(FMinimalViewInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMinimalViewInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMinimalViewInfo(adress, false);
		}}}
