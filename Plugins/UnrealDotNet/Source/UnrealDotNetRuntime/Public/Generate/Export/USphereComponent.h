#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSphereComponent.h"
#include "Runtime/Engine/Classes/Components/SphereComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetScaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetScaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetShapeScale(USphereComponent* Self)
	{
		return Self->GetShapeScale();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetUnscaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetUnscaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_InitSphereRadius(USphereComponent* Self, float InSphereRadius)
	{
		auto _p0 = InSphereRadius;
		Self->InitSphereRadius(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetSphereRadius(USphereComponent* Self, float InSphereRadius, bool bUpdateOverlaps)
	{
		auto _p0 = InSphereRadius;
		auto _p1 = bUpdateOverlaps;
		Self->SetSphereRadius(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UpdateBodySetup();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageSphereComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageSphereComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageSphereComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageSphereComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageSphereComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageSphereComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageSphereComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSphereComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSphereComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSphereComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_Deactivate(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSphereComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSphereComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSphereComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnRegister(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSphereComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSphereComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSphereComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSphereComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSphereComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_BeginDestroy(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_FinishDestroy(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostCDOContruct(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostEditImport(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostInitProperties(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostLoad(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostNetReceive(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostRepNotifies(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSphereComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_PreNetReceive(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USphereComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSphereComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
