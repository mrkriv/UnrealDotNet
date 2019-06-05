#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageInstancedStaticMeshComponent.h"
#include "Runtime/Engine/Classes/Components/InstancedStaticMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstanceEndCullDistance; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstanceEndCullDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstanceStartCullDistance; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstanceStartCullDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstancingRandomSeed; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstancingRandomSeed = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddInstance(UInstancedStaticMeshComponent* Self, INT_PTR InstanceTransform)
	{
		auto& _p0 = *(FTransform*)InstanceTransform;
		return Self->AddInstance(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddInstanceWorldSpace(UInstancedStaticMeshComponent* Self, INT_PTR WorldTransform)
	{
		auto& _p0 = *(FTransform*)WorldTransform;
		return Self->AddInstanceWorldSpace(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ClearInstances(UInstancedStaticMeshComponent* Self)
	{
		Self->ClearInstances();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetInstanceCount(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetInstanceCount();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetInstanceTransform(UInstancedStaticMeshComponent* Self, int32 InstanceIndex, INT_PTR OutInstanceTransform, bool bWorldSpace)
	{
		auto _p0 = InstanceIndex;
		auto& _p1 = *(FTransform*)OutInstanceTransform;
		auto _p2 = bWorldSpace;
		return Self->GetInstanceTransform(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PreAllocateInstancesMemory(UInstancedStaticMeshComponent* Self, int32 AddedInstanceCount)
	{
		auto _p0 = AddedInstanceCount;
		Self->PreAllocateInstancesMemory(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RemoveInstance(UInstancedStaticMeshComponent* Self, int32 InstanceIndex)
	{
		auto _p0 = InstanceIndex;
		return Self->RemoveInstance(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCullDistances(UInstancedStaticMeshComponent* Self, int32 StartCullDistance, int32 EndCullDistance)
	{
		auto _p0 = StartCullDistance;
		auto _p1 = EndCullDistance;
		Self->SetCullDistances(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UpdateInstanceTransform(UInstancedStaticMeshComponent* Self, int32 InstanceIndex, INT_PTR NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)
	{
		auto _p0 = InstanceIndex;
		auto& _p1 = *(FTransform*)NewInstanceTransform;
		auto _p2 = bWorldSpace;
		auto _p3 = bMarkRenderStateDirty;
		auto _p4 = bTeleport;
		return Self->UpdateInstanceTransform(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_ClearInstances(UInstancedStaticMeshComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__ClearInstances();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PreAllocateInstancesMemory(UInstancedStaticMeshComponent* Self, int32 AddedInstanceCount)
	{
		auto _p0 = AddedInstanceCount;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PreAllocateInstancesMemory(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PrestreamTextures(UMeshComponent* Self, float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bPrioritizeCharacterTextures;
		auto _p2 = CinematicTextureGroups;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetTextureForceResidentFlag(UMeshComponent* Self, bool bForceMiplevelsToBeResident)
	{
		auto _p0 = bForceMiplevelsToBeResident;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetTextureForceResidentFlag(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_Deactivate(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnRegister(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_BeginDestroy(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_FinishDestroy(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostCDOContruct(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostEditImport(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostInitProperties(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostLoad(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostNetReceive(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostRepNotifies(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_PreNetReceive(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UInstancedStaticMeshComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageInstancedStaticMeshComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
