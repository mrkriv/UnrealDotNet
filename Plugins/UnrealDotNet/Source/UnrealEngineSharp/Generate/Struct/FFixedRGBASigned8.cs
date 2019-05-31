// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\PackedVector.h:272

namespace UnrealEngine
{
	public  partial class FFixedRGBASigned8 : NativeStructWrapper
	{
		internal FFixedRGBASigned8(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFixedRGBASigned8() :
			base(E_CreateStruct_FFixedRGBASigned8(), false)
		{
		}

		public FFixedRGBASigned8(FLinearColor src) :
			base(E_CreateStruct_FFixedRGBASigned8_FLinearColor(src), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFixedRGBASigned8();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFixedRGBASigned8_FLinearColor(IntPtr src);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FFixedRGBASigned8_ToLinearColor(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public FLinearColor ToLinearColor()
			=> E_FFixedRGBASigned8_ToLinearColor(this);
		
		#endregion
		
		public static implicit operator IntPtr(FFixedRGBASigned8 self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFixedRGBASigned8(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFixedRGBASigned8(adress, false);
		}}}
