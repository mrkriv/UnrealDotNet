// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:211

namespace UnrealEngine
{
	public partial class FInputAxisKeyMapping : NativeStructWrapper
	{
		public FInputAxisKeyMapping(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FInputAxisKeyMapping_AxisName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisKeyMapping_AxisName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisKeyMapping_Scale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisKeyMapping_Scale_SET(IntPtr Ptr, float Value);
		
		#region Property
		
		/// <summary>
		/// Friendly name of axis, e.g "MoveForward"
		/// </summary>
		public string AxisName
		{
			get => E_PROP_FInputAxisKeyMapping_AxisName_GET(NativePointer);
			set => E_PROP_FInputAxisKeyMapping_AxisName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Multiplier to use for the mapping when accumulating the axis value
		/// </summary>
		public float Scale
		{
			get => E_PROP_FInputAxisKeyMapping_Scale_GET(NativePointer);
			set => E_PROP_FInputAxisKeyMapping_Scale_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputAxisKeyMapping self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputAxisKeyMapping(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputAxisKeyMapping(adress, false);
		}}}
