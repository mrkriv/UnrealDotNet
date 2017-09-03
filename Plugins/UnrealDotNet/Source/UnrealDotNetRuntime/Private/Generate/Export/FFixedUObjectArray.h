#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectArray.h"

extern "C"
{
	DOTNET_EXPORT int32 E_FFixedUObjectArray_AddRange(INT_PTR Self, int32 Count)
	{
		auto _p0 = Count;
		return ((FFixedUObjectArray*)Self)->AddRange(_p0);
	}

	DOTNET_EXPORT int32 E_FFixedUObjectArray_AddSingle(INT_PTR Self)
	{
		return ((FFixedUObjectArray*)Self)->AddSingle();
	}

	DOTNET_EXPORT bool E_FFixedUObjectArray_IsValidIndex(INT_PTR Self, int32 Index)
	{
		auto _p0 = Index;
		return ((FFixedUObjectArray*)Self)->IsValidIndex(_p0);
	}

	DOTNET_EXPORT int32 E_FFixedUObjectArray_Num(INT_PTR Self)
	{
		return ((FFixedUObjectArray*)Self)->Num();
	}

	DOTNET_EXPORT void E_FFixedUObjectArray_PreAllocate(INT_PTR Self, int32 InMaxElements)
	{
		auto _p0 = InMaxElements;
		((FFixedUObjectArray*)Self)->PreAllocate(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
