#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSpectatorPawn.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ASpectatorPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ASpectatorPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_LookUpAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		((AManageSpectatorPawn*)Self)->_Supper__LookUpAtRate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_MoveForward(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__MoveForward(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_MoveRight(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__MoveRight(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_MoveUp_World(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__MoveUp_World(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_TurnAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		((AManageSpectatorPawn*)Self)->_Supper__TurnAtRate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageSpectatorPawn*)Self)->_Supper__AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__DestroyPlayerInputComponent();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_Controller(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_Controller();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_PlayerState(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PawnClientRestart(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PawnClientRestart();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((AManageSpectatorPawn*)Self)->_Supper__PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_Restart(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__Restart();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_SetPlayerDefaults(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_SpawnDefaultController(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__SpawnDefaultController();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_TurnOff(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__TurnOff();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_UnPossessed(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__UnPossessed();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_UpdateNavigationRelevance(APawn* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_BeginPlay(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_Destroyed(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_ForceNetRelevant(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_ForceNetUpdate(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_GatherCurrentMovement(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageSpectatorPawn*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_K2_DestroyActor(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_LifeSpanExpired(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_Instigator(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_Owner(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageSpectatorPawn*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OutsideWorldBounds(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostActorCreated(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostInitializeComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostNetInit(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostNetReceiveRole(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostRegisterAllComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PreInitializeComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PreRegisterAllComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageSpectatorPawn*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageSpectatorPawn*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_RegisterAllComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_ReregisterAllComponents(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_RerunConstructionScripts(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_Reset(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_RewindForReplay(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageSpectatorPawn*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageSpectatorPawn*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageSpectatorPawn*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_TearOff(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageSpectatorPawn*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageSpectatorPawn*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_TornOff(AActor* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageSpectatorPawn*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_BeginDestroy(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_FinishDestroy(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostCDOContruct(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostEditImport(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostInitProperties(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostLoad(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostNetReceive(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostRepNotifies(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageSpectatorPawn*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PreDestroyFromReplication(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_PreNetReceive(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_ShutdownAfterError(UObject* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ASpectatorPawn_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageSpectatorPawn*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
