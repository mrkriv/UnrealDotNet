#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraComponent.h"
#include "Runtime/Engine/Classes/Camera/CameraComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraComponent.h:21

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCameraComponent_AspectRatio_GET(UCameraComponent* Ptr) { return Ptr->AspectRatio; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_AspectRatio_SET(UCameraComponent* Ptr, float Value) { Ptr->AspectRatio = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_bConstrainAspectRatio_GET(UCameraComponent* Ptr) { return Ptr->bConstrainAspectRatio; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_bConstrainAspectRatio_SET(UCameraComponent* Ptr, uint8 Value) { Ptr->bConstrainAspectRatio = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_bLockToHmd_GET(UCameraComponent* Ptr) { return Ptr->bLockToHmd; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_bLockToHmd_SET(UCameraComponent* Ptr, uint8 Value) { Ptr->bLockToHmd = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_bUseFieldOfViewForLOD_GET(UCameraComponent* Ptr) { return Ptr->bUseFieldOfViewForLOD; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_bUseFieldOfViewForLOD_SET(UCameraComponent* Ptr, uint8 Value) { Ptr->bUseFieldOfViewForLOD = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_bUsePawnControlRotation_GET(UCameraComponent* Ptr) { return Ptr->bUsePawnControlRotation; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_bUsePawnControlRotation_SET(UCameraComponent* Ptr, uint8 Value) { Ptr->bUsePawnControlRotation = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_FieldOfView_GET(UCameraComponent* Ptr) { return Ptr->FieldOfView; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_FieldOfView_SET(UCameraComponent* Ptr, float Value) { Ptr->FieldOfView = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_OrthoFarClipPlane_GET(UCameraComponent* Ptr) { return Ptr->OrthoFarClipPlane; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_OrthoFarClipPlane_SET(UCameraComponent* Ptr, float Value) { Ptr->OrthoFarClipPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_OrthoNearClipPlane_GET(UCameraComponent* Ptr) { return Ptr->OrthoNearClipPlane; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_OrthoNearClipPlane_SET(UCameraComponent* Ptr, float Value) { Ptr->OrthoNearClipPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_OrthoWidth_GET(UCameraComponent* Ptr) { return Ptr->OrthoWidth; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_OrthoWidth_SET(UCameraComponent* Ptr, float Value) { Ptr->OrthoWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_PostProcessBlendWeight_GET(UCameraComponent* Ptr) { return Ptr->PostProcessBlendWeight; }
	DOTNET_EXPORT void E_PROP_UCameraComponent_PostProcessBlendWeight_SET(UCameraComponent* Ptr, float Value) { Ptr->PostProcessBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraComponent_PostProcessSettings_GET(UCameraComponent* Ptr) { return (INT_PTR)&(Ptr->PostProcessSettings); }
	DOTNET_EXPORT void E_PROP_UCameraComponent_PostProcessSettings_SET(UCameraComponent* Ptr, INT_PTR Value) { Ptr->PostProcessSettings = *(FPostProcessSettings*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraComponent_AddAdditiveOffset(UCameraComponent* Self, INT_PTR Transform, float FOV)
	{
		auto& _p0 = *(FTransform*)Transform;
		auto _p1 = FOV;
		Self->AddAdditiveOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraComponent_AddExtraPostProcessBlend(UCameraComponent* Self, INT_PTR PPSettings, float PPBlendWeight)
	{
		auto& _p0 = *(FPostProcessSettings*)PPSettings;
		auto _p1 = PPBlendWeight;
		Self->AddExtraPostProcessBlend(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraComponent_ClearAdditiveOffset(UCameraComponent* Self)
	{
		Self->ClearAdditiveOffset();
	}

	DOTNET_EXPORT auto E_UCameraComponent_ClearExtraPostProcessBlends(UCameraComponent* Self)
	{
		Self->ClearExtraPostProcessBlends();
	}

	DOTNET_EXPORT auto E_UCameraComponent_GetAdditiveOffset(UCameraComponent* Self, INT_PTR OutAdditiveOffset, float OutAdditiveFOVOffset)
	{
		auto& _p0 = *(FTransform*)OutAdditiveOffset;
		auto& _p1 = OutAdditiveFOVOffset;
		Self->GetAdditiveOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraComponent_GetCameraView(UCameraComponent* Self, float DeltaTime, INT_PTR DesiredView)
	{
		auto _p0 = DeltaTime;
		auto& _p1 = *(FMinimalViewInfo*)DesiredView;
		Self->GetCameraView(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraComponent_NotifyCameraCut(UCameraComponent* Self)
	{
		Self->NotifyCameraCut();
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetAspectRatio(UCameraComponent* Self, float InAspectRatio)
	{
		auto _p0 = InAspectRatio;
		Self->SetAspectRatio(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetConstraintAspectRatio(UCameraComponent* Self, bool bInConstrainAspectRatio)
	{
		auto _p0 = bInConstrainAspectRatio;
		Self->SetConstraintAspectRatio(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetFieldOfView(UCameraComponent* Self, float InFieldOfView)
	{
		auto _p0 = InFieldOfView;
		Self->SetFieldOfView(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetOrthoFarClipPlane(UCameraComponent* Self, float InOrthoFarClipPlane)
	{
		auto _p0 = InOrthoFarClipPlane;
		Self->SetOrthoFarClipPlane(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetOrthoNearClipPlane(UCameraComponent* Self, float InOrthoNearClipPlane)
	{
		auto _p0 = InOrthoNearClipPlane;
		Self->SetOrthoNearClipPlane(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetOrthoWidth(UCameraComponent* Self, float InOrthoWidth)
	{
		auto _p0 = InOrthoWidth;
		Self->SetOrthoWidth(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetPostProcessBlendWeight(UCameraComponent* Self, float InPostProcessBlendWeight)
	{
		auto _p0 = InPostProcessBlendWeight;
		Self->SetPostProcessBlendWeight(_p0);
	}

	DOTNET_EXPORT auto E_UCameraComponent_SetUseFieldOfViewForLOD(UCameraComponent* Self, bool bInUseFieldOfViewForLOD)
	{
		auto _p0 = bInUseFieldOfViewForLOD;
		Self->SetUseFieldOfViewForLOD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_NotifyCameraCut(UCameraComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__NotifyCameraCut();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SetFieldOfView(UCameraComponent* Self, float InFieldOfView)
	{
		auto _p0 = InFieldOfView;
		((UManageCameraComponent*)Self)->_Supper__SetFieldOfView(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageCameraComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageCameraComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageCameraComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_Deactivate(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageCameraComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageCameraComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageCameraComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnRegister(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageCameraComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageCameraComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageCameraComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageCameraComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageCameraComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_BeginDestroy(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_FinishDestroy(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostCDOContruct(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostEditImport(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostInitProperties(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostLoad(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostNetReceive(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostRepNotifies(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCameraComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_PreNetReceive(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCameraComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCameraComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
