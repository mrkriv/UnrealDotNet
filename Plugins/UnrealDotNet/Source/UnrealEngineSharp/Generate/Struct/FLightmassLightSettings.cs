// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1509

namespace UnrealEngine
{
	public  partial class FLightmassLightSettings : NativeStructWrapper
	{
		internal FLightmassLightSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassLightSettings() :
			base(E_CreateStruct_FLightmassLightSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassLightSettings_IndirectLightingSaturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassLightSettings_IndirectLightingSaturation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassLightSettings_ShadowExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassLightSettings_ShadowExponent_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassLightSettings();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Whether to use area shadows for stationary light precomputed shadowmaps. </para>
		/// <para>Area shadows get softer the further they are from shadow casters, but require higher lightmap resolution to get the same quality where the shadow is sharp. </para>
		/// </summary>
		public bool bUseAreaShadowsForStationaryLight
		{
			get => E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_GET(NativePointer);
			set => E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0 will be completely desaturated, 1 will be unchanged </para>
		/// </summary>
		public float IndirectLightingSaturation
		{
			get => E_PROP_FLightmassLightSettings_IndirectLightingSaturation_GET(NativePointer);
			set => E_PROP_FLightmassLightSettings_IndirectLightingSaturation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the falloff of shadow penumbras </para>
		/// </summary>
		public float ShadowExponent
		{
			get => E_PROP_FLightmassLightSettings_ShadowExponent_GET(NativePointer);
			set => E_PROP_FLightmassLightSettings_ShadowExponent_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassLightSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLightmassLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassLightSettings(Adress, false);
		}}}
