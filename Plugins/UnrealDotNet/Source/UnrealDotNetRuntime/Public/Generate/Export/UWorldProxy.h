#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/World.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:78

extern "C"
{
	DOTNET_EXPORT auto E_UWorldProxy_GetReference(UWorldProxy* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetReference());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
