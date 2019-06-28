// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnActionsComponent.h:17

namespace UnrealEngine
{
	public partial class FPawnActionEvent : NativeStructWrapper
	{
		public FPawnActionEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPawnActionEvent() :
			base(E_CreateStruct_FPawnActionEvent(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FPawnActionEvent_Action_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPawnActionEvent_Action_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPawnActionEvent_FakeActionIndex_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPawnActionEvent();
		
		#endregion
		
		#region Property
		public UPawnAction Action
		{
			get => E_PROP_FPawnActionEvent_Action_GET(NativePointer);
			set => E_PROP_FPawnActionEvent_Action_SET(NativePointer, value);
		}

		public static int FakeActionIndex
		{
			get => E_PROP_FPawnActionEvent_FakeActionIndex_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(FPawnActionEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPawnActionEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPawnActionEvent(adress, false);
		}}}
