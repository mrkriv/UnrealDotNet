#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/LightComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT bool E_ULightComponent_AffectsPrimitive(ULightComponent* Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return (Self)->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetAffectDynamicIndirectLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		(Self)->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetAffectTranslucentLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		(Self)->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetBloomScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		(Self)->SetBloomScale(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetBloomThreshold(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		(Self)->SetBloomThreshold(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetEnableLightShaftBloom(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		(Self)->SetEnableLightShaftBloom(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetIndirectLightingIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		(Self)->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		(Self)->SetIntensity(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionDisabledBrightness(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		(Self)->SetLightFunctionDisabledBrightness(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionFadeDistance(ULightComponent* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		(Self)->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionScale(ULightComponent* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		(Self)->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetShadowBias(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		(Self)->SetShadowBias(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetTemperature(ULightComponent* Self, float NewTemperature)
	{
		auto _p0 = NewTemperature;
		(Self)->SetTemperature(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetVolumetricScatteringIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		(Self)->SetVolumetricScatteringIntensity(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
