#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SpotLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_InnerConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->InnerConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_InnerConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->InnerConeAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_LightShaftConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->LightShaftConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_LightShaftConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->LightShaftConeAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_OuterConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->OuterConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_OuterConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->OuterConeAngle = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpotLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpotLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetCosHalfConeAngle(USpotLightComponent* Self)
	{
		return Self->GetCosHalfConeAngle();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetHalfConeAngle(USpotLightComponent* Self)
	{
		return Self->GetHalfConeAngle();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetInnerConeAngle(USpotLightComponent* Self, float NewInnerConeAngle)
	{
		auto _p0 = NewInnerConeAngle;
		Self->SetInnerConeAngle(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetOuterConeAngle(USpotLightComponent* Self, float NewOuterConeAngle)
	{
		auto _p0 = NewOuterConeAngle;
		Self->SetOuterConeAngle(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
