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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponent_AffectsPrimitive(IntPtr self, IntPtr primitive);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetBoundingBox(IntPtr self);
		
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
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Test whether this light affects the given primitive.  This checks both the primitive and light settings for light relevance </para>
		/// <para>and also calls AffectsBounds. </para>
		/// <param name="PrimitiveSceneInfo">The primitive to test. </param>
		/// <return>True if the light affects the primitive. </return>
		/// </summary>
		public bool AffectsPrimitive(UPrimitiveComponent primitive)
			=> E_ULightComponent_AffectsPrimitive(this, primitive);
		
		
		/// <summary>
		/// <para>Return the world-space bounding box of the light's influence. </para>
		/// </summary>
		public virtual FBox GetBoundingBox()
			=> E_ULightComponent_GetBoundingBox(this);
		
		
		/// <summary>
		/// <para>Return the homogenous position of the light. </para>
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
		/// <para>Set intensity of the light </para>
		/// </summary>
		public void SetIntensity(float newIntensity)
			=> E_ULightComponent_SetIntensity(this, newIntensity);
		
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
