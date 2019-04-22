#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SphereComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetScaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetScaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetShapeScale(USphereComponent* Self)
	{
		return Self->GetShapeScale();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetUnscaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetUnscaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_InitSphereRadius(USphereComponent* Self, float InSphereRadius)
	{
		auto _p0 = InSphereRadius;
		Self->InitSphereRadius(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetSphereRadius(USphereComponent* Self, float InSphereRadius, bool bUpdateOverlaps)
	{
		auto _p0 = InSphereRadius;
		auto _p1 = bUpdateOverlaps;
		Self->SetSphereRadius(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
