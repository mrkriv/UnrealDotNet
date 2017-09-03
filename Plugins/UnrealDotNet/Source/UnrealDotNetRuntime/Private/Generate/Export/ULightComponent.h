#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/LightComponent.h"

extern "C"
{
	DOTNET_EXPORT bool E_ULightComponent_AffectsPrimitive(INT_PTR Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return ((ULightComponent*)Self)->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetAffectDynamicIndirectLighting(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ULightComponent*)Self)->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetAffectTranslucentLighting(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ULightComponent*)Self)->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetBloomScale(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((ULightComponent*)Self)->SetBloomScale(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetBloomThreshold(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((ULightComponent*)Self)->SetBloomThreshold(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetEnableLightShaftBloom(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ULightComponent*)Self)->SetEnableLightShaftBloom(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetIndirectLightingIntensity(INT_PTR Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		((ULightComponent*)Self)->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetIntensity(INT_PTR Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		((ULightComponent*)Self)->SetIntensity(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionDisabledBrightness(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((ULightComponent*)Self)->SetLightFunctionDisabledBrightness(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionFadeDistance(INT_PTR Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		((ULightComponent*)Self)->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionScale(INT_PTR Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		((ULightComponent*)Self)->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetShadowBias(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((ULightComponent*)Self)->SetShadowBias(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetTemperature(INT_PTR Self, float NewTemperature)
	{
		auto _p0 = NewTemperature;
		((ULightComponent*)Self)->SetTemperature(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetVolumetricScatteringIntensity(INT_PTR Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		((ULightComponent*)Self)->SetVolumetricScatteringIntensity(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
