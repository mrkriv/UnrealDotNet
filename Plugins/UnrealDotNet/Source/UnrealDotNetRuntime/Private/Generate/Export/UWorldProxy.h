#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Engine/World.h"

extern "C"
{
	DOTNET_EXPORT ObjectPointerDescription E_UWorldProxy_GetReference(INT_PTR Self)
	{
		return MakePrtDesc(((UWorldProxy*)Self)->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
