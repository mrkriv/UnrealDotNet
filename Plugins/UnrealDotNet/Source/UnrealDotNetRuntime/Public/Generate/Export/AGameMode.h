#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameMode.h"
#include "Runtime/Engine/Classes/GameFramework/GameMode.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

class E_PROTECTED_WRAP_AGameMode : protected AGameMode
{
public:
	void HandleLeavingMap_WRAP()
	{
		HandleLeavingMap();
	}

	void HandleMatchAborted_WRAP()
	{
		HandleMatchAborted();
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

	void K2_OnSetMatchState_WRAP(FName NewState)
	{
		K2_OnSetMatchState(NewState);
	}

	void OnMatchStateSet_WRAP()
	{
		OnMatchStateSet();
	}

	bool ReadyToEndMatch_WRAP()
	{
		return ReadyToEndMatch();
	}

	bool ReadyToStartMatch_WRAP()
	{
		return ReadyToStartMatch();
	}

	void SetMatchState_WRAP(FName NewState)
	{
		SetMatchState(NewState);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameMode_MinRespawnDelay_GET(AGameMode* Ptr) { return Ptr->MinRespawnDelay; }
	DOTNET_EXPORT void E_PROP_AGameMode_MinRespawnDelay_SET(AGameMode* Ptr, float Value) { Ptr->MinRespawnDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumBots_GET(AGameMode* Ptr) { return Ptr->NumBots; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumBots_SET(AGameMode* Ptr, int32 Value) { Ptr->NumBots = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumPlayers_GET(AGameMode* Ptr) { return Ptr->NumPlayers; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumPlayers_SET(AGameMode* Ptr, int32 Value) { Ptr->NumPlayers = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumSpectators_GET(AGameMode* Ptr) { return Ptr->NumSpectators; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumSpectators_SET(AGameMode* Ptr, int32 Value) { Ptr->NumSpectators = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumTravellingPlayers_GET(AGameMode* Ptr) { return Ptr->NumTravellingPlayers; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumTravellingPlayers_SET(AGameMode* Ptr, int32 Value) { Ptr->NumTravellingPlayers = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameMode(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameMode>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameMode_AbortMatch(AGameMode* Self)
	{
		Self->AbortMatch();
	}

	DOTNET_EXPORT auto E_AGameMode_AddInactivePlayer(AGameMode* Self, APlayerState* PlayerState, APlayerController* PC)
	{
		auto _p0 = PlayerState;
		auto _p1 = PC;
		Self->AddInactivePlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_Broadcast(AGameMode* Self, AActor* Sender, char* Msg, char* Type)
	{
		auto _p0 = Sender;
		auto _p1 = ConvertFromManage_FString(Msg);
		auto _p2 = ConvertFromManage_FName(Type);
		Self->Broadcast(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameMode_EndMatch(AGameMode* Self)
	{
		Self->EndMatch();
	}

	DOTNET_EXPORT auto E_AGameMode_FindInactivePlayer(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		return Self->FindInactivePlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_GetDefaultGameClassPath(AGameMode* Self, char* MapName, char* Options, char* Portal)
	{
		auto _p0 = ConvertFromManage_FString(MapName);
		auto _p1 = ConvertFromManage_FString(Options);
		auto _p2 = ConvertFromManage_FString(Portal);
		return ConvertToManage_StringWrapper(Self->GetDefaultGameClassPath(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_AGameMode_GetMatchState(AGameMode* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetMatchState());
	}

	DOTNET_EXPORT auto E_AGameMode_GetNetworkNumber(AGameMode* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetNetworkNumber());
	}

	DOTNET_EXPORT auto E_AGameMode_GetTravelType(AGameMode* Self)
	{
		return Self->GetTravelType();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleLeavingMap(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleLeavingMap_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchAborted(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchAborted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchHasEnded(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchHasEnded_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchHasStarted(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchHasStarted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchIsWaitingToStart(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchIsWaitingToStart_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HasMatchEnded(AGameMode* Self)
	{
		return Self->HasMatchEnded();
	}

	DOTNET_EXPORT auto E_AGameMode_IsMatchInProgress(AGameMode* Self)
	{
		return Self->IsMatchInProgress();
	}

	DOTNET_EXPORT auto E_AGameMode_K2_OnSetMatchState(AGameMode* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		((E_PROTECTED_WRAP_AGameMode*)Self)->K2_OnSetMatchState_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_MatineeCancelled(AGameMode* Self)
	{
		Self->MatineeCancelled();
	}

	DOTNET_EXPORT auto E_AGameMode_OnMatchStateSet(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->OnMatchStateSet_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_OverridePlayerState(AGameMode* Self, APlayerController* PC, APlayerState* OldPlayerState)
	{
		auto _p0 = PC;
		auto _p1 = OldPlayerState;
		Self->OverridePlayerState(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_PlayerSwitchedToSpectatorOnly(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->PlayerSwitchedToSpectatorOnly(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_PostCommitMapChange(AGameMode* Self)
	{
		Self->PostCommitMapChange();
	}

	DOTNET_EXPORT auto E_AGameMode_PreCommitMapChange(AGameMode* Self, char* PreviousMapName, char* NextMapName)
	{
		auto _p0 = ConvertFromManage_FString(PreviousMapName);
		auto _p1 = ConvertFromManage_FString(NextMapName);
		Self->PreCommitMapChange(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_ReadyToEndMatch(AGameMode* Self)
	{
		return ((E_PROTECTED_WRAP_AGameMode*)Self)->ReadyToEndMatch_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_ReadyToStartMatch(AGameMode* Self)
	{
		return ((E_PROTECTED_WRAP_AGameMode*)Self)->ReadyToStartMatch_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_RemovePlayerControllerFromPlayerCount(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->RemovePlayerControllerFromPlayerCount(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_RestartGame(AGameMode* Self)
	{
		Self->RestartGame();
	}

	DOTNET_EXPORT auto E_AGameMode_Say(AGameMode* Self, char* Msg)
	{
		auto _p0 = ConvertFromManage_FString(Msg);
		Self->Say(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SendPlayer(AGameMode* Self, APlayerController* aPlayer, char* URL)
	{
		auto _p0 = aPlayer;
		auto _p1 = ConvertFromManage_FString(URL);
		Self->SendPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_SetBandwidthLimit(AGameMode* Self, float AsyncIOBandwidthLimit)
	{
		auto _p0 = AsyncIOBandwidthLimit;
		Self->SetBandwidthLimit(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SetMatchState(AGameMode* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		((E_PROTECTED_WRAP_AGameMode*)Self)->SetMatchState_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SetSeamlessTravelViewTarget(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->SetSeamlessTravelViewTarget(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_StartMatch(AGameMode* Self)
	{
		Self->StartMatch();
	}

	DOTNET_EXPORT auto E_AGameMode_StartNewPlayer(AGameMode* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->StartNewPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_StaticGetFullGameClassName(AGameMode* Self, char* Str)
	{
		auto _p0 = ConvertFromManage_FString(Str);
		return ConvertToManage_StringWrapper(Self->StaticGetFullGameClassName(_p0));
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_AbortMatch(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__AbortMatch();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_EndMatch(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__EndMatch();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_HandleLeavingMap(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__HandleLeavingMap();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_HandleMatchAborted(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__HandleMatchAborted();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_HandleMatchHasEnded(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__HandleMatchHasEnded();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_HandleMatchHasStarted(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__HandleMatchHasStarted();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_HandleMatchIsWaitingToStart(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__HandleMatchIsWaitingToStart();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_MatineeCancelled(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__MatineeCancelled();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnMatchStateSet(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnMatchStateSet();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostCommitMapChange(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostCommitMapChange();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_RestartGame(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__RestartGame();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_SetBandwidthLimit(AGameMode* Self, float AsyncIOBandwidthLimit)
	{
		auto _p0 = AsyncIOBandwidthLimit;
		((AManageGameMode*)Self)->_Supper__SetBandwidthLimit(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_StartMatch(AGameMode* Self)
	{
		((AManageGameMode*)Self)->_Supper__StartMatch();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_InitGameState(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__InitGameState();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostSeamlessTravel(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ResetLevel(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__ResetLevel();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ReturnToMainMenuHost(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_StartPlay(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__StartPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_StartToLeaveMap(AGameModeBase* Self)
	{
		((AManageGameMode*)Self)->_Supper__StartToLeaveMap();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_BeginPlay(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_Destroyed(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ForceNetRelevant(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ForceNetUpdate(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameMode*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_K2_DestroyActor(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_LifeSpanExpired(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnRep_Instigator(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnRep_Owner(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameMode*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostActorCreated(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostInitializeComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostNetInit(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PreInitializeComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameMode*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameMode*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_RegisterAllComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_Reset(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_RewindForReplay(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameMode*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameMode*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameMode*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_TearOff(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameMode*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameMode*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_TornOff(AActor* Self)
	{
		((AManageGameMode*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameMode*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_BeginDestroy(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_FinishDestroy(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostCDOContruct(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostEditImport(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostInitProperties(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostLoad(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostNetReceive(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostRepNotifies(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameMode*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_PreNetReceive(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_ShutdownAfterError(UObject* Self)
	{
		((AManageGameMode*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameMode*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameMode_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameMode*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
