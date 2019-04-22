#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:195

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_ActiveMorphTargets_GET(USkinnedMeshComponent* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActiveMorphTargets); }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_ActiveMorphTargets_SET(USkinnedMeshComponent* Ptr, INT_PTR Value) { Ptr->ActiveMorphTargets = *(TArray<FActiveMorphTarget>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->ForcedLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->ForcedLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_LODInfo_GET(USkinnedMeshComponent* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->LODInfo); }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_LODInfo_SET(USkinnedMeshComponent* Ptr, INT_PTR Value) { Ptr->LODInfo = *(TArray<FSkelMeshComponentLODInfo>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(USkinnedMeshComponent* Ptr) { return Ptr->MaxDistanceFactor; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->MaxDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MinLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->MinLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MinLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->MinLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MorphTargetWeights_GET(USkinnedMeshComponent* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->MorphTargetWeights); }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MorphTargetWeights_SET(USkinnedMeshComponent* Ptr, INT_PTR Value) { Ptr->MorphTargetWeights = *(TArray<float>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(USkinnedMeshComponent* Ptr) { return Ptr->PredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->PredictedLODLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(USkinnedMeshComponent* Ptr) { return Ptr->StreamingDistanceMultiplier; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->StreamingDistanceMultiplier = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_GET(USkinnedMeshComponent* Ptr) { return Ptr->VisibilityBasedAnimTickOption; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_SET(USkinnedMeshComponent* Ptr, EVisibilityBasedAnimTickOption Value) { Ptr->VisibilityBasedAnimTickOption = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkinnedMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkinnedMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetMasterBoneMap(USkinnedMeshComponent* Self)
	{
		return ConvertToManage_TemplatePointerDescription(Self->GetMasterBoneMap());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
