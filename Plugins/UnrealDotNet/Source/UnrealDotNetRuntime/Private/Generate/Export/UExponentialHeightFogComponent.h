#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/ExponentialHeightFogComponent.h"

class E_PROTECTED_WRAP_UExponentialHeightFogComponent : protected UExponentialHeightFogComponent
{
public:
	void AddFogIfNeeded_WRAP()
	{
		AddFogIfNeeded();
	}

}
;

extern "C"
{
	DOTNET_EXPORT void E_UExponentialHeightFogComponent_AddFogIfNeeded(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->AddFogIfNeeded_WRAP();
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetDirectionalInscatteringExponent(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetDirectionalInscatteringStartDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFogCutoffDistance(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFogCutoffDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFogDensity(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFogDensity(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFogHeightFalloff(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFogHeightFalloff(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFogMaxOpacity(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFogMaxOpacity(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetFullyDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetInscatteringColorCubemapAngle(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetNonDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetStartDistance(INT_PTR Self, float Value)
	{
		auto _p0 = Value;
		((UExponentialHeightFogComponent*)Self)->SetStartDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetVolumetricFog(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((UExponentialHeightFogComponent*)Self)->SetVolumetricFog(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetVolumetricFogDistance(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((UExponentialHeightFogComponent*)Self)->SetVolumetricFogDistance(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((UExponentialHeightFogComponent*)Self)->SetVolumetricFogExtinctionScale(_p0);
	}

	DOTNET_EXPORT void E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(INT_PTR Self, float NewValue)
	{
		auto _p0 = NewValue;
		((UExponentialHeightFogComponent*)Self)->SetVolumetricFogScatteringDistribution(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
