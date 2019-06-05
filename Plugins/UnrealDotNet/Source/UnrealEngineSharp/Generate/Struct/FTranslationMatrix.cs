// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TranslationMatrix.h:10

namespace UnrealEngine
{
	public partial class FTranslationMatrix : FMatrix
	{
		public FTranslationMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor translation matrix based on given vector
		/// </summary>
		public FTranslationMatrix(FVector delta) :
			base(E_CreateStruct_FTranslationMatrix_FVector(delta), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTranslationMatrix_FVector(IntPtr delta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTranslationMatrix_Make(IntPtr self, IntPtr delta);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FVector delta)
			=> E_FTranslationMatrix_Make(this, delta);
		
		#endregion
		
		public static implicit operator IntPtr(FTranslationMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTranslationMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTranslationMatrix(adress, false);
		}}}
