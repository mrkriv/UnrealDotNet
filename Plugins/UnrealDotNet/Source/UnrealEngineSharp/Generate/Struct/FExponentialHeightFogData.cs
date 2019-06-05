// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:16

namespace UnrealEngine
{
	public partial class FExponentialHeightFogData : NativeStructWrapper
	{
		public FExponentialHeightFogData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FExponentialHeightFogData() :
			base(E_CreateStruct_FExponentialHeightFogData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FExponentialHeightFogData_FogDensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExponentialHeightFogData_FogDensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FExponentialHeightFogData_FogHeightFalloff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExponentialHeightFogData_FogHeightFalloff_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FExponentialHeightFogData_FogHeightOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExponentialHeightFogData_FogHeightOffset_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FExponentialHeightFogData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FExponentialHeightFogData_ClampToValidRanges(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Global density factor for this fog.
		/// </summary>
		public float FogDensity
		{
			get => E_PROP_FExponentialHeightFogData_FogDensity_GET(NativePointer);
			set => E_PROP_FExponentialHeightFogData_FogDensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Height density factor, controls how the density increases as height decreases.
		/// <para>Smaller values make the visible transition larger. </para>
		/// </summary>
		public float FogHeightFalloff
		{
			get => E_PROP_FExponentialHeightFogData_FogHeightFalloff_GET(NativePointer);
			set => E_PROP_FExponentialHeightFogData_FogHeightFalloff_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Height offset, relative to the actor position Z.
		/// </summary>
		public float FogHeightOffset
		{
			get => E_PROP_FExponentialHeightFogData_FogHeightOffset_GET(NativePointer);
			set => E_PROP_FExponentialHeightFogData_FogHeightOffset_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Clamp to valid ranges. This might be different from the UI clamp.
		/// </summary>
		public void ClampToValidRanges()
			=> E_FExponentialHeightFogData_ClampToValidRanges(this);
		
		#endregion
		
		public static implicit operator IntPtr(FExponentialHeightFogData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FExponentialHeightFogData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FExponentialHeightFogData(adress, false);
		}}}
