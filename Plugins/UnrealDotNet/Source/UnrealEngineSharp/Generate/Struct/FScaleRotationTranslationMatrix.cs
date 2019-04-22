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
	public  partial class FScaleRotationTranslationMatrix : FMatrix
	{
		internal FScaleRotationTranslationMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="Scale">scale to apply to matrix </param>
		/// <param name="Rot">rotation </param>
		/// <param name="Origin">translation to apply </param>
		/// </summary>
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
			return self.NativePointer;
		}

		public static implicit operator FScaleRotationTranslationMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScaleRotationTranslationMatrix(Adress, false);
		}}}
