// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryDebugHelpers.h:33

namespace UnrealEngine
{
	public partial class FTestData : NativeStructWrapper
	{
		public FTestData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTestData() :
			base(E_CreateStruct_FTestData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTestData_Detailed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTestData_Detailed_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTestData_ShortName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTestData_ShortName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTestData();
		
		#endregion
		
		#region Property
		public string Detailed
		{
			get => E_PROP_FTestData_Detailed_GET(NativePointer);
			set => E_PROP_FTestData_Detailed_SET(NativePointer, value);
		}

		public string ShortName
		{
			get => E_PROP_FTestData_ShortName_GET(NativePointer);
			set => E_PROP_FTestData_ShortName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTestData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTestData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTestData(adress, false);
		}}}
