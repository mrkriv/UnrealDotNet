#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/LightmassPortalComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LightmassPortalComponent.h:12

class E_PROTECTED_WRAP_ULightmassPortalComponent : protected ULightmassPortalComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightmassPortalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightmassPortalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CreateRenderState_Concurrent(ULightmassPortalComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SendRenderTransform_Concurrent(ULightmassPortalComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ApplyWorldOffset(ULightmassPortalComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_BeginDestroy(ULightmassPortalComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CalcBoundingCylinder(ULightmassPortalComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CanAttachAsChild(ULightmassPortalComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_DestroyComponent(ULightmassPortalComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_DetachFromComponent(ULightmassPortalComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_DetachFromParent(ULightmassPortalComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_DoesSocketExist(ULightmassPortalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetCollisionObjectType(ULightmassPortalComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetCollisionResponseToChannel(ULightmassPortalComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetComponentVelocity(ULightmassPortalComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetSocketLocation(ULightmassPortalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetSocketQuaternion(ULightmassPortalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetSocketRotation(ULightmassPortalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetSocketTransform(ULightmassPortalComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_HasAnySockets(ULightmassPortalComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsAnySimulatingPhysics(ULightmassPortalComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsPrecomputedLightingValid(ULightmassPortalComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsSimulatingPhysics(ULightmassPortalComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsVisible(ULightmassPortalComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsVisibleInEditor(ULightmassPortalComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsWorldGeometry(ULightmassPortalComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_MoveComponentImpl(ULightmassPortalComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnAttachmentChanged(ULightmassPortalComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnChildAttached(ULightmassPortalComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnChildDetached(ULightmassPortalComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnComponentDestroyed(ULightmassPortalComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnHiddenInGameChanged(ULightmassPortalComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnRegister(ULightmassPortalComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnUnregister(ULightmassPortalComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnUpdateTransform(ULightmassPortalComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnVisibilityChanged(ULightmassPortalComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostNetReceive(ULightmassPortalComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostRepNotifies(ULightmassPortalComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PreNetReceive(ULightmassPortalComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PropagateLightingScenarioChange(ULightmassPortalComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SetRelativeScale3D(ULightmassPortalComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ShouldCollideWhenPlacing(ULightmassPortalComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ShouldCreateRenderState(ULightmassPortalComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_UpdatePhysicsVolume(ULightmassPortalComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_Activate(ULightmassPortalComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_AddTickPrerequisiteActor(ULightmassPortalComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_AddTickPrerequisiteComponent(ULightmassPortalComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_BeginPlay(ULightmassPortalComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_Deactivate(ULightmassPortalComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_DestroyRenderState_Concurrent(ULightmassPortalComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetComponentClassCanReplicate(ULightmassPortalComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetReadableName(ULightmassPortalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_HasValidPhysicsState(ULightmassPortalComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_InitializeComponent(ULightmassPortalComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_InvalidateLightingCacheDetailed(ULightmassPortalComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsActive(ULightmassPortalComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsEditorOnly(ULightmassPortalComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsNameStableForNetworking(ULightmassPortalComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsNavigationRelevant(ULightmassPortalComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsReadyForOwnerToAutoDestroy(ULightmassPortalComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsSupportedForNetworking(ULightmassPortalComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_MarkAsEditorOnlySubobject(ULightmassPortalComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_NeedsLoadForClient(ULightmassPortalComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_NeedsLoadForEditorGame(ULightmassPortalComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_NeedsLoadForServer(ULightmassPortalComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnActorEnableCollisionChanged(ULightmassPortalComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnComponentCreated(ULightmassPortalComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnCreatePhysicsState(ULightmassPortalComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnDestroyPhysicsState(ULightmassPortalComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostInitProperties(ULightmassPortalComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostLoad(ULightmassPortalComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostRename(ULightmassPortalComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_RegisterComponentTickFunctions(ULightmassPortalComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_RemoveTickPrerequisiteActor(ULightmassPortalComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_RemoveTickPrerequisiteComponent(ULightmassPortalComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_RequiresGameThreadEndOfFrameRecreate(ULightmassPortalComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_RequiresGameThreadEndOfFrameUpdates(ULightmassPortalComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SendRenderDynamicData_Concurrent(ULightmassPortalComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SetActive(ULightmassPortalComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SetAutoActivate(ULightmassPortalComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SetComponentTickEnabled(ULightmassPortalComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_SetComponentTickEnabledAsync(ULightmassPortalComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ShouldActivate(ULightmassPortalComponent* Self)
	{
		return ((E_PROTECTED_WRAP_ULightmassPortalComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ShouldCreatePhysicsState(ULightmassPortalComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ToggleActive(ULightmassPortalComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_UninitializeComponent(ULightmassPortalComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_AreNativePropertiesIdenticalTo(ULightmassPortalComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CheckDefaultSubobjectsInternal(ULightmassPortalComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_FinishDestroy(ULightmassPortalComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetDesc(ULightmassPortalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_GetDetailedInfoInternal(ULightmassPortalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsAsset(ULightmassPortalComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsFullNameStableForNetworking(ULightmassPortalComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsLocalizedResource(ULightmassPortalComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsPostLoadThreadSafe(ULightmassPortalComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsReadyForFinishDestroy(ULightmassPortalComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_IsSafeForRootSet(ULightmassPortalComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_Modify(ULightmassPortalComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_NotifyObjectReferenceEliminated(ULightmassPortalComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostCDOContruct(ULightmassPortalComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostEditImport(ULightmassPortalComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PostSaveRoot(ULightmassPortalComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_PreDestroyFromReplication(ULightmassPortalComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_ShutdownAfterError(ULightmassPortalComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_AddToCluster(ULightmassPortalComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CanBeClusterRoot(ULightmassPortalComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CanBeInCluster(ULightmassPortalComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_CreateCluster(ULightmassPortalComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ULightmassPortalComponent_OnClusterMarkedAsPendingKill(ULightmassPortalComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
