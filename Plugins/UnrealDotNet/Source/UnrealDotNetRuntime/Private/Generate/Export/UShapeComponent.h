#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ShapeComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ShapeComponent.h:24

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UShapeComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UShapeComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UShapeComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		Self->UpdateBodySetup();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
