#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Engine/World.h"

extern "C"
{
	DOTNET_EXPORT float E_PROP_UWorld_AudioTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->AudioTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_AudioTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->AudioTimeSeconds = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bCreateRenderStateForHiddenComponents; }
	DOTNET_EXPORT void E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bCreateRenderStateForHiddenComponents = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bDebugDrawAllTraceTags_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bDebugDrawAllTraceTags; }
	DOTNET_EXPORT void E_PROP_UWorld_bDebugDrawAllTraceTags_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bDebugDrawAllTraceTags = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bDoDelayedUpdateCullDistanceVolumes; }
	DOTNET_EXPORT void E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bDoDelayedUpdateCullDistanceVolumes = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bHack_Force_UsesGameHiddenFlags_True; }
	DOTNET_EXPORT void E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bHack_Force_UsesGameHiddenFlags_True = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bInTick_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bInTick; }
	DOTNET_EXPORT void E_PROP_UWorld_bInTick_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bInTick = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsBuilt_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsBuilt; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsBuilt_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsBuilt = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsLevelStreamingFrozen_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsLevelStreamingFrozen; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsLevelStreamingFrozen_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsLevelStreamingFrozen = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsRunningConstructionScript_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsRunningConstructionScript; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsRunningConstructionScript_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsRunningConstructionScript = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bIsWorldInitialized_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bIsWorldInitialized; }
	DOTNET_EXPORT void E_PROP_UWorld_bIsWorldInitialized_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bIsWorldInitialized = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bPostTickComponentUpdate_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bPostTickComponentUpdate; }
	DOTNET_EXPORT void E_PROP_UWorld_bPostTickComponentUpdate_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bPostTickComponentUpdate = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldDelayGarbageCollect_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldDelayGarbageCollect; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldDelayGarbageCollect_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldDelayGarbageCollect = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldForceUnloadStreamingLevels_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldForceUnloadStreamingLevels; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldForceUnloadStreamingLevels_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldForceUnloadStreamingLevels = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldForceVisibleStreamingLevels_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldForceVisibleStreamingLevels; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldForceVisibleStreamingLevels_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldForceVisibleStreamingLevels = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bShouldSimulatePhysics_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bShouldSimulatePhysics; }
	DOTNET_EXPORT void E_PROP_UWorld_bShouldSimulatePhysics_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bShouldSimulatePhysics = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_bTickNewlySpawned_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->bTickNewlySpawned; }
	DOTNET_EXPORT void E_PROP_UWorld_bTickNewlySpawned_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->bTickNewlySpawned = Value; }
	
	DOTNET_EXPORT char* E_PROP_UWorld_CommittedPersistentLevelName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((UWorld*)Ptr)->CommittedPersistentLevelName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_UWorld_CommittedPersistentLevelName_SET(INT_PTR Ptr, char* Value) { ((UWorld*)Ptr)->CommittedPersistentLevelName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_UWorld_DebugDrawTraceTag_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((UWorld*)Ptr)->DebugDrawTraceTag.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_UWorld_DebugDrawTraceTag_SET(INT_PTR Ptr, char* Value) { ((UWorld*)Ptr)->DebugDrawTraceTag = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT float E_PROP_UWorld_DeltaTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->DeltaTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_DeltaTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->DeltaTimeSeconds = Value; }
	
	DOTNET_EXPORT bool E_PROP_UWorld_FullPurgeTriggered_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->FullPurgeTriggered; }
	DOTNET_EXPORT void E_PROP_UWorld_FullPurgeTriggered_SET(INT_PTR Ptr, bool Value) { ((UWorld*)Ptr)->FullPurgeTriggered = Value; }
	
	DOTNET_EXPORT double E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->LastTimeUnbuiltLightingWasEncountered; }
	DOTNET_EXPORT void E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(INT_PTR Ptr, double Value) { ((UWorld*)Ptr)->LastTimeUnbuiltLightingWasEncountered = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_NextSwitchCountdown_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NextSwitchCountdown; }
	DOTNET_EXPORT void E_PROP_UWorld_NextSwitchCountdown_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->NextSwitchCountdown = Value; }
	
	DOTNET_EXPORT ETravelType E_PROP_UWorld_NextTravelType_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NextTravelType; }
	DOTNET_EXPORT void E_PROP_UWorld_NextTravelType_SET(INT_PTR Ptr, ETravelType Value) { ((UWorld*)Ptr)->NextTravelType = Value; }
	
	DOTNET_EXPORT char* E_PROP_UWorld_NextURL_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((UWorld*)Ptr)->NextURL;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_UWorld_NextURL_SET(INT_PTR Ptr, char* Value) { ((UWorld*)Ptr)->NextURL = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_NumTextureStreamingDirtyResources_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NumTextureStreamingDirtyResources; }
	DOTNET_EXPORT void E_PROP_UWorld_NumTextureStreamingDirtyResources_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->NumTextureStreamingDirtyResources = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->NumTextureStreamingUnbuiltComponents; }
	DOTNET_EXPORT void E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->NumTextureStreamingUnbuiltComponents = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_UWorld_OriginOffsetThisFrame_GET(INT_PTR Ptr) { return (INT_PTR)&((UWorld*)Ptr)->OriginOffsetThisFrame; }
	DOTNET_EXPORT void E_PROP_UWorld_OriginOffsetThisFrame_SET(INT_PTR Ptr, INT_PTR Value) { ((UWorld*)Ptr)->OriginOffsetThisFrame = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_PauseDelay_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->PauseDelay; }
	DOTNET_EXPORT void E_PROP_UWorld_PauseDelay_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->PauseDelay = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_PlayerNum_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->PlayerNum; }
	DOTNET_EXPORT void E_PROP_UWorld_PlayerNum_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->PlayerNum = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_RealTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->RealTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_RealTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->RealTimeSeconds = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->StreamingVolumeUpdateDelay; }
	DOTNET_EXPORT void E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(INT_PTR Ptr, int32 Value) { ((UWorld*)Ptr)->StreamingVolumeUpdateDelay = Value; }
	
	DOTNET_EXPORT ETickingGroup E_PROP_UWorld_TickGroup_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->TickGroup; }
	DOTNET_EXPORT void E_PROP_UWorld_TickGroup_SET(INT_PTR Ptr, ETickingGroup Value) { ((UWorld*)Ptr)->TickGroup = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_TimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->TimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_TimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->TimeSeconds = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_TimeSinceLastPendingKillPurge_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->TimeSinceLastPendingKillPurge; }
	DOTNET_EXPORT void E_PROP_UWorld_TimeSinceLastPendingKillPurge_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->TimeSinceLastPendingKillPurge = Value; }
	
	DOTNET_EXPORT float E_PROP_UWorld_UnpausedTimeSeconds_GET(INT_PTR Ptr) { return ((UWorld*)Ptr)->UnpausedTimeSeconds; }
	DOTNET_EXPORT void E_PROP_UWorld_UnpausedTimeSeconds_SET(INT_PTR Ptr, float Value) { ((UWorld*)Ptr)->UnpausedTimeSeconds = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_UWorld_URL_GET(INT_PTR Ptr) { return (INT_PTR)&((UWorld*)Ptr)->URL; }
	DOTNET_EXPORT void E_PROP_UWorld_URL_SET(INT_PTR Ptr, INT_PTR Value) { ((UWorld*)Ptr)->URL = *(FURL*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UWorld(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UWorld>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UWorld_AddNetworkActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		((UWorld*)Self)->AddNetworkActor(_p0);
	}

	DOTNET_EXPORT void E_UWorld_AddPawn(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		((UWorld*)Self)->AddPawn(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_AllowLevelLoadRequests(INT_PTR Self)
	{
		return ((UWorld*)Self)->AllowLevelLoadRequests();
	}

	DOTNET_EXPORT bool E_UWorld_AreActorsInitialized(INT_PTR Self)
	{
		return ((UWorld*)Self)->AreActorsInitialized();
	}

	DOTNET_EXPORT bool E_UWorld_AreAlwaysLoadedLevelsLoaded(INT_PTR Self)
	{
		return ((UWorld*)Self)->AreAlwaysLoadedLevelsLoaded();
	}

	DOTNET_EXPORT void E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(INT_PTR Self)
	{
		((UWorld*)Self)->AsyncLoadAlwaysLoadedLevelsForSeamlessTravel();
	}

	DOTNET_EXPORT ENetMode E_UWorld_AttemptDeriveFromURL(INT_PTR Self)
	{
		return ((UWorld*)Self)->AttemptDeriveFromURL();
	}

	DOTNET_EXPORT void E_UWorld_BeginPlay(INT_PTR Self)
	{
		((UWorld*)Self)->BeginPlay();
	}

	DOTNET_EXPORT void E_UWorld_BroadcastLevelsChanged(INT_PTR Self)
	{
		((UWorld*)Self)->BroadcastLevelsChanged();
	}

	DOTNET_EXPORT char* E_UWorld_BuildPIEPackagePrefix(INT_PTR Self, int32 PIEInstanceID, int& ResultStringLen)
	{
		auto _p0 = PIEInstanceID;
		auto _result = ((UWorld*)Self)->BuildPIEPackagePrefix(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_CancelPendingMapChange(INT_PTR Self)
	{
		((UWorld*)Self)->CancelPendingMapChange();
	}

	DOTNET_EXPORT void E_UWorld_CleanupWorld(INT_PTR Self, bool bSessionEnded, bool bCleanupResources, UWorld* NewWorld)
	{
		auto _p0 = bSessionEnded;
		auto _p1 = bCleanupResources;
		auto _p2 = NewWorld;
		((UWorld*)Self)->CleanupWorld(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_ClearActorComponentEndOfFrameUpdate(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((UWorld*)Self)->ClearActorComponentEndOfFrameUpdate(_p0);
	}

	DOTNET_EXPORT void E_UWorld_ClearWorldComponents(INT_PTR Self)
	{
		((UWorld*)Self)->ClearWorldComponents();
	}

	DOTNET_EXPORT void E_UWorld_CommitMapChange(INT_PTR Self)
	{
		((UWorld*)Self)->CommitMapChange();
	}

	DOTNET_EXPORT void E_UWorld_CommitModelSurfaces(INT_PTR Self)
	{
		((UWorld*)Self)->CommitModelSurfaces();
	}

	DOTNET_EXPORT void E_UWorld_ConditionallyBuildStreamingData(INT_PTR Self)
	{
		((UWorld*)Self)->ConditionallyBuildStreamingData();
	}

	DOTNET_EXPORT bool E_UWorld_ContainsActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return ((UWorld*)Self)->ContainsActor(_p0);
	}

	DOTNET_EXPORT char* E_UWorld_ConvertToPIEPackageName(INT_PTR Self, char* PackageName, int32 PIEInstanceID, int& ResultStringLen)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = PIEInstanceID;
		auto _result = ((UWorld*)Self)->ConvertToPIEPackageName(_p0, _p1);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_CreateFXSystem(INT_PTR Self)
	{
		((UWorld*)Self)->CreateFXSystem();
	}

	DOTNET_EXPORT void E_UWorld_CreatePhysicsScene(INT_PTR Self)
	{
		((UWorld*)Self)->CreatePhysicsScene();
	}

	DOTNET_EXPORT bool E_UWorld_DebugDrawSceneQueries(INT_PTR Self, char* UsedTraceTag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(UsedTraceTag));
		return ((UWorld*)Self)->DebugDrawSceneQueries(_p0);
	}

	DOTNET_EXPORT void E_UWorld_DelayStreamingVolumeUpdates(INT_PTR Self, int32 InFrameDelay)
	{
		auto _p0 = InFrameDelay;
		((UWorld*)Self)->DelayStreamingVolumeUpdates(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_DestroyActor(INT_PTR Self, AActor* Actor, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bNetForce;
		auto _p2 = bShouldModifyLevel;
		return ((UWorld*)Self)->DestroyActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_DestroyDemoNetDriver(INT_PTR Self)
	{
		((UWorld*)Self)->DestroyDemoNetDriver();
	}

	DOTNET_EXPORT void E_UWorld_DuplicateRequestedLevels(INT_PTR Self, char* MapName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(MapName));
		((UWorld*)Self)->DuplicateRequestedLevels(_p0);
	}

	DOTNET_EXPORT UWorld* E_UWorld_DuplicateWorldForPIE(INT_PTR Self, char* PackageName, UWorld* OwningWorld)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = OwningWorld;
		return ((UWorld*)Self)->DuplicateWorldForPIE(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_EditorDestroyActor(INT_PTR Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		return ((UWorld*)Self)->EditorDestroyActor(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_EnsureCollisionTreeIsBuilt(INT_PTR Self)
	{
		((UWorld*)Self)->EnsureCollisionTreeIsBuilt();
	}

	DOTNET_EXPORT bool E_UWorld_FindTeleportSpot(INT_PTR Self, AActor* TestActor, INT_PTR PlaceLocation, INT_PTR PlaceRotation)
	{
		auto _p0 = TestActor;
		auto _p1 = *(FVector*)PlaceLocation;
		auto _p2 = *(FRotator*)PlaceRotation;
		return ((UWorld*)Self)->FindTeleportSpot(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_FinishPhysicsSim(INT_PTR Self)
	{
		((UWorld*)Self)->FinishPhysicsSim();
	}

	DOTNET_EXPORT void E_UWorld_ForceGarbageCollection(INT_PTR Self, bool bFullPurge)
	{
		auto _p0 = bFullPurge;
		((UWorld*)Self)->ForceGarbageCollection(_p0);
	}

	DOTNET_EXPORT int32 E_UWorld_GetActorCount(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetActorCount();
	}

	DOTNET_EXPORT float E_UWorld_GetAudioTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetAudioTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetDefaultGravityZ(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetDefaultGravityZ();
	}

	DOTNET_EXPORT float E_UWorld_GetDeltaSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetDeltaSeconds();
	}

	DOTNET_EXPORT int32 E_UWorld_GetDetailMode(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetDetailMode();
	}

	DOTNET_EXPORT float E_UWorld_GetGravityZ(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetGravityZ();
	}

	DOTNET_EXPORT float E_UWorld_GetMonoFarFieldCullingDistance(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetMonoFarFieldCullingDistance();
	}

	DOTNET_EXPORT ENetMode E_UWorld_GetNetMode(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNetMode();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNonDefaultPhysicsVolumeCount(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNonDefaultPhysicsVolumeCount();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumLevels(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNumLevels();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumPawns(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNumPawns();
	}

	DOTNET_EXPORT int32 E_UWorld_GetProgressDenominator(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetProgressDenominator();
	}

	DOTNET_EXPORT float E_UWorld_GetRealTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetRealTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetUnpausedTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetUnpausedTimeSeconds();
	}

	DOTNET_EXPORT bool E_UWorld_HasBegunPlay(INT_PTR Self)
	{
		return ((UWorld*)Self)->HasBegunPlay();
	}

	DOTNET_EXPORT bool E_UWorld_HasDefaultPhysicsVolume(INT_PTR Self)
	{
		return ((UWorld*)Self)->HasDefaultPhysicsVolume();
	}

	DOTNET_EXPORT bool E_UWorld_HasEndOfFrameUpdates(INT_PTR Self)
	{
		return ((UWorld*)Self)->HasEndOfFrameUpdates();
	}

	DOTNET_EXPORT void E_UWorld_InitializeActorsForPlay(INT_PTR Self, INT_PTR InURL, bool bResetTime)
	{
		auto _p0 = *(FURL*)InURL;
		auto _p1 = bResetTime;
		((UWorld*)Self)->InitializeActorsForPlay(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_InvalidateModelSurface(INT_PTR Self, bool bCurrentLevelOnly)
	{
		auto _p0 = bCurrentLevelOnly;
		((UWorld*)Self)->InvalidateModelSurface(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_IsCameraMoveable(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsCameraMoveable();
	}

	DOTNET_EXPORT bool E_UWorld_IsClient(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsClient();
	}

	DOTNET_EXPORT bool E_UWorld_IsEditorWorld(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsEditorWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsGameWorld(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsGameWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsInSeamlessTravel(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsInSeamlessTravel();
	}

	DOTNET_EXPORT bool E_UWorld_IsMapChangeReady(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsMapChangeReady();
	}

	DOTNET_EXPORT bool E_UWorld_IsNavigationRebuilt(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsNavigationRebuilt();
	}

	DOTNET_EXPORT bool E_UWorld_IsNetMode(INT_PTR Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return ((UWorld*)Self)->IsNetMode(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_IsPaused(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPaused();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInEditor(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPlayInEditor();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayingReplay(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPlayingReplay();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInMobilePreview(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPlayInMobilePreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInPreview(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPlayInPreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInVulkanPreview(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPlayInVulkanPreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPreparingMapChange(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPreparingMapChange();
	}

	DOTNET_EXPORT bool E_UWorld_IsPreviewWorld(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsPreviewWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsRecordingClientReplay(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsRecordingClientReplay();
	}

	DOTNET_EXPORT bool E_UWorld_IsServer(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsServer();
	}

	DOTNET_EXPORT bool E_UWorld_IsVisibilityRequestPending(INT_PTR Self)
	{
		return ((UWorld*)Self)->IsVisibilityRequestPending();
	}

	DOTNET_EXPORT bool E_UWorld_Listen(INT_PTR Self, INT_PTR InURL)
	{
		auto _p0 = *(FURL*)InURL;
		return ((UWorld*)Self)->Listen(_p0);
	}

	DOTNET_EXPORT void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(INT_PTR Self, UActorComponent* Component, bool bForceGameThread)
	{
		auto _p0 = Component;
		auto _p1 = bForceGameThread;
		((UWorld*)Self)->MarkActorComponentForNeededEndOfFrameUpdate(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_PropagateLightingScenarioChange(INT_PTR Self, bool bLevelWasMadeVisible)
	{
		auto _p0 = bLevelWasMadeVisible;
		((UWorld*)Self)->PropagateLightingScenarioChange(_p0);
	}

	DOTNET_EXPORT void E_UWorld_RemoveActor(INT_PTR Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		((UWorld*)Self)->RemoveActor(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_RemoveNetworkActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		((UWorld*)Self)->RemoveNetworkActor(_p0);
	}

	DOTNET_EXPORT void E_UWorld_RemovePawn(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		((UWorld*)Self)->RemovePawn(_p0);
	}

	DOTNET_EXPORT char* E_UWorld_RemovePIEPrefix(INT_PTR Self, char* Source, int& ResultStringLen)
	{
		auto _p0 = FString(Source);
		auto _result = ((UWorld*)Self)->RemovePIEPrefix(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_RenameToPIEWorld(INT_PTR Self, int32 PIEInstanceID)
	{
		auto _p0 = PIEInstanceID;
		((UWorld*)Self)->RenameToPIEWorld(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_RequiresHitProxies(INT_PTR Self)
	{
		return ((UWorld*)Self)->RequiresHitProxies();
	}

	DOTNET_EXPORT void E_UWorld_RunTickGroup(INT_PTR Self, ETickingGroup Group, bool bBlockTillComplete)
	{
		auto _p0 = Group;
		auto _p1 = bBlockTillComplete;
		((UWorld*)Self)->RunTickGroup(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_SendAllEndOfFrameUpdates(INT_PTR Self)
	{
		((UWorld*)Self)->SendAllEndOfFrameUpdates();
	}

	DOTNET_EXPORT bool E_UWorld_SetGameMode(INT_PTR Self, INT_PTR InURL)
	{
		auto _p0 = *(FURL*)InURL;
		return ((UWorld*)Self)->SetGameMode(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetMapNeedsLightingFullyRebuilt(INT_PTR Self, int32 InNumLightingUnbuiltObjects)
	{
		auto _p0 = InNumLightingUnbuiltObjects;
		((UWorld*)Self)->SetMapNeedsLightingFullyRebuilt(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetSeamlessTravelMidpointPause(INT_PTR Self, bool bNowPaused)
	{
		auto _p0 = bNowPaused;
		((UWorld*)Self)->SetSeamlessTravelMidpointPause(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetShouldTick(INT_PTR Self, bool bInShouldTick)
	{
		auto _p0 = bInShouldTick;
		((UWorld*)Self)->SetShouldTick(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetupParameterCollectionInstances(INT_PTR Self)
	{
		((UWorld*)Self)->SetupParameterCollectionInstances();
	}

	DOTNET_EXPORT void E_UWorld_SetupPhysicsTickFunctions(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((UWorld*)Self)->SetupPhysicsTickFunctions(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ShouldTick(INT_PTR Self)
	{
		return ((UWorld*)Self)->ShouldTick();
	}

	DOTNET_EXPORT void E_UWorld_StartPhysicsSim(INT_PTR Self)
	{
		((UWorld*)Self)->StartPhysicsSim();
	}

	DOTNET_EXPORT char* E_UWorld_StripPIEPrefixFromPackageName(INT_PTR Self, char* PackageName, char* Prefix, int& ResultStringLen)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = FString(Prefix);
		auto _result = ((UWorld*)Self)->StripPIEPrefixFromPackageName(_p0, _p1);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_Tick(INT_PTR Self, ELevelTick TickType, float DeltaSeconds)
	{
		auto _p0 = TickType;
		auto _p1 = DeltaSeconds;
		((UWorld*)Self)->Tick(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_TickNetClient(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((UWorld*)Self)->TickNetClient(_p0);
	}

	DOTNET_EXPORT float E_UWorld_TimeSince(INT_PTR Self, float Time)
	{
		auto _p0 = Time;
		return ((UWorld*)Self)->TimeSince(_p0);
	}

	DOTNET_EXPORT void E_UWorld_TransferBlueprintDebugReferences(INT_PTR Self, UWorld* NewWorld)
	{
		auto _p0 = NewWorld;
		((UWorld*)Self)->TransferBlueprintDebugReferences(_p0);
	}

	DOTNET_EXPORT void E_UWorld_TriggerStreamingDataRebuild(INT_PTR Self)
	{
		((UWorld*)Self)->TriggerStreamingDataRebuild();
	}

	DOTNET_EXPORT void E_UWorld_UpdateActorComponentEndOfFrameUpdateState(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((UWorld*)Self)->UpdateActorComponentEndOfFrameUpdateState(_p0);
	}

	DOTNET_EXPORT void E_UWorld_UpdateAllReflectionCaptures(INT_PTR Self)
	{
		((UWorld*)Self)->UpdateAllReflectionCaptures();
	}

	DOTNET_EXPORT void E_UWorld_UpdateAllSkyCaptures(INT_PTR Self)
	{
		((UWorld*)Self)->UpdateAllSkyCaptures();
	}

	DOTNET_EXPORT void E_UWorld_UpdateCullDistanceVolumes(INT_PTR Self, AActor* ActorToUpdate, UPrimitiveComponent* ComponentToUpdate)
	{
		auto _p0 = ActorToUpdate;
		auto _p1 = ComponentToUpdate;
		((UWorld*)Self)->UpdateCullDistanceVolumes(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_UpdateLevelStreaming(INT_PTR Self)
	{
		((UWorld*)Self)->UpdateLevelStreaming();
	}

	DOTNET_EXPORT void E_UWorld_UpdateParameterCollectionInstances(INT_PTR Self, bool bUpdateInstanceUniformBuffers)
	{
		auto _p0 = bUpdateInstanceUniformBuffers;
		((UWorld*)Self)->UpdateParameterCollectionInstances(_p0);
	}

	DOTNET_EXPORT void E_UWorld_UpdateWorldComponents(INT_PTR Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly)
	{
		auto _p0 = bRerunConstructionScripts;
		auto _p1 = bCurrentLevelOnly;
		((UWorld*)Self)->UpdateWorldComponents(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_UsesGameHiddenFlags(INT_PTR Self)
	{
		return ((UWorld*)Self)->UsesGameHiddenFlags();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
