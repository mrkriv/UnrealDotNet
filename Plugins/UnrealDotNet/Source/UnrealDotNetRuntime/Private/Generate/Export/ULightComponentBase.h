#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/LightComponentBase.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

class E_PROTECTED_WRAP_ULightComponentBase : protected ULightComponentBase
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponentBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponentBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ApplyWorldOffset(ULightComponentBase* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_BeginDestroy(ULightComponentBase* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CalcBoundingCylinder(ULightComponentBase* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CanAttachAsChild(ULightComponentBase* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_DestroyComponent(ULightComponentBase* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_DetachFromComponent(ULightComponentBase* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_DetachFromParent(ULightComponentBase* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_DoesSocketExist(ULightComponentBase* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetCollisionObjectType(ULightComponentBase* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetCollisionResponseToChannel(ULightComponentBase* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetComponentVelocity(ULightComponentBase* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetSocketLocation(ULightComponentBase* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetSocketQuaternion(ULightComponentBase* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetSocketRotation(ULightComponentBase* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetSocketTransform(ULightComponentBase* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_HasAnySockets(ULightComponentBase* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsAnySimulatingPhysics(ULightComponentBase* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsPrecomputedLightingValid(ULightComponentBase* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsSimulatingPhysics(ULightComponentBase* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsVisible(ULightComponentBase* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsVisibleInEditor(ULightComponentBase* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsWorldGeometry(ULightComponentBase* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_MoveComponentImpl(ULightComponentBase* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_ULightComponentBase*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnAttachmentChanged(ULightComponentBase* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnChildAttached(ULightComponentBase* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnChildDetached(ULightComponentBase* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnComponentDestroyed(ULightComponentBase* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnHiddenInGameChanged(ULightComponentBase* Self)
	{
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnRegister(ULightComponentBase* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnUnregister(ULightComponentBase* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnUpdateTransform(ULightComponentBase* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnVisibilityChanged(ULightComponentBase* Self)
	{
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostNetReceive(ULightComponentBase* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostRepNotifies(ULightComponentBase* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PreNetReceive(ULightComponentBase* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PropagateLightingScenarioChange(ULightComponentBase* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetRelativeScale3D(ULightComponentBase* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ShouldCollideWhenPlacing(ULightComponentBase* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ShouldCreateRenderState(ULightComponentBase* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_UpdatePhysicsVolume(ULightComponentBase* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_Activate(ULightComponentBase* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_AddTickPrerequisiteActor(ULightComponentBase* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_AddTickPrerequisiteComponent(ULightComponentBase* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_BeginPlay(ULightComponentBase* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CreateRenderState_Concurrent(ULightComponentBase* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_Deactivate(ULightComponentBase* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_DestroyRenderState_Concurrent(ULightComponentBase* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetComponentClassCanReplicate(ULightComponentBase* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetReadableName(ULightComponentBase* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_ULightComponentBase_HasValidPhysicsState(ULightComponentBase* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_InitializeComponent(ULightComponentBase* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_InvalidateLightingCacheDetailed(ULightComponentBase* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsActive(ULightComponentBase* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsEditorOnly(ULightComponentBase* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsNameStableForNetworking(ULightComponentBase* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsNavigationRelevant(ULightComponentBase* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsReadyForOwnerToAutoDestroy(ULightComponentBase* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsSupportedForNetworking(ULightComponentBase* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_MarkAsEditorOnlySubobject(ULightComponentBase* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_NeedsLoadForClient(ULightComponentBase* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_NeedsLoadForEditorGame(ULightComponentBase* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_NeedsLoadForServer(ULightComponentBase* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnActorEnableCollisionChanged(ULightComponentBase* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnComponentCreated(ULightComponentBase* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnCreatePhysicsState(ULightComponentBase* Self)
	{
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnDestroyPhysicsState(ULightComponentBase* Self)
	{
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostInitProperties(ULightComponentBase* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostLoad(ULightComponentBase* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostRename(ULightComponentBase* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_RegisterComponentTickFunctions(ULightComponentBase* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_RemoveTickPrerequisiteActor(ULightComponentBase* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_RemoveTickPrerequisiteComponent(ULightComponentBase* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_RequiresGameThreadEndOfFrameRecreate(ULightComponentBase* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_RequiresGameThreadEndOfFrameUpdates(ULightComponentBase* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SendRenderDynamicData_Concurrent(ULightComponentBase* Self)
	{
		((E_PROTECTED_WRAP_ULightComponentBase*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SendRenderTransform_Concurrent(ULightComponentBase* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetActive(ULightComponentBase* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetAutoActivate(ULightComponentBase* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetComponentTickEnabled(ULightComponentBase* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetComponentTickEnabledAsync(ULightComponentBase* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ShouldActivate(ULightComponentBase* Self)
	{
		return ((E_PROTECTED_WRAP_ULightComponentBase*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ShouldCreatePhysicsState(ULightComponentBase* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ToggleActive(ULightComponentBase* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_UninitializeComponent(ULightComponentBase* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_AreNativePropertiesIdenticalTo(ULightComponentBase* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CheckDefaultSubobjectsInternal(ULightComponentBase* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_FinishDestroy(ULightComponentBase* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetDesc(ULightComponentBase* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetDetailedInfoInternal(ULightComponentBase* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsAsset(ULightComponentBase* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsFullNameStableForNetworking(ULightComponentBase* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsLocalizedResource(ULightComponentBase* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsPostLoadThreadSafe(ULightComponentBase* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsReadyForFinishDestroy(ULightComponentBase* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsSafeForRootSet(ULightComponentBase* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_Modify(ULightComponentBase* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_NotifyObjectReferenceEliminated(ULightComponentBase* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostCDOContruct(ULightComponentBase* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostEditImport(ULightComponentBase* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PostSaveRoot(ULightComponentBase* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_PreDestroyFromReplication(ULightComponentBase* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ShutdownAfterError(ULightComponentBase* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_AddToCluster(ULightComponentBase* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CanBeClusterRoot(ULightComponentBase* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CanBeInCluster(ULightComponentBase* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_CreateCluster(ULightComponentBase* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_OnClusterMarkedAsPendingKill(ULightComponentBase* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
