// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:537

namespace UnrealEngine
{
	public  partial class FInputVectorAxisBinding : FInputBinding
	{
		internal FInputVectorAxisBinding(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInputVectorAxisBinding() :
			base(E_CreateStruct_FInputVectorAxisBinding(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FInputVectorAxisBinding_AxisValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputVectorAxisBinding_AxisValue_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputVectorAxisBinding();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The value of the axis as calculated during the most recent UPlayerInput::ProcessInputStack </para>
		/// <para>if the InputComponent containing the binding was in the stack, otherwise the value will be (0,0,0). </para>
		/// </summary>
		public FVector AxisValue
		{
			get => E_PROP_FInputVectorAxisBinding_AxisValue_GET(NativePointer);
			set => E_PROP_FInputVectorAxisBinding_AxisValue_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputVectorAxisBinding self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInputVectorAxisBinding(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInputVectorAxisBinding(Adress, false);
		}}}
