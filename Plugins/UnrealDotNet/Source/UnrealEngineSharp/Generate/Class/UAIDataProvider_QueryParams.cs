// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider_QueryParams.h:19

namespace UnrealEngine
{
	public partial class UAIDataProvider_QueryParams : UAIDataProvider
	{
		public UAIDataProvider_QueryParams(IntPtr adress)
			: base(adress)
		{
		}

		public UAIDataProvider_QueryParams(UObject Parent = null, string Name = "AIDataProvider_QueryParams")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIDataProvider_QueryParams(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UAIDataProvider_QueryParams_BoolValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAIDataProvider_QueryParams_BoolValue_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAIDataProvider_QueryParams_FloatValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAIDataProvider_QueryParams_FloatValue_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UAIDataProvider_QueryParams_IntValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAIDataProvider_QueryParams_IntValue_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UAIDataProvider_QueryParams_ParamName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAIDataProvider_QueryParams_ParamName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIDataProvider_QueryParams(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public bool BoolValue
		{
			get => E_PROP_UAIDataProvider_QueryParams_BoolValue_GET(NativePointer);
			set => E_PROP_UAIDataProvider_QueryParams_BoolValue_SET(NativePointer, value);
		}

		public float FloatValue
		{
			get => E_PROP_UAIDataProvider_QueryParams_FloatValue_GET(NativePointer);
			set => E_PROP_UAIDataProvider_QueryParams_FloatValue_SET(NativePointer, value);
		}

		public int IntValue
		{
			get => E_PROP_UAIDataProvider_QueryParams_IntValue_GET(NativePointer);
			set => E_PROP_UAIDataProvider_QueryParams_IntValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Arbitrary name this query parameter will be exposed as to outside world (like BT nodes)
		/// </summary>
		public string ParamName
		{
			get => E_PROP_UAIDataProvider_QueryParams_ParamName_GET(NativePointer);
			set => E_PROP_UAIDataProvider_QueryParams_ParamName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UAIDataProvider_QueryParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIDataProvider_QueryParams(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIDataProvider_QueryParams>(PtrDesc);
		}}}
