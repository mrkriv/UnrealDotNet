// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\ScaleRotationTranslationMatrix.h:10

namespace UnrealEngine
{
	public partial class FScaleRotationTranslationMatrix : FMatrix
	{
		public FScaleRotationTranslationMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="scale">scale to apply to matrix</param>
		/// <param name="rot">rotation</param>
		/// <param name="origin">translation to apply</param>
		public FScaleRotationTranslationMatrix(FVector scale, FRotator rot, FVector origin) :
			base(E_CreateStruct_FScaleRotationTranslationMatrix_FVector_FRotator_FVector(scale, rot, origin), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScaleRotationTranslationMatrix_FVector_FRotator_FVector(IntPtr scale, IntPtr rot, IntPtr origin);
		
		#endregion
		
		public static implicit operator IntPtr(FScaleRotationTranslationMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FScaleRotationTranslationMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FScaleRotationTranslationMatrix(adress, false);
		}}}
