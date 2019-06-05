// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:129

namespace UnrealEngine
{
	public partial class FInputActionUnifiedDelegate : NativeStructWrapper
	{
		public FInputActionUnifiedDelegate(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInputActionUnifiedDelegate() :
			base(E_CreateStruct_FInputActionUnifiedDelegate(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputActionUnifiedDelegate();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FInputActionUnifiedDelegate_BindDelegate(IntPtr self, IntPtr @object, string funcName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FInputActionUnifiedDelegate_IsBound(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FInputActionUnifiedDelegate_Unbind(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Binds a dynamic delegate and unbinds any bound native delegate
		/// </summary>
		public void BindDelegate(UObject @object, string funcName)
			=> E_FInputActionUnifiedDelegate_BindDelegate(this, @object, funcName);
		
		
		/// <summary>
		/// Returns if either the native or dynamic delegate is bound
		/// </summary>
		public bool IsBound()
			=> E_FInputActionUnifiedDelegate_IsBound(this);
		
		
		/// <summary>
		/// Unbinds any bound delegates
		/// </summary>
		public void Unbind()
			=> E_FInputActionUnifiedDelegate_Unbind(this);
		
		#endregion
		
		public static implicit operator IntPtr(FInputActionUnifiedDelegate self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputActionUnifiedDelegate(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputActionUnifiedDelegate(adress, false);
		}}}
