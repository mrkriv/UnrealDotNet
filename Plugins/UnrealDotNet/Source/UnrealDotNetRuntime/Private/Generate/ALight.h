#pragma once

#include "CoreMinimal.h"
#include "Engine/Light.h"

extern "C"
{
	DOTNET_EXPORT void E_ALight_OnRep_bEnabled(INT_PTR Self)
	{
		((ALight*)Self)->OnRep_bEnabled();
	}

	DOTNET_EXPORT void E_ALight_SetEnabled(INT_PTR Self, bool bSetEnabled)
	{
		auto _p0 = bSetEnabled;
		((ALight*)Self)->SetEnabled(_p0);
	}

	DOTNET_EXPORT bool E_ALight_IsEnabled(INT_PTR Self)
	{
		return ((ALight*)Self)->IsEnabled();
	}

	DOTNET_EXPORT void E_ALight_SetBrightness(INT_PTR Self, float NewBrightness)
	{
		auto _p0 = NewBrightness;
		((ALight*)Self)->SetBrightness(_p0);
	}

	DOTNET_EXPORT float E_ALight_GetBrightness(INT_PTR Self)
	{
		return ((ALight*)Self)->GetBrightness();
	}

	DOTNET_EXPORT void E_ALight_SetLightFunctionScale(INT_PTR Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		((ALight*)Self)->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT ULightComponent* E_ALight_GetLightComponent(INT_PTR Self)
	{
		return ((ALight*)Self)->GetLightComponent();
	}

}
