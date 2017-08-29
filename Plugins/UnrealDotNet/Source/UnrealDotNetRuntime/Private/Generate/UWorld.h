#pragma once

#include "CoreMinimal.h"
#include "Engine/World.h"

extern "C"
{
	DOTNET_EXPORT bool E_PROP_UWorld_bInTick_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bInTick; }
	DOTNET_EXPORT void E_PROP_UWorld_bInTick_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bInTick = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsBuilt_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsBuilt; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsBuilt_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsBuilt = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bTickNewlySpawned_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bTickNewlySpawned; }
	DOTNET_EXPORT void E_PROP_UWorld_bTickNewlySpawned_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bTickNewlySpawned = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bPostTickComponentUpdate_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bPostTickComponentUpdate; }
	DOTNET_EXPORT void E_PROP_UWorld_bPostTickComponentUpdate_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bPostTickComponentUpdate = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_PlayerNum_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->PlayerNum; }
	DOTNET_EXPORT void E_PROP_UWorld_PlayerNum_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->PlayerNum = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_TimeSinceLastPendingKillPurge_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->TimeSinceLastPendingKillPurge; }
	DOTNET_EXPORT void E_PROP_UWorld_TimeSinceLastPendingKillPurge_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->TimeSinceLastPendingKillPurge = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_FullPurgeTriggered_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->FullPurgeTriggered; }
	DOTNET_EXPORT void E_PROP_UWorld_FullPurgeTriggered_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->FullPurgeTriggered = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldDelayGarbageCollect_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldDelayGarbageCollect; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldDelayGarbageCollect_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldDelayGarbageCollect = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsWorldInitialized_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsWorldInitialized; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsWorldInitialized_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsWorldInitialized = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->StreamingVolumeUpdateDelay; }
	DOTNET_EXPORT void E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->StreamingVolumeUpdateDelay = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsLevelStreamingFrozen_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsLevelStreamingFrozen; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsLevelStreamingFrozen_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsLevelStreamingFrozen = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldForceUnloadStreamingLevels_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldForceUnloadStreamingLevels; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldForceUnloadStreamingLevels_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldForceUnloadStreamingLevels = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldForceVisibleStreamingLevels_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldForceVisibleStreamingLevels; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldForceVisibleStreamingLevels_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldForceVisibleStreamingLevels = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bDoDelayedUpdateCullDistanceVolumes; }
	DOTNET_EXPORT void E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bDoDelayedUpdateCullDistanceVolumes = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bHack_Force_UsesGameHiddenFlags_True; }
	DOTNET_EXPORT void E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bHack_Force_UsesGameHiddenFlags_True = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsRunningConstructionScript_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsRunningConstructionScript; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsRunningConstructionScript_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsRunningConstructionScript = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldSimulatePhysics_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldSimulatePhysics; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldSimulatePhysics_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldSimulatePhysics = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bCreateRenderStateForHiddenComponents; }
	DOTNET_EXPORT void E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bCreateRenderStateForHiddenComponents = Value; }
	
	DOTNET_EXPORT double E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->LastTimeUnbuiltLightingWasEncountered; }
	DOTNET_EXPORT void E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(INT_PTR Ptr, double Value) { ((UWorld*)Ptr)->LastTimeUnbuiltLightingWasEncountered = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_TimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->TimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_TimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->TimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_UnpausedTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->UnpausedTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_UnpausedTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->UnpausedTimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_RealTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->RealTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_RealTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->RealTimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_AudioTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->AudioTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_AudioTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->AudioTimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_DeltaTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->DeltaTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_DeltaTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->DeltaTimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_PauseDelay_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->PauseDelay; }
	DOTNET_EXPORT void E_PROP_UWorld_PauseDelay_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->PauseDelay = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_UWorld_OriginOffsetThisFrame_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((UWorld*)Ptr)->OriginOffsetThisFrame); }
	DOTNET_EXPORT void E_PROP_UWorld_OriginOffsetThisFrame_SET(INT_PTR Ptr, INT_PTR Value) { ((UWorld*)Ptr)->OriginOffsetThisFrame = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_NextSwitchCountdown_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NextSwitchCountdown; }
	DOTNET_EXPORT void E_PROP_UWorld_NextSwitchCountdown_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->NextSwitchCountdown = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NumTextureStreamingUnbuiltComponents; }
	DOTNET_EXPORT void E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->NumTextureStreamingUnbuiltComponents = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_NumTextureStreamingDirtyResources_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NumTextureStreamingDirtyResources; }
	DOTNET_EXPORT void E_PROP_UWorld_NumTextureStreamingDirtyResources_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->NumTextureStreamingDirtyResources = Value; }
	
	DOTNET_EXPORT void E_UWorld_CreateFXSystem(INT_PTR Self)
	{
		((UWorld*)Self)->CreateFXSystem();
	}

	DOTNET_EXPORT void E_UWorld_SetShouldTick(INT_PTR Self, bool bInShouldTick)
	{
		auto _p0 = bInShouldTick;
		((UWorld*)Self)->SetShouldTick(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ShouldTick(INT_PTR Self)
	{
		return ((UWorld*)Self)->ShouldTick();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumPawns(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNumPawns();
	}

	DOTNET_EXPORT float E_UWorld_GetTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_TimeSince(INT_PTR Self, float Time)
	{
		auto _p0 = Time;
		return ((UWorld*)Self)->TimeSince(_p0);
	}

	DOTNET_EXPORT void E_UWorld_AddPawn(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		((UWorld*)Self)->AddPawn(_p0);
	}

	DOTNET_EXPORT void E_UWorld_AddNetworkActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		((UWorld*)Self)->AddNetworkActor(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ContainsActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return ((UWorld*)Self)->ContainsActor(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_AllowAudioPlayback(INT_PTR Self)
	{
		return ((UWorld*)Self)->AllowAudioPlayback();
	}

	DOTNET_EXPORT void E_UWorld_UpdateWorldComponents(INT_PTR Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly)
	{
		auto _p0 = bRerunConstructionScripts;
		auto _p1 = bCurrentLevelOnly;
		((UWorld*)Self)->UpdateWorldComponents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_CleanupWorld(INT_PTR Self, bool bSessionEnded, bool bCleanupResources, UWorld* NewWorld)
	{
		auto _p0 = bSessionEnded;
		auto _p1 = bCleanupResources;
		auto _p2 = NewWorld;
		((UWorld*)Self)->CleanupWorld(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_DestroyWorld(INT_PTR Self, bool bInformEngineOfWorld, UWorld* NewWorld)
	{
		auto _p0 = bInformEngineOfWorld;
		auto _p1 = NewWorld;
		((UWorld*)Self)->DestroyWorld(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_SetTimeUntilNextGarbageCollection(INT_PTR Self, float MinTimeUntilNextPass)
	{
		auto _p0 = MinTimeUntilNextPass;
		((UWorld*)Self)->SetTimeUntilNextGarbageCollection(_p0);
	}

	DOTNET_EXPORT void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(INT_PTR Self, UActorComponent* Component, bool bForceGameThread)
	{
		auto _p0 = Component;
		auto _p1 = bForceGameThread;
		((UWorld*)Self)->MarkActorComponentForNeededEndOfFrameUpdate(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_ClearActorComponentEndOfFrameUpdate(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((UWorld*)Self)->ClearActorComponentEndOfFrameUpdate(_p0);
	}

	DOTNET_EXPORT void E_UWorld_UpdateActorComponentEndOfFrameUpdateState(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((UWorld*)Self)->UpdateActorComponentEndOfFrameUpdateState(_p0);
	}

	DOTNET_EXPORT void E_UWorld_ProcessLevelStreamingVolumes(INT_PTR Self, INT_PTR OverrideViewLocation)
	{
		auto _p0 = *(FVector*)OverrideViewLocation;
		((UWorld*)Self)->ProcessLevelStreamingVolumes(&_p0);
	}

	DOTNET_EXPORT bool E_UWorld_EditorDestroyActor(INT_PTR Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		return ((UWorld*)Self)->EditorDestroyActor(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_DestroyActor(INT_PTR Self, AActor* Actor, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bNetForce;
		auto _p2 = bShouldModifyLevel;
		return ((UWorld*)Self)->DestroyActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_RemoveActor(INT_PTR Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		((UWorld*)Self)->RemoveActor(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_FindTeleportSpot(INT_PTR Self, AActor* TestActor, INT_PTR PlaceLocation, INT_PTR PlaceRotation)
	{
		auto _p0 = TestActor;
		auto _p1 = *(FVector*)PlaceLocation;
		auto _p2 = *(FRotator*)PlaceRotation;
		return ((UWorld*)Self)->FindTeleportSpot(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_UWorld_EncroachingBlockingGeometry(INT_PTR Self, AActor* TestActor, INT_PTR TestLocation, INT_PTR TestRotation, INT_PTR ProposedAdjustment)
	{
		auto _p0 = TestActor;
		auto _p1 = *(FVector*)TestLocation;
		auto _p2 = *(FRotator*)TestRotation;
		auto _p3 = *(FVector*)ProposedAdjustment;
		return ((UWorld*)Self)->EncroachingBlockingGeometry(_p0, _p1, _p2, &_p3);
	}

	DOTNET_EXPORT void E_UWorld_DelayStreamingVolumeUpdates(INT_PTR Self, int32 InFrameDelay)
	{
		auto _p0 = InFrameDelay;
		((UWorld*)Self)->DelayStreamingVolumeUpdates(_p0);
	}

	DOTNET_EXPORT void E_UWorld_TransferBlueprintDebugReferences(INT_PTR Self, UWorld* NewWorld)
	{
		auto _p0 = NewWorld;
		((UWorld*)Self)->TransferBlueprintDebugReferences(_p0);
	}

	DOTNET_EXPORT int32 E_UWorld_GetProgressDenominator(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetProgressDenominator();
	}

}
