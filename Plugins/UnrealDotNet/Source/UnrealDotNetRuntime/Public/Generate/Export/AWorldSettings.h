#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
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
		Self->AWorldSettings::NotifyBeginPlay();
	}

	DOTNET_EXPORT auto E_AWorldSettings_NotifyMatchStarted(AWorldSettings* Self)
	{
		Self->AWorldSettings::NotifyMatchStarted();
	}

	DOTNET_EXPORT auto E_AWorldSettings_OnRep_WorldGravityZ(AWorldSettings* Self)
	{
		Self->AWorldSettings::OnRep_WorldGravityZ();
	}

	DOTNET_EXPORT auto E_AWorldSettings_SetTimeDilation(AWorldSettings* Self, float NewTimeDilation)
	{
		auto _p0 = NewTimeDilation;
		return Self->SetTimeDilation(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
