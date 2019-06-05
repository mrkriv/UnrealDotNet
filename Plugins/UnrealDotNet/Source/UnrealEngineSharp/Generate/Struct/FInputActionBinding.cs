// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:291

namespace UnrealEngine
{
	public partial class FInputActionBinding : FInputBinding
	{
		public FInputActionBinding(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInputActionBinding() :
			base(E_CreateStruct_FInputActionBinding(), false)
		{
		}

		public FInputActionBinding(string inActionName, EInputEvent inKeyEvent) :
			base(E_CreateStruct_FInputActionBinding_FName_EInputEvent(inActionName, (byte)inKeyEvent), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FInputActionBinding_ActionDelegate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionBinding_ActionDelegate_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputActionBinding();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputActionBinding_FName_EInputEvent(string inActionName, byte inKeyEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FInputActionBinding_GetActionName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FInputActionBinding_IsPaired(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The delegate bound to the action
		/// </summary>
		public FInputActionUnifiedDelegate ActionDelegate
		{
			get => E_PROP_FInputActionBinding_ActionDelegate_GET(NativePointer);
			set => E_PROP_FInputActionBinding_ActionDelegate_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public string GetActionName()
			=> E_FInputActionBinding_GetActionName(this);
		
		public bool IsPaired()
			=> E_FInputActionBinding_IsPaired(this);
		
		#endregion
		
		public static implicit operator IntPtr(FInputActionBinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputActionBinding(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputActionBinding(adress, false);
		}}}
