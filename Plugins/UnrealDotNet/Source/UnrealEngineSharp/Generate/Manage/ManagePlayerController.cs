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
		/// Activates a new touch interface for this player controller
		/// </summary>
		public override void ActivateTouchInterface(UTouchInterface newTouchInterface) { }
		
		
		/// <summary>
		/// Add Pitch (look up) input. This value is multiplied by InputPitchScale.
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by InputPitchScale.</param>
		public override void AddPitchInput(float val) { }
		
		
		/// <summary>
		/// Add Roll input. This value is multiplied by InputRollScale.
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by InputRollScale.</param>
		public override void AddRollInput(float val) { }
		
		
		/// <summary>
		/// Add Yaw (turn) input. This value is multiplied by InputYawScale.
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by InputYawScale.</param>
		public override void AddYawInput(float val) { }
		
		
		/// <summary>
		/// Pawn has been possessed, so changing state to NAME_Playing. Start it walking and begin playing with it.
		/// </summary>
		protected override void BeginPlayingState() { }
		
		public override void Camera(string newMode) { }
		
		
		/// <summary>
		/// Removes all Camera Lens Effects.
		/// </summary>
		public override void ClientClearCameraLensEffects() { }
		
		public override void ClientEnableNetworkVoice(bool bEnable) { }
		
		public override void ClientRepObjRef(UObject @object) { }
		
		public override void ClientReturnToMainMenu(string returnReason) { }
		
		public override void ClientReturnToMainMenuWithTextReason(string returnReason) { }
		
		public override void ClientVoiceHandshakeComplete() { }
		
		
		/// <summary>
		/// Used to wait until a map change can be prepared when one was already in progress
		/// </summary>
		public override void DelayedPrepareMapChange() { }
		
		public override void EnableCheats() { }
		
		
		/// <summary>
		/// Leave playing state.
		/// </summary>
		protected override void EndPlayingState() { }
		
		public override void FOV(float newFOV) { }
		
		public override void LocalTravel(string uRL) { }
		
		
		/// <summary>
		/// Called to notify the server when the client has loaded a new world via seamless traveling
		/// </summary>
		/// <param name="worldPackageName">the name of the world package that was loaded</param>
		/// <param name="bFinalDest">whether this world is the destination map for the travel (i.e. not the transition level)</param>
		public override void NotifyLoadedWorld(string worldPackageName, bool bFinalDest) { }
		
		public override void Pause() { }
		
		
		/// <summary>
		/// Processes player input (immediately after PlayerInput gets ticked) and calls UpdateRotation().
		/// <para>PlayerTick is only called if the PlayerController has a PlayerInput object. Therefore, it will only be called for locally controlled PlayerControllers. </para>
		/// </summary>
		public override void PlayerTick(float deltaTime) { }
		
		
		/// <summary>
		/// Method called after processing input
		/// </summary>
		public override void PostProcessInput(float deltaTime, bool bGamePaused) { }
		
		
		/// <summary>
		/// Called after this player controller has transitioned through seamless travel, but before that player is initialized
		/// <para>This is called both when a new player controller is created, and when it is maintained </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// Method called prior to processing input
		/// </summary>
		public override void PreProcessInput(float deltaTime, bool bGamePaused) { }
		
		public override void RestartLevel() { }
		
		
		/// <summary>
		/// Call ClientRetryClientRestart, but only if the current pawn is not the currently acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public override void SafeRetryClientRestart() { }
		
		
		/// <summary>
		/// Call ServerCheckClientPossession on the server, but only if the current pawn is not the acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public override void SafeServerCheckClientPossession() { }
		
		
		/// <summary>
		/// Called when seamless traveling and the specified PC is being replaced by this one
		/// <para>copy over data that should persist </para>
		/// (not called if PlayerController is the same for the from and to GameModes)
		/// </summary>
		public override void SeamlessTravelFrom(APlayerController oldPC) { }
		
		
		/// <summary>
		/// Called when seamless traveling and we are being replaced by the specified PC
		/// <para>clean up any persistent state (post process chains on LocalPlayers, for example) </para>
		/// (not called if PlayerController is the same for the from and to GameModes)
		/// </summary>
		public override void SeamlessTravelTo(APlayerController newPC) { }
		
		public override void SendToConsole(string command) { }
		
		
		/// <summary>
		/// Adjust input based on cinematic mode
		/// </summary>
		/// <param name="bInCinematicMode">specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.</param>
		/// <param name="bAffectsMovement">specify true to disable movement in cinematic mode, enable it when leaving</param>
		/// <param name="bAffectsTurning">specify true to disable turning in cinematic mode or enable it when leaving</param>
		public override void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning) { }
		
		
		/// <summary>
		/// Allows the player controller to disable all haptic requests from being fired, e.g. in the case of a level loading
		/// </summary>
		/// <param name="bNewDisabled">If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE</param>
		public override void SetDisableHaptics(bool bNewDisabled) { }
		
		public override void SetName(string s) { }
		
		
		/// <summary>
		/// Set the virtual joystick visibility.
		/// </summary>
		public override void SetVirtualJoystickVisibility(bool bVisible) { }
		
		public override void StartFire(byte fireModeNum) { }
		
		public override void SwitchLevel(string uRL) { }
		
		public override void ToggleSpeaking(bool bInSpeaking) { }
		
		
		/// <summary>
		/// Timer used by RoundEnded and Inactive states to accept player input again
		/// </summary>
		public override void UnFreeze() { }
		
		
		/// <summary>
		/// Updates the rotation of player, based on ControlRotation after RotationInput has been applied.
		/// <para>This may then be modified by the PlayerCamera, and is passed to Pawn->FaceRotation(). </para>
		/// </summary>
		public override void UpdateRotation(float deltaTime) { }
		
		public static implicit operator IntPtr(ManagePlayerController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayerController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerController>(PtrDesc);
		}}}
