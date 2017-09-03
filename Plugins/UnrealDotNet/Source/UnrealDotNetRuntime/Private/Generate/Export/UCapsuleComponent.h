#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/CapsuleComponent.h"

extern "C"
{
	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleHalfHeight(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetScaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetScaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleRadius(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetScaledCapsuleRadius();
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetScaledCapsuleSize(INT_PTR Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		((UCapsuleComponent*)Self)->GetScaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(INT_PTR Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		((UCapsuleComponent*)Self)->GetScaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetShapeScale(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetShapeScale();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetUnscaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleRadius(INT_PTR Self)
	{
		return ((UCapsuleComponent*)Self)->GetUnscaledCapsuleRadius();
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetUnscaledCapsuleSize(INT_PTR Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		((UCapsuleComponent*)Self)->GetUnscaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(INT_PTR Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		((UCapsuleComponent*)Self)->GetUnscaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_InitCapsuleSize(INT_PTR Self, float InRadius, float InHalfHeight)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		((UCapsuleComponent*)Self)->InitCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleHalfHeight(INT_PTR Self, float HalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = HalfHeight;
		auto _p1 = bUpdateOverlaps;
		((UCapsuleComponent*)Self)->SetCapsuleHalfHeight(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleRadius(INT_PTR Self, float Radius, bool bUpdateOverlaps)
	{
		auto _p0 = Radius;
		auto _p1 = bUpdateOverlaps;
		((UCapsuleComponent*)Self)->SetCapsuleRadius(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleSize(INT_PTR Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		auto _p2 = bUpdateOverlaps;
		((UCapsuleComponent*)Self)->SetCapsuleSize(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
