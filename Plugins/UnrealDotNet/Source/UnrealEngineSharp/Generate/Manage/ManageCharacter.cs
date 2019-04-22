// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

namespace UnrealEngine
{
	[ManageType("ManageCharacter")]
	public partial class ManageCharacter : ACharacter
	{
		public ManageCharacter(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Apply momentum caused by damage. </para>
		/// </summary>
		public override void ApplyDamageMomentum(float damageTaken, FDamageEvent damageEvent, APawn pawnInstigator, AActor damageCauser) { }
		
		
		/// <summary>
		/// <para>Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn). </para>
		/// </summary>
		protected override void BaseChange() { }
		
		
		/// <summary>
		/// <para>Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing. </para>
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <para>@see GetBaseTranslationOffset(), GetBaseRotationOffset() </para>
		/// </summary>
		public override void CacheInitialMeshOffset(FVector meshRelativeLocation, FRotator meshRelativeRotation) { }
		
		
		/// <summary>
		/// <para>Trigger jump if jump button has been pressed. </para>
		/// </summary>
		public override void CheckJumpInput(float deltaTime) { }
		
		
		/// <summary>
		/// <para>Update jump input state after having checked input. </para>
		/// </summary>
		public override void ClearJumpInput(float deltaTime) { }
		
		public override void ClientCheatFly_Implementation() { }
		
		public override void ClientCheatGhost_Implementation() { }
		
		public override void ClientCheatWalk_Implementation() { }
		
		
		/// <summary>
		/// <para>Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnStartCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public override void Crouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// <para>Called when the character's movement enters falling </para>
		/// </summary>
		public override void Falling() { }
		
		
		/// <summary>
		/// <para>Make the character jump on the next update. </para>
		/// <para>If you want your character to jump according to the time that the jump key is held, </para>
		/// <para>then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to </para>
		/// <para>call StopJumping() when you want the jump's z-velocity to stop being applied (such </para>
		/// <para>as on a button up event), otherwise the character will carry on receiving the </para>
		/// <para>velocity until JumpKeyHoldTime is reached. </para>
		/// </summary>
		public override void Jump() { }
		
		
		/// <summary>
		/// <para>Called upon landing when falling, to perform actions based on the Hit result. Triggers the OnLanded event. </para>
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// <para>Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking). </para>
		/// <param name="Hit">Result describing the landing that resulted in a valid landing spot. </param>
		/// <para>@see OnMovementModeChanged() </para>
		/// </summary>
		public override void Landed(FHitResult hit) { }
		
		
		/// <summary>
		/// <para>Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick, </para>
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// <para>@PARAM LaunchVelocity is the velocity to impart to the Character </para>
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// <para>@PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it. </para>
		/// </summary>
		public override void LaunchCharacter(FVector launchVelocity, bool bXYOverride, bool bZOverride) { }
		
		
		/// <summary>
		/// <para>Called when pawn's movement is blocked </para>
		/// <param name="Impact">describes the blocking hit. </param>
		/// </summary>
		public override void MoveBlockedBy(FHitResult impact) { }
		
		public override void NotifyActorBeginOverlap(AActor otherActor) { }
		
		public override void NotifyActorEndOverlap(AActor otherActor) { }
		
		
		/// <summary>
		/// <para>Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true </para>
		/// </summary>
		public override void NotifyJumpApex() { }
		
		
		/// <summary>
		/// <para>Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public override void OnEndCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust) { }
		
		public override void OnJumped_Implementation() { }
		
		
		/// <summary>
		/// <para>Called from CharacterMovementComponent to notify the character that the movement mode has changed. </para>
		/// <param name="PrevMovementMode">Movement mode before the change </param>
		/// <param name="PrevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom) </param>
		/// </summary>
		public override void OnMovementModeChanged(EMovementMode prevMovementMode, byte previousCustomMode) { }
		
		public override void OnRep_IsCrouched() { }
		
		public override void OnRep_ReplicatedBasedMovement() { }
		
		
		/// <summary>
		/// <para>Called when Character crouches. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public override void OnStartCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust) { }
		
		
		/// <summary>
		/// <para>Called on client after position update is received to respond to the new location and rotation. </para>
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// <para>Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so. </para>
		/// </summary>
		public override void OnUpdateSimulatedPosition(FVector oldLocation, FQuat oldRotation) { }
		
		public override void OnWalkingOffLedge_Implementation(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta) { }
		
		
		/// <summary>
		/// <para>Marks character as not trying to jump </para>
		/// </summary>
		public override void ResetJumpState() { }
		
		public override void RootMotionDebugClientPrintOnScreen_Implementation(string inString) { }
		
		
		/// <summary>
		/// <para>Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects. </para>
		/// </summary>
		public override void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor) { }
		
		
		/// <summary>
		/// <para>Stop the character from jumping on the next update. </para>
		/// <para>Call this from an input event (such as a button 'up' event) to cease applying </para>
		/// <para>jump Z-velocity. If this is not called, then jump z-velocity will be applied </para>
		/// <para>until JumpMaxHoldTime is reached. </para>
		/// </summary>
		public override void StopJumping() { }
		
		
		/// <summary>
		/// <para>Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnEndCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public override void UnCrouch(bool bClientSimulation) { }
		
		public static implicit operator IntPtr(ManageCharacter self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageCharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacter>(PtrDesc);
		}}}
