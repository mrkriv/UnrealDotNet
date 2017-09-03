using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Этот класс может быть наследованн
	/// <para>Characters are Pawns that have a mesh, collision, and built-in movement logic. </para>
	/// <para>They are responsible for all physical interaction between the player or AI and the world, and also implement basic networking and input models. </para>
	/// <para>They are designed for a vertically-oriented player representation that can walk, jump, fly, and swim through the world using CharacterMovementComponent. </para>
	/// <para>@see APawn, UCharacterMovementComponent </para>
	/// <para>@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character </para>
	/// </summary>
	public partial class ManageCharacter : ACharacter
	{
		public ManageCharacter(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn). </para>
		/// </summary>
		protected override void BaseChange() { }
		
		
		/// <summary>
		/// <para>Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing. </para>
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <para>@see GetBaseTranslationOffset(), GetBaseRotationOffset() </para>
		/// </summary>
		public override void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation) { }
		
		
		/// <summary>
		/// <para>Trigger jump if jump button has been pressed. </para>
		/// </summary>
		public override void CheckJumpInput(float DeltaTime) { }
		
		
		/// <summary>
		/// <para>Reset jump input state after having checked input. </para>
		/// </summary>
		public override void ClearJumpInput() { }
		
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
		/// <para>Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick, </para>
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// <para>@PARAM LaunchVelocity is the velocity to impart to the Character </para>
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// <para>@PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it. </para>
		/// </summary>
		public override void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride) { }
		
		
		/// <summary>
		/// <para>Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true </para>
		/// </summary>
		public override void NotifyJumpApex() { }
		
		
		/// <summary>
		/// <para>Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public override void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) { }
		
		public override void OnJumped_Implementation() { }
		
		public override void OnRep_IsCrouched() { }
		
		public override void OnRep_ReplicatedBasedMovement() { }
		
		
		/// <summary>
		/// <para>Called when Character crouches. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public override void OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) { }
		
		
		/// <summary>
		/// <para>Called on client after position update is received to respond to the new location and rotation. </para>
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// <para>Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so. </para>
		/// </summary>
		public override void OnUpdateSimulatedPosition(FVector OldLocation, FQuat OldRotation) { }
		
		public override void RootMotionDebugClientPrintOnScreen_Implementation(string InString) { }
		
		
		/// <summary>
		/// <para>Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects. </para>
		/// </summary>
		public override void SetBase(UPrimitiveComponent NewBase, string BoneName, bool bNotifyActor) { }
		
		
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
		
		public override void UpdateFromCompressedFlags(byte Flags) { }
		
		public override void UpdateSimulatedPosition(FVector Location, FRotator NewRotation) { }
		
		public static implicit operator IntPtr(ManageCharacter Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageCharacter(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageCharacter ?? new ManageCharacter(Adress);
		}