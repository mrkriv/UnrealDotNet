// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryDebugHelpers.h:40

namespace UnrealEngine
{
	public partial class FDebugHelper : NativeStructWrapper
	{
		public FDebugHelper(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FDebugHelper() :
			base(E_CreateStruct_FDebugHelper(), false)
		{
		}

		public FDebugHelper(FVector loc, float r) :
			base(E_CreateStruct_FDebugHelper_FVector_float(loc, r), false)
		{
		}

		public FDebugHelper(FVector loc, float r, string desc) :
			base(E_CreateStruct_FDebugHelper_FVector_float_FString(loc, r, desc), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FDebugHelper_AdditionalInformation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugHelper_AdditionalInformation_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugHelper_FailedScore_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugHelper_FailedScore_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FDebugHelper_FailedTestIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugHelper_FailedTestIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugHelper_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugHelper_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugHelper_Radius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugHelper_Radius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugHelper();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugHelper_FVector_float(IntPtr loc, float r);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugHelper_FVector_float_FString(IntPtr loc, float r, string desc);
		
		#endregion
		
		#region Property
		public string AdditionalInformation
		{
			get => E_PROP_FDebugHelper_AdditionalInformation_GET(NativePointer);
			set => E_PROP_FDebugHelper_AdditionalInformation_SET(NativePointer, value);
		}

		public float FailedScore
		{
			get => E_PROP_FDebugHelper_FailedScore_GET(NativePointer);
			set => E_PROP_FDebugHelper_FailedScore_SET(NativePointer, value);
		}

		public int FailedTestIndex
		{
			get => E_PROP_FDebugHelper_FailedTestIndex_GET(NativePointer);
			set => E_PROP_FDebugHelper_FailedTestIndex_SET(NativePointer, value);
		}

		public FVector Location
		{
			get => E_PROP_FDebugHelper_Location_GET(NativePointer);
			set => E_PROP_FDebugHelper_Location_SET(NativePointer, value);
		}

		public float Radius
		{
			get => E_PROP_FDebugHelper_Radius_GET(NativePointer);
			set => E_PROP_FDebugHelper_Radius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDebugHelper self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDebugHelper(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDebugHelper(adress, false);
		}}}
