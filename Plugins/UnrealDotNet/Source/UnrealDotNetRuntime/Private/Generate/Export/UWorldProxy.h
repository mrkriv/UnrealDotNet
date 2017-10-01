#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/World.h"

extern "C"
{
	DOTNET_EXPORT auto E_UWorldProxy_GetReference(UWorldProxy* Self)
	{
		return ConvertForManage(Self->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
