using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	public  partial class UProjectileMovementComponent : UMovementComponent
	{
		public UProjectileMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UProjectileMovementComponent(UObject Parent = null, string Name = "ProjectileMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UProjectileMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UProjectileMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeAcceleration(IntPtr Self, IntPtr InVelocity, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeBounceResult(IntPtr Self, IntPtr Hit, float TimeSlice, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeHomingAcceleration(IntPtr Self, IntPtr InVelocity, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeMoveDelta(IntPtr Self, IntPtr InVelocity, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UProjectileMovementComponent_GetEffectiveGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UProjectileMovementComponent_HandleBlockingHit(IntPtr Self, IntPtr Hit, float TimeTick, IntPtr MoveDelta, float SubTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_HandleSliding(IntPtr Self, IntPtr Hit, float SubTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_LimitVelocity(IntPtr Self, IntPtr NewVelocity);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Compute the acceleration that will be applied </para>
		/// </summary>
		protected virtual FVector ComputeAcceleration(FVector InVelocity, float DeltaTime)
			=> E_UProjectileMovementComponent_ComputeAcceleration(this, InVelocity, DeltaTime);
		
		
		/// <summary>
		/// <para>Computes result of a bounce and returns the new velocity. </para>
		/// </summary>
		protected virtual FVector ComputeBounceResult(FHitResult Hit, float TimeSlice, FVector MoveDelta)
			=> E_UProjectileMovementComponent_ComputeBounceResult(this, Hit, TimeSlice, MoveDelta);
		
		
		/// <summary>
		/// <para>Allow the projectile to track towards its homing target. </para>
		/// </summary>
		protected virtual FVector ComputeHomingAcceleration(FVector InVelocity, float DeltaTime)
			=> E_UProjectileMovementComponent_ComputeHomingAcceleration(this, InVelocity, DeltaTime);
		
		
		/// <summary>
		/// <para>Compute the distance we should move in the given time, at a given a velocity. </para>
		/// </summary>
		protected virtual FVector ComputeMoveDelta(FVector InVelocity, float DeltaTime)
			=> E_UProjectileMovementComponent_ComputeMoveDelta(this, InVelocity, DeltaTime);
		
		protected float GetEffectiveGravityZ()
			=> E_UProjectileMovementComponent_GetEffectiveGravityZ(this);
		
		
		/// <summary>
		/// <para>Handle blocking hit during simulation update. Checks that simulation remains valid after collision. </para>
		/// <para>If simulating then calls HandleImpact(), and returns EHandleHitWallResult::Deflect by default to enable multi-bounce and sliding support through HandleDeflection(). </para>
		/// <para>If no longer simulating then returns EHandleHitWallResult::Abort, which aborts attempts at further simulation. </para>
		/// <param name="Hit">Blocking hit that occurred. </param>
		/// <param name="TimeTick">Time delta of last move that resulted in the blocking hit. </param>
		/// <param name="MoveDelta">Movement delta for the current sub-step. </param>
		/// <param name="SubTickTimeRemaining">How much time to continue simulating in the current sub-step, which may change as a result of this function. </param>
		/// <para>Initial default value is: TimeTick * (1.f - Hit.Time) </para>
		/// <return>Result indicating how simulation should proceed. </return>
		/// <para>@see EHandleHitWallResult, HandleImpact() </para>
		/// </summary>
		protected virtual EHandleBlockingHitResult HandleBlockingHit(FHitResult Hit, float TimeTick, FVector MoveDelta, float SubTickTimeRemaining)
			=> (EHandleBlockingHitResult)E_UProjectileMovementComponent_HandleBlockingHit(this, Hit, TimeTick, MoveDelta, SubTickTimeRemaining);
		
		
		/// <summary>
		/// <para>Handle case where projectile is sliding along a surface. </para>
		/// <para>Velocity will be parallel to the impact surface upon entry to this method. </para>
		/// <param name="InitialHit">Hit result of impact causing slide. May be modified by this function to reflect any subsequent movement. </param>
		/// <param name="SubTickTimeRemaining">Time remaining in the tick. This function may update this time with any reduction to the simulation time requested. </param>
		/// <return>True if simulation of the projectile should continue, false otherwise. </return>
		/// </summary>
		protected virtual bool HandleSliding(FHitResult Hit, float SubTickTimeRemaining)
			=> E_UProjectileMovementComponent_HandleSliding(this, Hit, SubTickTimeRemaining);
		
		
		/// <summary>
		/// <para>Don't allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero. </para>
		/// </summary>
		protected FVector LimitVelocity(FVector NewVelocity)
			=> E_UProjectileMovementComponent_LimitVelocity(this, NewVelocity);
		
		#endregion
		
		public static implicit operator IntPtr(UProjectileMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UProjectileMovementComponent>(PtrDesc);
		}}}
