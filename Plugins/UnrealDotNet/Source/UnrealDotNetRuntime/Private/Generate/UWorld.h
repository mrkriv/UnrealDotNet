#pragma once

#include "CoreMinimal.h"
#include "Engine/World.h"

extern "C"
{
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
