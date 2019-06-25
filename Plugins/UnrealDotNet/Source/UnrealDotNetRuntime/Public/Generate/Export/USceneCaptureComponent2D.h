#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSceneCaptureComponent2D.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent2D.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_bEnableClipPlane_GET(USceneCaptureComponent2D* Ptr) { return Ptr->bEnableClipPlane; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_bEnableClipPlane_SET(USceneCaptureComponent2D* Ptr, bool Value) { Ptr->bEnableClipPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_GET(USceneCaptureComponent2D* Ptr) { return Ptr->bUseCustomProjectionMatrix; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_bUseCustomProjectionMatrix_SET(USceneCaptureComponent2D* Ptr, bool Value) { Ptr->bUseCustomProjectionMatrix = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_ClipPlaneBase_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->ClipPlaneBase); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_ClipPlaneBase_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->ClipPlaneBase = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->ClipPlaneNormal); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_ClipPlaneNormal_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->ClipPlaneNormal = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->CustomProjectionMatrix); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_CustomProjectionMatrix_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->CustomProjectionMatrix = *(FMatrix*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_FOVAngle_GET(USceneCaptureComponent2D* Ptr) { return Ptr->FOVAngle; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_FOVAngle_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->FOVAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_OrthoWidth_GET(USceneCaptureComponent2D* Ptr) { return Ptr->OrthoWidth; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_OrthoWidth_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->OrthoWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_GET(USceneCaptureComponent2D* Ptr) { return Ptr->PostProcessBlendWeight; }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_PostProcessBlendWeight_SET(USceneCaptureComponent2D* Ptr, float Value) { Ptr->PostProcessBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneCaptureComponent2D_PostProcessSettings_GET(USceneCaptureComponent2D* Ptr) { return (INT_PTR)&(Ptr->PostProcessSettings); }
	DOTNET_EXPORT void E_PROP_USceneCaptureComponent2D_PostProcessSettings_SET(USceneCaptureComponent2D* Ptr, INT_PTR Value) { Ptr->PostProcessSettings = *(FPostProcessSettings*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent2D(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent2D>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CaptureScene(USceneCaptureComponent2D* Self)
	{
		Self->CaptureScene();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CaptureSceneDeferred(USceneCaptureComponent2D* Self)
	{
		Self->CaptureSceneDeferred();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_UpdateContent(USceneCaptureComponent2D* Self)
	{
		Self->UpdateContent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_UpdateBounds(USceneComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_BeginPlay(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_Deactivate(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_InitializeComponent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnRegister(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnUnregister(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_ToggleActive(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_BeginDestroy(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_FinishDestroy(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostCDOContruct(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostEditImport(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostInitProperties(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostLoad(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostNetReceive(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostRepNotifies(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_PreNetReceive(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_ShutdownAfterError(UObject* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USceneCaptureComponent2D_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSceneCaptureComponent2D*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
