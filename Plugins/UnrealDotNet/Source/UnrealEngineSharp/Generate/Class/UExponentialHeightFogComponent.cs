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
		
		
		/// <summary>
		/// <para>Whether to use FogInscatteringColor for the Sky Light volumetric scattering color and DirectionalInscatteringColor for the Directional Light scattering color. </para>
		/// <para>Make sure your directional light has 'Atmosphere Sun Light' enabled! </para>
		/// <para>Enabling this allows Volumetric fog to better match Height fog in the distance, but produces non-physical volumetric lighting that may not match surface lighting. </para>
		/// </summary>
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
