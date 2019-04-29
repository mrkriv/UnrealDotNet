// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:604

namespace UnrealEngine
{
	public  partial class FPluginRedirect : NativeStructWrapper
	{
		internal FPluginRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPluginRedirect() :
			base(E_CreateStruct_FPluginRedirect(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FPluginRedirect_NewPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPluginRedirect_NewPluginName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FPluginRedirect_OldPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPluginRedirect_OldPluginName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPluginRedirect();
		
		#endregion
		
		#region Property
		public string NewPluginName
		{
			get => E_PROP_FPluginRedirect_NewPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_NewPluginName_SET(NativePointer, value);
		}

		public string OldPluginName
		{
			get => E_PROP_FPluginRedirect_OldPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_OldPluginName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPluginRedirect self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPluginRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPluginRedirect(Adress, false);
		}}}
