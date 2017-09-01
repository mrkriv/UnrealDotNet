#pragma once

#include "CoreMinimal.h"
#include "Engine/Level.h"

extern "C"
{
	DOTNET_EXPORT UWorld* E_PROP_ULevel_OwningWorld_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->OwningWorld; }
	DOTNET_EXPORT void E_PROP_ULevel_OwningWorld_SET(INT_PTR Ptr, UWorld* Value) { ((ULevel*)Ptr)->OwningWorld = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->NumTextureStreamingUnbuiltComponents; }
	DOTNET_EXPORT void E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_SET(INT_PTR Ptr, int32 Value) { ((ULevel*)Ptr)->NumTextureStreamingUnbuiltComponents = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ULevel_NumTextureStreamingDirtyResources_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->NumTextureStreamingDirtyResources; }
	DOTNET_EXPORT void E_PROP_ULevel_NumTextureStreamingDirtyResources_SET(INT_PTR Ptr, int32 Value) { ((ULevel*)Ptr)->NumTextureStreamingDirtyResources = Value; }
	
	DOTNET_EXPORT float E_PROP_ULevel_LightmapTotalSize_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->LightmapTotalSize; }
	DOTNET_EXPORT void E_PROP_ULevel_LightmapTotalSize_SET(INT_PTR Ptr, float Value) { ((ULevel*)Ptr)->LightmapTotalSize = Value; }
	
	DOTNET_EXPORT float E_PROP_ULevel_ShadowmapTotalSize_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->ShadowmapTotalSize; }
	DOTNET_EXPORT void E_PROP_ULevel_ShadowmapTotalSize_SET(INT_PTR Ptr, float Value) { ((ULevel*)Ptr)->ShadowmapTotalSize = Value; }
	
	DOTNET_EXPORT FPrecomputedVisibilityHandler E_PROP_ULevel_PrecomputedVisibilityHandler_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->PrecomputedVisibilityHandler; }
	DOTNET_EXPORT void E_PROP_ULevel_PrecomputedVisibilityHandler_SET(INT_PTR Ptr, FPrecomputedVisibilityHandler Value) { ((ULevel*)Ptr)->PrecomputedVisibilityHandler = Value; }
	
	DOTNET_EXPORT FPrecomputedVolumeDistanceField E_PROP_ULevel_PrecomputedVolumeDistanceField_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->PrecomputedVolumeDistanceField; }
	DOTNET_EXPORT void E_PROP_ULevel_PrecomputedVolumeDistanceField_SET(INT_PTR Ptr, FPrecomputedVolumeDistanceField Value) { ((ULevel*)Ptr)->PrecomputedVolumeDistanceField = Value; }
	
	DOTNET_EXPORT bool E_PROP_ULevel_bIsLightingScenario_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bIsLightingScenario; }
	DOTNET_EXPORT void E_PROP_ULevel_bIsLightingScenario_SET(INT_PTR Ptr, bool Value) { ((ULevel*)Ptr)->bIsLightingScenario = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAreComponentsCurrentlyRegistered_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAreComponentsCurrentlyRegistered; }
	DOTNET_EXPORT void E_PROP_ULevel_bAreComponentsCurrentlyRegistered_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAreComponentsCurrentlyRegistered = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bGeometryDirtyForLighting_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bGeometryDirtyForLighting; }
	DOTNET_EXPORT void E_PROP_ULevel_bGeometryDirtyForLighting_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bGeometryDirtyForLighting = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bTextureStreamingRotationChanged_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bTextureStreamingRotationChanged; }
	DOTNET_EXPORT void E_PROP_ULevel_bTextureStreamingRotationChanged_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bTextureStreamingRotationChanged = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bIsVisible_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bIsVisible; }
	DOTNET_EXPORT void E_PROP_ULevel_bIsVisible_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bIsVisible = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bLocked_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bLocked; }
	DOTNET_EXPORT void E_PROP_ULevel_bLocked_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bLocked = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyMovedActors_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyMovedActors; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyMovedActors_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyMovedActors = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyShiftedActors_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyShiftedActors; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyShiftedActors_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyShiftedActors = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyUpdatedComponents_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyUpdatedComponents; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyUpdatedComponents_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyUpdatedComponents = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyAssociatedStreamableResources_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyAssociatedStreamableResources; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyAssociatedStreamableResources_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyAssociatedStreamableResources = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyInitializedNetworkActors_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyInitializedNetworkActors; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyInitializedNetworkActors_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyInitializedNetworkActors = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadyRoutedActorInitialize_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadyRoutedActorInitialize; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadyRoutedActorInitialize_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadyRoutedActorInitialize = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bAlreadySortedActorList_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bAlreadySortedActorList; }
	DOTNET_EXPORT void E_PROP_ULevel_bAlreadySortedActorList_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bAlreadySortedActorList = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bIsAssociatingLevel_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bIsAssociatingLevel; }
	DOTNET_EXPORT void E_PROP_ULevel_bIsAssociatingLevel_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bIsAssociatingLevel = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bRequireFullVisibilityToRender_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bRequireFullVisibilityToRender; }
	DOTNET_EXPORT void E_PROP_ULevel_bRequireFullVisibilityToRender_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bRequireFullVisibilityToRender = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bClientOnlyVisible_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bClientOnlyVisible; }
	DOTNET_EXPORT void E_PROP_ULevel_bClientOnlyVisible_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bClientOnlyVisible = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bWasDuplicatedForPIE_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bWasDuplicatedForPIE; }
	DOTNET_EXPORT void E_PROP_ULevel_bWasDuplicatedForPIE_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bWasDuplicatedForPIE = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bIsBeingRemoved_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bIsBeingRemoved; }
	DOTNET_EXPORT void E_PROP_ULevel_bIsBeingRemoved_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bIsBeingRemoved = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bHasRerunConstructionScripts_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bHasRerunConstructionScripts; }
	DOTNET_EXPORT void E_PROP_ULevel_bHasRerunConstructionScripts_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bHasRerunConstructionScripts = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_ULevel_bActorClusterCreated_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->bActorClusterCreated; }
	DOTNET_EXPORT void E_PROP_ULevel_bActorClusterCreated_SET(INT_PTR Ptr, uint8 Value) { ((ULevel*)Ptr)->bActorClusterCreated = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ULevel_CurrentActorIndexForUpdateComponents_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->CurrentActorIndexForUpdateComponents; }
	DOTNET_EXPORT void E_PROP_ULevel_CurrentActorIndexForUpdateComponents_SET(INT_PTR Ptr, int32 Value) { ((ULevel*)Ptr)->CurrentActorIndexForUpdateComponents = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_GET(INT_PTR Ptr) { return ((ULevel*)Ptr)->CurrentActorIndexForUnregisterComponents; }
	DOTNET_EXPORT void E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_SET(INT_PTR Ptr, int32 Value) { ((ULevel*)Ptr)->CurrentActorIndexForUnregisterComponents = Value; }
	
	DOTNET_EXPORT bool E_ULevel_HasVisibilityRequestPending(INT_PTR Self)
	{
		return ((ULevel*)Self)->HasVisibilityRequestPending();
	}

	DOTNET_EXPORT void E_ULevel_BroadcastLevelBoundsActorUpdated(INT_PTR Self)
	{
		((ULevel*)Self)->BroadcastLevelBoundsActorUpdated();
	}

	DOTNET_EXPORT bool E_ULevel_IsNetActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return ((ULevel*)Self)->IsNetActor(_p0);
	}

	DOTNET_EXPORT void E_ULevel_IncrementalUpdateComponents(INT_PTR Self, int32 NumComponentsToUpdate, bool bRerunConstructionScripts)
	{
		auto _p0 = NumComponentsToUpdate;
		auto _p1 = bRerunConstructionScripts;
		((ULevel*)Self)->IncrementalUpdateComponents(_p0, _p1);
	}

	DOTNET_EXPORT bool E_ULevel_IncrementalUnregisterComponents(INT_PTR Self, int32 NumComponentsToUnregister)
	{
		auto _p0 = NumComponentsToUnregister;
		return ((ULevel*)Self)->IncrementalUnregisterComponents(_p0);
	}

	DOTNET_EXPORT void E_ULevel_ApplyWorldOffset(INT_PTR Self, INT_PTR InWorldOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InWorldOffset;
		auto _p1 = bWorldShift;
		((ULevel*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_ULevel_RegisterActorForAutoReceiveInput(INT_PTR Self, AActor* Actor, int32 PlayerIndex)
	{
		auto _p0 = Actor;
		auto _p1 = PlayerIndex;
		((ULevel*)Self)->RegisterActorForAutoReceiveInput(_p0, _p1);
	}

}
