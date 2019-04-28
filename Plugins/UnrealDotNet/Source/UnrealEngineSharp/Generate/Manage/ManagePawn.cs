// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

namespace UnrealEngine
{
	[ManageType("ManagePawn")]
	public partial class ManagePawn : APawn
	{
		public ManagePawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.</param>
		public override void AddControllerPitchInput(float val) { }
		
		
		/// <summary>
		/// Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.</param>
		public override void AddControllerRollInput(float val) { }
		
		
		/// <summary>
		/// Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.</param>
		public override void AddControllerYawInput(float val) { }
		
		
		/// <summary>
		/// Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction.
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <see cref="GetPendingMovementInputVector"/>
		/// </summary>
		/// <param name="worldDirection">Direction in world space to apply input</param>
		/// <param name="scaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.</param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored().</param>
		public override void AddMovementInput(FVector worldDirection, float scaleValue, bool bForce) { }
		
		
		/// <summary>
		/// Destroys the player input component and removes any references to it.
		/// </summary>
		protected override void DestroyPlayerInputComponent() { }
		
		
		/// <summary>
		/// Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.
		/// </summary>
		public override void DetachFromControllerPendingDestroy() { }
		
		
		/// <summary>
		/// Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings.
		/// </summary>
		public override void FaceRotation(FRotator newControlRotation, float deltaTime) { }
		
		public override void OnRep_Controller() { }
		
		public override void OnRep_PlayerState() { }
		
		
		/// <summary>
		/// Tell client that the Pawn is begin restarted. Calls Restart().
		/// </summary>
		public override void PawnClientRestart() { }
		
		
		/// <summary>
		/// Handle StartFire() passed from PlayerController
		/// </summary>
		public override void PawnStartFire(byte fireModeNum) { }
		
		
		/// <summary>
		/// Called when this Pawn is possessed. Only called on the server (or in standalone).
		/// </summary>
		/// <param name="newController">The controller possessing this pawn</param>
		public override void PossessedBy(AController newController) { }
		
		
		/// <summary>
		/// Set BaseEyeHeight based on current state.
		/// </summary>
		public override void RecalculateBaseEyeHeight() { }
		
		
		/// <summary>
		/// Called when the Pawn is being restarted (usually by being possessed by a Controller).
		/// </summary>
		public override void Restart() { }
		
		
		/// <summary>
		/// Make sure pawn properties are back to default.
		/// </summary>
		public override void SetPlayerDefaults() { }
		
		
		/// <summary>
		/// Allows a Pawn to set up custom input bindings. Called upon possession by a PlayerController, using the InputComponent created by CreatePlayerInputComponent().
		/// </summary>
		protected override void SetupPlayerInputComponent(UInputComponent playerInputComponent) { }
		
		
		/// <summary>
		/// Spawn default controller for this Pawn, and get possessed by it.
		/// </summary>
		public override void SpawnDefaultController() { }
		
		
		/// <summary>
		/// Freeze pawn - stop sounds, animations, physics, weapon firing
		/// </summary>
		public override void TurnOff() { }
		
		
		/// <summary>
		/// Called when our Controller no longer possesses us.
		/// </summary>
		public override void UnPossessed() { }
		
		
		/// <summary>
		/// Update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag
		/// </summary>
		public override void UpdateNavigationRelevance() { }
		
		public static implicit operator IntPtr(ManagePawn self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawn>(PtrDesc);
		}}}
