#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/SkinnedMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(USkinnedMeshComponent* Ptr) { return Ptr->CapsuleIndirectShadowMinVisibility; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->CapsuleIndirectShadowMinVisibility = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_CustomSortAlternateIndexMode_GET(USkinnedMeshComponent* Ptr) { return Ptr->CustomSortAlternateIndexMode; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CustomSortAlternateIndexMode_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->CustomSortAlternateIndexMode = Value; }
	
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

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetParentBone(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return ConvertToManage_StringWrapper(Self->GetParentBone(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSkinnedVertexPosition(USkinnedMeshComponent* Self, int32 VertexIndex)
	{
		auto _p0 = VertexIndex;
		return (INT_PTR) new FVector(Self->GetSkinnedVertexPosition(_p0));
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

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMaterialPreview(USkinnedMeshComponent* Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		Self->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMinLOD(USkinnedMeshComponent* Self, int32 InNewMinLOD)
	{
		auto _p0 = InNewMinLOD;
		Self->SetMinLOD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetSectionPreview(USkinnedMeshComponent* Self, int32 InSectionIndexPreview)
	{
		auto _p0 = InSectionIndexPreview;
		Self->SetSectionPreview(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCPUSkin(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCPUSkin();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UpdateRecomputeTangent(USkinnedMeshComponent* Self, int32 MaterialIndex, int32 LodIndex, bool bRecomputeTangentValue)
	{
		auto _p0 = MaterialIndex;
		auto _p1 = LodIndex;
		auto _p2 = bRecomputeTangentValue;
		Self->UpdateRecomputeTangent(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
