using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ExponentialHeightFogComponent.h:15

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UExponentialHeightFogComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_AddFogIfNeeded(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogCutoffDistance(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogDensity(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogHeightFalloff(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFogMaxOpacity(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetStartDistance(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFog(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogDistance(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(IntPtr Self, float NewValue);
		
		#endregion
		
		#region ExternMethods
		protected void AddFogIfNeeded()
			=> E_UExponentialHeightFogComponent_AddFogIfNeeded(this);
		
		public void SetDirectionalInscatteringExponent(float Value)
			=> E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(this, Value);
		
		public void SetDirectionalInscatteringStartDistance(float Value)
			=> E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(this, Value);
		
		public void SetFogCutoffDistance(float Value)
			=> E_UExponentialHeightFogComponent_SetFogCutoffDistance(this, Value);
		
		
		/// <summary>
		/// <para>Whether to use FogInscatteringColor for the Sky Light volumetric scattering color and DirectionalInscatteringColor for the Directional Light scattering color. </para>
		/// <para>Make sure your directional light has 'Atmosphere Sun Light' enabled! </para>
		/// <para>Enabling this allows Volumetric fog to better match Height fog in the distance, but produces non-physical volumetric lighting that may not match surface lighting. </para>
		/// </summary>
		public void SetFogDensity(float Value)
			=> E_UExponentialHeightFogComponent_SetFogDensity(this, Value);
		
		public void SetFogHeightFalloff(float Value)
			=> E_UExponentialHeightFogComponent_SetFogHeightFalloff(this, Value);
		
		public void SetFogMaxOpacity(float Value)
			=> E_UExponentialHeightFogComponent_SetFogMaxOpacity(this, Value);
		
		public void SetFullyDirectionalInscatteringColorDistance(float Value)
			=> E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(this, Value);
		
		public void SetInscatteringColorCubemapAngle(float Value)
			=> E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(this, Value);
		
		public void SetNonDirectionalInscatteringColorDistance(float Value)
			=> E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(this, Value);
		
		public void SetStartDistance(float Value)
			=> E_UExponentialHeightFogComponent_SetStartDistance(this, Value);
		
		public void SetVolumetricFog(bool bNewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFog(this, bNewValue);
		
		public void SetVolumetricFogDistance(float NewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogDistance(this, NewValue);
		
		public void SetVolumetricFogExtinctionScale(float NewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(this, NewValue);
		
		public void SetVolumetricFogScatteringDistribution(float NewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(this, NewValue);
		
		#endregion
		
		public static implicit operator IntPtr(UExponentialHeightFogComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UExponentialHeightFogComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UExponentialHeightFogComponent>(PtrDesc);
		}}}
