#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/SceneCaptureComponent.h"

class E_PROTECTED_WRAP_USceneCaptureComponent : protected USceneCaptureComponent
{
public:
	void UpdateShowFlags_WRAP()
	{
		UpdateShowFlags();
	}

}
;

extern "C"
{
	DOTNET_EXPORT void E_USceneCaptureComponent_ClearHiddenComponents(INT_PTR Self)
	{
		((USceneCaptureComponent*)Self)->ClearHiddenComponents();
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_ClearShowOnlyComponents(INT_PTR Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		((USceneCaptureComponent*)Self)->ClearShowOnlyComponents(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_HideActorComponents(INT_PTR Self, AActor* InActor)
	{
		auto _p0 = InActor;
		((USceneCaptureComponent*)Self)->HideActorComponents(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_HideComponent(INT_PTR Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		((USceneCaptureComponent*)Self)->HideComponent(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_RemoveShowOnlyActorComponents(INT_PTR Self, AActor* InActor)
	{
		auto _p0 = InActor;
		((USceneCaptureComponent*)Self)->RemoveShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_RemoveShowOnlyComponent(INT_PTR Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		((USceneCaptureComponent*)Self)->RemoveShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_SetCaptureSortPriority(INT_PTR Self, int32 NewCaptureSortPriority)
	{
		auto _p0 = NewCaptureSortPriority;
		((USceneCaptureComponent*)Self)->SetCaptureSortPriority(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_ShowOnlyActorComponents(INT_PTR Self, AActor* InActor)
	{
		auto _p0 = InActor;
		((USceneCaptureComponent*)Self)->ShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_ShowOnlyComponent(INT_PTR Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		((USceneCaptureComponent*)Self)->ShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT void E_USceneCaptureComponent_UpdateShowFlags(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->UpdateShowFlags_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
