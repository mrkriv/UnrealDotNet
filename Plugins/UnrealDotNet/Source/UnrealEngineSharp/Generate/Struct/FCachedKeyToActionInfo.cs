// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:641

namespace UnrealEngine
{
	public  partial class FCachedKeyToActionInfo : NativeStructWrapper
	{
		internal FCachedKeyToActionInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCachedKeyToActionInfo() :
			base(E_CreateStruct_FCachedKeyToActionInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FCachedKeyToActionInfo_PlayerInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCachedKeyToActionInfo_PlayerInput_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCachedKeyToActionInfo();
		
		#endregion
		
		#region Property
		public UPlayerInput PlayerInput
		{
			get => E_PROP_FCachedKeyToActionInfo_PlayerInput_GET(NativePointer);
			set => E_PROP_FCachedKeyToActionInfo_PlayerInput_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCachedKeyToActionInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCachedKeyToActionInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCachedKeyToActionInfo(Adress, false);
		}}}
