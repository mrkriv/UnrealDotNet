#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Classes/Components/SphereReflectionCaptureComponent.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
