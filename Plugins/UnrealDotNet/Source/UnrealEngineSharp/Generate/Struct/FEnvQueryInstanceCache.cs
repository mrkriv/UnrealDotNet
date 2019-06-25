// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryManager.h:80

namespace UnrealEngine
{
	public partial class FEnvQueryInstanceCache : NativeStructWrapper
	{
		public FEnvQueryInstanceCache(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryInstanceCache() :
			base(E_CreateStruct_FEnvQueryInstanceCache(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEnvQueryInstanceCache_AssetName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstanceCache_AssetName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FEnvQueryInstanceCache_Instance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstanceCache_Instance_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryInstanceCache();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// the name of the source query
		/// </summary>
		public string AssetName
		{
			get => E_PROP_FEnvQueryInstanceCache_AssetName_GET(NativePointer);
			set => E_PROP_FEnvQueryInstanceCache_AssetName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// instance to duplicate
		/// </summary>
		public FEnvQueryInstance Instance
		{
			get => E_PROP_FEnvQueryInstanceCache_Instance_GET(NativePointer);
			set => E_PROP_FEnvQueryInstanceCache_Instance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvQueryInstanceCache self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryInstanceCache(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryInstanceCache(adress, false);
		}}}
