// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:50

namespace UnrealEngine
{
	public  partial class FLightmassWorldInfoSettings : NativeStructWrapper
	{
		internal FLightmassWorldInfoSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassWorldInfoSettings() :
			base(E_CreateStruct_FLightmassWorldInfoSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightmassWorldInfoSettings_bCompressLightmaps_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_bCompressLightmaps_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightmassWorldInfoSettings_bGenerateAmbientOcclusionMaterialMask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_bGenerateAmbientOcclusionMaterialMask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightmassWorldInfoSettings_bUseAmbientOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_bUseAmbientOcclusion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightmassWorldInfoSettings_bVisualizeAmbientOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_bVisualizeAmbientOcclusion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightmassWorldInfoSettings_bVisualizeMaterialDiffuse_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_bVisualizeMaterialDiffuse_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_DiffuseBoost_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_DiffuseBoost_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_DirectIlluminationOcclusionFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_DirectIlluminationOcclusionFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_EmissiveBoost_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_EmissiveBoost_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_EnvironmentIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_EnvironmentIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_FullyOccludedSamplesFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_FullyOccludedSamplesFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_IndirectIlluminationOcclusionFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_IndirectIlluminationOcclusionFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_IndirectLightingQuality_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_IndirectLightingQuality_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_IndirectLightingSmoothness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_IndirectLightingSmoothness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_MaxOcclusionDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_MaxOcclusionDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FLightmassWorldInfoSettings_NumIndirectLightingBounces_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_NumIndirectLightingBounces_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FLightmassWorldInfoSettings_NumSkyLightingBounces_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_NumSkyLightingBounces_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_OcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_OcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_StaticLightingLevelScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_StaticLightingLevelScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_VolumeLightSamplePlacementScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_VolumeLightSamplePlacementScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapDetailCellSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapDetailCellSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapMaximumBrickMemoryMb_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapMaximumBrickMemoryMb_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapSphericalHarmonicSmoothing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapSphericalHarmonicSmoothing_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassWorldInfoSettings();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether to compress lightmap textures.  Disabling lightmap texture compression will reduce artifacts but increase memory and disk size by 4x.
		/// <para>Use caution when disabling this. </para>
		/// </summary>
		public byte bCompressLightmaps
		{
			get => E_PROP_FLightmassWorldInfoSettings_bCompressLightmaps_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_bCompressLightmaps_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to generate textures storing the AO computed by Lightmass.
		/// <para>These can be accessed through the PrecomputedAOMask material node, </para>
		/// Which is useful for blending between material layers on environment assets.
		/// <para>Be sure to set DirectIlluminationOcclusionFraction and IndirectIlluminationOcclusionFraction to 0 if you only want the PrecomputedAOMask! </para>
		/// </summary>
		public byte bGenerateAmbientOcclusionMaterialMask
		{
			get => E_PROP_FLightmassWorldInfoSettings_bGenerateAmbientOcclusionMaterialMask_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_bGenerateAmbientOcclusionMaterialMask_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, AmbientOcclusion will be enabled.
		/// </summary>
		public byte bUseAmbientOcclusion
		{
			get => E_PROP_FLightmassWorldInfoSettings_bUseAmbientOcclusion_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_bUseAmbientOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, override normal direct and indirect lighting with just the AO term.
		/// </summary>
		public byte bVisualizeAmbientOcclusion
		{
			get => E_PROP_FLightmassWorldInfoSettings_bVisualizeAmbientOcclusion_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_bVisualizeAmbientOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, override normal direct and indirect lighting with just the exported diffuse term.
		/// </summary>
		public byte bVisualizeMaterialDiffuse
		{
			get => E_PROP_FLightmassWorldInfoSettings_bVisualizeMaterialDiffuse_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_bVisualizeMaterialDiffuse_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the diffuse contribution of all materials in the scene.
		/// </summary>
		public float DiffuseBoost
		{
			get => E_PROP_FLightmassWorldInfoSettings_DiffuseBoost_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_DiffuseBoost_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How much of the AO to apply to direct lighting.
		/// </summary>
		public float DirectIlluminationOcclusionFraction
		{
			get => E_PROP_FLightmassWorldInfoSettings_DirectIlluminationOcclusionFraction_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_DirectIlluminationOcclusionFraction_SET(NativePointer, value);
		}

		public float EmissiveBoost
		{
			get => E_PROP_FLightmassWorldInfoSettings_EmissiveBoost_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_EmissiveBoost_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales EnvironmentColor to allow independent color and brightness controls.
		/// </summary>
		public float EnvironmentIntensity
		{
			get => E_PROP_FLightmassWorldInfoSettings_EnvironmentIntensity_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_EnvironmentIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Fraction of samples taken that must be occluded in order to reach full occlusion.
		/// </summary>
		public float FullyOccludedSamplesFraction
		{
			get => E_PROP_FLightmassWorldInfoSettings_FullyOccludedSamplesFraction_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_FullyOccludedSamplesFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How much of the AO to apply to indirect lighting.
		/// </summary>
		public float IndirectIlluminationOcclusionFraction
		{
			get => E_PROP_FLightmassWorldInfoSettings_IndirectIlluminationOcclusionFraction_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_IndirectIlluminationOcclusionFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Warning: Setting this higher than 1 will greatly increase build times!
		/// <para>Can be used to increase the GI solver sample counts in order to get higher quality for levels that need it. </para>
		/// It can be useful to reduce IndirectLightingSmoothness somewhat (~.75) when increasing quality to get defined indirect shadows.
		/// <para>Note that this can't affect compression artifacts, UV seams or other texture based artifacts. </para>
		/// </summary>
		public float IndirectLightingQuality
		{
			get => E_PROP_FLightmassWorldInfoSettings_IndirectLightingQuality_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_IndirectLightingQuality_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Smoothness factor to apply to indirect lighting.  This is useful in some lighting conditions when Lightmass cannot resolve accurate indirect lighting.
		/// <para>1 is default smoothness tweaked for a variety of lighting situations. </para>
		/// Higher values like 3 smooth out the indirect lighting more, but at the cost of indirect shadows losing detail.
		/// </summary>
		public float IndirectLightingSmoothness
		{
			get => E_PROP_FLightmassWorldInfoSettings_IndirectLightingSmoothness_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_IndirectLightingSmoothness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum distance for an object to cause occlusion on another object.
		/// </summary>
		public float MaxOcclusionDistance
		{
			get => E_PROP_FLightmassWorldInfoSettings_MaxOcclusionDistance_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_MaxOcclusionDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of light bounces to simulate for point / spot / directional lights, starting from the light source.
		/// <para>0 is direct lighting only, 1 is one bounce, etc. </para>
		/// Bounce 1 takes the most time to calculate and contributes the most to visual quality, followed by bounce 2.
		/// <para>Successive bounces don't really affect build times, but have a much lower visual impact, unless the material diffuse colors are close to 1. </para>
		/// </summary>
		public int NumIndirectLightingBounces
		{
			get => E_PROP_FLightmassWorldInfoSettings_NumIndirectLightingBounces_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_NumIndirectLightingBounces_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of skylight and emissive bounces to simulate.
		/// <para>Lightmass uses a non-distributable radiosity method for skylight bounces whose cost is proportional to the number of bounces. </para>
		/// </summary>
		public int NumSkyLightingBounces
		{
			get => E_PROP_FLightmassWorldInfoSettings_NumSkyLightingBounces_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_NumSkyLightingBounces_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Higher exponents increase contrast.
		/// </summary>
		public float OcclusionExponent
		{
			get => E_PROP_FLightmassWorldInfoSettings_OcclusionExponent_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_OcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Warning: Setting this to less than 1 will greatly increase build times!
		/// <para>Scale of the level relative to real world scale (1 Unreal Unit = 1 cm). </para>
		/// All scale-dependent Lightmass setting defaults have been tweaked to work well with real world scale,
		/// <para>Any levels with a different scale should use this scale to compensate. </para>
		/// For large levels it can drastically reduce build times to set this to 2 or 4.
		/// </summary>
		public float StaticLightingLevelScale
		{
			get => E_PROP_FLightmassWorldInfoSettings_StaticLightingLevelScale_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_StaticLightingLevelScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the distances at which volume lighting samples are placed.  Volume lighting samples are computed by Lightmass and are used for GI on movable components.
		/// <para>Using larger scales results in less sample memory usage and reduces Indirect Lighting Cache update times, but less accurate transitions between lighting areas. </para>
		/// </summary>
		public float VolumeLightSamplePlacementScale
		{
			get => E_PROP_FLightmassWorldInfoSettings_VolumeLightSamplePlacementScale_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_VolumeLightSamplePlacementScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Size of an Volumetric Lightmap voxel at the highest density (used around geometry), in world space units.
		/// <para>This setting has a large impact on build times and memory, use with caution. </para>
		/// Halving the DetailCellSize can increase memory by up to a factor of 8x.
		/// </summary>
		public float VolumetricLightmapDetailCellSize
		{
			get => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapDetailCellSize_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapDetailCellSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum amount of memory to spend on Volumetric Lightmap Brick data.  High density bricks will be discarded until this limit is met, with bricks furthest from geometry discarded first.
		/// </summary>
		public float VolumetricLightmapMaximumBrickMemoryMb
		{
			get => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapMaximumBrickMemoryMb_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapMaximumBrickMemoryMb_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls how much smoothing should be done to Volumetric Lightmap samples during Spherical Harmonic de-ringing.
		/// <para>Whenever highly directional lighting is stored in a Spherical Harmonic, a ringing artifact occurs which manifests as unexpected black areas on the opposite side. </para>
		/// Smoothing can reduce this artifact.  Smoothing is only applied when the ringing artifact is present.
		/// <para>0 = no smoothing, 1 = strong smooth (little directionality in lighting). </para>
		/// </summary>
		public float VolumetricLightmapSphericalHarmonicSmoothing
		{
			get => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapSphericalHarmonicSmoothing_GET(NativePointer);
			set => E_PROP_FLightmassWorldInfoSettings_VolumetricLightmapSphericalHarmonicSmoothing_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassWorldInfoSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLightmassWorldInfoSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassWorldInfoSettings(Adress, false);
		}}}
