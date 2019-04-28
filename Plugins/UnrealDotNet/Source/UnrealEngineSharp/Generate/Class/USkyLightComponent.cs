// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:96

namespace UnrealEngine
{
	public  partial class USkyLightComponent : ULightComponentBase
	{
		public USkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkyLightComponent(UObject Parent = null, string Name = "SkyLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkyLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USkyLightComponent_bCaptureEmissiveOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_bCaptureEmissiveOnly_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_Contrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_Contrast_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkyLightComponent_CubemapResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_CubemapResolution_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USkyLightComponent_LowerHemisphereColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_LowerHemisphereColor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_MinOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_MinOcclusion_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_OcclusionExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_OcclusionExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_OcclusionMaxDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_OcclusionMaxDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_SkyDistanceThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_SkyDistanceThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkyLightComponent_SourceCubemapAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkyLightComponent_SourceCubemapAngle_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkyLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkyLightComponent_IsOcclusionSupported(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_RecaptureSky(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SanitizeCubemapSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetCaptureIsDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetIndirectLightingIntensity(IntPtr self, float newIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetIntensity(IntPtr self, float newIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetLightColor(IntPtr self, IntPtr newLightColor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetLowerHemisphereColor(IntPtr self, IntPtr inLowerHemisphereColor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetMinOcclusion(IntPtr self, float inMinOcclusion);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetOcclusionContrast(IntPtr self, float inOcclusionContrast);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetOcclusionExponent(IntPtr self, float inOcclusionExponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetVolumetricScatteringIntensity(IntPtr self, float newIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateLimitedRenderingStateFast(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateOcclusionRenderingStateFast(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateSkyCaptureContents(IntPtr self, IntPtr worldToUpdate);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Only capture emissive materials. Skips all lighting making the capture cheaper. Recomended when using CaptureEveryFrame
		/// </summary>
		public bool bCaptureEmissiveOnly
		{
			get => E_PROP_USkyLightComponent_bCaptureEmissiveOnly_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bCaptureEmissiveOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether all distant lighting from the lower hemisphere should be set to LowerHemisphereColor.
		/// <para>Enabling this is accurate when lighting a scene on a planet where the ground blocks the sky, </para>
		/// However disabling it can be useful to approximate skylight bounce lighting (eg Movable light).
		/// </summary>
		public bool LowerHemisphereIsSolidColor
		{
			get => E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Contrast S-curve applied to the computed AO.  A value of 0 means no contrast increase, 1 is a significant contrast increase.
		/// </summary>
		public float OcclusionContrast
		{
			get => E_PROP_USkyLightComponent_Contrast_GET(NativePointer);
			set => E_PROP_USkyLightComponent_Contrast_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum resolution for the very top processed cubemap mip. Must be a power of 2.
		/// </summary>
		public int CubemapResolution
		{
			get => E_PROP_USkyLightComponent_CubemapResolution_GET(NativePointer);
			set => E_PROP_USkyLightComponent_CubemapResolution_SET(NativePointer, value);
		}

		public FLinearColor LowerHemisphereColor
		{
			get => E_PROP_USkyLightComponent_LowerHemisphereColor_GET(NativePointer);
			set => E_PROP_USkyLightComponent_LowerHemisphereColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the darkest that a fully occluded area can get.  This tends to destroy contact shadows, use Contrast or OcclusionExponent instead.
		/// </summary>
		public float MinOcclusion
		{
			get => E_PROP_USkyLightComponent_MinOcclusion_GET(NativePointer);
			set => E_PROP_USkyLightComponent_MinOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Exponent applied to the computed AO.  Values lower than 1 brighten occlusion overall without losing contact shadows.
		/// </summary>
		public float OcclusionExponent
		{
			get => E_PROP_USkyLightComponent_OcclusionExponent_GET(NativePointer);
			set => E_PROP_USkyLightComponent_OcclusionExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance that the occlusion of one point will affect another.
		/// <para>Higher values increase the cost of Distance Field AO exponentially. </para>
		/// </summary>
		public float OcclusionMaxDistance
		{
			get => E_PROP_USkyLightComponent_OcclusionMaxDistance_GET(NativePointer);
			set => E_PROP_USkyLightComponent_OcclusionMaxDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance from the sky light at which any geometry should be treated as part of the sky.
		/// <para>This is also used by reflection captures, so update reflection captures to see the impact. </para>
		/// </summary>
		public float SkyDistanceThreshold
		{
			get => E_PROP_USkyLightComponent_SkyDistanceThreshold_GET(NativePointer);
			set => E_PROP_USkyLightComponent_SkyDistanceThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.
		/// </summary>
		public float SourceCubemapAngle
		{
			get => E_PROP_USkyLightComponent_SourceCubemapAngle_GET(NativePointer);
			set => E_PROP_USkyLightComponent_SourceCubemapAngle_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Whether sky occlusion is supported by current feature level
		/// </summary>
		public bool IsOcclusionSupported()
			=> E_USkyLightComponent_IsOcclusionSupported(this);
		
		
		/// <summary>
		/// Recaptures the scene for the skylight.
		/// <para>This is useful for making sure the sky light is up to date after changing something in the world that it would capture. </para>
		/// Warning: this is very costly and will definitely cause a hitch.
		/// </summary>
		public void RecaptureSky()
			=> E_USkyLightComponent_RecaptureSky(this);
		
		public void SanitizeCubemapSize()
			=> E_USkyLightComponent_SanitizeCubemapSize(this);
		
		public void SetBlendDestinationCaptureIsDirty()
			=> E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(this);
		
		
		/// <summary>
		/// Indicates that the capture needs to recapture the scene, adds it to the recapture queue.
		/// </summary>
		public void SetCaptureIsDirty()
			=> E_USkyLightComponent_SetCaptureIsDirty(this);
		
		public void SetIndirectLightingIntensity(float newIntensity)
			=> E_USkyLightComponent_SetIndirectLightingIntensity(this, newIntensity);
		
		public void SetIntensity(float newIntensity)
			=> E_USkyLightComponent_SetIntensity(this, newIntensity);
		
		
		/// <summary>
		/// Set color of the light
		/// </summary>
		public void SetLightColor(FLinearColor newLightColor)
			=> E_USkyLightComponent_SetLightColor(this, newLightColor);
		
		public void SetLowerHemisphereColor(FLinearColor inLowerHemisphereColor)
			=> E_USkyLightComponent_SetLowerHemisphereColor(this, inLowerHemisphereColor);
		
		public void SetMinOcclusion(float inMinOcclusion)
			=> E_USkyLightComponent_SetMinOcclusion(this, inMinOcclusion);
		
		public void SetOcclusionContrast(float inOcclusionContrast)
			=> E_USkyLightComponent_SetOcclusionContrast(this, inOcclusionContrast);
		
		public void SetOcclusionExponent(float inOcclusionExponent)
			=> E_USkyLightComponent_SetOcclusionExponent(this, inOcclusionExponent);
		
		public void SetVolumetricScatteringIntensity(float newIntensity)
			=> E_USkyLightComponent_SetVolumetricScatteringIntensity(this, newIntensity);
		
		protected void UpdateLimitedRenderingStateFast()
			=> E_USkyLightComponent_UpdateLimitedRenderingStateFast(this);
		
		protected void UpdateOcclusionRenderingStateFast()
			=> E_USkyLightComponent_UpdateOcclusionRenderingStateFast(this);
		
		
		/// <summary>
		/// Called each tick to recapture and queued sky captures.
		/// </summary>
		public void UpdateSkyCaptureContents(UWorld worldToUpdate)
			=> E_USkyLightComponent_UpdateSkyCaptureContents(this, worldToUpdate);
		
		#endregion
		
		public static implicit operator IntPtr(USkyLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USkyLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkyLightComponent>(PtrDesc);
		}}}
