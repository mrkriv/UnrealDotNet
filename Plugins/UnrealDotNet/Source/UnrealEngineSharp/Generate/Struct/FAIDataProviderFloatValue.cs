// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:112

namespace UnrealEngine
{
	public partial class FAIDataProviderFloatValue : FAIDataProviderTypedValue
	{
		public FAIDataProviderFloatValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDataProviderFloatValue() :
			base(E_CreateStruct_FAIDataProviderFloatValue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAIDataProviderFloatValue_DefaultValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDataProviderFloatValue_DefaultValue_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDataProviderFloatValue();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FAIDataProviderFloatValue_GetValue(IntPtr self);
		
		#endregion
		
		#region Property
		public float DefaultValue
		{
			get => E_PROP_FAIDataProviderFloatValue_DefaultValue_GET(NativePointer);
			set => E_PROP_FAIDataProviderFloatValue_DefaultValue_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetValue()
			=> E_FAIDataProviderFloatValue_GetValue(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIDataProviderFloatValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDataProviderFloatValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDataProviderFloatValue(adress, false);
		}}}
