#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/LineBatchComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\LineBatchComponent.h:120

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULineBatchComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULineBatchComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
