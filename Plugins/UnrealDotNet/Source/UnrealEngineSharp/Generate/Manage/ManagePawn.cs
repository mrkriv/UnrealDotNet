using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

namespace UnrealEngine
{
	public partial class ManagePawn : APawn
	{
		public ManagePawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <param name="Val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value. </param>
		/// <para>@see PlayerController::InputPitchScale </para>
		/// </summary>
		public override void AddControllerPitchInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <param name="Val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value. </param>
		/// <para>@see PlayerController::InputRollScale </para>
		/// </summary>
		public override void AddControllerRollInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <param name="Val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value. </param>
		/// <para>@see PlayerController::InputYawScale </para>
		/// </summary>
		public override void AddControllerYawInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction. </para>
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public override void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce) { }
		
		
		/// <summary>
		/// <para>Destroys the player input component and removes any references to it. </para>
		/// </summary>
		protected override void DestroyPlayerInputComponent() { }
		
		
		/// <summary>
		/// <para>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon. </para>
		/// </summary>
		public override void DetachFromControllerPendingDestroy() { }
		
		
		/// <summary>
		/// <para>Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings. </para>
		/// </summary>
		public override void FaceRotation(FRotator NewControlRotation, float DeltaTime) { }
		
		public override void OnRep_Controller() { }
		
		public override void OnRep_PlayerState() { }
		
		
		/// <summary>
		/// <para>Tell client that the Pawn is begin restarted. Calls Restart(). </para>
		/// </summary>
		public override void PawnClientRestart() { }
		
		
		/// <summary>
		/// <para>Handle StartFire() passed from PlayerController </para>
		/// </summary>
		public override void PawnStartFire(byte FireModeNum) { }
		
		
		/// <summary>
		/// <para>Set BaseEyeHeight based on current state. </para>
		/// </summary>
		public override void RecalculateBaseEyeHeight() { }
		
		
		/// <summary>
		/// <para>Called when the Pawn is being restarted (usually by being possessed by a Controller). </para>
		/// </summary>
		public override void Restart() { }
		
		
		/// <summary>
		/// <para>Make sure pawn properties are back to default. </para>
		/// </summary>
		public override void SetPlayerDefaults() { }
		
		
		/// <summary>
		/// <para>Spawn default controller for this Pawn, and get possessed by it. </para>
		/// </summary>
		public override void SpawnDefaultController() { }
		
		
		/// <summary>
		/// <para>Freeze pawn - stop sounds, animations, physics, weapon firing </para>
		/// </summary>
		public override void TurnOff() { }
		
		
		/// <summary>
		/// <para>Called when our Controller no longer possesses us. </para>
		/// </summary>
		public override void UnPossessed() { }
		
		
		/// <summary>
		/// <para>Update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag </para>
		/// </summary>
		public override void UpdateNavigationRelevance() { }
		
		public static implicit operator IntPtr(ManagePawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawn>(PtrDesc);
		}}}
