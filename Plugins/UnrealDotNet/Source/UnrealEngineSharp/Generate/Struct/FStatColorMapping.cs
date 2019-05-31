// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:454

namespace UnrealEngine
{
	public  partial class FStatColorMapping : NativeStructWrapper
	{
		internal FStatColorMapping(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStatColorMapping() :
			base(E_CreateStruct_FStatColorMapping(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FStatColorMapping_StatName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStatColorMapping_StatName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStatColorMapping();
		
		#endregion
		
		#region Property
		public string StatName
		{
			get => E_PROP_FStatColorMapping_StatName_GET(NativePointer);
			set => E_PROP_FStatColorMapping_StatName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStatColorMapping self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FStatColorMapping(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FStatColorMapping(adress, false);
		}}}
