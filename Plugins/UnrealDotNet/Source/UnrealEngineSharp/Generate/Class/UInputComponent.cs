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
		/// <para>Whether any components lower on the input stack should be allowed to receive input. </para>
		/// </summary>
		public byte bBlockInput
		{
			get => E_PROP_UInputComponent_bBlockInput_GET(NativePointer);
			set => E_PROP_UInputComponent_bBlockInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The priority of this input component when pushed in to the stack. </para>
		/// </summary>
		public int Priority
		{
			get => E_PROP_UInputComponent_Priority_GET(NativePointer);
			set => E_PROP_UInputComponent_Priority_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds the specified action binding. </para>
		/// <param name="Binding">The binding to add. </param>
		/// <return>The last binding in the list. </return>
		/// <para>@see ClearActionBindings, GetActionBinding, GetNumActionBindings, RemoveActionBinding </para>
		/// </summary>
		public FInputActionBinding AddActionBinding(FInputActionBinding binding)
			=> E_UInputComponent_AddActionBinding(this, binding);
		
		
		/// <summary>
		/// <para>Indicates that the InputComponent is interested in knowing the Axis value </para>
		/// <para>(via GetAxisValue) but does not want a delegate function called each frame. </para>
		/// <para>Returned reference is only guaranteed to be valid until another axis is bound. </para>
		/// </summary>
		public FInputAxisBinding BindAxis(string axisName)
			=> E_UInputComponent_BindAxis(this, axisName);
		
		
		/// <summary>
		/// <para>Removes all action bindings. </para>
		/// <para>@see AddActionBinding, GetActionBinding, GetNumActionBindings, RemoveActionBinding </para>
		/// </summary>
		public void ClearActionBindings()
			=> E_UInputComponent_ClearActionBindings(this);
		
		
		/// <summary>
		/// <para>Clears all cached binding values. </para>
		/// </summary>
		public void ClearBindingValues()
			=> E_UInputComponent_ClearBindingValues(this);
		
		public void ConditionalBuildKeyMap(UPlayerInput playerInput)
			=> E_UInputComponent_ConditionalBuildKeyMap(this, playerInput);
		
		
		/// <summary>
		/// <para>Gets the action binding with the specified index. </para>
		/// <param name="BindingIndex">The index of the binding to get. </param>
		/// <para>@see AddActionBinding, ClearActionBindings, GetNumActionBindings, RemoveActionBinding </para>
		/// </summary>
		public FInputActionBinding GetActionBinding(int bindingIndex)
			=> E_UInputComponent_GetActionBinding(this, bindingIndex);
		
		
		/// <summary>
		/// <para>Gets the current value of the axis with the specified name. </para>
		/// <param name="AxisName">The name of the axis. </param>
		/// <return>Axis value. </return>
		/// <para>@see GetAxisKeyValue, GetVectorAxisValue </para>
		/// </summary>
		public float GetAxisValue(string axisName)
			=> E_UInputComponent_GetAxisValue(this, axisName);
		
		
		/// <summary>
		/// <para>Gets the number of action bindings. </para>
		/// <return>Number of bindings. </return>
		/// <para>@see AddActionBinding, ClearActionBindings, GetActionBinding, RemoveActionBinding </para>
		/// </summary>
		public int GetNumActionBindings()
			=> E_UInputComponent_GetNumActionBindings(this);
		
		
		/// <summary>
		/// <para>Checks whether this component has any input bindings. </para>
		/// <return>true if any bindings are set, false otherwise. </return>
		/// </summary>
		public bool HasBindings()
			=> E_UInputComponent_HasBindings(this);
		
		
		/// <summary>
		/// <para>Removes the action binding at the specified index. </para>
		/// <param name="BindingIndex">The index of the binding to remove. </param>
		/// <para>@see AddActionBinding, ClearActionBindings, GetActionBinding, GetNumActionBindings </para>
		/// </summary>
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
