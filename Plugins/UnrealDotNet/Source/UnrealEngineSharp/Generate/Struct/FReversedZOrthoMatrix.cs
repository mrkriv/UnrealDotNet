// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\OrthoMatrix.h:26

namespace UnrealEngine
{
	public partial class FReversedZOrthoMatrix : FMatrix
	{
		public FReversedZOrthoMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FReversedZOrthoMatrix(float width, float height, float zScale, float zOffset) :
			base(E_CreateStruct_FReversedZOrthoMatrix_float_float_float_float(width, height, zScale, zOffset), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReversedZOrthoMatrix_float_float_float_float(float width, float height, float zScale, float zOffset);
		
		#endregion
		
		public static implicit operator IntPtr(FReversedZOrthoMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FReversedZOrthoMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FReversedZOrthoMatrix(adress, false);
		}}}
