#pragma once

#include "CoreMinimal.h"
#include "Engine/Level.h"

extern "C"
{
	DOTNET_EXPORT bool E_PROP_FCompressedVisibilityChunk_bCompressed_GET(INT_PTR Ptr) { return ((FCompressedVisibilityChunk*)Ptr)->bCompressed; }
	DOTNET_EXPORT void E_PROP_FCompressedVisibilityChunk_bCompressed_SET(INT_PTR Ptr, bool Value) { ((FCompressedVisibilityChunk*)Ptr)->bCompressed = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FCompressedVisibilityChunk_UncompressedSize_GET(INT_PTR Ptr) { return ((FCompressedVisibilityChunk*)Ptr)->UncompressedSize; }
	DOTNET_EXPORT void E_PROP_FCompressedVisibilityChunk_UncompressedSize_SET(INT_PTR Ptr, int32 Value) { ((FCompressedVisibilityChunk*)Ptr)->UncompressedSize = Value; }
	
}
