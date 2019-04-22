// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:591

namespace UnrealEngine
{
	public  partial class FStructRedirect : NativeStructWrapper
	{
		internal FStructRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStructRedirect() :
			base(E_CreateStruct_FStructRedirect(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FStructRedirect_NewStructName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStructRedirect_NewStructName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FStructRedirect_OldStructName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStructRedirect_OldStructName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStructRedirect();
		
		#endregion
		
		#region Property
		public string NewStructName
		{
			get => E_PROP_FStructRedirect_NewStructName_GET(NativePointer);
			set => E_PROP_FStructRedirect_NewStructName_SET(NativePointer, value);
		}

		public string OldStructName
		{
			get => E_PROP_FStructRedirect_OldStructName_GET(NativePointer);
			set => E_PROP_FStructRedirect_OldStructName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStructRedirect self)
		{
			return self.NativePointer;
		}

		public static implicit operator FStructRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStructRedirect(Adress, false);
		}}}
