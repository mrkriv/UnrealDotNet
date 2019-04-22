// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_Bounciness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_Bounciness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_Buoyancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_Buoyancy_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_Friction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_Friction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_InterpLocationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_InterpLocationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_InterpRotationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_InterpRotationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UProjectileMovementComponent_MaxSimulationIterations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_MaxSimulationIterations_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_MinFrictionFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_MinFrictionFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UProjectileMovementComponent_PreviousHitNormal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_PreviousHitNormal_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_PreviousHitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_PreviousHitTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UProjectileMovementComponent_ProjectileGravityScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_ProjectileGravityScale_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UProjectileMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_CheckStillInWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeAcceleration(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeBounceResult(IntPtr self, IntPtr hit, float timeSlice, IntPtr moveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeHomingAcceleration(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeMoveDelta(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeVelocity(IntPtr self, IntPtr initialVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UProjectileMovementComponent_GetBuoyancy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UProjectileMovementComponent_GetInterpolatedComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UProjectileMovementComponent_GetSimulationTimeStep(IntPtr self, float remainingTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UProjectileMovementComponent_HandleBlockingHit(IntPtr self, IntPtr hit, float timeTick, IntPtr moveDelta, float subTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_HandleSliding(IntPtr self, IntPtr hit, float subTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_HasStoppedSimulation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_IsInterpolationComplete(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_IsVelocityUnderSimulationThreshold(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_LimitVelocity(IntPtr self, IntPtr newVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_MoveInterpolationTarget(IntPtr self, IntPtr newLocation, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_ResetInterpolation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_SetInterpolatedComponent(IntPtr self, IntPtr component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_SetVelocityInLocalSpace(IntPtr self, IntPtr newVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_ShouldApplyGravity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_ShouldUseSubStepping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_StopSimulating(IntPtr self, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UProjectileMovementComponent_TickInterpolation(IntPtr self, float deltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>On the first few bounces (up to this amount), allow extra iterations over MaxSimulationIterations if necessary. </para>
		/// </summary>
		public int BounceAdditionalIterations
		{
			get => E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event. </para>
		/// <para>Ignored if bShouldBounce is false, in which case the projectile stops simulating on the first impact. </para>
		/// <para>@see StopSimulating(), OnProjectileStop </para>
		/// </summary>
		public float BounceVelocityStopSimulatingThreshold
		{
			get => E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution). </para>
		/// <para>1.0 = no velocity lost, 0.0 = no bounce. Ignored if bShouldBounce is false. </para>
		/// </summary>
		public float Bounciness
		{
			get => E_PROP_UProjectileMovementComponent_Bounciness_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Bounciness_SET(NativePointer, value);
		}

		public float Buoyancy
		{
			get => E_PROP_UProjectileMovementComponent_Buoyancy_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Buoyancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Coefficient of friction, affecting the resistance to sliding along a surface. </para>
		/// <para>Normal range is [0,1] : 0.0 = no friction, 1.0+ = very high friction. </para>
		/// <para>Also affects the percentage of velocity maintained after the bounce in the direction tangent to the normal of impact. </para>
		/// <para>Ignored if bShouldBounce is false. </para>
		/// <para>@see bBounceAngleAffectsFriction </para>
		/// </summary>
		public float Friction
		{
			get => E_PROP_UProjectileMovementComponent_Friction_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Friction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed. </para>
		/// </summary>
		public float HomingAccelerationMagnitude
		{
			get => E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance behind UpdatedComponent which the interpolated component is allowed to lag. </para>
		/// </summary>
		public float InterpLocationMaxLagDistance
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance behind UpdatedComponent beyond which the interpolated component is snapped to the target location instead. </para>
		/// <para>For instance if the target teleports this far beyond the interpolated component, the interpolation is snapped to match the target. </para>
		/// </summary>
		public float InterpLocationSnapToTargetDistance
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>"Time" over which most of the location interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component. </para>
		/// <para>Since the implementation uses exponential lagged smoothing, this is a rough time value and experimentation should inform a final result. </para>
		/// <para>A value of zero is effectively instantaneous interpolation. </para>
		/// </summary>
		public float InterpLocationTime
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>"Time" over which most of the rotation interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component. </para>
		/// <para>Since the implementation uses exponential lagged smoothing, this is a rough time value and experimentation should inform a final result. </para>
		/// <para>A value of zero is effectively instantaneous interpolation. </para>
		/// </summary>
		public float InterpRotationTime
		{
			get => E_PROP_UProjectileMovementComponent_InterpRotationTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max number of iterations used for each discrete simulation step. </para>
		/// <para>Increasing this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// <para>@see MaxSimulationTimeStep, bForceSubStepping </para>
		/// </summary>
		public int MaxSimulationIterations
		{
			get => E_PROP_UProjectileMovementComponent_MaxSimulationIterations_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MaxSimulationIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max time delta for each discrete simulation step. </para>
		/// <para>Lowering this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// <para>@see MaxSimulationIterations, bForceSubStepping </para>
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get => E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When bounce angle affects friction, apply at least this fraction of normal friction. </para>
		/// <para>Helps consistently slow objects sliding or rolling along surfaces or in valleys when the usual friction amount would take a very long time to settle. </para>
		/// </summary>
		public float MinFrictionFraction
		{
			get => E_PROP_UProjectileMovementComponent_MinFrictionFraction_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MinFrictionFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step. </para>
		/// </summary>
		public FVector PreviousHitNormal
		{
			get => E_PROP_UProjectileMovementComponent_PreviousHitNormal_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_PreviousHitNormal_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact. </para>
		/// </summary>
		public float PreviousHitTime
		{
			get => E_PROP_UProjectileMovementComponent_PreviousHitTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_PreviousHitTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Custom gravity scale for this projectile. Set to 0 for no gravity. </para>
		/// </summary>
		public float ProjectileGravityScale
		{
			get => E_PROP_UProjectileMovementComponent_ProjectileGravityScale_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_ProjectileGravityScale_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This will check to see if the projectile is still in the world.  It will check things like </para>
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public virtual bool CheckStillInWorld()
			=> E_UProjectileMovementComponent_CheckStillInWorld(this);
		
		
		/// <summary>
		/// <para>Compute the acceleration that will be applied </para>
		/// </summary>
		protected virtual FVector ComputeAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Computes result of a bounce and returns the new velocity. </para>
		/// </summary>
		protected virtual FVector ComputeBounceResult(FHitResult hit, float timeSlice, FVector moveDelta)
			=> E_UProjectileMovementComponent_ComputeBounceResult(this, hit, timeSlice, moveDelta);
		
		
		/// <summary>
		/// <para>Allow the projectile to track towards its homing target. </para>
		/// </summary>
		protected virtual FVector ComputeHomingAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeHomingAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Compute the distance we should move in the given time, at a given a velocity. </para>
		/// </summary>
		protected virtual FVector ComputeMoveDelta(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeMoveDelta(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Given an initial velocity and a time step, compute a new velocity. </para>
		/// <para>Default implementation applies the result of ComputeAcceleration() to velocity. </para>
		/// <param name="InitialVelocity">Initial velocity. </param>
		/// <param name="DeltaTime">Time step of the update. </param>
		/// <return>Velocity after DeltaTime time step. </return>
		/// </summary>
		public virtual FVector ComputeVelocity(FVector initialVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeVelocity(this, initialVelocity, deltaTime);
		
		
		/// <summary>
		/// <return>Buoyancy of UpdatedComponent in fluid.  0.0=sinks as fast as in air, 1.0=neutral buoyancy </return>
		/// </summary>
		public float GetBuoyancy()
			=> E_UProjectileMovementComponent_GetBuoyancy(this);
		
		
		/// <summary>
		/// <para>Returns the component used for network interpolation. </para>
		/// </summary>
		public USceneComponent GetInterpolatedComponent()
			=> E_UProjectileMovementComponent_GetInterpolatedComponent(this);
		
		
		/// <summary>
		/// <para>Compute remaining time step given remaining time and current iterations. </para>
		/// <para>The last iteration (limited by MaxSimulationIterations) always returns the remaining time, which may violate MaxSimulationTimeStep. </para>
		/// <param name="RemainingTime">Remaining time in the tick. </param>
		/// <param name="Iterations">Current iteration of the tick (starting at 1). </param>
		/// <return>The remaining time step to use for the next sub-step of iteration. </return>
		/// <para>@see MaxSimulationTimeStep, MaxSimulationIterations </para>
		/// <para>@see ShouldUseSubStepping() </para>
		/// </summary>
		public float GetSimulationTimeStep(float remainingTime, int iterations)
			=> E_UProjectileMovementComponent_GetSimulationTimeStep(this, remainingTime, iterations);
		
		
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
		protected virtual EHandleBlockingHitResult HandleBlockingHit(FHitResult hit, float timeTick, FVector moveDelta, float subTickTimeRemaining)
			=> (EHandleBlockingHitResult)E_UProjectileMovementComponent_HandleBlockingHit(this, hit, timeTick, moveDelta, subTickTimeRemaining);
		
		
		/// <summary>
		/// <para>Handle case where projectile is sliding along a surface. </para>
		/// <para>Velocity will be parallel to the impact surface upon entry to this method. </para>
		/// <param name="InitialHit">Hit result of impact causing slide. May be modified by this function to reflect any subsequent movement. </param>
		/// <param name="SubTickTimeRemaining">Time remaining in the tick. This function may update this time with any reduction to the simulation time requested. </param>
		/// <return>True if simulation of the projectile should continue, false otherwise. </return>
		/// </summary>
		protected virtual bool HandleSliding(FHitResult hit, float subTickTimeRemaining)
			=> E_UProjectileMovementComponent_HandleSliding(this, hit, subTickTimeRemaining);
		
		public bool HasStoppedSimulation()
			=> E_UProjectileMovementComponent_HasStoppedSimulation(this);
		
		
		/// <summary>
		/// <para>Returns whether interpolation is complete because the target has been reached. True when interpolation is disabled. </para>
		/// </summary>
		public bool IsInterpolationComplete()
			=> E_UProjectileMovementComponent_IsInterpolationComplete(this);
		
		
		/// <summary>
		/// <para>Returns true if velocity magnitude is less than BounceVelocityStopSimulatingThreshold. </para>
		/// </summary>
		public bool IsVelocityUnderSimulationThreshold()
			=> E_UProjectileMovementComponent_IsVelocityUnderSimulationThreshold(this);
		
		
		/// <summary>
		/// <para>Don't allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero. </para>
		/// </summary>
		protected FVector LimitVelocity(FVector newVelocity)
			=> E_UProjectileMovementComponent_LimitVelocity(this, newVelocity);
		
		
		/// <summary>
		/// <para>Moves the UpdatedComponent, which is also the interpolation target for the interpolated component. If there is not interpolated component, this simply moves UpdatedComponent. </para>
		/// <para>Use this typically from PostNetReceiveLocationAndRotation() or similar from an Actor. </para>
		/// </summary>
		public virtual void MoveInterpolationTarget(FVector newLocation, FRotator newRotation)
			=> E_UProjectileMovementComponent_MoveInterpolationTarget(this, newLocation, newRotation);
		
		
		/// <summary>
		/// <para>Resets interpolation so that interpolated component snaps back to the initial location/rotation without any additional offsets. </para>
		/// </summary>
		public virtual void ResetInterpolation()
			=> E_UProjectileMovementComponent_ResetInterpolation(this);
		
		
		/// <summary>
		/// <para>Assigns the component that will be used for network interpolation/smoothing. It is expected that this is a component attached somewhere below the UpdatedComponent. </para>
		/// <para>When network updates use MoveInterpolationTarget() to move the UpdatedComponent, the interpolated component's relative offset will be maintained and smoothed over </para>
		/// <para>the course of future component ticks. The current relative location and rotation of the component is saved as the target offset for future interpolation. </para>
		/// <para>@see MoveInterpolationTarget(), bInterpMovement, bInterpRotation </para>
		/// </summary>
		public virtual void SetInterpolatedComponent(USceneComponent component)
			=> E_UProjectileMovementComponent_SetInterpolatedComponent(this, component);
		
		
		/// <summary>
		/// <para>Sets the velocity to the new value, rotated into Actor space. </para>
		/// </summary>
		public virtual void SetVelocityInLocalSpace(FVector newVelocity)
			=> E_UProjectileMovementComponent_SetVelocityInLocalSpace(this, newVelocity);
		
		public bool ShouldApplyGravity()
			=> E_UProjectileMovementComponent_ShouldApplyGravity(this);
		
		
		/// <summary>
		/// <para>Determine whether or not to use substepping in the projectile motion update. </para>
		/// <para>If true, GetSimulationTimeStep() will be used to time-slice the update. If false, all remaining time will be used during the tick. </para>
		/// <return>Whether or not to use substepping in the projectile motion update. </return>
		/// <para>@see GetSimulationTimeStep() </para>
		/// </summary>
		public virtual bool ShouldUseSubStepping()
			=> E_UProjectileMovementComponent_ShouldUseSubStepping(this);
		
		
		/// <summary>
		/// <para>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true). </para>
		/// </summary>
		public virtual void StopSimulating(FHitResult hitResult)
			=> E_UProjectileMovementComponent_StopSimulating(this, hitResult);
		
		protected virtual void TickInterpolation(float deltaTime)
			=> E_UProjectileMovementComponent_TickInterpolation(this, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(UProjectileMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UProjectileMovementComponent>(PtrDesc);
		}}}
