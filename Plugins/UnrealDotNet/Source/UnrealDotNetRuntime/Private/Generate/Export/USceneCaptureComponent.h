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

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetCaptureSortPriority(USceneCaptureComponent* Self, int32 NewCaptureSortPriority)
	{
		auto _p0 = NewCaptureSortPriority;
		Self->SetCaptureSortPriority(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_UpdateShowFlags(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->UpdateShowFlags_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
