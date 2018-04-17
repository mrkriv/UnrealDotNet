#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ReflectionCaptureComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:28

class E_PROTECTED_WRAP_UReflectionCaptureComponent : protected UReflectionCaptureComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ApplyWorldOffset(UReflectionCaptureComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_BeginDestroy(UReflectionCaptureComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CalcBoundingCylinder(UReflectionCaptureComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CanAttachAsChild(UReflectionCaptureComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_DestroyComponent(UReflectionCaptureComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_DetachFromComponent(UReflectionCaptureComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_DetachFromParent(UReflectionCaptureComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_DoesSocketExist(UReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetCollisionObjectType(UReflectionCaptureComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetCollisionResponseToChannel(UReflectionCaptureComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetComponentVelocity(UReflectionCaptureComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetSocketLocation(UReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetSocketQuaternion(UReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetSocketRotation(UReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetSocketTransform(UReflectionCaptureComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_HasAnySockets(UReflectionCaptureComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsAnySimulatingPhysics(UReflectionCaptureComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsPrecomputedLightingValid(UReflectionCaptureComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsSimulatingPhysics(UReflectionCaptureComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsVisible(UReflectionCaptureComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsVisibleInEditor(UReflectionCaptureComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsWorldGeometry(UReflectionCaptureComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_MoveComponentImpl(UReflectionCaptureComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnAttachmentChanged(UReflectionCaptureComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnChildAttached(UReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnChildDetached(UReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnComponentDestroyed(UReflectionCaptureComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnHiddenInGameChanged(UReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnRegister(UReflectionCaptureComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnUnregister(UReflectionCaptureComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnUpdateTransform(UReflectionCaptureComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnVisibilityChanged(UReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostNetReceive(UReflectionCaptureComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostRepNotifies(UReflectionCaptureComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PreNetReceive(UReflectionCaptureComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PropagateLightingScenarioChange(UReflectionCaptureComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetRelativeScale3D(UReflectionCaptureComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ShouldCollideWhenPlacing(UReflectionCaptureComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ShouldCreateRenderState(UReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_UpdatePhysicsVolume(UReflectionCaptureComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_Activate(UReflectionCaptureComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_AddTickPrerequisiteActor(UReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_AddTickPrerequisiteComponent(UReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_BeginPlay(UReflectionCaptureComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CreateRenderState_Concurrent(UReflectionCaptureComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_Deactivate(UReflectionCaptureComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_DestroyRenderState_Concurrent(UReflectionCaptureComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetComponentClassCanReplicate(UReflectionCaptureComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetReadableName(UReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_HasValidPhysicsState(UReflectionCaptureComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_InitializeComponent(UReflectionCaptureComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_InvalidateLightingCacheDetailed(UReflectionCaptureComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsActive(UReflectionCaptureComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsEditorOnly(UReflectionCaptureComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsNameStableForNetworking(UReflectionCaptureComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsNavigationRelevant(UReflectionCaptureComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsReadyForOwnerToAutoDestroy(UReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsSupportedForNetworking(UReflectionCaptureComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_MarkAsEditorOnlySubobject(UReflectionCaptureComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_NeedsLoadForClient(UReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_NeedsLoadForEditorGame(UReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_NeedsLoadForServer(UReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnActorEnableCollisionChanged(UReflectionCaptureComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnComponentCreated(UReflectionCaptureComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnCreatePhysicsState(UReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnDestroyPhysicsState(UReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostInitProperties(UReflectionCaptureComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostLoad(UReflectionCaptureComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostRename(UReflectionCaptureComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_RegisterComponentTickFunctions(UReflectionCaptureComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_RemoveTickPrerequisiteActor(UReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_RemoveTickPrerequisiteComponent(UReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_RequiresGameThreadEndOfFrameRecreate(UReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_RequiresGameThreadEndOfFrameUpdates(UReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SendRenderDynamicData_Concurrent(UReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SendRenderTransform_Concurrent(UReflectionCaptureComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetActive(UReflectionCaptureComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetAutoActivate(UReflectionCaptureComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetComponentTickEnabled(UReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_SetComponentTickEnabledAsync(UReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ShouldActivate(UReflectionCaptureComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UReflectionCaptureComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ShouldCreatePhysicsState(UReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ToggleActive(UReflectionCaptureComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_UninitializeComponent(UReflectionCaptureComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_AreNativePropertiesIdenticalTo(UReflectionCaptureComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CheckDefaultSubobjectsInternal(UReflectionCaptureComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_FinishDestroy(UReflectionCaptureComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetDesc(UReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_GetDetailedInfoInternal(UReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsAsset(UReflectionCaptureComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsFullNameStableForNetworking(UReflectionCaptureComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsLocalizedResource(UReflectionCaptureComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsPostLoadThreadSafe(UReflectionCaptureComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsReadyForFinishDestroy(UReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_IsSafeForRootSet(UReflectionCaptureComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_Modify(UReflectionCaptureComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_NotifyObjectReferenceEliminated(UReflectionCaptureComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostCDOContruct(UReflectionCaptureComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostEditImport(UReflectionCaptureComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PostSaveRoot(UReflectionCaptureComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_PreDestroyFromReplication(UReflectionCaptureComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_ShutdownAfterError(UReflectionCaptureComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_AddToCluster(UReflectionCaptureComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CanBeClusterRoot(UReflectionCaptureComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CanBeInCluster(UReflectionCaptureComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_CreateCluster(UReflectionCaptureComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UReflectionCaptureComponent_OnClusterMarkedAsPendingKill(UReflectionCaptureComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
