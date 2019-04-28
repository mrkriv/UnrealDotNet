#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/DirectionalLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_GET(UDirectionalLightComponent* Ptr) { return Ptr->CascadeDistributionExponent; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->CascadeDistributionExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_GET(UDirectionalLightComponent* Ptr) { return Ptr->CascadeTransitionFraction; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->CascadeTransitionFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->DistanceFieldShadowDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DistanceFieldShadowDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowCascades_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowCascades; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowCascades_SET(UDirectionalLightComponent* Ptr, int32 Value) { Ptr->DynamicShadowCascades = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowDistanceMovableLight; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DynamicShadowDistanceMovableLight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowDistanceStationaryLight; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DynamicShadowDistanceStationaryLight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_GET(UDirectionalLightComponent* Ptr) { return Ptr->FarShadowCascadeCount; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_SET(UDirectionalLightComponent* Ptr, int32 Value) { Ptr->FarShadowCascadeCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_FarShadowDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->FarShadowDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_FarShadowDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->FarShadowDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightmassSettings_GET(UDirectionalLightComponent* Ptr) { return (INT_PTR)&(Ptr->LightmassSettings); }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightmassSettings_SET(UDirectionalLightComponent* Ptr, INT_PTR Value) { Ptr->LightmassSettings = *(FLightmassDirectionalLightSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_GET(UDirectionalLightComponent* Ptr) { return (INT_PTR)&(Ptr->LightShaftOverrideDirection); }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_SET(UDirectionalLightComponent* Ptr, INT_PTR Value) { Ptr->LightShaftOverrideDirection = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightSourceAngle_GET(UDirectionalLightComponent* Ptr) { return Ptr->LightSourceAngle; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightSourceAngle_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->LightSourceAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_GET(UDirectionalLightComponent* Ptr) { return Ptr->LightSourceSoftAngle; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->LightSourceSoftAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_OcclusionDepthRange_GET(UDirectionalLightComponent* Ptr) { return Ptr->OcclusionDepthRange; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_OcclusionDepthRange_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->OcclusionDepthRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_GET(UDirectionalLightComponent* Ptr) { return Ptr->OcclusionMaskDarkness; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->OcclusionMaskDarkness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_GET(UDirectionalLightComponent* Ptr) { return Ptr->ShadowDistanceFadeoutFraction; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->ShadowDistanceFadeoutFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_TraceDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->TraceDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_TraceDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->TraceDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_GET(UDirectionalLightComponent* Ptr) { return Ptr->WholeSceneDynamicShadowRadius_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->WholeSceneDynamicShadowRadius_DEPRECATED = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDirectionalLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDirectionalLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetCascadeDistributionExponent(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCascadeDistributionExponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetCascadeTransitionFraction(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCascadeTransitionFraction(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowCascades(UDirectionalLightComponent* Self, int32 NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowCascades(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowDistanceMovableLight(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowDistanceMovableLight(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowDistanceStationaryLight(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowDistanceStationaryLight(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetEnableLightShaftOcclusion(UDirectionalLightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetEnableLightShaftOcclusion(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetLightShaftOverrideDirection(UDirectionalLightComponent* Self, INT_PTR NewValue)
	{
		auto _p0 = *(FVector*)NewValue;
		Self->SetLightShaftOverrideDirection(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetOcclusionMaskDarkness(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetOcclusionMaskDarkness(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetShadowDistanceFadeoutFraction(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetShadowDistanceFadeoutFraction(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
