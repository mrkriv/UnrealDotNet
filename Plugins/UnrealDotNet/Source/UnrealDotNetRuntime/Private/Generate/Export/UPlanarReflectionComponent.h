#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PlanarReflectionComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PlanarReflectionComponent.h:16

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_GET(UPlanarReflectionComponent* Ptr) { return Ptr->AngleFromPlaneFadeEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->AngleFromPlaneFadeEnd = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_GET(UPlanarReflectionComponent* Ptr) { return Ptr->AngleFromPlaneFadeStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->AngleFromPlaneFadeStart = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_GET(UPlanarReflectionComponent* Ptr) { return Ptr->bRenderSceneTwoSided; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_SET(UPlanarReflectionComponent* Ptr, bool Value) { Ptr->bRenderSceneTwoSided = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeEnd_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeEnd_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeoutEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeoutEnd = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeoutStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeoutStart = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeStart_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeStart_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_ExtraFOV_GET(UPlanarReflectionComponent* Ptr) { return Ptr->ExtraFOV; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ExtraFOV_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->ExtraFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_GET(UPlanarReflectionComponent* Ptr) { return Ptr->NormalDistortionStrength; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->NormalDistortionStrength = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_PrefilterRoughness_GET(UPlanarReflectionComponent* Ptr) { return Ptr->PrefilterRoughness; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughness_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->PrefilterRoughness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_GET(UPlanarReflectionComponent* Ptr) { return Ptr->PrefilterRoughnessDistance; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->PrefilterRoughnessDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_ScreenPercentage_GET(UPlanarReflectionComponent* Ptr) { return Ptr->ScreenPercentage; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ScreenPercentage_SET(UPlanarReflectionComponent* Ptr, int32 Value) { Ptr->ScreenPercentage = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlanarReflectionComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlanarReflectionComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetPlanarReflectionId(UPlanarReflectionComponent* Self)
	{
		return Self->GetPlanarReflectionId();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
