#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/InstancedStaticMeshComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\InstancedStaticMeshComponent.h:101

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->bPerInstanceRenderDataWasPrebuilt; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(UInstancedStaticMeshComponent* Ptr, bool Value) { Ptr->bPerInstanceRenderDataWasPrebuilt = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
