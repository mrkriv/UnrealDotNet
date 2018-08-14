using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:157

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
		/// <para>Add force to character. Forces are accumulated each tick and applied together </para>
		/// <para>so multiple calls to this function will accumulate. </para>
		/// <para>Forces are scaled depending on timestep, so they can be applied each frame. If you want an </para>
		/// <para>instantaneous force, use AddImpulse. </para>
		/// <para>Adding a force always takes the actor's mass into account. </para>
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// <param name="Force">Force to apply. </param>
		/// </summary>
		public override void AddForce(FVector Force) { }
		
		
		/// <summary>
		/// <para>Add impulse to character. Impulses are accumulated each tick and applied together </para>
		/// <para>so multiple calls to this function will accumulate. </para>
		/// <para>An impulse is an instantaneous force, usually applied once. If you want to continually apply </para>
		/// <para>forces each frame, use AddForce(). </para>
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// <param name="Impulse">Impulse to apply. </param>
		/// <param name="bVelocityChange">Whether or not the impulse is relative to mass. </param>
		/// </summary>
		public override void AddImpulse(FVector Impulse, bool bVelocityChange) { }
		
		
		/// <summary>
		/// <para>Adjust distance from floor, trying to maintain a slight offset from the floor when walking (based on CurrentFloor). </para>
		/// </summary>
		public override void AdjustFloorHeight() { }
		
		
		/// <summary>
		/// <para>Adjust the size of the capsule on simulated proxies, to avoid overlaps due to replication rounding. </para>
		/// <para>Changes to the capsule size on the proxy should set bShrinkProxyCapsule=true and possibly call AdjustProxyCapsuleSize() immediately if applicable. </para>
		/// </summary>
		protected override void AdjustProxyCapsuleSize() { }
		
		
		/// <summary>
		/// <para>Applies momentum accumulated through AddImpulse() and AddForce(), then clears those forces. Does *not* use ClearAccumulatedForces() since that would clear pending launch velocity as well. </para>
		/// </summary>
		public override void ApplyAccumulatedForces(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Applies downward force when walking on top of physics objects. </para>
		/// <param name="DeltaSeconds">Time elapsed since last frame. </param>
		/// </summary>
		public override void ApplyDownwardForce(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Apply physics forces to the impacted component, if bEnablePhysicsInteraction is true. </para>
		/// <param name="Impact">HitResult that resulted in the impact </param>
		/// <param name="ImpactAcceleration">Acceleration of the character at the time of impact </param>
		/// <param name="ImpactVelocity">Velocity of the character at the time of impact </param>
		/// </summary>
		protected override void ApplyImpactPhysicsForces(FHitResult Impact, FVector ImpactAcceleration, FVector ImpactVelocity) { }
		
		public override void ApplyNetworkMovementMode(byte ReceivedMode) { }
		
		
		/// <summary>
		/// <para>Applies repulsion force to all touched components. </para>
		/// </summary>
		public override void ApplyRepulsionForce(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Slows towards stop. </para>
		/// </summary>
		protected override void ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration) { }
		
		
		/// <summary>
		/// <para>Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity. </para>
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// <param name="DeltaTime">time elapsed since last frame. </param>
		/// <param name="Friction">coefficient of friction when not accelerating, or in the direction opposite acceleration. </param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration. </param>
		/// <param name="BrakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity. </param>
		/// </summary>
		public override void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration) { }
		
		
		/// <summary>
		/// <para>Internal function to call OnMovementUpdated delegate on CharacterOwner. </para>
		/// </summary>
		protected override void CallMovementUpdateDelegate(float DeltaSeconds, FVector OldLocation, FVector OldVelocity) { }
		
		protected override void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult) { }
		
		
		/// <summary>
		/// <para>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity. </para>
		/// </summary>
		public override void ClearAccumulatedForces() { }
		
		
		/// <summary>
		/// <para>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves </para>
		/// </summary>
		public override void ClientAckGoodMove(float TimeStamp) { }
		
		public override void ClientAckGoodMove_Implementation(float TimeStamp) { }
		
		
		/// <summary>
		/// <para>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment. </para>
		/// </summary>
		public override void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode) { }
		
		public override void ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode) { }
		
		public override void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode) { }
		
		public override void ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode) { }
		
		
		/// <summary>
		/// <para>Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful. </para>
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public override void Crouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// <para>Make movement impossible (sets movement mode to MOVE_None). </para>
		/// </summary>
		public override void DisableMovement() { }
		
		
		/// <summary>
		/// <para>Force a client update by making it appear on the server that the client hasn't updated in a long time. </para>
		/// </summary>
		public override void ForceReplicationUpdate() { }
		
		protected override void HandleSwimmingWallHit(FHitResult Hit, float DeltaTime) { }
		
		
		/// <summary>
		/// <para>Force this pawn to bounce off its current base, which isn't an acceptable base for it. </para>
		/// </summary>
		public override void JumpOff(AActor MovementBaseActor) { }
		
		
		/// <summary>
		/// <para>Jump onto shore from water </para>
		/// </summary>
		public override void JumpOutOfWater(FVector WallNormal) { }
		
		
		/// <summary>
		/// <para>Queue a pending launch with velocity LaunchVel. </para>
		/// </summary>
		public override void Launch(FVector LaunchVel) { }
		
		
		/// <summary>
		/// <para>Adjusts velocity when walking so that Z velocity is zero. </para>
		/// <para>When bMaintainHorizontalGroundVelocity is false, also rescales the velocity vector to maintain the original magnitude, but in the horizontal direction. </para>
		/// </summary>
		protected override void MaintainHorizontalGroundVelocity() { }
		
		
		/// <summary>
		/// <para>Call SaveBaseLocation() if not deferring updates (bDeferUpdateBasedMovement is false). </para>
		/// </summary>
		public override void MaybeSaveBaseLocation() { }
		
		
		/// <summary>
		/// <para>Update or defer updating of position based on Base movement </para>
		/// </summary>
		public override void MaybeUpdateBasedMovement(float DeltaSeconds) { }
		
		protected override void MoveAutonomous(float ClientTimeStamp, float DeltaTime, byte CompressedFlags, FVector NewAccel) { }
		
		
		/// <summary>
		/// <para>Called if bNotifyApex is true and character has just passed the apex of its jump. </para>
		/// </summary>
		public override void NotifyJumpApex() { }
		
		
		/// <summary>
		/// <para>Notification that the character is stuck in geometry.  Only called during walking movement. </para>
		/// </summary>
		protected override void OnCharacterStuckInGeometry(FHitResult Hit) { }
		
		
		/// <summary>
		/// <para>Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid. </para>
		/// </summary>
		protected override void OnClientTimeStampResetDetected() { }
		
		
		/// <summary>
		/// <para>Called after MovementMode has changed. Base implementation does special handling for starting certain modes, then notifies the CharacterOwner. </para>
		/// </summary>
		protected override void OnMovementModeChanged(EMovementMode PreviousMovementMode, byte PreviousCustomMode) { }
		
		
		/// <summary>
		/// <para>Event triggered at the end of a movement update. If scoped movement updates are enabled (bEnableScopedMovementUpdates), this is within such a scope. </para>
		/// <para>If that is not desired, bind to the CharacterOwner's OnMovementUpdated event instead, as that is triggered after the scoped movement update. </para>
		/// </summary>
		protected override void OnMovementUpdated(float DeltaSeconds, FVector OldLocation, FVector OldVelocity) { }
		
		
		/// <summary>
		/// <para>Called by UCharacterMovementComponent::ProcessClientTimeStampForTimeDiscrepancy() (on server) when the time from client moves </para>
		/// <para>significantly differs from the server time, indicating potential time manipulation by clients (speed hacks, significant network </para>
		/// <para>issues, client performance problems) </para>
		/// <param name="CurrentTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is bounded </param>
		/// <para>by MovementTimeDiscrepancy config variables in AGameNetworkManager, and is the value with which </para>
		/// <para>we test against to trigger this function. This is reset when MovementTimeDiscrepancy resolution </para>
		/// <para>is enabled </para>
		/// <param name="LifetimeRawTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is unbounded </param>
		/// <para>and does NOT get affected by MovementTimeDiscrepancy resolution, and is useful as a longer-term </para>
		/// <para>view of how the given client is performing. High magnitude unbounded error points to </para>
		/// <para>intentional tampering by a client vs. occasional "naturally caused" spikes in error due to </para>
		/// <para>burst packet loss/performance hitches </para>
		/// <param name="Lifetime">Game time over which LifetimeRawTimeDiscrepancy has accrued (useful for determining severity </param>
		/// <para>of LifetimeUnboundedError) </para>
		/// <param name="CurrentMoveError">Time difference between client ServerMove and how much time has passed on the server for the </param>
		/// <para>current move that has caused TimeDiscrepancy to accumulate enough to trigger detection. </para>
		/// </summary>
		protected override void OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError) { }
		
		
		/// <summary>
		/// <para>Event triggered when we are moving on a base but we are not able to move the full DeltaPosition because something has blocked us. </para>
		/// <para>Note: MoveComponentFlags includes the flag to ignore the movement base while this event is fired. </para>
		/// <param name="DeltaPosition">How far we tried to move with the base. </param>
		/// <param name="OldLocation">Location before we tried to move with the base. </param>
		/// <param name="MoveOnBaseHit">Hit result for the object we hit when trying to move with the base. </param>
		/// </summary>
		protected override void OnUnableToFollowBaseMove(FVector DeltaPosition, FVector OldLocation, FHitResult MoveOnBaseHit) { }
		
		
		/// <summary>
		/// <para>Update Velocity and Acceleration to air control in the desired Direction for character using path following. </para>
		/// <param name="Direction">is the desired direction of movement </param>
		/// <param name="ZDiff">is the height difference between the destination and the Pawn's current position </param>
		/// <para>@see RequestDirectMove() </para>
		/// </summary>
		public override void PerformAirControlForPathFollowing(FVector Direction, float ZDiff) { }
		
		
		/// <summary>
		/// <para>Perform movement on an autonomous client </para>
		/// </summary>
		protected override void PerformMovement(float DeltaTime) { }
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected override void PhysCustom(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>Handle falling movement. </para>
		/// </summary>
		public override void PhysFalling(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected override void PhysFlying(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>Perform rotation over deltaTime </para>
		/// </summary>
		public override void PhysicsRotation(float DeltaTime) { }
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected override void PhysNavWalking(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected override void PhysSwimming(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected override void PhysWalking(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode. </para>
		/// </summary>
		protected override void ProcessLanded(FHitResult Hit, float remainingTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>Perform local movement and send the move to the server. </para>
		/// </summary>
		protected override void ReplicateMoveToServer(float DeltaTime, FVector NewAcceleration) { }
		
		
		/// <summary>
		/// <para>Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update. </para>
		/// </summary>
		public override void SaveBaseLocation() { }
		
		
		/// <summary>
		/// <para>Have the server check if the client is outside an error tolerance, and queue a client adjustment if so. </para>
		/// <para>If either GetPredictionData_Server_Character()->bForceClientUpdate or ServerCheckClientError() are true, the client adjustment will be sent. </para>
		/// <para>RelativeClientLocation will be a relative location if MovementBaseUtility::UseRelativePosition(ClientMovementBase) is true, or a world location if false. </para>
		/// <para>@see ServerCheckClientError() </para>
		/// </summary>
		protected override void ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, FVector Accel, FVector RelativeClientLocation, UPrimitiveComponent ClientMovementBase, string ClientBaseBoneName, byte ClientMovementMode) { }
		
		
		/// <summary>
		/// <para>Update the base of the character, which is the PrimitiveComponent we are standing on. </para>
		/// </summary>
		public override void SetBase(UPrimitiveComponent NewBase, string BoneName, bool bNotifyActor) { }
		
		
		/// <summary>
		/// <para>Set movement mode to the default based on the current physics volume. </para>
		/// </summary>
		public override void SetDefaultMovementMode() { }
		
		
		/// <summary>
		/// <para>Change movement mode. </para>
		/// <param name="NewMovementMode">The new movement mode </param>
		/// <param name="NewCustomMode">The new custom sub-mode, only applicable if NewMovementMode is Custom. </param>
		/// </summary>
		public override void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode) { }
		
		
		/// <summary>
		/// <para>Switch collision settings for NavWalking mode (ignore world collisions) </para>
		/// </summary>
		protected override void SetNavWalkingPhysics(bool bEnable) { }
		
		
		/// <summary>
		/// <para>Use new physics after landing. Defaults to swimming if in water, walking otherwise. </para>
		/// </summary>
		protected override void SetPostLandedPhysics(FHitResult Hit) { }
		
		
		/// <summary>
		/// <para>Simulate movement on a non-owning client. Called by SimulatedTick(). </para>
		/// </summary>
		protected override void SimulateMovement(float DeltaTime) { }
		
		
		/// <summary>
		/// <para>Smooth mesh location for network interpolation, based on values set up by SmoothCorrection. </para>
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// <para>This function is not called when bNetworkSmoothingComplete is true. </para>
		/// <param name="DeltaSeconds">Time since last update. </param>
		/// </summary>
		protected override void SmoothClientPosition(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Transition from walking to falling </para>
		/// </summary>
		public override void StartFalling(int Iterations, float remainingTime, float timeTick, FVector Delta, FVector subLoc) { }
		
		
		/// <summary>
		/// <para>changes physics based on MovementMode </para>
		/// </summary>
		public override void StartNewPhysics(float deltaTime, int Iterations) { }
		
		
		/// <summary>
		/// <para>Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public override void UnCrouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// <para>Update position based on Base movement </para>
		/// </summary>
		public override void UpdateBasedMovement(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Update controller's view rotation as pawn's base rotates </para>
		/// </summary>
		public override void UpdateBasedRotation(FRotator FinalRotation, FRotator ReducedRotation) { }
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement after the position change. Some rotation updates happen after this. </para>
		/// </summary>
		public override void UpdateCharacterStateAfterMovement(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement right before doing the actual position change </para>
		/// </summary>
		public override void UpdateCharacterStateBeforeMovement(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base. </para>
		/// </summary>
		public override void UpdateFloorFromAdjustment() { }
		
		
		/// <summary>
		/// <para>Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character. </para>
		/// </summary>
		protected override void UpdateFromCompressedFlags(byte Flags) { }
		
		public static implicit operator IntPtr(ManageCharacterMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacterMovementComponent>(PtrDesc);
		}}}
