#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameNetworkManager.h"
#include "Runtime/Engine/Classes/GameFramework/GameNetworkManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameNetworkManager.h:27

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_AdjustedNetSpeed_GET(AGameNetworkManager* Ptr) { return Ptr->AdjustedNetSpeed; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_AdjustedNetSpeed_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->AdjustedNetSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_BadPingThreshold_GET(AGameNetworkManager* Ptr) { return Ptr->BadPingThreshold; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_BadPingThreshold_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->BadPingThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_GET(AGameNetworkManager* Ptr) { return Ptr->bMovementTimeDiscrepancyDetection; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_SET(AGameNetworkManager* Ptr, bool Value) { Ptr->bMovementTimeDiscrepancyDetection = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_GET(AGameNetworkManager* Ptr) { return Ptr->bMovementTimeDiscrepancyForceCorrectionsDuringResolution; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_SET(AGameNetworkManager* Ptr, bool Value) { Ptr->bMovementTimeDiscrepancyForceCorrectionsDuringResolution = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_GET(AGameNetworkManager* Ptr) { return Ptr->bMovementTimeDiscrepancyResolution; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_SET(AGameNetworkManager* Ptr, bool Value) { Ptr->bMovementTimeDiscrepancyResolution = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_GET(AGameNetworkManager* Ptr) { return Ptr->bUseDistanceBasedRelevancy; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_SET(AGameNetworkManager* Ptr, bool Value) { Ptr->bUseDistanceBasedRelevancy = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_GET(AGameNetworkManager* Ptr) { return Ptr->CLIENTADJUSTUPDATECOST; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_SET(AGameNetworkManager* Ptr, float Value) { Ptr->CLIENTADJUSTUPDATECOST = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientAuthorativePosition_GET(AGameNetworkManager* Ptr) { return Ptr->ClientAuthorativePosition; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientAuthorativePosition_SET(AGameNetworkManager* Ptr, bool Value) { Ptr->ClientAuthorativePosition = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_GET(AGameNetworkManager* Ptr) { return Ptr->ClientErrorUpdateRateLimit; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_SET(AGameNetworkManager* Ptr, float Value) { Ptr->ClientErrorUpdateRateLimit = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_GET(AGameNetworkManager* Ptr) { return Ptr->ClientNetSendMoveDeltaTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->ClientNetSendMoveDeltaTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_GET(AGameNetworkManager* Ptr) { return Ptr->ClientNetSendMoveDeltaTimeStationary; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_SET(AGameNetworkManager* Ptr, float Value) { Ptr->ClientNetSendMoveDeltaTimeStationary = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_GET(AGameNetworkManager* Ptr) { return Ptr->ClientNetSendMoveDeltaTimeThrottled; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_SET(AGameNetworkManager* Ptr, float Value) { Ptr->ClientNetSendMoveDeltaTimeThrottled = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_GET(AGameNetworkManager* Ptr) { return Ptr->ClientNetSendMoveThrottleAtNetSpeed; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->ClientNetSendMoveThrottleAtNetSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_GET(AGameNetworkManager* Ptr) { return Ptr->ClientNetSendMoveThrottleOverPlayerCount; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->ClientNetSendMoveThrottleOverPlayerCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_GET(AGameNetworkManager* Ptr) { return Ptr->JoinInProgressStandbyWaitTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->JoinInProgressStandbyWaitTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_GET(AGameNetworkManager* Ptr) { return Ptr->LastNetSpeedUpdateTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->LastNetSpeedUpdateTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_GET(AGameNetworkManager* Ptr) { return Ptr->MaxClientForcedUpdateDuration; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MaxClientForcedUpdateDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_GET(AGameNetworkManager* Ptr) { return Ptr->MaxClientSmoothingDeltaTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MaxClientSmoothingDeltaTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_GET(AGameNetworkManager* Ptr) { return Ptr->MAXCLIENTUPDATEINTERVAL; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MAXCLIENTUPDATEINTERVAL = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MaxDynamicBandwidth_GET(AGameNetworkManager* Ptr) { return Ptr->MaxDynamicBandwidth; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MaxDynamicBandwidth_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->MaxDynamicBandwidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MaxMoveDeltaTime_GET(AGameNetworkManager* Ptr) { return Ptr->MaxMoveDeltaTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MaxMoveDeltaTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MaxMoveDeltaTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_GET(AGameNetworkManager* Ptr) { return Ptr->MAXNEARZEROVELOCITYSQUARED; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MAXNEARZEROVELOCITYSQUARED = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_GET(AGameNetworkManager* Ptr) { return Ptr->MAXPOSITIONERRORSQUARED; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MAXPOSITIONERRORSQUARED = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MinDynamicBandwidth_GET(AGameNetworkManager* Ptr) { return Ptr->MinDynamicBandwidth; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MinDynamicBandwidth_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->MinDynamicBandwidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_GET(AGameNetworkManager* Ptr) { return Ptr->MovementTimeDiscrepancyDriftAllowance; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MovementTimeDiscrepancyDriftAllowance = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_GET(AGameNetworkManager* Ptr) { return Ptr->MovementTimeDiscrepancyMaxTimeMargin; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MovementTimeDiscrepancyMaxTimeMargin = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_GET(AGameNetworkManager* Ptr) { return Ptr->MovementTimeDiscrepancyMinTimeMargin; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MovementTimeDiscrepancyMinTimeMargin = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_GET(AGameNetworkManager* Ptr) { return Ptr->MovementTimeDiscrepancyResolutionRate; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MovementTimeDiscrepancyResolutionRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_MoveRepSize_GET(AGameNetworkManager* Ptr) { return Ptr->MoveRepSize; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_MoveRepSize_SET(AGameNetworkManager* Ptr, float Value) { Ptr->MoveRepSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_PercentForBadPing_GET(AGameNetworkManager* Ptr) { return Ptr->PercentForBadPing; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_PercentForBadPing_SET(AGameNetworkManager* Ptr, float Value) { Ptr->PercentForBadPing = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_PercentMissingForRxStandby_GET(AGameNetworkManager* Ptr) { return Ptr->PercentMissingForRxStandby; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_PercentMissingForRxStandby_SET(AGameNetworkManager* Ptr, float Value) { Ptr->PercentMissingForRxStandby = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_PercentMissingForTxStandby_GET(AGameNetworkManager* Ptr) { return Ptr->PercentMissingForTxStandby; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_PercentMissingForTxStandby_SET(AGameNetworkManager* Ptr, float Value) { Ptr->PercentMissingForTxStandby = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_StandbyRxCheatTime_GET(AGameNetworkManager* Ptr) { return Ptr->StandbyRxCheatTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_StandbyRxCheatTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->StandbyRxCheatTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_StandbyTxCheatTime_GET(AGameNetworkManager* Ptr) { return Ptr->StandbyTxCheatTime; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_StandbyTxCheatTime_SET(AGameNetworkManager* Ptr, float Value) { Ptr->StandbyTxCheatTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameNetworkManager_TotalNetBandwidth_GET(AGameNetworkManager* Ptr) { return Ptr->TotalNetBandwidth; }
	DOTNET_EXPORT void E_PROP_AGameNetworkManager_TotalNetBandwidth_SET(AGameNetworkManager* Ptr, int32 Value) { Ptr->TotalNetBandwidth = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameNetworkManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameNetworkManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_CalculatedNetSpeed(AGameNetworkManager* Self)
	{
		return Self->CalculatedNetSpeed();
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_EnableStandbyCheatDetection(AGameNetworkManager* Self, bool bIsEnabled)
	{
		auto _p0 = bIsEnabled;
		Self->EnableStandbyCheatDetection(_p0);
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_ExceedsAllowablePositionError(AGameNetworkManager* Self, INT_PTR LocDiff)
	{
		auto _p0 = *(FVector*)LocDiff;
		return Self->ExceedsAllowablePositionError(_p0);
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_IsInLowBandwidthMode(AGameNetworkManager* Self)
	{
		return Self->IsInLowBandwidthMode();
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_NetworkVelocityNearZero(AGameNetworkManager* Self, INT_PTR InVelocity)
	{
		auto _p0 = *(FVector*)InVelocity;
		return Self->NetworkVelocityNearZero(_p0);
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_StandbyCheatDetected(AGameNetworkManager* Self, EStandbyType StandbyType)
	{
		auto _p0 = StandbyType;
		Self->StandbyCheatDetected(_p0);
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_UpdateNetSpeeds(AGameNetworkManager* Self, bool bIsLanMatch)
	{
		auto _p0 = bIsLanMatch;
		Self->UpdateNetSpeeds(_p0);
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_UpdateNetSpeedsTimer(AGameNetworkManager* Self)
	{
		Self->UpdateNetSpeedsTimer();
	}

	DOTNET_EXPORT auto E_AGameNetworkManager_WithinUpdateDelayBounds(AGameNetworkManager* Self, APlayerController* PC, float LastUpdateTime)
	{
		auto _p0 = PC;
		auto _p1 = LastUpdateTime;
		return Self->WithinUpdateDelayBounds(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_EnableStandbyCheatDetection(AGameNetworkManager* Self, bool bIsEnabled)
	{
		auto _p0 = bIsEnabled;
		((AManageGameNetworkManager*)Self)->_Supper__EnableStandbyCheatDetection(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_UpdateNetSpeeds(AGameNetworkManager* Self, bool bIsLanMatch)
	{
		auto _p0 = bIsLanMatch;
		((AManageGameNetworkManager*)Self)->_Supper__UpdateNetSpeeds(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_UpdateNetSpeedsTimer(AGameNetworkManager* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__UpdateNetSpeedsTimer();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_BeginPlay(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_Destroyed(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_ForceNetRelevant(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_ForceNetUpdate(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameNetworkManager*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_K2_DestroyActor(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_LifeSpanExpired(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnRep_Instigator(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnRep_Owner(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameNetworkManager*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostActorCreated(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostInitializeComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostNetInit(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PreInitializeComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameNetworkManager*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameNetworkManager*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_RegisterAllComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_Reset(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_RewindForReplay(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameNetworkManager*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameNetworkManager*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameNetworkManager*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_TearOff(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameNetworkManager*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameNetworkManager*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_TornOff(AActor* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameNetworkManager*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_BeginDestroy(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_FinishDestroy(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostCDOContruct(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostEditImport(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostInitProperties(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostLoad(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostNetReceive(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostRepNotifies(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameNetworkManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_PreNetReceive(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_ShutdownAfterError(UObject* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameNetworkManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameNetworkManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
