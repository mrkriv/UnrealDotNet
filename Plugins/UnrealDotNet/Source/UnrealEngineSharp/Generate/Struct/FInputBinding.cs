// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:110

namespace UnrealEngine
{
	public  partial class FInputBinding : NativeStructWrapper
	{
		internal FInputBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputBinding() :
			base(E_CreateStruct_FInputBinding(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputBinding_bConsumeInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputBinding_bConsumeInput_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputBinding_bExecuteWhenPaused_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputBinding_bExecuteWhenPaused_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputBinding();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether the binding should consume the input or allow it to pass to another component
		/// </summary>
		public byte bConsumeInput
		{
			get => E_PROP_FInputBinding_bConsumeInput_GET(NativePointer);
			set => E_PROP_FInputBinding_bConsumeInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the binding should execute while paused
		/// </summary>
		public byte bExecuteWhenPaused
		{
			get => E_PROP_FInputBinding_bExecuteWhenPaused_GET(NativePointer);
			set => E_PROP_FInputBinding_bExecuteWhenPaused_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputBinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputBinding(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInputBinding(Adress, false);
		}}}
