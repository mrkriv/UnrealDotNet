// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2694

namespace UnrealEngine
{
	public  partial class FRadialDamageEvent : FDamageEvent
	{
		internal FRadialDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRadialDamageEvent() :
			base(E_CreateStruct_FRadialDamageEvent(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Params_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Params_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageEvent();
		
		#endregion
		
		#region Property
		public FVector Origin
		{
			get => E_PROP_FRadialDamageEvent_Origin_GET(NativePointer);
			set => E_PROP_FRadialDamageEvent_Origin_SET(NativePointer, value);
		}

		public FRadialDamageParams Params
		{
			get => E_PROP_FRadialDamageEvent_Params_GET(NativePointer);
			set => E_PROP_FRadialDamageEvent_Params_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRadialDamageEvent self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRadialDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRadialDamageEvent(Adress, false);
		}}}
