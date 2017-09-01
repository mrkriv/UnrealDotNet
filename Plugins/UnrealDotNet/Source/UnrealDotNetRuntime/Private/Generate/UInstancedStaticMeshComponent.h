#pragma once

#include "CoreMinimal.h"
#include "Components/InstancedStaticMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT bool E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(INT_PTR Ptr) { return ((UInstancedStaticMeshComponent*)Ptr)->bPerInstanceRenderDataWasPrebuilt; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(INT_PTR Ptr, bool Value) { ((UInstancedStaticMeshComponent*)Ptr)->bPerInstanceRenderDataWasPrebuilt = Value; }
	
}
