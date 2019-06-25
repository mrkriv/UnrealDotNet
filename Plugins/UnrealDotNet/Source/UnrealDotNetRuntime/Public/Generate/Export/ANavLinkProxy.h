#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageNavLinkProxy.h"
#include "Runtime/AIModule/Classes/Navigation/NavLinkProxy.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\NavLinkProxy.h:24

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_GET(ANavLinkProxy* Ptr) { return Ptr->bSmartLinkIsRelevant; }
	DOTNET_EXPORT void E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_SET(ANavLinkProxy* Ptr, bool Value) { Ptr->bSmartLinkIsRelevant = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ANavLinkProxy(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ANavLinkProxy>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ANavLinkProxy_HasMovingAgents(ANavLinkProxy* Self)
	{
		return Self->HasMovingAgents();
	}

	DOTNET_EXPORT auto E_ANavLinkProxy_IsSmartLinkEnabled(ANavLinkProxy* Self)
	{
		return Self->IsSmartLinkEnabled();
	}

	DOTNET_EXPORT auto E_ANavLinkProxy_ReceiveSmartLinkReached(ANavLinkProxy* Self, AActor* Agent, INT_PTR Destination)
	{
		auto _p0 = Agent;
		auto& _p1 = *(FVector*)Destination;
		Self->ReceiveSmartLinkReached(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ANavLinkProxy_ResumePathFollowing(ANavLinkProxy* Self, AActor* Agent)
	{
		auto _p0 = Agent;
		Self->ResumePathFollowing(_p0);
	}

	DOTNET_EXPORT auto E_ANavLinkProxy_SetSmartLinkEnabled(ANavLinkProxy* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetSmartLinkEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_BeginPlay(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_Destroyed(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_ForceNetRelevant(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_ForceNetUpdate(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_GatherCurrentMovement(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageNavLinkProxy*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_K2_DestroyActor(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_LifeSpanExpired(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnRep_Instigator(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnRep_Owner(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageNavLinkProxy*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OutsideWorldBounds(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostActorCreated(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostInitializeComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostNetInit(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostNetReceiveRole(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostRegisterAllComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PreInitializeComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PreRegisterAllComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageNavLinkProxy*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageNavLinkProxy*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_RegisterAllComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_ReregisterAllComponents(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_RerunConstructionScripts(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_Reset(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_RewindForReplay(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageNavLinkProxy*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageNavLinkProxy*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageNavLinkProxy*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_TearOff(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageNavLinkProxy*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageNavLinkProxy*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_TornOff(AActor* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageNavLinkProxy*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_BeginDestroy(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_FinishDestroy(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostCDOContruct(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostEditImport(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostInitProperties(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostLoad(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostNetReceive(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostRepNotifies(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageNavLinkProxy*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PreDestroyFromReplication(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_PreNetReceive(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_ShutdownAfterError(UObject* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ANavLinkProxy_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageNavLinkProxy*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
