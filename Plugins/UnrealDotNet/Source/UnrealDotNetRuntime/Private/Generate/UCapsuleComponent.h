#pragma once

#include "CoreMinimal.h"
#include "Components/CapsuleComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleSize(INT_PTR Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		auto _p2 = bUpdateOverlaps;
		((UCapsuleComponent*)Self)->SetCapsuleSize(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleRadius(INT_PTR Self, float Radius, bool bUpdateOverlaps)
	{
		auto _p0 = Radius;
		auto _p1 = bUpdateOverlaps;
		((UCapsuleComponent*)Self)->SetCapsuleRadius(_p0, _p1);
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleRadius(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetScaledCapsuleRadius();
	}

	DOTNET_EXPORT void E_UCapsuleComponent_InitCapsuleSize(INT_PTR Self, float InRadius, float InHalfHeight)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		((UCapsuleComponent*)Self)->InitCapsuleSize(_p0, _p1);
	}

}
