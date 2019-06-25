#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSceneCaptureComponentCube.h"
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

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_UpdateBounds(USceneComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_BeginPlay(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_Deactivate(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_InitializeComponent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnRegister(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnUnregister(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_ToggleActive(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_BeginDestroy(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_FinishDestroy(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostCDOContruct(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostEditImport(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostInitProperties(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostLoad(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostNetReceive(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostRepNotifies(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_PreNetReceive(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_ShutdownAfterError(UObject* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponentCube_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSceneCaptureComponentCube*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
