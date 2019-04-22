#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightComponent_AffectsPrimitive(ULightComponent* Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return Self->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_GetBoundingBox(ULightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetLightPosition(ULightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectDynamicIndirectLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectTranslucentLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomThreshold(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomThreshold(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetEnableLightShaftBloom(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetEnableLightShaftBloom(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetForceCachedShadowsForMovablePrimitives(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIESBrightnessScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetIESBrightnessScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIndirectLightingIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionDisabledBrightness(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetLightFunctionDisabledBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionFadeDistance(ULightComponent* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionScale(ULightComponent* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetShadowBias(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetShadowBias(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetSpecularScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSpecularScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetTemperature(ULightComponent* Self, float NewTemperature)
	{
		auto _p0 = NewTemperature;
		Self->SetTemperature(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetTransmission(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetTransmission(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetUseIESBrightness(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetUseIESBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetVolumetricScatteringIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetVolumetricScatteringIntensity(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
