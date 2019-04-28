#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PlaneReflectionCaptureComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PlaneReflectionCaptureComponent.h:13

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_GET(UPlaneReflectionCaptureComponent* Ptr) { return Ptr->InfluenceRadiusScale; }
	DOTNET_EXPORT void E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_SET(UPlaneReflectionCaptureComponent* Ptr, float Value) { Ptr->InfluenceRadiusScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_GET(UPlaneReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewCaptureBox); }
	DOTNET_EXPORT void E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_SET(UPlaneReflectionCaptureComponent* Ptr, UBoxComponent* Value) { Ptr->PreviewCaptureBox = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_GET(UPlaneReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewInfluenceRadius); }
	DOTNET_EXPORT void E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_SET(UPlaneReflectionCaptureComponent* Ptr, UDrawSphereComponent* Value) { Ptr->PreviewInfluenceRadius = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlaneReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlaneReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
