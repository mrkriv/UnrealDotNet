// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:75

namespace UnrealEngine
{
	public partial class FAIDataProviderTypedValue : FAIDataProviderValue
	{
		public FAIDataProviderTypedValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDataProviderTypedValue() :
			base(E_CreateStruct_FAIDataProviderTypedValue(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDataProviderTypedValue();
		
		#endregion
		
		public static implicit operator IntPtr(FAIDataProviderTypedValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDataProviderTypedValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDataProviderTypedValue(adress, false);
		}}}
