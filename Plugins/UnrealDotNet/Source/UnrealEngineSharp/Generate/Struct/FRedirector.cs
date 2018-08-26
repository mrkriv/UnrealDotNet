// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3614

namespace UnrealEngine
{
	public  partial class FRedirector : NativeStructWrapper
	{
		internal FRedirector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRedirector() :
			base(E_CreateStruct_FRedirector(), false)
		{
		}

		public FRedirector(string inOldName, string inNewName) :
			base(E_CreateStruct_FRedirector_FName_FName(inOldName, inNewName), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector_FName_FName(string inOldName, string inNewName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRedirector_NewName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRedirector_NewName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRedirector_OldName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRedirector_OldName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string NewName
		{
			get => E_PROP_FRedirector_NewName_GET(NativePointer);
			set => E_PROP_FRedirector_NewName_SET(NativePointer, value);
		}

		public string OldName
		{
			get => E_PROP_FRedirector_OldName_GET(NativePointer);
			set => E_PROP_FRedirector_OldName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRedirector self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRedirector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRedirector(Adress, false);
		}}}
