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
		public UMovementComponent(IntPtr adress)
			: base(adress)
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UMovementComponent_MoveComponentFlags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_MoveComponentFlags_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UMovementComponent_UpdatedComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_UpdatedComponent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UMovementComponent_UpdatedPrimitive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_UpdatedPrimitive_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UMovementComponent_Velocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UMovementComponent_Velocity_SET(IntPtr Ptr, IntPtr Value);
		
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
		private static extern void E_UMovementComponent_InitCollisionParams(IntPtr self, IntPtr outParams, IntPtr outResponseParam);
		
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
		/// If true, then applies the value of bComponentShouldUpdatePhysicsVolume to the UpdatedComponent. If false, will not change bShouldUpdatePhysicsVolume on the UpdatedComponent at all.
		/// <para>@see bComponentShouldUpdatePhysicsVolume </para>
		/// </summary>
		public byte bAutoRegisterPhysicsVolumeUpdates
		{
			get => E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, registers the owner's Root component as the UpdatedComponent if there is not one currently assigned.
		/// </summary>
		public byte bAutoRegisterUpdatedComponent
		{
			get => E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, whenever the updated component is changed, this component will enable or disable its tick dependent on whether it has something to update.
		/// <para>This will NOT enable tick at startup if bAutoActivate is false, because presumably you have a good reason for not wanting it to start ticking initially. </para>
		/// </summary>
		public byte bAutoUpdateTickRegistration
		{
			get => E_PROP_UMovementComponent_bAutoUpdateTickRegistration_GET(NativePointer);
			set => E_PROP_UMovementComponent_bAutoUpdateTickRegistration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, enables bShouldUpdatePhysicsVolume on the UpdatedComponent during initialization from SetUpdatedComponent(), otherwise disables such updates.
		/// <para>Only enabled if bAutoRegisterPhysicsVolumeUpdates is true. </para>
		/// WARNING: UpdatePhysicsVolume is potentially expensive if overlap events are also *disabled* because it requires a separate query against all physics volumes in the world.
		/// </summary>
		public byte bComponentShouldUpdatePhysicsVolume
		{
			get => E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_GET(NativePointer);
			set => E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, movement will be constrained to a plane.
		/// <see cref="PlaneConstraintNormal"/>
		/// </summary>
		public byte bConstrainToPlane
		{
			get => E_PROP_UMovementComponent_bConstrainToPlane_GET(NativePointer);
			set => E_PROP_UMovementComponent_bConstrainToPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true and plane constraints are enabled, then the updated component will be snapped to the plane when first attached.
		/// </summary>
		public byte bSnapToPlaneAtStart
		{
			get => E_PROP_UMovementComponent_bSnapToPlaneAtStart_GET(NativePointer);
			set => E_PROP_UMovementComponent_bSnapToPlaneAtStart_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, after registration we will add a tick dependency to tick before our owner (if we can both tick).
		/// <para>This is important when our tick causes an update in the owner's position, so that when the owner ticks it uses the most recent position without lag. </para>
		/// Disabling this can improve performance if both objects tick but the order of ticks doesn't matter.
		/// </summary>
		public byte bTickBeforeOwner
		{
			get => E_PROP_UMovementComponent_bTickBeforeOwner_GET(NativePointer);
			set => E_PROP_UMovementComponent_bTickBeforeOwner_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, skips TickComponent() if UpdatedComponent was not recently rendered.
		/// </summary>
		public byte bUpdateOnlyIfRendered
		{
			get => E_PROP_UMovementComponent_bUpdateOnlyIfRendered_GET(NativePointer);
			set => E_PROP_UMovementComponent_bUpdateOnlyIfRendered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Flags that control the behavior of calls to MoveComponent() on our UpdatedComponent.
		/// <para>@see EMoveComponentFlags </para>
		/// </summary>
		public EMoveComponentFlags MoveComponentFlags
		{
			get => (EMoveComponentFlags)E_PROP_UMovementComponent_MoveComponentFlags_GET(NativePointer);
			set => E_PROP_UMovementComponent_MoveComponentFlags_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// The component we move and update.
		/// <para>If this is null at startup and bAutoRegisterUpdatedComponent is true, the owning Actor's root component will automatically be set as our UpdatedComponent at startup. </para>
		/// <see cref="bAutoRegisterUpdatedComponent"/>
		/// </summary>
		public USceneComponent UpdatedComponent
		{
			get => E_PROP_UMovementComponent_UpdatedComponent_GET(NativePointer);
			set => E_PROP_UMovementComponent_UpdatedComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// UpdatedComponent, cast as a UPrimitiveComponent. May be invalid if UpdatedComponent was null or not a UPrimitiveComponent.
		/// </summary>
		public UPrimitiveComponent UpdatedPrimitive
		{
			get => E_PROP_UMovementComponent_UpdatedPrimitive_GET(NativePointer);
			set => E_PROP_UMovementComponent_UpdatedPrimitive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current velocity of updated component.
		/// </summary>
		public FVector Velocity
		{
			get => E_PROP_UMovementComponent_Velocity_GET(NativePointer);
			set => E_PROP_UMovementComponent_Velocity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds force from radial force components.
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// </summary>
		/// <param name="origin">The origin of the force</param>
		/// <param name="radius">The radius in which the force will be applied</param>
		/// <param name="strength">The strength of the force</param>
		/// <param name="falloff">The falloff from the force's origin</param>
		public virtual void AddRadialForce(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff)
			=> E_UMovementComponent_AddRadialForce(this, origin, radius, strength, (byte)falloff);
		
		
		/// <summary>
		/// Adds impulse from radial force components.
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// </summary>
		/// <param name="origin">The origin of the force</param>
		/// <param name="radius">The radius in which the force will be applied</param>
		/// <param name="strength">The strength of the force</param>
		/// <param name="falloff">The falloff from the force's origin</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).</param>
		public virtual void AddRadialImpulse(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bVelChange)
			=> E_UMovementComponent_AddRadialImpulse(this, origin, radius, strength, (byte)falloff, bVelChange);
		
		
		/// <summary>
		/// Compute a vector to slide along a surface, given an attempted move, time, and normal.
		/// </summary>
		/// <param name="delta">Attempted move.</param>
		/// <param name="time">Amount of move to apply (between 0 and 1).</param>
		/// <param name="normal">Normal opposed to movement. Not necessarily equal to Hit.Normal.</param>
		/// <param name="hit">HitResult of the move that resulted in the slide.</param>
		public virtual FVector ComputeSlideVector(FVector delta, float time, FVector normal, FHitResult hit)
			=> E_UMovementComponent_ComputeSlideVector(this, delta, time, normal, hit);
		
		
		/// <summary>
		/// Constrain a direction vector to the plane constraint, if enabled.
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public virtual FVector ConstrainDirectionToPlane(FVector direction)
			=> E_UMovementComponent_ConstrainDirectionToPlane(this, direction);
		
		
		/// <summary>
		/// Constrain a position vector to the plane constraint, if enabled.
		/// </summary>
		public virtual FVector ConstrainLocationToPlane(FVector location)
			=> E_UMovementComponent_ConstrainLocationToPlane(this, location);
		
		
		/// <summary>
		/// Constrain a normal vector (of unit length) to the plane constraint, if enabled.
		/// </summary>
		public virtual FVector ConstrainNormalToPlane(FVector normal)
			=> E_UMovementComponent_ConstrainNormalToPlane(this, normal);
		
		
		/// <summary>
		/// Returns gravity that affects this component
		/// </summary>
		public virtual float GetGravityZ()
			=> E_UMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// Returns maximum speed of component in current movement mode.
		/// </summary>
		public virtual float GetMaxSpeed()
			=> E_UMovementComponent_GetMaxSpeed(this);
		
		public virtual float GetMaxSpeedModifier()
			=> E_UMovementComponent_GetMaxSpeedModifier(this);
		
		public virtual float GetModifiedMaxSpeed()
			=> E_UMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// Calculate a movement adjustment to try to move out of a penetration from a failed move.
		/// </summary>
		/// <param name="hit">the result of the failed move</param>
		/// <return>The</return>
		public virtual FVector GetPenetrationAdjustment(FHitResult hit)
			=> E_UMovementComponent_GetPenetrationAdjustment(this, hit);
		
		
		/// <summary>
		/// Get the plane constraint axis setting.
		/// </summary>
		public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
			=> (EPlaneConstraintAxisSetting)E_UMovementComponent_GetPlaneConstraintAxisSetting(this);
		
		
		/// <summary>
		/// Returns the normal of the plane that constrains movement, enforced if the plane constraint is enabled.
		/// </summary>
		public FVector GetPlaneConstraintNormal()
			=> E_UMovementComponent_GetPlaneConstraintNormal(this);
		
		
		/// <summary>
		/// Helper to compute the plane constraint axis from the current setting.
		/// </summary>
		/// <param name="axisSetting">Setting to use when computing the axis.</param>
		/// <return>Plane</return>
		protected FVector GetPlaneConstraintNormalFromAxisSetting(EPlaneConstraintAxisSetting axisSetting)
			=> E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(this, (byte)axisSetting);
		
		
		/// <summary>
		/// Get the plane constraint origin. This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
		/// </summary>
		/// <return>The</return>
		public FVector GetPlaneConstraintOrigin()
			=> E_UMovementComponent_GetPlaneConstraintOrigin(this);
		
		
		/// <summary>
		/// Called for Blocking impact
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// be sure to handle that.
		/// </summary>
		/// <param name="hit">Describes the collision.</param>
		/// <param name="timeSlice">Time period for the simulation that produced this hit.  Useful for</param>
		/// <param name="moveDelta">Attempted move that resulted in the hit.</param>
		public virtual void HandleImpact(FHitResult hit, float timeSlice, FVector moveDelta)
			=> E_UMovementComponent_HandleImpact(this, hit, timeSlice, moveDelta);
		
		
		/// <summary>
		/// Initialize collision params appropriately based on our collision settings. Use this before any Line, Overlap, or Sweep tests.
		/// </summary>
		public virtual void InitCollisionParams(FCollisionQueryParams outParams, FCollisionResponseParams outResponseParam)
			=> E_UMovementComponent_InitCollisionParams(this, outParams, outResponseParam);
		
		
		/// <summary>
		/// Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance.
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// can cause the max speed to be violated.
		/// </summary>
		public virtual bool IsExceedingMaxSpeed(float maxSpeed)
			=> E_UMovementComponent_IsExceedingMaxSpeed(this, maxSpeed);
		
		
		/// <summary>
		/// Returns true if it's in PhysicsVolume with water flag
		/// </summary>
		public virtual bool IsInWater()
			=> E_UMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// Returns a scalar applied to the maximum velocity that the component can currently move.
		/// </summary>
		public virtual float K2_GetMaxSpeedModifier()
			=> E_UMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// Returns the result of GetMaxSpeed() * GetMaxSpeedModifier().
		/// </summary>
		public virtual float K2_GetModifiedMaxSpeed()
			=> E_UMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation.
		/// <para>Respects the plane constraint, if enabled. </para>
		/// </summary>
		/// <return>True</return>
		public bool K2_MoveUpdatedComponent(FVector delta, FRotator newRotation, FHitResult outHit, bool bSweep = true, bool bTeleport = false)
			=> E_UMovementComponent_K2_MoveUpdatedComponent(this, delta, newRotation, outHit, bSweep, bTeleport);
		
		
		/// <summary>
		/// Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation. Respects the plane constraint, if enabled.
		/// <para>@note This simply calls the virtual MoveUpdatedComponentImpl() which can be overridden to implement custom behavior. </para>
		/// @note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat).
		/// <para>@note The 'Teleport' flag is currently always treated as 'None' (not teleporting) when used in an active FScopedMovementUpdate. </para>
		/// </summary>
		/// <return>True</return>
		public bool MoveUpdatedComponent(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponent(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		public bool MoveUpdatedComponent(FVector delta, FRotator newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponent_o1(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		protected virtual bool MoveUpdatedComponentImpl(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_MoveUpdatedComponentImpl(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		
		/// <summary>
		/// Called by owning Actor upon successful teleport from AActor::TeleportTo().
		/// </summary>
		public virtual void OnTeleported()
			=> E_UMovementComponent_OnTeleported(this);
		
		
		/// <summary>
		/// Try to move out of penetration in an object after a failed move. This function should respect the plane constraint if applicable.
		/// <para>@note This simply calls the virtual ResolvePenetrationImpl() which can be overridden to implement custom behavior. </para>
		/// @note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat)..
		/// </summary>
		/// <param name="adjustment">The requested adjustment, usually from GetPenetrationAdjustment()</param>
		/// <param name="hit">The result of the failed move</param>
		/// <return>True</return>
		public bool ResolvePenetration(FVector adjustment, FHitResult hit, FQuat newRotation)
			=> E_UMovementComponent_ResolvePenetration(this, adjustment, hit, newRotation);
		
		public bool ResolvePenetration(FVector adjustment, FHitResult hit, FRotator newRotation)
			=> E_UMovementComponent_ResolvePenetration_o1(this, adjustment, hit, newRotation);
		
		protected virtual bool ResolvePenetrationImpl(FVector adjustment, FHitResult hit, FQuat newRotation)
			=> E_UMovementComponent_ResolvePenetrationImpl(this, adjustment, hit, newRotation);
		
		
		/// <summary>
		/// Calls MoveUpdatedComponent(), handling initial penetrations by calling ResolvePenetration().
		/// <para>If this adjustment succeeds, the original movement will be attempted again. </para>
		/// @note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat).
		/// <para>@note The 'Teleport' flag is currently always treated as 'None' (not teleporting) when used in an active FScopedMovementUpdate. </para>
		/// </summary>
		/// <return>result</return>
		public bool SafeMoveUpdatedComponent(FVector delta, FQuat newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_SafeMoveUpdatedComponent(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		public bool SafeMoveUpdatedComponent(FVector delta, FRotator newRotation, bool bSweep, FHitResult outHit, ETeleportType teleport)
			=> E_UMovementComponent_SafeMoveUpdatedComponent_o1(this, delta, newRotation, bSweep, outHit, (byte)teleport);
		
		
		/// <summary>
		/// Set the plane constraint axis setting.
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// </summary>
		/// <param name="newAxisSetting">New plane constraint axis setting.</param>
		public virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting newAxisSetting)
			=> E_UMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)newAxisSetting);
		
		
		/// <summary>
		/// Sets whether or not the plane constraint is enabled.
		/// </summary>
		public virtual void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_UMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled.
		/// </summary>
		public virtual void SetPlaneConstraintFromVectors(FVector forward, FVector up)
			=> E_UMovementComponent_SetPlaneConstraintFromVectors(this, forward, up);
		
		
		/// <summary>
		/// Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled.
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// </summary>
		/// <param name="planeNormal">The normal of the plane. If non-zero in length, it will be normalized.</param>
		public virtual void SetPlaneConstraintNormal(FVector planeNormal)
			=> E_UMovementComponent_SetPlaneConstraintNormal(this, planeNormal);
		
		
		/// <summary>
		/// Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled.
		/// </summary>
		public virtual void SetPlaneConstraintOrigin(FVector planeOrigin)
			=> E_UMovementComponent_SetPlaneConstraintOrigin(this, planeOrigin);
		
		
		/// <summary>
		/// Assign the component we move and update.
		/// </summary>
		public virtual void SetUpdatedComponent(USceneComponent newUpdatedComponent)
			=> E_UMovementComponent_SetUpdatedComponent(this, newUpdatedComponent);
		
		
		/// <summary>
		/// Possibly skip update if moved component is not rendered or can't move.
		/// </summary>
		/// <param name="deltaTime">todo this parameter is not used in the function.</param>
		/// <return>true</return>
		public virtual bool ShouldSkipUpdate(float deltaTime)
			=> E_UMovementComponent_ShouldSkipUpdate(this, deltaTime);
		
		
		/// <summary>
		/// Slide smoothly along a surface, and slide away from multiple impacts using TwoWallAdjust if necessary. Calls HandleImpact for each surface hit, if requested.
		/// <para>Uses SafeMoveUpdatedComponent() for movement, and ComputeSlideVector() to determine the slide direction. </para>
		/// </summary>
		/// <param name="delta">Attempted movement vector.</param>
		/// <param name="time">Percent of Delta to apply (between 0 and 1). Usually equal to the remaining time after a collision: (1.0 - Hit.Time).</param>
		/// <param name="normal">Normal opposing movement, along which we will slide.</param>
		/// <param name="hit">In] HitResult of the attempted move that resulted in the impact triggering the slide. [Out] HitResult of last attempted move.</param>
		/// <param name="bHandleImpact">Whether to call HandleImpact on each hit.</param>
		/// <return>The</return>
		public virtual float SlideAlongSurface(FVector delta, float time, FVector normal, FHitResult hit, bool bHandleImpact)
			=> E_UMovementComponent_SlideAlongSurface(this, delta, time, normal, hit, bHandleImpact);
		
		
		/// <summary>
		/// Snap the updated component to the plane constraint, if enabled.
		/// </summary>
		public virtual void SnapUpdatedComponentToPlane()
			=> E_UMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).
		/// </summary>
		public virtual void StopMovementImmediately()
			=> E_UMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// Compute a movement direction when contacting two surfaces.
		/// </summary>
		/// <param name="delta">In] Amount of move attempted before impact. [Out] Computed adjustment based on impacts.</param>
		/// <param name="hit">Impact from last attempted move</param>
		/// <param name="oldHitNormal">Normal of impact before last attempted move</param>
		/// <return>Result</return>
		public virtual void TwoWallAdjust(FVector delta, FHitResult hit, FVector oldHitNormal)
			=> E_UMovementComponent_TwoWallAdjust(this, delta, hit, oldHitNormal);
		
		
		/// <summary>
		/// Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed.
		/// </summary>
		public virtual void UpdateComponentVelocity()
			=> E_UMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent.
		/// </summary>
		public virtual void UpdateTickRegistration()
			=> E_UMovementComponent_UpdateTickRegistration(this);
		
		#endregion
		
		public static implicit operator IntPtr(UMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMovementComponent>(PtrDesc);
		}}}
