// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\PerspectiveMatrix.h:55

namespace UnrealEngine
{
	public partial class FReversedZPerspectiveMatrix : FMatrix
	{
		public FReversedZPerspectiveMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FReversedZPerspectiveMatrix(float halfFOVX, float halfFOVY, float multFOVX, float multFOVY, float minZ, float maxZ) :
			base(E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float_float_float(halfFOVX, halfFOVY, multFOVX, multFOVY, minZ, maxZ), false)
		{
		}

		public FReversedZPerspectiveMatrix(float halfFOV, float width, float height, float minZ, float maxZ) :
			base(E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float_float(halfFOV, width, height, minZ, maxZ), false)
		{
		}

		public FReversedZPerspectiveMatrix(float halfFOV, float width, float height, float minZ) :
			base(E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float(halfFOV, width, height, minZ), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float_float_float(float halfFOVX, float halfFOVY, float multFOVX, float multFOVY, float minZ, float maxZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float_float(float halfFOV, float width, float height, float minZ, float maxZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReversedZPerspectiveMatrix_float_float_float_float(float halfFOV, float width, float height, float minZ);
		
		#endregion
		
		public static implicit operator IntPtr(FReversedZPerspectiveMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FReversedZPerspectiveMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FReversedZPerspectiveMatrix(adress, false);
		}}}
