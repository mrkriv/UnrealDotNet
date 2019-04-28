#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PointLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_LightFalloffExponent_GET(UPointLightComponent* Ptr) { return Ptr->LightFalloffExponent; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_LightFalloffExponent_SET(UPointLightComponent* Ptr, float Value) { Ptr->LightFalloffExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SoftSourceRadius_GET(UPointLightComponent* Ptr) { return Ptr->SoftSourceRadius; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SoftSourceRadius_SET(UPointLightComponent* Ptr, float Value) { Ptr->SoftSourceRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SourceLength_GET(UPointLightComponent* Ptr) { return Ptr->SourceLength; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SourceLength_SET(UPointLightComponent* Ptr, float Value) { Ptr->SourceLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SourceRadius_GET(UPointLightComponent* Ptr) { return Ptr->SourceRadius; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SourceRadius_SET(UPointLightComponent* Ptr, float Value) { Ptr->SourceRadius = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPointLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPointLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetLightFalloffExponent(UPointLightComponent* Self, float NewLightFalloffExponent)
	{
		auto _p0 = NewLightFalloffExponent;
		Self->SetLightFalloffExponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSoftSourceRadius(UPointLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSoftSourceRadius(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSourceLength(UPointLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSourceLength(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSourceRadius(UPointLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSourceRadius(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
