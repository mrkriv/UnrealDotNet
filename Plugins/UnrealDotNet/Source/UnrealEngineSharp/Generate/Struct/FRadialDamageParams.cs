// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2648

namespace UnrealEngine
{
	public partial class FRadialDamageParams : NativeStructWrapper
	{
		public FRadialDamageParams(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FRadialDamageParams() :
			base(E_CreateStruct_FRadialDamageParams(), false)
		{
		}

		public FRadialDamageParams(float inBaseDamage, float inInnerRadius, float inOuterRadius, float inDamageFalloff) :
			base(E_CreateStruct_FRadialDamageParams_float_float_float_float(inBaseDamage, inInnerRadius, inOuterRadius, inDamageFalloff), false)
		{
		}

		public FRadialDamageParams(float inBaseDamage, float inMinimumDamage, float inInnerRadius, float inOuterRadius, float inDamageFalloff) :
			base(E_CreateStruct_FRadialDamageParams_float_float_float_float_float(inBaseDamage, inMinimumDamage, inInnerRadius, inOuterRadius, inDamageFalloff), false)
		{
		}

		public FRadialDamageParams(float inBaseDamage, float inRadius) :
			base(E_CreateStruct_FRadialDamageParams_float_float(inBaseDamage, inRadius), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRadialDamageParams_BaseDamage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageParams_BaseDamage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRadialDamageParams_DamageFalloff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageParams_DamageFalloff_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRadialDamageParams_InnerRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageParams_InnerRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRadialDamageParams_MinimumDamage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageParams_MinimumDamage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRadialDamageParams_OuterRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageParams_OuterRadius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float(float inBaseDamage, float inInnerRadius, float inOuterRadius, float inDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float_float(float inBaseDamage, float inMinimumDamage, float inInnerRadius, float inOuterRadius, float inDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float(float inBaseDamage, float inRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetDamageScale(IntPtr self, float distanceFromEpicenter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetMaxRadius(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Max damage done
		/// </summary>
		public float BaseDamage
		{
			get => E_PROP_FRadialDamageParams_BaseDamage_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_BaseDamage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Describes amount of exponential damage falloff
		/// </summary>
		public float DamageFalloff
		{
			get => E_PROP_FRadialDamageParams_DamageFalloff_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_DamageFalloff_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Within InnerRadius, do max damage
		/// </summary>
		public float InnerRadius
		{
			get => E_PROP_FRadialDamageParams_InnerRadius_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_InnerRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Damage will not fall below this if within range
		/// </summary>
		public float MinimumDamage
		{
			get => E_PROP_FRadialDamageParams_MinimumDamage_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_MinimumDamage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Outside OuterRadius, do no damage
		/// </summary>
		public float OuterRadius
		{
			get => E_PROP_FRadialDamageParams_OuterRadius_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_OuterRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns damage done at a certain distance
		/// </summary>
		public float GetDamageScale(float distanceFromEpicenter)
			=> E_FRadialDamageParams_GetDamageScale(this, distanceFromEpicenter);
		
		
		/// <summary>
		/// Return outermost radius of the damage area. Protects against malformed data.
		/// </summary>
		public float GetMaxRadius()
			=> E_FRadialDamageParams_GetMaxRadius(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRadialDamageParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRadialDamageParams(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRadialDamageParams(adress, false);
		}}}
