#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageDefaultPawn.h"
#include "Runtime/Engine/Classes/GameFramework/DefaultPawn.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_BaseLookUpRate_GET(ADefaultPawn* Ptr) { return Ptr->BaseLookUpRate; }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_BaseLookUpRate_SET(ADefaultPawn* Ptr, float Value) { Ptr->BaseLookUpRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_BaseTurnRate_GET(ADefaultPawn* Ptr) { return Ptr->BaseTurnRate; }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_BaseTurnRate_SET(ADefaultPawn* Ptr, float Value) { Ptr->BaseTurnRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_CollisionComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::CollisionComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MeshComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MeshComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MovementComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MovementComponentName); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ADefaultPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ADefaultPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetCollisionComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCollisionComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMeshComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMeshComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_LookUpAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		Self->LookUpAtRate(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveForward(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveForward(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveRight(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveRight(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveUp_World(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveUp_World(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TurnAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		Self->TurnAtRate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_LookUpAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		((AManageDefaultPawn*)Self)->_Supper__LookUpAtRate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_MoveForward(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__MoveForward(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_MoveRight(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__MoveRight(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_MoveUp_World(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__MoveUp_World(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_TurnAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		((AManageDefaultPawn*)Self)->_Supper__TurnAtRate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageDefaultPawn*)Self)->_Supper__AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__DestroyPlayerInputComponent();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_Controller(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_Controller();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_PlayerState(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PawnClientRestart(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PawnClientRestart();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((AManageDefaultPawn*)Self)->_Supper__PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_Restart(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__Restart();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_SetPlayerDefaults(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_SpawnDefaultController(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__SpawnDefaultController();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_TurnOff(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__TurnOff();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_UnPossessed(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__UnPossessed();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_UpdateNavigationRelevance(APawn* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_BeginPlay(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_Destroyed(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_ForceNetRelevant(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_ForceNetUpdate(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_GatherCurrentMovement(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageDefaultPawn*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_K2_DestroyActor(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_LifeSpanExpired(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_Instigator(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_Owner(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageDefaultPawn*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OutsideWorldBounds(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostActorCreated(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostInitializeComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostNetInit(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostNetReceiveRole(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostRegisterAllComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PreInitializeComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PreRegisterAllComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageDefaultPawn*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageDefaultPawn*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_RegisterAllComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_ReregisterAllComponents(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_RerunConstructionScripts(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_Reset(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_RewindForReplay(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageDefaultPawn*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageDefaultPawn*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageDefaultPawn*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_TearOff(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageDefaultPawn*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageDefaultPawn*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_TornOff(AActor* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageDefaultPawn*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_BeginDestroy(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_FinishDestroy(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostCDOContruct(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostEditImport(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostInitProperties(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostLoad(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostNetReceive(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostRepNotifies(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageDefaultPawn*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PreDestroyFromReplication(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_PreNetReceive(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_ShutdownAfterError(UObject* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ADefaultPawn_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageDefaultPawn*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
