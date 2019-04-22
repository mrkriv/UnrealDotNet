// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

namespace UnrealEngine
{
	public  partial class UMovementComponent : UActorComponent
	{
		public UMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UMovementComponent(UObject Parent = null, string Name = "MovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bAutoUpdateTickRegistration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bAutoUpdateTickRegistration_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bConstrainToPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bConstrainToPlane_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bSnapToPlaneAtStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bSnapToPlaneAtStart_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bTickBeforeOwner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bTickBeforeOwner_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_bUpdateOnlyIfRendered_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_bUpdateOnlyIfRendered_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_AddRadialForce(IntPtr self, IntPtr origin, float radius, float strength, byte falloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_AddRadialImpulse(IntPtr self, IntPtr origin, float radius, float strength, byte falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ComputeSlideVector(IntPtr self, IntPtr delta, float time, IntPtr normal, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainDirectionToPlane(IntPtr self, IntPtr direction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainLocationToPlane(IntPtr self, IntPtr location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainNormalToPlane(IntPtr self, IntPtr normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetMaxSpeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetMaxSpeedModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetModifiedMaxSpeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPenetrationAdjustment(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UMovementComponent_GetPlaneConstraintAxisSetting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPlaneConstraintNormal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(IntPtr self, byte axisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPlaneConstraintOrigin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_HandleImpact(IntPtr self, IntPtr hit, float timeSlice, IntPtr moveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_IsExceedingMaxSpeed(IntPtr self, float maxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_IsInWater(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_K2_GetMaxSpeedModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_K2_GetModifiedMaxSpeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_K2_MoveUpdatedComponent(IntPtr self, IntPtr delta, IntPtr newRotation, IntPtr outHit, bool bSweep, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_MoveUpdatedComponent(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr outHit, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_MoveUpdatedComponent_o1(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr outHit, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_MoveUpdatedComponentImpl(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr outHit, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_OnTeleported(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ResolvePenetration(IntPtr self, IntPtr adjustment, IntPtr hit, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ResolvePenetration_o1(IntPtr self, IntPtr adjustment, IntPtr hit, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ResolvePenetrationImpl(IntPtr self, IntPtr adjustment, IntPtr hit, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_SafeMoveUpdatedComponent(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr outHit, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_SafeMoveUpdatedComponent_o1(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr outHit, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintAxisSetting(IntPtr self, byte newAxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintFromVectors(IntPtr self, IntPtr forward, IntPtr up);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintNormal(IntPtr self, IntPtr planeNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintOrigin(IntPtr self, IntPtr planeOrigin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetUpdatedComponent(IntPtr self, IntPtr newUpdatedComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ShouldSkipUpdate(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_SlideAlongSurface(IntPtr self, IntPtr delta, float time, IntPtr normal, IntPtr hit, bool bHandleImpact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SnapUpdatedComponentToPlane(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_StopMovementImmediately(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_TwoWallAdjust(IntPtr self, IntPtr delta, IntPtr hit, IntPtr oldHitNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_UpdateComponentVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_UpdateTickRegistration(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>If true, then applies the value of bComponentShouldUpdatePhysicsVolume to the UpdatedComponent. If false, will not change bShouldUpdatePhysicsVolume on the UpdatedComponent at all. </para>
		/// <para>@see bComponentShouldUpdatePhysicsVolume </para>
		/// </summary>
		public byte bAutoRegisterPhysicsVolumeUpdates
		{
			get => E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, registers the owner's Root component as the UpdatedComponent if there is not one currently assigned. </para>
		/// </summary>
		public byte bAutoRegisterUpdatedComponent
		{
			get => E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, whenever the updated component is changed, this component will enable or disable its tick dependent on whether it has something to update. </para>
		/// <para>This will NOT enable tick at startup if bAutoActivate is false, because presumably you have a good reason for not wanting it to start ticking initially. </para>
		/// </summary>
		public byte bAutoUpdateTickRegistration
		{
			get => E_PROP_UMovementComponent_bAutoUpdateTickRegistration_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoUpdateTickRegistration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, enables bShouldUpdatePhysicsVolume on the UpdatedComponent during initialization from SetUpdatedComponent(), otherwise disables such updates. </para>
		/// <para>Only enabled if bAutoRegisterPhysicsVolumeUpdates is true. </para>
		/// <para>WARNING: UpdatePhysicsVolume is potentially expensive if overlap events are also *disabled* because it requires a separate query against all physics volumes in the world. </para>
		/// </summary>
		public byte bComponentShouldUpdatePhysicsVolume
		{
			get => E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_GET(NativePointer);
			set => E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, movement will be constrained to a plane. </para>
		/// <para>@see PlaneConstraintNormal, PlaneConstraintOrigin, PlaneConstraintAxisSetting </para>
		/// </summary>
		public byte bConstrainToPlane
		{
			get => E_PROP_UMovementComponent_bConstrainToPlane_GET(NativePointer);
			set => E_PROP_UMovementComponent_bConstrainToPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true and plane constraints are enabled, then the updated component will be snapped to the plane when first attached. </para>
		/// </summary>
		public byte bSnapToPlaneAtStart
		{
			get => E_PROP_UMovementComponent_bSnapToPlaneAtStart_GET(NativePointer);
			set => E_PROP_UMovementComponent_bSnapToPlaneAtStart_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, after registration we will add a tick dependency to tick before our owner (if we can both tick). </para>
		/// <para>This is important when our tick causes an update in the owner's position, so that when the owner ticks it uses the most recent position without lag. </para>
		/// <para>Disabling this can improve performance if both objects tick but the order of ticks doesn't matter. </para>
		/// </summary>
		public byte bTickBeforeOwner
		{
			get => E_PROP_UMovementComponent_bTickBeforeOwner_GET(NativePointer);
			set => E_PROP_UMovementComponent_bTickBeforeOwner_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, skips TickComponent() if UpdatedComponent was not recently rendered. </para>
		/// </summary>
		public byte bUpdateOnlyIfRendered
		{
			get => E_PROP_UMovementComponent_bUpdateOnlyIfRendered_GET(NativePointer);
			set => E_PROP_UMovementComponent_bUpdateOnlyIfRendered_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds force from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// </summary>
		public virtual void AddRadialForce(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff)
			=> E_UMovementComponent_AddRadialForce(this, origin, radius, strength, (byte)falloff);
		
		
		/// <summary>
		/// <para>Adds impulse from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public virtual void AddRadialImpulse(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bVelChange)
			=> E_UMovementComponent_AddRadialImpulse(this, origin, radius, strength, (byte)falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Compute a vector to slide along a surface, given an attempted move, time, and normal. </para>
		/// <param name="Delta">Attempted move. </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal. </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// </summary>
		public virtual FVector ComputeSlideVector(FVector delta, float time, FVector normal, FHitResult hit)
			=> E_UMovementComponent_ComputeSlideVector(this, delta, time, normal, hit);
		
		
		/// <summary>
		/// <para>Constrain a direction vector to the plane constraint, if enabled. </para>
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public virtual FVector ConstrainDirectionToPlane(FVector direction)
			=> E_UMovementComponent_ConstrainDirectionToPlane(this, direction);
		
		
		/// <summary>
		/// <para>Constrain a position vector to the plane constraint, if enabled. </para>
		/// </summary>
		public virtual FVector ConstrainLocationToPlane(FVector location)
			=> E_UMovementComponent_ConstrainLocationToPlane(this, location);
		
		
		/// <summary>
		/// <para>Constrain a normal vector (of unit length) to the plane constraint, if enabled. </para>
		/// </summary>
		public virtual FVector ConstrainNormalToPlane(FVector normal)
			=> E_UMovementComponent_ConstrainNormalToPlane(this, normal);
		
		
		/// <summary>
		/// <para>Returns gravity that affects this component </para>
		/// </summary>
		public virtual float GetGravityZ()
			=> E_UMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// <para>Returns maximum speed of component in current movement mode. </para>
		/// </summary>
		public virtual float GetMaxSpeed()
			=> E_UMovementComponent_GetMaxSpeed(this);
		
		public virtual float GetMaxSpeedModifier()
			=> E_UMovementComponent_GetMaxSpeedModifier(this);
		
		public virtual float GetModifiedMaxSpeed()
			=> E_UMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Calculate a movement adjustment to try to move out of a penetration from a failed move. </para>
		/// <param name="Hit">the result of the failed move </param>
		/// <return>The adjustment to use after a failed move, or a zero vector if no attempt should be made. </return>
		/// </summary>
		public virtual FVector GetPenetrationAdjustment(FHitResult hit)
			=> E_UMovementComponent_GetPenetrationAdjustment(this, hit);
		
		
		/// <summary>
		/// <para>Get the plane constraint axis setting. </para>
		/// </summary>
		public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
			=> (EPlaneConstraintAxisSetting)E_UMovementComponent_GetPlaneConstraintAxisSetting(this);
		
		
		/// <summary>
		/// <para>Returns the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public FVector GetPlaneConstraintNormal()
			=> E_UMovementComponent_GetPlaneConstraintNormal(this);
		
		
		/// <summary>
		/// <para>Helper to compute the plane constraint axis from the current setting. </para>
		/// <param name="AxisSetting">Setting to use when computing the axis. </param>
		/// <return>Plane constraint axis/normal. </return>
		/// </summary>
		protected FVector GetPlaneConstraintNormalFromAxisSetting(EPlaneConstraintAxisSetting axisSetting)
			=> E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(this, (byte)axisSetting);
		
		
		/// <summary>
		/// <para>Get the plane constraint origin. This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane(). </para>
		/// <return>The origin of the plane that constrains movement, if the plane constraint is enabled. </return>
		/// </summary>
		public FVector GetPlaneConstraintOrigin()
			=> E_UMovementComponent_GetPlaneConstraintOrigin(this);
		
		
		/// <summary>
		/// <para>Called for Blocking impact </para>
		/// <param name="Hit">Describes the collision. </param>
		/// <param name="TimeSlice">Time period for the simulation that produced this hit.  Useful for </param>
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// <para>be sure to handle that. </para>
		/// <param name="MoveDelta">Attempted move that resulted in the hit. </param>
		/// </summary>
		public virtual void HandleImpact(FHitResult hit, float timeSlice, FVector moveDelta)
			=> E_UMovementComponent_HandleImpact(this, hit, timeSlice, moveDelta);
		
		
		/// <summary>
		/// <para>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance. </para>
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// <para>can cause the max speed to be violated. </para>
		/// </summary>
		public virtual bool IsExceedingMaxSpeed(float maxSpeed)
			=> E_UMovementComponent_IsExceedingMaxSpeed(this, maxSpeed);
		
		
		/// <summary>
		/// <para>Returns true if it's in PhysicsVolume with water flag </para>
		/// </summary>
		public virtual bool IsInWater()
			=> E_UMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// <para>Returns a scalar applied to the maximum velocity that the component can currently move. </para>
		/// </summary>
		public virtual float K2_GetMaxSpeedModifier()
			=> E_UMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <para>Returns the result of GetMaxSpeed() * GetMaxSpeedModifier(). </para>
		/// </summary>
		public virtual float K2_GetModifiedMaxSpeed()
			=> E_UMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation. </para>
		/// <para>Respects the plane constraint, if enabled. </para>
		/// <return>True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit. </return>
		/// </summary>
		public bool K2_MoveUpdatedComponent(FVector delta, FRotator newRotation, FHitResult outHit, bool bSweep = true, bool bTeleport = false)
			=> E_UMovementComponent_K2_MoveUpdatedComponent(this, delta, newRotation, outHit, bSweep, bTeleport);
		
		
		/// <summary>
		/// <para>Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation. Respects the plane constraint, if enabled. </para>
		/// <para>@note This simply calls the virtual MoveUpdatedComponentImpl() which can be overridden to implement custom behavior. </para>
		/// <para>@note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat). </para>
		/// <para>@note The 'Teleport' flag is currently always treated as 'None' (not teleporting) when used in an active FScopedMovementUpdate. </para>
		/// <return>True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit. </return>
		/// </summary>
		public bool MoveUpdatedComponent(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponent(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		public bool MoveUpdatedComponent(FVector delta, FRotator newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponent_o1(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		protected virtual bool MoveUpdatedComponentImpl(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponentImpl(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		
		/// <summary>
		/// <para>Called by owning Actor upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public virtual void OnTeleported()
			=> E_UMovementComponent_OnTeleported(this);
		
		
		/// <summary>
		/// <para>Try to move out of penetration in an object after a failed move. This function should respect the plane constraint if applicable. </para>
		/// <para>@note This simply calls the virtual ResolvePenetrationImpl() which can be overridden to implement custom behavior. </para>
		/// <para>@note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat).. </para>
		/// <param name="Adjustment">The requested adjustment, usually from GetPenetrationAdjustment() </param>
		/// <param name="Hit">The result of the failed move </param>
		/// <return>True if the adjustment was successful and the original move should be retried, or false if no repeated attempt should be made. </return>
		/// </summary>
		public bool ResolvePenetration(FVector adjustment, FHitResult hit, FQuat newRotation)
			=> E_UMovementComponent_ResolvePenetration(this, adjustment, hit, newRotation);
		
		public bool ResolvePenetration(FVector adjustment, FHitResult hit, FRotator newRotation)
			=> E_UMovementComponent_ResolvePenetration_o1(this, adjustment, hit, newRotation);
		
		protected virtual bool ResolvePenetrationImpl(FVector adjustment, FHitResult hit, FQuat newRotation)
			=> E_UMovementComponent_ResolvePenetrationImpl(this, adjustment, hit, newRotation);
		
		
		/// <summary>
		/// <para>Calls MoveUpdatedComponent(), handling initial penetrations by calling ResolvePenetration(). </para>
		/// <para>If this adjustment succeeds, the original movement will be attempted again. </para>
		/// <para>@note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat). </para>
		/// <para>@note The 'Teleport' flag is currently always treated as 'None' (not teleporting) when used in an active FScopedMovementUpdate. </para>
		/// <return>result of the final MoveUpdatedComponent() call. </return>
		/// </summary>
		public bool SafeMoveUpdatedComponent(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_SafeMoveUpdatedComponent(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		public bool SafeMoveUpdatedComponent(FVector delta, FRotator newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_SafeMoveUpdatedComponent_o1(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting newAxisSetting)
			=> E_UMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)newAxisSetting);
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_UMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintFromVectors(FVector forward, FVector up)
			=> E_UMovementComponent_SetPlaneConstraintFromVectors(this, forward, up);
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public virtual void SetPlaneConstraintNormal(FVector planeNormal)
			=> E_UMovementComponent_SetPlaneConstraintNormal(this, planeNormal);
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintOrigin(FVector planeOrigin)
			=> E_UMovementComponent_SetPlaneConstraintOrigin(this, planeOrigin);
		
		
		/// <summary>
		/// <para>Assign the component we move and update. </para>
		/// </summary>
		public virtual void SetUpdatedComponent(USceneComponent newUpdatedComponent)
			=> E_UMovementComponent_SetUpdatedComponent(this, newUpdatedComponent);
		
		
		/// <summary>
		/// <para>Possibly skip update if moved component is not rendered or can't move. </para>
		/// <param name="DeltaTime">todo this parameter is not used in the function. </param>
		/// <return>true if component movement update should be skipped </return>
		/// </summary>
		public virtual bool ShouldSkipUpdate(float deltaTime)
			=> E_UMovementComponent_ShouldSkipUpdate(this, deltaTime);
		
		
		/// <summary>
		/// <para>Slide smoothly along a surface, and slide away from multiple impacts using TwoWallAdjust if necessary. Calls HandleImpact for each surface hit, if requested. </para>
		/// <para>Uses SafeMoveUpdatedComponent() for movement, and ComputeSlideVector() to determine the slide direction. </para>
		/// <param name="Delta">Attempted movement vector. </param>
		/// <param name="Time">Percent of Delta to apply (between 0 and 1). Usually equal to the remaining time after a collision: (1.0 - Hit.Time). </param>
		/// <param name="Normal">Normal opposing movement, along which we will slide. </param>
		/// <param name="Hit">In] HitResult of the attempted move that resulted in the impact triggering the slide. [Out] HitResult of last attempted move. </param>
		/// <param name="bHandleImpact">Whether to call HandleImpact on each hit. </param>
		/// <return>The percentage of requested distance (Delta * Percent) actually applied (between 0 and 1). 0 if no movement occurred, non-zero if movement occurred. </return>
		/// </summary>
		public virtual float SlideAlongSurface(FVector delta, float time, FVector normal, FHitResult hit, bool bHandleImpact)
			=> E_UMovementComponent_SlideAlongSurface(this, delta, time, normal, hit, bHandleImpact);
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public virtual void SnapUpdatedComponentToPlane()
			=> E_UMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// <para>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration). </para>
		/// </summary>
		public virtual void StopMovementImmediately()
			=> E_UMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// <para>Compute a movement direction when contacting two surfaces. </para>
		/// <param name="Delta">In] Amount of move attempted before impact. [Out] Computed adjustment based on impacts. </param>
		/// <param name="Hit">Impact from last attempted move </param>
		/// <param name="OldHitNormal">Normal of impact before last attempted move </param>
		/// <return>Result in Delta that is the direction to move when contacting two surfaces. </return>
		/// </summary>
		public virtual void TwoWallAdjust(FVector delta, FHitResult hit, FVector oldHitNormal)
			=> E_UMovementComponent_TwoWallAdjust(this, delta, hit, oldHitNormal);
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public virtual void UpdateComponentVelocity()
			=> E_UMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public virtual void UpdateTickRegistration()
			=> E_UMovementComponent_UpdateTickRegistration(this);
		
		#endregion
		
		public static implicit operator IntPtr(UMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMovementComponent>(PtrDesc);
		}}}
