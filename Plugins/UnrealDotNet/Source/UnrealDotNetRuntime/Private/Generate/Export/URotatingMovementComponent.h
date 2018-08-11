#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/RotatingMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_URotatingMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URotatingMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
