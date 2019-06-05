#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePoseableMeshComponent.h"
#include "Runtime/Engine/Classes/Components/PoseableMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPoseableMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPoseableMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CopyPoseFromSkeletalComponent(UPoseableMeshComponent* Self, USkeletalMeshComponent* InComponentToCopy)
	{
		auto _p0 = InComponentToCopy;
		Self->CopyPoseFromSkeletalComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_FillComponentSpaceTransforms(UPoseableMeshComponent* Self)
	{
		Self->FillComponentSpaceTransforms();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsRunningParallelEvaluation(UPoseableMeshComponent* Self)
	{
		return Self->IsRunningParallelEvaluation();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_MarkRefreshTransformDirty(UPoseableMeshComponent* Self)
	{
		Self->MarkRefreshTransformDirty();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ResetBoneTransformByName(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->ResetBoneTransformByName(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PrestreamTextures(UMeshComponent* Self, float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bPrioritizeCharacterTextures;
		auto _p2 = CinematicTextureGroups;
		((UManagePoseableMeshComponent*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetTextureForceResidentFlag(UMeshComponent* Self, bool bForceMiplevelsToBeResident)
	{
		auto _p0 = bForceMiplevelsToBeResident;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetTextureForceResidentFlag(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManagePoseableMeshComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManagePoseableMeshComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManagePoseableMeshComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_BeginPlay(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_Deactivate(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManagePoseableMeshComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManagePoseableMeshComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManagePoseableMeshComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnRegister(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnUnregister(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManagePoseableMeshComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePoseableMeshComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_ToggleActive(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_BeginDestroy(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_FinishDestroy(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostCDOContruct(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostEditImport(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostInitProperties(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostLoad(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostNetReceive(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostRepNotifies(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePoseableMeshComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_PreNetReceive(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_ShutdownAfterError(UObject* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPoseableMeshComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePoseableMeshComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
