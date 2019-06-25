#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageLight.h"
#include "Runtime/Engine/Classes/Engine/Light.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ALight(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ALight>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ALight_GetBrightness(ALight* Self)
	{
		return Self->GetBrightness();
	}

	DOTNET_EXPORT auto E_ALight_GetLightColor(ALight* Self)
	{
		return (INT_PTR) new FLinearColor(Self->GetLightColor());
	}

	DOTNET_EXPORT auto E_ALight_GetLightComponent(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetLightComponent());
	}

	DOTNET_EXPORT auto E_ALight_IsEnabled(ALight* Self)
	{
		return Self->IsEnabled();
	}

	DOTNET_EXPORT auto E_ALight_IsToggleable(ALight* Self)
	{
		return Self->IsToggleable();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_bEnabled(ALight* Self)
	{
		Self->OnRep_bEnabled();
	}

	DOTNET_EXPORT auto E_ALight_SetAffectTranslucentLighting(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetBrightness(ALight* Self, float NewBrightness)
	{
		auto _p0 = NewBrightness;
		Self->SetBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetCastShadows(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastShadows(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetEnabled(ALight* Self, bool bSetEnabled)
	{
		auto _p0 = bSetEnabled;
		Self->SetEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightColor(ALight* Self, INT_PTR NewLightColor)
	{
		auto _p0 = *(FLinearColor*)NewLightColor;
		Self->SetLightColor(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionFadeDistance(ALight* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionScale(ALight* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ToggleEnabled(ALight* Self)
	{
		Self->ToggleEnabled();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_bEnabled(ALight* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_bEnabled();
	}

	DOTNET_EXPORT auto E__Supper__ALight_BeginPlay(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ALight_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ALight_Destroyed(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ALight_ForceNetRelevant(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ALight_ForceNetUpdate(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ALight_GatherCurrentMovement(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ALight_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageLight*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_K2_DestroyActor(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ALight_LifeSpanExpired(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ALight_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ALight_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ALight_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_Instigator(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_Owner(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageLight*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_OutsideWorldBounds(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostActorCreated(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostInitializeComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostNetInit(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostNetReceiveRole(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostRegisterAllComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PreInitializeComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PreRegisterAllComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageLight*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ALight_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageLight*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_RegisterAllComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_ReregisterAllComponents(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ALight_RerunConstructionScripts(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ALight_Reset(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ALight_RewindForReplay(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ALight_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageLight*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageLight*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageLight*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_TearOff(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ALight_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageLight*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageLight*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_TornOff(AActor* Self)
	{
		((AManageLight*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ALight_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageLight*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_BeginDestroy(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ALight_FinishDestroy(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ALight_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostCDOContruct(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostEditImport(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostInitProperties(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostLoad(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostNetReceive(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostRepNotifies(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageLight*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ALight_PreDestroyFromReplication(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ALight_PreNetReceive(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ALight_ShutdownAfterError(UObject* Self)
	{
		((AManageLight*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ALight_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageLight*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ALight_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageLight*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
