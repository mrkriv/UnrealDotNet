// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:237

namespace UnrealEngine
{
	[ManageType("ManagePlayerController")]
	public partial class ManagePlayerController : APlayerController
	{
		public ManagePlayerController(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Activates a new touch interface for this player controller </para>
		/// </summary>
		public override void ActivateTouchInterface(UTouchInterface newTouchInterface) { }
		
		
		/// <summary>
		/// <para>Add Pitch (look up) input. This value is multiplied by InputPitchScale. </para>
		/// <param name="Val">Amount to add to Pitch. This value is multiplied by InputPitchScale. </param>
		/// </summary>
		public override void AddPitchInput(float val) { }
		
		
		/// <summary>
		/// <para>Add Roll input. This value is multiplied by InputRollScale. </para>
		/// <param name="Val">Amount to add to Roll. This value is multiplied by InputRollScale. </param>
		/// </summary>
		public override void AddRollInput(float val) { }
		
		
		/// <summary>
		/// <para>Add Yaw (turn) input. This value is multiplied by InputYawScale. </para>
		/// <param name="Val">Amount to add to Yaw. This value is multiplied by InputYawScale. </param>
		/// </summary>
		public override void AddYawInput(float val) { }
		
		
		/// <summary>
		/// <para>Pawn has been possessed, so changing state to NAME_Playing. Start it walking and begin playing with it. </para>
		/// </summary>
		protected override void BeginPlayingState() { }
		
		public override void Camera(string newMode) { }
		
		
		/// <summary>
		/// <para>Removes all Camera Lens Effects. </para>
		/// </summary>
		public override void ClientClearCameraLensEffects() { }
		
		public override void ClientEnableNetworkVoice(bool bEnable) { }
		
		public override void ClientRepObjRef(UObject @object) { }
		
		public override void ClientReturnToMainMenu(string returnReason) { }
		
		public override void ClientReturnToMainMenuWithTextReason(string returnReason) { }
		
		public override void ClientVoiceHandshakeComplete() { }
		
		
		/// <summary>
		/// <para>Used to wait until a map change can be prepared when one was already in progress </para>
		/// </summary>
		public override void DelayedPrepareMapChange() { }
		
		public override void EnableCheats() { }
		
		
		/// <summary>
		/// <para>Leave playing state. </para>
		/// </summary>
		protected override void EndPlayingState() { }
		
		public override void FOV(float newFOV) { }
		
		
		/// <summary>
		/// <para>Called on client during seamless level transitions to get the list of Actors that should be moved into the new level </para>
		/// <para>PlayerControllers, Role < ROLE_Authority Actors, and any non-Actors that are inside an Actor that is in the list </para>
		/// <para>(i.e. Object.Outer == Actor in the list) </para>
		/// <para>are all automatically moved regardless of whether they're included here </para>
		/// <para>only dynamic actors in the PersistentLevel may be moved (this includes all actors spawned during gameplay) </para>
		/// <para>this is called for both parts of the transition because actors might change while in the middle (e.g. players might join or leave the game) </para>
		/// <para>@see also GameModeBase::GetSeamlessTravelActorList() (the function that's called on servers) </para>
		/// <param name="bToEntry">true if we are going from old level -> entry, false if we are going from entry -> new level </param>
		/// <param name="ActorList">out) list of actors to maintain </param>
		/// </summary>
		public override void GetSeamlessTravelActorList(bool bToEntry, TArray<AActor> actorList) { }
		
		public override void LocalTravel(string uRL) { }
		
		
		/// <summary>
		/// <para>Called to notify the server when the client has loaded a new world via seamless traveling </para>
		/// <param name="WorldPackageName">the name of the world package that was loaded </param>
		/// <param name="bFinalDest">whether this world is the destination map for the travel (i.e. not the transition level) </param>
		/// </summary>
		public override void NotifyLoadedWorld(string worldPackageName, bool bFinalDest) { }
		
		public override void Pause() { }
		
		
		/// <summary>
		/// <para>Processes player input (immediately after PlayerInput gets ticked) and calls UpdateRotation(). </para>
		/// <para>PlayerTick is only called if the PlayerController has a PlayerInput object. Therefore, it will only be called for locally controlled PlayerControllers. </para>
		/// </summary>
		public override void PlayerTick(float deltaTime) { }
		
		
		/// <summary>
		/// <para>Method called after processing input </para>
		/// </summary>
		public override void PostProcessInput(float deltaTime, bool bGamePaused) { }
		
		
		/// <summary>
		/// <para>Called after this player controller has transitioned through seamless travel, but before that player is initialized </para>
		/// <para>This is called both when a new player controller is created, and when it is maintained </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// <para>Method called prior to processing input </para>
		/// </summary>
		public override void PreProcessInput(float deltaTime, bool bGamePaused) { }
		
		public override void RestartLevel() { }
		
		
		/// <summary>
		/// <para>Call ClientRetryClientRestart, but only if the current pawn is not the currently acknowledged pawn (and throttled to avoid saturating the network). </para>
		/// </summary>
		public override void SafeRetryClientRestart() { }
		
		
		/// <summary>
		/// <para>Call ServerCheckClientPossession on the server, but only if the current pawn is not the acknowledged pawn (and throttled to avoid saturating the network). </para>
		/// </summary>
		public override void SafeServerCheckClientPossession() { }
		
		
		/// <summary>
		/// <para>Called when seamless traveling and the specified PC is being replaced by this one </para>
		/// <para>copy over data that should persist </para>
		/// <para>(not called if PlayerController is the same for the from and to GameModes) </para>
		/// </summary>
		public override void SeamlessTravelFrom(APlayerController oldPC) { }
		
		
		/// <summary>
		/// <para>Called when seamless traveling and we are being replaced by the specified PC </para>
		/// <para>clean up any persistent state (post process chains on LocalPlayers, for example) </para>
		/// <para>(not called if PlayerController is the same for the from and to GameModes) </para>
		/// </summary>
		public override void SeamlessTravelTo(APlayerController newPC) { }
		
		public override void SendToConsole(string command) { }
		
		
		/// <summary>
		/// <para>Adjust input based on cinematic mode </para>
		/// <param name="bInCinematicMode">specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode. </param>
		/// <param name="bAffectsMovement">specify true to disable movement in cinematic mode, enable it when leaving </param>
		/// <param name="bAffectsTurning">specify true to disable turning in cinematic mode or enable it when leaving </param>
		/// </summary>
		public override void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning) { }
		
		
		/// <summary>
		/// <para>Allows the player controller to disable all haptic requests from being fired, e.g. in the case of a level loading </para>
		/// <param name="bNewDisabled">If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE </param>
		/// </summary>
		public override void SetDisableHaptics(bool bNewDisabled) { }
		
		public override void SetName(string s) { }
		
		
		/// <summary>
		/// <para>Set the virtual joystick visibility. </para>
		/// </summary>
		public override void SetVirtualJoystickVisibility(bool bVisible) { }
		
		public override void StartFire(byte fireModeNum) { }
		
		public override void SwitchLevel(string uRL) { }
		
		public override void ToggleSpeaking(bool bInSpeaking) { }
		
		
		/// <summary>
		/// <para>Timer used by RoundEnded and Inactive states to accept player input again </para>
		/// </summary>
		public override void UnFreeze() { }
		
		
		/// <summary>
		/// <para>Updates the rotation of player, based on ControlRotation after RotationInput has been applied. </para>
		/// <para>This may then be modified by the PlayerCamera, and is passed to Pawn->FaceRotation(). </para>
		/// </summary>
		public override void UpdateRotation(float deltaTime) { }
		
		public static implicit operator IntPtr(ManagePlayerController self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePlayerController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerController>(PtrDesc);
		}}}
