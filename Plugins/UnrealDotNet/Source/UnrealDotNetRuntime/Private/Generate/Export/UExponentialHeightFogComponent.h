#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ExponentialHeightFogComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:15

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UExponentialHeightFogComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UExponentialHeightFogComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddFogIfNeeded(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->AddFogIfNeeded_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringExponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogCutoffDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogCutoffDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogDensity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogDensity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogHeightFalloff(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogHeightFalloff(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogMaxOpacity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogMaxOpacity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFullyDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetInscatteringColorCubemapAngle(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetNonDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFog(UExponentialHeightFogComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetVolumetricFog(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogDistance(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogExtinctionScale(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogScatteringDistribution(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
