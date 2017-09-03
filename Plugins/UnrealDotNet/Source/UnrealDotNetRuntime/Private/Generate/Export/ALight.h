#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Engine/Light.h"

extern "C"
{
	DOTNET_EXPORT float E_ALight_GetBrightness(INT_PTR Self)
	{
		return ((ALight*)Self)->GetBrightness();
	}

	DOTNET_EXPORT ULightComponent* E_ALight_GetLightComponent(INT_PTR Self)
	{
		return ((ALight*)Self)->GetLightComponent();
	}

	DOTNET_EXPORT bool E_ALight_IsEnabled(INT_PTR Self)
	{
		return ((ALight*)Self)->IsEnabled();
	}

	DOTNET_EXPORT bool E_ALight_IsToggleable(INT_PTR Self)
	{
		return ((ALight*)Self)->IsToggleable();
	}

	DOTNET_EXPORT void E_ALight_OnRep_bEnabled(INT_PTR Self)
	{
		((ALight*)Self)->OnRep_bEnabled();
	}

	DOTNET_EXPORT void E_ALight_SetAffectTranslucentLighting(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ALight*)Self)->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT void E_ALight_SetBrightness(INT_PTR Self, float NewBrightness)
	{
		auto _p0 = NewBrightness;
		((ALight*)Self)->SetBrightness(_p0);
	}

	DOTNET_EXPORT void E_ALight_SetCastShadows(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ALight*)Self)->SetCastShadows(_p0);
	}

	DOTNET_EXPORT void E_ALight_SetEnabled(INT_PTR Self, bool bSetEnabled)
	{
		auto _p0 = bSetEnabled;
		((ALight*)Self)->SetEnabled(_p0);
	}

	DOTNET_EXPORT void E_ALight_SetLightFunctionFadeDistance(INT_PTR Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		((ALight*)Self)->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT void E_ALight_SetLightFunctionScale(INT_PTR Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		((ALight*)Self)->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT void E_ALight_ToggleEnabled(INT_PTR Self)
	{
		((ALight*)Self)->ToggleEnabled();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
