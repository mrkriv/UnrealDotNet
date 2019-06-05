// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LocalLightComponent.h:17

namespace UnrealEngine
{
	public partial class ULocalLightComponent : ULightComponent
	{
		public ULocalLightComponent(IntPtr adress)
			: base(adress)
		{
		}

		public ULocalLightComponent(UObject Parent = null, string Name = "LocalLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULocalLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULocalLightComponent_AttenuationRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalLightComponent_AttenuationRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_ULocalLightComponent_IntensityUnits_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalLightComponent_IntensityUnits_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULocalLightComponent_LightmassSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalLightComponent_LightmassSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULocalLightComponent_Radius_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalLightComponent_Radius_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULocalLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ULocalLightComponent_GetUnitsConversionFactor(IntPtr self, byte srcUnits, byte targetUnits);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalLightComponent_SetAttenuationRadius(IntPtr self, float newRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalLightComponent_SetIntensityUnits(IntPtr self, byte newIntensityUnits);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Bounds the light's visible influence.
		/// <para>This clamping of the light's influence is not physically correct but very important for performance, larger lights cost more. </para>
		/// </summary>
		public float AttenuationRadius
		{
			get => E_PROP_ULocalLightComponent_AttenuationRadius_GET(NativePointer);
			set => E_PROP_ULocalLightComponent_AttenuationRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Units used for the intensity.
		/// <para>The peak luminous intensity is measured in candelas, </para>
		/// while the luminous power is measured in lumens.
		/// </summary>
		public ELightUnits IntensityUnits
		{
			get => (ELightUnits)E_PROP_ULocalLightComponent_IntensityUnits_GET(NativePointer);
			set => E_PROP_ULocalLightComponent_IntensityUnits_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// The Lightmass settings for this object.
		/// </summary>
		public FLightmassPointLightSettings LightmassSettings
		{
			get => E_PROP_ULocalLightComponent_LightmassSettings_GET(NativePointer);
			set => E_PROP_ULocalLightComponent_LightmassSettings_SET(NativePointer, value);
		}

		public float Radius_DEPRECATED
		{
			get => E_PROP_ULocalLightComponent_Radius_DEPRECATED_GET(NativePointer);
			set => E_PROP_ULocalLightComponent_Radius_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetUnitsConversionFactor(ELightUnits srcUnits, ELightUnits targetUnits)
			=> E_ULocalLightComponent_GetUnitsConversionFactor(this, (byte)srcUnits, (byte)targetUnits);
		
		public void SetAttenuationRadius(float newRadius)
			=> E_ULocalLightComponent_SetAttenuationRadius(this, newRadius);
		
		
		/// <summary>
		/// Set the units used for the intensity of the light
		/// </summary>
		public void SetIntensityUnits(ELightUnits newIntensityUnits)
			=> E_ULocalLightComponent_SetIntensityUnits(this, (byte)newIntensityUnits);
		
		#endregion
		
		public static implicit operator IntPtr(ULocalLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ULocalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULocalLightComponent>(PtrDesc);
		}}}
