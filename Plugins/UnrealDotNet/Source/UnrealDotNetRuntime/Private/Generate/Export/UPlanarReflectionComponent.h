#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/PlanarReflectionComponent.h"

extern "C"
{
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->AngleFromPlaneFadeEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->AngleFromPlaneFadeEnd = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->AngleFromPlaneFadeStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->AngleFromPlaneFadeStart = Value; }
	
	DOTNET_EXPORT bool E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->bRenderSceneTwoSided; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_SET(INT_PTR Ptr, bool Value) { ((UPlanarReflectionComponent*)Ptr)->bRenderSceneTwoSided = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeEnd_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeEnd_DEPRECATED = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeoutEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeoutEnd = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeoutStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeoutStart = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeStart_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->DistanceFromPlaneFadeStart_DEPRECATED = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_ExtraFOV_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->ExtraFOV; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ExtraFOV_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->ExtraFOV = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->NormalDistortionStrength; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->NormalDistortionStrength = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_PrefilterRoughness_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->PrefilterRoughness; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughness_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->PrefilterRoughness = Value; }
	
	DOTNET_EXPORT float E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->PrefilterRoughnessDistance; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_SET(INT_PTR Ptr, float Value) { ((UPlanarReflectionComponent*)Ptr)->PrefilterRoughnessDistance = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPlanarReflectionComponent_ScreenPercentage_GET(INT_PTR Ptr) { return ((UPlanarReflectionComponent*)Ptr)->ScreenPercentage; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ScreenPercentage_SET(INT_PTR Ptr, int32 Value) { ((UPlanarReflectionComponent*)Ptr)->ScreenPercentage = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlanarReflectionComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlanarReflectionComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT int32 E_UPlanarReflectionComponent_GetPlanarReflectionId(INT_PTR Self)
	{
		return ((UPlanarReflectionComponent*)Self)->GetPlanarReflectionId();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
