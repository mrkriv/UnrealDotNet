// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:547

namespace UnrealEngine
{
	public  partial class FGameNameRedirect : NativeStructWrapper
	{
		internal FGameNameRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FGameNameRedirect() :
			base(E_CreateStruct_FGameNameRedirect(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FGameNameRedirect_NewGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FGameNameRedirect_NewGameName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FGameNameRedirect_OldGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FGameNameRedirect_OldGameName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGameNameRedirect();
		
		#endregion
		
		#region Property
		public string NewGameName
		{
			get => E_PROP_FGameNameRedirect_NewGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_NewGameName_SET(NativePointer, value);
		}

		public string OldGameName
		{
			get => E_PROP_FGameNameRedirect_OldGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_OldGameName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FGameNameRedirect self)
		{
			return self.NativePointer;
		}

		public static implicit operator FGameNameRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameNameRedirect(Adress, false);
		}}}
