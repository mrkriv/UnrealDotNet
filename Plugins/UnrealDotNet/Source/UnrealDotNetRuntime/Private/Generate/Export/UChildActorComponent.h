#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ChildActorComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:44

class E_PROTECTED_WRAP_UChildActorComponent : protected UChildActorComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UChildActorComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UChildActorComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_BeginDestroy(UChildActorComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_BeginPlay(UChildActorComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CreateChildActor(UChildActorComponent* Self)
	{
		Self->CreateChildActor();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DestroyChildActor(UChildActorComponent* Self)
	{
		Self->DestroyChildActor();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActor(UChildActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetChildActor());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorName(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetChildActorName());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorTemplate(UChildActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetChildActorTemplate());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnComponentDestroyed(UChildActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnRegister(UChildActorComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnUnregister(UChildActorComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostRepNotifies(UChildActorComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ApplyWorldOffset(UChildActorComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CalcBoundingCylinder(UChildActorComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CanAttachAsChild(UChildActorComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DestroyComponent(UChildActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DetachFromComponent(UChildActorComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DetachFromParent(UChildActorComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DoesSocketExist(UChildActorComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetCollisionObjectType(UChildActorComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetCollisionResponseToChannel(UChildActorComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetComponentVelocity(UChildActorComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetSocketLocation(UChildActorComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetSocketQuaternion(UChildActorComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetSocketRotation(UChildActorComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetSocketTransform(UChildActorComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_HasAnySockets(UChildActorComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsAnySimulatingPhysics(UChildActorComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsPrecomputedLightingValid(UChildActorComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsSimulatingPhysics(UChildActorComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsVisible(UChildActorComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsVisibleInEditor(UChildActorComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsWorldGeometry(UChildActorComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_MoveComponentImpl(UChildActorComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UChildActorComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnAttachmentChanged(UChildActorComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnChildAttached(UChildActorComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnChildDetached(UChildActorComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnHiddenInGameChanged(UChildActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnUpdateTransform(UChildActorComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnVisibilityChanged(UChildActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostNetReceive(UChildActorComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PreNetReceive(UChildActorComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PropagateLightingScenarioChange(UChildActorComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SetRelativeScale3D(UChildActorComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ShouldCollideWhenPlacing(UChildActorComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ShouldCreateRenderState(UChildActorComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_UpdatePhysicsVolume(UChildActorComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_Activate(UChildActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_AddTickPrerequisiteActor(UChildActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_AddTickPrerequisiteComponent(UChildActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CreateRenderState_Concurrent(UChildActorComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_Deactivate(UChildActorComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DestroyRenderState_Concurrent(UChildActorComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetComponentClassCanReplicate(UChildActorComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetReadableName(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_HasValidPhysicsState(UChildActorComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_InitializeComponent(UChildActorComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_InvalidateLightingCacheDetailed(UChildActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsActive(UChildActorComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsEditorOnly(UChildActorComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsNameStableForNetworking(UChildActorComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsNavigationRelevant(UChildActorComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsReadyForOwnerToAutoDestroy(UChildActorComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsSupportedForNetworking(UChildActorComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_MarkAsEditorOnlySubobject(UChildActorComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_NeedsLoadForClient(UChildActorComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_NeedsLoadForEditorGame(UChildActorComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_NeedsLoadForServer(UChildActorComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnActorEnableCollisionChanged(UChildActorComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnComponentCreated(UChildActorComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnCreatePhysicsState(UChildActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnDestroyPhysicsState(UChildActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostInitProperties(UChildActorComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostLoad(UChildActorComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostRename(UChildActorComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_RegisterComponentTickFunctions(UChildActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_RemoveTickPrerequisiteActor(UChildActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_RemoveTickPrerequisiteComponent(UChildActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_RequiresGameThreadEndOfFrameRecreate(UChildActorComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_RequiresGameThreadEndOfFrameUpdates(UChildActorComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SendRenderDynamicData_Concurrent(UChildActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UChildActorComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SendRenderTransform_Concurrent(UChildActorComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SetActive(UChildActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SetAutoActivate(UChildActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SetComponentTickEnabled(UChildActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_SetComponentTickEnabledAsync(UChildActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ShouldActivate(UChildActorComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UChildActorComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ShouldCreatePhysicsState(UChildActorComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ToggleActive(UChildActorComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_UninitializeComponent(UChildActorComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_AreNativePropertiesIdenticalTo(UChildActorComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CheckDefaultSubobjectsInternal(UChildActorComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_FinishDestroy(UChildActorComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetDesc(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetDetailedInfoInternal(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsAsset(UChildActorComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsFullNameStableForNetworking(UChildActorComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsLocalizedResource(UChildActorComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsPostLoadThreadSafe(UChildActorComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsReadyForFinishDestroy(UChildActorComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_IsSafeForRootSet(UChildActorComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_Modify(UChildActorComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_NotifyObjectReferenceEliminated(UChildActorComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostCDOContruct(UChildActorComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostEditImport(UChildActorComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PostSaveRoot(UChildActorComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_PreDestroyFromReplication(UChildActorComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_ShutdownAfterError(UChildActorComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_AddToCluster(UChildActorComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CanBeClusterRoot(UChildActorComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CanBeInCluster(UChildActorComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CreateCluster(UChildActorComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_OnClusterMarkedAsPendingKill(UChildActorComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
