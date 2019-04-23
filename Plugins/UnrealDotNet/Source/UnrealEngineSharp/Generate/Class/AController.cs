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
		public AController(IntPtr Adress)
			: base(Adress)
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
		/// <para>PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs). </para>
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
		/// <para>Add dependency that makes us tick before the given Pawn. This minimizes latency between input processing and Pawn movement. </para>
		/// </summary>
		protected virtual void AddPawnTickDependency(APawn newPawn)
			=> E_AController_AddPawnTickDependency(this, newPawn);
		
		
		/// <summary>
		/// <para>Physically attach the Controller to the specified Pawn, so that our position reflects theirs. </para>
		/// <para>The attachment persists during possession of the pawn. The Controller's rotation continues to match the ControlRotation. </para>
		/// <para>Attempting to attach to a nullptr Pawn will call DetachFromPawn() instead. </para>
		/// </summary>
		protected virtual void AttachToPawn(APawn inPawn)
			=> E_AController_AttachToPawn(this, inPawn);
		
		
		/// <summary>
		/// <para>State entered when inactive (no possessed pawn, not spectating, etc). </para>
		/// </summary>
		protected virtual void BeginInactiveState()
			=> E_AController_BeginInactiveState(this);
		
		
		/// <summary>
		/// <para>DEPRECATED! Use the standard "Cast To" node instead. Casts this Controller to a Player Controller, if possible. </para>
		/// </summary>
		public APlayerController CastToPlayerController()
			=> E_AController_CastToPlayerController(this);
		
		
		/// <summary>
		/// <para>Change the current state to named state </para>
		/// </summary>
		public virtual void ChangeState(string newState)
			=> E_AController_ChangeState(this, newState);
		
		
		/// <summary>
		/// <para>Called from Destroyed().  Cleans up PlayerState. </para>
		/// </summary>
		public virtual void CleanupPlayerState()
			=> E_AController_CleanupPlayerState(this);
		
		public void ClientSetLocation(FVector newLocation, FRotator newRotation)
			=> E_AController_ClientSetLocation(this, newLocation, newRotation);
		
		public void ClientSetRotation(FRotator newRotation, bool bResetCamera = false)
			=> E_AController_ClientSetRotation(this, newRotation, bResetCamera);
		
		
		/// <summary>
		/// <para>Called when the level this controller is in is unloaded via streaming. </para>
		/// </summary>
		public virtual void CurrentLevelUnloaded()
			=> E_AController_CurrentLevelUnloaded(this);
		
		
		/// <summary>
		/// <para>Detach the RootComponent from its parent, but only if bAttachToPawn is true and it was attached to a Pawn. </para>
		/// </summary>
		protected virtual void DetachFromPawn()
			=> E_AController_DetachFromPawn(this);
		
		
		/// <summary>
		/// <para>Called when leaving the inactive state </para>
		/// </summary>
		protected virtual void EndInactiveState()
			=> E_AController_EndInactiveState(this);
		
		
		/// <summary>
		/// <para>GameMode failed to spawn pawn for me. </para>
		/// </summary>
		public virtual void FailedToSpawnPawn()
			=> E_AController_FailedToSpawnPawn(this);
		
		
		/// <summary>
		/// <para>Called from game mode upon end of the game, used to transition to proper state. </para>
		/// <param name="EndGameFocus">Actor to set as the view target on end game </param>
		/// <param name="bIsWinner">true if this controller is on winning team </param>
		/// </summary>
		public virtual void GameHasEnded(AActor endGameFocus, bool bIsWinner)
			=> E_AController_GameHasEnded(this, endGameFocus, bIsWinner);
		
		
		/// <summary>
		/// <para>Getter for Character </para>
		/// </summary>
		public ACharacter GetCharacter()
			=> E_AController_GetCharacter(this);
		
		
		/// <summary>
		/// <para>Get the control rotation. This is the full aim rotation, which may be different than a camera orientation (for example in a third person view), </para>
		/// <para>and may differ from the rotation of the controlled Pawn (which may choose not to visually pitch or roll, for example). </para>
		/// </summary>
		public virtual FRotator GetControlRotation()
			=> E_AController_GetControlRotation(this);
		
		
		/// <summary>
		/// <para>Get the desired pawn target rotation </para>
		/// </summary>
		public virtual FRotator GetDesiredRotation()
			=> E_AController_GetDesiredRotation(this);
		
		
		/// <summary>
		/// <para>Getter for Pawn </para>
		/// </summary>
		public APawn GetPawn()
			=> E_AController_GetPawn(this);
		
		
		/// <summary>
		/// <para>Returns Player's Point of View </para>
		/// <para>For the AI this means the Pawn's 'Eyes' ViewPoint </para>
		/// <para>For a Human player, this means the Camera's ViewPoint </para>
		/// <para>@output	out_Location, view location of player </para>
		/// <para>@output	out_rotation, view rotation of player </para>
		/// </summary>
		public virtual void GetPlayerViewPoint(FVector location, FRotator rotation)
			=> E_AController_GetPlayerViewPoint(this, location, rotation);
		
		
		/// <summary>
		/// <return>the name of the current state </return>
		/// </summary>
		public string GetStateName()
			=> E_AController_GetStateName(this);
		
		
		/// <summary>
		/// <para>Returns TransformComponent subobject </para>
		/// </summary>
		protected USceneComponent GetTransformComponent()
			=> E_AController_GetTransformComponent(this);
		
		
		/// <summary>
		/// <para>Get the actor the controller is looking at </para>
		/// </summary>
		public virtual AActor GetViewTarget()
			=> E_AController_GetViewTarget(this);
		
		
		/// <summary>
		/// <para>spawns and initializes the PlayerState for this Controller </para>
		/// </summary>
		public virtual void InitPlayerState()
			=> E_AController_InitPlayerState(this);
		
		
		/// <summary>
		/// <para>States (uses FNames for replication, correlated to state flags) </para>
		/// <param name="StateName">the name of the state to test against </param>
		/// <return>true if current state is StateName </return>
		/// </summary>
		public bool IsInState(string inStateName)
			=> E_AController_IsInState(this, inStateName);
		
		
		/// <summary>
		/// <para>Returns whether this Controller is a local controller. </para>
		/// </summary>
		public virtual bool IsLocalController()
			=> E_AController_IsLocalController(this);
		
		
		/// <summary>
		/// <para>Returns whether this Controller is a locally controlled PlayerController. </para>
		/// </summary>
		public bool IsLocalPlayerController()
			=> E_AController_IsLocalPlayerController(this);
		
		
		/// <summary>
		/// <para>Returns true if look input is ignored. </para>
		/// </summary>
		public virtual bool IsLookInputIgnored()
			=> E_AController_IsLookInputIgnored(this);
		
		
		/// <summary>
		/// <para>Returns true if movement input is ignored. </para>
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_AController_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// <para>Returns whether this Controller is a PlayerController. </para>
		/// </summary>
		public bool IsPlayerController()
			=> E_AController_IsPlayerController(this);
		
		
		/// <summary>
		/// <para>Return the Pawn that is currently 'controlled' by this PlayerController </para>
		/// </summary>
		public APawn GetControlledPawn()
			=> E_AController_K2_GetPawn(this);
		
		
		/// <summary>
		/// <para>Checks line to center and top of other actor </para>
		/// <param name="Other">is the actor whose visibility is being checked. </param>
		/// <param name="ViewPoint">is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position. </param>
		/// <param name="bAlternateChecks">used only in AIController implementation </param>
		/// <return>true if controller's pawn can see Other actor. </return>
		/// </summary>
		public virtual bool LineOfSightTo(AActor other, FVector viewPoint, bool bAlternateChecks)
			=> E_AController_LineOfSightTo(this, other, viewPoint, bAlternateChecks);
		
		
		/// <summary>
		/// <para>Overridable native function for when this controller possesses a pawn. </para>
		/// </summary>
		protected virtual void OnPossess(APawn inPawn)
			=> E_AController_OnPossess(this, inPawn);
		
		public virtual void OnRep_Pawn()
			=> E_AController_OnRep_Pawn(this);
		
		public virtual void OnRep_PlayerState()
			=> E_AController_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// <para>Overridable native function for when this controller unpossesses its pawn. </para>
		/// </summary>
		protected virtual void OnUnPossess()
			=> E_AController_OnUnPossess(this);
		
		
		/// <summary>
		/// <para>Called to unpossess our pawn because it is going to be destroyed. </para>
		/// <para>(other unpossession handled by UnPossess()) </para>
		/// </summary>
		public virtual void PawnPendingDestroy(APawn inPawn)
			=> E_AController_PawnPendingDestroy(this, inPawn);
		
		
		/// <summary>
		/// <para>Handles attaching this controller to the specified pawn. </para>
		/// <para>Only runs on the network authority (where HasAuthority() returns true). </para>
		/// <param name="InPawn">The Pawn to be possessed. </param>
		/// <para>@see HasAuthority() </para>
		/// </summary>
		public virtual void Possess(APawn inPawn)
			=> E_AController_Possess(this, inPawn);
		
		
		/// <summary>
		/// <para>Blueprint implementable event to react to the controller possessing a pawn </para>
		/// </summary>
		protected void ReceivePossess(APawn possessedPawn)
			=> E_AController_ReceivePossess(this, possessedPawn);
		
		
		/// <summary>
		/// <para>Blueprint implementable event to react to the controller unpossessing a pawn </para>
		/// </summary>
		protected void ReceiveUnPossess(APawn unpossessedPawn)
			=> E_AController_ReceiveUnPossess(this, unpossessedPawn);
		
		
		/// <summary>
		/// <para>Remove dependency that makes us tick before the given Pawn. </para>
		/// </summary>
		protected virtual void RemovePawnTickDependency(APawn inOldPawn)
			=> E_AController_RemovePawnTickDependency(this, inOldPawn);
		
		
		/// <summary>
		/// <para>Reset move and look input ignore flags. </para>
		/// </summary>
		public virtual void ResetIgnoreInputFlags()
			=> E_AController_ResetIgnoreInputFlags(this);
		
		
		/// <summary>
		/// <para>Stops ignoring look input by resetting the ignore look input state. </para>
		/// </summary>
		public virtual void ResetIgnoreLookInput()
			=> E_AController_ResetIgnoreLookInput(this);
		
		
		/// <summary>
		/// <para>Stops ignoring move input by resetting the ignore move input state. </para>
		/// </summary>
		public virtual void ResetIgnoreMoveInput()
			=> E_AController_ResetIgnoreMoveInput(this);
		
		
		/// <summary>
		/// <para>Set the control rotation. The RootComponent's rotation will also be updated to match it if RootComponent->bAbsoluteRotation is true. </para>
		/// </summary>
		public virtual void SetControlRotation(FRotator newRotation)
			=> E_AController_SetControlRotation(this, newRotation);
		
		
		/// <summary>
		/// <para>Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput. </para>
		/// <param name="bNewLookInput">If true, look input is ignored. If false, input is not ignored. </param>
		/// </summary>
		public virtual void SetIgnoreLookInput(bool bNewLookInput)
			=> E_AController_SetIgnoreLookInput(this, bNewLookInput);
		
		
		/// <summary>
		/// <para>Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput. </para>
		/// <param name="bNewMoveInput">If true, move input is ignored. If false, input is not ignored. </param>
		/// </summary>
		public virtual void SetIgnoreMoveInput(bool bNewMoveInput)
			=> E_AController_SetIgnoreMoveInput(this, bNewMoveInput);
		
		
		/// <summary>
		/// <para>Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created. </para>
		/// </summary>
		public virtual void SetInitialLocationAndRotation(FVector newLocation, FRotator newRotation)
			=> E_AController_SetInitialLocationAndRotation(this, newLocation, newRotation);
		
		
		/// <summary>
		/// <para>Setter for Pawn. Normally should only be used internally when possessing/unpossessing a Pawn. </para>
		/// </summary>
		public virtual void SetPawn(APawn inPawn)
			=> E_AController_SetPawn(this, inPawn);
		
		
		/// <summary>
		/// <para>Calls SetPawn and RepNotify locally </para>
		/// </summary>
		public void SetPawnFromRep(APawn inPawn)
			=> E_AController_SetPawnFromRep(this, inPawn);
		
		
		/// <summary>
		/// <para>Aborts the move the controller is currently performing </para>
		/// </summary>
		public virtual void StopMovement()
			=> E_AController_StopMovement(this);
		
		
		/// <summary>
		/// <para>Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()). </para>
		/// </summary>
		public virtual void UnPossess()
			=> E_AController_UnPossess(this);
		
		
		/// <summary>
		/// <para>If controller has any navigation-related components then this function </para>
		/// <para>makes them update their cached data </para>
		/// <para>DEPRECATED: this functionality has been taken over by PathFollowingComponent </para>
		/// <para>by observing newly possessed pawns (via OnNewPawn) </para>
		/// </summary>
		public virtual void UpdateNavigationComponents()
			=> E_AController_UpdateNavigationComponents(this);
		
		#endregion
		
		public static implicit operator IntPtr(AController self)
		{
			return self.NativePointer;
		}

		public static implicit operator AController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AController>(PtrDesc);
		}}}
