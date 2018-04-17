using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:156

namespace UnrealEngine
{
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
		
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff) { }
		
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) { }
		
		
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
		
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift) { }
		
		public override void BeginDestroy() { }
		
		
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
		
		public override void Deactivate() { }
		
		
		/// <summary>
		/// <para>Make movement impossible (sets movement mode to MOVE_None). </para>
		/// </summary>
		public override void DisableMovement() { }
		
		public override void ForcePositionUpdate(float DeltaTime) { }
		
		
		/// <summary>
		/// <para>Force a client update by making it appear on the server that the client hasn't updated in a long time. </para>
		/// </summary>
		public override void ForceReplicationUpdate() { }
		
		
		/// <summary>
		/// <para>Handle a blocking impact. Calls ApplyImpactPhysicsForces for the hit, if bEnablePhysicsInteraction is true. </para>
		/// </summary>
		public override void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta) { }
		
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
		
		public override void NotifyBumpedPawn(APawn BumpedPawn) { }
		
		
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
		
		public override void OnRegister() { }
		
		
		/// <summary>
		/// <para>Called by owning Character upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public override void OnTeleported() { }
		
		
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
		
		public override void PostLoad() { }
		
		
		/// <summary>
		/// <para>Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode. </para>
		/// </summary>
		protected override void ProcessLanded(FHitResult Hit, float remainingTime, int Iterations) { }
		
		public override void RegisterComponentTickFunctions(bool bRegister) { }
		
		
		/// <summary>
		/// <para>Perform local movement and send the move to the server. </para>
		/// </summary>
		protected override void ReplicateMoveToServer(float DeltaTime, FVector NewAcceleration) { }
		
		public override void RequestDirectMove(FVector MoveVelocity, bool bForceMaxSpeed) { }
		
		public override void RequestPathMove(FVector MoveInput) { }
		
		public override void ResetPredictionData_Client() { }
		
		public override void ResetPredictionData_Server() { }
		
		
		/// <summary>
		/// <para>Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update. </para>
		/// </summary>
		public override void SaveBaseLocation() { }
		
		public override void SendClientAdjustment() { }
		
		
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
		
		public override void SetUpdatedComponent(USceneComponent NewUpdatedComponent) { }
		
		
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
		/// <para>React to new transform from network update. Sets bNetworkSmoothingComplete to false to ensure future smoothing updates. </para>
		/// <para>IMPORTANT: It is expected that this function triggers any movement/transform updates to match the network update if desired. </para>
		/// </summary>
		public override void SmoothCorrection(FVector OldLocation, FQuat OldRotation, FVector NewLocation, FQuat NewRotation) { }
		
		
		/// <summary>
		/// <para>Transition from walking to falling </para>
		/// </summary>
		public override void StartFalling(int Iterations, float remainingTime, float timeTick, FVector Delta, FVector subLoc) { }
		
		
		/// <summary>
		/// <para>changes physics based on MovementMode </para>
		/// </summary>
		public override void StartNewPhysics(float deltaTime, int Iterations) { }
		
		public override void StopActiveMovement() { }
		
		
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
		public override void UpdateCharacterStateAfterMovement() { }
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement right before doing the actual position change </para>
		/// </summary>
		public override void UpdateCharacterStateBeforeMovement() { }
		
		
		/// <summary>
		/// <para>React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base. </para>
		/// </summary>
		public override void UpdateFloorFromAdjustment() { }
		
		
		/// <summary>
		/// <para>Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character. </para>
		/// </summary>
		protected override void UpdateFromCompressedFlags(byte Flags) { }
		
		
		/// <summary>
		/// <para>Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude. </para>
		/// <para>They are accumulated during a frame then applied as acceleration during the movement update. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void AddInputVector(FVector WorldVector, bool bForce) { }
		
		public override void StopMovementImmediately() { }
		
		
		/// <summary>
		/// <para>Overridden to auto-register the updated component if it starts NULL, and we can find a root component on our owner. </para>
		/// </summary>
		public override void InitializeComponent() { }
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public override void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) { }
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintFromVectors(FVector Forward, FVector Up) { }
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public override void SetPlaneConstraintNormal(FVector PlaneNormal) { }
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintOrigin(FVector PlaneOrigin) { }
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public override void SnapUpdatedComponentToPlane() { }
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public override void UpdateComponentVelocity() { }
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public override void UpdateTickRegistration() { }
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset) { }
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay() { }
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void CreateRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren) { }
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) { }
		
		public override void MarkAsEditorOnlySubobject() { }
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged() { }
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated() { }
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy) { }
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState() { }
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState() { }
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public override void OnUnregister() { }
		
		public override void PostInitProperties() { }
		
		public override void PostNetReceive() { }
		
		public override void PostRename(UObject OldOuter, string OldName) { }
		
		public override void PreNetReceive() { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent() { }
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void SendRenderTransform_Concurrent() { }
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset) { }
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate) { }
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive() { }
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent() { }
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public override void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) { }
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy() { }
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct() { }
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport() { }
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies() { }
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired) { }
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication() { }
		
		public override void ShutdownAfterError() { }
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) { }
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster() { }
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill() { }
		
		public static implicit operator IntPtr(ManageCharacterMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacterMovementComponent>(PtrDesc);
		}}}
