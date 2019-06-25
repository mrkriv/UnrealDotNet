#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/ReflectionCaptureComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:28

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UReflectionCaptureComponent_Brightness_GET(UReflectionCaptureComponent* Ptr) { return Ptr->Brightness; }
	DOTNET_EXPORT void E_PROP_UReflectionCaptureComponent_Brightness_SET(UReflectionCaptureComponent* Ptr, float Value) { Ptr->Brightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UReflectionCaptureComponent_CaptureOffset_GET(UReflectionCaptureComponent* Ptr) { return (INT_PTR)&(Ptr->CaptureOffset); }
	DOTNET_EXPORT void E_PROP_UReflectionCaptureComponent_CaptureOffset_SET(UReflectionCaptureComponent* Ptr, INT_PTR Value) { Ptr->CaptureOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_GET(UReflectionCaptureComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->CaptureOffsetComponent); }
	DOTNET_EXPORT void E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_SET(UReflectionCaptureComponent* Ptr, UBillboardComponent* Value) { Ptr->CaptureOffsetComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UReflectionCaptureComponent_ReflectionSourceType_GET(UReflectionCaptureComponent* Ptr) { return Ptr->ReflectionSourceType; }
	DOTNET_EXPORT void E_PROP_UReflectionCaptureComponent_ReflectionSourceType_SET(UReflectionCaptureComponent* Ptr, EReflectionSourceType Value) { Ptr->ReflectionSourceType = Value; }
	
	DOTNET_EXPORT auto E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_GET(UReflectionCaptureComponent* Ptr) { return Ptr->SourceCubemapAngle; }
	DOTNET_EXPORT void E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_SET(UReflectionCaptureComponent* Ptr, float Value) { Ptr->SourceCubemapAngle = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetInfluenceBoundingRadius(UReflectionCaptureComponent* Self)
	{
		return Self->GetInfluenceBoundingRadius();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_MarkDirtyForRecapture(UReflectionCaptureComponent* Self)
	{
		Self->MarkDirtyForRecapture();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_MarkDirtyForRecaptureOrUpload(UReflectionCaptureComponent* Self)
	{
		Self->MarkDirtyForRecaptureOrUpload();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetCaptureCompleted(UReflectionCaptureComponent* Self)
	{
		Self->SetCaptureCompleted();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_UpdatePreviewShape(UReflectionCaptureComponent* Self)
	{
		Self->UpdatePreviewShape();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
