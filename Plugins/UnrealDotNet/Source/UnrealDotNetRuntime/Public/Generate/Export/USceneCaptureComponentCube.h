#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponentCube.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponentCube_IPD_GET(USceneCaptureComponentCube* Ptr) { return Ptr->IPD; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponentCube_IPD_SET(USceneCaptureComponentCube* Ptr, float Value) { Ptr->IPD = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponentCube(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponentCube>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CaptureScene(USceneCaptureComponentCube* Self)
	{
		Self->CaptureScene();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CaptureSceneDeferred(USceneCaptureComponentCube* Self)
	{
		Self->CaptureSceneDeferred();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_UpdateContent(USceneCaptureComponentCube* Self)
	{
		Self->UpdateContent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
