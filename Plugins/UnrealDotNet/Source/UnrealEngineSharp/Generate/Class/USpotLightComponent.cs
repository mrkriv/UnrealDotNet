// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

namespace UnrealEngine
{
	public  partial class USpotLightComponent : UPointLightComponent
	{
		public USpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USpotLightComponent(UObject Parent = null, string Name = "SpotLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USpotLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpotLightComponent_InnerConeAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpotLightComponent_InnerConeAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpotLightComponent_LightShaftConeAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpotLightComponent_LightShaftConeAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpotLightComponent_OuterConeAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpotLightComponent_OuterConeAngle_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpotLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USpotLightComponent_GetCosHalfConeAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USpotLightComponent_GetHalfConeAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USpotLightComponent_SetInnerConeAngle(IntPtr self, float newInnerConeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USpotLightComponent_SetOuterConeAngle(IntPtr self, float newOuterConeAngle);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Degrees.
		/// </summary>
		public float InnerConeAngle
		{
			get => E_PROP_USpotLightComponent_InnerConeAngle_GET(NativePointer);
			set => E_PROP_USpotLightComponent_InnerConeAngle_SET(NativePointer, value);
		}

		public float LightShaftConeAngle
		{
			get => E_PROP_USpotLightComponent_LightShaftConeAngle_GET(NativePointer);
			set => E_PROP_USpotLightComponent_LightShaftConeAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Degrees.
		/// </summary>
		public float OuterConeAngle
		{
			get => E_PROP_USpotLightComponent_OuterConeAngle_GET(NativePointer);
			set => E_PROP_USpotLightComponent_OuterConeAngle_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetCosHalfConeAngle()
			=> E_USpotLightComponent_GetCosHalfConeAngle(this);
		
		public float GetHalfConeAngle()
			=> E_USpotLightComponent_GetHalfConeAngle(this);
		
		public void SetInnerConeAngle(float newInnerConeAngle)
			=> E_USpotLightComponent_SetInnerConeAngle(this, newInnerConeAngle);
		
		public void SetOuterConeAngle(float newOuterConeAngle)
			=> E_USpotLightComponent_SetOuterConeAngle(this, newOuterConeAngle);
		
		#endregion
		
		public static implicit operator IntPtr(USpotLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpotLightComponent>(PtrDesc);
		}}}
