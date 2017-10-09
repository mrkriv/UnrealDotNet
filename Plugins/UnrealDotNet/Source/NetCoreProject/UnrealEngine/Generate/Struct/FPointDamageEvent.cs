using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2611

namespace UnrealEngine
{
	public  partial class FPointDamageEvent : FDamageEvent
	{
		internal FPointDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPointDamageEvent() :
			base(E_CreateStruct_FPointDamageEvent(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPointDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPointDamageEvent_Damage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_Damage_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float Damage
		{
			get => E_PROP_FPointDamageEvent_Damage_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_Damage_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPointDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPointDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPointDamageEvent(Adress, false);
		}}}
