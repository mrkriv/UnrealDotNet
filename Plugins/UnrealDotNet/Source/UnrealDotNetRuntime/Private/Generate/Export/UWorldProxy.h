#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Engine/World.h"

extern "C"
{
	DOTNET_EXPORT UWorld* E_UWorldProxy_GetReference(INT_PTR Self)
	{
		return ((UWorldProxy*)Self)->GetReference();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
