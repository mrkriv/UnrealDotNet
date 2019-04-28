// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

namespace UnrealEngine
{
	public  partial class ULightComponentBase : USceneComponent
	{
		public ULightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULightComponentBase(UObject Parent = null, string Name = "LightComponentBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightComponentBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponentBase_Brightness_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponentBase_Brightness_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponentBase_IndirectLightingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponentBase_IndirectLightingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponentBase_Intensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponentBase_Intensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ULightComponentBase_SamplesPerPixel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponentBase_SamplesPerPixel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULightComponentBase_VolumetricScatteringIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightComponentBase_VolumetricScatteringIntensity_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightComponentBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ULightComponentBase_GetLightColor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponentBase_HasStaticLighting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponentBase_HasStaticShadowing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULightComponentBase_IsMovable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_SetAffectReflection(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_SetCastRaytracedShadow(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_SetCastShadows(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_SetCastVolumetricShadow(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_SetSamplesPerPixel(IntPtr self, int newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_UpdateLightGUIDs(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULightComponentBase_ValidateLightGUIDs(IntPtr self);
		
		#endregion
		
		#region Property
		public float Brightness_DEPRECATED
		{
			get => E_PROP_ULightComponentBase_Brightness_DEPRECATED_GET(NativePointer);
			set => E_PROP_ULightComponentBase_Brightness_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scales the indirect lighting contribution from this light. </para>
		/// <para>A value of 0 disables any GI from this light. Default is 1. </para>
		/// </summary>
		public float IndirectLightingIntensity
		{
			get => E_PROP_ULightComponentBase_IndirectLightingIntensity_GET(NativePointer);
			set => E_PROP_ULightComponentBase_IndirectLightingIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Total energy that the light emits. </para>
		/// </summary>
		public float Intensity
		{
			get => E_PROP_ULightComponentBase_Intensity_GET(NativePointer);
			set => E_PROP_ULightComponentBase_Intensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Samples per pixel for ray tracing </para>
		/// </summary>
		public int SamplesPerPixel
		{
			get => E_PROP_ULightComponentBase_SamplesPerPixel_GET(NativePointer);
			set => E_PROP_ULightComponentBase_SamplesPerPixel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Intensity of the volumetric scattering from this light.  This scales Intensity and LightColor. </para>
		/// </summary>
		public float VolumetricScatteringIntensity
		{
			get => E_PROP_ULightComponentBase_VolumetricScatteringIntensity_GET(NativePointer);
			set => E_PROP_ULightComponentBase_VolumetricScatteringIntensity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Gets the light color as a linear color </para>
		/// </summary>
		public FLinearColor GetLightColor()
			=> E_ULightComponentBase_GetLightColor(this);
		
		
		/// <summary>
		/// <para>Return True if a light's parameters as well as its position is static during gameplay, and can thus use static lighting. </para>
		/// <para>A light with HasStaticLighting() == true will always have HasStaticShadowing() == true as well. </para>
		/// </summary>
		public bool HasStaticLighting()
			=> E_ULightComponentBase_HasStaticLighting(this);
		
		
		/// <summary>
		/// <para>Whether the light has static direct shadowing. </para>
		/// <para>The light may still have dynamic brightness and color. </para>
		/// <para>The light may or may not also have static lighting. </para>
		/// </summary>
		public bool HasStaticShadowing()
			=> E_ULightComponentBase_HasStaticShadowing(this);
		
		
		/// <summary>
		/// <para>Returns true if the light's Mobility is set to Movable </para>
		/// </summary>
		public bool IsMovable()
			=> E_ULightComponentBase_IsMovable(this);
		
		public void SetAffectReflection(bool bNewValue)
			=> E_ULightComponentBase_SetAffectReflection(this, bNewValue);
		
		public void SetCastRaytracedShadow(bool bNewValue)
			=> E_ULightComponentBase_SetCastRaytracedShadow(this, bNewValue);
		
		
		/// <summary>
		/// <para>Sets whether this light casts shadows </para>
		/// </summary>
		public void SetCastShadows(bool bNewValue)
			=> E_ULightComponentBase_SetCastShadows(this, bNewValue);
		
		public void SetCastVolumetricShadow(bool bNewValue)
			=> E_ULightComponentBase_SetCastVolumetricShadow(this, bNewValue);
		
		public void SetSamplesPerPixel(int newValue)
			=> E_ULightComponentBase_SetSamplesPerPixel(this, newValue);
		
		
		/// <summary>
		/// <para>Update/reset light GUIDs. </para>
		/// </summary>
		public virtual void UpdateLightGUIDs()
			=> E_ULightComponentBase_UpdateLightGUIDs(this);
		
		
		/// <summary>
		/// <para>Validate light GUIDs and resets as appropriate. </para>
		/// </summary>
		public void ValidateLightGUIDs()
			=> E_ULightComponentBase_ValidateLightGUIDs(this);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponentBase self)
		{
			return self.NativePointer;
		}

		public static implicit operator ULightComponentBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightComponentBase>(PtrDesc);
		}}}
