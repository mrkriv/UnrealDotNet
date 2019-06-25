#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageRectLightComponent.h"
#include "Runtime/Engine/Classes/Components/RectLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:20

extern "C"
{
	DOTNET_EXPORT auto E_PROP_URectLightComponent_BarnDoorAngle_GET(URectLightComponent* Ptr) { return Ptr->BarnDoorAngle; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_BarnDoorAngle_SET(URectLightComponent* Ptr, float Value) { Ptr->BarnDoorAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_BarnDoorLength_GET(URectLightComponent* Ptr) { return Ptr->BarnDoorLength; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_BarnDoorLength_SET(URectLightComponent* Ptr, float Value) { Ptr->BarnDoorLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_SourceHeight_GET(URectLightComponent* Ptr) { return Ptr->SourceHeight; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_SourceHeight_SET(URectLightComponent* Ptr, float Value) { Ptr->SourceHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_SourceWidth_GET(URectLightComponent* Ptr) { return Ptr->SourceWidth; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_SourceWidth_SET(URectLightComponent* Ptr, float Value) { Ptr->SourceWidth = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_URectLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URectLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetBarnDoorAngle(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBarnDoorAngle(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetBarnDoorLength(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBarnDoorLength(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetSourceHeight(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSourceHeight(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetSourceWidth(URectLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSourceWidth(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageRectLightComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageRectLightComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageRectLightComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_Deactivate(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageRectLightComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageRectLightComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageRectLightComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnRegister(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageRectLightComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageRectLightComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageRectLightComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageRectLightComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageRectLightComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_BeginDestroy(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_FinishDestroy(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostCDOContruct(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostEditImport(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostInitProperties(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostLoad(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostNetReceive(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostRepNotifies(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageRectLightComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_PreNetReceive(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__URectLightComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageRectLightComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
