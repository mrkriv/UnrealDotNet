// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:588

namespace UnrealEngine
{
	public  partial class FPostProcessSettings : NativeStructWrapper
	{
		internal FPostProcessSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPostProcessSettings() :
			base(E_CreateStruct_FPostProcessSettings(), false)
		{
		}

		public FPostProcessSettings(FPostProcessSettings _p0) :
			base(E_CreateStruct_FPostProcessSettings_FPostProcessSettings(_p0), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_AmbientCubemapTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientCubemapTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom1Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom1Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom1Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom1Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom2Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom2Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom2Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom2Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom3Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom3Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom3Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom3Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom4Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom4Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom4Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom4Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom5Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom5Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom5Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom5Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom6Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom6Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_Bloom6Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom6Tint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_BloomDirtMaskTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomDirtMaskTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomSizeScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomSizeScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BlueCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BlueCorrection_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bMobileHQGaussian_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bMobileHQGaussian_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientCubemapIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientCubemapIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientCubemapTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientCubemapTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionBias_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionDistance_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionDistance_DEPRECATED_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeDistance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeRadius_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipBlend_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipThreshold_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionPower_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionPower_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionQuality_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadius_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadiusInWS_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadiusInWS_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionStaticFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionStaticFraction_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureBias_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureBiasCurve_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureBiasCurve_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureCalibrationConstant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureCalibrationConstant_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureHighPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureHighPercent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureLowPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureLowPercent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureMaxBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureMaxBrightness_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureMinBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureMinBrightness_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedDown_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedUp_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom1Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom1Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom1Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom1Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom2Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom2Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom2Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom2Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom3Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom3Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom3Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom3Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom4Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom4Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom4Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom4Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom5Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom5Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom5Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom5Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom6Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom6Size_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_Bloom6Tint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_Bloom6Tint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionBufferScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionBufferScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionCenterUV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionCenterUV_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilter_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilter_DEPRECATED_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMax_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMin_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMult_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomConvolutionTexture_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomConvolutionTexture_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomDirtMask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomDirtMask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomSizeScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomSizeScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BloomThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BloomThreshold_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_BlueCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_BlueCorrection_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_CameraISO_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_CameraISO_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_CameraShutterSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_CameraShutterSpeed_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ChromaticAberrationStartOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ChromaticAberrationStartOffset_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorContrast_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorContrastHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorContrastHighlights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorContrastMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorContrastMidtones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorContrastShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorContrastShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorCorrectionHighlightsMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorCorrectionHighlightsMin_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorCorrectionShadowsMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorCorrectionShadowsMax_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGain_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGain_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGainHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGainHighlights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGainMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGainMidtones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGainShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGainShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGamma_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGammaHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGammaHighlights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGammaMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGammaMidtones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGammaShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGammaShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGradingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGradingIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorGradingLUT_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorGradingLUT_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorOffset_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorOffsetHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorOffsetHighlights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorOffsetMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorOffsetMidtones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorOffsetShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorOffsetShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorSaturation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorSaturationHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorSaturationHighlights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorSaturationMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorSaturationMidtones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ColorSaturationShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ColorSaturationShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBladeCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBladeCount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBokehShape_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBokehShape_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldColorThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldColorThreshold_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurAmount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurRadius_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarBlurSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarTransitionRegion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalDistance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalRegion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFstop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFstop_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMaxBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMaxBokehSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMinFstop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMinFstop_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearBlurSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearTransitionRegion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldOcclusion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSensorWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSensorWidth_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSizeThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSizeThreshold_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSkyFocusDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSkyFocusDistance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_DepthOfFieldVignetteSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_DepthOfFieldVignetteSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ExpandGamut_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ExpandGamut_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmBlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmBlackClip_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerBlue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerBlue_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerGreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerGreen_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerRed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerRed_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmContrast_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmDynamicRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmDynamicRange_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmHealAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmHealAmount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmSaturation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmShadowTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmShadowTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmShadowTintAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmShadowTintAmount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmShadowTintBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmShadowTintBlend_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmShoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmShoulder_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmSlope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmSlope_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmToe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmToe_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmToeAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmToeAmount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmWhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmWhiteClip_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_FilmWhitePoint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_FilmWhitePoint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_GrainIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_GrainIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_GrainJitter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_GrainJitter_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_HistogramLogMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_HistogramLogMax_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_HistogramLogMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_HistogramLogMin_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_IndirectLightingColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_IndirectLightingColor_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_IndirectLightingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_IndirectLightingIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareBokehShape_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareBokehShape_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareBokehSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareThreshold_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LensFlareTints_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LensFlareTints_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionExponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionFadeRange_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionRadius_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVEmissiveInjectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVEmissiveInjectionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVFadeRange_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVGeometryVolumeBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVGeometryVolumeBias_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVSecondaryBounceIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVSecondaryBounceIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVSecondaryOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVSecondaryOcclusionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionExponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_LPVVplInjectionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_LPVVplInjectionBias_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_MobileHQGaussian_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_MobileHQGaussian_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_MotionBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_MotionBlurAmount_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_MotionBlurMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_MotionBlurMax_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_MotionBlurPerObjectSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_MotionBlurPerObjectSize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_SceneColorTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_SceneColorTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_SceneFringeIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_SceneFringeIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ScreenPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ScreenPercentage_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionMaxRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionMaxRoughness_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionQuality_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionRoughnessScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionRoughnessScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_VignetteIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_VignetteIntensity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_WhiteTemp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_WhiteTemp_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_bOverride_WhiteTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_bOverride_WhiteTint_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_CameraISO_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_CameraISO_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_CameraShutterSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_CameraShutterSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrast_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGain_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGain_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGamma_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorGradingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGradingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_DepthOfFieldBladeCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldBladeCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldMinFstop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldMinFstop_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ExpandGamut_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ExpandGamut_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmBlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmBlackClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_FilmChannelMixerBlue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmChannelMixerBlue_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_FilmChannelMixerGreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmChannelMixerGreen_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_FilmChannelMixerRed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmChannelMixerRed_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmContrast_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmDynamicRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmDynamicRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmHealAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmHealAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmSaturation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_FilmShadowTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShadowTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShadowTintAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShadowTintAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShadowTintBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShadowTintBlend_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShoulder_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmSlope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmSlope_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmToe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmToe_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmToeAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmToeAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmWhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmWhiteClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_FilmWhitePoint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmWhitePoint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_GrainIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_GrainIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_GrainJitter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_GrainJitter_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_HistogramLogMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_HistogramLogMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_HistogramLogMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_HistogramLogMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_IndirectLightingColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_IndirectLightingColor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_LensFlareTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVFadeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_PathTracingMaxBounces_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_PathTracingMaxBounces_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_PathTracingSamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_PathTracingSamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingAOSamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingAOSamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingGIMaxBounces_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingGIMaxBounces_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingGISamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingGISamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingReflectionsMaxBounces_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingReflectionsMaxBounces_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_RayTracingReflectionsMaxRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingReflectionsMaxRoughness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingReflectionsSamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingReflectionsSamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_RayTracingReflectionsShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingReflectionsShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_RayTracingTranslucencyMaxRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingTranslucencyMaxRoughness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_RayTracingTranslucencyRefraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingTranslucencyRefraction_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingTranslucencyRefractionRays_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingTranslucencyRefractionRays_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPostProcessSettings_RayTracingTranslucencySamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingTranslucencySamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_RayTracingTranslucencyShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_RayTracingTranslucencyShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_ReflectionsType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ReflectionsType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_SceneColorTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_SceneColorTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenPercentage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FPostProcessSettings_TranslucencyType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_TranslucencyType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_VignetteIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_VignetteIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_WeightedBlendables_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WeightedBlendables_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_WhiteTemp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WhiteTemp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_WhiteTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WhiteTint_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPostProcessSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPostProcessSettings_FPostProcessSettings(IntPtr _p0);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPostProcessSettings_SetBaseValues(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// To scale the Ambient cubemap brightness
		/// <para>>=0: off, 1(default), >1 brighter </para>
		/// </summary>
		public float AmbientCubemapIntensity
		{
			get => E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// AmbientCubemap tint color
		/// </summary>
		public FLinearColor AmbientCubemapTint
		{
			get => E_PROP_FPostProcessSettings_AmbientCubemapTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientCubemapTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0, in unreal units, default (3.0) works well for flat surfaces but can reduce details
		/// </summary>
		public float Bias
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionBias_SET(NativePointer, value);
		}

		public float AmbientOcclusionDistance_DEPRECATED
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0, in unreal units, at what distance the AO effect disppears in the distance (avoding artifacts and AO effects on huge object)
		/// </summary>
		public float FadeOutDistance
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0, in unreal units, how many units before AmbientOcclusionFadeOutDistance it starts fading out
		/// </summary>
		public float FadeOutRadius
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0..1 0=off/no ambient occlusion .. 1=strong ambient occlusion, defines how much it affects the non direct lighting after base pass
		/// </summary>
		public float AmbientOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Affects the blend over the multiple mips (lower resolution versions) , 0:fully use full resolution, 1::fully use low resolution, around 0.6 seems to be a good value
		/// </summary>
		public float MipBlend
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Affects the radius AO radius scale over the multiple mips (lower resolution versions)
		/// </summary>
		public float MipScale
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// to tweak the bilateral upsampling when using multiple mips (lower resolution versions)
		/// </summary>
		public float MipThreshold
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion
		/// </summary>
		public float Power
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition
		/// </summary>
		public float AmbientOcclusionQuality
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion
		/// </summary>
		public float Radius
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0..1 0=no effect on static lighting .. 1=AO affects the stat lighting, 0 is free meaning no extra rendering pass
		/// </summary>
		public float StaticFraction
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Logarithmic adjustment for the exposure. Only used if a tonemapper is specified.
		/// <para>0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ... </para>
		/// </summary>
		public float ExposureCompensation
		{
			get => E_PROP_FPostProcessSettings_AutoExposureBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Calibration constant for 18% albedo.
		/// </summary>
		public float CalibrationConstant
		{
			get => E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// <para>The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority </para>
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// <para>bright spots. </para>
		/// >0, <100, good values are in the range 80 .. 95
		/// </summary>
		public float HighPercent
		{
			get => E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// <para>The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority </para>
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// <para>bright spots. </para>
		/// >0, <100, good values are in the range 70 .. 80
		/// </summary>
		public float LowPercent
		{
			get => E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Auto-Exposure maximum adaptation. Eye Adaptation is disabled if Min = Max.
		/// <para>Auto-exposure is implemented by choosing an exposure value for which the average luminance generates a pixel brightness equal to the Constant Calibration value. </para>
		/// The Min/Max are expressed in pixel luminance (cd/m2) or in EV100 when using ExtendDefaultLuminanceRange (see project settings).
		/// </summary>
		public float MaxBrightness
		{
			get => E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Auto-Exposure minimum adaptation. Eye Adaptation is disabled if Min = Max.
		/// <para>Auto-exposure is implemented by choosing an exposure value for which the average luminance generates a pixel brightness equal to the Constant Calibration value. </para>
		/// The Min/Max are expressed in pixel luminance (cd/m2) or in EV100 when using ExtendDefaultLuminanceRange (see project settings).
		/// </summary>
		public float MinBrightness
		{
			get => E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0
		/// </summary>
		public float SpeedDown
		{
			get => E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0
		/// </summary>
		public float SpeedUp
		{
			get => E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for the Bloom1 in percent of the screen width
		/// <para>(is done in 1/2 resolution, larger values cost more performance, good for high frequency details) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom1Size
		{
			get => E_PROP_FPostProcessSettings_Bloom1Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom1Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom1 tint color
		/// </summary>
		public FLinearColor Bloom1Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom1Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom1Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for Bloom2 in percent of the screen width
		/// <para>(is done in 1/4 resolution, larger values cost more performance) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom2Size
		{
			get => E_PROP_FPostProcessSettings_Bloom2Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom2Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom2 tint color
		/// </summary>
		public FLinearColor Bloom2Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom2Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom2Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for Bloom3 in percent of the screen width
		/// <para>(is done in 1/8 resolution, larger values cost more performance) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom3Size
		{
			get => E_PROP_FPostProcessSettings_Bloom3Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom3Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom3 tint color
		/// </summary>
		public FLinearColor Bloom3Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom3Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom3Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for Bloom4 in percent of the screen width
		/// <para>(is done in 1/16 resolution, larger values cost more performance, best for wide contributions) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom4Size
		{
			get => E_PROP_FPostProcessSettings_Bloom4Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom4Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom4 tint color
		/// </summary>
		public FLinearColor Bloom4Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom4Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom4Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for Bloom5 in percent of the screen width
		/// <para>(is done in 1/32 resolution, larger values cost more performance, best for wide contributions) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom5Size
		{
			get => E_PROP_FPostProcessSettings_Bloom5Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom5Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom5 tint color
		/// </summary>
		public FLinearColor Bloom5Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom5Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom5Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diameter size for Bloom6 in percent of the screen width
		/// <para>(is done in 1/64 resolution, larger values cost more performance, best for wide contributions) </para>
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom6Size
		{
			get => E_PROP_FPostProcessSettings_Bloom6Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom6Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bloom6 tint color
		/// </summary>
		public FLinearColor Bloom6Tint
		{
			get => E_PROP_FPostProcessSettings_Bloom6Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom6Tint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Implicit buffer region as a fraction of the screen size to insure the bloom does not wrap across the screen.  Larger sizes have perf impact.
		/// </summary>
		public float ConvolutionBuffer
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The UV location of the center of the kernel.  Should be very close to (.5,.5)
		/// </summary>
		public FVector2D ConvolutionCenter
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMax
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMin
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMult
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Relative size of the convolution kernel image compared to the minor axis of the viewport
		/// </summary>
		public float ConvolutionScale
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// BloomDirtMask intensity
		/// </summary>
		public float DirtMaskIntensity
		{
			get => E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// BloomDirtMask tint color
		/// </summary>
		public FLinearColor DirtMaskTint
		{
			get => E_PROP_FPostProcessSettings_BloomDirtMaskTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomDirtMaskTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Multiplier for all bloom contributions >=0: off, 1(default), >1 brighter
		/// </summary>
		public float BloomIntensity
		{
			get => E_PROP_FPostProcessSettings_BloomIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scale for all bloom sizes
		/// </summary>
		public float Sizescale
		{
			get => E_PROP_FPostProcessSettings_BloomSizeScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomSizeScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// minimum brightness the bloom starts having effect
		/// <para>-1:all pixels affect bloom equally (physically correct, faster as a threshold pass is omitted), 0:all pixels affect bloom brights more, 1(default), >1 brighter </para>
		/// </summary>
		public float BloomThreshold
		{
			get => E_PROP_FPostProcessSettings_BloomThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Correct for artifacts with "electric" blues due to the ACEScg color space. Bright blue desaturates instead of going to violet.
		/// </summary>
		public float BlueCorrection
		{
			get => E_PROP_FPostProcessSettings_BlueCorrection_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BlueCorrection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Enable HQ Gaussian on high end mobile platforms. (ES3_1)
		/// </summary>
		public byte HighQualityGaussianDoFonMobile
		{
			get => E_PROP_FPostProcessSettings_bMobileHQGaussian_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bMobileHQGaussian_SET(NativePointer, value);
		}

		public byte bOverride_AmbientCubemapIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientCubemapIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientCubemapIntensity_SET(NativePointer, value);
		}

		public byte bOverride_AmbientCubemapTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientCubemapTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientCubemapTint_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionBias
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionBias_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionDistance_DEPRECATED
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionDistance_DEPRECATED_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionDistance_DEPRECATED_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionFadeDistance
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeDistance_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionFadeRadius
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionFadeRadius_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionMipBlend
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipBlend_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipBlend_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionMipScale
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipScale_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionMipThreshold
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionMipThreshold_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionPower
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionPower_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionPower_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionQuality
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionQuality_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionRadius
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadius_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionRadiusInWS
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadiusInWS_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionRadiusInWS_SET(NativePointer, value);
		}

		public byte bOverride_AmbientOcclusionStaticFraction
		{
			get => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionStaticFraction_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AmbientOcclusionStaticFraction_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureBias
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureBias_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureBiasCurve
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureBiasCurve_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureBiasCurve_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureCalibrationConstant
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureCalibrationConstant_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureCalibrationConstant_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureHighPercent
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureHighPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureHighPercent_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureLowPercent
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureLowPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureLowPercent_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureMaxBrightness
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureMaxBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureMaxBrightness_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureMethod
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureMethod_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureMethod_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureMinBrightness
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureMinBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureMinBrightness_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureSpeedDown
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedDown_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedDown_SET(NativePointer, value);
		}

		public byte bOverride_AutoExposureSpeedUp
		{
			get => E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedUp_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_AutoExposureSpeedUp_SET(NativePointer, value);
		}

		public byte bOverride_Bloom1Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom1Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom1Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom1Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom1Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom1Tint_SET(NativePointer, value);
		}

		public byte bOverride_Bloom2Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom2Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom2Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom2Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom2Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom2Tint_SET(NativePointer, value);
		}

		public byte bOverride_Bloom3Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom3Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom3Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom3Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom3Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom3Tint_SET(NativePointer, value);
		}

		public byte bOverride_Bloom4Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom4Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom4Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom4Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom4Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom4Tint_SET(NativePointer, value);
		}

		public byte bOverride_Bloom5Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom5Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom5Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom5Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom5Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom5Tint_SET(NativePointer, value);
		}

		public byte bOverride_Bloom6Size
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom6Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom6Size_SET(NativePointer, value);
		}

		public byte bOverride_Bloom6Tint
		{
			get => E_PROP_FPostProcessSettings_bOverride_Bloom6Tint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_Bloom6Tint_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionBufferScale
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionBufferScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionBufferScale_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionCenterUV
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionCenterUV_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionCenterUV_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionPreFilter_DEPRECATED
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilter_DEPRECATED_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilter_DEPRECATED_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionPreFilterMax
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMax_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionPreFilterMin
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMin_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionPreFilterMult
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMult_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionPreFilterMult_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionSize_SET(NativePointer, value);
		}

		public byte bOverride_BloomConvolutionTexture
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionTexture_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomConvolutionTexture_SET(NativePointer, value);
		}

		public byte bOverride_BloomDirtMask
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomDirtMask_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomDirtMask_SET(NativePointer, value);
		}

		public byte bOverride_BloomDirtMaskIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskIntensity_SET(NativePointer, value);
		}

		public byte bOverride_BloomDirtMaskTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomDirtMaskTint_SET(NativePointer, value);
		}

		public byte bOverride_BloomIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomIntensity_SET(NativePointer, value);
		}

		public byte bOverride_BloomMethod
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomMethod_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomMethod_SET(NativePointer, value);
		}

		public byte bOverride_BloomSizeScale
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomSizeScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomSizeScale_SET(NativePointer, value);
		}

		public byte bOverride_BloomThreshold
		{
			get => E_PROP_FPostProcessSettings_bOverride_BloomThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BloomThreshold_SET(NativePointer, value);
		}

		public byte bOverride_BlueCorrection
		{
			get => E_PROP_FPostProcessSettings_bOverride_BlueCorrection_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_BlueCorrection_SET(NativePointer, value);
		}

		public byte bOverride_CameraISO
		{
			get => E_PROP_FPostProcessSettings_bOverride_CameraISO_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_CameraISO_SET(NativePointer, value);
		}

		public byte bOverride_CameraShutterSpeed
		{
			get => E_PROP_FPostProcessSettings_bOverride_CameraShutterSpeed_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_CameraShutterSpeed_SET(NativePointer, value);
		}

		public byte bOverride_ChromaticAberrationStartOffset
		{
			get => E_PROP_FPostProcessSettings_bOverride_ChromaticAberrationStartOffset_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ChromaticAberrationStartOffset_SET(NativePointer, value);
		}

		public byte bOverride_ColorContrast
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorContrast_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorContrast_SET(NativePointer, value);
		}

		public byte bOverride_ColorContrastHighlights
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorContrastHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorContrastHighlights_SET(NativePointer, value);
		}

		public byte bOverride_ColorContrastMidtones
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorContrastMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorContrastMidtones_SET(NativePointer, value);
		}

		public byte bOverride_ColorContrastShadows
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorContrastShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorContrastShadows_SET(NativePointer, value);
		}

		public byte bOverride_ColorCorrectionHighlightsMin
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorCorrectionHighlightsMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorCorrectionHighlightsMin_SET(NativePointer, value);
		}

		public byte bOverride_ColorCorrectionShadowsMax
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorCorrectionShadowsMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorCorrectionShadowsMax_SET(NativePointer, value);
		}

		public byte bOverride_ColorGain
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGain_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGain_SET(NativePointer, value);
		}

		public byte bOverride_ColorGainHighlights
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGainHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGainHighlights_SET(NativePointer, value);
		}

		public byte bOverride_ColorGainMidtones
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGainMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGainMidtones_SET(NativePointer, value);
		}

