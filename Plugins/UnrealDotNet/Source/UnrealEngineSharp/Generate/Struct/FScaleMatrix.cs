// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\ScaleMatrix.h:12

namespace UnrealEngine
{
	public  partial class FScaleMatrix : FMatrix
	{
		internal FScaleMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// </summary>
		/// <param name="scale">uniform scale to apply to matrix.</param>
		public FScaleMatrix(float scale) :
			base(E_CreateStruct_FScaleMatrix_float(scale), false)
		{
		}

		
		/// <summary>
		/// </summary>
		/// <param name="scale">Non-uniform scale to apply to matrix.</param>
		public FScaleMatrix(FVector scale) :
			base(E_CreateStruct_FScaleMatrix_FVector(scale), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScaleMatrix_float(float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScaleMatrix_FVector(IntPtr scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScaleMatrix_Make(IntPtr self, float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScaleMatrix_Make_o1(IntPtr self, IntPtr scale);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(float scale)
			=> E_FScaleMatrix_Make(this, scale);
		
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FVector scale)
			=> E_FScaleMatrix_Make_o1(this, scale);
		
		#endregion
		
		public static implicit operator IntPtr(FScaleMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FScaleMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScaleMatrix(Adress, false);
		}}}
