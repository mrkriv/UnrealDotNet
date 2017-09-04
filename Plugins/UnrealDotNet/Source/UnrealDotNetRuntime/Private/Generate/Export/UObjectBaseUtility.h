#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectBaseUtility.h"

extern "C"
{
	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerIndex(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerIndex();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerLicenseeUE4Version();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerUE4Version(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerUE4Version();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsDefaultSubobject(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsDefaultSubobject();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
