#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameState.h"
#include "Runtime/Engine/Classes/GameFramework/GameState.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

class E_PROTECTED_WRAP_AGameState : protected AGameState
{
public:
	void HandleLeavingMap_WRAP()
	{
		HandleLeavingMap();
	}

	void HandleMatchHasEnded_WRAP()
	{
		HandleMatchHasEnded();
	}

	void HandleMatchHasStarted_WRAP()
	{
		HandleMatchHasStarted();
	}

	void HandleMatchIsWaitingToStart_WRAP()
	{
		HandleMatchIsWaitingToStart();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameState_ElapsedTime_GET(AGameState* Ptr) { return Ptr->ElapsedTime; }
	DOTNET_EXPORT void E_PROP_AGameState_ElapsedTime_SET(AGameState* Ptr, int32 Value) { Ptr->ElapsedTime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameState(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameState>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameState_DefaultTimer(AGameState* Self)
	{
		Self->DefaultTimer();
	}

	DOTNET_EXPORT auto E_AGameState_GetMatchState(AGameState* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetMatchState());
	}

	DOTNET_EXPORT auto E_AGameState_HandleLeavingMap(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleLeavingMap_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchHasEnded(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchHasEnded_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchHasStarted(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchHasStarted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchIsWaitingToStart(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchIsWaitingToStart_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HasMatchEnded(AGameState* Self)
	{
		return Self->HasMatchEnded();
	}

	DOTNET_EXPORT auto E_AGameState_IsMatchInProgress(AGameState* Self)
	{
		return Self->IsMatchInProgress();
	}

	DOTNET_EXPORT auto E_AGameState_OnRep_ElapsedTime(AGameState* Self)
	{
		Self->OnRep_ElapsedTime();
	}

	DOTNET_EXPORT auto E_AGameState_OnRep_MatchState(AGameState* Self)
	{
		Self->OnRep_MatchState();
	}

	DOTNET_EXPORT auto E_AGameState_SetMatchState(AGameState* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		Self->SetMatchState(_p0);
	}

	DOTNET_EXPORT auto E_AGameState_ShouldShowGore(AGameState* Self)
	{
		return Self->ShouldShowGore();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_DefaultTimer(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__DefaultTimer();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_HandleLeavingMap(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__HandleLeavingMap();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_HandleMatchHasEnded(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__HandleMatchHasEnded();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_HandleMatchHasStarted(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__HandleMatchHasStarted();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_HandleMatchIsWaitingToStart(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__HandleMatchIsWaitingToStart();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_ElapsedTime(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_ElapsedTime();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_MatchState(AGameState* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_MatchState();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_HandleBeginPlay(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__HandleBeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_GameModeClass(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_GameModeClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_ReplicatedHasBegunPlay(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_ReplicatedHasBegunPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_ReplicatedWorldTimeSeconds(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_ReplicatedWorldTimeSeconds();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_SpectatorClass(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_SpectatorClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ReceivedGameModeClass(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__ReceivedGameModeClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ReceivedSpectatorClass(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__ReceivedSpectatorClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_SeamlessTravelTransitionCheckpoint(AGameStateBase* Self, bool bToTransitionMap)
	{
		auto _p0 = bToTransitionMap;
		((AManageGameState*)Self)->_Supper__SeamlessTravelTransitionCheckpoint(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_UpdateServerTimeSeconds(AGameStateBase* Self)
	{
		((AManageGameState*)Self)->_Supper__UpdateServerTimeSeconds();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_BeginPlay(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_Destroyed(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ForceNetRelevant(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ForceNetUpdate(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameState*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_K2_DestroyActor(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_LifeSpanExpired(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_Instigator(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_Owner(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameState*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostActorCreated(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostInitializeComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostNetInit(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PreInitializeComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameState*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameState*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_RegisterAllComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_Reset(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_RewindForReplay(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameState*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameState*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameState*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_TearOff(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameState*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameState*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_TornOff(AActor* Self)
	{
		((AManageGameState*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameState*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_BeginDestroy(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_FinishDestroy(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostCDOContruct(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostEditImport(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostInitProperties(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostLoad(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostNetReceive(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostRepNotifies(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameState*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_PreNetReceive(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_ShutdownAfterError(UObject* Self)
	{
		((AManageGameState*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameState*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameState_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameState*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
