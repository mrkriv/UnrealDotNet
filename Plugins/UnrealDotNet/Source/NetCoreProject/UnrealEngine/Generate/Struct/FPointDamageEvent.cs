using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2618

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPointDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPointDamageEvent_Damage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_Damage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPointDamageEvent_HitInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_HitInfo_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPointDamageEvent_GetBestHitInfo(IntPtr Self, IntPtr HitActor, IntPtr HitInstigator, IntPtr OutHitInfo, IntPtr OutImpulseDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FPointDamageEvent_GetTypeID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPointDamageEvent_IsOfType(IntPtr Self, int InID);
		
		#endregion
		
		#region Property
		public float Damage
		{
			get => E_PROP_FPointDamageEvent_Damage_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_Damage_SET(NativePointer, value);
		}

		public FHitResult HitInfo
		{
			get => E_PROP_FPointDamageEvent_HitInfo_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_HitInfo_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Simple API for common cases where we are happy to assume a single hit is expected, even though damage event may have multiple hits. </para>
		/// </summary>
		public override void GetBestHitInfo(AActor HitActor, AActor HitInstigator, FHitResult OutHitInfo, FVector OutImpulseDir)
			=> E_FPointDamageEvent_GetBestHitInfo(this, HitActor, HitInstigator, OutHitInfo, OutImpulseDir);
		
		public override int GetTypeID()
			=> E_FPointDamageEvent_GetTypeID(this);
		
		public override bool IsOfType(int InID)
			=> E_FPointDamageEvent_IsOfType(this, InID);
		
		#endregion
		
		public static implicit operator IntPtr(FPointDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPointDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPointDamageEvent(Adress, false);
		}}}
