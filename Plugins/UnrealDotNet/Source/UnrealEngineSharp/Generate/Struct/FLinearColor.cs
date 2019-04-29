// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Color.h:31

namespace UnrealEngine
{
	public  partial class FLinearColor : NativeStructWrapper
	{
		internal FLinearColor(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLinearColor() :
			base(E_CreateStruct_FLinearColor(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLinearColor();
		
		#endregion
		
		public static implicit operator IntPtr(FLinearColor self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLinearColor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLinearColor(Adress, false);
		}}}
