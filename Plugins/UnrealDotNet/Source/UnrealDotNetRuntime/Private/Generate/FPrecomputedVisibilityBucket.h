#pragma once

#include "CoreMinimal.h"
#include "Engine/Level.h"

extern "C"
{
	DOTNET_EXPORT int32 E_PROP_FPrecomputedVisibilityBucket_CellDataSize_GET(INT_PTR Ptr) { return ((FPrecomputedVisibilityBucket*)Ptr)->CellDataSize; }
	DOTNET_EXPORT void E_PROP_FPrecomputedVisibilityBucket_CellDataSize_SET(INT_PTR Ptr, int32 Value) { ((FPrecomputedVisibilityBucket*)Ptr)->CellDataSize = Value; }
	
}
