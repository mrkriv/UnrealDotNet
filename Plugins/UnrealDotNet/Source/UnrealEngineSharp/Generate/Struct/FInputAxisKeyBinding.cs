// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:473

namespace UnrealEngine
{
	public partial class FInputAxisKeyBinding : FInputBinding
	{
		public FInputAxisKeyBinding(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInputAxisKeyBinding() :
			base(E_CreateStruct_FInputAxisKeyBinding(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisKeyBinding_AxisValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisKeyBinding_AxisValue_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputAxisKeyBinding();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The value of the axis as calculated during the most recent UPlayerInput::ProcessInputStack
		/// <para>if the InputComponent containing the binding was in the stack, otherwise the value will be 0. </para>
		/// </summary>
		public float AxisValue
		{
			get => E_PROP_FInputAxisKeyBinding_AxisValue_GET(NativePointer);
			set => E_PROP_FInputAxisKeyBinding_AxisValue_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputAxisKeyBinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputAxisKeyBinding(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputAxisKeyBinding(adress, false);
		}}}
