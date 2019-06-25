// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:125

namespace UnrealEngine
{
	public partial class FAIDataProviderBoolValue : FAIDataProviderTypedValue
	{
		public FAIDataProviderBoolValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDataProviderBoolValue() :
			base(E_CreateStruct_FAIDataProviderBoolValue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAIDataProviderBoolValue_DefaultValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDataProviderBoolValue_DefaultValue_SET(IntPtr Ptr, bool Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDataProviderBoolValue();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIDataProviderBoolValue_GetValue(IntPtr self);
		
		#endregion
		
		#region Property
		public bool DefaultValue
		{
			get => E_PROP_FAIDataProviderBoolValue_DefaultValue_GET(NativePointer);
			set => E_PROP_FAIDataProviderBoolValue_DefaultValue_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool GetValue()
			=> E_FAIDataProviderBoolValue_GetValue(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIDataProviderBoolValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDataProviderBoolValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDataProviderBoolValue(adress, false);
		}}}
