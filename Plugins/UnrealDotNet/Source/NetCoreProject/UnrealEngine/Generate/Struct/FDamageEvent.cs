using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2576

namespace UnrealEngine
{
	public  partial class FDamageEvent : NativeStructWrapper
	{
		internal FDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FDamageEvent() :
			base(E_CreateStruct_FDamageEvent(), false)
		{
		}

		public FDamageEvent(FDamageEvent InDamageEvent) :
			base(E_CreateStruct_FDamageEvent_FDamageEvent(InDamageEvent), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDamageEvent_FDamageEvent(IntPtr InDamageEvent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FDamageEvent_GetBestHitInfo(IntPtr Self, IntPtr HitActor, IntPtr HitInstigator, IntPtr OutHitInfo, IntPtr OutImpulseDir);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FDamageEvent_GetTypeID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FDamageEvent_IsOfType(IntPtr Self, int InID);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This is for compatibility with old-style functions which want a unified set of hit data regardless of type of hit.  Ideally this will go away over time. </para>
		/// </summary>
		public virtual void GetBestHitInfo(AActor HitActor, AActor HitInstigator, FHitResult OutHitInfo, FVector OutImpulseDir)
			=> E_FDamageEvent_GetBestHitInfo(this, HitActor, HitInstigator, OutHitInfo, OutImpulseDir);
		
		public virtual int GetTypeID()
			=> E_FDamageEvent_GetTypeID(this);
		
		public virtual bool IsOfType(int InID)
			=> E_FDamageEvent_IsOfType(this, InID);
		
		#endregion
		
		public static implicit operator IntPtr(FDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDamageEvent(Adress, false);
		}}}
