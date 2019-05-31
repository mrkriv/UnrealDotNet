// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\FloatPacker.h:14

namespace UnrealEngine
{
	public  partial class FFloatInfo_IEEE32 : NativeStructWrapper
	{
		internal FFloatInfo_IEEE32(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFloatInfo_IEEE32() :
			base(E_CreateStruct_FFloatInfo_IEEE32(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloatInfo_IEEE32();
		
		#endregion
		
		public static implicit operator IntPtr(FFloatInfo_IEEE32 self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFloatInfo_IEEE32(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFloatInfo_IEEE32(adress, false);
		}}}
