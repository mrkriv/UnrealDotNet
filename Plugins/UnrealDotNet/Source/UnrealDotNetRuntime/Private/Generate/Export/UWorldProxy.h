#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/World.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\World.h:80

extern "C"
{
	DOTNET_EXPORT auto E_UWorldProxy_GetReference(UWorldProxy* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
