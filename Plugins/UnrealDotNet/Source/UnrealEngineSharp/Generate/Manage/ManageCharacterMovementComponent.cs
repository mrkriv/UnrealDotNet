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
	public partial class ManageCharacterMovementComponent : UCharacterMovementComponent
	{
		public ManageCharacterMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Add force to character. Forces are accumulated each tick and applied together
		/// <para>so multiple calls to this function will accumulate. </para>
		/// Forces are scaled depending on timestep, so they can be applied each frame. If you want an
		/// <para>instantaneous force, use AddImpulse. </para>
		/// Adding a force always takes the actor's mass into account.
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// </summary>
		/// <param name="force">Force to apply.</param>
		public override void AddForce(FVector force) { }
		
		
		/// <summary>
		/// Add impulse to character. Impulses are accumulated each tick and applied together
		/// <para>so multiple calls to this function will accumulate. </para>
		/// An impulse is an instantaneous force, usually applied once. If you want to continually apply
		/// <para>forces each frame, use AddForce(). </para>
		/// Note that changing the momentum of characters like this can change the movement mode.
		/// </summary>
		/// <param name="impulse">Impulse to apply.</param>
		/// <param name="bVelocityChange">Whether or not the impulse is relative to mass.</param>
		public override void AddImpulse(FVector impulse, bool bVelocityChange) { }
		
		
		/// <summary>
		/// Adjust distance from floor, trying to maintain a slight offset from the floor when walking (based on CurrentFloor).
		/// </summary>
		public override void AdjustFloorHeight() { }
		
		
		/// <summary>
		/// Adjust the size of the capsule on simulated proxies, to avoid overlaps due to replication rounding.
		/// <para>Changes to the capsule size on the proxy should set bShrinkProxyCapsule=true and possibly call AdjustProxyCapsuleSize() immediately if applicable. </para>
		/// </summary>
		protected override void AdjustProxyCapsuleSize() { }
		
		
		/// <summary>
		/// Applies momentum accumulated through AddImpulse() and AddForce(), then clears those forces. Does *not* use ClearAccumulatedForces() since that would clear pending launch velocity as well.
		/// </summary>
		public override void ApplyAccumulatedForces(float deltaSeconds) { }
		
		
		/// <summary>
		/// Applies downward force when walking on top of physics objects.
		/// </summary>
		/// <param name="deltaSeconds">Time elapsed since last frame.</param>
		public override void ApplyDownwardForce(float deltaSeconds) { }
		
		
		/// <summary>
		/// Apply physics forces to the impacted component, if bEnablePhysicsInteraction is true.
		/// </summary>
		/// <param name="impact">HitResult that resulted in the impact</param>
		/// <param name="impactAcceleration">Acceleration of the character at the time of impact</param>
		/// <param name="impactVelocity">Velocity of the character at the time of impact</param>
		protected override void ApplyImpactPhysicsForces(FHitResult impact, FVector impactAcceleration, FVector impactVelocity) { }
		
		public override void ApplyNetworkMovementMode(byte receivedMode) { }
		
		
		/// <summary>
		/// Applies repulsion force to all touched components.
		/// </summary>
		public override void ApplyRepulsionForce(float deltaSeconds) { }
		
		
		/// <summary>
		/// Slows towards stop.
		/// </summary>
		protected override void ApplyVelocityBraking(float deltaTime, float friction, float brakingDeceleration) { }
		
		
		/// <summary>
		/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// </summary>
		/// <param name="deltaTime">time elapsed since last frame.</param>
		/// <param name="friction">coefficient of friction when not accelerating, or in the direction opposite acceleration.</param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration.</param>
		/// <param name="brakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity.</param>
		public override void CalcVelocity(float deltaTime, float friction, bool bFluid, float brakingDeceleration) { }
		
		
		/// <summary>
		/// Internal function to call OnMovementUpdated delegate on CharacterOwner.
		/// </summary>
		protected override void CallMovementUpdateDelegate(float deltaSeconds, FVector oldLocation, FVector oldVelocity) { }
		
		protected override void CapsuleTouched(UPrimitiveComponent overlappedComp, AActor other, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult) { }
		
		
		/// <summary>
		/// Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.
		/// </summary>
		public override void ClearAccumulatedForces() { }
		
		
		/// <summary>
		/// If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves
		/// </summary>
		public override void ClientAckGoodMove(float timeStamp) { }
		
		public override void ClientAckGoodMove_Implementation(float timeStamp) { }
		
		
		/// <summary>
		/// Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment.
		/// </summary>
		public override void ClientAdjustPosition(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode) { }
		
		public override void ClientAdjustPosition_Implementation(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode) { }
		
		public override void ClientVeryShortAdjustPosition(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode) { }
		
		public override void ClientVeryShortAdjustPosition_Implementation(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode) { }
		
		
		/// <summary>
		/// Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful.
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public override void Crouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// Make movement impossible (sets movement mode to MOVE_None).
		/// </summary>
		public override void DisableMovement() { }
		
		
		/// <summary>
		/// Force a client update by making it appear on the server that the client hasn't updated in a long time.
		/// </summary>
		public override void ForceReplicationUpdate() { }
		
		protected override void HandleSwimmingWallHit(FHitResult hit, float deltaTime) { }
		
		
		/// <summary>
		/// Trigger OnWalkingOffLedge event on CharacterOwner.
		/// </summary>
		public override void HandleWalkingOffLedge(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta) { }
		
		
		/// <summary>
		/// Force this pawn to bounce off its current base, which isn't an acceptable base for it.
		/// </summary>
		public override void JumpOff(AActor movementBaseActor) { }
		
		
		/// <summary>
		/// Jump onto shore from water
		/// </summary>
		public override void JumpOutOfWater(FVector wallNormal) { }
		
		
		/// <summary>
		/// Queue a pending launch with velocity LaunchVel.
		/// </summary>
		public override void Launch(FVector launchVel) { }
		
		
		/// <summary>
		/// Adjusts velocity when walking so that Z velocity is zero.
		/// <para>When bMaintainHorizontalGroundVelocity is false, also rescales the velocity vector to maintain the original magnitude, but in the horizontal direction. </para>
		/// </summary>
		protected override void MaintainHorizontalGroundVelocity() { }
		
		
		/// <summary>
		/// Call SaveBaseLocation() if not deferring updates (bDeferUpdateBasedMovement is false).
		/// </summary>
		public override void MaybeSaveBaseLocation() { }
		
		
		/// <summary>
		/// Update or defer updating of position based on Base movement
		/// </summary>
		public override void MaybeUpdateBasedMovement(float deltaSeconds) { }
		
		protected override void MoveAutonomous(float clientTimeStamp, float deltaTime, byte compressedFlags, FVector newAccel) { }
		
		
		/// <summary>
		/// Called if bNotifyApex is true and character has just passed the apex of its jump.
		/// </summary>
		public override void NotifyJumpApex() { }
		
		
		/// <summary>
		/// Notification that the character is stuck in geometry.  Only called during walking movement.
		/// </summary>
		protected override void OnCharacterStuckInGeometry(FHitResult hit) { }
		
		
		/// <summary>
		/// Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid.
		/// </summary>
		protected override void OnClientTimeStampResetDetected() { }
		
		
		/// <summary>
		/// Called after MovementMode has changed. Base implementation does special handling for starting certain modes, then notifies the CharacterOwner.
		/// </summary>
		protected override void OnMovementModeChanged(EMovementMode previousMovementMode, byte previousCustomMode) { }
		
		
		/// <summary>
		/// Event triggered at the end of a movement update. If scoped movement updates are enabled (bEnableScopedMovementUpdates), this is within such a scope.
		/// <para>If that is not desired, bind to the CharacterOwner's OnMovementUpdated event instead, as that is triggered after the scoped movement update. </para>
		/// </summary>
		protected override void OnMovementUpdated(float deltaSeconds, FVector oldLocation, FVector oldVelocity) { }
		
		
		/// <summary>
		/// Called during ApplyRootMotionSource call, useful for project-specific alerts for "something is about to be altering our movement"
		/// </summary>
		public override void OnRootMotionSourceBeingApplied(FRootMotionSource source) { }
		
		
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
		protected override void OnTimeDiscrepancyDetected(float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError) { }
		
		
		/// <summary>
		/// Event triggered when we are moving on a base but we are not able to move the full DeltaPosition because something has blocked us.
		/// <para>Note: MoveComponentFlags includes the flag to ignore the movement base while this event is fired. </para>
		/// </summary>
		/// <param name="deltaPosition">How far we tried to move with the base.</param>
		/// <param name="oldLocation">Location before we tried to move with the base.</param>
		/// <param name="moveOnBaseHit">Hit result for the object we hit when trying to move with the base.</param>
		protected override void OnUnableToFollowBaseMove(FVector deltaPosition, FVector oldLocation, FHitResult moveOnBaseHit) { }
		
		
		/// <summary>
		/// Update Velocity and Acceleration to air control in the desired Direction for character using path following.
		/// <see cref="RequestDirectMove"/>
		/// </summary>
		/// <param name="direction">is the desired direction of movement</param>
		/// <param name="zDiff">is the height difference between the destination and the Pawn's current position</param>
		public override void PerformAirControlForPathFollowing(FVector direction, float zDiff) { }
		
		
		/// <summary>
		/// Perform movement on an autonomous client
		/// </summary>
		protected override void PerformMovement(float deltaTime) { }
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysCustom(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// Handle falling movement.
		/// </summary>
		public override void PhysFalling(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysFlying(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// Perform rotation over deltaTime
		/// </summary>
		public override void PhysicsRotation(float deltaTime) { }
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysNavWalking(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysSwimming(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected override void PhysWalking(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode.
		/// </summary>
		protected override void ProcessLanded(FHitResult hit, float remainingTime, int iterations) { }
		
		
		/// <summary>
		/// Perform local movement and send the move to the server.
		/// </summary>
		protected override void ReplicateMoveToServer(float deltaTime, FVector newAcceleration) { }
		
		
		/// <summary>
		/// Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update.
		/// </summary>
		public override void SaveBaseLocation() { }
		
		
		/// <summary>
		/// Have the server check if the client is outside an error tolerance, and queue a client adjustment if so.
		/// <para>If either GetPredictionData_Server_Character()->bForceClientUpdate or ServerCheckClientError() are true, the client adjustment will be sent. </para>
		/// RelativeClientLocation will be a relative location if MovementBaseUtility::UseRelativePosition(ClientMovementBase) is true, or a world location if false.
		/// <see cref="ServerCheckClientError"/>
		/// </summary>
		protected override void ServerMoveHandleClientError(float clientTimeStamp, float deltaTime, FVector accel, FVector relativeClientLocation, UPrimitiveComponent clientMovementBase, string clientBaseBoneName, byte clientMovementMode) { }
		
		
		/// <summary>
		/// Update the base of the character, which is the PrimitiveComponent we are standing on.
		/// </summary>
		public override void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor) { }
		
		
		/// <summary>
		/// Set movement mode to the default based on the current physics volume.
		/// </summary>
		public override void SetDefaultMovementMode() { }
		
		
		/// <summary>
		/// Change movement mode.
		/// </summary>
		/// <param name="newMovementMode">The new movement mode</param>
		/// <param name="newCustomMode">The new custom sub-mode, only applicable if NewMovementMode is Custom.</param>
		public override void SetMovementMode(EMovementMode newMovementMode, byte newCustomMode) { }
		
		
		/// <summary>
		/// Switch collision settings for NavWalking mode (ignore world collisions)
		/// </summary>
		protected override void SetNavWalkingPhysics(bool bEnable) { }
		
		
		/// <summary>
		/// Use new physics after landing. Defaults to swimming if in water, walking otherwise.
		/// </summary>
		protected override void SetPostLandedPhysics(FHitResult hit) { }
		
		
		/// <summary>
		/// Simulate movement on a non-owning client. Called by SimulatedTick().
		/// </summary>
		protected override void SimulateMovement(float deltaTime) { }
		
		
		/// <summary>
		/// Smooth mesh location for network interpolation, based on values set up by SmoothCorrection.
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// This function is not called when bNetworkSmoothingComplete is true.
		/// </summary>
		/// <param name="deltaSeconds">Time since last update.</param>
		protected override void SmoothClientPosition(float deltaSeconds) { }
		
		
		/// <summary>
		/// Transition from walking to falling
		/// </summary>
		public override void StartFalling(int iterations, float remainingTime, float timeTick, FVector delta, FVector subLoc) { }
		
		
		/// <summary>
		/// changes physics based on MovementMode
		/// </summary>
		public override void StartNewPhysics(float deltaTime, int iterations) { }
		
		
		/// <summary>
		/// Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful.
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public override void UnCrouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// Update position based on Base movement
		/// </summary>
		public override void UpdateBasedMovement(float deltaSeconds) { }
		
		
		/// <summary>
		/// Update controller's view rotation as pawn's base rotates
		/// </summary>
		public override void UpdateBasedRotation(FRotator finalRotation, FRotator reducedRotation) { }
		
		
		/// <summary>
		/// Update the character state in PerformMovement after the position change. Some rotation updates happen after this.
		/// </summary>
		public override void UpdateCharacterStateAfterMovement(float deltaSeconds) { }
		
		
		/// <summary>
		/// Update the character state in PerformMovement right before doing the actual position change
		/// </summary>
		public override void UpdateCharacterStateBeforeMovement(float deltaSeconds) { }
		
		
		/// <summary>
		/// React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base.
		/// </summary>
		public override void UpdateFloorFromAdjustment() { }
		
		
		/// <summary>
		/// Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character.
		/// </summary>
		protected override void UpdateFromCompressedFlags(byte flags) { }
		
		
		/// <summary>
		/// Used during SimulateMovement for proxies, this computes a new value for Acceleration before running proxy simulation.
		/// <para>The base implementation simply derives a value from the normalized Velocity value, which may help animations that want some indication of the direction of movement. </para>
		/// Proxies don't implement predictive acceleration by default so this value is not used for the actual simulation.
		/// </summary>
		public override void UpdateProxyAcceleration() { }
		
		public static implicit operator IntPtr(ManageCharacterMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacterMovementComponent>(PtrDesc);
		}}}