		public byte bOverride_ColorGainShadows
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGainShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGainShadows_SET(NativePointer, value);
		}

		public byte bOverride_ColorGamma
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGamma_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGamma_SET(NativePointer, value);
		}

		public byte bOverride_ColorGammaHighlights
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGammaHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGammaHighlights_SET(NativePointer, value);
		}

		public byte bOverride_ColorGammaMidtones
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGammaMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGammaMidtones_SET(NativePointer, value);
		}

		public byte bOverride_ColorGammaShadows
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGammaShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGammaShadows_SET(NativePointer, value);
		}

		public byte bOverride_ColorGradingIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGradingIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGradingIntensity_SET(NativePointer, value);
		}

		public byte bOverride_ColorGradingLUT
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorGradingLUT_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorGradingLUT_SET(NativePointer, value);
		}

		public byte bOverride_ColorOffset
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorOffset_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorOffset_SET(NativePointer, value);
		}

		public byte bOverride_ColorOffsetHighlights
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorOffsetHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorOffsetHighlights_SET(NativePointer, value);
		}

		public byte bOverride_ColorOffsetMidtones
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorOffsetMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorOffsetMidtones_SET(NativePointer, value);
		}

		public byte bOverride_ColorOffsetShadows
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorOffsetShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorOffsetShadows_SET(NativePointer, value);
		}

		public byte bOverride_ColorSaturation
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorSaturation_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorSaturation_SET(NativePointer, value);
		}

		public byte bOverride_ColorSaturationHighlights
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorSaturationHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorSaturationHighlights_SET(NativePointer, value);
		}

		public byte bOverride_ColorSaturationMidtones
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorSaturationMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorSaturationMidtones_SET(NativePointer, value);
		}

		public byte bOverride_ColorSaturationShadows
		{
			get => E_PROP_FPostProcessSettings_bOverride_ColorSaturationShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ColorSaturationShadows_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldBladeCount
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBladeCount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBladeCount_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldBokehShape
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBokehShape_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldBokehShape_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldColorThreshold
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldColorThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldColorThreshold_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldDepthBlurAmount
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurAmount_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldDepthBlurRadius
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldDepthBlurRadius_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldFarBlurSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarBlurSize_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldFarTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFarTransitionRegion_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldFocalDistance
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalDistance_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldFocalRegion
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFocalRegion_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldFstop
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFstop_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldFstop_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldMaxBokehSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMaxBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMaxBokehSize_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldMethod
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMethod_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMethod_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldMinFstop
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMinFstop_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldMinFstop_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldNearBlurSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearBlurSize_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldNearTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldNearTransitionRegion_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldOcclusion
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldOcclusion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldOcclusion_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldScale
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldScale_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldSensorWidth
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSensorWidth_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSensorWidth_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldSizeThreshold
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSizeThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSizeThreshold_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldSkyFocusDistance
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSkyFocusDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldSkyFocusDistance_SET(NativePointer, value);
		}

		public byte bOverride_DepthOfFieldVignetteSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldVignetteSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_DepthOfFieldVignetteSize_SET(NativePointer, value);
		}

		public byte bOverride_ExpandGamut
		{
			get => E_PROP_FPostProcessSettings_bOverride_ExpandGamut_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ExpandGamut_SET(NativePointer, value);
		}

		public byte bOverride_FilmBlackClip
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmBlackClip_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmBlackClip_SET(NativePointer, value);
		}

		public byte bOverride_FilmChannelMixerBlue
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerBlue_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerBlue_SET(NativePointer, value);
		}

		public byte bOverride_FilmChannelMixerGreen
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerGreen_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerGreen_SET(NativePointer, value);
		}

		public byte bOverride_FilmChannelMixerRed
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerRed_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmChannelMixerRed_SET(NativePointer, value);
		}

		public byte bOverride_FilmContrast
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmContrast_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmContrast_SET(NativePointer, value);
		}

		public byte bOverride_FilmDynamicRange
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmDynamicRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmDynamicRange_SET(NativePointer, value);
		}

		public byte bOverride_FilmHealAmount
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmHealAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmHealAmount_SET(NativePointer, value);
		}

		public byte bOverride_FilmSaturation
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmSaturation_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmSaturation_SET(NativePointer, value);
		}

		public byte bOverride_FilmShadowTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmShadowTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmShadowTint_SET(NativePointer, value);
		}

		public byte bOverride_FilmShadowTintAmount
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmShadowTintAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmShadowTintAmount_SET(NativePointer, value);
		}

		public byte bOverride_FilmShadowTintBlend
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmShadowTintBlend_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmShadowTintBlend_SET(NativePointer, value);
		}

		public byte bOverride_FilmShoulder
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmShoulder_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmShoulder_SET(NativePointer, value);
		}

		public byte bOverride_FilmSlope
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmSlope_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmSlope_SET(NativePointer, value);
		}

		public byte bOverride_FilmToe
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmToe_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmToe_SET(NativePointer, value);
		}

		public byte bOverride_FilmToeAmount
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmToeAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmToeAmount_SET(NativePointer, value);
		}

		public byte bOverride_FilmWhiteClip
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmWhiteClip_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmWhiteClip_SET(NativePointer, value);
		}

		public byte bOverride_FilmWhitePoint
		{
			get => E_PROP_FPostProcessSettings_bOverride_FilmWhitePoint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_FilmWhitePoint_SET(NativePointer, value);
		}

		public byte bOverride_GrainIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_GrainIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_GrainIntensity_SET(NativePointer, value);
		}

		public byte bOverride_GrainJitter
		{
			get => E_PROP_FPostProcessSettings_bOverride_GrainJitter_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_GrainJitter_SET(NativePointer, value);
		}

		public byte bOverride_HistogramLogMax
		{
			get => E_PROP_FPostProcessSettings_bOverride_HistogramLogMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_HistogramLogMax_SET(NativePointer, value);
		}

		public byte bOverride_HistogramLogMin
		{
			get => E_PROP_FPostProcessSettings_bOverride_HistogramLogMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_HistogramLogMin_SET(NativePointer, value);
		}

		public byte bOverride_IndirectLightingColor
		{
			get => E_PROP_FPostProcessSettings_bOverride_IndirectLightingColor_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_IndirectLightingColor_SET(NativePointer, value);
		}

		public byte bOverride_IndirectLightingIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_IndirectLightingIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_IndirectLightingIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareBokehShape
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareBokehShape_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareBokehShape_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareBokehSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareBokehSize_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareThreshold
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareThreshold_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareTint_SET(NativePointer, value);
		}

		public byte bOverride_LensFlareTints
		{
			get => E_PROP_FPostProcessSettings_bOverride_LensFlareTints_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LensFlareTints_SET(NativePointer, value);
		}

		public byte bOverride_LPVDiffuseOcclusionExponent
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionExponent_SET(NativePointer, value);
		}

		public byte bOverride_LPVDiffuseOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVDiffuseOcclusionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVDirectionalOcclusionFadeRange
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionFadeRange_SET(NativePointer, value);
		}

		public byte bOverride_LPVDirectionalOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVDirectionalOcclusionRadius
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVDirectionalOcclusionRadius_SET(NativePointer, value);
		}

		public byte bOverride_LPVEmissiveInjectionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVEmissiveInjectionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVEmissiveInjectionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVFadeRange
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVFadeRange_SET(NativePointer, value);
		}

		public byte bOverride_LPVGeometryVolumeBias
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVGeometryVolumeBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVGeometryVolumeBias_SET(NativePointer, value);
		}

		public byte bOverride_LPVIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVSecondaryBounceIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVSecondaryBounceIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVSecondaryBounceIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVSecondaryOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVSecondaryOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVSecondaryOcclusionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVSize_SET(NativePointer, value);
		}

		public byte bOverride_LPVSpecularOcclusionExponent
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionExponent_SET(NativePointer, value);
		}

		public byte bOverride_LPVSpecularOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVSpecularOcclusionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_LPVVplInjectionBias
		{
			get => E_PROP_FPostProcessSettings_bOverride_LPVVplInjectionBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_LPVVplInjectionBias_SET(NativePointer, value);
		}

		public byte bOverride_MobileHQGaussian
		{
			get => E_PROP_FPostProcessSettings_bOverride_MobileHQGaussian_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_MobileHQGaussian_SET(NativePointer, value);
		}

		public byte bOverride_MotionBlurAmount
		{
			get => E_PROP_FPostProcessSettings_bOverride_MotionBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_MotionBlurAmount_SET(NativePointer, value);
		}

		public byte bOverride_MotionBlurMax
		{
			get => E_PROP_FPostProcessSettings_bOverride_MotionBlurMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_MotionBlurMax_SET(NativePointer, value);
		}

		public byte bOverride_MotionBlurPerObjectSize
		{
			get => E_PROP_FPostProcessSettings_bOverride_MotionBlurPerObjectSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_MotionBlurPerObjectSize_SET(NativePointer, value);
		}

		public byte bOverride_SceneColorTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_SceneColorTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_SceneColorTint_SET(NativePointer, value);
		}

		public byte bOverride_SceneFringeIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_SceneFringeIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_SceneFringeIntensity_SET(NativePointer, value);
		}

		public byte bOverride_ScreenPercentage
		{
			get => E_PROP_FPostProcessSettings_bOverride_ScreenPercentage_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ScreenPercentage_SET(NativePointer, value);
		}

		public byte bOverride_ScreenSpaceReflectionIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionIntensity_SET(NativePointer, value);
		}

		public byte bOverride_ScreenSpaceReflectionMaxRoughness
		{
			get => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionMaxRoughness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionMaxRoughness_SET(NativePointer, value);
		}

		public byte bOverride_ScreenSpaceReflectionQuality
		{
			get => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionQuality_SET(NativePointer, value);
		}

		public byte bOverride_ScreenSpaceReflectionRoughnessScale
		{
			get => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionRoughnessScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_ScreenSpaceReflectionRoughnessScale_SET(NativePointer, value);
		}

		public byte bOverride_VignetteIntensity
		{
			get => E_PROP_FPostProcessSettings_bOverride_VignetteIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_VignetteIntensity_SET(NativePointer, value);
		}

		public byte bOverride_WhiteTemp
		{
			get => E_PROP_FPostProcessSettings_bOverride_WhiteTemp_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_WhiteTemp_SET(NativePointer, value);
		}

		public byte bOverride_WhiteTint
		{
			get => E_PROP_FPostProcessSettings_bOverride_WhiteTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_bOverride_WhiteTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The camera sensor sensitivity in ISO.
		/// </summary>
		public float ISO
		{
			get => E_PROP_FPostProcessSettings_CameraISO_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_CameraISO_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The camera shutter in seconds.
		/// </summary>
		public float ShutterSpeed1s
		{
			get => E_PROP_FPostProcessSettings_CameraShutterSpeed_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_CameraShutterSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A normalized distance to the center of the framebuffer where the effect takes place.
		/// </summary>
		public float StartOffset
		{
			get => E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_SET(NativePointer, value);
		}

		public FVector4 ColorContrast
		{
			get => E_PROP_FPostProcessSettings_ColorContrast_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorContrast_SET(NativePointer, value);
		}

		public FVector4 ColorContrastHighlights
		{
			get => E_PROP_FPostProcessSettings_ColorContrastHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorContrastHighlights_SET(NativePointer, value);
		}

		public FVector4 ColorContrastMidtones
		{
			get => E_PROP_FPostProcessSettings_ColorContrastMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorContrastMidtones_SET(NativePointer, value);
		}

		public FVector4 ColorContrastShadows
		{
			get => E_PROP_FPostProcessSettings_ColorContrastShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorContrastShadows_SET(NativePointer, value);
		}

		public float HighlightsMin
		{
			get => E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_SET(NativePointer, value);
		}

		public float ShadowsMax
		{
			get => E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_SET(NativePointer, value);
		}

		public FVector4 ColorGain
		{
			get => E_PROP_FPostProcessSettings_ColorGain_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGain_SET(NativePointer, value);
		}

		public FVector4 ColorGainHighlights
		{
			get => E_PROP_FPostProcessSettings_ColorGainHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGainHighlights_SET(NativePointer, value);
		}

		public FVector4 ColorGainMidtones
		{
			get => E_PROP_FPostProcessSettings_ColorGainMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGainMidtones_SET(NativePointer, value);
		}

		public FVector4 ColorGainShadows
		{
			get => E_PROP_FPostProcessSettings_ColorGainShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGainShadows_SET(NativePointer, value);
		}

		public FVector4 ColorGamma
		{
			get => E_PROP_FPostProcessSettings_ColorGamma_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGamma_SET(NativePointer, value);
		}

		public FVector4 ColorGammaHighlights
		{
			get => E_PROP_FPostProcessSettings_ColorGammaHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGammaHighlights_SET(NativePointer, value);
		}

		public FVector4 ColorGammaMidtones
		{
			get => E_PROP_FPostProcessSettings_ColorGammaMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGammaMidtones_SET(NativePointer, value);
		}

		public FVector4 ColorGammaShadows
		{
			get => E_PROP_FPostProcessSettings_ColorGammaShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGammaShadows_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Color grading lookup table intensity. 0 = no intensity, 1=full intensity
		/// </summary>
		public float ColorGradingLUTIntensity
		{
			get => E_PROP_FPostProcessSettings_ColorGradingIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorGradingIntensity_SET(NativePointer, value);
		}

		public FVector4 ColorOffset
		{
			get => E_PROP_FPostProcessSettings_ColorOffset_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorOffset_SET(NativePointer, value);
		}

		public FVector4 ColorOffsetHighlights
		{
			get => E_PROP_FPostProcessSettings_ColorOffsetHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorOffsetHighlights_SET(NativePointer, value);
		}

		public FVector4 ColorOffsetMidtones
		{
			get => E_PROP_FPostProcessSettings_ColorOffsetMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorOffsetMidtones_SET(NativePointer, value);
		}

		public FVector4 ColorOffsetShadows
		{
			get => E_PROP_FPostProcessSettings_ColorOffsetShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorOffsetShadows_SET(NativePointer, value);
		}

		public FVector4 ColorSaturation
		{
			get => E_PROP_FPostProcessSettings_ColorSaturation_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorSaturation_SET(NativePointer, value);
		}

		public FVector4 ColorSaturationHighlights
		{
			get => E_PROP_FPostProcessSettings_ColorSaturationHighlights_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorSaturationHighlights_SET(NativePointer, value);
		}

		public FVector4 ColorSaturationMidtones
		{
			get => E_PROP_FPostProcessSettings_ColorSaturationMidtones_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorSaturationMidtones_SET(NativePointer, value);
		}

		public FVector4 ColorSaturationShadows
		{
			get => E_PROP_FPostProcessSettings_ColorSaturationShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ColorSaturationShadows_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Defines the number of blades of the diaphragm within the lens (between 4 and 16).
		/// </summary>
		public int Numberofdiaphragmblades
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldBladeCount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldBladeCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// DEPRECATED: Color threshold to do full quality DOF (BokehDOF only)
		/// </summary>
		public float ColorThreshold
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// CircleDOF only: Depth blur km for 50%
		/// </summary>
		public float DepthBlurkmfor50
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// CircleDOF only: Depth blur radius in pixels at 1920x
		/// </summary>
		public float DepthBlurRadius
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)
		/// </summary>
		public float FarBlurSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// To define the width of the transition region next to the focal region on the near side (cm)
		/// </summary>
		public float FarTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance in which the Depth of Field effect should be sharp, in unreal units (cm)
		/// </summary>
		public float FocalDistance
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Artificial region where all content is in focus, starting after DepthOfFieldFocalDistance, in unreal units  (cm)
		/// </summary>
		public float FocalRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Defines the opening of the camera lens, Aperture is 1/fstop, typical lens go down to f/1.2 (large opening), larger numbers reduce the DOF effect
		/// </summary>
		public float ApertureFstop
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(NativePointer, value);
		}

		
		/// <summary>
		/// DEPRECATED: BokehDOF only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size*size)
		/// </summary>
		public float MaxBokehSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Defines the maximum opening of the camera lens to control the curvature of blades of the diaphragm. Set it to 0 to get straight blades.
		/// </summary>
		public float MaximumApertureminFstop
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldMinFstop_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldMinFstop_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)
		/// </summary>
		public float NearBlurSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// To define the width of the transition region next to the focal region on the near side (cm)
		/// </summary>
		public float NearTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Occlusion tweak factor 1 (0.18 to get natural occlusion, 0.4 to solve layer color leaking issues)
		/// </summary>
		public float Occlusion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// SM5: BokehDOF only: To amplify the depth of field effect (like aperture)  0=off
		/// <para>ES2: Used to blend DoF. 0=off </para>
		/// </summary>
		public float Scale
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Width of the camera sensor to assume, in mm.
		/// </summary>
		public float SensorWidthmm
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// DEPRECATED: Size threshold to do full quality DOF (BokehDOF only)
		/// </summary>
		public float SizeThreshold
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Artificial distance to allow the skybox to be in focus (e.g. 200000), <=0 to switch the feature off, only for GaussianDOF, can cost performance
		/// </summary>
		public float SkyDistance
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Artificial circular mask to (near) blur content outside the radius, only for GaussianDOF, diameter in percent of screen width, costs performance if the mask is used, keep Feather can Radius on default to keep it off
		/// </summary>
		public float VignetteSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Expand bright saturated colors outside the sRGB gamut to fake wide gamut rendering.
		/// </summary>
		public float ExpandGamut
		{
			get => E_PROP_FPostProcessSettings_ExpandGamut_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ExpandGamut_SET(NativePointer, value);
		}

		public float Blackclip
		{
			get => E_PROP_FPostProcessSettings_FilmBlackClip_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmBlackClip_SET(NativePointer, value);
		}

		public FLinearColor ChannelMixerBlue
		{
			get => E_PROP_FPostProcessSettings_FilmChannelMixerBlue_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmChannelMixerBlue_SET(NativePointer, value);
		}

		public FLinearColor ChannelMixerGreen
		{
			get => E_PROP_FPostProcessSettings_FilmChannelMixerGreen_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmChannelMixerGreen_SET(NativePointer, value);
		}

		public FLinearColor ChannelMixerRed
		{
			get => E_PROP_FPostProcessSettings_FilmChannelMixerRed_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmChannelMixerRed_SET(NativePointer, value);
		}

		public float FilmContrast
		{
			get => E_PROP_FPostProcessSettings_FilmContrast_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmContrast_SET(NativePointer, value);
		}

		public float DynamicRange
		{
			get => E_PROP_FPostProcessSettings_FilmDynamicRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmDynamicRange_SET(NativePointer, value);
		}

		public float CrushHighlights
		{
			get => E_PROP_FPostProcessSettings_FilmHealAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmHealAmount_SET(NativePointer, value);
		}

		public float FilmSaturation
		{
			get => E_PROP_FPostProcessSettings_FilmSaturation_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmSaturation_SET(NativePointer, value);
		}

		public FLinearColor TintShadow
		{
			get => E_PROP_FPostProcessSettings_FilmShadowTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmShadowTint_SET(NativePointer, value);
		}

		public float TintShadowAmount
		{
			get => E_PROP_FPostProcessSettings_FilmShadowTintAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmShadowTintAmount_SET(NativePointer, value);
		}

		public float TintShadowBlend
		{
			get => E_PROP_FPostProcessSettings_FilmShadowTintBlend_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmShadowTintBlend_SET(NativePointer, value);
		}

		public float Shoulder
		{
			get => E_PROP_FPostProcessSettings_FilmShoulder_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmShoulder_SET(NativePointer, value);
		}

		public float Slope
		{
			get => E_PROP_FPostProcessSettings_FilmSlope_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmSlope_SET(NativePointer, value);
		}

		public float Toe
		{
			get => E_PROP_FPostProcessSettings_FilmToe_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmToe_SET(NativePointer, value);
		}

		public float CrushShadows
		{
			get => E_PROP_FPostProcessSettings_FilmToeAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmToeAmount_SET(NativePointer, value);
		}

		public float Whiteclip
		{
			get => E_PROP_FPostProcessSettings_FilmWhiteClip_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmWhiteClip_SET(NativePointer, value);
		}

		public FLinearColor FilmWhitePoint
		{
			get => E_PROP_FPostProcessSettings_FilmWhitePoint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmWhitePoint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0..1 grain intensity
		/// </summary>
		public float GrainIntensity
		{
			get => E_PROP_FPostProcessSettings_GrainIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_GrainIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0..1 grain jitter
		/// </summary>
		public float GrainJitter
		{
			get => E_PROP_FPostProcessSettings_GrainJitter_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_GrainJitter_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Histogram Max value. Expressed in Log2(Luminance) or in EV100 when using ExtendDefaultLuminanceRange (see project settings)
		/// </summary>
		public float HistogramLogMax
		{
			get => E_PROP_FPostProcessSettings_HistogramLogMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_HistogramLogMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Histogram Min value. Expressed in Log2(Luminance) or in EV100 when using ExtendDefaultLuminanceRange (see project settings)
		/// </summary>
		public float HistogramLogMin
		{
			get => E_PROP_FPostProcessSettings_HistogramLogMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_HistogramLogMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Adjusts indirect lighting color. (1,1,1) is default. (0,0,0) to disable GI. The show flag 'Global Illumination' must be enabled to use this property.
		/// </summary>
		public FLinearColor IndirectLightingColor
		{
			get => E_PROP_FPostProcessSettings_IndirectLightingColor_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_IndirectLightingColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the indirect lighting contribution. A value of 0 disables GI. Default is 1. The show flag 'Global Illumination' must be enabled to use this property.
		/// </summary>
		public float IndirectLightingIntensity
		{
			get => E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Size of the Lens Blur (in percent of the view width) that is done with the Bokeh texture (note: performance cost is radius*radius)
		/// </summary>
		public float BokehSize
		{
			get => E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Brightness scale of the image cased lens flares (linear)
		/// </summary>
		public float LensFlareIntensity
		{
			get => E_PROP_FPostProcessSettings_LensFlareIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum brightness the lens flare starts having effect (this should be as high as possible to avoid the performance cost of blurring content that is too dark too see)
		/// </summary>
		public float LensFlareThreshold
		{
			get => E_PROP_FPostProcessSettings_LensFlareThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Tint color for the image based lens flares.
		/// </summary>
		public FLinearColor LensFlareTint
		{
			get => E_PROP_FPostProcessSettings_LensFlareTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diffuse occlusion exponent - increase for more contrast. 1 to 2 is recommended
		/// </summary>
		public float Diffuseocclusionexponent
		{
			get => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Diffuse occlusion intensity - higher values provide increased diffuse occlusion.
		/// </summary>
		public float Diffuseocclusionintensity
		{
			get => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// LPV Directional Occlusion Fade range - increase to fade more gradually towards the LPV edges.
		/// </summary>
		public float DOFaderange
		{
			get => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the amount of directional occlusion. Requires LPV. Values very close to 1.0 are recommended
		/// </summary>
		public float OcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Occlusion Radius - 16 is recommended for most scenes
		/// </summary>
		public float OcclusionRadius
		{
			get => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_SET(NativePointer, value);
		}

		public float EmissiveInjectionIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// LPV Fade range - increase to fade more gradually towards the LPV edges.
		/// </summary>
		public float Faderange
		{
			get => E_PROP_FPostProcessSettings_LPVFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVFadeRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bias applied to the geometry volume in cell units. Increase to reduce darkening due to secondary occlusion
		/// </summary>
		public float GeometryVolumeBias
		{
			get => E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How strong the dynamic GI from the LPV should be. 0.0 is off, 1.0 is the "normal" value, but higher values can be used to boost the effect
		/// </summary>
		public float LPVIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Secondary bounce light strength (bounce light shadows). Set to 0 to disable
		/// </summary>
		public float SecondaryBounceIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Secondary occlusion strength (bounce light shadows). Set to 0 to disable
		/// </summary>
		public float SecondaryOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The size of the LPV volume, in Unreal units
		/// </summary>
		public float Size
		{
			get => E_PROP_FPostProcessSettings_LPVSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Specular occlusion exponent - increase for more contrast. 6 to 9 is recommended
		/// </summary>
		public float Specularocclusionexponent
		{
			get => E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Specular occlusion intensity - higher values provide increased specular occlusion.
		/// </summary>
		public float Specularocclusionintensity
		{
			get => E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bias applied to light injected into the LPV in cell units. Increase to reduce bleeding through thin walls
		/// </summary>
		public float LightInjectionBias
		{
			get => E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Strength of motion blur, 0:off, should be renamed to intensity
		/// </summary>
		public float Amount
		{
			get => E_PROP_FPostProcessSettings_MotionBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurAmount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// max distortion caused by motion blur, in percent of the screen width, 0:off
		/// </summary>
		public float Max
		{
			get => E_PROP_FPostProcessSettings_MotionBlurMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The minimum projected screen radius for a primitive to be drawn in the velocity pass, percentage of screen width. smaller numbers cause more draw calls, default: 4%
		/// </summary>
		public float PerObjectSize
		{
			get => E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the path tracing maximum bounces
		/// </summary>
		public int PathTracingMaxBounces
		{
			get => E_PROP_FPostProcessSettings_PathTracingMaxBounces_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_PathTracingMaxBounces_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the samples per pixel for the path tracer.
		/// </summary>
		public int PathTracingSamplesPerPixel
		{
			get => E_PROP_FPostProcessSettings_PathTracingSamplesPerPixel_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_PathTracingSamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the samples per pixel for ray tracing global illumination.
		/// </summary>
		public int RayTracingAOSamplesPerPixel
		{
			get => E_PROP_FPostProcessSettings_RayTracingAOSamplesPerPixel_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingAOSamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the ray tracing global illumination maximum bounces.
		/// </summary>
		public int RayTracingGIMaxBounces
		{
			get => E_PROP_FPostProcessSettings_RayTracingGIMaxBounces_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingGIMaxBounces_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the samples per pixel for ray tracing global illumination.
		/// </summary>
		public int RayTracingGISamplesPerPixel
		{
			get => E_PROP_FPostProcessSettings_RayTracingGISamplesPerPixel_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingGISamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the maximum number of ray tracing reflection bounces.
		/// </summary>
		public int RayTracingReflectionsMaxBounces
		{
			get => E_PROP_FPostProcessSettings_RayTracingReflectionsMaxBounces_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingReflectionsMaxBounces_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the maximum roughness until which ray tracing reflections will be visible (lower value is faster). Reflection contribution is smoothly faded when close to roughness threshold. This parameter behaves similarly to ScreenSpaceReflectionMaxRoughness.
		/// </summary>
		public float RayTracingReflectionsMaxRoughness
		{
			get => E_PROP_FPostProcessSettings_RayTracingReflectionsMaxRoughness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingReflectionsMaxRoughness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the samples per pixel for ray traced reflections.
		/// </summary>
		public int RayTracingReflectionsSamplesPerPixel
		{
			get => E_PROP_FPostProcessSettings_RayTracingReflectionsSamplesPerPixel_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingReflectionsSamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the reflected shadows type.
		/// </summary>
		public EReflectedAndRefractedRayTracedShadows RayTracingReflectionsShadows
		{
			get => (EReflectedAndRefractedRayTracedShadows)E_PROP_FPostProcessSettings_RayTracingReflectionsShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingReflectionsShadows_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Sets the maximum roughness until which ray tracing translucency will be visible (lower value is faster). Translucency contribution is smoothly faded when close to roughness threshold. This parameter behaves similarly to ScreenSpaceReflectionMaxRoughness.
		/// </summary>
		public float RayTracingTranslucencyMaxRoughness
		{
			get => E_PROP_FPostProcessSettings_RayTracingTranslucencyMaxRoughness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingTranslucencyMaxRoughness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets whether refraction should be enabled or not (if not rays will not scatter and only travel in the same direction as before the intersection event).
		/// </summary>
		public byte Refraction
		{
			get => E_PROP_FPostProcessSettings_RayTracingTranslucencyRefraction_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingTranslucencyRefraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the maximum number of ray tracing refraction rays.
		/// </summary>
		public int MaxRefractionRays
		{
			get => E_PROP_FPostProcessSettings_RayTracingTranslucencyRefractionRays_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingTranslucencyRefractionRays_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the samples per pixel for ray traced translucency.
		/// </summary>
		public int RayTracingTranslucencySamplesPerPixel
		{
			get => E_PROP_FPostProcessSettings_RayTracingTranslucencySamplesPerPixel_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingTranslucencySamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the translucency shadows type.
		/// </summary>
		public EReflectedAndRefractedRayTracedShadows RayTracingTranslucencyShadows
		{
			get => (EReflectedAndRefractedRayTracedShadows)E_PROP_FPostProcessSettings_RayTracingTranslucencyShadows_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_RayTracingTranslucencyShadows_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Sets the reflections type
		/// </summary>
		public EReflectionsType ReflectionsType
		{
			get => (EReflectionsType)E_PROP_FPostProcessSettings_ReflectionsType_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ReflectionsType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Scene tint color
		/// </summary>
		public FLinearColor SceneColorTint
		{
			get => E_PROP_FPostProcessSettings_SceneColorTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_SceneColorTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.
		/// </summary>
		public float SceneFringeIntensity
		{
			get => E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// To render with lower or high resolution than it is presented,
		/// <para>controlled by console variable, </para>
		/// 100:off, needs to be <99 to get upsampling and lower to get performance,
		/// <para>>100 for super sampling (slower but higher quality), </para>
		/// only applied in game
		/// </summary>
		public float ScreenPercentage
		{
			get => E_PROP_FPostProcessSettings_ScreenPercentage_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenPercentage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Enable/Fade/disable the Screen Space Reflection feature, in percent, avoid numbers between 0 and 1 fo consistency
		/// </summary>
		public float ScreenSpaceReflectionIntensity
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Until what roughness we fade the screen space reflections, 0.8 works well, smaller can run faster
		/// </summary>
		public float ScreenSpaceReflectionMaxRoughness
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition, 50 is the default for better performance.
		/// </summary>
		public float ScreenSpaceReflectionQuality
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Sets the translucency type
		/// </summary>
		public ETranslucencyType TranslucencyType
		{
			get => (ETranslucencyType)E_PROP_FPostProcessSettings_TranslucencyType_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_TranslucencyType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// 0..1 0=off/no vignette .. 1=strong vignette
		/// </summary>
		public float VignetteIntensity
		{
			get => E_PROP_FPostProcessSettings_VignetteIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_VignetteIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending.
		/// <para>For materials this needs to be the "PostProcess" domain type. This can be used for any UObject object implementing the IBlendableInterface (e.g. could be used to fade weather settings). </para>
		/// </summary>
		public FWeightedBlendables PostProcessMaterials
		{
			get => E_PROP_FPostProcessSettings_WeightedBlendables_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_WeightedBlendables_SET(NativePointer, value);
		}

		public float Temp
		{
			get => E_PROP_FPostProcessSettings_WhiteTemp_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_WhiteTemp_SET(NativePointer, value);
		}

		public float WhiteTint
		{
			get => E_PROP_FPostProcessSettings_WhiteTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_WhiteTint_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Used to define the values before any override happens.
		/// <para>Should be as neutral as possible. </para>
		/// </summary>
		public void SetBaseValues()
			=> E_FPostProcessSettings_SetBaseValues(this);
		
		#endregion
		
		public static implicit operator IntPtr(FPostProcessSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPostProcessSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPostProcessSettings(Adress, false);
		}}}
