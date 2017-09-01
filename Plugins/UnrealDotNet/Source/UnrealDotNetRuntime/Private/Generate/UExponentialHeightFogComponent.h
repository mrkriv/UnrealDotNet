#pragma once

#include "CoreMinimal.h"
#include "Components/ExponentialHeightFogComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFogDensity(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFogDensity(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetVolumetricFog(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((UExponentialHeightFogComponent*)Self)->SetVolumetricFog(_p0);
	}

}
