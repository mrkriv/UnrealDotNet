#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameStateBase.h"
#include "Runtime/Engine/Classes/GameFramework/GameStateBase.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

class E_PROTECTED_WRAP_AGameStateBase : protected AGameStateBase
{
public:
	void OnRep_GameModeClass_WRAP()
	{
		OnRep_GameModeClass();
	}

	void OnRep_ReplicatedHasBegunPlay_WRAP()
	{
		OnRep_ReplicatedHasBegunPlay();
	}

	void OnRep_ReplicatedWorldTimeSeconds_WRAP()
	{
		OnRep_ReplicatedWorldTimeSeconds();
	}

	void OnRep_SpectatorClass_WRAP()
	{
		OnRep_SpectatorClass();
	}

	void UpdateServerTimeSeconds_WRAP()
	{
		UpdateServerTimeSeconds();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameStateBase_AuthorityGameMode_GET(AGameStateBase* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AuthorityGameMode); }
	DOTNET_EXPORT void E_PROP_AGameStateBase_AuthorityGameMode_SET(AGameStateBase* Ptr, AGameModeBase* Value) { Ptr->AuthorityGameMode = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameStateBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameStateBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameStateBase_AddPlayerState(AGameStateBase* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->AddPlayerState(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_AsyncPackageLoaded(AGameStateBase* Self, UObject* Package)
	{
		auto _p0 = Package;
		Self->AsyncPackageLoaded(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetDefaultGameMode(AGameStateBase* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultGameMode());
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetPlayerRespawnDelay(AGameStateBase* Self, AController* Controller)
	{
		auto _p0 = Controller;
		return Self->GetPlayerRespawnDelay(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetPlayerStartTime(AGameStateBase* Self, AController* Controller)
	{
		auto _p0 = Controller;
		return Self->GetPlayerStartTime(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetServerWorldTimeSeconds(AGameStateBase* Self)
	{
		return Self->GetServerWorldTimeSeconds();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HandleBeginPlay(AGameStateBase* Self)
	{
		Self->HandleBeginPlay();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HasBegunPlay(AGameStateBase* Self)
	{
		return Self->HasBegunPlay();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HasMatchStarted(AGameStateBase* Self)
	{
		return Self->HasMatchStarted();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_GameModeClass(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_GameModeClass_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_ReplicatedHasBegunPlay(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_ReplicatedHasBegunPlay_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_ReplicatedWorldTimeSeconds(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_ReplicatedWorldTimeSeconds_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_SpectatorClass(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_SpectatorClass_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_ReceivedGameModeClass(AGameStateBase* Self)
	{
		Self->ReceivedGameModeClass();
	}

	DOTNET_EXPORT auto E_AGameStateBase_ReceivedSpectatorClass(AGameStateBase* Self)
	{
		Self->ReceivedSpectatorClass();
	}

	DOTNET_EXPORT auto E_AGameStateBase_RemovePlayerState(AGameStateBase* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->RemovePlayerState(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_SeamlessTravelTransitionCheckpoint(AGameStateBase* Self, bool bToTransitionMap)
	{
		auto _p0 = bToTransitionMap;
		Self->SeamlessTravelTransitionCheckpoint(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_UpdateServerTimeSeconds(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->UpdateServerTimeSeconds_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_HandleBeginPlay(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__HandleBeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_GameModeClass(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_GameModeClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_ReplicatedHasBegunPlay(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_ReplicatedHasBegunPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_ReplicatedWorldTimeSeconds(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_ReplicatedWorldTimeSeconds();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_SpectatorClass(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_SpectatorClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ReceivedGameModeClass(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ReceivedGameModeClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ReceivedSpectatorClass(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ReceivedSpectatorClass();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_SeamlessTravelTransitionCheckpoint(AGameStateBase* Self, bool bToTransitionMap)
	{
		auto _p0 = bToTransitionMap;
		((AManageGameStateBase*)Self)->_Supper__SeamlessTravelTransitionCheckpoint(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_UpdateServerTimeSeconds(AGameStateBase* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__UpdateServerTimeSeconds();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_BeginPlay(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_Destroyed(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ForceNetRelevant(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ForceNetUpdate(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameStateBase*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_K2_DestroyActor(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_LifeSpanExpired(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_Instigator(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_Owner(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameStateBase*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostActorCreated(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostInitializeComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostNetInit(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PreInitializeComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameStateBase*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameStateBase*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_RegisterAllComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_Reset(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_RewindForReplay(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameStateBase*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameStateBase*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameStateBase*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_TearOff(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameStateBase*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameStateBase*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_TornOff(AActor* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameStateBase*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_BeginDestroy(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_FinishDestroy(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostCDOContruct(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostEditImport(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostInitProperties(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostLoad(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostNetReceive(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostRepNotifies(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameStateBase*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_PreNetReceive(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_ShutdownAfterError(UObject* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameStateBase_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameStateBase*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
