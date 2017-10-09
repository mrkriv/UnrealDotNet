#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/PostProcessComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PostProcessComponent.h:21

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPostProcessComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPostProcessComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
