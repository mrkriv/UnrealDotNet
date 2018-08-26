// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

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
		public virtual float GetPathFollowingBrakingDistance(float maxSpeed)
			=> E_UNavMovementComponent_GetPathFollowingBrakingDistance(this, maxSpeed);
		
		
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
		public virtual void RequestDirectMove(FVector moveVelocity, bool bForceMaxSpeed)
			=> E_UNavMovementComponent_RequestDirectMove(this, moveVelocity, bForceMaxSpeed);
		
		
		/// <summary>
		/// <para>path following: request new move input (normal vector = full strength) </para>
		/// </summary>
		public virtual void RequestPathMove(FVector moveInput)
			=> E_UNavMovementComponent_RequestPathMove(this, moveInput);
		
		
		/// <summary>
		/// <para>Resets runtime movement state to character's movement capabilities </para>
		/// </summary>
		public void ResetMoveState()
			=> E_UNavMovementComponent_ResetMoveState(this);
		
		
		/// <summary>
		/// <para>set fixed braking distance </para>
		/// </summary>
		public void SetFixedBrakingDistance(float distanceToEndOfPath)
			=> E_UNavMovementComponent_SetFixedBrakingDistance(this, distanceToEndOfPath);
		
		
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
		
		public void UpdateNavAgent(AActor inOwner)
			=> E_UNavMovementComponent_UpdateNavAgent(this, inOwner);
		
		public void UpdateNavAgent(UCapsuleComponent capsuleComponent)
			=> E_UNavMovementComponent_UpdateNavAgent_o1(this, capsuleComponent);
		
		public bool UseAccelerationForPathFollowing()
			=> E_UNavMovementComponent_UseAccelerationForPathFollowing(this);
		
		#endregion
		
		public static implicit operator IntPtr(UNavMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UNavMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UNavMovementComponent>(PtrDesc);
		}}}
