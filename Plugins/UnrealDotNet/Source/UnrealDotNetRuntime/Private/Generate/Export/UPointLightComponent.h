#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PointLightComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

class E_PROTECTED_WRAP_UPointLightComponent : protected UPointLightComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPointLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPointLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ComputeLightBrightness(UPointLightComponent* Self)
	{
		return Self->ComputeLightBrightness();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetBoundingBox(UPointLightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetLightmassSettings(UPointLightComponent* Self)
	{
		return (INT_PTR) new FLightmassLightSettings(Self->GetLightmassSettings());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetLightPosition(UPointLightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetUniformPenumbraSize(UPointLightComponent* Self)
	{
		return Self->GetUniformPenumbraSize();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SendRenderTransform_Concurrent(UPointLightComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ApplyWorldOffset(UPointLightComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_BeginDestroy(UPointLightComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CalcBoundingCylinder(UPointLightComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CanAttachAsChild(UPointLightComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_DestroyComponent(UPointLightComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_DetachFromComponent(UPointLightComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_DetachFromParent(UPointLightComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_DoesSocketExist(UPointLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetCollisionObjectType(UPointLightComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetCollisionResponseToChannel(UPointLightComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetComponentVelocity(UPointLightComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetSocketLocation(UPointLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetSocketQuaternion(UPointLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetSocketRotation(UPointLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetSocketTransform(UPointLightComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_HasAnySockets(UPointLightComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsAnySimulatingPhysics(UPointLightComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsPrecomputedLightingValid(UPointLightComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsSimulatingPhysics(UPointLightComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsVisible(UPointLightComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsVisibleInEditor(UPointLightComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsWorldGeometry(UPointLightComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_MoveComponentImpl(UPointLightComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPointLightComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnAttachmentChanged(UPointLightComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnChildAttached(UPointLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnChildDetached(UPointLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnComponentDestroyed(UPointLightComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnHiddenInGameChanged(UPointLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnRegister(UPointLightComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnUnregister(UPointLightComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnUpdateTransform(UPointLightComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnVisibilityChanged(UPointLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostNetReceive(UPointLightComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostRepNotifies(UPointLightComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PreNetReceive(UPointLightComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PropagateLightingScenarioChange(UPointLightComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetRelativeScale3D(UPointLightComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ShouldCollideWhenPlacing(UPointLightComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ShouldCreateRenderState(UPointLightComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_UpdatePhysicsVolume(UPointLightComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_Activate(UPointLightComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_AddTickPrerequisiteActor(UPointLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_AddTickPrerequisiteComponent(UPointLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_BeginPlay(UPointLightComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CreateRenderState_Concurrent(UPointLightComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_Deactivate(UPointLightComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_DestroyRenderState_Concurrent(UPointLightComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetComponentClassCanReplicate(UPointLightComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetReadableName(UPointLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_HasValidPhysicsState(UPointLightComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_InitializeComponent(UPointLightComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_InvalidateLightingCacheDetailed(UPointLightComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsActive(UPointLightComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsEditorOnly(UPointLightComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsNameStableForNetworking(UPointLightComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsNavigationRelevant(UPointLightComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsReadyForOwnerToAutoDestroy(UPointLightComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsSupportedForNetworking(UPointLightComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_MarkAsEditorOnlySubobject(UPointLightComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_NeedsLoadForClient(UPointLightComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_NeedsLoadForEditorGame(UPointLightComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_NeedsLoadForServer(UPointLightComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnActorEnableCollisionChanged(UPointLightComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnComponentCreated(UPointLightComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnCreatePhysicsState(UPointLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnDestroyPhysicsState(UPointLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostInitProperties(UPointLightComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostLoad(UPointLightComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostRename(UPointLightComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_RegisterComponentTickFunctions(UPointLightComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_RemoveTickPrerequisiteActor(UPointLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_RemoveTickPrerequisiteComponent(UPointLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_RequiresGameThreadEndOfFrameRecreate(UPointLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_RequiresGameThreadEndOfFrameUpdates(UPointLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SendRenderDynamicData_Concurrent(UPointLightComponent* Self)
	{
		((E_PROTECTED_WRAP_UPointLightComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetActive(UPointLightComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetAutoActivate(UPointLightComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetComponentTickEnabled(UPointLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetComponentTickEnabledAsync(UPointLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ShouldActivate(UPointLightComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPointLightComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ShouldCreatePhysicsState(UPointLightComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ToggleActive(UPointLightComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_UninitializeComponent(UPointLightComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_AreNativePropertiesIdenticalTo(UPointLightComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CheckDefaultSubobjectsInternal(UPointLightComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_FinishDestroy(UPointLightComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetDesc(UPointLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_GetDetailedInfoInternal(UPointLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsAsset(UPointLightComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsFullNameStableForNetworking(UPointLightComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsLocalizedResource(UPointLightComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsPostLoadThreadSafe(UPointLightComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsReadyForFinishDestroy(UPointLightComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_IsSafeForRootSet(UPointLightComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_Modify(UPointLightComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_NotifyObjectReferenceEliminated(UPointLightComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostCDOContruct(UPointLightComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostEditImport(UPointLightComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PostSaveRoot(UPointLightComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_PreDestroyFromReplication(UPointLightComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_ShutdownAfterError(UPointLightComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_AddToCluster(UPointLightComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CanBeClusterRoot(UPointLightComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CanBeInCluster(UPointLightComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_CreateCluster(UPointLightComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPointLightComponent_OnClusterMarkedAsPendingKill(UPointLightComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
