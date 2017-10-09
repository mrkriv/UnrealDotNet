using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPostProcessSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom1Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom1Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom2Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom2Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom3Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom3Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom4Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom4Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom5Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom5Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_Bloom6Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_Bloom6Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomSizeScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomSizeScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_BloomThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_BloomThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrast_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorContrastShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorContrastShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGain_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGain_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGainShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGainShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGamma_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorGammaShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGammaShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ColorGradingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorGradingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorOffsetShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorOffsetShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationHighlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationHighlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationMidtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationMidtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_ColorSaturationShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ColorSaturationShadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmBlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmBlackClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmContrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmContrast_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmDynamicRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmDynamicRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmHealAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmHealAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmSaturation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShadowTintAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShadowTintAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShadowTintBlend_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShadowTintBlend_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmShoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmShoulder_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmSlope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmSlope_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmToe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmToe_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmToeAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmToeAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_FilmWhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_FilmWhiteClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_GrainIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_GrainIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_GrainJitter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_GrainJitter_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_HistogramLogMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_HistogramLogMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_HistogramLogMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_HistogramLogMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LensFlareThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LensFlareThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVFadeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurAmount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurAmount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenPercentage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_VignetteIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_VignetteIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPostProcessSettings_WeightedBlendables_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WeightedBlendables_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_WhiteTemp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WhiteTemp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPostProcessSettings_WhiteTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPostProcessSettings_WhiteTint_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPostProcessSettings_OnAfterLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPostProcessSettings_SetBaseValues(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>To scale the Ambient cubemap brightness </para>
		/// <para>>=0: off, 1(default), >1 brighter </para>
		/// </summary>
		public float AmbientCubemapIntensity
		{
			get => E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0, in unreal units, default (3.0) works well for flat surfaces but can reduce details </para>
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
		/// <para>>0, in unreal units, at what distance the AO effect disppears in the distance (avoding artifacts and AO effects on huge object) </para>
		/// </summary>
		public float FadeOutDistance
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0, in unreal units, how many units before AmbientOcclusionFadeOutDistance it starts fading out </para>
		/// </summary>
		public float FadeOutRadius
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0..1 0=off/no ambient occlusion .. 1=strong ambient occlusion, defines how much it affects the non direct lighting after base pass </para>
		/// </summary>
		public float AmbientOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Affects the blend over the multiple mips (lower resolution versions) , 0:fully use full resolution, 1::fully use low resolution, around 0.6 seems to be a good value </para>
		/// </summary>
		public float MipBlend
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Affects the radius AO radius scale over the multiple mips (lower resolution versions) </para>
		/// </summary>
		public float MipScale
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>to tweak the bilateral upsampling when using multiple mips (lower resolution versions) </para>
		/// </summary>
		public float MipThreshold
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion </para>
		/// </summary>
		public float Power
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition </para>
		/// </summary>
		public float AmbientOcclusionQuality
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion </para>
		/// </summary>
		public float Radius
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0..1 0=no effect on static lighting .. 1=AO affects the stat lighting, 0 is free meaning no extra rendering pass </para>
		/// </summary>
		public float StaticFraction
		{
			get => E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Logarithmic adjustment for the exposure. Only used if a tonemapper is specified. </para>
		/// <para>0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ... </para>
		/// </summary>
		public float ExposureBias
		{
			get => E_PROP_FPostProcessSettings_AutoExposureBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color. </para>
		/// <para>The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority </para>
		/// <para>but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of </para>
		/// <para>bright spots. </para>
		/// <para>>0, <100, good values are in the range 80 .. 95 </para>
		/// </summary>
		public float HighPercent
		{
			get => E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color. </para>
		/// <para>The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority </para>
		/// <para>but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of </para>
		/// <para>bright spots. </para>
		/// <para>>0, <100, good values are in the range 70 .. 80 </para>
		/// </summary>
		public float LowPercent
		{
			get => E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A good value should be positive (2 is a good value). This is the maximum brightness the auto exposure can adapt to. </para>
		/// <para>It should be tweaked in a bright lighting situation (too small: image appears too bright, too large: image appears too dark). </para>
		/// <para>Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global </para>
		/// <para>effect and defined the HDR range - you don't want to change that late in the project development. </para>
		/// <para>Eye Adaptation is disabled if MinBrightness = MaxBrightness </para>
		/// </summary>
		public float MaxBrightness
		{
			get => E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A good value should be positive near 0. This is the minimum brightness the auto exposure can adapt to. </para>
		/// <para>It should be tweaked in a dark lighting situation (too small: image appears too bright, too large: image appears too dark). </para>
		/// <para>Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global </para>
		/// <para>effect and defined the HDR range - you don't want to change that late in the project development. </para>
		/// <para>Eye Adaptation is disabled if MinBrightness = MaxBrightness </para>
		/// </summary>
		public float MinBrightness
		{
			get => E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0 </para>
		/// </summary>
		public float SpeedDown
		{
			get => E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>>0 </para>
		/// </summary>
		public float SpeedUp
		{
			get => E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for the Bloom1 in percent of the screen width </para>
		/// <para>(is done in 1/2 resolution, larger values cost more performance, good for high frequency details) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom1Size
		{
			get => E_PROP_FPostProcessSettings_Bloom1Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom1Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for Bloom2 in percent of the screen width </para>
		/// <para>(is done in 1/4 resolution, larger values cost more performance) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom2Size
		{
			get => E_PROP_FPostProcessSettings_Bloom2Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom2Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for Bloom3 in percent of the screen width </para>
		/// <para>(is done in 1/8 resolution, larger values cost more performance) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom3Size
		{
			get => E_PROP_FPostProcessSettings_Bloom3Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom3Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for Bloom4 in percent of the screen width </para>
		/// <para>(is done in 1/16 resolution, larger values cost more performance, best for wide contributions) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom4Size
		{
			get => E_PROP_FPostProcessSettings_Bloom4Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom4Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for Bloom5 in percent of the screen width </para>
		/// <para>(is done in 1/32 resolution, larger values cost more performance, best for wide contributions) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom5Size
		{
			get => E_PROP_FPostProcessSettings_Bloom5Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom5Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diameter size for Bloom6 in percent of the screen width </para>
		/// <para>(is done in 1/64 resolution, larger values cost more performance, best for wide contributions) </para>
		/// <para>>=0: can be clamped because of shader limitations </para>
		/// </summary>
		public float Bloom6Size
		{
			get => E_PROP_FPostProcessSettings_Bloom6Size_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_Bloom6Size_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Implicit buffer region as a fraction of the screen size to insure the bloom does not wrap across the screen.  Larger sizes have perf impact. </para>
		/// </summary>
		public float ConvolutionBuffer
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The UV location of the center of the kernel.  Should be very close to (.5,.5) </para>
		/// </summary>
		public FVector2D ConvolutionCenter
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(NativePointer, value);
		}

		public FVector BloomConvolutionPreFilter_DEPRECATED
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables </para>
		/// </summary>
		public float ConvolutionBoostMax
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables </para>
		/// </summary>
		public float ConvolutionBoostMin
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables </para>
		/// </summary>
		public float ConvolutionBoostMult
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Relative size of the convolution kernel image compared to the minor axis of the viewport </para>
		/// </summary>
		public float ConvolutionScale
		{
			get => E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>BloomDirtMask intensity </para>
		/// </summary>
		public float DirtMaskIntensity
		{
			get => E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Multiplier for all bloom contributions >=0: off, 1(default), >1 brighter </para>
		/// </summary>
		public float BloomIntensity
		{
			get => E_PROP_FPostProcessSettings_BloomIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scale for all bloom sizes </para>
		/// </summary>
		public float Sizescale
		{
			get => E_PROP_FPostProcessSettings_BloomSizeScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomSizeScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>minimum brightness the bloom starts having effect </para>
		/// <para>-1:all pixels affect bloom equally (physically correct, faster as a threshold pass is omitted), 0:all pixels affect bloom brights more, 1(default), >1 brighter </para>
		/// </summary>
		public float BloomThreshold
		{
			get => E_PROP_FPostProcessSettings_BloomThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_BloomThreshold_SET(NativePointer, value);
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
		/// <para>Color grading lookup table intensity. 0 = no intensity, 1=full intensity </para>
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
		/// <para>Color threshold to do full quality DOF (BokehDOF only) </para>
		/// </summary>
		public float ColorThreshold
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>CircleDOF only: Depth blur km for 50% </para>
		/// </summary>
		public float DepthBlurkmfor50
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>CircleDOF only: Depth blur radius in pixels at 1920x </para>
		/// </summary>
		public float DepthBlurRadius
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size) </para>
		/// </summary>
		public float FarBlurSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>To define the width of the transition region next to the focal region on the near side (cm) </para>
		/// </summary>
		public float FarTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Distance in which the Depth of Field effect should be sharp, in unreal units (cm) </para>
		/// </summary>
		public float FocalDistance
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Artificial region where all content is in focus, starting after DepthOfFieldFocalDistance, in unreal units  (cm) </para>
		/// </summary>
		public float FocalRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>CircleDOF only: Defines the opening of the camera lens, Aperture is 1/fstop, typical lens go down to f/1.2 (large opening), larger numbers reduce the DOF effect </para>
		/// </summary>
		public float ApertureFstop
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>BokehDOF only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size*size) </para>
		/// </summary>
		public float MaxBokehSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size) </para>
		/// </summary>
		public float NearBlurSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>To define the width of the transition region next to the focal region on the near side (cm) </para>
		/// </summary>
		public float NearTransitionRegion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Occlusion tweak factor 1 (0.18 to get natural occlusion, 0.4 to solve layer color leaking issues) </para>
		/// </summary>
		public float Occlusion
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>SM5: BokehDOF only: To amplify the depth of field effect (like aperture)  0=off </para>
		/// <para>ES2: Used to blend DoF. 0=off </para>
		/// </summary>
		public float Scale
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Width of the camera sensor to assume, in mm. </para>
		/// </summary>
		public float SensorWidthmm
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Size threshold to do full quality DOF (BokehDOF only) </para>
		/// </summary>
		public float SizeThreshold
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Artificial distance to allow the skybox to be in focus (e.g. 200000), <=0 to switch the feature off, only for GaussianDOF, can cost performance </para>
		/// </summary>
		public float SkyDistance
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Artificial circular mask to (near) blur content outside the radius, only for GaussianDOF, diameter in percent of screen width, costs performance if the mask is used, keep Feather can Radius on default to keep it off </para>
		/// </summary>
		public float VignetteSize
		{
			get => E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(NativePointer, value);
		}

		public float Blackclip
		{
			get => E_PROP_FPostProcessSettings_FilmBlackClip_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_FilmBlackClip_SET(NativePointer, value);
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

		
		/// <summary>
		/// <para>0..1 grain intensity </para>
		/// </summary>
		public float GrainIntensity
		{
			get => E_PROP_FPostProcessSettings_GrainIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_GrainIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0..1 grain jitter </para>
		/// </summary>
		public float GrainJitter
		{
			get => E_PROP_FPostProcessSettings_GrainJitter_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_GrainJitter_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>temporary exposed until we found good values 4: 16, 8: 256 </para>
		/// </summary>
		public float HistogramLogMax
		{
			get => E_PROP_FPostProcessSettings_HistogramLogMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_HistogramLogMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>temporary exposed until we found good values, -8: 1/256, -10: 1/1024 </para>
		/// </summary>
		public float HistogramLogMin
		{
			get => E_PROP_FPostProcessSettings_HistogramLogMin_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_HistogramLogMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scales the indirect lighting contribution. A value of 0 disables GI. Default is 1. The show flag 'Global Illumination' must be enabled to use this property. </para>
		/// </summary>
		public float IndirectLightingIntensity
		{
			get => E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Size of the Lens Blur (in percent of the view width) that is done with the Bokeh texture (note: performance cost is radius*radius) </para>
		/// </summary>
		public float BokehSize
		{
			get => E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Brightness scale of the image cased lens flares (linear) </para>
		/// </summary>
		public float LensFlareIntensity
		{
			get => E_PROP_FPostProcessSettings_LensFlareIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum brightness the lens flare starts having effect (this should be as high as possible to avoid the performance cost of blurring content that is too dark too see) </para>
		/// </summary>
		public float LensFlareThreshold
		{
			get => E_PROP_FPostProcessSettings_LensFlareThreshold_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LensFlareThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diffuse occlusion exponent - increase for more contrast. 1 to 2 is recommended </para>
		/// </summary>
		public float Diffuseocclusionexponent
		{
			get => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Diffuse occlusion intensity - higher values provide increased diffuse occlusion. </para>
		/// </summary>
		public float Diffuseocclusionintensity
		{
			get => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>LPV Directional Occlusion Fade range - increase to fade more gradually towards the LPV edges. </para>
		/// </summary>
		public float DOFaderange
		{
			get => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the amount of directional occlusion. Requires LPV. Values very close to 1.0 are recommended </para>
		/// </summary>
		public float OcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Occlusion Radius - 16 is recommended for most scenes </para>
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
		/// <para>LPV Fade range - increase to fade more gradually towards the LPV edges. </para>
		/// </summary>
		public float Faderange
		{
			get => E_PROP_FPostProcessSettings_LPVFadeRange_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVFadeRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Bias applied to the geometry volume in cell units. Increase to reduce darkening due to secondary occlusion </para>
		/// </summary>
		public float GeometryVolumeBias
		{
			get => E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How strong the dynamic GI from the LPV should be. 0.0 is off, 1.0 is the "normal" value, but higher values can be used to boost the effect </para>
		/// </summary>
		public float LPVIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Secondary bounce light strength (bounce light shadows). Set to 0 to disable </para>
		/// </summary>
		public float SecondaryBounceIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Secondary occlusion strength (bounce light shadows). Set to 0 to disable </para>
		/// </summary>
		public float SecondaryOcclusionIntensity
		{
			get => E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The size of the LPV volume, in Unreal units </para>
		/// </summary>
		public float Size
		{
			get => E_PROP_FPostProcessSettings_LPVSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Specular occlusion exponent - increase for more contrast. 6 to 9 is recommended </para>
		/// </summary>
		public float Specularocclusionexponent
		{
			get => E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Specular occlusion intensity - higher values provide increased specular occlusion. </para>
		/// </summary>
		public float Specularocclusionintensity
		{
			get => E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Bias applied to light injected into the LPV in cell units. Increase to reduce bleeding through thin walls </para>
		/// </summary>
		public float LightInjectionBias
		{
			get => E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Strength of motion blur, 0:off, should be renamed to intensity </para>
		/// </summary>
		public float Amount
		{
			get => E_PROP_FPostProcessSettings_MotionBlurAmount_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurAmount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>max distortion caused by motion blur, in percent of the screen width, 0:off </para>
		/// </summary>
		public float Max
		{
			get => E_PROP_FPostProcessSettings_MotionBlurMax_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The minimum projected screen radius for a primitive to be drawn in the velocity pass, percentage of screen width. smaller numbers cause more draw calls, default: 4% </para>
		/// </summary>
		public float PerObjectSize
		{
			get => E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners. </para>
		/// </summary>
		public float ChromaticAberation
		{
			get => E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>To render with lower or high resolution than it is presented, </para>
		/// <para>controlled by console variable, </para>
		/// <para>100:off, needs to be <99 to get upsampling and lower to get performance, </para>
		/// <para>>100 for super sampling (slower but higher quality), </para>
		/// <para>only applied in game </para>
		/// </summary>
		public float ScreenPercentage
		{
			get => E_PROP_FPostProcessSettings_ScreenPercentage_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenPercentage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Enable/Fade/disable the Screen Space Reflection feature, in percent, avoid numbers between 0 and 1 fo consistency </para>
		/// </summary>
		public float ScreenSpaceReflectionIntensity
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Until what roughness we fade the screen space reflections, 0.8 works well, smaller can run faster </para>
		/// </summary>
		public float MaxRoughness
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition, 50 is the default for better performance. </para>
		/// </summary>
		public float ScreenSpaceReflectionQuality
		{
			get => E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0..1 0=off/no vignette .. 1=strong vignette </para>
		/// </summary>
		public float VignetteIntensity
		{
			get => E_PROP_FPostProcessSettings_VignetteIntensity_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_VignetteIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending. </para>
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

		public float Tint
		{
			get => E_PROP_FPostProcessSettings_WhiteTint_GET(NativePointer);
			set => E_PROP_FPostProcessSettings_WhiteTint_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void OnAfterLoad()
			=> E_FPostProcessSettings_OnAfterLoad(this);
		
		
		/// <summary>
		/// <para>Used to define the values before any override happens. </para>
		/// <para>Should be as neutral as possible. </para>
		/// </summary>
		public void SetBaseValues()
			=> E_FPostProcessSettings_SetBaseValues(this);
		
		#endregion
		
		public static implicit operator IntPtr(FPostProcessSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPostProcessSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPostProcessSettings(Adress, false);
		}}}
