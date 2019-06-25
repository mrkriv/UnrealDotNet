#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SphereReflectionCaptureComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_GET(USphereReflectionCaptureComponent* Ptr) { return Ptr->CaptureDistanceScale; }
	DOTNET_EXPORT void E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_SET(USphereReflectionCaptureComponent* Ptr, float Value) { Ptr->CaptureDistanceScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_GET(USphereReflectionCaptureComponent* Ptr) { return Ptr->InfluenceRadius; }
	DOTNET_EXPORT void E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_SET(USphereReflectionCaptureComponent* Ptr, float Value) { Ptr->InfluenceRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_GET(USphereReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewInfluenceRadius); }
	DOTNET_EXPORT void E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_SET(USphereReflectionCaptureComponent* Ptr, UDrawSphereComponent* Value) { Ptr->PreviewInfluenceRadius = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
