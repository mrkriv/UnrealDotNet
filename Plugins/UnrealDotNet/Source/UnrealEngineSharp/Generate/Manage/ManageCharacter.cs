// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

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
		/// Apply momentum caused by damage.
		/// </summary>
		public override void ApplyDamageMomentum(float damageTaken, FDamageEvent damageEvent, APawn pawnInstigator, AActor damageCauser) { }
		
		
		/// <summary>
		/// Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn).
		/// </summary>
		protected override void BaseChange() { }
		
		
		/// <summary>
		/// Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing.
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <see cref="GetBaseTranslationOffset"/>
		/// </summary>
		public override void CacheInitialMeshOffset(FVector meshRelativeLocation, FRotator meshRelativeRotation) { }
		
		
		/// <summary>
		/// Trigger jump if jump button has been pressed.
		/// </summary>
		public override void CheckJumpInput(float deltaTime) { }
		
		
		/// <summary>
		/// Update jump input state after having checked input.
		/// </summary>
		public override void ClearJumpInput(float deltaTime) { }
		
		public override void ClientCheatFly_Implementation() { }
		
		public override void ClientCheatGhost_Implementation() { }
		
		public override void ClientCheatWalk_Implementation() { }
		
		
		/// <summary>
		/// Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// <para>@see OnStartCrouch </para>
		/// @see IsCrouched
		/// <see cref="CharacterMovement"/>
		/// </summary>
		public override void Crouch(bool bClientSimulation) { }
		
		
		/// <summary>
		/// Called when the character's movement enters falling
		/// </summary>
		public override void Falling() { }
		
		
		/// <summary>
		/// Make the character jump on the next update.
		/// <para>If you want your character to jump according to the time that the jump key is held, </para>
		/// then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to
		/// <para>call StopJumping() when you want the jump's z-velocity to stop being applied (such </para>
		/// as on a button up event), otherwise the character will carry on receiving the
		/// <para>velocity until JumpKeyHoldTime is reached. </para>
		/// </summary>
		public override void Jump() { }
		
		
		/// <summary>
		/// Called upon landing when falling, to perform actions based on the Hit result. Triggers the OnLanded event.
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking).
		/// <see cref="OnMovementModeChanged"/>
		/// </summary>
		/// <param name="hit">Result describing the landing that resulted in a valid landing spot.</param>
		public override void Landed(FHitResult hit) { }
		
		
		/// <summary>
		/// Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// @PARAM LaunchVelocity is the velocity to impart to the Character
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// @PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
		/// </summary>
		public override void LaunchCharacter(FVector launchVelocity, bool bXYOverride, bool bZOverride) { }
		
		
		/// <summary>
		/// Called when pawn's movement is blocked
		/// </summary>
		/// <param name="impact">describes the blocking hit.</param>
		public override void MoveBlockedBy(FHitResult impact) { }
		
		public override void NotifyActorBeginOverlap(AActor otherActor) { }
		
		public override void NotifyActorEndOverlap(AActor otherActor) { }
		
		
		/// <summary>
		/// Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true
		/// </summary>
		public override void NotifyJumpApex() { }
		
		
		/// <summary>
		/// Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public override void OnEndCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust) { }
		
		public override void OnJumped_Implementation() { }
		
		
		/// <summary>
		/// Called from CharacterMovementComponent to notify the character that the movement mode has changed.
		/// </summary>
		/// <param name="prevMovementMode">Movement mode before the change</param>
		/// <param name="prevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom)</param>
		public override void OnMovementModeChanged(EMovementMode prevMovementMode, byte previousCustomMode) { }
		
		public override void OnRep_IsCrouched() { }
		
		public override void OnRep_ReplicatedBasedMovement() { }
		
		
		/// <summary>
		/// Called when Character crouches. Called on non-owned Characters through bIsCrouched replication.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public override void OnStartCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust) { }
		
		
		/// <summary>
		/// Called on client after position update is received to respond to the new location and rotation.
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so.
		/// </summary>
		public override void OnUpdateSimulatedPosition(FVector oldLocation, FQuat oldRotation) { }
		
		public override void OnWalkingOffLedge_Implementation(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta) { }
		
		
		/// <summary>
		/// Marks character as not trying to jump
		/// </summary>
		public override void ResetJumpState() { }
		
		public override void RootMotionDebugClientPrintOnScreen_Implementation(string inString) { }
		
		
		/// <summary>
		/// Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects.
		/// </summary>
		public override void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor) { }
		
		
		/// <summary>
		/// Stop the character from jumping on the next update.
		/// <para>Call this from an input event (such as a button 'up' event) to cease applying </para>
		/// jump Z-velocity. If this is not called, then jump z-velocity will be applied
		/// <para>until JumpMaxHoldTime is reached. </para>
		/// </summary>
		public override void StopJumping() { }
		
		
		/// <summary>
		/// Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// <para>@see OnEndCrouch </para>
		/// @see IsCrouched
		/// <see cref="CharacterMovement"/>
		/// </summary>
		public override void UnCrouch(bool bClientSimulation) { }
		
		public static implicit operator IntPtr(ManageCharacter self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacter>(PtrDesc);
		}}}
