#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
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
	
	DOTNET_EXPORT auto E_PROP_APlayerController_ActiveForceFeedbackEffects_GET(APlayerController* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActiveForceFeedbackEffects); }
	DOTNET_EXPORT void E_PROP_APlayerController_ActiveForceFeedbackEffects_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->ActiveForceFeedbackEffects = *(TArray<FActiveForceFeedbackEffect>*)Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_APlayerController_ForceFeedbackEffectHistoryEntries_GET(APlayerController* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ForceFeedbackEffectHistoryEntries); }
	DOTNET_EXPORT void E_PROP_APlayerController_ForceFeedbackEffectHistoryEntries_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->ForceFeedbackEffectHistoryEntries = *(TArray<FForceFeedbackEffectHistoryEntry>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_ForceFeedbackScale_GET(APlayerController* Ptr) { return Ptr->ForceFeedbackScale; }
	DOTNET_EXPORT void E_PROP_APlayerController_ForceFeedbackScale_SET(APlayerController* Ptr, float Value) { Ptr->ForceFeedbackScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_HiddenActors_GET(APlayerController* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->HiddenActors); }
	DOTNET_EXPORT void E_PROP_APlayerController_HiddenActors_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->HiddenActors = *(TArray<AActor*>*)Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_APlayerController_PendingMapChangeLevelNames_GET(APlayerController* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->PendingMapChangeLevelNames); }
	DOTNET_EXPORT void E_PROP_APlayerController_PendingMapChangeLevelNames_SET(APlayerController* Ptr, INT_PTR Value) { Ptr->PendingMapChangeLevelNames = *(TArray<FName>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerController_Player_GET(APlayerController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Player); }
	DOTNET_EXPORT void E_PROP_APlayerController_Player_SET(APlayerController* Ptr, UPlayer* Value) { Ptr->Player = Value; }
	
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

	DOTNET_EXPORT auto E_APlayerController_ClientUpdateMultipleLevelsStreamingStatus(APlayerController* Self, INT_PTR LevelStatuses)
	{
		auto& _p0 = *(const TArray<FUpdateLevelStreamingLevelStatus>*)LevelStatuses;
		Self->ClientUpdateMultipleLevelsStreamingStatus(_p0);
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

	DOTNET_EXPORT auto E_APlayerController_GetHitResultAtScreenPosition(APlayerController* Self, INT_PTR ScreenPosition, ECollisionChannel TraceChannel, bool bTraceComplex, INT_PTR HitResult)
	{
		auto _p0 = *(FVector2D*)ScreenPosition;
		auto _p1 = TraceChannel;
		auto _p2 = bTraceComplex;
		auto& _p3 = *(FHitResult*)HitResult;
		return Self->GetHitResultAtScreenPosition(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APlayerController_GetHitResultAtScreenPosition_o1(APlayerController* Self, INT_PTR ScreenPosition, ETraceTypeQuery TraceChannel, bool bTraceComplex, INT_PTR HitResult)
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

	DOTNET_EXPORT auto E_APlayerController_GetSeamlessTravelActorList(APlayerController* Self, bool bToEntry, INT_PTR ActorList)
	{
		auto _p0 = bToEntry;
		auto& _p1 = *(TArray<AActor*>*)ActorList;
		Self->GetSeamlessTravelActorList(_p0, _p1);
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

	DOTNET_EXPORT auto E_APlayerController_ServerUpdateLevelVisibility(APlayerController* Self, char* PackageName, bool bIsVisible)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		auto _p1 = bIsVisible;
		Self->ServerUpdateLevelVisibility(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerController_ServerUpdateMultipleLevelsVisibility(APlayerController* Self, INT_PTR LevelVisibilities)
	{
		auto& _p0 = *(const TArray<FUpdateLevelVisibilityLevelInfo>*)LevelVisibilities;
		Self->ServerUpdateMultipleLevelsVisibility(_p0);
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
