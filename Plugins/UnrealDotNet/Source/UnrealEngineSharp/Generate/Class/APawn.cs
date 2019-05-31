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
	public  partial class APawn : AActor
	{
		public APawn(IntPtr adress)
			: base(adress)
		{
		}

		public APawn(UObject Parent = null, string Name = "Pawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_APawn(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APawn_AllowedYawError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_AllowedYawError_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APawn_AutoPossessAI_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_AutoPossessAI_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APawn_BaseEyeHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_BaseEyeHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APawn_BlendedReplayViewPitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_BlendedReplayViewPitch_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APawn_Controller_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_Controller_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APawn_LastHitBy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_LastHitBy_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APawn_RemoteViewPitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_RemoteViewPitch_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_APawn(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerPitchInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerRollInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerYawInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddMovementInput(IntPtr self, IntPtr worldDirection, float scaleValue, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_ConsumeMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_CreatePlayerInputComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_DestroyPlayerInputComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_DetachFromControllerPendingDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_FaceRotation(IntPtr self, IntPtr newControlRotation, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetBaseAimRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetControlRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APawn_GetDefaultHalfHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetGravityDirection(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetLastMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetMovementBase(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetMovementBaseActor(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetMovementComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetPawnNoiseEmitterComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetPawnViewLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetPendingMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APawn_GetPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetViewRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_InFreeCam(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_InputEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_Internal_AddMovementInput(IntPtr self, IntPtr worldAccel, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_ConsumeMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_GetLastMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_GetPendingMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsBotControlled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsControlled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsLocallyControlled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsMoveInputIgnored(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsPlayerControlled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_K2_GetMovementInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_LaunchPawn(IntPtr self, IntPtr launchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_MoveIgnoreActorAdd(IntPtr self, IntPtr actorToIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_MoveIgnoreActorRemove(IntPtr self, IntPtr actorToIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_OnRep_Controller(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_OnRep_PlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PawnClientRestart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PawnMakeNoise(IntPtr self, float loudness, IntPtr noiseLocation, bool bUseNoiseMakerLocation, IntPtr noiseMaker);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PawnStartFire(IntPtr self, byte fireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PossessedBy(IntPtr self, IntPtr newController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_ReachedDesiredRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_RecalculateBaseEyeHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_ReceivePossessed(IntPtr self, IntPtr newController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_ReceiveUnpossessed(IntPtr self, IntPtr oldController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_Restart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetCanAffectNavigationGeneration(IntPtr self, bool bNewValue, bool bForceUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetPlayerDefaults(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetPlayerState(IntPtr self, IntPtr newPlayerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetRemoteViewPitch(IntPtr self, float newRemoteViewPitch);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetupPlayerInputComponent(IntPtr self, IntPtr playerInputComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_ShouldTakeDamage(IntPtr self, float damage, IntPtr damageEvent, IntPtr eventInstigator, IntPtr damageCauser);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SpawnDefaultController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_TurnOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UnPossessed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UpdateNavAgent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UpdateNavigationRelevance(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Max difference between pawn's Rotation.Yaw and GetDesiredRotation().Yaw for pawn to be considered as having reached its desired rotation
		/// </summary>
		public float AllowedYawError
		{
			get => E_PROP_APawn_AllowedYawError_GET(NativePointer);
			set => E_PROP_APawn_AllowedYawError_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Determines when the Pawn creates and is possessed by an AI Controller (on level start, when spawned, etc).
		/// <para>Only possible if AIControllerClass is set, and ignored if AutoPossessPlayer is enabled. </para>
		/// @see AutoPossessPlayer
		/// </summary>
		public EAutoPossessAI AutoPossessAI
		{
			get => (EAutoPossessAI)E_PROP_APawn_AutoPossessAI_GET(NativePointer);
			set => E_PROP_APawn_AutoPossessAI_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Base eye height above collision center.
		/// </summary>
		public float BaseEyeHeight
		{
			get => E_PROP_APawn_BaseEyeHeight_GET(NativePointer);
			set => E_PROP_APawn_BaseEyeHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Playback of replays writes blended pitch to this, rather than the RemoteViewPitch. This is to avoid having to compress and interpolated value.
		/// </summary>
		public float BlendedReplayViewPitch
		{
			get => E_PROP_APawn_BlendedReplayViewPitch_GET(NativePointer);
			set => E_PROP_APawn_BlendedReplayViewPitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controller currently possessing this Actor
		/// </summary>
		public AController Controller
		{
			get => E_PROP_APawn_Controller_GET(NativePointer);
			set => E_PROP_APawn_Controller_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controller of the last Actor that caused us damage.
		/// </summary>
		public AController LastHitBy
		{
			get => E_PROP_APawn_LastHitBy_GET(NativePointer);
			set => E_PROP_APawn_LastHitBy_SET(NativePointer, value);
		}

		public byte RemoteViewPitch
		{
			get => E_PROP_APawn_RemoteViewPitch_GET(NativePointer);
			set => E_PROP_APawn_RemoteViewPitch_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.</param>
		public virtual void AddControllerPitchInput(float val)
			=> E_APawn_AddControllerPitchInput(this, val);
		
		
		/// <summary>
		/// Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.</param>
		public virtual void AddControllerRollInput(float val)
			=> E_APawn_AddControllerRollInput(this, val);
		
		
		/// <summary>
		/// Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.</param>
		public virtual void AddControllerYawInput(float val)
			=> E_APawn_AddControllerYawInput(this, val);
		
		
		/// <summary>
		/// Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction.
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <see cref="GetPendingMovementInputVector"/>
		/// </summary>
		/// <param name="worldDirection">Direction in world space to apply input</param>
		/// <param name="scaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.</param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored().</param>
		public virtual void AddMovementInput(FVector worldDirection, float scaleValue, bool bForce)
			=> E_APawn_AddMovementInput(this, worldDirection, scaleValue, bForce);
		
		
		/// <summary>
		/// Returns the pending input vector and resets it to zero.
		/// <para>This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames. </para>
		/// Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
		/// </summary>
		/// <return>The</return>
		public virtual FVector ConsumeMovementInputVector()
			=> E_APawn_ConsumeMovementInputVector(this);
		
		
		/// <summary>
		/// Creates an InputComponent that can be used for custom input bindings. Called upon possession by a PlayerController. Return null if you don't want one.
		/// </summary>
		protected virtual UInputComponent CreatePlayerInputComponent()
			=> E_APawn_CreatePlayerInputComponent(this);
		
		
		/// <summary>
		/// Destroys the player input component and removes any references to it.
		/// </summary>
		protected virtual void DestroyPlayerInputComponent()
			=> E_APawn_DestroyPlayerInputComponent(this);
		
		
		/// <summary>
		/// Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.
		/// </summary>
		public virtual void DetachFromControllerPendingDestroy()
			=> E_APawn_DetachFromControllerPendingDestroy(this);
		
		
		/// <summary>
		/// Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings.
		/// </summary>
		public virtual void FaceRotation(FRotator newControlRotation, float deltaTime)
			=> E_APawn_FaceRotation(this, newControlRotation, deltaTime);
		
		
		/// <summary>
		/// Return the aim rotation for the Pawn.
		/// <para>If we have a controller, by default we aim at the player's 'eyes' direction </para>
		/// that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players.
		/// </summary>
		public virtual FRotator GetBaseAimRotation()
			=> E_APawn_GetBaseAimRotation(this);
		
		
		/// <summary>
		/// Returns controller for this actor.
		/// </summary>
		public AController GetController()
			=> E_APawn_GetController(this);
		
		
		/// <summary>
		/// Get the rotation of the Controller, often the 'view' rotation of this Pawn.
		/// </summary>
		public FRotator GetControlRotation()
			=> E_APawn_GetControlRotation(this);
		
		
		/// <summary>
		/// Returns The half-height of the default Pawn, scaled by the component scale. By default returns the half-height of the RootComponent, regardless of whether it is registered or collidable.
		/// </summary>
		public virtual float GetDefaultHalfHeight()
			=> E_APawn_GetDefaultHalfHeight(this);
		
		
		/// <summary>
		/// Returns vector direction of gravity
		/// </summary>
		public FVector GetGravityDirection()
			=> E_APawn_GetGravityDirection(this);
		
		
		/// <summary>
		/// Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent.
		/// <para>Any user that needs to know about the input that last affected movement should use this function. </para>
		/// For example an animation update would want to use this, since by default the order of updates in a frame is:
		/// <para>PlayerController (device input) -> MovementComponent -> Pawn -> Mesh (animations) </para>
		/// <see cref="AddMovementInput"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetLastMovementInputVector()
			=> E_APawn_GetLastMovementInputVector(this);
		
		
		/// <summary>
		/// Return PrimitiveComponent we are based on (standing on, attached to, and moving on).
		/// </summary>
		public virtual UPrimitiveComponent GetMovementBase()
			=> E_APawn_GetMovementBase(this);
		
		
		/// <summary>
		/// Gets the owning actor of the Movement Base Component on which the pawn is standing.
		/// </summary>
		public AActor GetMovementBaseActor(APawn pawn)
			=> E_APawn_GetMovementBaseActor(this, pawn);
		
		
		/// <summary>
		/// Return our PawnMovementComponent, if we have one. By default, returns the first PawnMovementComponent found. Native classes that create their own movement component should override this method for more efficiency.
		/// </summary>
		public virtual UPawnMovementComponent GetMovementComponent()
			=> E_APawn_GetMovementComponent(this);
		
		
		/// <summary>
		/// Return our PawnNoiseEmitterComponent, if any. Default implementation returns the first PawnNoiseEmitterComponent found in the components array.
		/// <para>If one isn't found, then it tries to find one on the Pawn's current Controller. </para>
		/// </summary>
		public virtual UPawnNoiseEmitterComponent GetPawnNoiseEmitterComponent()
			=> E_APawn_GetPawnNoiseEmitterComponent(this);
		
		
		/// <summary>
		/// Returns	Pawn's eye location
		/// </summary>
		public virtual FVector GetPawnViewLocation()
			=> E_APawn_GetPawnViewLocation(this);
		
		
		/// <summary>
		/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it,
		/// <para>Usually only a PawnMovementComponent will want to read this value, or the Pawn itself if it is responsible for movement. </para>
		/// <see cref="AddMovementInput"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetPendingMovementInputVector()
			=> E_APawn_GetPendingMovementInputVector(this);
		
		
		/// <summary>
		/// If Pawn is possessed by a player, returns its Player State.  Needed for network play as controllers are not replicated to clients.
		/// </summary>
		public APlayerState GetPlayerState()
			=> E_APawn_GetPlayerState(this);
		
		
		/// <summary>
		/// Get the view rotation of the Pawn (direction they are looking, normally Controller->ControlRotation).
		/// </summary>
		/// <return>The</return>
		public virtual FRotator GetViewRotation()
			=> E_APawn_GetViewRotation(this);
		
		
		/// <summary>
		/// Returns true if player is viewing this Pawn in FreeCam
		/// </summary>
		public virtual bool InFreeCam()
			=> E_APawn_InFreeCam(this);
		
		
		/// <summary>
		/// Whether this Pawn's input handling is enabled.  Pawn must still be possessed to get input even if this is true
		/// </summary>
		public bool InputEnabled()
			=> E_APawn_InputEnabled(this);
		
		
		/// <summary>
		/// Internal function meant for use only within Pawn or by a PawnMovementComponent. Adds movement input if not ignored, or if forced.
		/// </summary>
		public void Internal_AddMovementInput(FVector worldAccel, bool bForce = false)
			=> E_APawn_Internal_AddMovementInput(this, worldAccel, bForce);
		
		
		/// <summary>
		/// Internal function meant for use only within Pawn or by a PawnMovementComponent. LastControlInputVector is updated with initial value of ControlInputVector. Returns ControlInputVector and resets it to zero.
		/// </summary>
		public FVector Internal_ConsumeMovementInputVector()
			=> E_APawn_Internal_ConsumeMovementInputVector(this);
		
		
		/// <summary>
		/// Internal function meant for use only within Pawn or by a PawnMovementComponent. Returns the value of LastControlInputVector.
		/// </summary>
		public FVector Internal_GetLastMovementInputVector()
			=> E_APawn_Internal_GetLastMovementInputVector(this);
		
		
		/// <summary>
		/// Internal function meant for use only within Pawn or by a PawnMovementComponent. Returns the value of ControlInputVector.
		/// </summary>
		public FVector Internal_GetPendingMovementInputVector()
			=> E_APawn_Internal_GetPendingMovementInputVector(this);
		
		
		/// <summary>
		/// Returns true if controlled by a bot.
		/// </summary>
		public virtual bool IsBotControlled()
			=> E_APawn_IsBotControlled(this);
		
		
		/// <summary>
		/// See if this actor is currently being controlled
		/// </summary>
		public bool IsControlled()
			=> E_APawn_IsControlled(this);
		
		
		/// <summary>
		/// Returns true if controlled by a local (not network) Controller.
		/// </summary>
		public virtual bool IsLocallyControlled()
			=> E_APawn_IsLocallyControlled(this);
		
		
		/// <summary>
		/// Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored().
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_APawn_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// Returns true if controlled by a human player (possessed by a PlayerController).
		/// </summary>
		public virtual bool IsPlayerControlled()
			=> E_APawn_IsPlayerControlled(this);
		
		
		/// <summary>
		/// (Deprecated) Return the input vector in world space.
		/// </summary>
		public FVector GetMovementInputVector()
			=> E_APawn_K2_GetMovementInputVector(this);
		
		
		/// <summary>
		/// (Deprecated) Launch Character with LaunchVelocity
		/// </summary>
		public void LaunchPawn(FVector launchVelocity, bool bXYOverride, bool bZOverride)
			=> E_APawn_LaunchPawn(this, launchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// Add an Actor to ignore by Pawn's movement collision
		/// </summary>
		public void MoveIgnoreActorAdd(AActor actorToIgnore)
			=> E_APawn_MoveIgnoreActorAdd(this, actorToIgnore);
		
		
		/// <summary>
		/// Remove an Actor to ignore by Pawn's movement collision
		/// </summary>
		public void MoveIgnoreActorRemove(AActor actorToIgnore)
			=> E_APawn_MoveIgnoreActorRemove(this, actorToIgnore);
		
		public virtual void OnRep_Controller()
			=> E_APawn_OnRep_Controller(this);
		
		public virtual void OnRep_PlayerState()
			=> E_APawn_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// Tell client that the Pawn is begin restarted. Calls Restart().
		/// </summary>
		public virtual void PawnClientRestart()
			=> E_APawn_PawnClientRestart(this);
		
		
		/// <summary>
		/// Inform AIControllers that you've made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)
		/// <para>The instigator of this sound is the pawn which is used to call MakeNoise. </para>
		/// </summary>
		/// <param name="loudness">is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.</param>
		/// <param name="noiseLocation">Position of noise source.  If zero vector, use the actor's location.</param>
		/// <param name="bUseNoiseMakerLocation">If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.</param>
		/// <param name="noiseMaker">Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker</param>
		public void PawnMakeNoise(float loudness, FVector noiseLocation, bool bUseNoiseMakerLocation = true, AActor noiseMaker = null)
			=> E_APawn_PawnMakeNoise(this, loudness, noiseLocation, bUseNoiseMakerLocation, noiseMaker);
		
		
		/// <summary>
		/// Handle StartFire() passed from PlayerController
		/// </summary>
		public virtual void PawnStartFire(byte fireModeNum)
			=> E_APawn_PawnStartFire(this, fireModeNum);
		
		
		/// <summary>
		/// Called when this Pawn is possessed. Only called on the server (or in standalone).
		/// </summary>
		/// <param name="newController">The controller possessing this pawn</param>
		public virtual void PossessedBy(AController newController)
			=> E_APawn_PossessedBy(this, newController);
		
		
		/// <summary>
		/// Return true if yaw is within AllowedYawError of desired yaw
		/// </summary>
		public virtual bool ReachedDesiredRotation()
			=> E_APawn_ReachedDesiredRotation(this);
		
		
		/// <summary>
		/// Set BaseEyeHeight based on current state.
		/// </summary>
		public virtual void RecalculateBaseEyeHeight()
			=> E_APawn_RecalculateBaseEyeHeight(this);
		
		
		/// <summary>
		/// Event called when the Pawn is possessed by a Controller (normally only occurs on the server/standalone).
		/// </summary>
		public void Possessed(AController newController)
			=> E_APawn_ReceivePossessed(this, newController);
		
		
		/// <summary>
		/// Event called when the Pawn is no longer possessed by a Controller.
		/// </summary>
		public void Unpossessed(AController oldController)
			=> E_APawn_ReceiveUnpossessed(this, oldController);
		
		
		/// <summary>
		/// Called when the Pawn is being restarted (usually by being possessed by a Controller).
		/// </summary>
		public virtual void Restart()
			=> E_APawn_Restart(this);
		
		
		/// <summary>
		/// Use SetCanAffectNavigationGeneration to change this value at runtime.
		/// <para>Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled. </para>
		/// </summary>
		public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
			=> E_APawn_SetCanAffectNavigationGeneration(this, bNewValue, bForceUpdate);
		
		
		/// <summary>
		/// Make sure pawn properties are back to default.
		/// </summary>
		public virtual void SetPlayerDefaults()
			=> E_APawn_SetPlayerDefaults(this);
		
		
		/// <summary>
		/// Set the Pawn's Player State. Keeps bi-directional reference of Pawn to Player State and back in sync.
		/// </summary>
		public void SetPlayerState(APlayerState newPlayerState)
			=> E_APawn_SetPlayerState(this, newPlayerState);
		
		
		/// <summary>
		/// Set Pawn ViewPitch, so we can see where remote clients are looking.
		/// <para>Maps 360.0 degrees into a byte </para>
		/// </summary>
		/// <param name="newRemoteViewPitch">Pitch component to replicate to remote (non owned) clients.</param>
		public void SetRemoteViewPitch(float newRemoteViewPitch)
			=> E_APawn_SetRemoteViewPitch(this, newRemoteViewPitch);
		
		
		/// <summary>
		/// Allows a Pawn to set up custom input bindings. Called upon possession by a PlayerController, using the InputComponent created by CreatePlayerInputComponent().
		/// </summary>
		protected virtual void SetupPlayerInputComponent(UInputComponent playerInputComponent)
			=> E_APawn_SetupPlayerInputComponent(this, playerInputComponent);
		
		
		/// <summary>
		/// Return true if we are in a state to take damage (checked at the start of TakeDamage.
		/// <para>Subclasses may check this as well if they override TakeDamage and don't want to potentially trigger TakeDamage actions by checking if it returns zero in the super class. </para>
		/// </summary>
		public virtual bool ShouldTakeDamage(float damage, FDamageEvent damageEvent, AController eventInstigator, AActor damageCauser)
			=> E_APawn_ShouldTakeDamage(this, damage, damageEvent, eventInstigator, damageCauser);
		
		
		/// <summary>
		/// Spawn default controller for this Pawn, and get possessed by it.
		/// </summary>
		public virtual void SpawnDefaultController()
			=> E_APawn_SpawnDefaultController(this);
		
		
		/// <summary>
		/// Freeze pawn - stop sounds, animations, physics, weapon firing
		/// </summary>
		public virtual void TurnOff()
			=> E_APawn_TurnOff(this);
		
		
		/// <summary>
		/// Called when our Controller no longer possesses us.
		/// </summary>
		public virtual void UnPossessed()
			=> E_APawn_UnPossessed(this);
		
		
		/// <summary>
		/// Updates MovementComponent's parameters used by navigation system
		/// </summary>
		public void UpdateNavAgent()
			=> E_APawn_UpdateNavAgent(this);
		
		
		/// <summary>
		/// Update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag
		/// </summary>
		public virtual void UpdateNavigationRelevance()
			=> E_APawn_UpdateNavigationRelevance(this);
		
		#endregion
		
		public static implicit operator IntPtr(APawn self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator APawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<APawn>(PtrDesc);
		}}}
