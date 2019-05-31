// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:440

namespace UnrealEngine
{
	public  partial class FInputAxisBinding : FInputBinding
	{
		internal FInputAxisBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputAxisBinding() :
			base(E_CreateStruct_FInputAxisBinding(), false)
		{
		}

		public FInputAxisBinding(string inAxisName) :
			base(E_CreateStruct_FInputAxisBinding_FName(inAxisName), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FInputAxisBinding_AxisName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisBinding_AxisName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FInputAxisBinding_AxisValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputAxisBinding_AxisValue_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputAxisBinding();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputAxisBinding_FName(string inAxisName);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The axis mapping being bound to.
		/// </summary>
		public string AxisName
		{
			get => E_PROP_FInputAxisBinding_AxisName_GET(NativePointer);
			set => E_PROP_FInputAxisBinding_AxisName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The value of the axis as calculated during the most recent UPlayerInput::ProcessInputStack
		/// <para>if the InputComponent was in the stack, otherwise all values should be 0. </para>
		/// </summary>
		public float AxisValue
		{
			get => E_PROP_FInputAxisBinding_AxisValue_GET(NativePointer);
			set => E_PROP_FInputAxisBinding_AxisValue_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputAxisBinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputAxisBinding(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputAxisBinding(adress, false);
		}}}
