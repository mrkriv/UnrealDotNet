// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\RotationTranslationMatrix.h:11

namespace UnrealEngine
{
	public  partial class FRotationTranslationMatrix : FMatrix
	{
		internal FRotationTranslationMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="rot">rotation</param>
		/// <param name="origin">translation to apply</param>
		public FRotationTranslationMatrix(FRotator rot, FVector origin) :
			base(E_CreateStruct_FRotationTranslationMatrix_FRotator_FVector(rot, origin), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationTranslationMatrix_FRotator_FVector(IntPtr rot, IntPtr origin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationTranslationMatrix_Make(IntPtr self, IntPtr rot, IntPtr origin);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FRotator rot, FVector origin)
			=> E_FRotationTranslationMatrix_Make(this, rot, origin);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationTranslationMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRotationTranslationMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotationTranslationMatrix(Adress, false);
		}}}
