#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraActor.h"
#include "Runtime/Engine/Classes/Camera/CameraActor.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraActor.h:18

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ACameraActor(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ACameraActor>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ACameraActor_GetAutoActivatePlayerIndex(ACameraActor* Self)
	{
		return Self->GetAutoActivatePlayerIndex();
	}

	DOTNET_EXPORT auto E_ACameraActor_GetCameraComponent(ACameraActor* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCameraComponent());
	}

	DOTNET_EXPORT auto E_ACameraActor_NotifyCameraCut(ACameraActor* Self)
	{
		Self->NotifyCameraCut();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_NotifyCameraCut(ACameraActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__NotifyCameraCut();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_BeginPlay(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_Destroyed(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_ForceNetRelevant(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_ForceNetUpdate(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_GatherCurrentMovement(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageCameraActor*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_K2_DestroyActor(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_LifeSpanExpired(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnRep_Instigator(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnRep_Owner(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageCameraActor*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OutsideWorldBounds(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostActorCreated(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostInitializeComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostNetInit(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostNetReceiveRole(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostRegisterAllComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PreInitializeComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PreRegisterAllComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageCameraActor*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageCameraActor*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_RegisterAllComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_ReregisterAllComponents(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_RerunConstructionScripts(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_Reset(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_RewindForReplay(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageCameraActor*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageCameraActor*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageCameraActor*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_TearOff(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageCameraActor*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageCameraActor*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_TornOff(AActor* Self)
	{
		((AManageCameraActor*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageCameraActor*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_BeginDestroy(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_FinishDestroy(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostCDOContruct(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostEditImport(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostInitProperties(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostLoad(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostNetReceive(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostRepNotifies(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageCameraActor*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PreDestroyFromReplication(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_PreNetReceive(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_ShutdownAfterError(UObject* Self)
	{
		((AManageCameraActor*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageCameraActor*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ACameraActor_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageCameraActor*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
