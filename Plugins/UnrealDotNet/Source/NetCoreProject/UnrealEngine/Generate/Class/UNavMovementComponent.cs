using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

namespace UnrealEngine
{
	public  partial class UNavMovementComponent : UMovementComponent
	{
		public UNavMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UNavMovementComponent(UObject Parent = null, string Name = "NavMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UNavMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UNavMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverCrouch(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverFly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverJump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverMoveOnGround(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverSwim(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStartPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStopPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ClearFixedBrakingDistance(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocationBased(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorNavLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetPathFollowingBrakingDistance(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsCrouching(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFalling(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFlying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsJumpAllowed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsMovingOnGround(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsSwimming(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestDirectMove(IntPtr Self, IntPtr MoveVelocity, bool bForceMaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestPathMove(IntPtr Self, IntPtr MoveInput);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ResetMoveState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetFixedBrakingDistance(IntPtr Self, float DistanceToEndOfPath);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetJumpAllowed(IntPtr Self, bool bAllowed);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(IntPtr Self, bool bUpdateWithOwner);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopActiveMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopMovementKeepPathing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_UseAccelerationForPathFollowing(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <return>true if component can crouch </return>
		/// </summary>
		public bool CanEverCrouch()
			=> E_UNavMovementComponent_CanEverCrouch(this);
		
		
		/// <summary>
		/// <return>true if component can fly </return>
		/// </summary>
		public bool CanEverFly()
			=> E_UNavMovementComponent_CanEverFly(this);
		
		
		/// <summary>
		/// <return>true if component can jump </return>
		/// </summary>
		public bool CanEverJump()
			=> E_UNavMovementComponent_CanEverJump(this);
		
		
		/// <summary>
		/// <return>true if component can move along the ground (walk, drive, etc) </return>
		/// </summary>
		public bool CanEverMoveOnGround()
			=> E_UNavMovementComponent_CanEverMoveOnGround(this);
		
		
		/// <summary>
		/// <return>true if component can swim </return>
		/// </summary>
		public bool CanEverSwim()
			=> E_UNavMovementComponent_CanEverSwim(this);
		
		
		/// <summary>
		/// <return>true if path following can start </return>
		/// </summary>
		public virtual bool CanStartPathFollowing()
			=> E_UNavMovementComponent_CanStartPathFollowing(this);
		
		
		/// <summary>
		/// <para>check if current move target can be reached right now if positions are matching </para>
		/// <para>(e.g. performing scripted move and can't stop) </para>
		/// </summary>
		public virtual bool CanStopPathFollowing()
			=> E_UNavMovementComponent_CanStopPathFollowing(this);
		
		
		/// <summary>
		/// <para>clears fixed braking distance </para>
		/// </summary>
		public void ClearFixedBrakingDistance()
			=> E_UNavMovementComponent_ClearFixedBrakingDistance(this);
		
		
		/// <summary>
		/// <para>@returns location of controlled actor's "feet" meaning center of bottom of collision bounding box </para>
		/// </summary>
		public FVector GetActorFeetLocation()
			=> E_UNavMovementComponent_GetActorFeetLocation(this);
		
		
		/// <summary>
		/// <para>@returns based location of controlled actor </para>
		/// </summary>
		public virtual FBasedPosition GetActorFeetLocationBased()
			=> E_UNavMovementComponent_GetActorFeetLocationBased(this);
		
		
		/// <summary>
		/// <para>@returns location of controlled actor - meaning center of collision bounding box </para>
		/// </summary>
		public FVector GetActorLocation()
			=> E_UNavMovementComponent_GetActorLocation(this);
		
		
		/// <summary>
		/// <para>@returns navigation location of controlled actor </para>
		/// </summary>
		public FVector GetActorNavLocation()
			=> E_UNavMovementComponent_GetActorNavLocation(this);
		
		
		/// <summary>
		/// <para>@returns braking distance for acceleration driven path following </para>
		/// </summary>
		public virtual float GetPathFollowingBrakingDistance(float MaxSpeed)
			=> E_UNavMovementComponent_GetPathFollowingBrakingDistance(this, MaxSpeed);
		
		
		/// <summary>
		/// <return>true if currently crouching </return>
		/// </summary>
		public virtual bool IsCrouching()
			=> E_UNavMovementComponent_IsCrouching(this);
		
		
		/// <summary>
		/// <return>true if currently falling (not flying, in a non-fluid volume, and not on the ground) </return>
		/// </summary>
		public virtual bool IsFalling()
			=> E_UNavMovementComponent_IsFalling(this);
		
		
		/// <summary>
		/// <return>true if currently flying (moving through a non-fluid volume without resting on the ground) </return>
		/// </summary>
		public virtual bool IsFlying()
			=> E_UNavMovementComponent_IsFlying(this);
		
		
		/// <summary>
		/// <return>true if component is allowed to jump </return>
		/// </summary>
		public bool IsJumpAllowed()
			=> E_UNavMovementComponent_IsJumpAllowed(this);
		
		
		/// <summary>
		/// <return>true if currently moving on the ground (e.g. walking or driving) </return>
		/// </summary>
		public virtual bool IsMovingOnGround()
			=> E_UNavMovementComponent_IsMovingOnGround(this);
		
		
		/// <summary>
		/// <return>true if currently swimming (moving through a fluid volume) </return>
		/// </summary>
		public virtual bool IsSwimming()
			=> E_UNavMovementComponent_IsSwimming(this);
		
		
		/// <summary>
		/// <para>path following: request new velocity </para>
		/// </summary>
		public virtual void RequestDirectMove(FVector MoveVelocity, bool bForceMaxSpeed)
			=> E_UNavMovementComponent_RequestDirectMove(this, MoveVelocity, bForceMaxSpeed);
		
		
		/// <summary>
		/// <para>path following: request new move input (normal vector = full strength) </para>
		/// </summary>
		public virtual void RequestPathMove(FVector MoveInput)
			=> E_UNavMovementComponent_RequestPathMove(this, MoveInput);
		
		
		/// <summary>
		/// <para>Resets runtime movement state to character's movement capabilities </para>
		/// </summary>
		public void ResetMoveState()
			=> E_UNavMovementComponent_ResetMoveState(this);
		
		
		/// <summary>
		/// <para>set fixed braking distance </para>
		/// </summary>
		public void SetFixedBrakingDistance(float DistanceToEndOfPath)
			=> E_UNavMovementComponent_SetFixedBrakingDistance(this, DistanceToEndOfPath);
		
		
		/// <summary>
		/// <param name="bAllowed">true if component is allowed to jump </param>
		/// </summary>
		public void SetJumpAllowed(bool bAllowed)
			=> E_UNavMovementComponent_SetJumpAllowed(this, bAllowed);
		
		public void SetUpdateNavAgentWithOwnersCollisions(bool bUpdateWithOwner)
			=> E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(this, bUpdateWithOwner);
		
		public bool ShouldUpdateNavAgentWithOwnersCollision()
			=> E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(this);
		
		
		/// <summary>
		/// <para>Stops applying further movement (usually zeros acceleration). </para>
		/// </summary>
		public virtual void StopActiveMovement()
			=> E_UNavMovementComponent_StopActiveMovement(this);
		
		
		/// <summary>
		/// <para>Stops movement immediately (reset velocity) but keeps following current path </para>
		/// </summary>
		public void StopMovementKeepPathing()
			=> E_UNavMovementComponent_StopMovementKeepPathing(this);
		
		public bool UseAccelerationForPathFollowing()
			=> E_UNavMovementComponent_UseAccelerationForPathFollowing(this);
		
		#endregion
		
		public static implicit operator IntPtr(UNavMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UNavMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UNavMovementComponent>(PtrDesc);
		}}}
