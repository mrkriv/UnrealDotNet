#pragma once

#include "CoreMinimal.h"
#include "Engine/Level.h"

extern "C"
{
	DOTNET_EXPORT INT_PTR E_PROP_FPrecomputedVisibilityCell_Min_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FPrecomputedVisibilityCell*)Ptr)->Min); }
	DOTNET_EXPORT void E_PROP_FPrecomputedVisibilityCell_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FPrecomputedVisibilityCell*)Ptr)->Min = *(FVector*)Value; }
	
}
