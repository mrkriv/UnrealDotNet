// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1400

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationConversionCache();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedQuat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedRotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_NormalizedQuatToRotator(IntPtr self, IntPtr inNormalizedQuat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_NormalizedQuatToRotator_ReadOnly(IntPtr self, IntPtr inNormalizedQuat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_QuatToRotator(IntPtr self, IntPtr inQuat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_QuatToRotator_ReadOnly(IntPtr self, IntPtr inQuat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_RotatorToQuat(IntPtr self, IntPtr inRotator);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_RotatorToQuat_ReadOnly(IntPtr self, IntPtr inRotator);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Return the cached Quat.
		/// </summary>
		public FQuat GetCachedQuat()
			=> E_FRotationConversionCache_GetCachedQuat(this);
		
		
		/// <summary>
		/// Return the cached Rotator.
		/// </summary>
		public FRotator GetCachedRotator()
			=> E_FRotationConversionCache_GetCachedRotator(this);
		
		
		/// <summary>
		/// Version of QuatToRotator when the Quat is known to already be normalized.
		/// </summary>
		public FRotator NormalizedQuatToRotator(FQuat inNormalizedQuat)
			=> E_FRotationConversionCache_NormalizedQuatToRotator(this, inNormalizedQuat);
		
		
		/// <summary>
		/// Version of QuatToRotator when the Quat is known to already be normalized. Does *NOT* update the cache if there was no match.
		/// </summary>
		public FRotator NormalizedQuatToRotator_ReadOnly(FQuat inNormalizedQuat)
			=> E_FRotationConversionCache_NormalizedQuatToRotator_ReadOnly(this, inNormalizedQuat);
		
		
		/// <summary>
		/// Convert a FQuat to FRotator. Uses the cached conversion if possible, and updates it if there was no match.
		/// </summary>
		public FRotator QuatToRotator(FQuat inQuat)
			=> E_FRotationConversionCache_QuatToRotator(this, inQuat);
		
		
		/// <summary>
		/// Convert a FQuat to FRotator. Uses the cached conversion if possible, but does *NOT* update the cache if there was no match.
		/// </summary>
		public FRotator QuatToRotator_ReadOnly(FQuat inQuat)
			=> E_FRotationConversionCache_QuatToRotator_ReadOnly(this, inQuat);
		
		
		/// <summary>
		/// Convert a FRotator to FQuat. Uses the cached conversion if possible, and updates it if there was no match.
		/// </summary>
		public FQuat RotatorToQuat(FRotator inRotator)
			=> E_FRotationConversionCache_RotatorToQuat(this, inRotator);
		
		
		/// <summary>
		/// Convert a FRotator to FQuat. Uses the cached conversion if possible, but does *NOT* update the cache if there was no match.
		/// </summary>
		public FQuat RotatorToQuat_ReadOnly(FRotator inRotator)
			=> E_FRotationConversionCache_RotatorToQuat_ReadOnly(this, inRotator);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationConversionCache self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRotationConversionCache(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotationConversionCache(Adress, false);
		}}}
