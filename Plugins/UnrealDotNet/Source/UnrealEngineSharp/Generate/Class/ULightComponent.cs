using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

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
		private static extern bool E_ULightComponent_AffectsPrimitive(IntPtr Self, IntPtr Primitive);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetBoundingBox(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponent_GetLightPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetAffectDynamicIndirectLighting(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetAffectTranslucentLighting(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetBloomScale(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetBloomThreshold(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetEnableLightShaftBloom(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetIndirectLightingIntensity(IntPtr Self, float NewIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetIntensity(IntPtr Self, float NewIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionDisabledBrightness(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionFadeDistance(IntPtr Self, float NewLightFunctionFadeDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetLightFunctionScale(IntPtr Self, IntPtr NewLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetShadowBias(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetTemperature(IntPtr Self, float NewTemperature);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetTransmission(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponent_SetVolumetricScatteringIntensity(IntPtr Self, float NewIntensity);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Test whether this light affects the given primitive.  This checks both the primitive and light settings for light relevance </para>
		/// <para>and also calls AffectsBounds. </para>
		/// <param name="PrimitiveSceneInfo">The primitive to test. </param>
		/// <return>True if the light affects the primitive. </return>
		/// </summary>
		public bool AffectsPrimitive(UPrimitiveComponent Primitive)
			=> E_ULightComponent_AffectsPrimitive(this, Primitive);
		
		
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
		
		public void SetBloomScale(float NewValue)
			=> E_ULightComponent_SetBloomScale(this, NewValue);
		
		public void SetBloomThreshold(float NewValue)
			=> E_ULightComponent_SetBloomThreshold(this, NewValue);
		
		public void SetEnableLightShaftBloom(bool bNewValue)
			=> E_ULightComponent_SetEnableLightShaftBloom(this, bNewValue);
		
		public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)
			=> E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(this, bNewValue);
		
		public void SetIndirectLightingIntensity(float NewIntensity)
			=> E_ULightComponent_SetIndirectLightingIntensity(this, NewIntensity);
		
		
		/// <summary>
		/// <para>Set intensity of the light </para>
		/// </summary>
		public void SetIntensity(float NewIntensity)
			=> E_ULightComponent_SetIntensity(this, NewIntensity);
		
		public void SetLightFunctionDisabledBrightness(float NewValue)
			=> E_ULightComponent_SetLightFunctionDisabledBrightness(this, NewValue);
		
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
			=> E_ULightComponent_SetLightFunctionFadeDistance(this, NewLightFunctionFadeDistance);
		
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
			=> E_ULightComponent_SetLightFunctionScale(this, NewLightFunctionScale);
		
		public void SetShadowBias(float NewValue)
			=> E_ULightComponent_SetShadowBias(this, NewValue);
		
		public void SetTemperature(float NewTemperature)
			=> E_ULightComponent_SetTemperature(this, NewTemperature);
		
		public void SetTransmission(bool bNewValue)
			=> E_ULightComponent_SetTransmission(this, bNewValue);
		
		public void SetVolumetricScatteringIntensity(float NewIntensity)
			=> E_ULightComponent_SetVolumetricScatteringIntensity(this, NewIntensity);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightComponent>(PtrDesc);
		}}}
