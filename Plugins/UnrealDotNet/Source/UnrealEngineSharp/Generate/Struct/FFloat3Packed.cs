// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\PackedVector.h:14

namespace UnrealEngine
{
	public  partial class FFloat3Packed : NativeStructWrapper
	{
		internal FFloat3Packed(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFloat3Packed() :
			base(E_CreateStruct_FFloat3Packed(), false)
		{
		}

		public FFloat3Packed(FLinearColor src) :
			base(E_CreateStruct_FFloat3Packed_FLinearColor(src), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat3Packed();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat3Packed_FLinearColor(IntPtr src);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FFloat3Packed_ToLinearColor(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public FLinearColor ToLinearColor()
			=> E_FFloat3Packed_ToLinearColor(this);
		
		#endregion
		
		public static implicit operator IntPtr(FFloat3Packed self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFloat3Packed(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFloat3Packed(Adress, false);
		}}}
