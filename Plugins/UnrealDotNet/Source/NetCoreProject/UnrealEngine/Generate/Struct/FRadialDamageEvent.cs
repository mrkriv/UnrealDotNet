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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRadialDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRadialDamageEvent_Params_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRadialDamageEvent_Params_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRadialDamageEvent_GetBestHitInfo(IntPtr Self, IntPtr HitActor, IntPtr HitInstigator, IntPtr OutHitInfo, IntPtr OutImpulseDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FRadialDamageEvent_GetTypeID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRadialDamageEvent_IsOfType(IntPtr Self, int InID);
		
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
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Simple API for common cases where we are happy to assume a single hit is expected, even though damage event may have multiple hits. </para>
		/// </summary>
		public override void GetBestHitInfo(AActor HitActor, AActor HitInstigator, FHitResult OutHitInfo, FVector OutImpulseDir)
			=> E_FRadialDamageEvent_GetBestHitInfo(this, HitActor, HitInstigator, OutHitInfo, OutImpulseDir);
		
		public override int GetTypeID()
			=> E_FRadialDamageEvent_GetTypeID(this);
		
		public override bool IsOfType(int InID)
			=> E_FRadialDamageEvent_IsOfType(this, InID);
		
		#endregion
		
		public static implicit operator IntPtr(FRadialDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRadialDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRadialDamageEvent(Adress, false);
		}}}
