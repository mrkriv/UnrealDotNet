// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

namespace UnrealEngine
{
	public  partial class UNavMovementComponent : UMovementComponent
	{
		public UNavMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UNavMovementComponent(UObject Parent = null, string Name = "NavMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UNavMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UNavMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverCrouch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverFly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverJump(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverMoveOnGround(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverSwim(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStartPathFollowing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStopPathFollowing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ClearFixedBrakingDistance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocationBased(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorNavLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetPathFollowingBrakingDistance(IntPtr self, float maxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsCrouching(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFalling(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFlying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsJumpAllowed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsMovingOnGround(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsSwimming(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestDirectMove(IntPtr self, IntPtr moveVelocity, bool bForceMaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestPathMove(IntPtr self, IntPtr moveInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ResetMoveState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetFixedBrakingDistance(IntPtr self, float distanceToEndOfPath);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetJumpAllowed(IntPtr self, bool bAllowed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(IntPtr self, bool bUpdateWithOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopActiveMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopMovementKeepPathing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UpdateNavAgent(IntPtr self, IntPtr inOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UpdateNavAgent_o1(IntPtr self, IntPtr capsuleComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_UseAccelerationForPathFollowing(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns true if component can crouch
		/// </summary>
		public bool CanEverCrouch()
			=> E_UNavMovementComponent_CanEverCrouch(this);
		
		
		/// <summary>
		/// Returns true if component can fly
		/// </summary>
		public bool CanEverFly()
			=> E_UNavMovementComponent_CanEverFly(this);
		
		
		/// <summary>
		/// Returns true if component can jump
		/// </summary>
		public bool CanEverJump()
			=> E_UNavMovementComponent_CanEverJump(this);
		
		
		/// <summary>
		/// Returns true if component can move along the ground (walk, drive, etc)
		/// </summary>
		public bool CanEverMoveOnGround()
			=> E_UNavMovementComponent_CanEverMoveOnGround(this);
		
		
		/// <summary>
		/// Returns true if component can swim
		/// </summary>
		public bool CanEverSwim()
			=> E_UNavMovementComponent_CanEverSwim(this);
		
		
		/// <summary>
		/// Returns true if path following can start
		/// </summary>
		public virtual bool CanStartPathFollowing()
			=> E_UNavMovementComponent_CanStartPathFollowing(this);
		
		
		/// <summary>
		/// check if current move target can be reached right now if positions are matching
		/// <para>(e.g. performing scripted move and can't stop) </para>
		/// </summary>
		public virtual bool CanStopPathFollowing()
			=> E_UNavMovementComponent_CanStopPathFollowing(this);
		
		
		/// <summary>
		/// clears fixed braking distance
		/// </summary>
		public void ClearFixedBrakingDistance()
			=> E_UNavMovementComponent_ClearFixedBrakingDistance(this);
		
		
		/// <summary>
		/// Returns location of controlled actor's "feet" meaning center of bottom of collision bounding box
		/// </summary>
		public FVector GetActorFeetLocation()
			=> E_UNavMovementComponent_GetActorFeetLocation(this);
		
		
		/// <summary>
		/// Returns based location of controlled actor
		/// </summary>
		public virtual FBasedPosition GetActorFeetLocationBased()
			=> E_UNavMovementComponent_GetActorFeetLocationBased(this);
		
		
		/// <summary>
		/// Returns location of controlled actor - meaning center of collision bounding box
		/// </summary>
		public FVector GetActorLocation()
			=> E_UNavMovementComponent_GetActorLocation(this);
		
		
		/// <summary>
		/// Returns navigation location of controlled actor
		/// </summary>
		public FVector GetActorNavLocation()
			=> E_UNavMovementComponent_GetActorNavLocation(this);
		
		
		/// <summary>
		/// Returns braking distance for acceleration driven path following
		/// </summary>
		public virtual float GetPathFollowingBrakingDistance(float maxSpeed)
			=> E_UNavMovementComponent_GetPathFollowingBrakingDistance(this, maxSpeed);
		
		
		/// <summary>
		/// Returns true if currently crouching
		/// </summary>
		public virtual bool IsCrouching()
			=> E_UNavMovementComponent_IsCrouching(this);
		
		
		/// <summary>
		/// Returns true if currently falling (not flying, in a non-fluid volume, and not on the ground)
		/// </summary>
		public virtual bool IsFalling()
			=> E_UNavMovementComponent_IsFalling(this);
		
		
		/// <summary>
		/// Returns true if currently flying (moving through a non-fluid volume without resting on the ground)
		/// </summary>
		public virtual bool IsFlying()
			=> E_UNavMovementComponent_IsFlying(this);
		
		
		/// <summary>
		/// Returns true if component is allowed to jump
		/// </summary>
		public bool IsJumpAllowed()
			=> E_UNavMovementComponent_IsJumpAllowed(this);
		
		
		/// <summary>
		/// Returns true if currently moving on the ground (e.g. walking or driving)
		/// </summary>
		public virtual bool IsMovingOnGround()
			=> E_UNavMovementComponent_IsMovingOnGround(this);
		
		
		/// <summary>
		/// Returns true if currently swimming (moving through a fluid volume)
		/// </summary>
		public virtual bool IsSwimming()
			=> E_UNavMovementComponent_IsSwimming(this);
		
		
		/// <summary>
		/// path following: request new velocity
		/// </summary>
		public virtual void RequestDirectMove(FVector moveVelocity, bool bForceMaxSpeed)
			=> E_UNavMovementComponent_RequestDirectMove(this, moveVelocity, bForceMaxSpeed);
		
		
		/// <summary>
		/// path following: request new move input (normal vector = full strength)
		/// </summary>
		public virtual void RequestPathMove(FVector moveInput)
			=> E_UNavMovementComponent_RequestPathMove(this, moveInput);
		
		
		/// <summary>
		/// Resets runtime movement state to character's movement capabilities
		/// </summary>
		public void ResetMoveState()
			=> E_UNavMovementComponent_ResetMoveState(this);
		
		
		/// <summary>
		/// set fixed braking distance
		/// </summary>
		public void SetFixedBrakingDistance(float distanceToEndOfPath)
			=> E_UNavMovementComponent_SetFixedBrakingDistance(this, distanceToEndOfPath);
		
		
		/// <summary>
		/// Sets whether this component is allowed to jump
		/// </summary>
		public void SetJumpAllowed(bool bAllowed)
			=> E_UNavMovementComponent_SetJumpAllowed(this, bAllowed);
		
		public void SetUpdateNavAgentWithOwnersCollisions(bool bUpdateWithOwner)
			=> E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(this, bUpdateWithOwner);
		
		public bool ShouldUpdateNavAgentWithOwnersCollision()
			=> E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(this);
		
		
		/// <summary>
		/// Stops applying further movement (usually zeros acceleration).
		/// </summary>
		public virtual void StopActiveMovement()
			=> E_UNavMovementComponent_StopActiveMovement(this);
		
		
		/// <summary>
		/// Stops movement immediately (reset velocity) but keeps following current path
		/// </summary>
		public void StopMovementKeepPathing()
			=> E_UNavMovementComponent_StopMovementKeepPathing(this);
		
		public void UpdateNavAgent(AActor inOwner)
			=> E_UNavMovementComponent_UpdateNavAgent(this, inOwner);
		
		public void UpdateNavAgent(UCapsuleComponent capsuleComponent)
			=> E_UNavMovementComponent_UpdateNavAgent_o1(this, capsuleComponent);
		
		public bool UseAccelerationForPathFollowing()
			=> E_UNavMovementComponent_UseAccelerationForPathFollowing(this);
		
		#endregion
		
		public static implicit operator IntPtr(UNavMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UNavMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UNavMovementComponent>(PtrDesc);
		}}}
