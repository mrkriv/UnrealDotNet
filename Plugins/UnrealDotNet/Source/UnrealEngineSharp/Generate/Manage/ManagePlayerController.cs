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
	public partial class ManagePlayerController : APlayerController, IManageWrapper
	{
		public ManagePlayerController(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_AddPitchInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_AddRollInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_AddYawInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_BeginPlayingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ClientClearCameraLensEffects(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ClientEnableNetworkVoice(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ClientVoiceHandshakeComplete(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_DelayedPrepareMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_EnableCheats(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_EndPlayingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_FOV(IntPtr self, float newFOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_Pause(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PlayerTick(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostProcessInput(IntPtr self, float deltaTime, bool bGamePaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PreProcessInput(IntPtr self, float deltaTime, bool bGamePaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_RestartLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SafeRetryClientRestart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SafeServerCheckClientPossession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetCinematicMode(IntPtr self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetDisableHaptics(IntPtr self, bool bNewDisabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetVirtualJoystickVisibility(IntPtr self, bool bVisible);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_StartFire(IntPtr self, byte fireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ToggleSpeaking(IntPtr self, bool bInSpeaking);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_UnFreeze(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_UpdateRotation(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_BeginInactiveState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_CleanupPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_CurrentLevelUnloaded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_DetachFromPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_EndInactiveState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_FailedToSpawnPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_InitPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_Pawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_PlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnUnPossess(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ResetIgnoreInputFlags(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ResetIgnoreLookInput(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ResetIgnoreMoveInput(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetIgnoreLookInput(IntPtr self, bool bNewLookInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetIgnoreMoveInput(IntPtr self, bool bNewMoveInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_StopMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_UpdateNavigationComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ClearCrossLevelReferences(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_Destroyed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ForceNetRelevant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ForceNetUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_GatherCurrentMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_InvalidateLightingCacheDetailed(IntPtr self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_K2_DestroyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_LifeSpanExpired(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_MarkComponentsAsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_NotifyActorBeginCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_NotifyActorEndCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_AttachmentReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_Instigator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_Owner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_ReplicatedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnRep_ReplicateMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnReplicationPausedChanged(IntPtr self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OutsideWorldBounds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostActorCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostNetInit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostNetReceiveLocationAndRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostNetReceivePhysicState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostNetReceiveRole(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostUnregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PreInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PreRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PrestreamTextures(IntPtr self, float seconds, bool bEnableStreaming, int cinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_RegisterActorTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_RegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ReregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_RerunConstructionScripts(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_Reset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_RewindForReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetActorHiddenInGame(IntPtr self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetLifeSpan(IntPtr self, float inLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_SetReplicateMovement(IntPtr self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_TearOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_TeleportSucceeded(IntPtr self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_Tick(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_TornOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_UnregisterAllComponents(IntPtr self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APlayerController_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Add Pitch (look up) input. This value is multiplied by InputPitchScale.
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by InputPitchScale.</param>
		public override void AddPitchInput(float val)
			=> E__Supper__APlayerController_AddPitchInput(this, val);
		
		
		/// <summary>
		/// Add Roll input. This value is multiplied by InputRollScale.
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by InputRollScale.</param>
		public override void AddRollInput(float val)
			=> E__Supper__APlayerController_AddRollInput(this, val);
		
		
		/// <summary>
		/// Add Yaw (turn) input. This value is multiplied by InputYawScale.
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by InputYawScale.</param>
		public override void AddYawInput(float val)
			=> E__Supper__APlayerController_AddYawInput(this, val);
		
		
		/// <summary>
		/// Pawn has been possessed, so changing state to NAME_Playing. Start it walking and begin playing with it.
		/// </summary>
		protected override void BeginPlayingState()
			=> E__Supper__APlayerController_BeginPlayingState(this);
		
		
		/// <summary>
		/// Removes all Camera Lens Effects.
		/// </summary>
		public override void ClientClearCameraLensEffects()
			=> E__Supper__APlayerController_ClientClearCameraLensEffects(this);
		
		public override void ClientEnableNetworkVoice(bool bEnable)
			=> E__Supper__APlayerController_ClientEnableNetworkVoice(this, bEnable);
		
		public override void ClientVoiceHandshakeComplete()
			=> E__Supper__APlayerController_ClientVoiceHandshakeComplete(this);
		
		
		/// <summary>
		/// Used to wait until a map change can be prepared when one was already in progress
		/// </summary>
		public override void DelayedPrepareMapChange()
			=> E__Supper__APlayerController_DelayedPrepareMapChange(this);
		
		public override void EnableCheats()
			=> E__Supper__APlayerController_EnableCheats(this);
		
		
		/// <summary>
		/// Leave playing state.
		/// </summary>
		protected override void EndPlayingState()
			=> E__Supper__APlayerController_EndPlayingState(this);
		
		public override void FOV(float newFOV)
			=> E__Supper__APlayerController_FOV(this, newFOV);
		
		public override void Pause()
			=> E__Supper__APlayerController_Pause(this);
		
		
		/// <summary>
		/// Processes player input (immediately after PlayerInput gets ticked) and calls UpdateRotation().
		/// <para>PlayerTick is only called if the PlayerController has a PlayerInput object. Therefore, it will only be called for locally controlled PlayerControllers. </para>
		/// </summary>
		public override void PlayerTick(float deltaTime)
			=> E__Supper__APlayerController_PlayerTick(this, deltaTime);
		
		
		/// <summary>
		/// Method called after processing input
		/// </summary>
		public override void PostProcessInput(float deltaTime, bool bGamePaused)
			=> E__Supper__APlayerController_PostProcessInput(this, deltaTime, bGamePaused);
		
		
		/// <summary>
		/// Called after this player controller has transitioned through seamless travel, but before that player is initialized
		/// <para>This is called both when a new player controller is created, and when it is maintained </para>
		/// </summary>
		public override void PostSeamlessTravel()
			=> E__Supper__APlayerController_PostSeamlessTravel(this);
		
		
		/// <summary>
		/// Method called prior to processing input
		/// </summary>
		public override void PreProcessInput(float deltaTime, bool bGamePaused)
			=> E__Supper__APlayerController_PreProcessInput(this, deltaTime, bGamePaused);
		
		public override void RestartLevel()
			=> E__Supper__APlayerController_RestartLevel(this);
		
		
		/// <summary>
		/// Call ClientRetryClientRestart, but only if the current pawn is not the currently acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public override void SafeRetryClientRestart()
			=> E__Supper__APlayerController_SafeRetryClientRestart(this);
		
		
		/// <summary>
		/// Call ServerCheckClientPossession on the server, but only if the current pawn is not the acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public override void SafeServerCheckClientPossession()
			=> E__Supper__APlayerController_SafeServerCheckClientPossession(this);
		
		
		/// <summary>
		/// Adjust input based on cinematic mode
		/// </summary>
		/// <param name="bInCinematicMode">specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.</param>
		/// <param name="bAffectsMovement">specify true to disable movement in cinematic mode, enable it when leaving</param>
		/// <param name="bAffectsTurning">specify true to disable turning in cinematic mode or enable it when leaving</param>
		public override void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
			=> E__Supper__APlayerController_SetCinematicMode(this, bInCinematicMode, bAffectsMovement, bAffectsTurning);
		
		
		/// <summary>
		/// Allows the player controller to disable all haptic requests from being fired, e.g. in the case of a level loading
		/// </summary>
		/// <param name="bNewDisabled">If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE</param>
		public override void SetDisableHaptics(bool bNewDisabled)
			=> E__Supper__APlayerController_SetDisableHaptics(this, bNewDisabled);
		
		
		/// <summary>
		/// Set the virtual joystick visibility.
		/// </summary>
		public override void SetVirtualJoystickVisibility(bool bVisible)
			=> E__Supper__APlayerController_SetVirtualJoystickVisibility(this, bVisible);
		
		public override void StartFire(byte fireModeNum)
			=> E__Supper__APlayerController_StartFire(this, fireModeNum);
		
		public override void ToggleSpeaking(bool bInSpeaking)
			=> E__Supper__APlayerController_ToggleSpeaking(this, bInSpeaking);
		
		
		/// <summary>
		/// Timer used by RoundEnded and Inactive states to accept player input again
		/// </summary>
		public override void UnFreeze()
			=> E__Supper__APlayerController_UnFreeze(this);
		
		
		/// <summary>
		/// Updates the rotation of player, based on ControlRotation after RotationInput has been applied.
		/// <para>This may then be modified by the PlayerCamera, and is passed to Pawn->FaceRotation(). </para>
		/// </summary>
		public override void UpdateRotation(float deltaTime)
			=> E__Supper__APlayerController_UpdateRotation(this, deltaTime);
		
		
		/// <summary>
		/// State entered when inactive (no possessed pawn, not spectating, etc).
		/// </summary>
		protected override void BeginInactiveState()
			=> E__Supper__APlayerController_BeginInactiveState(this);
		
		
		/// <summary>
		/// Called from Destroyed().  Cleans up PlayerState.
		/// </summary>
		public override void CleanupPlayerState()
			=> E__Supper__APlayerController_CleanupPlayerState(this);
		
		
		/// <summary>
		/// Called when the level this controller is in is unloaded via streaming.
		/// </summary>
		public override void CurrentLevelUnloaded()
			=> E__Supper__APlayerController_CurrentLevelUnloaded(this);
		
		
		/// <summary>
		/// Detach the RootComponent from its parent, but only if bAttachToPawn is true and it was attached to a Pawn.
		/// </summary>
		protected override void DetachFromPawn()
			=> E__Supper__APlayerController_DetachFromPawn(this);
		
		
		/// <summary>
		/// Called when leaving the inactive state
		/// </summary>
		protected override void EndInactiveState()
			=> E__Supper__APlayerController_EndInactiveState(this);
		
		
		/// <summary>
		/// GameMode failed to spawn pawn for me.
		/// </summary>
		public override void FailedToSpawnPawn()
			=> E__Supper__APlayerController_FailedToSpawnPawn(this);
		
		
		/// <summary>
		/// spawns and initializes the PlayerState for this Controller
		/// </summary>
		public override void InitPlayerState()
			=> E__Supper__APlayerController_InitPlayerState(this);
		
		public override void OnRep_Pawn()
			=> E__Supper__APlayerController_OnRep_Pawn(this);
		
		public override void OnRep_PlayerState()
			=> E__Supper__APlayerController_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// Overridable native function for when this controller unpossesses its pawn.
		/// </summary>
		protected override void OnUnPossess()
			=> E__Supper__APlayerController_OnUnPossess(this);
		
		
		/// <summary>
		/// Reset move and look input ignore flags.
		/// </summary>
		public override void ResetIgnoreInputFlags()
			=> E__Supper__APlayerController_ResetIgnoreInputFlags(this);
		
		
		/// <summary>
		/// Stops ignoring look input by resetting the ignore look input state.
		/// </summary>
		public override void ResetIgnoreLookInput()
			=> E__Supper__APlayerController_ResetIgnoreLookInput(this);
		
		
		/// <summary>
		/// Stops ignoring move input by resetting the ignore move input state.
		/// </summary>
		public override void ResetIgnoreMoveInput()
			=> E__Supper__APlayerController_ResetIgnoreMoveInput(this);
		
		
		/// <summary>
		/// Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.
		/// </summary>
		/// <param name="bNewLookInput">If true, look input is ignored. If false, input is not ignored.</param>
		public override void SetIgnoreLookInput(bool bNewLookInput)
			=> E__Supper__APlayerController_SetIgnoreLookInput(this, bNewLookInput);
		
		
		/// <summary>
		/// Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.
		/// </summary>
		/// <param name="bNewMoveInput">If true, move input is ignored. If false, input is not ignored.</param>
		public override void SetIgnoreMoveInput(bool bNewMoveInput)
			=> E__Supper__APlayerController_SetIgnoreMoveInput(this, bNewMoveInput);
		
		
		/// <summary>
		/// Aborts the move the controller is currently performing
		/// </summary>
		public override void StopMovement()
			=> E__Supper__APlayerController_StopMovement(this);
		
		
		/// <summary>
		/// If controller has any navigation-related components then this function
		/// <para>makes them update their cached data </para>
		/// DEPRECATED: this functionality has been taken over by PathFollowingComponent
		/// <para>by observing newly possessed pawns (via OnNewPawn) </para>
		/// </summary>
		public override void UpdateNavigationComponents()
			=> E__Supper__APlayerController_UpdateNavigationComponents(this);
		
		
		/// <summary>
		/// Overridable native event for when play begins for this actor.
		/// </summary>
		protected override void BeginPlay()
			=> E__Supper__APlayerController_BeginPlay(this);
		
		
		/// <summary>
		/// Do anything needed to clear out cross level references; Called from ULevel::PreSave
		/// </summary>
		public override void ClearCrossLevelReferences()
			=> E__Supper__APlayerController_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// Called when this actor is explicitly being destroyed during gameplay or in the editor, not called during level streaming or gameplay ending
		/// </summary>
		public override void Destroyed()
			=> E__Supper__APlayerController_Destroyed(this);
		
		
		/// <summary>
		/// Forces this actor to be net relevant if it is not already by default
		/// </summary>
		public override void ForceNetRelevant()
			=> E__Supper__APlayerController_ForceNetRelevant(this);
		
		
		/// <summary>
		/// Force actor to be updated to clients/demo net drivers
		/// </summary>
		public override void ForceNetUpdate()
			=> E__Supper__APlayerController_ForceNetUpdate(this);
		
		
		/// <summary>
		/// Fills ReplicatedMovement property
		/// </summary>
		public override void GatherCurrentMovement()
			=> E__Supper__APlayerController_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// Invalidates anything produced by the last lighting build.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E__Supper__APlayerController_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// Destroy the actor
		/// </summary>
		public override void DestroyActor()
			=> E__Supper__APlayerController_K2_DestroyActor(this);
		
		
		/// <summary>
		/// Called when the lifespan of an actor expires (if he has one).
		/// </summary>
		public override void LifeSpanExpired()
			=> E__Supper__APlayerController_LifeSpanExpired(this);
		
		
		/// <summary>
		/// Called to mark all components as pending kill when the actor is being destroyed
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E__Supper__APlayerController_MarkComponentsAsPendingKill(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved over it with the clickable interface.
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E__Supper__APlayerController_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved off of it with the clickable interface.
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E__Supper__APlayerController_NotifyActorEndCursorOver(this);
		
		public override void OnRep_AttachmentReplication()
			=> E__Supper__APlayerController_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E__Supper__APlayerController_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E__Supper__APlayerController_OnRep_Owner(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E__Supper__APlayerController_OnRep_ReplicatedMovement(this);
		
		public override void OnRep_ReplicateMovement()
			=> E__Supper__APlayerController_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// Called on the client when the replication paused value is changed
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E__Supper__APlayerController_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// Called when the Actor is outside the hard limit on world bounds
		/// </summary>
		public override void OutsideWorldBounds()
			=> E__Supper__APlayerController_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// Called when an actor is done spawning into the world (from UWorld::SpawnActor), both in the editor and during gameplay
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// This is called before calling construction scripts, but after native components have been created
		/// </summary>
		public override void PostActorCreated()
			=> E__Supper__APlayerController_PostActorCreated(this);
		
		
		/// <summary>
		/// Allow actors to initialize themselves on the C++ side after all of their components have been initialized, only called during gameplay
		/// </summary>
		public override void PostInitializeComponents()
			=> E__Supper__APlayerController_PostInitializeComponents(this);
		
		
		/// <summary>
		/// Always called immediately after spawning and reading in replicated properties
		/// </summary>
		public override void PostNetInit()
			=> E__Supper__APlayerController_PostNetInit(this);
		
		
		/// <summary>
		/// Update location and rotation from ReplicatedMovement. Not called for simulated physics!
		/// </summary>
		public override void PostNetReceiveLocationAndRotation()
			=> E__Supper__APlayerController_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity()
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E__Supper__APlayerController_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// Always called immediately after a new Role is received from the remote.
		/// </summary>
		public override void PostNetReceiveRole()
			=> E__Supper__APlayerController_PostNetReceiveRole(this);
		
		
		/// <summary>
		/// Called after all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PostRegisterAllComponents()
			=> E__Supper__APlayerController_PostRegisterAllComponents(this);
		
		
		/// <summary>
		/// Called after all currently registered components are cleared
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E__Supper__APlayerController_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// Called right before components are initialized, only called during gameplay
		/// </summary>
		public override void PreInitializeComponents()
			=> E__Supper__APlayerController_PreInitializeComponents(this);
		
		
		/// <summary>
		/// Called before all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PreRegisterAllComponents()
			=> E__Supper__APlayerController_PreRegisterAllComponents(this);
		
		
		/// <summary>
		/// Calls PrestreamTextures() for all the actor's meshcomponents.
		/// </summary>
		/// <param name="seconds">Number of seconds to force all mip-levels to be resident</param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming</param>
		/// <param name="cinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips</param>
		public override void PrestreamTextures(float seconds, bool bEnableStreaming, int cinematicTextureGroups)
			=> E__Supper__APlayerController_PrestreamTextures(this, seconds, bEnableStreaming, cinematicTextureGroups);
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions for the actor class hierarchy
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E__Supper__APlayerController_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// Ensure that all the components in the Components array are registered
		/// </summary>
		public override void RegisterAllComponents()
			=> E__Supper__APlayerController_RegisterAllComponents(this);
		
		
		/// <summary>
		/// Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty.
		/// </summary>
		public override void ReregisterAllComponents()
			=> E__Supper__APlayerController_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location.
		/// </summary>
		public override void RerunConstructionScripts()
			=> E__Supper__APlayerController_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// Reset actor to initial state - used when restarting level without reloading.
		/// </summary>
		public override void Reset()
			=> E__Supper__APlayerController_Reset(this);
		
		
		/// <summary>
		/// Called on the actor before checkpoint data is applied during a replay.
		/// <para>Only called if bReplayRewindable is set. </para>
		/// </summary>
		public override void RewindForReplay()
			=> E__Supper__APlayerController_RewindForReplay(this);
		
		
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// </summary>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components</param>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E__Supper__APlayerController_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.
		/// </summary>
		public override void SetLifeSpan(float inLifespan)
			=> E__Supper__APlayerController_SetLifeSpan(this, inLifespan);
		
		
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// </summary>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients.</param>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E__Supper__APlayerController_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.
		/// </summary>
		public override void TearOff()
			=> E__Supper__APlayerController_TearOff(this);
		
		
		/// <summary>
		/// Called from TeleportTo() when teleport succeeds
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest)
			=> E__Supper__APlayerController_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame.
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// </summary>
		/// <param name="deltaSeconds">Game time elapsed during last frame modified by the time dilation</param>
		public override void Tick(float deltaSeconds)
			=> E__Supper__APlayerController_Tick(this, deltaSeconds);
		
		
		/// <summary>
		/// Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients.
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff()
			=> E__Supper__APlayerController_TornOff(this);
		
		
		/// <summary>
		/// Unregister all currently registered components
		/// </summary>
		/// <param name="bForReregister">If true, RegisterAllComponents will be called immediately after this so some slow operations can be avoided</param>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E__Supper__APlayerController_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__APlayerController_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__APlayerController_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__APlayerController_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__APlayerController_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__APlayerController_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__APlayerController_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__APlayerController_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__APlayerController_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__APlayerController_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__APlayerController_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__APlayerController_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__APlayerController_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__APlayerController_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__APlayerController_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__APlayerController_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManagePlayerController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayerController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerController>(PtrDesc);
		}}}
