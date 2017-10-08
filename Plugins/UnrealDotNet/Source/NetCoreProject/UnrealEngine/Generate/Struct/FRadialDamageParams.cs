using System;
using System.Runtime.InteropServices;

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float(float InBaseDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float_float_float_float(float InBaseDamage, float InMinimumDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageParams_float_float(float InBaseDamage, float InRadius);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetDamageScale(IntPtr Self, float DistanceFromEpicenter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRadialDamageParams_GetMaxRadius(IntPtr Self);
		
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
