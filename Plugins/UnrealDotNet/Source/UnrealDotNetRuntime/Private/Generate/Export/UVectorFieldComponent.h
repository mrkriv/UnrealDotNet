#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/VectorFieldComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UVectorFieldComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UVectorFieldComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
