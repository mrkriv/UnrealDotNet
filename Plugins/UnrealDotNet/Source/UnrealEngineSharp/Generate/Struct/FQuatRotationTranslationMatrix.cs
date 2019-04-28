// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\QuatRotationTranslationMatrix.h:12

namespace UnrealEngine
{
	public  partial class FQuatRotationTranslationMatrix : FMatrix
	{
		internal FQuatRotationTranslationMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="q">rotation</param>
		/// <param name="origin">translation to apply</param>
		public FQuatRotationTranslationMatrix(FQuat q, FVector origin) :
			base(E_CreateStruct_FQuatRotationTranslationMatrix_FQuat_FVector(q, origin), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuatRotationTranslationMatrix_FQuat_FVector(IntPtr q, IntPtr origin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuatRotationTranslationMatrix_Make(IntPtr self, IntPtr q, IntPtr origin);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FQuat q, FVector origin)
			=> E_FQuatRotationTranslationMatrix_Make(this, q, origin);
		
		#endregion
		
		public static implicit operator IntPtr(FQuatRotationTranslationMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FQuatRotationTranslationMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuatRotationTranslationMatrix(Adress, false);
		}}}
