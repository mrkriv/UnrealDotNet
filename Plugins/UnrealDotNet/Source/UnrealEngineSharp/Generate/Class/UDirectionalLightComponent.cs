// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

namespace UnrealEngine
{
	public partial class UDirectionalLightComponent : ULightComponent
	{
		public UDirectionalLightComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UDirectionalLightComponent(UObject Parent = null, string Name = "DirectionalLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDirectionalLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UDirectionalLightComponent_DynamicShadowCascades_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_DynamicShadowCascades_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_FarShadowDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_FarShadowDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UDirectionalLightComponent_LightmassSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_LightmassSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_LightSourceAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_LightSourceAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_OcclusionDepthRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_OcclusionDepthRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_TraceDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_TraceDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDirectionalLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetCascadeDistributionExponent(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetCascadeTransitionFraction(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetDynamicShadowCascades(IntPtr self, int newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetDynamicShadowDistanceMovableLight(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetDynamicShadowDistanceStationaryLight(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetEnableLightShaftOcclusion(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetLightShaftOverrideDirection(IntPtr self, IntPtr newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetOcclusionMaskDarkness(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDirectionalLightComponent_SetShadowDistanceFadeoutFraction(IntPtr self, float newValue);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Controls whether the cascades are distributed closer to the camera (larger exponent) or further from the camera (smaller exponent).
		/// <para>An exponent of 1 means that cascade transitions will happen at a distance proportional to their resolution. </para>
		/// </summary>
		public float DistributionExponent
		{
			get => E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Proportion of the fade region between cascades.
		/// <para>Pixels within the fade region of two cascades have their shadows blended to avoid hard transitions between quality levels. </para>
		/// A value of zero eliminates the fade region, creating hard transitions.
		/// <para>Higher values increase the size of the fade region, creating a more gradual transition between cascades. </para>
		/// The value is expressed as a percentage proportion (i.e. 0.1 = 10% overlap).
		/// <para>Ideal values are the smallest possible which still hide the transition. </para>
		/// An increased fade region size causes an increase in shadow rendering cost.
		/// </summary>
		public float TransitionFraction
		{
			get => E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance at which the ray traced shadow cascade should end.  Distance field shadows will cover the range between 'Dynamic Shadow Distance' this distance.
		/// </summary>
		public float DistanceFieldShadowDistance
		{
			get => E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of cascades to split the view frustum into for the whole scene dynamic shadow.
		/// <para>More cascades result in better shadow resolution, but adds significant rendering cost. </para>
		/// </summary>
		public int NumDynamicShadowCascades
		{
			get => E_PROP_UDirectionalLightComponent_DynamicShadowCascades_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_DynamicShadowCascades_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a movable light, measured from the camera.
		/// <para>A value of 0 disables the dynamic shadow. </para>
		/// </summary>
		public float DynamicShadowDistanceMovableLight
		{
			get => E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a stationary light, measured from the camera.
		/// <para>A value of 0 disables the dynamic shadow. </para>
		/// </summary>
		public float DynamicShadowDistanceStationaryLight
		{
			get => E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0: no DistantShadowCascades, otherwise the count of cascades between WholeSceneDynamicShadowRadius and DistantShadowDistance that are covered by distant shadow cascades.
		/// </summary>
		public int FarShadowCascadeCount
		{
			get => E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance at which the far shadow cascade should end.  Far shadows will cover the range between 'Dynamic Shadow Distance' and this distance.
		/// </summary>
		public float FarShadowDistance
		{
			get => E_PROP_UDirectionalLightComponent_FarShadowDistance_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_FarShadowDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The Lightmass settings for this object.
		/// </summary>
		public FLightmassDirectionalLightSettings LightmassSettings
		{
			get => E_PROP_UDirectionalLightComponent_LightmassSettings_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_LightmassSettings_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Can be used to make light shafts come from somewhere other than the light's actual direction.
		/// <para>This will only be used when non-zero.  It does not have to be normalized. </para>
		/// </summary>
		public FVector LightShaftOverrideDirection
		{
			get => E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Angle subtended by light source in degrees (also known as angular diameter).
		/// <para>Defaults to 0.5357 which is the angle for our sun. </para>
		/// </summary>
		public float SourceAngle
		{
			get => E_PROP_UDirectionalLightComponent_LightSourceAngle_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_LightSourceAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Angle subtended by soft light source in degrees.
		/// </summary>
		public float SourceSoftAngle
		{
			get => E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Everything closer to the camera than this distance will occlude light shafts.
		/// </summary>
		public float OcclusionDepthRange
		{
			get => E_PROP_UDirectionalLightComponent_OcclusionDepthRange_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_OcclusionDepthRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls how dark the occlusion masking is, a value of 1 results in no darkening term.
		/// </summary>
		public float OcclusionMaskDarkness
		{
			get => E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the size of the fade out region at the far extent of the dynamic shadow's influence.
		/// <para>This is specified as a fraction of DynamicShadowDistance. </para>
		/// </summary>
		public float DistanceFadeoutFraction
		{
			get => E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Determines how far shadows can be cast, in world units.  Larger values increase the shadowing cost.
		/// </summary>
		public float DistanceFieldTraceDistance
		{
			get => E_PROP_UDirectionalLightComponent_TraceDistance_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_TraceDistance_SET(NativePointer, value);
		}

		public float WholeSceneDynamicShadowRadius_DEPRECATED
		{
			get => E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_GET(NativePointer);
			set => E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void SetCascadeDistributionExponent(float newValue)
			=> E_UDirectionalLightComponent_SetCascadeDistributionExponent(this, newValue);
		
		public void SetCascadeTransitionFraction(float newValue)
			=> E_UDirectionalLightComponent_SetCascadeTransitionFraction(this, newValue);
		
		public void SetDynamicShadowCascades(int newValue)
			=> E_UDirectionalLightComponent_SetDynamicShadowCascades(this, newValue);
		
		public void SetDynamicShadowDistanceMovableLight(float newValue)
			=> E_UDirectionalLightComponent_SetDynamicShadowDistanceMovableLight(this, newValue);
		
		public void SetDynamicShadowDistanceStationaryLight(float newValue)
			=> E_UDirectionalLightComponent_SetDynamicShadowDistanceStationaryLight(this, newValue);
		
		public void SetEnableLightShaftOcclusion(bool bNewValue)
			=> E_UDirectionalLightComponent_SetEnableLightShaftOcclusion(this, bNewValue);
		
		public void SetLightShaftOverrideDirection(FVector newValue)
			=> E_UDirectionalLightComponent_SetLightShaftOverrideDirection(this, newValue);
		
		public void SetOcclusionMaskDarkness(float newValue)
			=> E_UDirectionalLightComponent_SetOcclusionMaskDarkness(this, newValue);
		
		public void SetShadowDistanceFadeoutFraction(float newValue)
			=> E_UDirectionalLightComponent_SetShadowDistanceFadeoutFraction(this, newValue);
		
		#endregion
		
		public static implicit operator IntPtr(UDirectionalLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UDirectionalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDirectionalLightComponent>(PtrDesc);
		}}}
