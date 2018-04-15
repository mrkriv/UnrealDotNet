#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCanHighlightSelectedSections; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCanHighlightSelectedSections = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCastCapsuleDirectShadow; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCastCapsuleDirectShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCastCapsuleIndirectShadow; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCastCapsuleIndirectShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_GET(USkinnedMeshComponent* Ptr) { return Ptr->bComponentUseFixedSkelBounds; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bComponentUseFixedSkelBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_GET(USkinnedMeshComponent* Ptr) { return Ptr->bConsiderAllBodiesForBounds; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bConsiderAllBodiesForBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCPUSkinning_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCPUSkinning; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCPUSkinning_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCPUSkinning = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisableMorphTarget_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisableMorphTarget; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisableMorphTarget_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisableMorphTarget = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisplayBones_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisplayBones_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisplayDebugUpdateRateOptimizations; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisplayDebugUpdateRateOptimizations = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_GET(USkinnedMeshComponent* Ptr) { return Ptr->bEnableUpdateRateOptimizations; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bEnableUpdateRateOptimizations = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bForceWireframe_GET(USkinnedMeshComponent* Ptr) { return Ptr->bForceWireframe; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bForceWireframe_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bForceWireframe = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bHideSkin_GET(USkinnedMeshComponent* Ptr) { return Ptr->bHideSkin; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bHideSkin_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bHideSkin = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_GET(USkinnedMeshComponent* Ptr) { return Ptr->bPerBoneMotionBlur; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bPerBoneMotionBlur = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bRecentlyRendered_GET(USkinnedMeshComponent* Ptr) { return Ptr->bRecentlyRendered; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bRecentlyRendered_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bRecentlyRendered = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_GET(USkinnedMeshComponent* Ptr) { return Ptr->bUseBoundsFromMasterPoseComponent; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bUseBoundsFromMasterPoseComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(USkinnedMeshComponent* Ptr) { return Ptr->CapsuleIndirectShadowMinVisibility; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->CapsuleIndirectShadowMinVisibility = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->ForcedLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->ForcedLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(USkinnedMeshComponent* Ptr) { return Ptr->MaxDistanceFactor; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->MaxDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MinLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->MinLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MinLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->MinLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_GET(USkinnedMeshComponent* Ptr) { return Ptr->OldPredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->OldPredictedLODLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(USkinnedMeshComponent* Ptr) { return Ptr->PredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->PredictedLODLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(USkinnedMeshComponent* Ptr) { return Ptr->StreamingDistanceMultiplier; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->StreamingDistanceMultiplier = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkinnedMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkinnedMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearRefPoseOverride(USkinnedMeshComponent* Self)
	{
		Self->ClearRefPoseOverride();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearSkinWeightOverride(USkinnedMeshComponent* Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		Self->ClearSkinWeightOverride(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearVertexColorOverride(USkinnedMeshComponent* Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		Self->ClearVertexColorOverride(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetBoneIndex(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetBoneIndex(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetBoneName(USkinnedMeshComponent* Self, int32 BoneIndex)
	{
		auto _p0 = BoneIndex;
		return ConvertToManage_StringWrapper(Self->GetBoneName(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNumBones(USkinnedMeshComponent* Self)
	{
		return Self->GetNumBones();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNumLODs(USkinnedMeshComponent* Self)
	{
		return Self->GetNumLODs();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetParentBone(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return ConvertToManage_StringWrapper(Self->GetParentBone(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketBoneName(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return ConvertToManage_StringWrapper(Self->GetSocketBoneName(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(USkinnedMeshComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCapsuleIndirectShadowMinVisibility(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(USkinnedMeshComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastCapsuleDirectShadow(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(USkinnedMeshComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastCapsuleIndirectShadow(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetForcedLOD(USkinnedMeshComponent* Self, int32 InNewForcedLOD)
	{
		auto _p0 = InNewForcedLOD;
		Self->SetForcedLOD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetForceWireframe(USkinnedMeshComponent* Self, bool InForceWireframe)
	{
		auto _p0 = InForceWireframe;
		Self->SetForceWireframe(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMinLOD(USkinnedMeshComponent* Self, int32 InNewMinLOD)
	{
		auto _p0 = InNewMinLOD;
		Self->SetMinLOD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCPUSkin(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCPUSkin();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
