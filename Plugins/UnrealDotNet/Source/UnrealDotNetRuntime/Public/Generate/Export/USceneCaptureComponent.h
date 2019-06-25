#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:60

class E_PROTECTED_WRAP_USceneCaptureComponent : protected USceneCaptureComponent
{
public:
	void UpdateShowFlags_WRAP()
	{
		UpdateShowFlags();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_bAlwaysPersistRenderingState_GET(USceneCaptureComponent* Ptr) { return Ptr->bAlwaysPersistRenderingState; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_bAlwaysPersistRenderingState_SET(USceneCaptureComponent* Ptr, bool Value) { Ptr->bAlwaysPersistRenderingState = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_bCaptureEveryFrame_GET(USceneCaptureComponent* Ptr) { return Ptr->bCaptureEveryFrame; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_bCaptureEveryFrame_SET(USceneCaptureComponent* Ptr, bool Value) { Ptr->bCaptureEveryFrame = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_bCaptureOnMovement_GET(USceneCaptureComponent* Ptr) { return Ptr->bCaptureOnMovement; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_bCaptureOnMovement_SET(USceneCaptureComponent* Ptr, bool Value) { Ptr->bCaptureOnMovement = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_CaptureSortPriority_GET(USceneCaptureComponent* Ptr) { return Ptr->CaptureSortPriority; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_CaptureSortPriority_SET(USceneCaptureComponent* Ptr, int32 Value) { Ptr->CaptureSortPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_LODDistanceFactor_GET(USceneCaptureComponent* Ptr) { return Ptr->LODDistanceFactor; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_LODDistanceFactor_SET(USceneCaptureComponent* Ptr, float Value) { Ptr->LODDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_MaxViewDistanceOverride_GET(USceneCaptureComponent* Ptr) { return Ptr->MaxViewDistanceOverride; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_MaxViewDistanceOverride_SET(USceneCaptureComponent* Ptr, float Value) { Ptr->MaxViewDistanceOverride = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_PrimitiveRenderMode_GET(USceneCaptureComponent* Ptr) { return Ptr->PrimitiveRenderMode; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_PrimitiveRenderMode_SET(USceneCaptureComponent* Ptr, ESceneCapturePrimitiveRenderMode Value) { Ptr->PrimitiveRenderMode = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent_ProfilingEventName_GET(USceneCaptureComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->ProfilingEventName); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent_ProfilingEventName_SET(USceneCaptureComponent* Ptr, char* Value) { Ptr->ProfilingEventName = ConvertFromManage_FString(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearHiddenComponents(USceneCaptureComponent* Self)
	{
		Self->ClearHiddenComponents();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearShowOnlyComponents(USceneCaptureComponent* Self)
	{
		Self->ClearShowOnlyComponents();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetViewOwner(USceneCaptureComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetViewOwner());
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
