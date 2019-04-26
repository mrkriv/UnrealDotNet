// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\OrthoMatrix.h:9

namespace UnrealEngine
{
	public  partial class FOrthoMatrix : FMatrix
	{
		internal FOrthoMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="Width">view space width </param>
		/// <param name="Height">view space height </param>
		/// <param name="ZScale">scale in the Z axis </param>
		/// <param name="ZOffset">offset in the Z axis </param>
		/// </summary>
		public FOrthoMatrix(float width, float height, float zScale, float zOffset) :
			base(E_CreateStruct_FOrthoMatrix_float_float_float_float(width, height, zScale, zOffset), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOrthoMatrix_float_float_float_float(float width, float height, float zScale, float zOffset);
		
		#endregion
		
		public static implicit operator IntPtr(FOrthoMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FOrthoMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FOrthoMatrix(Adress, false);
		}