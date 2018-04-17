#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PostProcessComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PostProcessComponent.h:21

class E_PROTECTED_WRAP_UPostProcessComponent : protected UPostProcessComponent
{
public:
	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, Hit, MoveFlags, Teleport);
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPostProcessComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPostProcessComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnRegister(UPostProcessComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnUnregister(UPostProcessComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ApplyWorldOffset(UPostProcessComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_BeginDestroy(UPostProcessComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CalcBoundingCylinder(UPostProcessComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CanAttachAsChild(UPostProcessComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_DestroyComponent(UPostProcessComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_DetachFromComponent(UPostProcessComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_DetachFromParent(UPostProcessComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_DoesSocketExist(UPostProcessComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetCollisionObjectType(UPostProcessComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetCollisionResponseToChannel(UPostProcessComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetComponentVelocity(UPostProcessComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetSocketLocation(UPostProcessComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetSocketQuaternion(UPostProcessComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetSocketRotation(UPostProcessComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetSocketTransform(UPostProcessComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_HasAnySockets(UPostProcessComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsAnySimulatingPhysics(UPostProcessComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsPrecomputedLightingValid(UPostProcessComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsSimulatingPhysics(UPostProcessComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsVisible(UPostProcessComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsVisibleInEditor(UPostProcessComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsWorldGeometry(UPostProcessComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_MoveComponentImpl(UPostProcessComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnAttachmentChanged(UPostProcessComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnChildAttached(UPostProcessComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnChildDetached(UPostProcessComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnComponentDestroyed(UPostProcessComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnHiddenInGameChanged(UPostProcessComponent* Self)
	{
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnUpdateTransform(UPostProcessComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnVisibilityChanged(UPostProcessComponent* Self)
	{
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostNetReceive(UPostProcessComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostRepNotifies(UPostProcessComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PreNetReceive(UPostProcessComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PropagateLightingScenarioChange(UPostProcessComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SetRelativeScale3D(UPostProcessComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ShouldCollideWhenPlacing(UPostProcessComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ShouldCreateRenderState(UPostProcessComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_UpdatePhysicsVolume(UPostProcessComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_Activate(UPostProcessComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_AddTickPrerequisiteActor(UPostProcessComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_AddTickPrerequisiteComponent(UPostProcessComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_BeginPlay(UPostProcessComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CreateRenderState_Concurrent(UPostProcessComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_Deactivate(UPostProcessComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_DestroyRenderState_Concurrent(UPostProcessComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetComponentClassCanReplicate(UPostProcessComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetReadableName(UPostProcessComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_HasValidPhysicsState(UPostProcessComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_InitializeComponent(UPostProcessComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_InvalidateLightingCacheDetailed(UPostProcessComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsActive(UPostProcessComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsEditorOnly(UPostProcessComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsNameStableForNetworking(UPostProcessComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsNavigationRelevant(UPostProcessComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsReadyForOwnerToAutoDestroy(UPostProcessComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsSupportedForNetworking(UPostProcessComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_MarkAsEditorOnlySubobject(UPostProcessComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_NeedsLoadForClient(UPostProcessComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_NeedsLoadForEditorGame(UPostProcessComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_NeedsLoadForServer(UPostProcessComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnActorEnableCollisionChanged(UPostProcessComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnComponentCreated(UPostProcessComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnCreatePhysicsState(UPostProcessComponent* Self)
	{
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnDestroyPhysicsState(UPostProcessComponent* Self)
	{
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostInitProperties(UPostProcessComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostLoad(UPostProcessComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostRename(UPostProcessComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_RegisterComponentTickFunctions(UPostProcessComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_RemoveTickPrerequisiteActor(UPostProcessComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_RemoveTickPrerequisiteComponent(UPostProcessComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_RequiresGameThreadEndOfFrameRecreate(UPostProcessComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_RequiresGameThreadEndOfFrameUpdates(UPostProcessComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SendRenderDynamicData_Concurrent(UPostProcessComponent* Self)
	{
		((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SendRenderTransform_Concurrent(UPostProcessComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SetActive(UPostProcessComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SetAutoActivate(UPostProcessComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SetComponentTickEnabled(UPostProcessComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_SetComponentTickEnabledAsync(UPostProcessComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ShouldActivate(UPostProcessComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPostProcessComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ShouldCreatePhysicsState(UPostProcessComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ToggleActive(UPostProcessComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_UninitializeComponent(UPostProcessComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_AreNativePropertiesIdenticalTo(UPostProcessComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CheckDefaultSubobjectsInternal(UPostProcessComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_FinishDestroy(UPostProcessComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetDesc(UPostProcessComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_GetDetailedInfoInternal(UPostProcessComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsAsset(UPostProcessComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsFullNameStableForNetworking(UPostProcessComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsLocalizedResource(UPostProcessComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsPostLoadThreadSafe(UPostProcessComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsReadyForFinishDestroy(UPostProcessComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_IsSafeForRootSet(UPostProcessComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_Modify(UPostProcessComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_NotifyObjectReferenceEliminated(UPostProcessComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostCDOContruct(UPostProcessComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostEditImport(UPostProcessComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PostSaveRoot(UPostProcessComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_PreDestroyFromReplication(UPostProcessComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_ShutdownAfterError(UPostProcessComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_AddToCluster(UPostProcessComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CanBeClusterRoot(UPostProcessComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CanBeInCluster(UPostProcessComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_CreateCluster(UPostProcessComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPostProcessComponent_OnClusterMarkedAsPendingKill(UPostProcessComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
