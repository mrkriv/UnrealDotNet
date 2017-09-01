#pragma once

#include "CoreMinimal.h"
#include "Engine/Level.h"

extern "C"
{
	DOTNET_EXPORT void E_FPrecomputedVisibilityHandler_UpdateVisibilityStats(INT_PTR Self, bool bAllocating)
	{
		auto _p0 = bAllocating;
		((FPrecomputedVisibilityHandler*)Self)->UpdateVisibilityStats(_p0);
	}

	DOTNET_EXPORT void E_FPrecomputedVisibilityHandler_ApplyWorldOffset(INT_PTR Self, INT_PTR InOffset)
	{
		auto _p0 = *(FVector*)InOffset;
		((FPrecomputedVisibilityHandler*)Self)->ApplyWorldOffset(_p0);
	}

	DOTNET_EXPORT int32 E_FPrecomputedVisibilityHandler_GetId(INT_PTR Self)
	{
		return ((FPrecomputedVisibilityHandler*)Self)->GetId();
	}

}
