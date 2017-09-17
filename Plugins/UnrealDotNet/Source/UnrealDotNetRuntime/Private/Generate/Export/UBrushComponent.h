#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/BrushComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBrushComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBrushComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UBrushComponent_BuildSimpleBrushCollision(INT_PTR Self)
	{
		((UBrushComponent*)Self)->BuildSimpleBrushCollision();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
