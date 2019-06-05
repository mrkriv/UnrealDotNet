#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCapsuleComponent.h"
#include "Runtime/Engine/Classes/Components/CapsuleComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCapsuleComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCapsuleComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleRadius();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto& _p0 = OutRadius;
		auto& _p1 = OutHalfHeight;
		Self->GetScaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto& _p0 = OutRadius;
		auto& _p1 = OutHalfHeightWithoutHemisphere;
		Self->GetScaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetShapeScale(UCapsuleComponent* Self)
	{
		return Self->GetShapeScale();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleRadius();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto& _p0 = OutRadius;
		auto& _p1 = OutHalfHeight;
		Self->GetUnscaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto& _p0 = OutRadius;
		auto& _p1 = OutHalfHeightWithoutHemisphere;
		Self->GetUnscaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_InitCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		Self->InitCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleHalfHeight(UCapsuleComponent* Self, float HalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = HalfHeight;
		auto _p1 = bUpdateOverlaps;
		Self->SetCapsuleHalfHeight(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleRadius(UCapsuleComponent* Self, float Radius, bool bUpdateOverlaps)
	{
		auto _p0 = Radius;
		auto _p1 = bUpdateOverlaps;
		Self->SetCapsuleRadius(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		auto _p2 = bUpdateOverlaps;
		Self->SetCapsuleSize(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UpdateBodySetup();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageCapsuleComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageCapsuleComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageCapsuleComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageCapsuleComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageCapsuleComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageCapsuleComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageCapsuleComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageCapsuleComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageCapsuleComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageCapsuleComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_Deactivate(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageCapsuleComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageCapsuleComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageCapsuleComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnRegister(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageCapsuleComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageCapsuleComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageCapsuleComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageCapsuleComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageCapsuleComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_BeginDestroy(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_FinishDestroy(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostCDOContruct(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostEditImport(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostInitProperties(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostLoad(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostNetReceive(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostRepNotifies(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCapsuleComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_PreNetReceive(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCapsuleComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCapsuleComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
