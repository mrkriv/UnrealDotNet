// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:330

namespace UnrealEngine
{
	public  partial class FInputKeyBinding : FInputBinding
	{
		internal FInputKeyBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputKeyBinding() :
			base(E_CreateStruct_FInputKeyBinding(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FInputKeyBinding_KeyDelegate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputKeyBinding_KeyDelegate_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputKeyBinding();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The delegate bound to the key chord
		/// </summary>
		public FInputActionUnifiedDelegate KeyDelegate
		{
			get => E_PROP_FInputKeyBinding_KeyDelegate_GET(NativePointer);
			set => E_PROP_FInputKeyBinding_KeyDelegate_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputKeyBinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputKeyBinding(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputKeyBinding(adress, false);
		}}}
