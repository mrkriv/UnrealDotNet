#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageLineBatchComponent.h"
#include "Runtime/Engine/Classes/Components/LineBatchComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULineBatchComponent_DefaultLifeTime_GET(ULineBatchComponent* Ptr) { return Ptr->DefaultLifeTime; }
	DOTNET_EXPORT void E_PROP_ULineBatchComponent_DefaultLifeTime_SET(ULineBatchComponent* Ptr, float Value) { Ptr->DefaultLifeTime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULineBatchComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULineBatchComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DrawLine(ULineBatchComponent* Self, INT_PTR Start, INT_PTR End, INT_PTR Color, uint8 DepthPriority, float Thickness, float LifeTime)
	{
		auto& _p0 = *(FVector*)Start;
		auto& _p1 = *(FVector*)End;
		auto& _p2 = *(FLinearColor*)Color;
		auto _p3 = DepthPriority;
		auto _p4 = Thickness;
		auto _p5 = LifeTime;
		Self->DrawLine(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DrawPoint(ULineBatchComponent* Self, INT_PTR Position, INT_PTR Color, float PointSize, uint8 DepthPriority, float LifeTime)
	{
		auto& _p0 = *(FVector*)Position;
		auto& _p1 = *(FLinearColor*)Color;
		auto _p2 = PointSize;
		auto _p3 = DepthPriority;
		auto _p4 = LifeTime;
		Self->DrawPoint(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_Flush(ULineBatchComponent* Self)
	{
		Self->Flush();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageLineBatchComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageLineBatchComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageLineBatchComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageLineBatchComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageLineBatchComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageLineBatchComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageLineBatchComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageLineBatchComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageLineBatchComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageLineBatchComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_Deactivate(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageLineBatchComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageLineBatchComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageLineBatchComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnRegister(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageLineBatchComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageLineBatchComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageLineBatchComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageLineBatchComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageLineBatchComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_BeginDestroy(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_FinishDestroy(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostCDOContruct(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostEditImport(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostInitProperties(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostLoad(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostNetReceive(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostRepNotifies(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageLineBatchComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_PreNetReceive(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ULineBatchComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageLineBatchComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
