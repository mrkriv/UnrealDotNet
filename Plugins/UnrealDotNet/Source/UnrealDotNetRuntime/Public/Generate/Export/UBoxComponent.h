#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageBoxComponent.h"
#include "Runtime/Engine/Classes/Components/BoxComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BoxComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBoxComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBoxComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBoxComponent_GetScaledBoxExtent(UBoxComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetScaledBoxExtent());
	}

	DOTNET_EXPORT auto E_UBoxComponent_GetUnscaledBoxExtent(UBoxComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUnscaledBoxExtent());
	}

	DOTNET_EXPORT auto E_UBoxComponent_InitBoxExtent(UBoxComponent* Self, INT_PTR InBoxExtent)
	{
		auto& _p0 = *(FVector*)InBoxExtent;
		Self->InitBoxExtent(_p0);
	}

	DOTNET_EXPORT auto E_UBoxComponent_SetBoxExtent(UBoxComponent* Self, INT_PTR InBoxExtent, bool bUpdateOverlaps)
	{
		auto _p0 = *(FVector*)InBoxExtent;
		auto _p1 = bUpdateOverlaps;
		Self->SetBoxExtent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UpdateBodySetup();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageBoxComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageBoxComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageBoxComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageBoxComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageBoxComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageBoxComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageBoxComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageBoxComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageBoxComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageBoxComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_Deactivate(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageBoxComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageBoxComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageBoxComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnRegister(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageBoxComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageBoxComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageBoxComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBoxComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBoxComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_BeginDestroy(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_FinishDestroy(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostCDOContruct(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostEditImport(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostInitProperties(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostLoad(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostNetReceive(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostRepNotifies(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageBoxComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_PreNetReceive(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UBoxComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageBoxComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
