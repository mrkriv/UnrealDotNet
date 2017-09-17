#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/ArrowComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UArrowComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UArrowComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
