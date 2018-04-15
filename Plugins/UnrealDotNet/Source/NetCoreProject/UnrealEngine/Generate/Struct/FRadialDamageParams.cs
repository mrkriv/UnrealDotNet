using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2650

namespace UnrealEngine
{
	public  partial class FRadialDamageParams : NativeStructWrapper
	{
		internal FRadialDamageParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRadialDamageParams() :
			base(E_CreateStruct_FRadialDamageParams(), false)
		{
		}

		public FRadialDamageParams(float InBaseDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) :
			base(E_CreateStruct_FRadialDamageParams_float_float_float_float(InBaseDamage, InInnerRadius, InOuterRadius, InDamageFalloff), false)
		{
		}

		public FRadialDamageParams(float InBaseDamage, float InMinimumDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) :
			base(E_CreateStruct_FRadialDamageParams_float_float_float_float_float(InBaseDamage, InMinimumDamage, InInnerRadius, InOuterRadius, InDamageFalloff), false)
		{
		}

		public FRadialDamageParams(float InBaseDamage, float InRadius) :
			base(E_CreateStruct_FRadialDamageParams_float_float(InBaseDamage, InRadius), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float(float InBaseDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float_float(float InBaseDamage, float InMinimumDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float(float InBaseDamage, float InRadius);
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetDamageScale(IntPtr Self, float DistanceFromEpicenter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetMaxRadius(IntPtr Self);
		
		#endregion
		
		#region Property
		public float BaseDamage
		{
			get => E_PROP_FRadialDamageParams_BaseDamage_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_BaseDamage_SET(NativePointer, value);
		}

		public float DamageFalloff
		{
			get => E_PROP_FRadialDamageParams_DamageFalloff_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_DamageFalloff_SET(NativePointer, value);
		}

		public float InnerRadius
		{
			get => E_PROP_FRadialDamageParams_InnerRadius_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_InnerRadius_SET(NativePointer, value);
		}

		public float MinimumDamage
		{
			get => E_PROP_FRadialDamageParams_MinimumDamage_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_MinimumDamage_SET(NativePointer, value);
		}

		public float OuterRadius
		{
			get => E_PROP_FRadialDamageParams_OuterRadius_GET(NativePointer);
			set => E_PROP_FRadialDamageParams_OuterRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetDamageScale(float DistanceFromEpicenter)
			=> E_FRadialDamageParams_GetDamageScale(this, DistanceFromEpicenter);
		
		
		/// <summary>
		/// <para>Return outermost radius of the damage area. Protects against malformed data. </para>
		/// </summary>
		public float GetMaxRadius()
			=> E_FRadialDamageParams_GetMaxRadius(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRadialDamageParams Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRadialDamageParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRadialDamageParams(Adress, false);
		}}}
