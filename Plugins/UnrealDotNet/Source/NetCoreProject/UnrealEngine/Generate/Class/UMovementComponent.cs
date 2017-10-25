using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ComputeSlideVector(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainDirectionToPlane(IntPtr Self, IntPtr Direction);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainLocationToPlane(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_ConstrainNormalToPlane(IntPtr Self, IntPtr Normal);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPenetrationAdjustment(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UMovementComponent_GetPlaneConstraintAxisSetting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(IntPtr Self, byte AxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_HandleImpact(IntPtr Self, IntPtr Hit, float TimeSlice, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_IsExceedingMaxSpeed(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_IsInWater(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_K2_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_K2_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_K2_MoveUpdatedComponent(IntPtr Self, IntPtr Delta, IntPtr NewRotation, IntPtr OutHit, bool bSweep, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_MoveUpdatedComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_OnTeleported(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ResolvePenetrationImpl(IntPtr Self, IntPtr Adjustment, IntPtr Hit, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintAxisSetting(IntPtr Self, byte NewAxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintFromVectors(IntPtr Self, IntPtr Forward, IntPtr Up);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintNormal(IntPtr Self, IntPtr PlaneNormal);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetPlaneConstraintOrigin(IntPtr Self, IntPtr PlaneOrigin);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SetUpdatedComponent(IntPtr Self, IntPtr NewUpdatedComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_ShouldSkipUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMovementComponent_SkipUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMovementComponent_SlideAlongSurface(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit, bool bHandleImpact);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_SnapUpdatedComponentToPlane(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_StopMovementImmediately(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_TwoWallAdjust(IntPtr Self, IntPtr Delta, IntPtr Hit, IntPtr OldHitNormal);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_UpdateComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMovementComponent_UpdateTickRegistration(IntPtr Self);
		
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
		public virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
			=> E_UMovementComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff);
		
		
		/// <summary>
		/// <para>Adds impulse from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect). </param>
		/// </summary>
		public virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_UMovementComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Compute a vector to slide along a surface, given an attempted move, time, and normal. </para>
		/// <param name="Delta">Attempted move. </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal. </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// </summary>
		public virtual FVector ComputeSlideVector(FVector Delta, float Time, FVector Normal, FHitResult Hit)
			=> E_UMovementComponent_ComputeSlideVector(this, Delta, Time, Normal, Hit);
		
		
		/// <summary>
		/// <para>Constrain a direction vector to the plane constraint, if enabled. </para>
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public virtual FVector ConstrainDirectionToPlane(FVector Direction)
			=> E_UMovementComponent_ConstrainDirectionToPlane(this, Direction);
		
		
		/// <summary>
		/// <para>Constrain a position vector to the plane constraint, if enabled. </para>
		/// </summary>
		public virtual FVector ConstrainLocationToPlane(FVector Location)
			=> E_UMovementComponent_ConstrainLocationToPlane(this, Location);
		
		
		/// <summary>
		/// <para>Constrain a normal vector (of unit length) to the plane constraint, if enabled. </para>
		/// </summary>
		public virtual FVector ConstrainNormalToPlane(FVector Normal)
			=> E_UMovementComponent_ConstrainNormalToPlane(this, Normal);
		
		
		/// <summary>
		/// <return>gravity that affects this component </return>
		/// </summary>
		public virtual float GetGravityZ()
			=> E_UMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// <return>Maximum speed of component in current movement mode. </return>
		/// </summary>
		public virtual float GetMaxSpeed()
			=> E_UMovementComponent_GetMaxSpeed(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public virtual float GetMaxSpeedModifier()
			=> E_UMovementComponent_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public virtual float GetModifiedMaxSpeed()
			=> E_UMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Calculate a movement adjustment to try to move out of a penetration from a failed move. </para>
		/// <param name="Hit">the result of the failed move </param>
		/// <return>The adjustment to use after a failed move, or a zero vector if no attempt should be made. </return>
		/// </summary>
		public virtual FVector GetPenetrationAdjustment(FHitResult Hit)
			=> E_UMovementComponent_GetPenetrationAdjustment(this, Hit);
		
		
		/// <summary>
		/// <para>Get the plane constraint axis setting. </para>
		/// </summary>
		public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
			=> (EPlaneConstraintAxisSetting)E_UMovementComponent_GetPlaneConstraintAxisSetting(this);
		
		
		/// <summary>
		/// <para>Helper to compute the plane constraint axis from the current setting. </para>
		/// <param name="AxisSetting">Setting to use when computing the axis. </param>
		/// <return>Plane constraint axis/normal. </return>
		/// </summary>
		protected FVector GetPlaneConstraintNormalFromAxisSetting(EPlaneConstraintAxisSetting AxisSetting)
			=> E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(this, (byte)AxisSetting);
		
		
		/// <summary>
		/// <para>Called for Blocking impact </para>
		/// <param name="Hit">Describes the collision. </param>
		/// <param name="TimeSlice">Time period for the simulation that produced this hit.  Useful for </param>
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// <para>be sure to handle that. </para>
		/// <param name="MoveDelta">Attempted move that resulted in the hit. </param>
		/// </summary>
		public virtual void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta)
			=> E_UMovementComponent_HandleImpact(this, Hit, TimeSlice, MoveDelta);
		
		
		/// <summary>
		/// <para>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance. </para>
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// <para>can cause the max speed to be violated. </para>
		/// </summary>
		public virtual bool IsExceedingMaxSpeed(float MaxSpeed)
			=> E_UMovementComponent_IsExceedingMaxSpeed(this, MaxSpeed);
		
		
		/// <summary>
		/// <para>return true if it's in PhysicsVolume with water flag </para>
		/// </summary>
		public virtual bool IsInWater()
			=> E_UMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public virtual float K2_GetMaxSpeedModifier()
			=> E_UMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public virtual float K2_GetModifiedMaxSpeed()
			=> E_UMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation. </para>
		/// <para>Respects the plane constraint, if enabled. </para>
		/// <return>True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit. </return>
		/// </summary>
		public bool MoveUpdatedComponent(FVector Delta, FRotator NewRotation, FHitResult OutHit, bool bSweep = true, bool bTeleport = false)
			=> E_UMovementComponent_K2_MoveUpdatedComponent(this, Delta, NewRotation, OutHit, bSweep, bTeleport);
		
		protected virtual bool MoveUpdatedComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, ETeleportType Teleport)
			=> E_UMovementComponent_MoveUpdatedComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Called by owning Actor upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public virtual void OnTeleported()
			=> E_UMovementComponent_OnTeleported(this);
		
		protected virtual bool ResolvePenetrationImpl(FVector Adjustment, FHitResult Hit, FQuat NewRotation)
			=> E_UMovementComponent_ResolvePenetrationImpl(this, Adjustment, Hit, NewRotation);
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
			=> E_UMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)NewAxisSetting);
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_UMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
			=> E_UMovementComponent_SetPlaneConstraintFromVectors(this, Forward, Up);
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public virtual void SetPlaneConstraintNormal(FVector PlaneNormal)
			=> E_UMovementComponent_SetPlaneConstraintNormal(this, PlaneNormal);
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public virtual void SetPlaneConstraintOrigin(FVector PlaneOrigin)
			=> E_UMovementComponent_SetPlaneConstraintOrigin(this, PlaneOrigin);
		
		
		/// <summary>
		/// <para>Assign the component we move and update. </para>
		/// </summary>
		public virtual void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
			=> E_UMovementComponent_SetUpdatedComponent(this, NewUpdatedComponent);
		
		
		/// <summary>
		/// <para>Possibly skip update if moved component is not rendered or can't move. </para>
		/// <param name="DeltaTime">todo this parameter is not used in the function. </param>
		/// <return>true if component movement update should be skipped </return>
		/// </summary>
		public virtual bool ShouldSkipUpdate(float DeltaTime)
			=> E_UMovementComponent_ShouldSkipUpdate(this, DeltaTime);
		
		public virtual bool SkipUpdate(float DeltaTime)
			=> E_UMovementComponent_SkipUpdate(this, DeltaTime);
		
		
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
		public virtual float SlideAlongSurface(FVector Delta, float Time, FVector Normal, FHitResult Hit, bool bHandleImpact)
			=> E_UMovementComponent_SlideAlongSurface(this, Delta, Time, Normal, Hit, bHandleImpact);
		
		
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
		public virtual void TwoWallAdjust(FVector Delta, FHitResult Hit, FVector OldHitNormal)
			=> E_UMovementComponent_TwoWallAdjust(this, Delta, Hit, OldHitNormal);
		
		
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
		
		public static implicit operator IntPtr(UMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMovementComponent>(PtrDesc);
		}}}
