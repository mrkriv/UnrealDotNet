// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:88

namespace UnrealEngine
{
	public partial class FAIDataProviderStructValue : FAIDataProviderValue
	{
		public FAIDataProviderStructValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDataProviderStructValue() :
			base(E_CreateStruct_FAIDataProviderStructValue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAIDataProviderStructValue_StructName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDataProviderStructValue_StructName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDataProviderStructValue();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// name of UStruct type
		/// </summary>
		public string StructName
		{
			get => E_PROP_FAIDataProviderStructValue_StructName_GET(NativePointer);
			set => E_PROP_FAIDataProviderStructValue_StructName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAIDataProviderStructValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDataProviderStructValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDataProviderStructValue(adress, false);
		}}}
