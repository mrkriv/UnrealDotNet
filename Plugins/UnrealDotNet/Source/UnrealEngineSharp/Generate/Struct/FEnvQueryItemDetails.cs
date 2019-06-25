// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:570

namespace UnrealEngine
{
	public partial class FEnvQueryItemDetails : NativeStructWrapper
	{
		public FEnvQueryItemDetails(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryItemDetails() :
			base(E_CreateStruct_FEnvQueryItemDetails(), false)
		{
		}

		public FEnvQueryItemDetails(int numTests, int inItemIndex) :
			base(E_CreateStruct_FEnvQueryItemDetails_int32_int32(numTests, inItemIndex), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEnvQueryItemDetails_FailedDescription_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryItemDetails_FailedDescription_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryItemDetails_FailedTestIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryItemDetails_FailedTestIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryItemDetails_ItemIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryItemDetails_ItemIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryItemDetails();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryItemDetails_int32_int32(int numTests, int inItemIndex);
		
		#endregion
		
		#region Property
		public string FailedDescription
		{
			get => E_PROP_FEnvQueryItemDetails_FailedDescription_GET(NativePointer);
			set => E_PROP_FEnvQueryItemDetails_FailedDescription_SET(NativePointer, value);
		}

		public int FailedTestIndex
		{
			get => E_PROP_FEnvQueryItemDetails_FailedTestIndex_GET(NativePointer);
			set => E_PROP_FEnvQueryItemDetails_FailedTestIndex_SET(NativePointer, value);
		}

		public int ItemIndex
		{
			get => E_PROP_FEnvQueryItemDetails_ItemIndex_GET(NativePointer);
			set => E_PROP_FEnvQueryItemDetails_ItemIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvQueryItemDetails self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryItemDetails(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryItemDetails(adress, false);
		}}}
