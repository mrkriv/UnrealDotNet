using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1365

namespace UnrealEngine
{
	public  partial class FRotationConversionCache : NativeStructWrapper
	{
		internal FRotationConversionCache(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRotationConversionCache() :
			base(E_CreateStruct_FRotationConversionCache(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationConversionCache();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedRotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_NormalizedQuatToRotator(IntPtr Self, IntPtr InNormalizedQuat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_NormalizedQuatToRotator_ReadOnly(IntPtr Self, IntPtr InNormalizedQuat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_QuatToRotator(IntPtr Self, IntPtr InQuat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_QuatToRotator_ReadOnly(IntPtr Self, IntPtr InQuat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_RotatorToQuat(IntPtr Self, IntPtr InRotator);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_RotatorToQuat_ReadOnly(IntPtr Self, IntPtr InRotator);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Return the cached Quat. </para>
		/// </summary>
		public FQuat GetCachedQuat()
			=> E_FRotationConversionCache_GetCachedQuat(this);
		
		
		/// <summary>
		/// <para>Return the cached Rotator. </para>
		/// </summary>
		public FRotator GetCachedRotator()
			=> E_FRotationConversionCache_GetCachedRotator(this);
		
		
		/// <summary>
		/// <para>Version of QuatToRotator when the Quat is known to already be normalized. </para>
		/// </summary>
		public FRotator NormalizedQuatToRotator(FQuat InNormalizedQuat)
			=> E_FRotationConversionCache_NormalizedQuatToRotator(this, InNormalizedQuat);
		
		
		/// <summary>
		/// <para>Version of QuatToRotator when the Quat is known to already be normalized. Does *NOT* update the cache if there was no match. </para>
		/// </summary>
		public FRotator NormalizedQuatToRotator_ReadOnly(FQuat InNormalizedQuat)
			=> E_FRotationConversionCache_NormalizedQuatToRotator_ReadOnly(this, InNormalizedQuat);
		
		
		/// <summary>
		/// <para>Convert a FQuat to FRotator. Uses the cached conversion if possible, and updates it if there was no match. </para>
		/// </summary>
		public FRotator QuatToRotator(FQuat InQuat)
			=> E_FRotationConversionCache_QuatToRotator(this, InQuat);
		
		
		/// <summary>
		/// <para>Convert a FQuat to FRotator. Uses the cached conversion if possible, but does *NOT* update the cache if there was no match. </para>
		/// </summary>
		public FRotator QuatToRotator_ReadOnly(FQuat InQuat)
			=> E_FRotationConversionCache_QuatToRotator_ReadOnly(this, InQuat);
		
		
		/// <summary>
		/// <para>Convert a FRotator to FQuat. Uses the cached conversion if possible, and updates it if there was no match. </para>
		/// </summary>
		public FQuat RotatorToQuat(FRotator InRotator)
			=> E_FRotationConversionCache_RotatorToQuat(this, InRotator);
		
		
		/// <summary>
		/// <para>Convert a FRotator to FQuat. Uses the cached conversion if possible, but does *NOT* update the cache if there was no match. </para>
		/// </summary>
		public FQuat RotatorToQuat_ReadOnly(FRotator InRotator)
			=> E_FRotationConversionCache_RotatorToQuat_ReadOnly(this, InRotator);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationConversionCache Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRotationConversionCache(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotationConversionCache(Adress, false);
		}}}
