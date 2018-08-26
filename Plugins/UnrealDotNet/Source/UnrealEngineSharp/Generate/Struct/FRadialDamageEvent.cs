// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2733

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FRadialDamageEvent_ComponentHits_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_ComponentHits_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Params_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Params_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public TArray<FHitResult> ComponentHits
		{
			get => E_PROP_FRadialDamageEvent_ComponentHits_GET(NativePointer);
			set => E_PROP_FRadialDamageEvent_ComponentHits_SET(NativePointer, value);
		}

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
