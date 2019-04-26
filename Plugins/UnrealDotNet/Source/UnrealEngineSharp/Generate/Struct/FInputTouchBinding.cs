// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:386

namespace UnrealEngine
{
	public  partial class FInputTouchBinding : FInputBinding
	{
		internal FInputTouchBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputTouchBinding() :
			base(E_CreateStruct_FInputTouchBinding(), false)
		{
		}

		public FInputTouchBinding(EInputEvent inKeyEvent) :
			base(E_CreateStruct_FInputTouchBinding_EInputEvent((byte)inKeyEvent), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputTouchBinding();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputTouchBinding_EInputEvent(byte inKeyEvent);
		
		#endregion
		
		public static implicit operator IntPtr(FInputTouchBinding self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInputTouchBinding(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInputTouchBinding(Adress, false);
		}}}
