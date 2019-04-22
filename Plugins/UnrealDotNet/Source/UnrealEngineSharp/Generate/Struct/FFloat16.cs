// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Float16.h:26

namespace UnrealEngine
{
	public  partial class FFloat16 : NativeStructWrapper
	{
		internal FFloat16(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor </para>
		/// </summary>
		public FFloat16() :
			base(E_CreateStruct_FFloat16(), false)
		{
		}

		
		/// <summary>
		/// <para>Copy constructor. </para>
		/// </summary>
		public FFloat16(FFloat16 fP16Value) :
			base(E_CreateStruct_FFloat16_FFloat16(fP16Value), false)
		{
		}

		
		/// <summary>
		/// <para>Conversion constructor. Convert from Fp32 to Fp16. </para>
		/// </summary>
		public FFloat16(float fP32Value) :
			base(E_CreateStruct_FFloat16_float(fP32Value), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16_FFloat16(IntPtr fP16Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16_float(float fP32Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFloat16_GetFloat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFloat16_Set(IntPtr self, float fP32Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFloat16_SetWithoutBoundsChecks(IntPtr self, float fP32Value);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Convert from Fp16 to Fp32. </para>
		/// </summary>
		public float GetFloat()
			=> E_FFloat16_GetFloat(this);
		
		
		/// <summary>
		/// <para>Convert from Fp32 to Fp16. </para>
		/// </summary>
		public void Set(float fP32Value)
			=> E_FFloat16_Set(this, fP32Value);
		
		
		/// <summary>
		/// <para>Convert from Fp32 to Fp16 without doing any checks if </para>
		/// <para>the Fp32 exponent is too large or too small. This is a </para>
		/// <para>faster alternative to Set() when you know the values </para>
		/// <para>within the single precision float don't need the checks. </para>
		/// <param name="FP32Value">Single precision float to be set as half precision. </param>
		/// </summary>
		public void SetWithoutBoundsChecks(float fP32Value)
			=> E_FFloat16_SetWithoutBoundsChecks(this, fP32Value);
		
		#endregion
		
		public static implicit operator IntPtr(FFloat16 self)
		{
			return self.NativePointer;
		}

		public static implicit operator FFloat16(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFloat16(Adress, false);
		}}}
