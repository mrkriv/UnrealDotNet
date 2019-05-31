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
	public  partial class APlayerController : AController
	{
		public APlayerController(IntPtr adress)
			: base(adress)
		{
		}

		public APlayerController(UObject Parent = null, string Name = "PlayerController")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_APlayerController(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerController_AcknowledgedPawn_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_AcknowledgedPawn_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_APlayerController_bAutoManageActiveCameraTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_bAutoManageActiveCameraTarget_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_BlendedTargetViewRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_BlendedTargetViewRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_APlayerController_bRenderPrimitiveComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_bRenderPrimitiveComponents_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerController_CheatManager_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_CheatManager_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_APlayerController_ClientCap_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_ClientCap_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_ForceFeedbackScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_ForceFeedbackScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_HitResultTraceDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_HitResultTraceDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_InputPitchScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_InputPitchScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_InputRollScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_InputRollScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_InputYawScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_InputYawScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_LastSpectatorStateSynchTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_LastSpectatorStateSynchTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_LastSpectatorSyncLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_LastSpectatorSyncLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_LastSpectatorSyncRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_LastSpectatorSyncRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_MuteList_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_MuteList_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerController_MyHUD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_MyHUD_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerController_NetPlayerIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_NetPlayerIndex_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerController_Player_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_Player_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_APlayerController_PlayerInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_PlayerInput_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_RotationInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_RotationInput_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerController_SmoothTargetViewRotationSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_SmoothTargetViewRotationSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_APlayerController_TargetViewRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerController_TargetViewRotation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_APlayerController(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ActivateTouchInterface(IntPtr self, IntPtr newTouchInterface);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_AddPitchInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_AddRollInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_AddYawInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_BeginPlayingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_Camera(IntPtr self, string newMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientAddTextureStreamingLoc(IntPtr self, IntPtr inLoc, float duration, bool bOverrideLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientCancelPendingMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientCapBandwidth(IntPtr self, int cap);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientClearCameraLensEffects(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientCommitMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientEnableNetworkVoice(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientEndOnlineSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientFlushLevelStreaming(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientForceGarbageCollection(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientGameEnded(IntPtr self, IntPtr endGameFocus, bool bIsWinner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientGotoState(IntPtr self, string newState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientIgnoreLookInput(IntPtr self, bool bIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientIgnoreMoveInput(IntPtr self, bool bIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientMessage(IntPtr self, string s, string type, float msgLifeTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientPrepareMapChange(IntPtr self, string levelName, bool bFirst, bool bLast);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientPrestreamTextures(IntPtr self, IntPtr forcedActor, float forceDuration, bool bEnableStreaming, int cinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientRepObjRef(IntPtr self, IntPtr @object);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientReset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientRestart(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientRetryClientRestart(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientReturnToMainMenu(IntPtr self, string returnReason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientReturnToMainMenuWithTextReason(IntPtr self, string returnReason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientSetBlockOnAsyncLoading(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientSetCameraMode(IntPtr self, string newCamMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientSetCinematicMode(IntPtr self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientSetSpectatorWaiting(IntPtr self, bool bWaiting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientStartOnlineSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientTeamMessage(IntPtr self, IntPtr senderPlayerState, string s, string type, float msgLifeTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientUpdateLevelStreamingStatus(IntPtr self, string packageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int lODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientVoiceHandshakeComplete(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ClientWasKicked(IntPtr self, string kickReason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_DelayedPrepareMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_DeprojectMousePositionToWorld(IntPtr self, IntPtr worldLocation, IntPtr worldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_DeprojectScreenPositionToWorld(IntPtr self, float screenX, float screenY, IntPtr worldLocation, IntPtr worldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_EnableCheats(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_EndPlayingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_FOV(IntPtr self, float newFOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetHitResultAtScreenPosition(IntPtr self, IntPtr screenPosition, byte traceChannel, IntPtr collisionQueryParams, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetHitResultAtScreenPosition_o1(IntPtr self, IntPtr screenPosition, byte traceChannel, bool bTraceComplex, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetHitResultAtScreenPosition_o2(IntPtr self, IntPtr screenPosition, byte traceChannel, bool bTraceComplex, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetHitResultUnderCursor(IntPtr self, byte traceChannel, bool bTraceComplex, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetHitResultUnderCursorByChannel(IntPtr self, byte traceChannel, bool bTraceComplex, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APlayerController_GetHUD(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_GetInputMotionState(IntPtr self, IntPtr tilt, IntPtr rotationRate, IntPtr gravity, IntPtr acceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_GetInputMouseDelta(IntPtr self, float deltaX, float deltaY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APlayerController_GetMinRespawnDelay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_GetMousePosition(IntPtr self, float locationX, float locationY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_GetViewportSize(IntPtr self, int sizeX, int sizeY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_LocalTravel(IntPtr self, string uRL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_NotifyLoadedWorld(IntPtr self, string worldPackageName, bool bFinalDest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_Pause(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_PlayerTick(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_PostProcessInput(IntPtr self, float deltaTime, bool bGamePaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_PostProcessWorldToScreen(IntPtr self, IntPtr worldLocation, IntPtr screenLocation, bool bPlayerViewportRelative);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_PostSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_PreProcessInput(IntPtr self, float deltaTime, bool bGamePaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_ProjectWorldLocationToScreen(IntPtr self, IntPtr worldLocation, IntPtr screenLocation, bool bPlayerViewportRelative);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerController_ProjectWorldLocationToScreenWithDistance(IntPtr self, IntPtr worldLocation, IntPtr screenLocation, bool bPlayerViewportRelative);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ResetControllerLightColor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_RestartLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SafeRetryClientRestart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SafeServerCheckClientPossession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SafeServerUpdateSpectatorState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SeamlessTravelFrom(IntPtr self, IntPtr oldPC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SeamlessTravelTo(IntPtr self, IntPtr newPC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SendToConsole(IntPtr self, string command);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerAcknowledgePossession(IntPtr self, IntPtr p);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerCamera(IntPtr self, string newMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerChangeName(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerCheckClientPossession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerCheckClientPossessionReliable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerNotifyLoadedWorld(IntPtr self, string worldPackageName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerPause(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerRestartPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerSetSpectatorLocation(IntPtr self, IntPtr newLoc, IntPtr newRot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerSetSpectatorWaiting(IntPtr self, bool bWaiting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerShortTimeout(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerToggleAILogging(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerUpdateLevelVisibility(IntPtr self, string packageName, bool bIsVisible);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerVerifyViewTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerViewNextPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ServerViewPrevPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SetCinematicMode(IntPtr self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SetDisableHaptics(IntPtr self, bool bNewDisabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SetMouseLocation(IntPtr self, int x, int y);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SetName(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SetVirtualJoystickVisibility(IntPtr self, bool bVisible);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_StartFire(IntPtr self, byte fireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_StartTalking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_StopTalking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_SwitchLevel(IntPtr self, string uRL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_ToggleSpeaking(IntPtr self, bool bInSpeaking);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_UnFreeze(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerController_UpdateRotation(IntPtr self, float deltaTime);
		
		#endregion
		
		#region Property
		public APawn AcknowledgedPawn
		{
			get => E_PROP_APlayerController_AcknowledgedPawn_GET(NativePointer);
			set => E_PROP_APlayerController_AcknowledgedPawn_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True to allow this player controller to manage the camera target for you,
		/// <para>typically by using the possessed pawn as the camera target. Set to false </para>
		/// if you want to manually control the camera target.
		/// </summary>
		public bool bAutoManageActiveCameraTarget
		{
			get => E_PROP_APlayerController_bAutoManageActiveCameraTarget_GET(NativePointer);
			set => E_PROP_APlayerController_bAutoManageActiveCameraTarget_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Smoothed version of TargetViewRotation to remove jerkiness from intermittent replication updates.
		/// </summary>
		public FRotator BlendedTargetViewRotation
		{
			get => E_PROP_APlayerController_BlendedTargetViewRotation_GET(NativePointer);
			set => E_PROP_APlayerController_BlendedTargetViewRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to render primitives component.
		/// </summary>
		public bool bRenderPrimitiveComponents
		{
			get => E_PROP_APlayerController_bRenderPrimitiveComponents_GET(NativePointer);
			set => E_PROP_APlayerController_bRenderPrimitiveComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Object that manages "cheat" commands.  Not instantiated in shipping builds.
		/// </summary>
		public UCheatManager CheatManager
		{
			get => E_PROP_APlayerController_CheatManager_GET(NativePointer);
			set => E_PROP_APlayerController_CheatManager_SET(NativePointer, value);
		}

		public int ClientCap
		{
			get => E_PROP_APlayerController_ClientCap_GET(NativePointer);
			set => E_PROP_APlayerController_ClientCap_SET(NativePointer, value);
		}

		public float ForceFeedbackScale
		{
			get => E_PROP_APlayerController_ForceFeedbackScale_GET(NativePointer);
			set => E_PROP_APlayerController_ForceFeedbackScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance to trace when computing click events
		/// </summary>
		public float TraceDistance
		{
			get => E_PROP_APlayerController_HitResultTraceDistance_GET(NativePointer);
			set => E_PROP_APlayerController_HitResultTraceDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Pitch input speed scaling
		/// </summary>
		public float InputPitchScale
		{
			get => E_PROP_APlayerController_InputPitchScale_GET(NativePointer);
			set => E_PROP_APlayerController_InputPitchScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Roll input speed scaling
		/// </summary>
		public float InputRollScale
		{
			get => E_PROP_APlayerController_InputRollScale_GET(NativePointer);
			set => E_PROP_APlayerController_InputRollScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Yaw input speed scaling
		/// </summary>
		public float InputYawScale
		{
			get => E_PROP_APlayerController_InputYawScale_GET(NativePointer);
			set => E_PROP_APlayerController_InputYawScale_SET(NativePointer, value);
		}

		public float LastSpectatorStateSynchTime
		{
			get => E_PROP_APlayerController_LastSpectatorStateSynchTime_GET(NativePointer);
			set => E_PROP_APlayerController_LastSpectatorStateSynchTime_SET(NativePointer, value);
		}

		public FVector LastSpectatorSyncLocation
		{
			get => E_PROP_APlayerController_LastSpectatorSyncLocation_GET(NativePointer);
			set => E_PROP_APlayerController_LastSpectatorSyncLocation_SET(NativePointer, value);
		}

		public FRotator LastSpectatorSyncRotation
		{
			get => E_PROP_APlayerController_LastSpectatorSyncRotation_GET(NativePointer);
			set => E_PROP_APlayerController_LastSpectatorSyncRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Last used FOV based multiplier to distance to an object when determining if it exceeds the object's cull distance
		/// <para>@note: only valid for local player </para>
		/// </summary>
		public float LocalPlayerCachedLODDistanceFactor
		{
			get => E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_GET(NativePointer);
			set => E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// List of muted players in various categories
		/// </summary>
		public FPlayerMuteList MuteList
		{
			get => E_PROP_APlayerController_MuteList_GET(NativePointer);
			set => E_PROP_APlayerController_MuteList_SET(NativePointer, value);
		}

		public AHUD MyHUD
		{
			get => E_PROP_APlayerController_MyHUD_GET(NativePointer);
			set => E_PROP_APlayerController_MyHUD_SET(NativePointer, value);
		}

		public byte NetPlayerIndex
		{
			get => E_PROP_APlayerController_NetPlayerIndex_GET(NativePointer);
			set => E_PROP_APlayerController_NetPlayerIndex_SET(NativePointer, value);
		}

		public UPlayer Player
		{
			get => E_PROP_APlayerController_Player_GET(NativePointer);
			set => E_PROP_APlayerController_Player_SET(NativePointer, value);
		}

		public UPlayerInput PlayerInput
		{
			get => E_PROP_APlayerController_PlayerInput_GET(NativePointer);
			set => E_PROP_APlayerController_PlayerInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Input axes values, accumulated each tick.
		/// </summary>
		public FRotator RotationInput
		{
			get => E_PROP_APlayerController_RotationInput_GET(NativePointer);
			set => E_PROP_APlayerController_RotationInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Interp speed for blending remote view rotation for smoother client updates
		/// </summary>
		public float SmoothTargetViewRotationSpeed
		{
			get => E_PROP_APlayerController_SmoothTargetViewRotationSpeed_GET(NativePointer);
			set => E_PROP_APlayerController_SmoothTargetViewRotationSpeed_SET(NativePointer, value);
		}

		public FRotator TargetViewRotation
		{
			get => E_PROP_APlayerController_TargetViewRotation_GET(NativePointer);
			set => E_PROP_APlayerController_TargetViewRotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Activates a new touch interface for this player controller
		/// </summary>
		public virtual void ActivateTouchInterface(UTouchInterface newTouchInterface)
			=> E_APlayerController_ActivateTouchInterface(this, newTouchInterface);
		
		
		/// <summary>
		/// Add Pitch (look up) input. This value is multiplied by InputPitchScale.
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by InputPitchScale.</param>
		public virtual void AddPitchInput(float val)
			=> E_APlayerController_AddPitchInput(this, val);
		
		
		/// <summary>
		/// Add Roll input. This value is multiplied by InputRollScale.
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by InputRollScale.</param>
		public virtual void AddRollInput(float val)
			=> E_APlayerController_AddRollInput(this, val);
		
		
		/// <summary>
		/// Add Yaw (turn) input. This value is multiplied by InputYawScale.
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by InputYawScale.</param>
		public virtual void AddYawInput(float val)
			=> E_APlayerController_AddYawInput(this, val);
		
		
		/// <summary>
		/// Pawn has been possessed, so changing state to NAME_Playing. Start it walking and begin playing with it.
		/// </summary>
		protected virtual void BeginPlayingState()
			=> E_APlayerController_BeginPlayingState(this);
		
		public virtual void Camera(string newMode)
			=> E_APlayerController_Camera(this, newMode);
		
		public void ClientAddTextureStreamingLoc(FVector inLoc, float duration, bool bOverrideLocation)
			=> E_APlayerController_ClientAddTextureStreamingLoc(this, inLoc, duration, bOverrideLocation);
		
		public void ClientCancelPendingMapChange()
			=> E_APlayerController_ClientCancelPendingMapChange(this);
		
		public void ClientCapBandwidth(int cap)
			=> E_APlayerController_ClientCapBandwidth(this, cap);
		
		
		/// <summary>
		/// Removes all Camera Lens Effects.
		/// </summary>
		public virtual void ClientClearCameraLensEffects()
			=> E_APlayerController_ClientClearCameraLensEffects(this);
		
		public void ClientCommitMapChange()
			=> E_APlayerController_ClientCommitMapChange(this);
		
		public virtual void ClientEnableNetworkVoice(bool bEnable)
			=> E_APlayerController_ClientEnableNetworkVoice(this, bEnable);
		
		public void ClientEndOnlineSession()
			=> E_APlayerController_ClientEndOnlineSession(this);
		
		public void ClientFlushLevelStreaming()
			=> E_APlayerController_ClientFlushLevelStreaming(this);
		
		public void ClientForceGarbageCollection()
			=> E_APlayerController_ClientForceGarbageCollection(this);
		
		public void ClientGameEnded(AActor endGameFocus, bool bIsWinner)
			=> E_APlayerController_ClientGameEnded(this, endGameFocus, bIsWinner);
		
		public void ClientGotoState(string newState)
			=> E_APlayerController_ClientGotoState(this, newState);
		
		public void ClientIgnoreLookInput(bool bIgnore)
			=> E_APlayerController_ClientIgnoreLookInput(this, bIgnore);
		
		public void ClientIgnoreMoveInput(bool bIgnore)
			=> E_APlayerController_ClientIgnoreMoveInput(this, bIgnore);
		
		public void ClientMessage(string s, string type, float msgLifeTime)
			=> E_APlayerController_ClientMessage(this, s, type, msgLifeTime);
		
		public void ClientPrepareMapChange(string levelName, bool bFirst, bool bLast)
			=> E_APlayerController_ClientPrepareMapChange(this, levelName, bFirst, bLast);
		
		public void ClientPrestreamTextures(AActor forcedActor, float forceDuration, bool bEnableStreaming, int cinematicTextureGroups = 0)
			=> E_APlayerController_ClientPrestreamTextures(this, forcedActor, forceDuration, bEnableStreaming, cinematicTextureGroups);
		
		public virtual void ClientRepObjRef(UObject @object)
			=> E_APlayerController_ClientRepObjRef(this, @object);
		
		public void ClientReset()
			=> E_APlayerController_ClientReset(this);
		
		public void ClientRestart(APawn newPawn)
			=> E_APlayerController_ClientRestart(this, newPawn);
		
		public void ClientRetryClientRestart(APawn newPawn)
			=> E_APlayerController_ClientRetryClientRestart(this, newPawn);
		
		public virtual void ClientReturnToMainMenu(string returnReason)
			=> E_APlayerController_ClientReturnToMainMenu(this, returnReason);
		
		public virtual void ClientReturnToMainMenuWithTextReason(string returnReason)
			=> E_APlayerController_ClientReturnToMainMenuWithTextReason(this, returnReason);
		
		public void ClientSetBlockOnAsyncLoading()
			=> E_APlayerController_ClientSetBlockOnAsyncLoading(this);
		
		public void ClientSetCameraMode(string newCamMode)
			=> E_APlayerController_ClientSetCameraMode(this, newCamMode);
		
		public void ClientSetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
			=> E_APlayerController_ClientSetCinematicMode(this, bInCinematicMode, bAffectsMovement, bAffectsTurning, bAffectsHUD);
		
		
		/// <summary>
		/// Indicate that the Spectator is waiting to join/respawn.
		/// </summary>
		public void ClientSetSpectatorWaiting(bool bWaiting)
			=> E_APlayerController_ClientSetSpectatorWaiting(this, bWaiting);
		
		public void ClientStartOnlineSession()
			=> E_APlayerController_ClientStartOnlineSession(this);
		
		public void ClientTeamMessage(APlayerState senderPlayerState, string s, string type, float msgLifeTime = 0)
			=> E_APlayerController_ClientTeamMessage(this, senderPlayerState, s, type, msgLifeTime);
		
		public void ClientUpdateLevelStreamingStatus(string packageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int lODIndex)
			=> E_APlayerController_ClientUpdateLevelStreamingStatus(this, packageName, bNewShouldBeLoaded, bNewShouldBeVisible, bNewShouldBlockOnLoad, lODIndex);
		
		public virtual void ClientVoiceHandshakeComplete()
			=> E_APlayerController_ClientVoiceHandshakeComplete(this);
		
		public void ClientWasKicked(string kickReason)
			=> E_APlayerController_ClientWasKicked(this, kickReason);
		
		
		/// <summary>
		/// Used to wait until a map change can be prepared when one was already in progress
		/// </summary>
		public virtual void DelayedPrepareMapChange()
			=> E_APlayerController_DelayedPrepareMapChange(this);
		
		
		/// <summary>
		/// Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value.
		/// </summary>
		public bool ConvertMouseLocationToWorldSpace(FVector worldLocation, FVector worldDirection)
			=> E_APlayerController_DeprojectMousePositionToWorld(this, worldLocation, worldDirection);
		
		
		/// <summary>
		/// Convert 2D screen position to World Space 3D position and direction. Returns false if unable to determine value.
		/// </summary>
		public bool ConvertScreenLocationToWorldSpace(float screenX, float screenY, FVector worldLocation, FVector worldDirection)
			=> E_APlayerController_DeprojectScreenPositionToWorld(this, screenX, screenY, worldLocation, worldDirection);
		
		public virtual void EnableCheats()
			=> E_APlayerController_EnableCheats(this);
		
		
		/// <summary>
		/// Leave playing state.
		/// </summary>
		protected virtual void EndPlayingState()
			=> E_APlayerController_EndPlayingState(this);
		
		public virtual void FOV(float newFOV)
			=> E_APlayerController_FOV(this, newFOV);
		
		
		/// <summary>
		/// Returns hit results from doing a collision query at a certain location on the screen
		/// </summary>
		public bool GetHitResultAtScreenPosition(FVector2D screenPosition, ECollisionChannel traceChannel, FCollisionQueryParams collisionQueryParams, FHitResult hitResult)
			=> E_APlayerController_GetHitResultAtScreenPosition(this, screenPosition, (byte)traceChannel, collisionQueryParams, hitResult);
		
		public bool GetHitResultAtScreenPosition(FVector2D screenPosition, ECollisionChannel traceChannel, bool bTraceComplex, FHitResult hitResult)
			=> E_APlayerController_GetHitResultAtScreenPosition_o1(this, screenPosition, (byte)traceChannel, bTraceComplex, hitResult);
		
		public bool GetHitResultAtScreenPosition(FVector2D screenPosition, ETraceTypeQuery traceChannel, bool bTraceComplex, FHitResult hitResult)
			=> E_APlayerController_GetHitResultAtScreenPosition_o2(this, screenPosition, (byte)traceChannel, bTraceComplex, hitResult);
		
		public bool GetHitResultUnderCursor(ECollisionChannel traceChannel, bool bTraceComplex, FHitResult hitResult)
			=> E_APlayerController_GetHitResultUnderCursor(this, (byte)traceChannel, bTraceComplex, hitResult);
		
		
		/// <summary>
		/// Performs a collision query under the mouse cursor, looking on a trace channel
		/// </summary>
		public bool GetHitResultUnderCursorByChannel(ETraceTypeQuery traceChannel, bool bTraceComplex, FHitResult hitResult)
			=> E_APlayerController_GetHitResultUnderCursorByChannel(this, (byte)traceChannel, bTraceComplex, hitResult);
		
		
		/// <summary>
		/// Gets the HUD currently being used by this player controller
		/// </summary>
		public AHUD GetHUD()
			=> E_APlayerController_GetHUD(this);
		
		
		/// <summary>
		/// Retrieves the current motion state of the player's input device
		/// </summary>
		public void GetInputMotionState(FVector tilt, FVector rotationRate, FVector gravity, FVector acceleration)
			=> E_APlayerController_GetInputMotionState(this, tilt, rotationRate, gravity, acceleration);
		
		
		/// <summary>
		/// Retrieves how far the mouse moved this frame.
		/// </summary>
		public void GetInputMouseDelta(float deltaX, float deltaY)
			=> E_APlayerController_GetInputMouseDelta(this, deltaX, deltaY);
		
		
		/// <summary>
		/// Calculate minimal respawn delay
		/// </summary>
		public virtual float GetMinRespawnDelay()
			=> E_APlayerController_GetMinRespawnDelay(this);
		
		
		/// <summary>
		/// Retrieves the X and Y screen coordinates of the mouse cursor. Returns false if there is no associated mouse device
		/// </summary>
		public bool GetMousePosition(float locationX, float locationY)
			=> E_APlayerController_GetMousePosition(this, locationX, locationY);
		
		
		/// <summary>
		/// Helper to get the size of the HUD canvas for this player controller.  Returns 0 if there is no HUD
		/// </summary>
		public void GetViewportSize(int sizeX, int sizeY)
			=> E_APlayerController_GetViewportSize(this, sizeX, sizeY);
		
		public virtual void LocalTravel(string uRL)
			=> E_APlayerController_LocalTravel(this, uRL);
		
		
		/// <summary>
		/// Called to notify the server when the client has loaded a new world via seamless traveling
		/// </summary>
		/// <param name="worldPackageName">the name of the world package that was loaded</param>
		/// <param name="bFinalDest">whether this world is the destination map for the travel (i.e. not the transition level)</param>
		public virtual void NotifyLoadedWorld(string worldPackageName, bool bFinalDest)
			=> E_APlayerController_NotifyLoadedWorld(this, worldPackageName, bFinalDest);
		
		public virtual void Pause()
			=> E_APlayerController_Pause(this);
		
		
		/// <summary>
		/// Processes player input (immediately after PlayerInput gets ticked) and calls UpdateRotation().
		/// <para>PlayerTick is only called if the PlayerController has a PlayerInput object. Therefore, it will only be called for locally controlled PlayerControllers. </para>
		/// </summary>
		public virtual void PlayerTick(float deltaTime)
			=> E_APlayerController_PlayerTick(this, deltaTime);
		
		
		/// <summary>
		/// Method called after processing input
		/// </summary>
		public virtual void PostProcessInput(float deltaTime, bool bGamePaused)
			=> E_APlayerController_PostProcessInput(this, deltaTime, bGamePaused);
		
		
		/// <summary>
		/// After successful world to screen projection, allows custom post-processing of the resulting ScreenLocation.
		/// </summary>
		/// <return>Whether</return>
		public virtual bool PostProcessWorldToScreen(FVector worldLocation, FVector2D screenLocation, bool bPlayerViewportRelative)
			=> E_APlayerController_PostProcessWorldToScreen(this, worldLocation, screenLocation, bPlayerViewportRelative);
		
		
		/// <summary>
		/// Called after this player controller has transitioned through seamless travel, but before that player is initialized
		/// <para>This is called both when a new player controller is created, and when it is maintained </para>
		/// </summary>
		public virtual void PostSeamlessTravel()
			=> E_APlayerController_PostSeamlessTravel(this);
		
		
		/// <summary>
		/// Method called prior to processing input
		/// </summary>
		public virtual void PreProcessInput(float deltaTime, bool bGamePaused)
			=> E_APlayerController_PreProcessInput(this, deltaTime, bGamePaused);
		
		
		/// <summary>
		/// Convert a World Space 3D position into a 2D Screen Space position.
		/// </summary>
		/// <return>true</return>
		public bool ConvertWorldLocationToScreenLocation(FVector worldLocation, FVector2D screenLocation, bool bPlayerViewportRelative = false)
			=> E_APlayerController_ProjectWorldLocationToScreen(this, worldLocation, screenLocation, bPlayerViewportRelative);
		
		
		/// <summary>
		/// Convert a World Space 3D position into a 3D Screen Space position.
		/// </summary>
		/// <return>true</return>
		public bool ProjectWorldLocationToScreenWithDistance(FVector worldLocation, FVector screenLocation, bool bPlayerViewportRelative = false)
			=> E_APlayerController_ProjectWorldLocationToScreenWithDistance(this, worldLocation, screenLocation, bPlayerViewportRelative);
		
		
		/// <summary>
		/// Resets the light color of the player's controller to default
		/// </summary>
		public void ResetControllerLightColor()
			=> E_APlayerController_ResetControllerLightColor(this);
		
		public virtual void RestartLevel()
			=> E_APlayerController_RestartLevel(this);
		
		
		/// <summary>
		/// Call ClientRetryClientRestart, but only if the current pawn is not the currently acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public virtual void SafeRetryClientRestart()
			=> E_APlayerController_SafeRetryClientRestart(this);
		
		
		/// <summary>
		/// Call ServerCheckClientPossession on the server, but only if the current pawn is not the acknowledged pawn (and throttled to avoid saturating the network).
		/// </summary>
		public virtual void SafeServerCheckClientPossession()
			=> E_APlayerController_SafeServerCheckClientPossession(this);
		
		
		/// <summary>
		/// Calls ServerSetSpectatorLocation but throttles it to reduce bandwidth and only calls it when necessary.
		/// </summary>
		public void SafeServerUpdateSpectatorState()
			=> E_APlayerController_SafeServerUpdateSpectatorState(this);
		
		
		/// <summary>
		/// Called when seamless traveling and the specified PC is being replaced by this one
		/// <para>copy over data that should persist </para>
		/// (not called if PlayerController is the same for the from and to GameModes)
		/// </summary>
		public virtual void SeamlessTravelFrom(APlayerController oldPC)
			=> E_APlayerController_SeamlessTravelFrom(this, oldPC);
		
		
		/// <summary>
		/// Called when seamless traveling and we are being replaced by the specified PC
		/// <para>clean up any persistent state (post process chains on LocalPlayers, for example) </para>
		/// (not called if PlayerController is the same for the from and to GameModes)
		/// </summary>
		public virtual void SeamlessTravelTo(APlayerController newPC)
			=> E_APlayerController_SeamlessTravelTo(this, newPC);
		
		public virtual void SendToConsole(string command)
			=> E_APlayerController_SendToConsole(this, command);
		
		public void ServerAcknowledgePossession(APawn p)
			=> E_APlayerController_ServerAcknowledgePossession(this, p);
		
		public void ServerCamera(string newMode)
			=> E_APlayerController_ServerCamera(this, newMode);
		
		public void ServerChangeName(string s)
			=> E_APlayerController_ServerChangeName(this, s);
		
		public void ServerCheckClientPossession()
			=> E_APlayerController_ServerCheckClientPossession(this);
		
		public void ServerCheckClientPossessionReliable()
			=> E_APlayerController_ServerCheckClientPossessionReliable(this);
		
		public void ServerNotifyLoadedWorld(string worldPackageName)
			=> E_APlayerController_ServerNotifyLoadedWorld(this, worldPackageName);
		
		public void ServerPause()
			=> E_APlayerController_ServerPause(this);
		
		public void ServerRestartPlayer()
			=> E_APlayerController_ServerRestartPlayer(this);
		
		public void ServerSetSpectatorLocation(FVector newLoc, FRotator newRot)
			=> E_APlayerController_ServerSetSpectatorLocation(this, newLoc, newRot);
		
		
		/// <summary>
		/// Indicate that the Spectator is waiting to join/respawn.
		/// </summary>
		public void ServerSetSpectatorWaiting(bool bWaiting)
			=> E_APlayerController_ServerSetSpectatorWaiting(this, bWaiting);
		
		public void ServerShortTimeout()
			=> E_APlayerController_ServerShortTimeout(this);
		
		public void ServerToggleAILogging()
			=> E_APlayerController_ServerToggleAILogging(this);
		
		public void ServerUpdateLevelVisibility(string packageName, bool bIsVisible)
			=> E_APlayerController_ServerUpdateLevelVisibility(this, packageName, bIsVisible);
		
		public void ServerVerifyViewTarget()
			=> E_APlayerController_ServerVerifyViewTarget(this);
		
		public void ServerViewNextPlayer()
			=> E_APlayerController_ServerViewNextPlayer(this);
		
		public void ServerViewPrevPlayer()
			=> E_APlayerController_ServerViewPrevPlayer(this);
		
		
		/// <summary>
		/// Adjust input based on cinematic mode
		/// </summary>
		/// <param name="bInCinematicMode">specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.</param>
		/// <param name="bAffectsMovement">specify true to disable movement in cinematic mode, enable it when leaving</param>
		/// <param name="bAffectsTurning">specify true to disable turning in cinematic mode or enable it when leaving</param>
		public virtual void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
			=> E_APlayerController_SetCinematicMode(this, bInCinematicMode, bAffectsMovement, bAffectsTurning);
		
		
		/// <summary>
		/// Allows the player controller to disable all haptic requests from being fired, e.g. in the case of a level loading
		/// </summary>
		/// <param name="bNewDisabled">If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE</param>
		public virtual void SetDisableHaptics(bool bNewDisabled)
			=> E_APlayerController_SetDisableHaptics(this, bNewDisabled);
		
		
		/// <summary>
		/// Positions the mouse cursor in screen space, in pixels.
		/// </summary>
		public void SetMousePosition(int x, int y)
			=> E_APlayerController_SetMouseLocation(this, x, y);
		
		public virtual void SetName(string s)
			=> E_APlayerController_SetName(this, s);
		
		
		/// <summary>
		/// Set the virtual joystick visibility.
		/// </summary>
		public virtual void SetVirtualJoystickVisibility(bool bVisible)
			=> E_APlayerController_SetVirtualJoystickVisibility(this, bVisible);
		
		public virtual void StartFire(byte fireModeNum)
			=> E_APlayerController_StartFire(this, fireModeNum);
		
		
		/// <summary>
		/// Enable voice chat transmission
		/// </summary>
		public void StartTalking()
			=> E_APlayerController_StartTalking(this);
		
		
		/// <summary>
		/// Disable voice chat transmission
		/// </summary>
		public void StopTalking()
			=> E_APlayerController_StopTalking(this);
		
		public virtual void SwitchLevel(string uRL)
			=> E_APlayerController_SwitchLevel(this, uRL);
		
		public virtual void ToggleSpeaking(bool bInSpeaking)
			=> E_APlayerController_ToggleSpeaking(this, bInSpeaking);
		
		
		/// <summary>
		/// Timer used by RoundEnded and Inactive states to accept player input again
		/// </summary>
		public virtual void UnFreeze()
			=> E_APlayerController_UnFreeze(this);
		
		
		/// <summary>
		/// Updates the rotation of player, based on ControlRotation after RotationInput has been applied.
		/// <para>This may then be modified by the PlayerCamera, and is passed to Pawn->FaceRotation(). </para>
		/// </summary>
		public virtual void UpdateRotation(float deltaTime)
			=> E_APlayerController_UpdateRotation(this, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(APlayerController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator APlayerController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<APlayerController>(PtrDesc);
		}}}
