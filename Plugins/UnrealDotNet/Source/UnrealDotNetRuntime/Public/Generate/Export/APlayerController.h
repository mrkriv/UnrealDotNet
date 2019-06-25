#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePlayerController.h"
#include "Runtime/Engine/Classes/GameFramework/PlayerController.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:237

class E_PROTECTED_WRAP_APlayerController : protected APlayerController
{
public:
	void BeginPlayingState_WRAP()
	{
		BeginPlayingState();
	}

	void EndPlayingState_WRAP()
	{
		EndPlayingState();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_APlayerController_AcknowledgedPawn_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AcknowledgedPawn); }
	DOTNET_EXPORT void E_PROP_APlayerController_AcknowledgedPawn_SET(APlayerController* Ptr, APawn* Value) { Ptr->AcknowledgedPawn = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_bAutoManageActiveCameraTarget_GET(APlayerController* Ptr) { return Ptr->bAutoManageActiveCameraTarget; }
	DOTNET_EXPORT void E_PROP_APlayerController_bAutoManageActiveCameraTarget_SET(APlayerController* Ptr, bool Value) { Ptr->bAutoManageActiveCameraTarget = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_BlendedTargetViewRotation_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->BlendedTargetViewRotation); }
	DOTNET_EXPORT void E_PROP_APlayerController_BlendedTargetViewRotation_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->BlendedTargetViewRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_bRenderPrimitiveComponents_GET(APlayerController* Ptr) { return Ptr->bRenderPrimitiveComponents; }
	DOTNET_EXPORT void E_PROP_APlayerController_bRenderPrimitiveComponents_SET(APlayerController* Ptr, bool Value) { Ptr->bRenderPrimitiveComponents = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_CheatManager_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->CheatManager); }
	DOTNET_EXPORT void E_PROP_APlayerController_CheatManager_SET(APlayerController* Ptr, UCheatManager* Value) { Ptr->CheatManager = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_ClientCap_GET(APlayerController* Ptr) { return Ptr->ClientCap; }
	DOTNET_EXPORT void E_PROP_APlayerController_ClientCap_SET(APlayerController* Ptr, int32 Value) { Ptr->ClientCap = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_ForceFeedbackScale_GET(APlayerController* Ptr) { return Ptr->ForceFeedbackScale; }
	DOTNET_EXPORT void E_PROP_APlayerController_ForceFeedbackScale_SET(APlayerController* Ptr, float Value) { Ptr->ForceFeedbackScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_HitResultTraceDistance_GET(APlayerController* Ptr) { return Ptr->HitResultTraceDistance; }
	DOTNET_EXPORT void E_PROP_APlayerController_HitResultTraceDistance_SET(APlayerController* Ptr, float Value) { Ptr->HitResultTraceDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_InputPitchScale_GET(APlayerController* Ptr) { return Ptr->InputPitchScale; }
	DOTNET_EXPORT void E_PROP_APlayerController_InputPitchScale_SET(APlayerController* Ptr, float Value) { Ptr->InputPitchScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_InputRollScale_GET(APlayerController* Ptr) { return Ptr->InputRollScale; }
	DOTNET_EXPORT void E_PROP_APlayerController_InputRollScale_SET(APlayerController* Ptr, float Value) { Ptr->InputRollScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_InputYawScale_GET(APlayerController* Ptr) { return Ptr->InputYawScale; }
	DOTNET_EXPORT void E_PROP_APlayerController_InputYawScale_SET(APlayerController* Ptr, float Value) { Ptr->InputYawScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_LastSpectatorStateSynchTime_GET(APlayerController* Ptr) { return Ptr->LastSpectatorStateSynchTime; }
	DOTNET_EXPORT void E_PROP_APlayerController_LastSpectatorStateSynchTime_SET(APlayerController* Ptr, float Value) { Ptr->LastSpectatorStateSynchTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_LastSpectatorSyncLocation_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->LastSpectatorSyncLocation); }
	DOTNET_EXPORT void E_PROP_APlayerController_LastSpectatorSyncLocation_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->LastSpectatorSyncLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_LastSpectatorSyncRotation_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->LastSpectatorSyncRotation); }
	DOTNET_EXPORT void E_PROP_APlayerController_LastSpectatorSyncRotation_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->LastSpectatorSyncRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_GET(APlayerController* Ptr) { return Ptr->LocalPlayerCachedLODDistanceFactor; }
	DOTNET_EXPORT void E_PROP_APlayerController_LocalPlayerCachedLODDistanceFactor_SET(APlayerController* Ptr, float Value) { Ptr->LocalPlayerCachedLODDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_MuteList_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->MuteList); }
	DOTNET_EXPORT void E_PROP_APlayerController_MuteList_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->MuteList = *(FPlayerMuteList*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_MyHUD_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->MyHUD); }
	DOTNET_EXPORT void E_PROP_APlayerController_MyHUD_SET(APlayerController* Ptr, AHUD* Value) { Ptr->MyHUD = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_NetPlayerIndex_GET(APlayerController* Ptr) { return Ptr->NetPlayerIndex; }
	DOTNET_EXPORT void E_PROP_APlayerController_NetPlayerIndex_SET(APlayerController* Ptr, uint8 Value) { Ptr->NetPlayerIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_Player_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Player); }
	DOTNET_EXPORT void E_PROP_APlayerController_Player_SET(APlayerController* Ptr, UPlayer* Value) { Ptr->Player = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_PlayerCameraManager_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PlayerCameraManager); }
	DOTNET_EXPORT void E_PROP_APlayerController_PlayerCameraManager_SET(APlayerController* Ptr, APlayerCameraManager* Value) { Ptr->PlayerCameraManager = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_PlayerInput_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PlayerInput); }
	DOTNET_EXPORT void E_PROP_APlayerController_PlayerInput_SET(APlayerController* Ptr, UPlayerInput* Value) { Ptr->PlayerInput = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_RotationInput_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->RotationInput); }
	DOTNET_EXPORT void E_PROP_APlayerController_RotationInput_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->RotationInput = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_SmoothTargetViewRotationSpeed_GET(APlayerController* Ptr) { return Ptr->SmoothTargetViewRotationSpeed; }
	DOTNET_EXPORT void E_PROP_APlayerController_SmoothTargetViewRotationSpeed_SET(APlayerController* Ptr, float Value) { Ptr->SmoothTargetViewRotationSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_TargetViewRotation_GET(APlayerController* Ptr) { return (INT_PTR)&(Ptr->TargetViewRotation); }
	DOTNET_EXPORT void E_PROP_APlayerController_TargetViewRotation_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->TargetViewRotation = *(FRotator*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APlayerController(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APlayerController>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_APlayerController_ActivateTouchInterface(APlayerController* Self, UTouchInterface* NewTouchInterface)
	{
		auto _p0 = NewTouchInterface;
		Self->ActivateTouchInterface(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_AddPitchInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_AddRollInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddRollInput(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_AddYawInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddYawInput(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_BeginPlayingState(APlayerController* Self)
	{
		((E_PROTECTED_WRAP_APlayerController*)Self)->BeginPlayingState_WRAP();
	}

	DOTNET_EXPORT auto E_APlayerController_Camera(APlayerController* Self, char* NewMode)
	{
		auto _p0 = ConvertFromManage_FName(NewMode);
		Self->Camera(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientAddTextureStreamingLoc(APlayerController* Self, INT_PTR InLoc, float Duration, bool bOverrideLocation)
	{
		auto _p0 = *(FVector*)InLoc;
		auto _p1 = Duration;
		auto _p2 = bOverrideLocation;
		Self->ClientAddTextureStreamingLoc(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientCancelPendingMapChange(APlayerController* Self)
	{
		Self->ClientCancelPendingMapChange();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientCapBandwidth(APlayerController* Self, int32 Cap)
	{
		auto _p0 = Cap;
		Self->ClientCapBandwidth(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientClearCameraLensEffects(APlayerController* Self)
	{
		Self->ClientClearCameraLensEffects();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientCommitMapChange(APlayerController* Self)
	{
		Self->ClientCommitMapChange();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientEnableNetworkVoice(APlayerController* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->ClientEnableNetworkVoice(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientEndOnlineSession(APlayerController* Self)
	{
		Self->ClientEndOnlineSession();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientFlushLevelStreaming(APlayerController* Self)
	{
		Self->ClientFlushLevelStreaming();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientForceGarbageCollection(APlayerController* Self)
	{
		Self->ClientForceGarbageCollection();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientGameEnded(APlayerController* Self, AActor* EndGameFocus, bool bIsWinner)
	{
		auto _p0 = EndGameFocus;
		auto _p1 = bIsWinner;
		Self->ClientGameEnded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientGotoState(APlayerController* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		Self->ClientGotoState(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientIgnoreLookInput(APlayerController* Self, bool bIgnore)
	{
		auto _p0 = bIgnore;
		Self->ClientIgnoreLookInput(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientIgnoreMoveInput(APlayerController* Self, bool bIgnore)
	{
		auto _p0 = bIgnore;
		Self->ClientIgnoreMoveInput(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientMessage(APlayerController* Self, char* S, char* Type, float MsgLifeTime)
	{
		auto _p0 = ConvertFromManage_FString(S);
		auto _p1 = ConvertFromManage_FName(Type);
		auto _p2 = MsgLifeTime;
		Self->ClientMessage(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientPrepareMapChange(APlayerController* Self, char* LevelName, bool bFirst, bool bLast)
	{
		auto _p0 = ConvertFromManage_FName(LevelName);
		auto _p1 = bFirst;
		auto _p2 = bLast;
		Self->ClientPrepareMapChange(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientPrestreamTextures(APlayerController* Self, AActor* ForcedActor, float ForceDuration, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = ForcedActor;
		auto _p1 = ForceDuration;
		auto _p2 = bEnableStreaming;
		auto _p3 = CinematicTextureGroups;
		Self->ClientPrestreamTextures(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientRepObjRef(APlayerController* Self, UObject* Object)
	{
		auto _p0 = Object;
		Self->ClientRepObjRef(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientReset(APlayerController* Self)
	{
		Self->ClientReset();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientRestart(APlayerController* Self, APawn* NewPawn)
	{
		auto _p0 = NewPawn;
		Self->ClientRestart(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientRetryClientRestart(APlayerController* Self, APawn* NewPawn)
	{
		auto _p0 = NewPawn;
		Self->ClientRetryClientRestart(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientReturnToMainMenu(APlayerController* Self, char* ReturnReason)
	{
		auto _p0 = ConvertFromManage_FString(ReturnReason);
		Self->ClientReturnToMainMenu(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientReturnToMainMenuWithTextReason(APlayerController* Self, char* ReturnReason)
	{
		auto _p0 = ConvertFromManage_FText(ReturnReason);
		Self->ClientReturnToMainMenuWithTextReason(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientSetBlockOnAsyncLoading(APlayerController* Self)
	{
		Self->ClientSetBlockOnAsyncLoading();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientSetCameraMode(APlayerController* Self, char* NewCamMode)
	{
		auto _p0 = ConvertFromManage_FName(NewCamMode);
		Self->ClientSetCameraMode(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientSetCinematicMode(APlayerController* Self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
	{
		auto _p0 = bInCinematicMode;
		auto _p1 = bAffectsMovement;
		auto _p2 = bAffectsTurning;
		auto _p3 = bAffectsHUD;
		Self->ClientSetCinematicMode(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientSetSpectatorWaiting(APlayerController* Self, bool bWaiting)
	{
		auto _p0 = bWaiting;
		Self->ClientSetSpectatorWaiting(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientSetViewTarget(APlayerController* Self, AActor* A, INT_PTR TransitionParams)
	{
		auto _p0 = A;
		auto _p1 = *(FViewTargetTransitionParams*)TransitionParams;
		Self->ClientSetViewTarget(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientStartOnlineSession(APlayerController* Self)
	{
		Self->ClientStartOnlineSession();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientTeamMessage(APlayerController* Self, APlayerState* SenderPlayerState, char* S, char* Type, float MsgLifeTime)
	{
		auto _p0 = SenderPlayerState;
		auto _p1 = ConvertFromManage_FString(S);
		auto _p2 = ConvertFromManage_FName(Type);
		auto _p3 = MsgLifeTime;
		Self->ClientTeamMessage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientUpdateLevelStreamingStatus(APlayerController* Self, char* PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int32 LODIndex)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		auto _p1 = bNewShouldBeLoaded;
		auto _p2 = bNewShouldBeVisible;
		auto _p3 = bNewShouldBlockOnLoad;
		auto _p4 = LODIndex;
		Self->ClientUpdateLevelStreamingStatus(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_APlayerController_ClientVoiceHandshakeComplete(APlayerController* Self)
	{
		Self->ClientVoiceHandshakeComplete();
	}

	DOTNET_EXPORT auto E_APlayerController_ClientWasKicked(APlayerController* Self, char* KickReason)
	{
		auto _p0 = ConvertFromManage_FText(KickReason);
		Self->ClientWasKicked(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_DelayedPrepareMapChange(APlayerController* Self)
	{
		Self->DelayedPrepareMapChange();
	}

	DOTNET_EXPORT auto E_APlayerController_DeprojectMousePositionToWorld(APlayerController* Self, INT_PTR WorldLocation, INT_PTR WorldDirection)
	{
		auto& _p0 = *(FVector*)WorldLocation;
		auto& _p1 = *(FVector*)WorldDirection;
		return Self->DeprojectMousePositionToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_DeprojectScreenPositionToWorld(APlayerController* Self, float ScreenX, float ScreenY, INT_PTR WorldLocation, INT_PTR WorldDirection)
	{
		auto _p0 = ScreenX;
		auto _p1 = ScreenY;
		auto& _p2 = *(FVector*)WorldLocation;
		auto& _p3 = *(FVector*)WorldDirection;
		return Self->DeprojectScreenPositionToWorld(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_EnableCheats(APlayerController* Self)
	{
		Self->EnableCheats();
	}

	DOTNET_EXPORT auto E_APlayerController_EndPlayingState(APlayerController* Self)
	{
		((E_PROTECTED_WRAP_APlayerController*)Self)->EndPlayingState_WRAP();
	}

	DOTNET_EXPORT auto E_APlayerController_FOV(APlayerController* Self, float NewFOV)
	{
		auto _p0 = NewFOV;
		Self->FOV(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultAtScreenPosition(APlayerController* Self, INT_PTR ScreenPosition, ECollisionChannel TraceChannel, INT_PTR CollisionQueryParams, INT_PTR HitResult)
	{
		auto _p0 = *(FVector2D*)ScreenPosition;
		auto _p1 = TraceChannel;
		auto& _p2 = *(FCollisionQueryParams*)CollisionQueryParams;
		auto& _p3 = *(FHitResult*)HitResult;
		return Self->GetHitResultAtScreenPosition(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultAtScreenPosition_o1(APlayerController* Self, INT_PTR ScreenPosition, ECollisionChannel TraceChannel, bool bTraceComplex, INT_PTR HitResult)
	{
		auto _p0 = *(FVector2D*)ScreenPosition;
		auto _p1 = TraceChannel;
		auto _p2 = bTraceComplex;
		auto& _p3 = *(FHitResult*)HitResult;
		return Self->GetHitResultAtScreenPosition(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultAtScreenPosition_o2(APlayerController* Self, INT_PTR ScreenPosition, ETraceTypeQuery TraceChannel, bool bTraceComplex, INT_PTR HitResult)
	{
		auto _p0 = *(FVector2D*)ScreenPosition;
		auto _p1 = TraceChannel;
		auto _p2 = bTraceComplex;
		auto& _p3 = *(FHitResult*)HitResult;
		return Self->GetHitResultAtScreenPosition(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultUnderCursor(APlayerController* Self, ECollisionChannel TraceChannel, bool bTraceComplex, INT_PTR HitResult)
	{
		auto _p0 = TraceChannel;
		auto _p1 = bTraceComplex;
		auto& _p2 = *(FHitResult*)HitResult;
		return Self->GetHitResultUnderCursor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultUnderCursorByChannel(APlayerController* Self, ETraceTypeQuery TraceChannel, bool bTraceComplex, INT_PTR HitResult)
	{
		auto _p0 = TraceChannel;
		auto _p1 = bTraceComplex;
		auto& _p2 = *(FHitResult*)HitResult;
		return Self->GetHitResultUnderCursorByChannel(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHUD(APlayerController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetHUD());
	}

	DOTNET_EXPORT auto E_APlayerController_GetInputMotionState(APlayerController* Self, INT_PTR Tilt, INT_PTR RotationRate, INT_PTR Gravity, INT_PTR Acceleration)
	{
		auto& _p0 = *(FVector*)Tilt;
		auto& _p1 = *(FVector*)RotationRate;
		auto& _p2 = *(FVector*)Gravity;
		auto& _p3 = *(FVector*)Acceleration;
		Self->GetInputMotionState(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_GetInputMouseDelta(APlayerController* Self, float DeltaX, float DeltaY)
	{
		auto& _p0 = DeltaX;
		auto& _p1 = DeltaY;
		Self->GetInputMouseDelta(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_GetMinRespawnDelay(APlayerController* Self)
	{
		return Self->GetMinRespawnDelay();
	}

	DOTNET_EXPORT auto E_APlayerController_GetMousePosition(APlayerController* Self, float LocationX, float LocationY)
	{
		auto& _p0 = LocationX;
		auto& _p1 = LocationY;
		return Self->GetMousePosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_GetViewportSize(APlayerController* Self, int32 SizeX, int32 SizeY)
	{
		auto& _p0 = SizeX;
		auto& _p1 = SizeY;
		Self->GetViewportSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_LocalTravel(APlayerController* Self, char* URL)
	{
		auto _p0 = ConvertFromManage_FString(URL);
		Self->LocalTravel(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_NotifyLoadedWorld(APlayerController* Self, char* WorldPackageName, bool bFinalDest)
	{
		auto _p0 = ConvertFromManage_FName(WorldPackageName);
		auto _p1 = bFinalDest;
		Self->NotifyLoadedWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_Pause(APlayerController* Self)
	{
		Self->Pause();
	}

	DOTNET_EXPORT auto E_APlayerController_PlayerTick(APlayerController* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->PlayerTick(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_PostProcessInput(APlayerController* Self, float DeltaTime, bool bGamePaused)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bGamePaused;
		Self->PostProcessInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_PostProcessWorldToScreen(APlayerController* Self, INT_PTR WorldLocation, INT_PTR ScreenLocation, bool bPlayerViewportRelative)
	{
		auto _p0 = *(FVector*)WorldLocation;
		auto& _p1 = *(FVector2D*)ScreenLocation;
		auto _p2 = bPlayerViewportRelative;
		return Self->PostProcessWorldToScreen(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_PostSeamlessTravel(APlayerController* Self)
	{
		Self->PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E_APlayerController_PreProcessInput(APlayerController* Self, float DeltaTime, bool bGamePaused)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bGamePaused;
		Self->PreProcessInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ProjectWorldLocationToScreen(APlayerController* Self, INT_PTR WorldLocation, INT_PTR ScreenLocation, bool bPlayerViewportRelative)
	{
		auto _p0 = *(FVector*)WorldLocation;
		auto& _p1 = *(FVector2D*)ScreenLocation;
		auto _p2 = bPlayerViewportRelative;
		return Self->ProjectWorldLocationToScreen(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_ProjectWorldLocationToScreenWithDistance(APlayerController* Self, INT_PTR WorldLocation, INT_PTR ScreenLocation, bool bPlayerViewportRelative)
	{
		auto _p0 = *(FVector*)WorldLocation;
		auto& _p1 = *(FVector*)ScreenLocation;
		auto _p2 = bPlayerViewportRelative;
		return Self->ProjectWorldLocationToScreenWithDistance(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_ResetControllerLightColor(APlayerController* Self)
	{
		Self->ResetControllerLightColor();
	}

	DOTNET_EXPORT auto E_APlayerController_RestartLevel(APlayerController* Self)
	{
		Self->RestartLevel();
	}

	DOTNET_EXPORT auto E_APlayerController_SafeRetryClientRestart(APlayerController* Self)
	{
		Self->SafeRetryClientRestart();
	}

	DOTNET_EXPORT auto E_APlayerController_SafeServerCheckClientPossession(APlayerController* Self)
	{
		Self->SafeServerCheckClientPossession();
	}

	DOTNET_EXPORT auto E_APlayerController_SafeServerUpdateSpectatorState(APlayerController* Self)
	{
		Self->SafeServerUpdateSpectatorState();
	}

	DOTNET_EXPORT auto E_APlayerController_SeamlessTravelFrom(APlayerController* Self, APlayerController* OldPC)
	{
		auto _p0 = OldPC;
		Self->SeamlessTravelFrom(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_SeamlessTravelTo(APlayerController* Self, APlayerController* NewPC)
	{
		auto _p0 = NewPC;
		Self->SeamlessTravelTo(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_SendToConsole(APlayerController* Self, char* Command)
	{
		auto _p0 = ConvertFromManage_FString(Command);
		Self->SendToConsole(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerAcknowledgePossession(APlayerController* Self, APawn* P)
	{
		auto _p0 = P;
		Self->ServerAcknowledgePossession(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerCamera(APlayerController* Self, char* NewMode)
	{
		auto _p0 = ConvertFromManage_FName(NewMode);
		Self->ServerCamera(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerChangeName(APlayerController* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->ServerChangeName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerCheckClientPossession(APlayerController* Self)
	{
		Self->ServerCheckClientPossession();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerCheckClientPossessionReliable(APlayerController* Self)
	{
		Self->ServerCheckClientPossessionReliable();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerNotifyLoadedWorld(APlayerController* Self, char* WorldPackageName)
	{
		auto _p0 = ConvertFromManage_FName(WorldPackageName);
		Self->ServerNotifyLoadedWorld(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerPause(APlayerController* Self)
	{
		Self->ServerPause();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerRestartPlayer(APlayerController* Self)
	{
		Self->ServerRestartPlayer();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerSetSpectatorLocation(APlayerController* Self, INT_PTR NewLoc, INT_PTR NewRot)
	{
		auto _p0 = *(FVector*)NewLoc;
		auto _p1 = *(FRotator*)NewRot;
		Self->ServerSetSpectatorLocation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerSetSpectatorWaiting(APlayerController* Self, bool bWaiting)
	{
		auto _p0 = bWaiting;
		Self->ServerSetSpectatorWaiting(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerShortTimeout(APlayerController* Self)
	{
		Self->ServerShortTimeout();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerToggleAILogging(APlayerController* Self)
	{
		Self->ServerToggleAILogging();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerUpdateCamera(APlayerController* Self, INT_PTR CamLoc, int32 CamPitchAndYaw)
	{
		auto _p0 = *(FVector_NetQuantize*)CamLoc;
		auto _p1 = CamPitchAndYaw;
		Self->ServerUpdateCamera(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerUpdateLevelVisibility(APlayerController* Self, char* PackageName, bool bIsVisible)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		auto _p1 = bIsVisible;
		Self->ServerUpdateLevelVisibility(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerVerifyViewTarget(APlayerController* Self)
	{
		Self->ServerVerifyViewTarget();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerViewNextPlayer(APlayerController* Self)
	{
		Self->ServerViewNextPlayer();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerViewPrevPlayer(APlayerController* Self)
	{
		Self->ServerViewPrevPlayer();
	}

	DOTNET_EXPORT auto E_APlayerController_ServerViewSelf(APlayerController* Self, INT_PTR TransitionParams)
	{
		auto _p0 = *(FViewTargetTransitionParams*)TransitionParams;
		Self->ServerViewSelf(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_SetCinematicMode(APlayerController* Self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
	{
		auto _p0 = bInCinematicMode;
		auto _p1 = bAffectsMovement;
		auto _p2 = bAffectsTurning;
		Self->SetCinematicMode(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APlayerController_SetDisableHaptics(APlayerController* Self, bool bNewDisabled)
	{
		auto _p0 = bNewDisabled;
		Self->SetDisableHaptics(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_SetMouseLocation(APlayerController* Self, int X, int Y)
	{
		auto _p0 = X;
		auto _p1 = Y;
		Self->SetMouseLocation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_SetName(APlayerController* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->SetName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_SetViewTargetWithBlend(APlayerController* Self, AActor* NewViewTarget, float BlendTime, EViewTargetBlendFunction BlendFunc, float BlendExp, bool bLockOutgoing)
	{
		auto _p0 = NewViewTarget;
		auto _p1 = BlendTime;
		auto _p2 = BlendFunc;
		auto _p3 = BlendExp;
		auto _p4 = bLockOutgoing;
		Self->SetViewTargetWithBlend(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_APlayerController_SetVirtualJoystickVisibility(APlayerController* Self, bool bVisible)
	{
		auto _p0 = bVisible;
		Self->SetVirtualJoystickVisibility(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_StartFire(APlayerController* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->StartFire(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_StartTalking(APlayerController* Self)
	{
		Self->StartTalking();
	}

	DOTNET_EXPORT auto E_APlayerController_StopTalking(APlayerController* Self)
	{
		Self->StopTalking();
	}

	DOTNET_EXPORT auto E_APlayerController_SwitchLevel(APlayerController* Self, char* URL)
	{
		auto _p0 = ConvertFromManage_FString(URL);
		Self->SwitchLevel(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_ToggleSpeaking(APlayerController* Self, bool bInSpeaking)
	{
		auto _p0 = bInSpeaking;
		Self->ToggleSpeaking(_p0);
	}

	DOTNET_EXPORT auto E_APlayerController_UnFreeze(APlayerController* Self)
	{
		Self->UnFreeze();
	}

	DOTNET_EXPORT auto E_APlayerController_UpdateRotation(APlayerController* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->UpdateRotation(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_AddPitchInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePlayerController*)Self)->_Supper__AddPitchInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_AddRollInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePlayerController*)Self)->_Supper__AddRollInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_AddYawInput(APlayerController* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePlayerController*)Self)->_Supper__AddYawInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_BeginPlayingState(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__BeginPlayingState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ClientClearCameraLensEffects(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ClientClearCameraLensEffects();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ClientEnableNetworkVoice(APlayerController* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((AManagePlayerController*)Self)->_Supper__ClientEnableNetworkVoice(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ClientVoiceHandshakeComplete(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ClientVoiceHandshakeComplete();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_DelayedPrepareMapChange(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__DelayedPrepareMapChange();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_EnableCheats(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__EnableCheats();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_EndPlayingState(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__EndPlayingState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_FOV(APlayerController* Self, float NewFOV)
	{
		auto _p0 = NewFOV;
		((AManagePlayerController*)Self)->_Supper__FOV(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_Pause(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__Pause();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PlayerTick(APlayerController* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((AManagePlayerController*)Self)->_Supper__PlayerTick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostProcessInput(APlayerController* Self, float DeltaTime, bool bGamePaused)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bGamePaused;
		((AManagePlayerController*)Self)->_Supper__PostProcessInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostSeamlessTravel(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PreProcessInput(APlayerController* Self, float DeltaTime, bool bGamePaused)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bGamePaused;
		((AManagePlayerController*)Self)->_Supper__PreProcessInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_RestartLevel(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__RestartLevel();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SafeRetryClientRestart(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__SafeRetryClientRestart();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SafeServerCheckClientPossession(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__SafeServerCheckClientPossession();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetCinematicMode(APlayerController* Self, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
	{
		auto _p0 = bInCinematicMode;
		auto _p1 = bAffectsMovement;
		auto _p2 = bAffectsTurning;
		((AManagePlayerController*)Self)->_Supper__SetCinematicMode(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetDisableHaptics(APlayerController* Self, bool bNewDisabled)
	{
		auto _p0 = bNewDisabled;
		((AManagePlayerController*)Self)->_Supper__SetDisableHaptics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetVirtualJoystickVisibility(APlayerController* Self, bool bVisible)
	{
		auto _p0 = bVisible;
		((AManagePlayerController*)Self)->_Supper__SetVirtualJoystickVisibility(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_StartFire(APlayerController* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((AManagePlayerController*)Self)->_Supper__StartFire(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ToggleSpeaking(APlayerController* Self, bool bInSpeaking)
	{
		auto _p0 = bInSpeaking;
		((AManagePlayerController*)Self)->_Supper__ToggleSpeaking(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_UnFreeze(APlayerController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__UnFreeze();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_UpdateRotation(APlayerController* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((AManagePlayerController*)Self)->_Supper__UpdateRotation(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_BeginInactiveState(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__BeginInactiveState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_CleanupPlayerState(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__CleanupPlayerState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_CurrentLevelUnloaded(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__CurrentLevelUnloaded();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_DetachFromPawn(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__DetachFromPawn();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_EndInactiveState(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__EndInactiveState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_FailedToSpawnPawn(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__FailedToSpawnPawn();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_InitPlayerState(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__InitPlayerState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_Pawn(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_Pawn();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_PlayerState(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnUnPossess(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnUnPossess();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ResetIgnoreInputFlags(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ResetIgnoreInputFlags();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ResetIgnoreLookInput(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ResetIgnoreLookInput();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ResetIgnoreMoveInput(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ResetIgnoreMoveInput();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetIgnoreLookInput(AController* Self, bool bNewLookInput)
	{
		auto _p0 = bNewLookInput;
		((AManagePlayerController*)Self)->_Supper__SetIgnoreLookInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetIgnoreMoveInput(AController* Self, bool bNewMoveInput)
	{
		auto _p0 = bNewMoveInput;
		((AManagePlayerController*)Self)->_Supper__SetIgnoreMoveInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_StopMovement(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__StopMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_UpdateNavigationComponents(AController* Self)
	{
		((AManagePlayerController*)Self)->_Supper__UpdateNavigationComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_BeginPlay(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ClearCrossLevelReferences(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_Destroyed(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ForceNetRelevant(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ForceNetUpdate(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_GatherCurrentMovement(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManagePlayerController*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_K2_DestroyActor(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_LifeSpanExpired(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_Instigator(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_Owner(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManagePlayerController*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OutsideWorldBounds(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostActorCreated(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostInitializeComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostNetInit(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostNetReceivePhysicState(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostNetReceiveRole(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostUnregisterAllComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PreInitializeComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PreRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManagePlayerController*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManagePlayerController*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_RegisterAllComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ReregisterAllComponents(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_RerunConstructionScripts(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_Reset(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_RewindForReplay(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManagePlayerController*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManagePlayerController*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManagePlayerController*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_TearOff(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManagePlayerController*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManagePlayerController*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_TornOff(AActor* Self)
	{
		((AManagePlayerController*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManagePlayerController*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_BeginDestroy(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_FinishDestroy(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostCDOContruct(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostEditImport(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostInitProperties(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostLoad(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostNetReceive(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostRepNotifies(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManagePlayerController*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PreDestroyFromReplication(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_PreNetReceive(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_ShutdownAfterError(UObject* Self)
	{
		((AManagePlayerController*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManagePlayerController*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__APlayerController_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManagePlayerController*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
