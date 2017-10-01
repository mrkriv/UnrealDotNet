#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
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

	DOTNET_EXPORT void E_UWorld_AddNetworkActor(UWorld* Self, AActor* Actor)
	{
		auto _p0 = Actor;
		(Self)->AddNetworkActor(_p0);
	}

	DOTNET_EXPORT void E_UWorld_AddPawn(UWorld* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		(Self)->AddPawn(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_AllowLevelLoadRequests(UWorld* Self)
	{
		return (Self)->AllowLevelLoadRequests();
	}

	DOTNET_EXPORT bool E_UWorld_AreActorsInitialized(UWorld* Self)
	{
		return (Self)->AreActorsInitialized();
	}

	DOTNET_EXPORT bool E_UWorld_AreAlwaysLoadedLevelsLoaded(UWorld* Self)
	{
		return (Self)->AreAlwaysLoadedLevelsLoaded();
	}

	DOTNET_EXPORT void E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(UWorld* Self)
	{
		(Self)->AsyncLoadAlwaysLoadedLevelsForSeamlessTravel();
	}

	DOTNET_EXPORT ENetMode E_UWorld_AttemptDeriveFromURL(UWorld* Self)
	{
		return (Self)->AttemptDeriveFromURL();
	}

	DOTNET_EXPORT void E_UWorld_BeginPlay(UWorld* Self)
	{
		(Self)->BeginPlay();
	}

	DOTNET_EXPORT void E_UWorld_BroadcastLevelsChanged(UWorld* Self)
	{
		(Self)->BroadcastLevelsChanged();
	}

	DOTNET_EXPORT char* E_UWorld_BuildPIEPackagePrefix(UWorld* Self, int32 PIEInstanceID, int& ResultStringLen)
	{
		auto _p0 = PIEInstanceID;
		auto _result = (Self)->BuildPIEPackagePrefix(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_CancelPendingMapChange(UWorld* Self)
	{
		(Self)->CancelPendingMapChange();
	}

	DOTNET_EXPORT void E_UWorld_CleanupWorld(UWorld* Self, bool bSessionEnded, bool bCleanupResources, UWorld* NewWorld)
	{
		auto _p0 = bSessionEnded;
		auto _p1 = bCleanupResources;
		auto _p2 = NewWorld;
		(Self)->CleanupWorld(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_ClearActorComponentEndOfFrameUpdate(UWorld* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		(Self)->ClearActorComponentEndOfFrameUpdate(_p0);
	}

	DOTNET_EXPORT void E_UWorld_ClearWorldComponents(UWorld* Self)
	{
		(Self)->ClearWorldComponents();
	}

	DOTNET_EXPORT void E_UWorld_CommitMapChange(UWorld* Self)
	{
		(Self)->CommitMapChange();
	}

	DOTNET_EXPORT void E_UWorld_CommitModelSurfaces(UWorld* Self)
	{
		(Self)->CommitModelSurfaces();
	}

	DOTNET_EXPORT void E_UWorld_ConditionallyBuildStreamingData(UWorld* Self)
	{
		(Self)->ConditionallyBuildStreamingData();
	}

	DOTNET_EXPORT bool E_UWorld_ContainsActor(UWorld* Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return (Self)->ContainsActor(_p0);
	}

	DOTNET_EXPORT char* E_UWorld_ConvertToPIEPackageName(UWorld* Self, char* PackageName, int32 PIEInstanceID, int& ResultStringLen)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = PIEInstanceID;
		auto _result = (Self)->ConvertToPIEPackageName(_p0, _p1);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_CreateFXSystem(UWorld* Self)
	{
		(Self)->CreateFXSystem();
	}

	DOTNET_EXPORT void E_UWorld_CreatePhysicsScene(UWorld* Self)
	{
		(Self)->CreatePhysicsScene();
	}

	DOTNET_EXPORT bool E_UWorld_DebugDrawSceneQueries(UWorld* Self, char* UsedTraceTag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(UsedTraceTag));
		return (Self)->DebugDrawSceneQueries(_p0);
	}

	DOTNET_EXPORT void E_UWorld_DelayStreamingVolumeUpdates(UWorld* Self, int32 InFrameDelay)
	{
		auto _p0 = InFrameDelay;
		(Self)->DelayStreamingVolumeUpdates(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_DestroyActor(UWorld* Self, AActor* Actor, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bNetForce;
		auto _p2 = bShouldModifyLevel;
		return (Self)->DestroyActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_DestroyDemoNetDriver(UWorld* Self)
	{
		(Self)->DestroyDemoNetDriver();
	}

	DOTNET_EXPORT void E_UWorld_DuplicateRequestedLevels(UWorld* Self, char* MapName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(MapName));
		(Self)->DuplicateRequestedLevels(_p0);
	}

	DOTNET_EXPORT ObjectPointerDescription E_UWorld_DuplicateWorldForPIE(UWorld* Self, char* PackageName, UWorld* OwningWorld)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = OwningWorld;
		return MakePrtDesc((Self)->DuplicateWorldForPIE(_p0, _p1));
	}

	DOTNET_EXPORT bool E_UWorld_EditorDestroyActor(UWorld* Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		return (Self)->EditorDestroyActor(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_EncroachingBlockingGeometry(UWorld* Self, AActor* TestActor, INT_PTR TestLocation, INT_PTR TestRotation, INT_PTR ProposedAdjustment)
	{
		auto _p0 = TestActor;
		auto _p1 = *(FVector*)TestLocation;
		auto _p2 = *(FRotator*)TestRotation;
		auto _p3 = (FVector*)ProposedAdjustment;
		return (Self)->EncroachingBlockingGeometry(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_UWorld_EnsureCollisionTreeIsBuilt(UWorld* Self)
	{
		(Self)->EnsureCollisionTreeIsBuilt();
	}

	DOTNET_EXPORT bool E_UWorld_FindTeleportSpot(UWorld* Self, AActor* TestActor, INT_PTR PlaceLocation, INT_PTR PlaceRotation)
	{
		auto _p0 = TestActor;
		auto _p1 = *(FVector*)PlaceLocation;
		auto _p2 = *(FRotator*)PlaceRotation;
		return (Self)->FindTeleportSpot(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_FinishPhysicsSim(UWorld* Self)
	{
		(Self)->FinishPhysicsSim();
	}

	DOTNET_EXPORT void E_UWorld_ForceGarbageCollection(UWorld* Self, bool bFullPurge)
	{
		auto _p0 = bFullPurge;
		(Self)->ForceGarbageCollection(_p0);
	}

	DOTNET_EXPORT int32 E_UWorld_GetActorCount(UWorld* Self)
	{
		return (Self)->GetActorCount();
	}

	DOTNET_EXPORT float E_UWorld_GetAudioTimeSeconds(UWorld* Self)
	{
		return (Self)->GetAudioTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetDefaultGravityZ(UWorld* Self)
	{
		return (Self)->GetDefaultGravityZ();
	}

	DOTNET_EXPORT float E_UWorld_GetDeltaSeconds(UWorld* Self)
	{
		return (Self)->GetDeltaSeconds();
	}

	DOTNET_EXPORT int32 E_UWorld_GetDetailMode(UWorld* Self)
	{
		return (Self)->GetDetailMode();
	}

	DOTNET_EXPORT float E_UWorld_GetGravityZ(UWorld* Self)
	{
		return (Self)->GetGravityZ();
	}

	DOTNET_EXPORT float E_UWorld_GetMonoFarFieldCullingDistance(UWorld* Self)
	{
		return (Self)->GetMonoFarFieldCullingDistance();
	}

	DOTNET_EXPORT ENetMode E_UWorld_GetNetMode(UWorld* Self)
	{
		return (Self)->GetNetMode();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNonDefaultPhysicsVolumeCount(UWorld* Self)
	{
		return (Self)->GetNonDefaultPhysicsVolumeCount();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumLevels(UWorld* Self)
	{
		return (Self)->GetNumLevels();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumPawns(UWorld* Self)
	{
		return (Self)->GetNumPawns();
	}

	DOTNET_EXPORT int32 E_UWorld_GetProgressDenominator(UWorld* Self)
	{
		return (Self)->GetProgressDenominator();
	}

	DOTNET_EXPORT float E_UWorld_GetRealTimeSeconds(UWorld* Self)
	{
		return (Self)->GetRealTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetTimeSeconds(UWorld* Self)
	{
		return (Self)->GetTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_GetUnpausedTimeSeconds(UWorld* Self)
	{
		return (Self)->GetUnpausedTimeSeconds();
	}

	DOTNET_EXPORT bool E_UWorld_HasBegunPlay(UWorld* Self)
	{
		return (Self)->HasBegunPlay();
	}

	DOTNET_EXPORT bool E_UWorld_HasDefaultPhysicsVolume(UWorld* Self)
	{
		return (Self)->HasDefaultPhysicsVolume();
	}

	DOTNET_EXPORT bool E_UWorld_HasEndOfFrameUpdates(UWorld* Self)
	{
		return (Self)->HasEndOfFrameUpdates();
	}

	DOTNET_EXPORT void E_UWorld_InitializeActorsForPlay(UWorld* Self, INT_PTR InURL, bool bResetTime)
	{
		auto _p0 = *(FURL*)InURL;
		auto _p1 = bResetTime;
		(Self)->InitializeActorsForPlay(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_InvalidateModelSurface(UWorld* Self, bool bCurrentLevelOnly)
	{
		auto _p0 = bCurrentLevelOnly;
		(Self)->InvalidateModelSurface(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_IsCameraMoveable(UWorld* Self)
	{
		return (Self)->IsCameraMoveable();
	}

	DOTNET_EXPORT bool E_UWorld_IsClient(UWorld* Self)
	{
		return (Self)->IsClient();
	}

	DOTNET_EXPORT bool E_UWorld_IsEditorWorld(UWorld* Self)
	{
		return (Self)->IsEditorWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsGameWorld(UWorld* Self)
	{
		return (Self)->IsGameWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsInSeamlessTravel(UWorld* Self)
	{
		return (Self)->IsInSeamlessTravel();
	}

	DOTNET_EXPORT bool E_UWorld_IsMapChangeReady(UWorld* Self)
	{
		return (Self)->IsMapChangeReady();
	}

	DOTNET_EXPORT bool E_UWorld_IsNavigationRebuilt(UWorld* Self)
	{
		return (Self)->IsNavigationRebuilt();
	}

	DOTNET_EXPORT bool E_UWorld_IsNetMode(UWorld* Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return (Self)->IsNetMode(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_IsPaused(UWorld* Self)
	{
		return (Self)->IsPaused();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInEditor(UWorld* Self)
	{
		return (Self)->IsPlayInEditor();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayingReplay(UWorld* Self)
	{
		return (Self)->IsPlayingReplay();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInMobilePreview(UWorld* Self)
	{
		return (Self)->IsPlayInMobilePreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInPreview(UWorld* Self)
	{
		return (Self)->IsPlayInPreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPlayInVulkanPreview(UWorld* Self)
	{
		return (Self)->IsPlayInVulkanPreview();
	}

	DOTNET_EXPORT bool E_UWorld_IsPreparingMapChange(UWorld* Self)
	{
		return (Self)->IsPreparingMapChange();
	}

	DOTNET_EXPORT bool E_UWorld_IsPreviewWorld(UWorld* Self)
	{
		return (Self)->IsPreviewWorld();
	}

	DOTNET_EXPORT bool E_UWorld_IsRecordingClientReplay(UWorld* Self)
	{
		return (Self)->IsRecordingClientReplay();
	}

	DOTNET_EXPORT bool E_UWorld_IsServer(UWorld* Self)
	{
		return (Self)->IsServer();
	}

	DOTNET_EXPORT bool E_UWorld_IsVisibilityRequestPending(UWorld* Self)
	{
		return (Self)->IsVisibilityRequestPending();
	}

	DOTNET_EXPORT bool E_UWorld_Listen(UWorld* Self, INT_PTR InURL)
	{
		auto _p0 = *(FURL*)InURL;
		return (Self)->Listen(_p0);
	}

	DOTNET_EXPORT void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(UWorld* Self, UActorComponent* Component, bool bForceGameThread)
	{
		auto _p0 = Component;
		auto _p1 = bForceGameThread;
		(Self)->MarkActorComponentForNeededEndOfFrameUpdate(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_ProcessLevelStreamingVolumes(UWorld* Self, INT_PTR OverrideViewLocation)
	{
		auto _p0 = (FVector*)OverrideViewLocation;
		(Self)->ProcessLevelStreamingVolumes(_p0);
	}

	DOTNET_EXPORT void E_UWorld_PropagateLightingScenarioChange(UWorld* Self, bool bLevelWasMadeVisible)
	{
		auto _p0 = bLevelWasMadeVisible;
		(Self)->PropagateLightingScenarioChange(_p0);
	}

	DOTNET_EXPORT void E_UWorld_RemoveActor(UWorld* Self, AActor* Actor, bool bShouldModifyLevel)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldModifyLevel;
		(Self)->RemoveActor(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_RemoveNetworkActor(UWorld* Self, AActor* Actor)
	{
		auto _p0 = Actor;
		(Self)->RemoveNetworkActor(_p0);
	}

	DOTNET_EXPORT void E_UWorld_RemovePawn(UWorld* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		(Self)->RemovePawn(_p0);
	}

	DOTNET_EXPORT char* E_UWorld_RemovePIEPrefix(UWorld* Self, char* Source, int& ResultStringLen)
	{
		auto _p0 = FString(Source);
		auto _result = (Self)->RemovePIEPrefix(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_RenameToPIEWorld(UWorld* Self, int32 PIEInstanceID)
	{
		auto _p0 = PIEInstanceID;
		(Self)->RenameToPIEWorld(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_RequiresHitProxies(UWorld* Self)
	{
		return (Self)->RequiresHitProxies();
	}

	DOTNET_EXPORT void E_UWorld_RunTickGroup(UWorld* Self, ETickingGroup Group, bool bBlockTillComplete)
	{
		auto _p0 = Group;
		auto _p1 = bBlockTillComplete;
		(Self)->RunTickGroup(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_SendAllEndOfFrameUpdates(UWorld* Self)
	{
		(Self)->SendAllEndOfFrameUpdates();
	}

	DOTNET_EXPORT bool E_UWorld_SetGameMode(UWorld* Self, INT_PTR InURL)
	{
		auto _p0 = *(FURL*)InURL;
		return (Self)->SetGameMode(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetMapNeedsLightingFullyRebuilt(UWorld* Self, int32 InNumLightingUnbuiltObjects)
	{
		auto _p0 = InNumLightingUnbuiltObjects;
		(Self)->SetMapNeedsLightingFullyRebuilt(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetSeamlessTravelMidpointPause(UWorld* Self, bool bNowPaused)
	{
		auto _p0 = bNowPaused;
		(Self)->SetSeamlessTravelMidpointPause(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetShouldTick(UWorld* Self, bool bInShouldTick)
	{
		auto _p0 = bInShouldTick;
		(Self)->SetShouldTick(_p0);
	}

	DOTNET_EXPORT void E_UWorld_SetupParameterCollectionInstances(UWorld* Self)
	{
		(Self)->SetupParameterCollectionInstances();
	}

	DOTNET_EXPORT void E_UWorld_SetupPhysicsTickFunctions(UWorld* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		(Self)->SetupPhysicsTickFunctions(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ShouldTick(UWorld* Self)
	{
		return (Self)->ShouldTick();
	}

	DOTNET_EXPORT void E_UWorld_StartPhysicsSim(UWorld* Self)
	{
		(Self)->StartPhysicsSim();
	}

	DOTNET_EXPORT char* E_UWorld_StripPIEPrefixFromPackageName(UWorld* Self, char* PackageName, char* Prefix, int& ResultStringLen)
	{
		auto _p0 = FString(PackageName);
		auto _p1 = FString(Prefix);
		auto _result = (Self)->StripPIEPrefixFromPackageName(_p0, _p1);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UWorld_Tick(UWorld* Self, ELevelTick TickType, float DeltaSeconds)
	{
		auto _p0 = TickType;
		auto _p1 = DeltaSeconds;
		(Self)->Tick(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_TickNetClient(UWorld* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		(Self)->TickNetClient(_p0);
	}

	DOTNET_EXPORT float E_UWorld_TimeSince(UWorld* Self, float Time)
	{
		auto _p0 = Time;
		return (Self)->TimeSince(_p0);
	}

	DOTNET_EXPORT void E_UWorld_TransferBlueprintDebugReferences(UWorld* Self, UWorld* NewWorld)
	{
		auto _p0 = NewWorld;
		(Self)->TransferBlueprintDebugReferences(_p0);
	}

	DOTNET_EXPORT void E_UWorld_TriggerStreamingDataRebuild(UWorld* Self)
	{
		(Self)->TriggerStreamingDataRebuild();
	}

	DOTNET_EXPORT void E_UWorld_UpdateActorComponentEndOfFrameUpdateState(UWorld* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		(Self)->UpdateActorComponentEndOfFrameUpdateState(_p0);
	}

	DOTNET_EXPORT void E_UWorld_UpdateAllReflectionCaptures(UWorld* Self)
	{
		(Self)->UpdateAllReflectionCaptures();
	}

	DOTNET_EXPORT void E_UWorld_UpdateAllSkyCaptures(UWorld* Self)
	{
		(Self)->UpdateAllSkyCaptures();
	}

	DOTNET_EXPORT void E_UWorld_UpdateCullDistanceVolumes(UWorld* Self, AActor* ActorToUpdate, UPrimitiveComponent* ComponentToUpdate)
	{
		auto _p0 = ActorToUpdate;
		auto _p1 = ComponentToUpdate;
		(Self)->UpdateCullDistanceVolumes(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_UpdateLevelStreaming(UWorld* Self)
	{
		(Self)->UpdateLevelStreaming();
	}

	DOTNET_EXPORT void E_UWorld_UpdateParameterCollectionInstances(UWorld* Self, bool bUpdateInstanceUniformBuffers)
	{
		auto _p0 = bUpdateInstanceUniformBuffers;
		(Self)->UpdateParameterCollectionInstances(_p0);
	}

	DOTNET_EXPORT void E_UWorld_UpdateWorldComponents(UWorld* Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly)
	{
		auto _p0 = bRerunConstructionScripts;
		auto _p1 = bCurrentLevelOnly;
		(Self)->UpdateWorldComponents(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UWorld_UsesGameHiddenFlags(UWorld* Self)
	{
		return (Self)->UsesGameHiddenFlags();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
