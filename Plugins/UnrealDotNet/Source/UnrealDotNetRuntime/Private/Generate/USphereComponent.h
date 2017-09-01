#pragma once

#include "CoreMinimal.h"
#include "Components/SphereComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_USphereComponent_SetSphereRadius(INT_PTR Self, float InSphereRadius, bool bUpdateOverlaps)
	{
		auto _p0 = InSphereRadius;
		auto _p1 = bUpdateOverlaps;
		((USphereComponent*)Self)->SetSphereRadius(_p0, _p1);
	}

	DOTNET_EXPORT float E_USphereComponent_GetScaledSphereRadius(INT_PTR Self)
	{
		return ((USphereComponent*)Self)->GetScaledSphereRadius();
	}

	DOTNET_EXPORT void E_USphereComponent_InitSphereRadius(INT_PTR Self, float InSphereRadius)
	{
		auto _p0 = InSphereRadius;
		((USphereComponent*)Self)->InitSphereRadius(_p0);
	}

}
