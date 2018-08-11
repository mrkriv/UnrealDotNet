using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

namespace UnrealEngine
{
	public  partial class UInterpToMovementComponent : UMovementComponent
	{
		public UInterpToMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInterpToMovementComponent(UObject Parent = null, string Name = "InterpToMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInterpToMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInterpToMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UInterpToMovementComponent_CalculateNewTime(IntPtr Self, float TimeNow, float Delta, IntPtr HitResult, bool InBroadcastEvent, bool OutStopped, float OutTimeRemainder);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInterpToMovementComponent_ComputeMoveDelta(IntPtr Self, float Time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_HandleHitWall(IntPtr Self, IntPtr Hit, float TimeTick, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_ReverseDirection(IntPtr Self, IntPtr Hit, float Time, bool InBroadcastEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_UpdateControlPoints(IntPtr Self, bool InForceUpdate);
		
		#endregion
		
		#region ExternMethods
		protected float CalculateNewTime(float TimeNow, float Delta, FHitResult HitResult, bool InBroadcastEvent, bool OutStopped, float OutTimeRemainder)
			=> E_UInterpToMovementComponent_CalculateNewTime(this, TimeNow, Delta, HitResult, InBroadcastEvent, OutStopped, OutTimeRemainder);
		
		
		/// <summary>
		/// <para>Compute the distance for the given time. </para>
		/// </summary>
		protected virtual FVector ComputeMoveDelta(float Time)
			=> E_UInterpToMovementComponent_ComputeMoveDelta(this, Time);
		
		
		/// <summary>
		/// <return>true if the simulation should stop. </return>
		/// </summary>
		protected bool HandleHitWall(FHitResult Hit, float TimeTick, FVector MoveDelta)
			=> E_UInterpToMovementComponent_HandleHitWall(this, Hit, TimeTick, MoveDelta);
		
		protected void ReverseDirection(FHitResult Hit, float Time, bool InBroadcastEvent)
			=> E_UInterpToMovementComponent_ReverseDirection(this, Hit, Time, InBroadcastEvent);
		
		protected virtual void UpdateControlPoints(bool InForceUpdate)
			=> E_UInterpToMovementComponent_UpdateControlPoints(this, InForceUpdate);
		
		#endregion
		
		public static implicit operator IntPtr(UInterpToMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UInterpToMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInterpToMovementComponent>(PtrDesc);
		}}}
