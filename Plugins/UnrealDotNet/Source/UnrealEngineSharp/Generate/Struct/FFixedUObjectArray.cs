// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectArray.h:198

namespace UnrealEngine
{
	public  partial class FFixedUObjectArray : NativeStructWrapper
	{
		internal FFixedUObjectArray(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Current number of UObject slots
		/// </summary>
		public FFixedUObjectArray() :
			base(E_CreateStruct_FFixedUObjectArray(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFixedUObjectArray();
		
		#endregion
		
		public static implicit operator IntPtr(FFixedUObjectArray self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFixedUObjectArray(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFixedUObjectArray(Adress, false);
		}}}
