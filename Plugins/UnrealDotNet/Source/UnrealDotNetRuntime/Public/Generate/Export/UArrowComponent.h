#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageArrowComponent.h"
#include "Runtime/Engine/Classes/Components/ArrowComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UArrowComponent_ArrowSize_GET(UArrowComponent* Ptr) { return Ptr->ArrowSize; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_ArrowSize_SET(UArrowComponent* Ptr, float Value) { Ptr->ArrowSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UArrowComponent_bIsScreenSizeScaled_GET(UArrowComponent* Ptr) { return Ptr->bIsScreenSizeScaled; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_bIsScreenSizeScaled_SET(UArrowComponent* Ptr, bool Value) { Ptr->bIsScreenSizeScaled = Value; }
	
	DOTNET_EXPORT auto E_PROP_UArrowComponent_ScreenSize_GET(UArrowComponent* Ptr) { return Ptr->ScreenSize; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_ScreenSize_SET(UArrowComponent* Ptr, float Value) { Ptr->ScreenSize = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UArrowComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UArrowComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UArrowComponent_SetArrowColor(UArrowComponent* Self, INT_PTR NewColor)
	{
		auto _p0 = *(FLinearColor*)NewColor;
		Self->SetArrowColor(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageArrowComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageArrowComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageArrowComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageArrowComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageArrowComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageArrowComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageArrowComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageArrowComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageArrowComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageArrowComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_Deactivate(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageArrowComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageArrowComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageArrowComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnRegister(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageArrowComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageArrowComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageArrowComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageArrowComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageArrowComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_BeginDestroy(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_FinishDestroy(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostCDOContruct(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostEditImport(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostInitProperties(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostLoad(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostNetReceive(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostRepNotifies(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageArrowComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_PreNetReceive(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UArrowComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageArrowComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
