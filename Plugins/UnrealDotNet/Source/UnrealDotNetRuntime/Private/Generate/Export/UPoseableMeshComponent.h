#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PoseableMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPoseableMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPoseableMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
