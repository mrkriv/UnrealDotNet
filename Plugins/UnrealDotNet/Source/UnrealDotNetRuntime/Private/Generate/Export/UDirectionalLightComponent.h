#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/DirectionalLightComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

class E_PROTECTED_WRAP_UDirectionalLightComponent : protected UDirectionalLightComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDirectionalLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDirectionalLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetBoundingBox(UDirectionalLightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetLightPosition(UDirectionalLightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ApplyWorldOffset(UDirectionalLightComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_BeginDestroy(UDirectionalLightComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CalcBoundingCylinder(UDirectionalLightComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CanAttachAsChild(UDirectionalLightComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_DestroyComponent(UDirectionalLightComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_DetachFromComponent(UDirectionalLightComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_DetachFromParent(UDirectionalLightComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_DoesSocketExist(UDirectionalLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetCollisionObjectType(UDirectionalLightComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetCollisionResponseToChannel(UDirectionalLightComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetComponentVelocity(UDirectionalLightComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetSocketLocation(UDirectionalLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetSocketQuaternion(UDirectionalLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetSocketRotation(UDirectionalLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetSocketTransform(UDirectionalLightComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_HasAnySockets(UDirectionalLightComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsAnySimulatingPhysics(UDirectionalLightComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsPrecomputedLightingValid(UDirectionalLightComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsSimulatingPhysics(UDirectionalLightComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsVisible(UDirectionalLightComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsVisibleInEditor(UDirectionalLightComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsWorldGeometry(UDirectionalLightComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_MoveComponentImpl(UDirectionalLightComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnAttachmentChanged(UDirectionalLightComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnChildAttached(UDirectionalLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnChildDetached(UDirectionalLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnComponentDestroyed(UDirectionalLightComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnHiddenInGameChanged(UDirectionalLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnRegister(UDirectionalLightComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnUnregister(UDirectionalLightComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnUpdateTransform(UDirectionalLightComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnVisibilityChanged(UDirectionalLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostNetReceive(UDirectionalLightComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostRepNotifies(UDirectionalLightComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PreNetReceive(UDirectionalLightComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PropagateLightingScenarioChange(UDirectionalLightComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetRelativeScale3D(UDirectionalLightComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ShouldCollideWhenPlacing(UDirectionalLightComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ShouldCreateRenderState(UDirectionalLightComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_UpdatePhysicsVolume(UDirectionalLightComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_Activate(UDirectionalLightComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_AddTickPrerequisiteActor(UDirectionalLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_AddTickPrerequisiteComponent(UDirectionalLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_BeginPlay(UDirectionalLightComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CreateRenderState_Concurrent(UDirectionalLightComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_Deactivate(UDirectionalLightComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_DestroyRenderState_Concurrent(UDirectionalLightComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetComponentClassCanReplicate(UDirectionalLightComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetReadableName(UDirectionalLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_HasValidPhysicsState(UDirectionalLightComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_InitializeComponent(UDirectionalLightComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_InvalidateLightingCacheDetailed(UDirectionalLightComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsActive(UDirectionalLightComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsEditorOnly(UDirectionalLightComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsNameStableForNetworking(UDirectionalLightComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsNavigationRelevant(UDirectionalLightComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsReadyForOwnerToAutoDestroy(UDirectionalLightComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsSupportedForNetworking(UDirectionalLightComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_MarkAsEditorOnlySubobject(UDirectionalLightComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_NeedsLoadForClient(UDirectionalLightComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_NeedsLoadForEditorGame(UDirectionalLightComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_NeedsLoadForServer(UDirectionalLightComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnActorEnableCollisionChanged(UDirectionalLightComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnComponentCreated(UDirectionalLightComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnCreatePhysicsState(UDirectionalLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnDestroyPhysicsState(UDirectionalLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostInitProperties(UDirectionalLightComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostLoad(UDirectionalLightComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostRename(UDirectionalLightComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_RegisterComponentTickFunctions(UDirectionalLightComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_RemoveTickPrerequisiteActor(UDirectionalLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_RemoveTickPrerequisiteComponent(UDirectionalLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_RequiresGameThreadEndOfFrameRecreate(UDirectionalLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_RequiresGameThreadEndOfFrameUpdates(UDirectionalLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SendRenderDynamicData_Concurrent(UDirectionalLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SendRenderTransform_Concurrent(UDirectionalLightComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetActive(UDirectionalLightComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetAutoActivate(UDirectionalLightComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetComponentTickEnabled(UDirectionalLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetComponentTickEnabledAsync(UDirectionalLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ShouldActivate(UDirectionalLightComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDirectionalLightComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ShouldCreatePhysicsState(UDirectionalLightComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ToggleActive(UDirectionalLightComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_UninitializeComponent(UDirectionalLightComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_AreNativePropertiesIdenticalTo(UDirectionalLightComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CheckDefaultSubobjectsInternal(UDirectionalLightComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_FinishDestroy(UDirectionalLightComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetDesc(UDirectionalLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_GetDetailedInfoInternal(UDirectionalLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsAsset(UDirectionalLightComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsFullNameStableForNetworking(UDirectionalLightComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsLocalizedResource(UDirectionalLightComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsPostLoadThreadSafe(UDirectionalLightComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsReadyForFinishDestroy(UDirectionalLightComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_IsSafeForRootSet(UDirectionalLightComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_Modify(UDirectionalLightComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_NotifyObjectReferenceEliminated(UDirectionalLightComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostCDOContruct(UDirectionalLightComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostEditImport(UDirectionalLightComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PostSaveRoot(UDirectionalLightComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_PreDestroyFromReplication(UDirectionalLightComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_ShutdownAfterError(UDirectionalLightComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_AddToCluster(UDirectionalLightComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CanBeClusterRoot(UDirectionalLightComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CanBeInCluster(UDirectionalLightComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_CreateCluster(UDirectionalLightComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_OnClusterMarkedAsPendingKill(UDirectionalLightComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
