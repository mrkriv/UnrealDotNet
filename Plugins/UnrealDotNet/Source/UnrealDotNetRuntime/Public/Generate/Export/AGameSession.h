#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameSession.h"
#include "Runtime/Engine/Classes/GameFramework/GameSession.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameSession_bRequiresPushToTalk_GET(AGameSession* Ptr) { return Ptr->bRequiresPushToTalk; }
	DOTNET_EXPORT void E_PROP_AGameSession_bRequiresPushToTalk_SET(AGameSession* Ptr, bool Value) { Ptr->bRequiresPushToTalk = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxPartySize_GET(AGameSession* Ptr) { return Ptr->MaxPartySize; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxPartySize_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxPartySize = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxPlayers_GET(AGameSession* Ptr) { return Ptr->MaxPlayers; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxPlayers_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxPlayers = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxSpectators_GET(AGameSession* Ptr) { return Ptr->MaxSpectators; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxSpectators_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxSpectators = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxSplitscreensPerConnection_GET(AGameSession* Ptr) { return Ptr->MaxSplitscreensPerConnection; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxSplitscreensPerConnection_SET(AGameSession* Ptr, uint8 Value) { Ptr->MaxSplitscreensPerConnection = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_SessionName_GET(AGameSession* Ptr) { return ConvertToManage_StringWrapper(Ptr->SessionName); }
	DOTNET_EXPORT void E_PROP_AGameSession_SessionName_SET(AGameSession* Ptr, char* Value) { Ptr->SessionName = ConvertFromManage_FName(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameSession(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameSession>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameSession_AddAdmin(AGameSession* Self, APlayerController* AdminPlayer)
	{
		auto _p0 = AdminPlayer;
		Self->AddAdmin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_ApproveLogin(AGameSession* Self, char* Options)
	{
		auto _p0 = ConvertFromManage_FString(Options);
		return ConvertToManage_StringWrapper(Self->ApproveLogin(_p0));
	}

	DOTNET_EXPORT auto E_AGameSession_AtCapacity(AGameSession* Self, bool bSpectator)
	{
		auto _p0 = bSpectator;
		return Self->AtCapacity(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_BanPlayer(AGameSession* Self, APlayerController* BannedPlayer, char* BanReason)
	{
		auto _p0 = BannedPlayer;
		auto _p1 = ConvertFromManage_FText(BanReason);
		return Self->BanPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameSession_CanRestartGame(AGameSession* Self)
	{
		return Self->CanRestartGame();
	}

	DOTNET_EXPORT auto E_AGameSession_DumpSessionState(AGameSession* Self)
	{
		Self->DumpSessionState();
	}

	DOTNET_EXPORT auto E_AGameSession_GetNextPlayerID(AGameSession* Self)
	{
		return Self->GetNextPlayerID();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchHasEnded(AGameSession* Self)
	{
		Self->HandleMatchHasEnded();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchHasStarted(AGameSession* Self)
	{
		Self->HandleMatchHasStarted();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchIsWaitingToStart(AGameSession* Self)
	{
		Self->HandleMatchIsWaitingToStart();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleStartMatchRequest(AGameSession* Self)
	{
		return Self->HandleStartMatchRequest();
	}

	DOTNET_EXPORT auto E_AGameSession_InitOptions(AGameSession* Self, char* Options)
	{
		auto _p0 = ConvertFromManage_FString(Options);
		Self->InitOptions(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_KickPlayer(AGameSession* Self, APlayerController* KickedPlayer, char* KickReason)
	{
		auto _p0 = KickedPlayer;
		auto _p1 = ConvertFromManage_FText(KickReason);
		return Self->KickPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameSession_NotifyLogout(AGameSession* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->NotifyLogout(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_OnAutoLoginComplete(AGameSession* Self, int32 LocalUserNum, bool bWasSuccessful, char* Error)
	{
		auto _p0 = LocalUserNum;
		auto _p1 = bWasSuccessful;
		auto _p2 = ConvertFromManage_FString(Error);
		Self->OnAutoLoginComplete(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameSession_PostLogin(AGameSession* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->PostLogin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_PostSeamlessTravel(AGameSession* Self)
	{
		Self->PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E_AGameSession_ProcessAutoLogin(AGameSession* Self)
	{
		return Self->ProcessAutoLogin();
	}

	DOTNET_EXPORT auto E_AGameSession_RegisterServer(AGameSession* Self)
	{
		Self->RegisterServer();
	}

	DOTNET_EXPORT auto E_AGameSession_RegisterServerFailed(AGameSession* Self)
	{
		Self->RegisterServerFailed();
	}

	DOTNET_EXPORT auto E_AGameSession_RemoveAdmin(AGameSession* Self, APlayerController* AdminPlayer)
	{
		auto _p0 = AdminPlayer;
		Self->RemoveAdmin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_RequiresPushToTalk(AGameSession* Self)
	{
		return Self->RequiresPushToTalk();
	}

	DOTNET_EXPORT auto E_AGameSession_Restart(AGameSession* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_AGameSession_ReturnToMainMenuHost(AGameSession* Self)
	{
		Self->ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E_AGameSession_UnregisterPlayer(AGameSession* Self, APlayerController* ExitingPlayer)
	{
		auto _p0 = ExitingPlayer;
		Self->UnregisterPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_UpdateSessionJoinability(AGameSession* Self, char* InSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly)
	{
		auto _p0 = ConvertFromManage_FName(InSessionName);
		auto _p1 = bPublicSearchable;
		auto _p2 = bAllowInvites;
		auto _p3 = bJoinViaPresence;
		auto _p4 = bJoinViaPresenceFriendsOnly;
		Self->UpdateSessionJoinability(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_DumpSessionState(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__DumpSessionState();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_HandleMatchHasEnded(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__HandleMatchHasEnded();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_HandleMatchHasStarted(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__HandleMatchHasStarted();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_HandleMatchIsWaitingToStart(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__HandleMatchIsWaitingToStart();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostSeamlessTravel(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RegisterServer(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__RegisterServer();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RegisterServerFailed(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__RegisterServerFailed();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_Restart(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__Restart();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ReturnToMainMenuHost(AGameSession* Self)
	{
		((AManageGameSession*)Self)->_Supper__ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_BeginPlay(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_Destroyed(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ForceNetRelevant(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ForceNetUpdate(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameSession*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_K2_DestroyActor(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_LifeSpanExpired(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnRep_Instigator(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnRep_Owner(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameSession*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostActorCreated(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostInitializeComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostNetInit(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PreInitializeComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameSession*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameSession*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RegisterAllComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_Reset(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_RewindForReplay(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameSession*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameSession*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameSession*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_TearOff(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameSession*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameSession*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_TornOff(AActor* Self)
	{
		((AManageGameSession*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameSession*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_BeginDestroy(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_FinishDestroy(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostCDOContruct(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostEditImport(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostInitProperties(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostLoad(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostNetReceive(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostRepNotifies(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameSession*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_PreNetReceive(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_ShutdownAfterError(UObject* Self)
	{
		((AManageGameSession*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameSession*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameSession_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameSession*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
