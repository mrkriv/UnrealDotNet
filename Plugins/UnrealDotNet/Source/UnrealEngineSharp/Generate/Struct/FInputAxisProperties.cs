// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:93

namespace UnrealEngine
{
	public partial class FInputAxisProperties : NativeStructWrapper
	{
		public FInputAxisProperties(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInputAxisProperties() :
			base(E_CreateStruct_FInputAxisProperties(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputAxisProperties_bInvert_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisProperties_bInvert_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisProperties_DeadZone_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisProperties_DeadZone_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisProperties_Exponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisProperties_Exponent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisProperties_Sensitivity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisProperties_Sensitivity_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputAxisProperties();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Inverts reported values for this axis
		/// </summary>
		public byte bInvert
		{
			get => E_PROP_FInputAxisProperties_bInvert_GET(NativePointer);
			set => E_PROP_FInputAxisProperties_bInvert_SET(NativePointer, value);
		}

		
		/// <summary>
		/// What the dead zone of the axis is.  For control axes such as analog sticks.
		/// </summary>
		public float DeadZone
		{
			get => E_PROP_FInputAxisProperties_DeadZone_GET(NativePointer);
			set => E_PROP_FInputAxisProperties_DeadZone_SET(NativePointer, value);
		}

		
		/// <summary>
		/// For applying curves to [0..1] axes, e.g. analog sticks
		/// </summary>
		public float Exponent
		{
			get => E_PROP_FInputAxisProperties_Exponent_GET(NativePointer);
			set => E_PROP_FInputAxisProperties_Exponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scaling factor to multiply raw value by.
		/// </summary>
		public float Sensitivity
		{
			get => E_PROP_FInputAxisProperties_Sensitivity_GET(NativePointer);
			set => E_PROP_FInputAxisProperties_Sensitivity_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputAxisProperties self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputAxisProperties(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputAxisProperties(adress, false);
		}}}
