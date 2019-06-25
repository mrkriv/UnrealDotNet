#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/BoxReflectionCaptureComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BoxReflectionCaptureComponent.h:13

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_GET(UBoxReflectionCaptureComponent* Ptr) { return Ptr->BoxTransitionDistance; }
	DOTNET_EXPORT void E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_SET(UBoxReflectionCaptureComponent* Ptr, float Value) { Ptr->BoxTransitionDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_GET(UBoxReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewCaptureBox); }
	DOTNET_EXPORT void E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_SET(UBoxReflectionCaptureComponent* Ptr, UBoxComponent* Value) { Ptr->PreviewCaptureBox = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_GET(UBoxReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewInfluenceBox); }
	DOTNET_EXPORT void E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_SET(UBoxReflectionCaptureComponent* Ptr, UBoxComponent* Value) { Ptr->PreviewInfluenceBox = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBoxReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBoxReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
