#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/SceneCaptureComponentCube.h"

extern "C"
{
	DOTNET_EXPORT void E_USceneCaptureComponentCube_CaptureScene(INT_PTR Self)
	{
		((USceneCaptureComponentCube*)Self)->CaptureScene();
	}

	DOTNET_EXPORT void E_USceneCaptureComponentCube_CaptureSceneDeferred(INT_PTR Self)
	{
		((USceneCaptureComponentCube*)Self)->CaptureSceneDeferred();
	}

	DOTNET_EXPORT void E_USceneCaptureComponentCube_UpdateContent(INT_PTR Self)
	{
		((USceneCaptureComponentCube*)Self)->UpdateContent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
