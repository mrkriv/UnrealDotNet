#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/CapsuleComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCapsuleComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCapsuleComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return (Self)->GetScaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return (Self)->GetScaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetScaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return (Self)->GetScaledCapsuleRadius();
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetScaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		(Self)->GetScaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		(Self)->GetScaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetShapeScale(UCapsuleComponent* Self)
	{
		return (Self)->GetShapeScale();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return (Self)->GetUnscaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return (Self)->GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT float E_UCapsuleComponent_GetUnscaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return (Self)->GetUnscaledCapsuleRadius();
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetUnscaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		(Self)->GetUnscaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		(Self)->GetUnscaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_InitCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		(Self)->InitCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleHalfHeight(UCapsuleComponent* Self, float HalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = HalfHeight;
		auto _p1 = bUpdateOverlaps;
		(Self)->SetCapsuleHalfHeight(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleRadius(UCapsuleComponent* Self, float Radius, bool bUpdateOverlaps)
	{
		auto _p0 = Radius;
		auto _p1 = bUpdateOverlaps;
		(Self)->SetCapsuleRadius(_p0, _p1);
	}

	DOTNET_EXPORT void E_UCapsuleComponent_SetCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		auto _p2 = bUpdateOverlaps;
		(Self)->SetCapsuleSize(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
