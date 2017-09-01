#pragma once

#include "CoreMinimal.h"
#include "Components/SceneCaptureComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_USceneCaptureComponent_HideComponent(INT_PTR Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		((USceneCaptureComponent*)Self)->HideComponent(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_HideActorComponents(INT_PTR Self, AActor* InActor)
	{
		auto _p0 = InActor;
		((USceneCaptureComponent*)Self)->HideActorComponents(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_SetCaptureSortPriority(INT_PTR Self, int32 NewCaptureSortPriority)
	{
		auto _p0 = NewCaptureSortPriority;
		((USceneCaptureComponent*)Self)->SetCaptureSortPriority(_p0);
	}

}
