#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageBillboardComponent.h"
#include "Runtime/Engine/Classes/Components/BillboardComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_ScreenSize_GET(UBillboardComponent* Ptr) { return Ptr->ScreenSize; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_ScreenSize_SET(UBillboardComponent* Ptr, float Value) { Ptr->ScreenSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_U_GET(UBillboardComponent* Ptr) { return Ptr->U; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_U_SET(UBillboardComponent* Ptr, float Value) { Ptr->U = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_UL_GET(UBillboardComponent* Ptr) { return Ptr->UL; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_UL_SET(UBillboardComponent* Ptr, float Value) { Ptr->UL = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_V_GET(UBillboardComponent* Ptr) { return Ptr->V; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_V_SET(UBillboardComponent* Ptr, float Value) { Ptr->V = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_VL_GET(UBillboardComponent* Ptr) { return Ptr->VL; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_VL_SET(UBillboardComponent* Ptr, float Value) { Ptr->VL = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBillboardComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBillboardComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBillboardComponent_SetUV(UBillboardComponent* Self, int32 NewU, int32 NewUL, int32 NewV, int32 NewVL)
	{
		auto _p0 = NewU;
		auto _p1 = NewUL;
		auto _p2 = NewV;
		auto _p3 = NewVL;
		Self->SetUV(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetUV(UBillboardComponent* Self, int32 NewU, int32 NewUL, int32 NewV, int32 NewVL)
	{
		auto _p0 = NewU;
		auto _p1 = NewUL;
		auto _p2 = NewV;
		auto _p3 = NewVL;
		((UManageBillboardComponent*)Self)->_Supper__SetUV(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageBillboardComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageBillboardComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageBillboardComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageBillboardComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageBillboardComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageBillboardComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageBillboardComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageBillboardComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageBillboardComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageBillboardComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_Deactivate(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageBillboardComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageBillboardComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageBillboardComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnRegister(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageBillboardComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageBillboardComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageBillboardComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBillboardComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBillboardComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_BeginDestroy(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_FinishDestroy(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostCDOContruct(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostEditImport(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostInitProperties(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostLoad(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostNetReceive(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostRepNotifies(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageBillboardComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_PreNetReceive(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UBillboardComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageBillboardComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
