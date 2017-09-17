#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/SpectatorPawn.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ASpectatorPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ASpectatorPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
