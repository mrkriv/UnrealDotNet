using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1602

namespace UnrealEngine
{
	public  partial class FLightmassPrimitiveSettings : NativeStructWrapper
	{
		internal FLightmassPrimitiveSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassPrimitiveSettings() :
			base(E_CreateStruct_FLightmassPrimitiveSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassPrimitiveSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Scales the diffuse contribution of all materials applied to this object. </para>
		/// </summary>
		public float DiffuseBoost
		{
			get => E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_GET(NativePointer);
			set => E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scales the emissive contribution of all materials applied to this object. </para>
		/// </summary>
		public float EmissiveBoost
		{
			get => E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_GET(NativePointer);
			set => E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_SET(NativePointer, value);
		}

		public float EmissiveLightExplicitInfluenceRadius
		{
			get => E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_GET(NativePointer);
			set => E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_SET(NativePointer, value);
		}

		public float EmissiveLightFalloffExponent
		{
			get => E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_GET(NativePointer);
			set => E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Fraction of samples taken that must be occluded in order to reach full occlusion. </para>
		/// </summary>
		public float FullyOccludedSamplesFraction
		{
			get => E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_GET(NativePointer);
			set => E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassPrimitiveSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassPrimitiveSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassPrimitiveSettings(Adress, false);
		}}}
