// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

namespace UnrealEngine
{
	public partial class UPointLightComponent : ULocalLightComponent
	{
		public UPointLightComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UPointLightComponent(UObject Parent = null, string Name = "PointLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPointLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPointLightComponent_LightFalloffExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPointLightComponent_LightFalloffExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPointLightComponent_SoftSourceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPointLightComponent_SoftSourceRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPointLightComponent_SourceLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPointLightComponent_SourceLength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPointLightComponent_SourceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPointLightComponent_SourceRadius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPointLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPointLightComponent_SetLightFalloffExponent(IntPtr self, float newLightFalloffExponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPointLightComponent_SetSoftSourceRadius(IntPtr self, float bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPointLightComponent_SetSourceLength(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPointLightComponent_SetSourceRadius(IntPtr self, float bNewValue);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Controls the radial falloff of the light when UseInverseSquaredFalloff is disabled.
		/// <para>2 is almost linear and very unrealistic and around 8 it looks reasonable. </para>
		/// With large exponents, the light has contribution to only a small area of its influence radius but still costs the same as low exponents.
		/// </summary>
		public float LightFalloffExponent
		{
			get => E_PROP_UPointLightComponent_LightFalloffExponent_GET(NativePointer);
			set => E_PROP_UPointLightComponent_LightFalloffExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Soft radius of light source shape.
		/// <para>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts. </para>
		/// </summary>
		public float SoftSourceRadius
		{
			get => E_PROP_UPointLightComponent_SoftSourceRadius_GET(NativePointer);
			set => E_PROP_UPointLightComponent_SoftSourceRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Length of light source shape.
		/// <para>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts. </para>
		/// </summary>
		public float SourceLength
		{
			get => E_PROP_UPointLightComponent_SourceLength_GET(NativePointer);
			set => E_PROP_UPointLightComponent_SourceLength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Radius of light source shape.
		/// <para>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts. </para>
		/// </summary>
		public float SourceRadius
		{
			get => E_PROP_UPointLightComponent_SourceRadius_GET(NativePointer);
			set => E_PROP_UPointLightComponent_SourceRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void SetLightFalloffExponent(float newLightFalloffExponent)
			=> E_UPointLightComponent_SetLightFalloffExponent(this, newLightFalloffExponent);
		
		public void SetSoftSourceRadius(float bNewValue)
			=> E_UPointLightComponent_SetSoftSourceRadius(this, bNewValue);
		
		public void SetSourceLength(float newValue)
			=> E_UPointLightComponent_SetSourceLength(this, newValue);
		
		public void SetSourceRadius(float bNewValue)
			=> E_UPointLightComponent_SetSourceRadius(this, bNewValue);
		
		#endregion
		
		public static implicit operator IntPtr(UPointLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPointLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPointLightComponent>(PtrDesc);
		}}}
