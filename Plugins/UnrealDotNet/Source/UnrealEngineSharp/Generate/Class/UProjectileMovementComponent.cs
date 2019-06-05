// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	public partial class UProjectileMovementComponent : UMovementComponent
	{
		public UProjectileMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UProjectileMovementComponent(UObject Parent = null, string Name = "ProjectileMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UProjectileMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bForceSubStepping_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bForceSubStepping_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bInterpMovement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bInterpMovement_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bInterpRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bInterpRotation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bIsHomingProjectile_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bIsHomingProjectile_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bIsSliding_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bIsSliding_SET(IntPtr Ptr, byte Value);
		
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
		private static extern byte E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bShouldBounce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bShouldBounce_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bSimulationEnabled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bSimulationEnabled_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UProjectileMovementComponent_bSweepCollision_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_bSweepCollision_SET(IntPtr Ptr, byte Value);
		
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
		private static extern float E_PROP_UProjectileMovementComponent_InitialSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_InitialSpeed_SET(IntPtr Ptr, float Value);
		
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
		private static extern float E_PROP_UProjectileMovementComponent_MaxSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UProjectileMovementComponent_MaxSpeed_SET(IntPtr Ptr, float Value);
		
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
		/// Controls the effects of friction on velocity parallel to the impact surface when bouncing.
		/// <para>If true, friction will be modified based on the angle of impact, making friction higher for perpendicular impacts and lower for glancing impacts. </para>
		/// If false, a bounce will retain a proportion of tangential velocity equal to (1.0 - Friction), acting as a "horizontal restitution".
		/// </summary>
		public byte bBounceAngleAffectsFriction
		{
			get => E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
		/// <para>Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed. </para>
		/// Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
		/// <see cref="MaxSimulationTimeStep"/>
		/// </summary>
		public byte bForceSubStepping
		{
			get => E_PROP_UProjectileMovementComponent_bForceSubStepping_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bForceSubStepping_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, the initial Velocity is interpreted as being in local space upon startup.
		/// <see cref="SetVelocityInLocalSpace"/>
		/// </summary>
		public byte bInitialVelocityInLocalSpace
		{
			get => E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true and there is an interpolated component set, location (and optionally rotation) interpolation is enabled which allows the interpolated object to smooth uneven updates
		/// <para>of the UpdatedComponent's location (usually to smooth network updates). </para>
		/// <see cref="SetInterpolatedComponent"/>
		/// </summary>
		public byte bInterpMovement
		{
			get => E_PROP_UProjectileMovementComponent_bInterpMovement_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bInterpMovement_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true and there is an interpolated component set, rotation interpolation is enabled which allows the interpolated object to smooth uneven updates
		/// <para>of the UpdatedComponent's rotation (usually to smooth network updates). </para>
		/// Rotation interpolation is *only* applied if bInterpMovement is also enabled.
		/// <see cref="SetInterpolatedComponent"/>
		/// </summary>
		public byte bInterpRotation
		{
			get => E_PROP_UProjectileMovementComponent_bInterpRotation_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bInterpRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, we will accelerate toward our homing target. HomingTargetComponent must be set after the projectile is spawned.
		/// <see cref="HomingTargetComponent"/>
		/// </summary>
		public byte bIsHomingProjectile
		{
			get => E_PROP_UProjectileMovementComponent_bIsHomingProjectile_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bIsHomingProjectile_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, projectile is sliding / rolling along a surface.
		/// </summary>
		public byte bIsSliding
		{
			get => E_PROP_UProjectileMovementComponent_bIsSliding_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bIsSliding_SET(NativePointer, value);
		}

		
		/// <summary>
		/// On the first few bounces (up to this amount), allow extra iterations over MaxSimulationIterations if necessary.
		/// </summary>
		public int BounceAdditionalIterations
		{
			get => E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event.
		/// <para>Ignored if bShouldBounce is false, in which case the projectile stops simulating on the first impact. </para>
		/// <see cref="StopSimulating"/>
		/// </summary>
		public float BounceVelocityStopSimulatingThreshold
		{
			get => E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution).
		/// <para>1.0 = no velocity lost, 0.0 = no bounce. Ignored if bShouldBounce is false. </para>
		/// </summary>
		public float Bounciness
		{
			get => E_PROP_UProjectileMovementComponent_Bounciness_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Bounciness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this projectile will have its rotation updated each frame to match the direction of its velocity.
		/// </summary>
		public byte bRotationFollowsVelocity
		{
			get => E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, simple bounces will be simulated. Set this to false to stop simulating on contact.
		/// </summary>
		public byte bShouldBounce
		{
			get => E_PROP_UProjectileMovementComponent_bShouldBounce_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bShouldBounce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, does normal simulation ticking and update. If false, simulation is halted, but component will still tick (allowing interpolation to run).
		/// </summary>
		public byte bSimulationEnabled
		{
			get => E_PROP_UProjectileMovementComponent_bSimulationEnabled_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bSimulationEnabled_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, movement uses swept collision checks.
		/// <para>If false, collision effectively teleports to the destination. Note that when this is disabled, movement will never generate blocking collision hits (though overlaps will be updated). </para>
		/// </summary>
		public byte bSweepCollision
		{
			get => E_PROP_UProjectileMovementComponent_bSweepCollision_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_bSweepCollision_SET(NativePointer, value);
		}

		public float Buoyancy
		{
			get => E_PROP_UProjectileMovementComponent_Buoyancy_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Buoyancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Coefficient of friction, affecting the resistance to sliding along a surface.
		/// <para>Normal range is [0,1] : 0.0 = no friction, 1.0+ = very high friction. </para>
		/// Also affects the percentage of velocity maintained after the bounce in the direction tangent to the normal of impact.
		/// <para>Ignored if bShouldBounce is false. </para>
		/// @see bBounceAngleAffectsFriction
		/// </summary>
		public float Friction
		{
			get => E_PROP_UProjectileMovementComponent_Friction_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_Friction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed.
		/// </summary>
		public float HomingAccelerationMagnitude
		{
			get => E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Initial speed of projectile. If greater than zero, this will override the initial Velocity value and instead treat Velocity as a direction.
		/// </summary>
		public float InitialSpeed
		{
			get => E_PROP_UProjectileMovementComponent_InitialSpeed_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InitialSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance behind UpdatedComponent which the interpolated component is allowed to lag.
		/// </summary>
		public float InterpLocationMaxLagDistance
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance behind UpdatedComponent beyond which the interpolated component is snapped to the target location instead.
		/// <para>For instance if the target teleports this far beyond the interpolated component, the interpolation is snapped to match the target. </para>
		/// </summary>
		public float InterpLocationSnapToTargetDistance
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// "Time" over which most of the location interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component.
		/// <para>Since the implementation uses exponential lagged smoothing, this is a rough time value and experimentation should inform a final result. </para>
		/// A value of zero is effectively instantaneous interpolation.
		/// </summary>
		public float InterpLocationTime
		{
			get => E_PROP_UProjectileMovementComponent_InterpLocationTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// "Time" over which most of the rotation interpolation occurs, when the UpdatedComponent (target) moves ahead of the interpolated component.
		/// <para>Since the implementation uses exponential lagged smoothing, this is a rough time value and experimentation should inform a final result. </para>
		/// A value of zero is effectively instantaneous interpolation.
		/// </summary>
		public float InterpRotationTime
		{
			get => E_PROP_UProjectileMovementComponent_InterpRotationTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_InterpRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// <para>Increasing this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// <see cref="MaxSimulationTimeStep"/>
		/// </summary>
		public int MaxSimulationIterations
		{
			get => E_PROP_UProjectileMovementComponent_MaxSimulationIterations_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MaxSimulationIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// <para>Lowering this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// <see cref="MaxSimulationIterations"/>
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get => E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Limit on speed of projectile (0 means no limit).
		/// </summary>
		public float MaxSpeed
		{
			get => E_PROP_UProjectileMovementComponent_MaxSpeed_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MaxSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When bounce angle affects friction, apply at least this fraction of normal friction.
		/// <para>Helps consistently slow objects sliding or rolling along surfaces or in valleys when the usual friction amount would take a very long time to settle. </para>
		/// </summary>
		public float MinFrictionFraction
		{
			get => E_PROP_UProjectileMovementComponent_MinFrictionFraction_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_MinFrictionFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step.
		/// </summary>
		public FVector PreviousHitNormal
		{
			get => E_PROP_UProjectileMovementComponent_PreviousHitNormal_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_PreviousHitNormal_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact.
		/// </summary>
		public float PreviousHitTime
		{
			get => E_PROP_UProjectileMovementComponent_PreviousHitTime_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_PreviousHitTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Custom gravity scale for this projectile. Set to 0 for no gravity.
		/// </summary>
		public float ProjectileGravityScale
		{
			get => E_PROP_UProjectileMovementComponent_ProjectileGravityScale_GET(NativePointer);
			set => E_PROP_UProjectileMovementComponent_ProjectileGravityScale_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// This will check to see if the projectile is still in the world.  It will check things like
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public virtual bool CheckStillInWorld()
			=> E_UProjectileMovementComponent_CheckStillInWorld(this);
		
		
		/// <summary>
		/// Compute the acceleration that will be applied
		/// </summary>
		protected virtual FVector ComputeAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// Computes result of a bounce and returns the new velocity.
		/// </summary>
		protected virtual FVector ComputeBounceResult(FHitResult hit, float timeSlice, FVector moveDelta)
			=> E_UProjectileMovementComponent_ComputeBounceResult(this, hit, timeSlice, moveDelta);
		
		
		/// <summary>
		/// Allow the projectile to track towards its homing target.
		/// </summary>
		protected virtual FVector ComputeHomingAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeHomingAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// Compute the distance we should move in the given time, at a given a velocity.
		/// </summary>
		protected virtual FVector ComputeMoveDelta(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeMoveDelta(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// Given an initial velocity and a time step, compute a new velocity.
		/// <para>Default implementation applies the result of ComputeAcceleration() to velocity. </para>
		/// </summary>
		/// <param name="initialVelocity">Initial velocity.</param>
		/// <param name="deltaTime">Time step of the update.</param>
		/// <return>Velocity</return>
		public virtual FVector ComputeVelocity(FVector initialVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeVelocity(this, initialVelocity, deltaTime);
		
		
		/// <summary>
		/// </summary>
		/// <return>Buoyancy</return>
		public float GetBuoyancy()
			=> E_UProjectileMovementComponent_GetBuoyancy(this);
		
		
		/// <summary>
		/// Returns the component used for network interpolation.
		/// </summary>
		public USceneComponent GetInterpolatedComponent()
			=> E_UProjectileMovementComponent_GetInterpolatedComponent(this);
		
		
		/// <summary>
		/// Compute remaining time step given remaining time and current iterations.
		/// <para>The last iteration (limited by MaxSimulationIterations) always returns the remaining time, which may violate MaxSimulationTimeStep. </para>
		/// <see cref="MaxSimulationTimeStep"/>
		/// <see cref="ShouldUseSubStepping"/>
		/// </summary>
		/// <param name="remainingTime">Remaining time in the tick.</param>
		/// <param name="iterations">Current iteration of the tick (starting at 1).</param>
		/// <return>The</return>
		public float GetSimulationTimeStep(float remainingTime, int iterations)
			=> E_UProjectileMovementComponent_GetSimulationTimeStep(this, remainingTime, iterations);
		
		
		/// <summary>
		/// Handle blocking hit during simulation update. Checks that simulation remains valid after collision.
		/// <para>If simulating then calls HandleImpact(), and returns EHandleHitWallResult::Deflect by default to enable multi-bounce and sliding support through HandleDeflection(). </para>
		/// If no longer simulating then returns EHandleHitWallResult::Abort, which aborts attempts at further simulation.
		/// <para>Initial default value is: TimeTick * (1.f - Hit.Time) </para>
		/// <see cref="EHandleHitWallResult"/>
		/// </summary>
		/// <param name="hit">Blocking hit that occurred.</param>
		/// <param name="timeTick">Time delta of last move that resulted in the blocking hit.</param>
		/// <param name="moveDelta">Movement delta for the current sub-step.</param>
		/// <param name="subTickTimeRemaining">How much time to continue simulating in the current sub-step, which may change as a result of this function.</param>
		/// <return>Result</return>
		protected virtual EHandleBlockingHitResult HandleBlockingHit(FHitResult hit, float timeTick, FVector moveDelta, float subTickTimeRemaining)
			=> (EHandleBlockingHitResult)E_UProjectileMovementComponent_HandleBlockingHit(this, hit, timeTick, moveDelta, subTickTimeRemaining);
		
		
		/// <summary>
		/// Handle case where projectile is sliding along a surface.
		/// <para>Velocity will be parallel to the impact surface upon entry to this method. </para>
		/// </summary>
		/// <param name="initialHit">Hit result of impact causing slide. May be modified by this function to reflect any subsequent movement.</param>
		/// <param name="subTickTimeRemaining">Time remaining in the tick. This function may update this time with any reduction to the simulation time requested.</param>
		/// <return>True</return>
		protected virtual bool HandleSliding(FHitResult hit, float subTickTimeRemaining)
			=> E_UProjectileMovementComponent_HandleSliding(this, hit, subTickTimeRemaining);
		
		public bool HasStoppedSimulation()
			=> E_UProjectileMovementComponent_HasStoppedSimulation(this);
		
		
		/// <summary>
		/// Returns whether interpolation is complete because the target has been reached. True when interpolation is disabled.
		/// </summary>
		public bool IsInterpolationComplete()
			=> E_UProjectileMovementComponent_IsInterpolationComplete(this);
		
		
		/// <summary>
		/// Returns true if velocity magnitude is less than BounceVelocityStopSimulatingThreshold.
		/// </summary>
		public bool IsVelocityUnderSimulationThreshold()
			=> E_UProjectileMovementComponent_IsVelocityUnderSimulationThreshold(this);
		
		
		/// <summary>
		/// Don't allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero.
		/// </summary>
		protected FVector LimitVelocity(FVector newVelocity)
			=> E_UProjectileMovementComponent_LimitVelocity(this, newVelocity);
		
		
		/// <summary>
		/// Moves the UpdatedComponent, which is also the interpolation target for the interpolated component. If there is not interpolated component, this simply moves UpdatedComponent.
		/// <para>Use this typically from PostNetReceiveLocationAndRotation() or similar from an Actor. </para>
		/// </summary>
		public virtual void MoveInterpolationTarget(FVector newLocation, FRotator newRotation)
			=> E_UProjectileMovementComponent_MoveInterpolationTarget(this, newLocation, newRotation);
		
		
		/// <summary>
		/// Resets interpolation so that interpolated component snaps back to the initial location/rotation without any additional offsets.
		/// </summary>
		public virtual void ResetInterpolation()
			=> E_UProjectileMovementComponent_ResetInterpolation(this);
		
		
		/// <summary>
		/// Assigns the component that will be used for network interpolation/smoothing. It is expected that this is a component attached somewhere below the UpdatedComponent.
		/// <para>When network updates use MoveInterpolationTarget() to move the UpdatedComponent, the interpolated component's relative offset will be maintained and smoothed over </para>
		/// the course of future component ticks. The current relative location and rotation of the component is saved as the target offset for future interpolation.
		/// <see cref="MoveInterpolationTarget"/>
		/// </summary>
		public virtual void SetInterpolatedComponent(USceneComponent component)
			=> E_UProjectileMovementComponent_SetInterpolatedComponent(this, component);
		
		
		/// <summary>
		/// Sets the velocity to the new value, rotated into Actor space.
		/// </summary>
		public virtual void SetVelocityInLocalSpace(FVector newVelocity)
			=> E_UProjectileMovementComponent_SetVelocityInLocalSpace(this, newVelocity);
		
		public bool ShouldApplyGravity()
			=> E_UProjectileMovementComponent_ShouldApplyGravity(this);
		
		
		/// <summary>
		/// Determine whether or not to use substepping in the projectile motion update.
		/// <para>If true, GetSimulationTimeStep() will be used to time-slice the update. If false, all remaining time will be used during the tick. </para>
		/// <see cref="GetSimulationTimeStep"/>
		/// </summary>
		/// <return>Whether</return>
		public virtual bool ShouldUseSubStepping()
			=> E_UProjectileMovementComponent_ShouldUseSubStepping(this);
		
		
		/// <summary>
		/// Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).
		/// </summary>
		public virtual void StopSimulating(FHitResult hitResult)
			=> E_UProjectileMovementComponent_StopSimulating(this, hitResult);
		
		protected virtual void TickInterpolation(float deltaTime)
			=> E_UProjectileMovementComponent_TickInterpolation(this, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(UProjectileMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UProjectileMovementComponent>(PtrDesc);
		}}}
