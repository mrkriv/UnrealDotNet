// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\UnitConversion.inl:46

namespace UnrealEngine
{
	public  partial class FQuantizationInfo : NativeStructWrapper
	{
		internal FQuantizationInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// </summary>
		public FQuantizationInfo(EUnit inUnit, float inFactor) :
			base(E_CreateStruct_FQuantizationInfo_EUnit_float((byte)inUnit, inFactor), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuantizationInfo_Factor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuantizationInfo_Factor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FQuantizationInfo_Units_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuantizationInfo_Units_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuantizationInfo_EUnit_float(byte inUnit, float inFactor);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The factor by which to multiply to get to the next unit in this range </para>
		/// </summary>
		public float Factor
		{
			get => E_PROP_FQuantizationInfo_Factor_GET(NativePointer);
			set => E_PROP_FQuantizationInfo_Factor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The unit to which this factor applies </para>
		/// </summary>
		public EUnit Units
		{
			get => (EUnit)E_PROP_FQuantizationInfo_Units_GET(NativePointer);
			set => E_PROP_FQuantizationInfo_Units_SET(NativePointer, (byte)value);
		}

		#endregion
		
		public static implicit operator IntPtr(FQuantizationInfo self)
		{
			return self.NativePointer;
		}

		public static implicit operator FQuantizationInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuantizationInfo(Adress, false);
		}}}
