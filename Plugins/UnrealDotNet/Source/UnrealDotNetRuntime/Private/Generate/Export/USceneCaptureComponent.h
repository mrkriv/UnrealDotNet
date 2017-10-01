#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearHiddenComponents(USceneCaptureComponent* Self)
	{
		Self->ClearHiddenComponents();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearShowOnlyComponents(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->ClearShowOnlyComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HideActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->HideActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HideComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->HideComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveShowOnlyActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->RemoveShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveShowOnlyComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->RemoveShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetCaptureSortPriority(USceneCaptureComponent* Self, int32 NewCaptureSortPriority)
	{
		auto _p0 = NewCaptureSortPriority;
		Self->SetCaptureSortPriority(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShowOnlyActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->ShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShowOnlyComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->ShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_UpdateShowFlags(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->UpdateShowFlags_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
