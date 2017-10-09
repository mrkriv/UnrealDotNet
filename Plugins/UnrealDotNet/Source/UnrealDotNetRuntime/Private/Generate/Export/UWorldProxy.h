#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/World.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\World.h:79

extern "C"
{
	DOTNET_EXPORT auto E_UWorldProxy_GetReference(UWorldProxy* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
