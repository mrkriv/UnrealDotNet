#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/PawnNoiseEmitterComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnNoiseEmitterComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnNoiseEmitterComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseTime(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseTime(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_MakeNoise(UPawnNoiseEmitterComponent* Self, AActor* NoiseMaker, float Loudness, INT_PTR NoiseLocation)
	{
		auto _p0 = NoiseMaker;
		auto _p1 = Loudness;
		auto _p2 = *(FVector*)NoiseLocation;
		Self->MakeNoise(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
