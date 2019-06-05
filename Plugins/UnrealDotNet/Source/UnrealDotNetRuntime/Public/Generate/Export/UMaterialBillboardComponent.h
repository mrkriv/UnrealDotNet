#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageMaterialBillboardComponent.h"
#include "Runtime/Engine/Classes/Components/MaterialBillboardComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMaterialBillboardComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMaterialBillboardComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageMaterialBillboardComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageMaterialBillboardComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageMaterialBillboardComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_Deactivate(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageMaterialBillboardComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageMaterialBillboardComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnRegister(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageMaterialBillboardComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageMaterialBillboardComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_BeginDestroy(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_FinishDestroy(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostCDOContruct(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostEditImport(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostInitProperties(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostLoad(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostNetReceive(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostRepNotifies(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageMaterialBillboardComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_PreNetReceive(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UMaterialBillboardComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageMaterialBillboardComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
