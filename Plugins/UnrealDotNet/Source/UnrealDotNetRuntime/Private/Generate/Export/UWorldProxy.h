#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/World.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\World.h:81

extern "C"
{
	DOTNET_EXPORT auto E_UWorldProxy_GetReference(UWorldProxy* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
