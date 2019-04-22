#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ASpectatorPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ASpectatorPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
