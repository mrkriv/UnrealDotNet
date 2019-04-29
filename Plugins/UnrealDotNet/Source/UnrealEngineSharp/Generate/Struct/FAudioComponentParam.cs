// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:61

namespace UnrealEngine
{
	public  partial class FAudioComponentParam : NativeStructWrapper
	{
		internal FAudioComponentParam(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAudioComponentParam(string name) :
			base(E_CreateStruct_FAudioComponentParam_FName(name), false)
		{
		}

		public FAudioComponentParam() :
			base(E_CreateStruct_FAudioComponentParam(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAudioComponentParam_BoolParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_BoolParam_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAudioComponentParam_FloatParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_FloatParam_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FAudioComponentParam_IntParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_IntParam_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAudioComponentParam_ParamName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_ParamName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam_FName(string name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam();
		
		#endregion
		
		#region Property
		public bool BoolParam
		{
			get => E_PROP_FAudioComponentParam_BoolParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_BoolParam_SET(NativePointer, value);
		}

		public float FloatParam
		{
			get => E_PROP_FAudioComponentParam_FloatParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_FloatParam_SET(NativePointer, value);
		}

		public int IntParam
		{
			get => E_PROP_FAudioComponentParam_IntParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_IntParam_SET(NativePointer, value);
		}

		public string ParamName
		{
			get => E_PROP_FAudioComponentParam_ParamName_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_ParamName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAudioComponentParam self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAudioComponentParam(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAudioComponentParam(Adress, false);
		}}}
