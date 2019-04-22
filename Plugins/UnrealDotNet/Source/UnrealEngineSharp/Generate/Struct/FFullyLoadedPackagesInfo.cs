// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:150

namespace UnrealEngine
{
	public  partial class FFullyLoadedPackagesInfo : NativeStructWrapper
	{
		internal FFullyLoadedPackagesInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFullyLoadedPackagesInfo() :
			base(E_CreateStruct_FFullyLoadedPackagesInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FFullyLoadedPackagesInfo_LoadedObjects_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFullyLoadedPackagesInfo_LoadedObjects_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FFullyLoadedPackagesInfo_PackagesToLoad_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFullyLoadedPackagesInfo_PackagesToLoad_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FFullyLoadedPackagesInfo_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFullyLoadedPackagesInfo_Tag_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFullyLoadedPackagesInfo();
		
		#endregion
		
		#region Property
		public TArray<UObject> LoadedObjects
		{
			get => E_PROP_FFullyLoadedPackagesInfo_LoadedObjects_GET(NativePointer);
			set => E_PROP_FFullyLoadedPackagesInfo_LoadedObjects_SET(NativePointer, value);
		}

		public TArray<string> PackagesToLoad
		{
			get => E_PROP_FFullyLoadedPackagesInfo_PackagesToLoad_GET(NativePointer);
			set => E_PROP_FFullyLoadedPackagesInfo_PackagesToLoad_SET(NativePointer, value);
		}

		public string Tag
		{
			get => E_PROP_FFullyLoadedPackagesInfo_Tag_GET(NativePointer);
			set => E_PROP_FFullyLoadedPackagesInfo_Tag_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFullyLoadedPackagesInfo self)
		{
			return self.NativePointer;
		}

		public static implicit operator FFullyLoadedPackagesInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFullyLoadedPackagesInfo(Adress, false);
		}}}
