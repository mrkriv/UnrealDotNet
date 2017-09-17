#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/InstancedStaticMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT bool E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(INT_PTR Ptr) { return ((UInstancedStaticMeshComponent*)Ptr)->bPerInstanceRenderDataWasPrebuilt; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(INT_PTR Ptr, bool Value) { ((UInstancedStaticMeshComponent*)Ptr)->bPerInstanceRenderDataWasPrebuilt = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
