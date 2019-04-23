// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:124

namespace UnrealEngine
{
	public  partial class FInputAxisConfigEntry : NativeStructWrapper
	{
		internal FInputAxisConfigEntry(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputAxisConfigEntry() :
			base(E_CreateStruct_FInputAxisConfigEntry(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FInputAxisConfigEntry_AxisKeyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisConfigEntry_AxisKeyName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FInputAxisConfigEntry_AxisProperties_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisConfigEntry_AxisProperties_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputAxisConfigEntry();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Axis Key these properties apply to </para>
		/// </summary>
		public string AxisKeyName
		{
			get => E_PROP_FInputAxisConfigEntry_AxisKeyName_GET(NativePointer);
			set => E_PROP_FInputAxisConfigEntry_AxisKeyName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Properties for the Axis Key </para>
		/// </summary>
		public FInputAxisProperties AxisProperties
		{
			get => E_PROP_FInputAxisConfigEntry_AxisProperties_GET(NativePointer);
			set => E_PROP_FInputAxisConfigEntry_AxisProperties_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputAxisConfigEntry self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInputAxisConfigEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInputAxisConfigEntry(Adress, false);
		}}}
