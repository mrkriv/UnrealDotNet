// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:47

namespace UnrealEngine
{
	public  partial class UExponentialHeightFogComponent : USceneComponent
	{
		public UExponentialHeightFogComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UExponentialHeightFogComponent(UObject Parent = null, string Name = "ExponentialHeightFogComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UExponentialHeightFogComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_FogDensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FogDensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UExponentialHeightFogComponent_SecondFogData_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_SecondFogData_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_StartDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_StartDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UExponentialHeightFogComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_AddFogIfNeeded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetDirectionalInscatteringColor(IntPtr self, IntPtr value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogCutoffDistance(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogDensity(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogHeightFalloff(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogInscatteringColor(IntPtr self, IntPtr value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogMaxOpacity(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetInscatteringTextureTint(IntPtr self, IntPtr value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetStartDistance(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFog(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogDistance(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogEmissive(IntPtr self, IntPtr newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(IntPtr self, float newValue);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether to enable Volumetric fog.  Scalability settings control the resolution of the fog simulation.
		/// <para>Note that Volumetric fog currently does not support StartDistance, FogMaxOpacity and FogCutoffDistance. </para>
		/// Volumetric fog also can't match exponential height fog in general as exponential height fog has non-physical behavior.
		/// </summary>
		public bool VolumetricFog
		{
			get => E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to use FogInscatteringColor for the Sky Light volumetric scattering color and DirectionalInscatteringColor for the Directional Light scattering color.
		/// <para>Make sure your directional light has 'Atmosphere Sun Light' enabled! </para>
		/// Enabling this allows Volumetric fog to better match Height fog in the distance, but produces non-physical volumetric lighting that may not match surface lighting.
		/// </summary>
		public bool bOverrideLightColorsWithFogInscatteringColors
		{
			get => E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// <para>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used. </para>
		/// </summary>
		public FLinearColor DirectionalInscatteringColor
		{
			get => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the size of the directional inscattering cone, which is used to approximate inscattering from a directional light.
		/// <para>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used. </para>
		/// </summary>
		public float DirectionalInscatteringExponent
		{
			get => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// <para>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used. </para>
		/// </summary>
		public float DirectionalInscatteringStartDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scene elements past this distance will not have fog applied.  This is useful for excluding skyboxes which already have fog baked in.
		/// </summary>
		public float FogCutoffDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Global density factor.
		/// </summary>
		public float FogDensity
		{
			get => E_PROP_UExponentialHeightFogComponent_FogDensity_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FogDensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Height density factor, controls how the density increases as height decreases.
		/// <para>Smaller values make the visible transition larger. </para>
		/// </summary>
		public float FogHeightFalloff
		{
			get => E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_SET(NativePointer, value);
		}

		public FLinearColor FogInscatteringColor
		{
			get => E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum opacity of the fog.
		/// <para>A value of 1 means the fog can become fully opaque at a distance and replace scene color completely, </para>
		/// A value of 0 means the fog color will not be factored in at all.
		/// </summary>
		public float FogMaxOpacity
		{
			get => E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance at which InscatteringColorCubemap should be used directly for the Inscattering Color.
		/// </summary>
		public float FullyDirectionalInscatteringColorDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Angle to rotate the InscatteringColorCubemap around the Z axis.
		/// </summary>
		public float InscatteringColorCubemapAngle
		{
			get => E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Tint color used when InscatteringColorCubemap is specified, for quick edits without having to reimport InscatteringColorCubemap.
		/// </summary>
		public FLinearColor InscatteringTextureTint
		{
			get => E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance at which only the average color of InscatteringColorCubemap should be used as Inscattering Color.
		/// </summary>
		public float NonDirectionalInscatteringColorDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Settings for the second fog. Setting the density of this to 0 means it doesn't have any influence.
		/// </summary>
		public FExponentialHeightFogData SecondFogData
		{
			get => E_PROP_UExponentialHeightFogComponent_SecondFogData_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_SecondFogData_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance from the camera that the fog will start, in world units.
		/// </summary>
		public float StartDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_StartDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_StartDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance over which volumetric fog should be computed.  Larger values extend the effect into the distance but expose under-sampling artifacts in details.
		/// </summary>
		public float ViewDistance
		{
			get => E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Light emitted by height fog.  This is a density so more light is emitted the further you are looking through the fog.
		/// <para>In most cases skylight is a better choice, however right now volumetric fog does not support precomputed lighting, </para>
		/// So stationary skylights are unshadowed and static skylights don't affect volumetric fog at all.
		/// </summary>
		public FLinearColor Emissive
		{
			get => E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the height fog particle extinction amount used by volumetric fog.  Values larger than 1 cause fog particles everywhere absorb more light.
		/// </summary>
		public float ExtinctionScale
		{
			get => E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the scattering phase function - how much incoming light scatters in various directions.
		/// <para>A distribution value of 0 scatters equally in all directions, while .9 scatters predominantly in the light direction. </para>
		/// In order to have visible volumetric fog light shafts from the side, the distribution will need to be closer to 0.
		/// </summary>
		public float ScatteringDistribution
		{
			get => E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_SET(NativePointer, value);
		}

		public float StaticLightingScatteringIntensity
		{
			get => E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_GET(NativePointer);
			set => E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected void AddFogIfNeeded()
			=> E_UExponentialHeightFogComponent_AddFogIfNeeded(this);
		
		public void SetDirectionalInscatteringColor(FLinearColor value)
			=> E_UExponentialHeightFogComponent_SetDirectionalInscatteringColor(this, value);
		
		public void SetDirectionalInscatteringExponent(float value)
			=> E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(this, value);
		
		public void SetDirectionalInscatteringStartDistance(float value)
			=> E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(this, value);
		
		public void SetFogCutoffDistance(float value)
			=> E_UExponentialHeightFogComponent_SetFogCutoffDistance(this, value);
		
		public void SetFogDensity(float value)
			=> E_UExponentialHeightFogComponent_SetFogDensity(this, value);
		
		public void SetFogHeightFalloff(float value)
			=> E_UExponentialHeightFogComponent_SetFogHeightFalloff(this, value);
		
		public void SetFogInscatteringColor(FLinearColor value)
			=> E_UExponentialHeightFogComponent_SetFogInscatteringColor(this, value);
		
		public void SetFogMaxOpacity(float value)
			=> E_UExponentialHeightFogComponent_SetFogMaxOpacity(this, value);
		
		public void SetFullyDirectionalInscatteringColorDistance(float value)
			=> E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(this, value);
		
		public void SetInscatteringColorCubemapAngle(float value)
			=> E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(this, value);
		
		public void SetInscatteringTextureTint(FLinearColor value)
			=> E_UExponentialHeightFogComponent_SetInscatteringTextureTint(this, value);
		
		public void SetNonDirectionalInscatteringColorDistance(float value)
			=> E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(this, value);
		
		public void SetStartDistance(float value)
			=> E_UExponentialHeightFogComponent_SetStartDistance(this, value);
		
		public void SetVolumetricFog(bool bNewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFog(this, bNewValue);
		
		public void SetVolumetricFogDistance(float newValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogDistance(this, newValue);
		
		public void SetVolumetricFogEmissive(FLinearColor newValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogEmissive(this, newValue);
		
		public void SetVolumetricFogExtinctionScale(float newValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(this, newValue);
		
		public void SetVolumetricFogScatteringDistribution(float newValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(this, newValue);
		
		#endregion
		
		public static implicit operator IntPtr(UExponentialHeightFogComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UExponentialHeightFogComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UExponentialHeightFogComponent>(PtrDesc);
		}}}
