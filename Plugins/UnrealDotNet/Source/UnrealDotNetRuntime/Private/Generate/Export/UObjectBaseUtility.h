#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectBaseUtility.h"

extern "C"
{
	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerIndex(UObjectBaseUtility* Self)
	{
		return (Self)->GetLinkerIndex();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(UObjectBaseUtility* Self)
	{
		return (Self)->GetLinkerLicenseeUE4Version();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerUE4Version(UObjectBaseUtility* Self)
	{
		return (Self)->GetLinkerUE4Version();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsDefaultSubobject(UObjectBaseUtility* Self)
	{
		return (Self)->IsDefaultSubobject();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
