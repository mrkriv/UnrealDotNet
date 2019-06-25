#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LocalLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LocalLightComponent.h:17

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULocalLightComponent_AttenuationRadius_GET(ULocalLightComponent* Ptr) { return Ptr->AttenuationRadius; }
	DOTNET_EXPORT void E_PROP_ULocalLightComponent_AttenuationRadius_SET(ULocalLightComponent* Ptr, float Value) { Ptr->AttenuationRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalLightComponent_IntensityUnits_GET(ULocalLightComponent* Ptr) { return Ptr->IntensityUnits; }
	DOTNET_EXPORT void E_PROP_ULocalLightComponent_IntensityUnits_SET(ULocalLightComponent* Ptr, ELightUnits Value) { Ptr->IntensityUnits = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalLightComponent_LightmassSettings_GET(ULocalLightComponent* Ptr) { return (INT_PTR)&(Ptr->LightmassSettings); }
	DOTNET_EXPORT void E_PROP_ULocalLightComponent_LightmassSettings_SET(ULocalLightComponent* Ptr, INT_PTR Value) { Ptr->LightmassSettings = *(FLightmassPointLightSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalLightComponent_Radius_DEPRECATED_GET(ULocalLightComponent* Ptr) { return Ptr->Radius_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_ULocalLightComponent_Radius_DEPRECATED_SET(ULocalLightComponent* Ptr, float Value) { Ptr->Radius_DEPRECATED = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULocalLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULocalLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULocalLightComponent_GetUnitsConversionFactor(ULocalLightComponent* Self, ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle)
	{
		auto _p0 = SrcUnits;
		auto _p1 = TargetUnits;
		auto _p2 = CosHalfConeAngle;
		return Self->GetUnitsConversionFactor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULocalLightComponent_SetAttenuationRadius(ULocalLightComponent* Self, float NewRadius)
	{
		auto _p0 = NewRadius;
		Self->SetAttenuationRadius(_p0);
	}

	DOTNET_EXPORT auto E_ULocalLightComponent_SetIntensityUnits(ULocalLightComponent* Self, ELightUnits NewIntensityUnits)
	{
		auto _p0 = NewIntensityUnits;
		Self->SetIntensityUnits(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
