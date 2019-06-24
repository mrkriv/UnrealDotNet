// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:159

namespace UnrealEngine
{
	[ManageType("ManageCharacterMovementComponent")]
	public partial class ManageCharacterMovementComponent : UCharacterMovementComponent, IManageWrapper
	{
		public ManageCharacterMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_AdjustFloorHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_AdjustProxyCapsuleSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ApplyAccumulatedForces(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ApplyDownwardForce(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ApplyNetworkMovementMode(IntPtr self, byte receivedMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ApplyRepulsionForce(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ApplyVelocityBraking(IntPtr self, float deltaTime, float friction, float brakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_CalcVelocity(IntPtr self, float deltaTime, float friction, bool bFluid, float brakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ClearAccumulatedForces(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ClientAckGoodMove(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ClientAckGoodMove_Implementation(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_Crouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_DisableMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ForceReplicationUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_MaintainHorizontalGroundVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_MaybeSaveBaseLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_MaybeUpdateBasedMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_NotifyJumpApex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnClientTimeStampResetDetected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnTimeDiscrepancyDetected(IntPtr self, float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PerformMovement(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysCustom(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysFalling(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysFlying(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysicsRotation(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysNavWalking(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysSwimming(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PhysWalking(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SaveBaseLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetDefaultMovementMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetNavWalkingPhysics(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SimulateMovement(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SmoothClientPosition(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_StartNewPhysics(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UnCrouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateBasedMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateCharacterStateAfterMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateFloorFromAdjustment(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateFromCompressedFlags(IntPtr self, byte flags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateProxyAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_StopActiveMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnTeleported(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetPlaneConstraintEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SnapUpdatedComponentToPlane(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_StopMovementImmediately(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateComponentVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UpdateTickRegistration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_Activate(IntPtr self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_CreateRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_Deactivate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_DestroyComponent(IntPtr self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_DestroyRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_InitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_InvalidateLightingCacheDetailed(IntPtr self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnActorEnableCollisionChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnComponentCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnComponentDestroyed(IntPtr self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnCreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnDestroyPhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnRegister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnRep_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnUnregister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_RegisterComponentTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SendRenderDynamicData_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SendRenderTransform_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetActive(IntPtr self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetAutoActivate(IntPtr self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetComponentTickEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_SetComponentTickEnabledAsync(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ToggleActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_UninitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCharacterMovementComponent_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Adjust distance from floor, trying to maintain a slight offset from the floor when walking (based on CurrentFloor).
		/// </summary>
		public override void AdjustFloorHeight()
			=> E__Supper__UCharacterMovementComponent_AdjustFloorHeight(this);
		
		
		/// <summary>
		/// Adjust the size of the capsule on simulated proxies, to avoid overlaps due to replication rounding.
		/// <para>Changes to the capsule size on the proxy should set bShrinkProxyCapsule=true and possibly call AdjustProxyCapsuleSize() immediately if applicable. </para>
		/// </summary>
		protected override void AdjustProxyCapsuleSize()
			=> E__Supper__UCharacterMovementComponent_AdjustProxyCapsuleSize(this);
		
		
		/// <summary>
		/// Applies momentum accumulated through AddImpulse() and AddForce(), then clears those forces. Does *not* use ClearAccumulatedForces() since that would clear pending launch velocity as well.
		/// </summary>
		public override void ApplyAccumulatedForces(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_ApplyAccumulatedForces(this, deltaSeconds);
		
		
		/// <summary>
		/// Applies downward force when walking on top of physics objects.
		/// </summary>
		/// <param name="deltaSeconds">Time elapsed since last frame.</param>
		public override void ApplyDownwardForce(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_ApplyDownwardForce(this, deltaSeconds);
		
		public override void ApplyNetworkMovementMode(byte receivedMode)
			=> E__Supper__UCharacterMovementComponent_ApplyNetworkMovementMode(this, receivedMode);
		
		
		/// <summary>
		/// Applies repulsion force to all touched components.
		/// </summary>
		public override void ApplyRepulsionForce(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_ApplyRepulsionForce(this, deltaSeconds);
		
		
		/// <summary>
		/// Slows towards stop.
		/// </summary>
		protected override void ApplyVelocityBraking(float deltaTime, float friction, float brakingDeceleration)
			=> E__Supper__UCharacterMovementComponent_ApplyVelocityBraking(this, deltaTime, friction, brakingDeceleration);
		
		
		/// <summary>
		/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// </summary>
		/// <param name="deltaTime">time elapsed since last frame.</param>
		/// <param name="friction">coefficient of friction when not accelerating, or in the direction opposite acceleration.</param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration.</param>
		/// <param name="brakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity.</param>
		public override void CalcVelocity(float deltaTime, float friction, bool bFluid, float brakingDeceleration)
			=> E__Supper__UCharacterMovementComponent_CalcVelocity(this, deltaTime, friction, bFluid, brakingDeceleration);
		
		
		/// <summary>
		/// Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.
		/// </summary>
		public override void ClearAccumulatedForces()
			=> E__Supper__UCharacterMovementComponent_ClearAccumulatedForces(this);
		
		
		/// <summary>
		/// If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves
		/// </summary>
		public override void ClientAckGoodMove(float timeStamp)
			=> E__Supper__UCharacterMovementComponent_ClientAckGoodMove(this, timeStamp);
		
		public override void ClientAckGoodMove_Implementation(float timeStamp)
			=> E__Supper__UCharacterMovementComponent_ClientAckGoodMove_Implementation(this, timeStamp);
		
		
		/// <summary>
		/// Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful.
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public override void Crouch(bool bClientSimulation)
			=> E__Supper__UCharacterMovementComponent_Crouch(this, bClientSimulation);
		
		
		/// <summary>
		/// Make movement impossible (sets movement mode to MOVE_None).
		/// </summary>
		public override void DisableMovement()
			=> E__Supper__UCharacterMovementComponent_DisableMovement(this);
		
		
		/// <summary>
		/// Force a client update by making it appear on the server that the client hasn't updated in a long time.
		/// </summary>
		public override void ForceReplicationUpdate()
			=> E__Supper__UCharacterMovementComponent_ForceReplicationUpdate(this);
		
		
		/// <summary>
		/// Adjusts velocity when walking so that Z velocity is zero.
		/// <para>When bMaintainHorizontalGroundVelocity is false, also rescales the velocity vector to maintain the original magnitude, but in the horizontal direction. </para>
		/// </summary>
		protected override void MaintainHorizontalGroundVelocity()
			=> E__Supper__UCharacterMovementComponent_MaintainHorizontalGroundVelocity(this);
		
		
		/// <summary>
		/// Call SaveBaseLocation() if not deferring updates (bDeferUpdateBasedMovement is false).
		/// </summary>
		public override void MaybeSaveBaseLocation()
			=> E__Supper__UCharacterMovementComponent_MaybeSaveBaseLocation(this);
		
		
		/// <summary>
		/// Update or defer updating of position based on Base movement
		/// </summary>
		public override void MaybeUpdateBasedMovement(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_MaybeUpdateBasedMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Called if bNotifyApex is true and character has just passed the apex of its jump.
		/// </summary>
		public override void NotifyJumpApex()
			=> E__Supper__UCharacterMovementComponent_NotifyJumpApex(this);
		
		
		/// <summary>
		/// Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid.
		/// </summary>
		protected override void OnClientTimeStampResetDetected()
			=> E__Supper__UCharacterMovementComponent_OnClientTimeStampResetDetected(this);
		
		
		/// <summary>
		/// Called by UCharacterMovementComponent::ProcessClientTimeStampForTimeDiscrepancy() (on server) when the time from client moves
		/// <para>significantly differs from the server time, indicating potential time manipulation by clients (speed hacks, significant network </para>
		/// issues, client performance problems)
		/// <para>by MovementTimeDiscrepancy config variables in AGameNetworkManager, and is the value with which </para>
		/// we test against to trigger this function. This is reset when MovementTimeDiscrepancy resolution
		/// <para>is enabled </para>
		/// and does NOT get affected by MovementTimeDiscrepancy resolution, and is useful as a longer-term
		/// <para>view of how the given client is performing. High magnitude unbounded error points to </para>
		/// intentional tampering by a client vs. occasional "naturally caused" spikes in error due to
		/// <para>burst packet loss/performance hitches </para>
		/// of LifetimeUnboundedError)
		/// <para>current move that has caused TimeDiscrepancy to accumulate enough to trigger detection. </para>
		/// </summary>
		/// <param name="currentTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is bounded</param>
		/// <param name="lifetimeRawTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is unbounded</param>
		/// <param name="lifetime">Game time over which LifetimeRawTimeDiscrepancy has accrued (useful for determining severity</param>
		/// <param name="currentMoveError">Time difference between client ServerMove and how much time has passed on the server for the</param>
		protected override void OnTimeDiscrepancyDetected(float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError)
			=> E__Supper__UCharacterMovementComponent_OnTimeDiscrepancyDetected(this, currentTimeDiscrepancy, lifetimeRawTimeDiscrepancy, lifetime, currentMoveError);
		
		
		/// <summary>
		/// Perform movement on an autonomous client
		/// </summary>
		protected override void PerformMovement(float deltaTime)
			=> E__Supper__UCharacterMovementComponent_PerformMovement(this, deltaTime);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysCustom(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysCustom(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Handle falling movement.
		/// </summary>
		public override void PhysFalling(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysFalling(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysFlying(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysFlying(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Perform rotation over deltaTime
		/// </summary>
		public override void PhysicsRotation(float deltaTime)
			=> E__Supper__UCharacterMovementComponent_PhysicsRotation(this, deltaTime);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysNavWalking(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysNavWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysSwimming(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysSwimming(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysWalking(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_PhysWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update.
		/// </summary>
		public override void SaveBaseLocation()
			=> E__Supper__UCharacterMovementComponent_SaveBaseLocation(this);
		
		
		/// <summary>
		/// Set movement mode to the default based on the current physics volume.
		/// </summary>
		public override void SetDefaultMovementMode()
			=> E__Supper__UCharacterMovementComponent_SetDefaultMovementMode(this);
		
		
		/// <summary>
		/// Switch collision settings for NavWalking mode (ignore world collisions)
		/// </summary>
		protected override void SetNavWalkingPhysics(bool bEnable)
			=> E__Supper__UCharacterMovementComponent_SetNavWalkingPhysics(this, bEnable);
		
		
		/// <summary>
		/// Simulate movement on a non-owning client. Called by SimulatedTick().
		/// </summary>
		protected override void SimulateMovement(float deltaTime)
			=> E__Supper__UCharacterMovementComponent_SimulateMovement(this, deltaTime);
		
		
		/// <summary>
		/// Smooth mesh location for network interpolation, based on values set up by SmoothCorrection.
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// This function is not called when bNetworkSmoothingComplete is true.
		/// </summary>
		/// <param name="deltaSeconds">Time since last update.</param>
		protected override void SmoothClientPosition(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_SmoothClientPosition(this, deltaSeconds);
		
		
		/// <summary>
		/// changes physics based on MovementMode
		/// </summary>
		public override void StartNewPhysics(float deltaTime, int iterations)
			=> E__Supper__UCharacterMovementComponent_StartNewPhysics(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful.
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public override void UnCrouch(bool bClientSimulation)
			=> E__Supper__UCharacterMovementComponent_UnCrouch(this, bClientSimulation);
		
		
		/// <summary>
		/// Update position based on Base movement
		/// </summary>
		public override void UpdateBasedMovement(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_UpdateBasedMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Update the character state in PerformMovement after the position change. Some rotation updates happen after this.
		/// </summary>
		public override void UpdateCharacterStateAfterMovement(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_UpdateCharacterStateAfterMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Update the character state in PerformMovement right before doing the actual position change
		/// </summary>
		public override void UpdateCharacterStateBeforeMovement(float deltaSeconds)
			=> E__Supper__UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base.
		/// </summary>
		public override void UpdateFloorFromAdjustment()
			=> E__Supper__UCharacterMovementComponent_UpdateFloorFromAdjustment(this);
		
		
		/// <summary>
		/// Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character.
		/// </summary>
		protected override void UpdateFromCompressedFlags(byte flags)
			=> E__Supper__UCharacterMovementComponent_UpdateFromCompressedFlags(this, flags);
		
		
		/// <summary>
		/// Used during SimulateMovement for proxies, this computes a new value for Acceleration before running proxy simulation.
		/// <para>The base implementation simply derives a value from the normalized Velocity value, which may help animations that want some indication of the direction of movement. </para>
		/// Proxies don't implement predictive acceleration by default so this value is not used for the actual simulation.
		/// </summary>
		public override void UpdateProxyAcceleration()
			=> E__Supper__UCharacterMovementComponent_UpdateProxyAcceleration(this);
		
		
		/// <summary>
		/// Stops applying further movement (usually zeros acceleration).
		/// </summary>
		public override void StopActiveMovement()
			=> E__Supper__UCharacterMovementComponent_StopActiveMovement(this);
		
		
		/// <summary>
		/// Called by owning Actor upon successful teleport from AActor::TeleportTo().
		/// </summary>
		public override void OnTeleported()
			=> E__Supper__UCharacterMovementComponent_OnTeleported(this);
		
		
		/// <summary>
		/// Sets whether or not the plane constraint is enabled.
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled)
			=> E__Supper__UCharacterMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// Snap the updated component to the plane constraint, if enabled.
		/// </summary>
		public override void SnapUpdatedComponentToPlane()
			=> E__Supper__UCharacterMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).
		/// </summary>
		public override void StopMovementImmediately()
			=> E__Supper__UCharacterMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed.
		/// </summary>
		public override void UpdateComponentVelocity()
			=> E__Supper__UCharacterMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent.
		/// </summary>
		public override void UpdateTickRegistration()
			=> E__Supper__UCharacterMovementComponent_UpdateTickRegistration(this);
		
		
		/// <summary>
		/// Activates the SceneComponent, should be overridden by native child classes.
		/// </summary>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false.</param>
		public override void Activate(bool bReset)
			=> E__Supper__UCharacterMovementComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// BeginsPlay for the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component).
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// Actor/Component gets BeginPlay.
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E__Supper__UCharacterMovementComponent_BeginPlay(this);
		
		
		/// <summary>
		/// Used to create any rendering thread information for this component
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void CreateRenderState_Concurrent()
			=> E__Supper__UCharacterMovementComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// Deactivates the SceneComponent.
		/// </summary>
		public override void Deactivate()
			=> E__Supper__UCharacterMovementComponent_Deactivate(this);
		
		
		/// <summary>
		/// Unregister the component, remove it from its outer Actor's Components array and mark for pending kill.
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren)
			=> E__Supper__UCharacterMovementComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// Used to shut down any rendering thread structure for this component
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void DestroyRenderState_Concurrent()
			=> E__Supper__UCharacterMovementComponent_DestroyRenderState_Concurrent(this);
		
		
		/// <summary>
		/// Initializes the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component).
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// Requires component to be registered, and bWantsInitializeComponent to be true.
		/// </summary>
		public override void InitializeComponent()
			=> E__Supper__UCharacterMovementComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// Called when this actor component has moved, allowing it to discard statically cached lighting information.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E__Supper__UCharacterMovementComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// Called on each component when the Actor's bEnableCollisionChanged flag changes
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E__Supper__UCharacterMovementComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// Called when a component is created (not loaded). This can happen in the editor or during gameplay
		/// </summary>
		public override void OnComponentCreated()
			=> E__Supper__UCharacterMovementComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// Called when a component is destroyed
		/// </summary>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations</param>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E__Supper__UCharacterMovementComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// Used to create any physics engine information for this component
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E__Supper__UCharacterMovementComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// Used to shut down and physics engine structure for this component
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E__Supper__UCharacterMovementComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called.
		/// </summary>
		protected override void OnRegister()
			=> E__Supper__UCharacterMovementComponent_OnRegister(this);
		
		public override void OnRep_IsActive()
			=> E__Supper__UCharacterMovementComponent_OnRep_IsActive(this);
		
		
		/// <summary>
		/// Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called.
		/// </summary>
		protected override void OnUnregister()
			=> E__Supper__UCharacterMovementComponent_OnUnregister(this);
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterComponentTickFunctions(bool bRegister)
			=> E__Supper__UCharacterMovementComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// Called to send dynamic data for this component to the rendering thread
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E__Supper__UCharacterMovementComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// Called to send a transform update for this component to the rendering thread
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void SendRenderTransform_Concurrent()
			=> E__Supper__UCharacterMovementComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// Sets whether the component is active or not
		/// </summary>
		/// <param name="bNewActive">The new active state of the component</param>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false.</param>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E__Supper__UCharacterMovementComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// Sets whether the component should be auto activate or not. Only safe during construction scripts.
		/// </summary>
		/// <param name="bNewAutoActivate">The new auto activate state of the component</param>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E__Supper__UCharacterMovementComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered
		/// </summary>
		/// <param name="bEnabled">Whether it should be enabled or not</param>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E__Supper__UCharacterMovementComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// Spawns a task on GameThread that will call SetComponentTickEnabled
		/// </summary>
		/// <param name="bEnabled">Whether it should be enabled or not</param>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E__Supper__UCharacterMovementComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// Toggles the active state of the component
		/// </summary>
		public override void ToggleActive()
			=> E__Supper__UCharacterMovementComponent_ToggleActive(this);
		
		
		/// <summary>
		/// Handle this component being Uninitialized.
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E__Supper__UCharacterMovementComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__UCharacterMovementComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__UCharacterMovementComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__UCharacterMovementComponent_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__UCharacterMovementComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__UCharacterMovementComponent_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__UCharacterMovementComponent_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__UCharacterMovementComponent_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__UCharacterMovementComponent_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__UCharacterMovementComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__UCharacterMovementComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__UCharacterMovementComponent_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__UCharacterMovementComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__UCharacterMovementComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__UCharacterMovementComponent_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__UCharacterMovementComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManageCharacterMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacterMovementComponent>(PtrDesc);
		}}}
