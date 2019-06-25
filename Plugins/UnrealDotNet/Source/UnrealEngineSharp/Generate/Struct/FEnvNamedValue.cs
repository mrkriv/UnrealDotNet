// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:270

namespace UnrealEngine
{
	public partial class FEnvNamedValue : NativeStructWrapper
	{
		public FEnvNamedValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvNamedValue() :
			base(E_CreateStruct_FEnvNamedValue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEnvNamedValue_ParamName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvNamedValue_ParamName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FEnvNamedValue_ParamType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvNamedValue_ParamType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvNamedValue_Value_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvNamedValue_Value_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvNamedValue();
		
		#endregion
		
		#region Property
		public string ParamName
		{
			get => E_PROP_FEnvNamedValue_ParamName_GET(NativePointer);
			set => E_PROP_FEnvNamedValue_ParamName_SET(NativePointer, value);
		}

		public EAIParamType ParamType
		{
			get => (EAIParamType)E_PROP_FEnvNamedValue_ParamType_GET(NativePointer);
			set => E_PROP_FEnvNamedValue_ParamType_SET(NativePointer, (byte)value);
		}

		public float Value
		{
			get => E_PROP_FEnvNamedValue_Value_GET(NativePointer);
			set => E_PROP_FEnvNamedValue_Value_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvNamedValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvNamedValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvNamedValue(adress, false);
		}}}
