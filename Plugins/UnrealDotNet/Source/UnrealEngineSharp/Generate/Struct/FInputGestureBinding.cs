// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:601

namespace UnrealEngine
{
	public  partial class FInputGestureBinding : FInputBinding
	{
		internal FInputGestureBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputGestureBinding() :
			base(E_CreateStruct_FInputGestureBinding(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputGestureBinding_GestureValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputGestureBinding_GestureValue_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputGestureBinding();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Value parameter, meaning is dependent on the gesture.
		/// </summary>
		public float GestureValue
		{
			get => E_PROP_FInputGestureBinding_GestureValue_GET(NativePointer);
			set => E_PROP_FInputGestureBinding_GestureValue_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputGestureBinding self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInputGestureBinding(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInputGestureBinding(Adress, false);
		}}}
