#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/BillboardComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBillboardComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBillboardComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
