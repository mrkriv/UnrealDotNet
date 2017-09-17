#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/SkinnedMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT float E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->CapsuleIndirectShadowMinVisibility; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(INT_PTR Ptr, float Value) { ((USkinnedMeshComponent*)Ptr)->CapsuleIndirectShadowMinVisibility = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_USkinnedMeshComponent_CustomSortAlternateIndexMode_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->CustomSortAlternateIndexMode; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CustomSortAlternateIndexMode_SET(INT_PTR Ptr, uint8 Value) { ((USkinnedMeshComponent*)Ptr)->CustomSortAlternateIndexMode = Value; }
	
	DOTNET_EXPORT int32 E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->ForcedLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(INT_PTR Ptr, int32 Value) { ((USkinnedMeshComponent*)Ptr)->ForcedLodModel = Value; }
	
	DOTNET_EXPORT float E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->MaxDistanceFactor; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(INT_PTR Ptr, float Value) { ((USkinnedMeshComponent*)Ptr)->MaxDistanceFactor = Value; }
	
	DOTNET_EXPORT int32 E_PROP_USkinnedMeshComponent_MinLodModel_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->MinLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MinLodModel_SET(INT_PTR Ptr, int32 Value) { ((USkinnedMeshComponent*)Ptr)->MinLodModel = Value; }
	
	DOTNET_EXPORT int32 E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->OldPredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_SET(INT_PTR Ptr, int32 Value) { ((USkinnedMeshComponent*)Ptr)->OldPredictedLODLevel = Value; }
	
	DOTNET_EXPORT int32 E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->PredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(INT_PTR Ptr, int32 Value) { ((USkinnedMeshComponent*)Ptr)->PredictedLODLevel = Value; }
	
	DOTNET_EXPORT float E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(INT_PTR Ptr) { return ((USkinnedMeshComponent*)Ptr)->StreamingDistanceMultiplier; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(INT_PTR Ptr, float Value) { ((USkinnedMeshComponent*)Ptr)->StreamingDistanceMultiplier = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkinnedMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkinnedMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_ClearRefPoseOverride(INT_PTR Self)
	{
		((USkinnedMeshComponent*)Self)->ClearRefPoseOverride();
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_ClearSkinWeightOverride(INT_PTR Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		((USkinnedMeshComponent*)Self)->ClearSkinWeightOverride(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_ClearVertexColorOverride(INT_PTR Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		((USkinnedMeshComponent*)Self)->ClearVertexColorOverride(_p0);
	}

	DOTNET_EXPORT int32 E_USkinnedMeshComponent_GetBoneIndex(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return ((USkinnedMeshComponent*)Self)->GetBoneIndex(_p0);
	}

	DOTNET_EXPORT char* E_USkinnedMeshComponent_GetBoneName(INT_PTR Self, int32 BoneIndex, int& ResultStringLen)
	{
		auto _p0 = BoneIndex;
		auto _result = ((USkinnedMeshComponent*)Self)->GetBoneName(_p0).ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT int32 E_USkinnedMeshComponent_GetNumBones(INT_PTR Self)
	{
		return ((USkinnedMeshComponent*)Self)->GetNumBones();
	}

	DOTNET_EXPORT char* E_USkinnedMeshComponent_GetParentBone(INT_PTR Self, char* BoneName, int& ResultStringLen)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _result = ((USkinnedMeshComponent*)Self)->GetParentBone(_p0).ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_USkinnedMeshComponent_GetSocketBoneName(INT_PTR Self, char* InSocketName, int& ResultStringLen)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InSocketName));
		auto _result = ((USkinnedMeshComponent*)Self)->GetSocketBoneName(_p0).ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((USkinnedMeshComponent*)Self)->SetCapsuleIndirectShadowMinVisibility(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((USkinnedMeshComponent*)Self)->SetCastCapsuleDirectShadow(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((USkinnedMeshComponent*)Self)->SetCastCapsuleIndirectShadow(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetForcedLOD(INT_PTR Self, int32 InNewForcedLOD)
	{
		auto _p0 = InNewForcedLOD;
		((USkinnedMeshComponent*)Self)->SetForcedLOD(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetForceWireframe(INT_PTR Self, bool InForceWireframe)
	{
		auto _p0 = InForceWireframe;
		((USkinnedMeshComponent*)Self)->SetForceWireframe(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetMaterialPreview(INT_PTR Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		((USkinnedMeshComponent*)Self)->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetMinLOD(INT_PTR Self, int32 InNewMinLOD)
	{
		auto _p0 = InNewMinLOD;
		((USkinnedMeshComponent*)Self)->SetMinLOD(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_SetSectionPreview(INT_PTR Self, int32 InSectionIndexPreview)
	{
		auto _p0 = InSectionIndexPreview;
		((USkinnedMeshComponent*)Self)->SetSectionPreview(_p0);
	}

	DOTNET_EXPORT void E_USkinnedMeshComponent_UpdateRecomputeTangent(INT_PTR Self, int32 MaterialIndex, int32 LodIndex, bool bRecomputeTangentValue)
	{
		auto _p0 = MaterialIndex;
		auto _p1 = LodIndex;
		auto _p2 = bRecomputeTangentValue;
		((USkinnedMeshComponent*)Self)->UpdateRecomputeTangent(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
