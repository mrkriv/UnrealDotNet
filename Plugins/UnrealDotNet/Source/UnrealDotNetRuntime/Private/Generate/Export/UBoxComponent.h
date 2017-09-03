#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/BoxComponent.h"

extern "C"
{
	DOTNET_EXPORT INT_PTR E_UBoxComponent_GetScaledBoxExtent(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((UBoxComponent*)Self)->GetScaledBoxExtent());
	}

	DOTNET_EXPORT INT_PTR E_UBoxComponent_GetUnscaledBoxExtent(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((UBoxComponent*)Self)->GetUnscaledBoxExtent());
	}

	DOTNET_EXPORT void E_UBoxComponent_InitBoxExtent(INT_PTR Self, INT_PTR InBoxExtent)
	{
		auto _p0 = *(FVector*)InBoxExtent;
		((UBoxComponent*)Self)->InitBoxExtent(_p0);
	}

	DOTNET_EXPORT void E_UBoxComponent_SetBoxExtent(INT_PTR Self, INT_PTR InBoxExtent, bool bUpdateOverlaps)
	{
		auto _p0 = *(FVector*)InBoxExtent;
		auto _p1 = bUpdateOverlaps;
		((UBoxComponent*)Self)->SetBoxExtent(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
