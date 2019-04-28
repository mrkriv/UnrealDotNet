// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

namespace UnrealEngine
{
	public  partial class ULightComponent : ULightComponentBase
	{
		public ULightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULightComponent(UObject Parent = null, string Name = "LightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_BloomScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_BloomScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_BloomThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_BloomThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_ContactShadowLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_ContactShadowLength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_DisabledBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_DisabledBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_IESBrightnessScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_IESBrightnessScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_LightFunctionFadeDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_LightFunctionFadeDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULightComponent_LightFunctionScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_LightFunctionScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULightComponent_LightingChannels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_LightingChannels_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_MaxDistanceFadeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_MaxDistanceFadeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_MaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_MaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_MinRoughness_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_MinRoughness_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ULightComponent_PreviewShadowMapChannel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_PreviewShadowMapChannel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_RayStartOffsetDepthScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_RayStartOffsetDepthScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_ShadowBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_ShadowBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_ShadowResolutionScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_ShadowResolutionScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_ShadowSharpen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_ShadowSharpen_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_SpecularScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_SpecularScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponent_Temperature_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponent_Temperature_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponent_AffectsBounds(IntPtr self, IntPtr inBounds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponent_AffectsPrimitive(IntPtr self, IntPtr primitive);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetBoundingBox(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetBoundingSphere(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetLightPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetAffectDynamicIndirectLighting(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetAffectTranslucentLighting(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetBloomScale(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetBloomThreshold(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetEnableLightShaftBloom(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetIESBrightnessScale(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetIndirectLightingIntensity(IntPtr self, float newIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetIntensity(IntPtr self, float newIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightColor(IntPtr self, IntPtr newLightColor, bool bSRGB);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionDisabledBrightness(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionFadeDistance(IntPtr self, float newLightFunctionFadeDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionScale(IntPtr self, IntPtr newLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetShadowBias(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetSpecularScale(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetTemperature(IntPtr self, float newTemperature);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetTransmission(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetUseIESBrightness(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetVolumetricScatteringIntensity(IntPtr self, float newIntensity);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Scales the additive color.
		/// </summary>
		public float BloomScale
		{
			get => E_PROP_ULightComponent_BloomScale_GET(NativePointer);
			set => E_PROP_ULightComponent_BloomScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scene color must be larger than this to create bloom in the light shafts.
		/// </summary>
		public float BloomThreshold
		{
			get => E_PROP_ULightComponent_BloomThreshold_GET(NativePointer);
			set => E_PROP_ULightComponent_BloomThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to use ray traced distance field area shadows.  The project setting bGenerateMeshDistanceFields must be enabled for this to have effect.
		/// <para>Distance field shadows support area lights so they create soft shadows with sharp contacts. </para>
		/// They have less aliasing artifacts than standard shadowmaps, but inherit all the limitations of distance field representations (only uniform scale, no deformation).
		/// <para>These shadows have a low per-object cost (and don't depend on triangle count) so they are effective for distant shadows from a dynamic sun. </para>
		/// </summary>
		public bool RayTracedDistanceFieldShadows
		{
			get => E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_GET(NativePointer);
			set => E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Length of screen space ray trace for sharp contact shadows. Zero is disabled.
		/// </summary>
		public float ContactShadowLength
		{
			get => E_PROP_ULightComponent_ContactShadowLength_GET(NativePointer);
			set => E_PROP_ULightComponent_ContactShadowLength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Brightness factor applied to the light when the light function is specified but disabled, for example in scene captures that use SceneCapView_LitNoShadows.
		/// <para>This should be set to the average brightness of the light function material's emissive input, which should be between 0 and 1. </para>
		/// </summary>
		public float DisabledBrightness
		{
			get => E_PROP_ULightComponent_DisabledBrightness_GET(NativePointer);
			set => E_PROP_ULightComponent_DisabledBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Global scale for IES brightness contribution. Only available when "Use IES Brightness" is selected, and a valid IES profile texture is set
		/// </summary>
		public float IESIntensityScale
		{
			get => E_PROP_ULightComponent_IESBrightnessScale_GET(NativePointer);
			set => E_PROP_ULightComponent_IESBrightnessScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance at which the light function should be completely faded to DisabledBrightness.
		/// <para>This is useful for hiding aliasing from light functions applied in the distance. </para>
		/// </summary>
		public float FadeDistance
		{
			get => E_PROP_ULightComponent_LightFunctionFadeDistance_GET(NativePointer);
			set => E_PROP_ULightComponent_LightFunctionFadeDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the light function projection.  X and Y scale in the directions perpendicular to the light's direction, Z scales along the light direction.
		/// </summary>
		public FVector LightFunctionScale
		{
			get => E_PROP_ULightComponent_LightFunctionScale_GET(NativePointer);
			set => E_PROP_ULightComponent_LightFunctionScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Channels that this light should affect.
		/// <para>These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing. </para>
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get => E_PROP_ULightComponent_LightingChannels_GET(NativePointer);
			set => E_PROP_ULightComponent_LightingChannels_SET(NativePointer, value);
		}

		public float MaxDistanceFadeRange
		{
			get => E_PROP_ULightComponent_MaxDistanceFadeRange_GET(NativePointer);
			set => E_PROP_ULightComponent_MaxDistanceFadeRange_SET(NativePointer, value);
		}

		public float MaxDrawDistance
		{
			get => E_PROP_ULightComponent_MaxDrawDistance_GET(NativePointer);
			set => E_PROP_ULightComponent_MaxDrawDistance_SET(NativePointer, value);
		}

		public float MinRoughness_DEPRECATED
		{
			get => E_PROP_ULightComponent_MinRoughness_DEPRECATED_GET(NativePointer);
			set => E_PROP_ULightComponent_MinRoughness_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Transient shadowmap channel used to preview the results of stationary light shadowmap packing.
		/// </summary>
		public int PreviewShadowMapChannel
		{
			get => E_PROP_ULightComponent_PreviewShadowMapChannel_GET(NativePointer);
			set => E_PROP_ULightComponent_PreviewShadowMapChannel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls how large of an offset ray traced shadows have from the receiving surface as the camera gets further away.
		/// <para>This can be useful to hide self-shadowing artifacts from low resolution distance fields on huge static meshes. </para>
		/// </summary>
		public float RayStartOffsetDepthScale
		{
			get => E_PROP_ULightComponent_RayStartOffsetDepthScale_GET(NativePointer);
			set => E_PROP_ULightComponent_RayStartOffsetDepthScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls how accurate self shadowing of whole scene shadows from this light are.
		/// <para>At 0, shadows will start at the their caster surface, but there will be many self shadowing artifacts. </para>
		/// larger values, shadows will start further from their caster, and there won't be self shadowing artifacts but object might appear to fly.
		/// <para>around 0.5 seems to be a good tradeoff. This also affects the soft transition of shadows </para>
		/// </summary>
		public float ShadowBias
		{
			get => E_PROP_ULightComponent_ShadowBias_GET(NativePointer);
			set => E_PROP_ULightComponent_ShadowBias_SET(NativePointer, value);
		}

		public int ShadowMapChannel_DEPRECATED
		{
			get => E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_GET(NativePointer);
			set => E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the resolution of shadowmaps used to shadow this light.  By default shadowmap resolution is chosen based on screen size of the caster.
		/// <para>Note: shadowmap resolution is still clamped by 'r.Shadow.MaxResolution' </para>
		/// </summary>
		public float ShadowResolutionScale
		{
			get => E_PROP_ULightComponent_ShadowResolutionScale_GET(NativePointer);
			set => E_PROP_ULightComponent_ShadowResolutionScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount to sharpen shadow filtering
		/// </summary>
		public float ShadowFilterSharpen
		{
			get => E_PROP_ULightComponent_ShadowSharpen_GET(NativePointer);
			set => E_PROP_ULightComponent_ShadowSharpen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Multiplier on specular highlights. Use only with great care! Any value besides 1 is not physical!
		/// <para>Can be used to artistically remove highlights mimicking polarizing filters or photo touch up. </para>
		/// </summary>
		public float SpecularScale
		{
			get => E_PROP_ULightComponent_SpecularScale_GET(NativePointer);
			set => E_PROP_ULightComponent_SpecularScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Color temperature in Kelvin of the blackbody illuminant.
		/// <para>White (D65) is 6500K. </para>
		/// </summary>
		public float Temperature
		{
			get => E_PROP_ULightComponent_Temperature_GET(NativePointer);
			set => E_PROP_ULightComponent_Temperature_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Test whether the light affects the given bounding volume.
		/// </summary>
		/// <param name="bounds">The bounding volume to test.</param>
		/// <return>True</return>
		public virtual bool AffectsBounds(FBoxSphereBounds inBounds)
			=> E_ULightComponent_AffectsBounds(this, inBounds);
		
		
		/// <summary>
		/// Test whether this light affects the given primitive.  This checks both the primitive and light settings for light relevance
		/// <para>and also calls AffectsBounds. </para>
		/// </summary>
		/// <param name="primitiveSceneInfo">The primitive to test.</param>
		/// <return>True</return>
		public bool AffectsPrimitive(UPrimitiveComponent primitive)
			=> E_ULightComponent_AffectsPrimitive(this, primitive);
		
		
		/// <summary>
		/// Return the world-space bounding box of the light's influence.
		/// </summary>
		public virtual FBox GetBoundingBox()
			=> E_ULightComponent_GetBoundingBox(this);
		
		public virtual FSphere GetBoundingSphere()
			=> E_ULightComponent_GetBoundingSphere(this);
		
		
		/// <summary>
		/// Return the homogenous position of the light.
		/// </summary>
		public virtual FVector4 GetLightPosition()
			=> E_ULightComponent_GetLightPosition(this);
		
		public void SetAffectDynamicIndirectLighting(bool bNewValue)
			=> E_ULightComponent_SetAffectDynamicIndirectLighting(this, bNewValue);
		
		public void SetAffectTranslucentLighting(bool bNewValue)
			=> E_ULightComponent_SetAffectTranslucentLighting(this, bNewValue);
		
		public void SetBloomScale(float newValue)
			=> E_ULightComponent_SetBloomScale(this, newValue);
		
		public void SetBloomThreshold(float newValue)
			=> E_ULightComponent_SetBloomThreshold(this, newValue);
		
		public void SetEnableLightShaftBloom(bool bNewValue)
			=> E_ULightComponent_SetEnableLightShaftBloom(this, bNewValue);
		
		public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)
			=> E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(this, bNewValue);
		
		public void SetIESIntensityScale(float newValue)
			=> E_ULightComponent_SetIESBrightnessScale(this, newValue);
		
		public void SetIndirectLightingIntensity(float newIntensity)
			=> E_ULightComponent_SetIndirectLightingIntensity(this, newIntensity);
		
		
		/// <summary>
		/// Set intensity of the light
		/// </summary>
		public void SetIntensity(float newIntensity)
			=> E_ULightComponent_SetIntensity(this, newIntensity);
		
		
		/// <summary>
		/// Set color of the light
		/// </summary>
		public void SetLightColor(FLinearColor newLightColor, bool bSRGB = true)
			=> E_ULightComponent_SetLightColor(this, newLightColor, bSRGB);
		
		public void SetLightFunctionDisabledBrightness(float newValue)
			=> E_ULightComponent_SetLightFunctionDisabledBrightness(this, newValue);
		
		public void SetLightFunctionFadeDistance(float newLightFunctionFadeDistance)
			=> E_ULightComponent_SetLightFunctionFadeDistance(this, newLightFunctionFadeDistance);
		
		public void SetLightFunctionScale(FVector newLightFunctionScale)
			=> E_ULightComponent_SetLightFunctionScale(this, newLightFunctionScale);
		
		public void SetShadowBias(float newValue)
			=> E_ULightComponent_SetShadowBias(this, newValue);
		
		public void SetSpecularScale(float newValue)
			=> E_ULightComponent_SetSpecularScale(this, newValue);
		
		public void SetTemperature(float newTemperature)
			=> E_ULightComponent_SetTemperature(this, newTemperature);
		
		public void SetTransmission(bool bNewValue)
			=> E_ULightComponent_SetTransmission(this, bNewValue);
		
		public void SetUseIESIntensity(bool bNewValue)
			=> E_ULightComponent_SetUseIESBrightness(this, bNewValue);
		
		public void SetVolumetricScatteringIntensity(float newIntensity)
			=> E_ULightComponent_SetVolumetricScatteringIntensity(this, newIntensity);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ULightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightComponent>(PtrDesc);
		}}}
