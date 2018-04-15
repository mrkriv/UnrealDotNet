using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2693

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Params_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Params_SET(IntPtr Ptr, IntPtr Value);
		
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
		
		public static implicit operator IntPtr(FRadialDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRadialDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRadialDamageEvent(Adress, false);
		}}}
