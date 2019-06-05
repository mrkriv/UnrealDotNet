// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Matrix.h:22

namespace UnrealEngine
{
	public partial class FMatrix : NativeStructWrapper
	{
		public FMatrix(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FMatrix() :
			base(E_CreateStruct_FMatrix(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix();
		
		#endregion
		
		public static implicit operator IntPtr(FMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMatrix(adress, false);
		}}}
