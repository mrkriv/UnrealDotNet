#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent2D.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_bEnableClipPlane_GET(USceneCaptureComponent2D* Ptr) { return Ptr->bEnableClipPlane; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_bEnableClipPlane_SET(USceneCaptureComponent2D* Ptr, bool Value) { Ptr->bEnableClipPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_GET(USceneCaptureComponent2D* Ptr) { return Ptr->bUseCustomProjectionMatrix; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_SET(USceneCaptureComponent2D* Ptr, bool Value) { Ptr->bUseCustomProjectionMatrix = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_ClipPlaneBase_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->ClipPlaneBase); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_ClipPlaneBase_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->ClipPlaneBase = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->ClipPlaneNormal); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->ClipPlaneNormal = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->CustomProjectionMatrix); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->CustomProjectionMatrix = *(FMatrix*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_FOVAngle_GET(USceneCaptureComponent2D* Ptr) { return Ptr->FOVAngle; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_FOVAngle_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->FOVAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_OrthoWidth_GET(USceneCaptureComponent2D* Ptr) { return Ptr->OrthoWidth; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_OrthoWidth_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->OrthoWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_GET(USceneCaptureComponent2D* Ptr) { return Ptr->PostProcessBlendWeight; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->PostProcessBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_PostProcessSettings_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->PostProcessSettings); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_PostProcessSettings_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->PostProcessSettings = *(FPostProcessSettings*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent2D(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent2D>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CaptureScene(USceneCaptureComponent2D* Self)
	{
		Self->CaptureScene();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CaptureSceneDeferred(USceneCaptureComponent2D* Self)
	{
		Self->CaptureSceneDeferred();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_UpdateContent(USceneCaptureComponent2D* Self)
	{
		Self->UpdateContent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
