#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/SceneCaptureComponentCube.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponentCube(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponentCube>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_USceneCaptureComponentCube_CaptureScene(USceneCaptureComponentCube* Self)
	{
		(Self)->CaptureScene();
	}

	DOTNET_EXPORT void E_USceneCaptureComponentCube_CaptureSceneDeferred(USceneCaptureComponentCube* Self)
	{
		(Self)->CaptureSceneDeferred();
	}

	DOTNET_EXPORT void E_USceneCaptureComponentCube_UpdateContent(USceneCaptureComponentCube* Self)
	{
		(Self)->UpdateContent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
