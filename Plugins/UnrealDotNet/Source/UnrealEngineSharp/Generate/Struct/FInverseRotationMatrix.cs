// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\InverseRotationMatrix.h:11

namespace UnrealEngine
{
	public partial class FInverseRotationMatrix : FMatrix
	{
		public FInverseRotationMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="rot">rotation</param>
		public FInverseRotationMatrix(FRotator rot) :
			base(E_CreateStruct_FInverseRotationMatrix_FRotator(rot), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInverseRotationMatrix_FRotator(IntPtr rot);
		
		#endregion
		
		public static implicit operator IntPtr(FInverseRotationMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInverseRotationMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInverseRotationMatrix(adress, false);
		}}}
