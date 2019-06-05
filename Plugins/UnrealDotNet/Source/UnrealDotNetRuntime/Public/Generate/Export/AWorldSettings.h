#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageWorldSettings.h"
#include "Runtime/Engine/Classes/GameFramework/WorldSettings.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bEnableAISystem_GET(AWorldSettings* Ptr) { return Ptr->bEnableAISystem; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bEnableAISystem_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bEnableAISystem = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bEnableWorldBoundsChecks_GET(AWorldSettings* Ptr) { return Ptr->bEnableWorldBoundsChecks; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bEnableWorldBoundsChecks_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bEnableWorldBoundsChecks = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bEnableWorldComposition_GET(AWorldSettings* Ptr) { return Ptr->bEnableWorldComposition; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bEnableWorldComposition_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bEnableWorldComposition = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bEnableWorldOriginRebasing_GET(AWorldSettings* Ptr) { return Ptr->bEnableWorldOriginRebasing; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bEnableWorldOriginRebasing_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bEnableWorldOriginRebasing = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bForceNoPrecomputedLighting_GET(AWorldSettings* Ptr) { return Ptr->bForceNoPrecomputedLighting; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bForceNoPrecomputedLighting_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bForceNoPrecomputedLighting = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bGlobalGravitySet_GET(AWorldSettings* Ptr) { return Ptr->bGlobalGravitySet; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bGlobalGravitySet_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bGlobalGravitySet = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bHighPriorityLoading_GET(AWorldSettings* Ptr) { return Ptr->bHighPriorityLoading; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bHighPriorityLoading_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bHighPriorityLoading = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bHighPriorityLoadingLocal_GET(AWorldSettings* Ptr) { return Ptr->bHighPriorityLoadingLocal; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bHighPriorityLoadingLocal_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bHighPriorityLoadingLocal = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bMinimizeBSPSections_GET(AWorldSettings* Ptr) { return Ptr->bMinimizeBSPSections; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bMinimizeBSPSections_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bMinimizeBSPSections = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_GET(AWorldSettings* Ptr) { return Ptr->bOverrideDefaultBroadphaseSettings; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bOverrideDefaultBroadphaseSettings = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bPlaceCellsOnlyAlongCameraTracks_GET(AWorldSettings* Ptr) { return Ptr->bPlaceCellsOnlyAlongCameraTracks; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bPlaceCellsOnlyAlongCameraTracks_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bPlaceCellsOnlyAlongCameraTracks = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bPrecomputeVisibility_GET(AWorldSettings* Ptr) { return Ptr->bPrecomputeVisibility; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bPrecomputeVisibility_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bPrecomputeVisibility = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_BroadphaseSettings_GET(AWorldSettings* Ptr) { return (INT_PTR)&(Ptr->BroadphaseSettings); }
	DOTNET_EXPORT void E_PROP_AWorldSettings_BroadphaseSettings_SET(AWorldSettings* Ptr, INT_PTR Value) { Ptr->BroadphaseSettings = *(FBroadphaseSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_GET(AWorldSettings* Ptr) { return Ptr->bUseClientSideLevelStreamingVolumes; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bUseClientSideLevelStreamingVolumes = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_bWorldGravitySet_GET(AWorldSettings* Ptr) { return Ptr->bWorldGravitySet; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_bWorldGravitySet_SET(AWorldSettings* Ptr, uint8 Value) { Ptr->bWorldGravitySet = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_DefaultColorScale_GET(AWorldSettings* Ptr) { return (INT_PTR)&(Ptr->DefaultColorScale); }
	DOTNET_EXPORT void E_PROP_AWorldSettings_DefaultColorScale_SET(AWorldSettings* Ptr, INT_PTR Value) { Ptr->DefaultColorScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_GET(AWorldSettings* Ptr) { return Ptr->DefaultMaxDistanceFieldOcclusionDistance; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_SET(AWorldSettings* Ptr, float Value) { Ptr->DefaultMaxDistanceFieldOcclusionDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_DemoPlayTimeDilation_GET(AWorldSettings* Ptr) { return Ptr->DemoPlayTimeDilation; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_DemoPlayTimeDilation_SET(AWorldSettings* Ptr, float Value) { Ptr->DemoPlayTimeDilation = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_GET(AWorldSettings* Ptr) { return Ptr->DynamicIndirectShadowsSelfShadowingIntensity; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_SET(AWorldSettings* Ptr, float Value) { Ptr->DynamicIndirectShadowsSelfShadowingIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_GET(AWorldSettings* Ptr) { return Ptr->GlobalDistanceFieldViewDistance; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_SET(AWorldSettings* Ptr, float Value) { Ptr->GlobalDistanceFieldViewDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_GlobalGravityZ_GET(AWorldSettings* Ptr) { return Ptr->GlobalGravityZ; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_GlobalGravityZ_SET(AWorldSettings* Ptr, float Value) { Ptr->GlobalGravityZ = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_KillZ_GET(AWorldSettings* Ptr) { return Ptr->KillZ; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_KillZ_SET(AWorldSettings* Ptr, float Value) { Ptr->KillZ = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MatineeTimeDilation_GET(AWorldSettings* Ptr) { return Ptr->MatineeTimeDilation; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MatineeTimeDilation_SET(AWorldSettings* Ptr, float Value) { Ptr->MatineeTimeDilation = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MaxGlobalTimeDilation_GET(AWorldSettings* Ptr) { return Ptr->MaxGlobalTimeDilation; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MaxGlobalTimeDilation_SET(AWorldSettings* Ptr, float Value) { Ptr->MaxGlobalTimeDilation = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MaxUndilatedFrameTime_GET(AWorldSettings* Ptr) { return Ptr->MaxUndilatedFrameTime; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MaxUndilatedFrameTime_SET(AWorldSettings* Ptr, float Value) { Ptr->MaxUndilatedFrameTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MinGlobalTimeDilation_GET(AWorldSettings* Ptr) { return Ptr->MinGlobalTimeDilation; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MinGlobalTimeDilation_SET(AWorldSettings* Ptr, float Value) { Ptr->MinGlobalTimeDilation = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MinUndilatedFrameTime_GET(AWorldSettings* Ptr) { return Ptr->MinUndilatedFrameTime; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MinUndilatedFrameTime_SET(AWorldSettings* Ptr, float Value) { Ptr->MinUndilatedFrameTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_MonoCullingDistance_GET(AWorldSettings* Ptr) { return Ptr->MonoCullingDistance; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_MonoCullingDistance_SET(AWorldSettings* Ptr, float Value) { Ptr->MonoCullingDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_GET(AWorldSettings* Ptr) { return Ptr->PackedLightAndShadowMapTextureSize; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_SET(AWorldSettings* Ptr, int32 Value) { Ptr->PackedLightAndShadowMapTextureSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_Pauser_GET(AWorldSettings* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Pauser); }
	DOTNET_EXPORT void E_PROP_AWorldSettings_Pauser_SET(AWorldSettings* Ptr, APlayerState* Value) { Ptr->Pauser = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_TimeDilation_GET(AWorldSettings* Ptr) { return Ptr->TimeDilation; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_TimeDilation_SET(AWorldSettings* Ptr, float Value) { Ptr->TimeDilation = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_VisibilityCellSize_GET(AWorldSettings* Ptr) { return Ptr->VisibilityCellSize; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_VisibilityCellSize_SET(AWorldSettings* Ptr, int32 Value) { Ptr->VisibilityCellSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_WorldGravityZ_GET(AWorldSettings* Ptr) { return Ptr->WorldGravityZ; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_WorldGravityZ_SET(AWorldSettings* Ptr, float Value) { Ptr->WorldGravityZ = Value; }
	
	DOTNET_EXPORT auto E_PROP_AWorldSettings_WorldToMeters_GET(AWorldSettings* Ptr) { return Ptr->WorldToMeters; }
	DOTNET_EXPORT void E_PROP_AWorldSettings_WorldToMeters_SET(AWorldSettings* Ptr, float Value) { Ptr->WorldToMeters = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AWorldSettings(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AWorldSettings>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AWorldSettings_ClearAllBookmarks(AWorldSettings* Self)
	{
		Self->ClearAllBookmarks();
	}

	DOTNET_EXPORT auto E_AWorldSettings_CompactBookmarks(AWorldSettings* Self)
	{
		Self->CompactBookmarks();
	}

	DOTNET_EXPORT auto E_AWorldSettings_FixupDeltaSeconds(AWorldSettings* Self, float DeltaSeconds, float RealDeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = RealDeltaSeconds;
		return Self->FixupDeltaSeconds(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AWorldSettings_GetEffectiveTimeDilation(AWorldSettings* Self)
	{
		return Self->GetEffectiveTimeDilation();
	}

	DOTNET_EXPORT auto E_AWorldSettings_GetGravityZ(AWorldSettings* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_AWorldSettings_GetMaxNumberOfBookmarks(AWorldSettings* Self)
	{
		return Self->GetMaxNumberOfBookmarks();
	}

	DOTNET_EXPORT auto E_AWorldSettings_IsNavigationSystemEnabled(AWorldSettings* Self)
	{
		return Self->IsNavigationSystemEnabled();
	}

	DOTNET_EXPORT auto E_AWorldSettings_NotifyBeginPlay(AWorldSettings* Self)
	{
		Self->NotifyBeginPlay();
	}

	DOTNET_EXPORT auto E_AWorldSettings_NotifyMatchStarted(AWorldSettings* Self)
	{
		Self->NotifyMatchStarted();
	}

	DOTNET_EXPORT auto E_AWorldSettings_OnRep_WorldGravityZ(AWorldSettings* Self)
	{
		Self->OnRep_WorldGravityZ();
	}

	DOTNET_EXPORT auto E_AWorldSettings_SetTimeDilation(AWorldSettings* Self, float NewTimeDilation)
	{
		auto _p0 = NewTimeDilation;
		return Self->SetTimeDilation(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_NotifyBeginPlay(AWorldSettings* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__NotifyBeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_NotifyMatchStarted(AWorldSettings* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__NotifyMatchStarted();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_WorldGravityZ(AWorldSettings* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_WorldGravityZ();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_BeginPlay(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_Destroyed(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_ForceNetRelevant(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_ForceNetUpdate(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_GatherCurrentMovement(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageWorldSettings*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_K2_DestroyActor(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_LifeSpanExpired(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_Instigator(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_Owner(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageWorldSettings*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OutsideWorldBounds(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostActorCreated(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostInitializeComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostNetInit(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostNetReceiveRole(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostRegisterAllComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PreInitializeComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PreRegisterAllComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageWorldSettings*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageWorldSettings*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_RegisterAllComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_ReregisterAllComponents(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_RerunConstructionScripts(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_Reset(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_RewindForReplay(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageWorldSettings*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageWorldSettings*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageWorldSettings*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_TearOff(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageWorldSettings*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageWorldSettings*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_TornOff(AActor* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageWorldSettings*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_BeginDestroy(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_FinishDestroy(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostCDOContruct(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostEditImport(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostInitProperties(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostLoad(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostNetReceive(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostRepNotifies(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageWorldSettings*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PreDestroyFromReplication(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_PreNetReceive(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_ShutdownAfterError(UObject* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AWorldSettings_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageWorldSettings*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
