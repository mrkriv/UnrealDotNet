// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Controller.h:40

namespace UnrealEngine
{
	public  partial class AController : AActor
	{
		public AController(IntPtr adress)
			: base(adress)
		{
		}

		public AController(UObject Parent = null, string Name = "Controller")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AController(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AController_PlayerState_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AController_PlayerState_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_AController_StateName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AController_StateName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AController(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_AddPawnTickDependency(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_AttachToPawn(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_BeginInactiveState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_CastToPlayerController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ChangeState(IntPtr self, string newState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_CleanupPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ClientSetLocation(IntPtr self, IntPtr newLocation, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ClientSetRotation(IntPtr self, IntPtr newRotation, bool bResetCamera);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_CurrentLevelUnloaded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_DetachFromPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_EndInactiveState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_FailedToSpawnPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_GameHasEnded(IntPtr self, IntPtr endGameFocus, bool bIsWinner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_GetCharacter(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AController_GetControlRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AController_GetDesiredRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_GetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_GetPlayerViewPoint(IntPtr self, IntPtr location, IntPtr rotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AController_GetStateName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_GetTransformComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_GetViewTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_InitPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsInState(IntPtr self, string inStateName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsLocalController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsLocalPlayerController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsLookInputIgnored(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsMoveInputIgnored(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_IsPlayerController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AController_K2_GetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AController_LineOfSightTo(IntPtr self, IntPtr other, IntPtr viewPoint, bool bAlternateChecks);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_OnPossess(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_OnRep_Pawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_OnRep_PlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_OnUnPossess(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_PawnPendingDestroy(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_Possess(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ReceivePossess(IntPtr self, IntPtr possessedPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ReceiveUnPossess(IntPtr self, IntPtr unpossessedPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_RemovePawnTickDependency(IntPtr self, IntPtr inOldPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ResetIgnoreInputFlags(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ResetIgnoreLookInput(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_ResetIgnoreMoveInput(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetControlRotation(IntPtr self, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetIgnoreLookInput(IntPtr self, bool bNewLookInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetIgnoreMoveInput(IntPtr self, bool bNewMoveInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetInitialLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetPawn(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_SetPawnFromRep(IntPtr self, IntPtr inPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_StopMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_UnPossess(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AController_UpdateNavigationComponents(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs).
		/// </summary>
		public APlayerState PlayerState
		{
			get => E_PROP_AController_PlayerState_GET(NativePointer);
			set => E_PROP_AController_PlayerState_SET(NativePointer, value);
		}

		public string StateName
		{
			get => E_PROP_AController_StateName_GET(NativePointer);
			set => E_PROP_AController_StateName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add dependency that makes us tick before the given Pawn. This minimizes latency between input processing and Pawn movement.
		/// </summary>
		protected virtual void AddPawnTickDependency(APawn newPawn)
			=> E_AController_AddPawnTickDependency(this, newPawn);
		
		
		/// <summary>
		/// Physically attach the Controller to the specified Pawn, so that our position reflects theirs.
		/// <para>The attachment persists during possession of the pawn. The Controller's rotation continues to match the ControlRotation. </para>
		/// Attempting to attach to a nullptr Pawn will call DetachFromPawn() instead.
		/// </summary>
		protected virtual void AttachToPawn(APawn inPawn)
			=> E_AController_AttachToPawn(this, inPawn);
		
		
		/// <summary>
		/// State entered when inactive (no possessed pawn, not spectating, etc).
		/// </summary>
		protected virtual void BeginInactiveState()
			=> E_AController_BeginInactiveState(this);
		
		
		/// <summary>
		/// DEPRECATED! Use the standard "Cast To" node instead. Casts this Controller to a Player Controller, if possible.
		/// </summary>
		public APlayerController CastToPlayerController()
			=> E_AController_CastToPlayerController(this);
		
		
		/// <summary>
		/// Change the current state to named state
		/// </summary>
		public virtual void ChangeState(string newState)
			=> E_AController_ChangeState(this, newState);
		
		
		/// <summary>
		/// Called from Destroyed().  Cleans up PlayerState.
		/// </summary>
		public virtual void CleanupPlayerState()
			=> E_AController_CleanupPlayerState(this);
		
		public void ClientSetLocation(FVector newLocation, FRotator newRotation)
			=> E_AController_ClientSetLocation(this, newLocation, newRotation);
		
		public void ClientSetRotation(FRotator newRotation, bool bResetCamera = false)
			=> E_AController_ClientSetRotation(this, newRotation, bResetCamera);
		
		
		/// <summary>
		/// Called when the level this controller is in is unloaded via streaming.
		/// </summary>
		public virtual void CurrentLevelUnloaded()
			=> E_AController_CurrentLevelUnloaded(this);
		
		
		/// <summary>
		/// Detach the RootComponent from its parent, but only if bAttachToPawn is true and it was attached to a Pawn.
		/// </summary>
		protected virtual void DetachFromPawn()
			=> E_AController_DetachFromPawn(this);
		
		
		/// <summary>
		/// Called when leaving the inactive state
		/// </summary>
		protected virtual void EndInactiveState()
			=> E_AController_EndInactiveState(this);
		
		
		/// <summary>
		/// GameMode failed to spawn pawn for me.
		/// </summary>
		public virtual void FailedToSpawnPawn()
			=> E_AController_FailedToSpawnPawn(this);
		
		
		/// <summary>
		/// Called from game mode upon end of the game, used to transition to proper state.
		/// </summary>
		/// <param name="endGameFocus">Actor to set as the view target on end game</param>
		/// <param name="bIsWinner">true if this controller is on winning team</param>
		public virtual void GameHasEnded(AActor endGameFocus, bool bIsWinner)
			=> E_AController_GameHasEnded(this, endGameFocus, bIsWinner);
		
		
		/// <summary>
		/// Getter for Character
		/// </summary>
		public ACharacter GetCharacter()
			=> E_AController_GetCharacter(this);
		
		
		/// <summary>
		/// Get the control rotation. This is the full aim rotation, which may be different than a camera orientation (for example in a third person view),
		/// <para>and may differ from the rotation of the controlled Pawn (which may choose not to visually pitch or roll, for example). </para>
		/// </summary>
		public virtual FRotator GetControlRotation()
			=> E_AController_GetControlRotation(this);
		
		
		/// <summary>
		/// Get the desired pawn target rotation
		/// </summary>
		public virtual FRotator GetDesiredRotation()
			=> E_AController_GetDesiredRotation(this);
		
		
		/// <summary>
		/// Getter for Pawn
		/// </summary>
		public APawn GetPawn()
			=> E_AController_GetPawn(this);
		
		
		/// <summary>
		/// Returns Player's Point of View
		/// <para>For the AI this means the Pawn's 'Eyes' ViewPoint </para>
		/// For a Human player, this means the Camera's ViewPoint
		/// <para>@output	out_Location, view location of player </para>
		/// @output	out_rotation, view rotation of player
		/// </summary>
		public virtual void GetPlayerViewPoint(FVector location, FRotator rotation)
			=> E_AController_GetPlayerViewPoint(this, location, rotation);
		
		
		/// <summary>
		/// </summary>
		/// <return>the</return>
		public string GetStateName()
			=> E_AController_GetStateName(this);
		
		
		/// <summary>
		/// Returns TransformComponent subobject
		/// </summary>
		protected USceneComponent GetTransformComponent()
			=> E_AController_GetTransformComponent(this);
		
		
		/// <summary>
		/// Get the actor the controller is looking at
		/// </summary>
		public virtual AActor GetViewTarget()
			=> E_AController_GetViewTarget(this);
		
		
		/// <summary>
		/// spawns and initializes the PlayerState for this Controller
		/// </summary>
		public virtual void InitPlayerState()
			=> E_AController_InitPlayerState(this);
		
		
		/// <summary>
		/// States (uses FNames for replication, correlated to state flags)
		/// </summary>
		/// <param name="stateName">the name of the state to test against</param>
		/// <return>true</return>
		public bool IsInState(string inStateName)
			=> E_AController_IsInState(this, inStateName);
		
		
		/// <summary>
		/// Returns whether this Controller is a local controller.
		/// </summary>
		public virtual bool IsLocalController()
			=> E_AController_IsLocalController(this);
		
		
		/// <summary>
		/// Returns whether this Controller is a locally controlled PlayerController.
		/// </summary>
		public bool IsLocalPlayerController()
			=> E_AController_IsLocalPlayerController(this);
		
		
		/// <summary>
		/// Returns true if look input is ignored.
		/// </summary>
		public virtual bool IsLookInputIgnored()
			=> E_AController_IsLookInputIgnored(this);
		
		
		/// <summary>
		/// Returns true if movement input is ignored.
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_AController_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// Returns whether this Controller is a PlayerController.
		/// </summary>
		public bool IsPlayerController()
			=> E_AController_IsPlayerController(this);
		
		
		/// <summary>
		/// Return the Pawn that is currently 'controlled' by this PlayerController
		/// </summary>
		public APawn GetControlledPawn()
			=> E_AController_K2_GetPawn(this);
		
		
		/// <summary>
		/// Checks line to center and top of other actor
		/// </summary>
		/// <param name="other">is the actor whose visibility is being checked.</param>
		/// <param name="viewPoint">is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position.</param>
		/// <param name="bAlternateChecks">used only in AIController implementation</param>
		/// <return>true</return>
		public virtual bool LineOfSightTo(AActor other, FVector viewPoint, bool bAlternateChecks)
			=> E_AController_LineOfSightTo(this, other, viewPoint, bAlternateChecks);
		
		
		/// <summary>
		/// Overridable native function for when this controller possesses a pawn.
		/// </summary>
		protected virtual void OnPossess(APawn inPawn)
			=> E_AController_OnPossess(this, inPawn);
		
		public virtual void OnRep_Pawn()
			=> E_AController_OnRep_Pawn(this);
		
		public virtual void OnRep_PlayerState()
			=> E_AController_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// Overridable native function for when this controller unpossesses its pawn.
		/// </summary>
		protected virtual void OnUnPossess()
			=> E_AController_OnUnPossess(this);
		
		
		/// <summary>
		/// Called to unpossess our pawn because it is going to be destroyed.
		/// <para>(other unpossession handled by UnPossess()) </para>
		/// </summary>
		public virtual void PawnPendingDestroy(APawn inPawn)
			=> E_AController_PawnPendingDestroy(this, inPawn);
		
		
		/// <summary>
		/// Handles attaching this controller to the specified pawn.
		/// <para>Only runs on the network authority (where HasAuthority() returns true). </para>
		/// <see cref="HasAuthority"/>
		/// </summary>
		/// <param name="inPawn">The Pawn to be possessed.</param>
		public virtual void Possess(APawn inPawn)
			=> E_AController_Possess(this, inPawn);
		
		
		/// <summary>
		/// Blueprint implementable event to react to the controller possessing a pawn
		/// </summary>
		protected void ReceivePossess(APawn possessedPawn)
			=> E_AController_ReceivePossess(this, possessedPawn);
		
		
		/// <summary>
		/// Blueprint implementable event to react to the controller unpossessing a pawn
		/// </summary>
		protected void ReceiveUnPossess(APawn unpossessedPawn)
			=> E_AController_ReceiveUnPossess(this, unpossessedPawn);
		
		
		/// <summary>
		/// Remove dependency that makes us tick before the given Pawn.
		/// </summary>
		protected virtual void RemovePawnTickDependency(APawn inOldPawn)
			=> E_AController_RemovePawnTickDependency(this, inOldPawn);
		
		
		/// <summary>
		/// Reset move and look input ignore flags.
		/// </summary>
		public virtual void ResetIgnoreInputFlags()
			=> E_AController_ResetIgnoreInputFlags(this);
		
		
		/// <summary>
		/// Stops ignoring look input by resetting the ignore look input state.
		/// </summary>
		public virtual void ResetIgnoreLookInput()
			=> E_AController_ResetIgnoreLookInput(this);
		
		
		/// <summary>
		/// Stops ignoring move input by resetting the ignore move input state.
		/// </summary>
		public virtual void ResetIgnoreMoveInput()
			=> E_AController_ResetIgnoreMoveInput(this);
		
		
		/// <summary>
		/// Set the control rotation. The RootComponent's rotation will also be updated to match it if RootComponent->bAbsoluteRotation is true.
		/// </summary>
		public virtual void SetControlRotation(FRotator newRotation)
			=> E_AController_SetControlRotation(this, newRotation);
		
		
		/// <summary>
		/// Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.
		/// </summary>
		/// <param name="bNewLookInput">If true, look input is ignored. If false, input is not ignored.</param>
		public virtual void SetIgnoreLookInput(bool bNewLookInput)
			=> E_AController_SetIgnoreLookInput(this, bNewLookInput);
		
		
		/// <summary>
		/// Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.
		/// </summary>
		/// <param name="bNewMoveInput">If true, move input is ignored. If false, input is not ignored.</param>
		public virtual void SetIgnoreMoveInput(bool bNewMoveInput)
			=> E_AController_SetIgnoreMoveInput(this, bNewMoveInput);
		
		
		/// <summary>
		/// Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created.
		/// </summary>
		public virtual void SetInitialLocationAndRotation(FVector newLocation, FRotator newRotation)
			=> E_AController_SetInitialLocationAndRotation(this, newLocation, newRotation);
		
		
		/// <summary>
		/// Setter for Pawn. Normally should only be used internally when possessing/unpossessing a Pawn.
		/// </summary>
		public virtual void SetPawn(APawn inPawn)
			=> E_AController_SetPawn(this, inPawn);
		
		
		/// <summary>
		/// Calls SetPawn and RepNotify locally
		/// </summary>
		public void SetPawnFromRep(APawn inPawn)
			=> E_AController_SetPawnFromRep(this, inPawn);
		
		
		/// <summary>
		/// Aborts the move the controller is currently performing
		/// </summary>
		public virtual void StopMovement()
			=> E_AController_StopMovement(this);
		
		
		/// <summary>
		/// Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()).
		/// </summary>
		public virtual void UnPossess()
			=> E_AController_UnPossess(this);
		
		
		/// <summary>
		/// If controller has any navigation-related components then this function
		/// <para>makes them update their cached data </para>
		/// DEPRECATED: this functionality has been taken over by PathFollowingComponent
		/// <para>by observing newly possessed pawns (via OnNewPawn) </para>
		/// </summary>
		public virtual void UpdateNavigationComponents()
			=> E_AController_UpdateNavigationComponents(this);
		
		#endregion
		
		public static implicit operator IntPtr(AController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AController>(PtrDesc);
		}}}
