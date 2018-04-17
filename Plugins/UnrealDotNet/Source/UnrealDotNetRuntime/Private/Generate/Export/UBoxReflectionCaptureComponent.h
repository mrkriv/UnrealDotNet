#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/BoxReflectionCaptureComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\BoxReflectionCaptureComponent.h:13

class E_PROTECTED_WRAP_UBoxReflectionCaptureComponent : protected UBoxReflectionCaptureComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBoxReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBoxReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetInfluenceBoundingRadius(UBoxReflectionCaptureComponent* Self)
	{
		return Self->GetInfluenceBoundingRadius();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_UpdatePreviewShape(UBoxReflectionCaptureComponent* Self)
	{
		Self->UpdatePreviewShape();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ApplyWorldOffset(UBoxReflectionCaptureComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_BeginDestroy(UBoxReflectionCaptureComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CalcBoundingCylinder(UBoxReflectionCaptureComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CanAttachAsChild(UBoxReflectionCaptureComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_DestroyComponent(UBoxReflectionCaptureComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_DetachFromComponent(UBoxReflectionCaptureComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_DetachFromParent(UBoxReflectionCaptureComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_DoesSocketExist(UBoxReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetCollisionObjectType(UBoxReflectionCaptureComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetCollisionResponseToChannel(UBoxReflectionCaptureComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetComponentVelocity(UBoxReflectionCaptureComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetSocketLocation(UBoxReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetSocketQuaternion(UBoxReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetSocketRotation(UBoxReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetSocketTransform(UBoxReflectionCaptureComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_HasAnySockets(UBoxReflectionCaptureComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsAnySimulatingPhysics(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsPrecomputedLightingValid(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsSimulatingPhysics(UBoxReflectionCaptureComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsVisible(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsVisibleInEditor(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsWorldGeometry(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_MoveComponentImpl(UBoxReflectionCaptureComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnAttachmentChanged(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnChildAttached(UBoxReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnChildDetached(UBoxReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnComponentDestroyed(UBoxReflectionCaptureComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnHiddenInGameChanged(UBoxReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnRegister(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnUnregister(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnUpdateTransform(UBoxReflectionCaptureComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnVisibilityChanged(UBoxReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostNetReceive(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostRepNotifies(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PreNetReceive(UBoxReflectionCaptureComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PropagateLightingScenarioChange(UBoxReflectionCaptureComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SetRelativeScale3D(UBoxReflectionCaptureComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ShouldCollideWhenPlacing(UBoxReflectionCaptureComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ShouldCreateRenderState(UBoxReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_UpdatePhysicsVolume(UBoxReflectionCaptureComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_Activate(UBoxReflectionCaptureComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_AddTickPrerequisiteActor(UBoxReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_AddTickPrerequisiteComponent(UBoxReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_BeginPlay(UBoxReflectionCaptureComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CreateRenderState_Concurrent(UBoxReflectionCaptureComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_Deactivate(UBoxReflectionCaptureComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_DestroyRenderState_Concurrent(UBoxReflectionCaptureComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetComponentClassCanReplicate(UBoxReflectionCaptureComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetReadableName(UBoxReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_HasValidPhysicsState(UBoxReflectionCaptureComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_InitializeComponent(UBoxReflectionCaptureComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_InvalidateLightingCacheDetailed(UBoxReflectionCaptureComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsActive(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsEditorOnly(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsNameStableForNetworking(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsNavigationRelevant(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsReadyForOwnerToAutoDestroy(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsSupportedForNetworking(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_MarkAsEditorOnlySubobject(UBoxReflectionCaptureComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_NeedsLoadForClient(UBoxReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_NeedsLoadForEditorGame(UBoxReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_NeedsLoadForServer(UBoxReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnActorEnableCollisionChanged(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnComponentCreated(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnCreatePhysicsState(UBoxReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnDestroyPhysicsState(UBoxReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostInitProperties(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostLoad(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostRename(UBoxReflectionCaptureComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_RegisterComponentTickFunctions(UBoxReflectionCaptureComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_RemoveTickPrerequisiteActor(UBoxReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_RemoveTickPrerequisiteComponent(UBoxReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_RequiresGameThreadEndOfFrameRecreate(UBoxReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_RequiresGameThreadEndOfFrameUpdates(UBoxReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SendRenderDynamicData_Concurrent(UBoxReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SendRenderTransform_Concurrent(UBoxReflectionCaptureComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SetActive(UBoxReflectionCaptureComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SetAutoActivate(UBoxReflectionCaptureComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SetComponentTickEnabled(UBoxReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_SetComponentTickEnabledAsync(UBoxReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ShouldActivate(UBoxReflectionCaptureComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UBoxReflectionCaptureComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ShouldCreatePhysicsState(UBoxReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ToggleActive(UBoxReflectionCaptureComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_UninitializeComponent(UBoxReflectionCaptureComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_AreNativePropertiesIdenticalTo(UBoxReflectionCaptureComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CheckDefaultSubobjectsInternal(UBoxReflectionCaptureComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_FinishDestroy(UBoxReflectionCaptureComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetDesc(UBoxReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_GetDetailedInfoInternal(UBoxReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsAsset(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsFullNameStableForNetworking(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsLocalizedResource(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsPostLoadThreadSafe(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsReadyForFinishDestroy(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_IsSafeForRootSet(UBoxReflectionCaptureComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_Modify(UBoxReflectionCaptureComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_NotifyObjectReferenceEliminated(UBoxReflectionCaptureComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostCDOContruct(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostEditImport(UBoxReflectionCaptureComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PostSaveRoot(UBoxReflectionCaptureComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_PreDestroyFromReplication(UBoxReflectionCaptureComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_ShutdownAfterError(UBoxReflectionCaptureComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_AddToCluster(UBoxReflectionCaptureComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CanBeClusterRoot(UBoxReflectionCaptureComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CanBeInCluster(UBoxReflectionCaptureComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_CreateCluster(UBoxReflectionCaptureComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UBoxReflectionCaptureComponent_OnClusterMarkedAsPendingKill(UBoxReflectionCaptureComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
