// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:675

namespace UnrealEngine
{
	public  partial class UInputComponent : UActorComponent
	{
		public UInputComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInputComponent(UObject Parent = null, string Name = "InputComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInputComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputComponent_bBlockInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputComponent_bBlockInput_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UInputComponent_Priority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputComponent_Priority_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInputComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInputComponent_AddActionBinding(IntPtr self, IntPtr binding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInputComponent_BindAxis(IntPtr self, string axisName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputComponent_ClearActionBindings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputComponent_ClearBindingValues(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputComponent_ConditionalBuildKeyMap(IntPtr self, IntPtr playerInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInputComponent_GetActionBinding(IntPtr self, int bindingIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UInputComponent_GetAxisValue(IntPtr self, string axisName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UInputComponent_GetNumActionBindings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInputComponent_HasBindings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputComponent_RemoveActionBinding(IntPtr self, int bindingIndex);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether any components lower on the input stack should be allowed to receive input.
		/// </summary>
		public byte bBlockInput
		{
			get => E_PROP_UInputComponent_bBlockInput_GET(NativePointer);
			set => E_PROP_UInputComponent_bBlockInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The priority of this input component when pushed in to the stack.
		/// </summary>
		public int Priority
		{
			get => E_PROP_UInputComponent_Priority_GET(NativePointer);
			set => E_PROP_UInputComponent_Priority_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds the specified action binding.
		/// <see cref="ClearActionBindings"/>
		/// </summary>
		/// <param name="binding">The binding to add.</param>
		/// <return>The</return>
		public FInputActionBinding AddActionBinding(FInputActionBinding binding)
			=> E_UInputComponent_AddActionBinding(this, binding);
		
		
		/// <summary>
		/// Indicates that the InputComponent is interested in knowing the Axis value
		/// <para>(via GetAxisValue) but does not want a delegate function called each frame. </para>
		/// Returned reference is only guaranteed to be valid until another axis is bound.
		/// </summary>
		public FInputAxisBinding BindAxis(string axisName)
			=> E_UInputComponent_BindAxis(this, axisName);
		
		
		/// <summary>
		/// Removes all action bindings.
		/// <see cref="AddActionBinding"/>
		/// </summary>
		public void ClearActionBindings()
			=> E_UInputComponent_ClearActionBindings(this);
		
		
		/// <summary>
		/// Clears all cached binding values.
		/// </summary>
		public void ClearBindingValues()
			=> E_UInputComponent_ClearBindingValues(this);
		
		public void ConditionalBuildKeyMap(UPlayerInput playerInput)
			=> E_UInputComponent_ConditionalBuildKeyMap(this, playerInput);
		
		
		/// <summary>
		/// Gets the action binding with the specified index.
		/// <see cref="AddActionBinding"/>
		/// </summary>
		/// <param name="bindingIndex">The index of the binding to get.</param>
		public FInputActionBinding GetActionBinding(int bindingIndex)
			=> E_UInputComponent_GetActionBinding(this, bindingIndex);
		
		
		/// <summary>
		/// Gets the current value of the axis with the specified name.
		/// <see cref="GetAxisKeyValue"/>
		/// </summary>
		/// <param name="axisName">The name of the axis.</param>
		/// <return>Axis</return>
		public float GetAxisValue(string axisName)
			=> E_UInputComponent_GetAxisValue(this, axisName);
		
		
		/// <summary>
		/// Gets the number of action bindings.
		/// <see cref="AddActionBinding"/>
		/// </summary>
		/// <return>Number</return>
		public int GetNumActionBindings()
			=> E_UInputComponent_GetNumActionBindings(this);
		
		
		/// <summary>
		/// Checks whether this component has any input bindings.
		/// </summary>
		/// <return>true</return>
		public bool HasBindings()
			=> E_UInputComponent_HasBindings(this);
		
		
		/// <summary>
		/// Removes the action binding at the specified index.
		/// <see cref="AddActionBinding"/>
		/// </summary>
		/// <param name="bindingIndex">The index of the binding to remove.</param>
		public void RemoveActionBinding(int bindingIndex)
			=> E_UInputComponent_RemoveActionBinding(this, bindingIndex);
		
		#endregion
		
		public static implicit operator IntPtr(UInputComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UInputComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInputComponent>(PtrDesc);
		}}}
