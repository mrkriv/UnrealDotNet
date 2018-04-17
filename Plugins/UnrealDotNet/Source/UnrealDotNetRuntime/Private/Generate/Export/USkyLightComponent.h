#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SkyLightComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:99

class E_PROTECTED_WRAP_USkyLightComponent : protected USkyLightComponent
{
public:
	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void UpdateLimitedRenderingStateFast_WRAP()
	{
		UpdateLimitedRenderingStateFast();
	}

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkyLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkyLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CreateRenderState_Concurrent(USkyLightComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_DestroyRenderState_Concurrent(USkyLightComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnVisibilityChanged(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RecaptureSky(USkyLightComponent* Self)
	{
		Self->RecaptureSky();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SanitizeCubemapSize(USkyLightComponent* Self)
	{
		Self->SanitizeCubemapSize();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetBlendDestinationCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdateLimitedRenderingStateFast(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->UpdateLimitedRenderingStateFast_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ApplyWorldOffset(USkyLightComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_BeginDestroy(USkyLightComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CalcBoundingCylinder(USkyLightComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CanAttachAsChild(USkyLightComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_DestroyComponent(USkyLightComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_DetachFromComponent(USkyLightComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_DetachFromParent(USkyLightComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_DoesSocketExist(USkyLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetCollisionObjectType(USkyLightComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetCollisionResponseToChannel(USkyLightComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetComponentVelocity(USkyLightComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetSocketLocation(USkyLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetSocketQuaternion(USkyLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetSocketRotation(USkyLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetSocketTransform(USkyLightComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_HasAnySockets(USkyLightComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsAnySimulatingPhysics(USkyLightComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsPrecomputedLightingValid(USkyLightComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsSimulatingPhysics(USkyLightComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsVisible(USkyLightComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsVisibleInEditor(USkyLightComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsWorldGeometry(USkyLightComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_MoveComponentImpl(USkyLightComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USkyLightComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnAttachmentChanged(USkyLightComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnChildAttached(USkyLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnChildDetached(USkyLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnComponentDestroyed(USkyLightComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnHiddenInGameChanged(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnRegister(USkyLightComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnUnregister(USkyLightComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnUpdateTransform(USkyLightComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostNetReceive(USkyLightComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostRepNotifies(USkyLightComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PreNetReceive(USkyLightComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PropagateLightingScenarioChange(USkyLightComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetRelativeScale3D(USkyLightComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ShouldCollideWhenPlacing(USkyLightComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ShouldCreateRenderState(USkyLightComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdatePhysicsVolume(USkyLightComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_Activate(USkyLightComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_AddTickPrerequisiteActor(USkyLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_AddTickPrerequisiteComponent(USkyLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_BeginPlay(USkyLightComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_Deactivate(USkyLightComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetComponentClassCanReplicate(USkyLightComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetReadableName(USkyLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USkyLightComponent_HasValidPhysicsState(USkyLightComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_InitializeComponent(USkyLightComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_InvalidateLightingCacheDetailed(USkyLightComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsActive(USkyLightComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsEditorOnly(USkyLightComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsNameStableForNetworking(USkyLightComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsNavigationRelevant(USkyLightComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsReadyForOwnerToAutoDestroy(USkyLightComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsSupportedForNetworking(USkyLightComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_MarkAsEditorOnlySubobject(USkyLightComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_NeedsLoadForClient(USkyLightComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_NeedsLoadForEditorGame(USkyLightComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_NeedsLoadForServer(USkyLightComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnActorEnableCollisionChanged(USkyLightComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnComponentCreated(USkyLightComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnCreatePhysicsState(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnDestroyPhysicsState(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostInitProperties(USkyLightComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostLoad(USkyLightComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostRename(USkyLightComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RegisterComponentTickFunctions(USkyLightComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RemoveTickPrerequisiteActor(USkyLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RemoveTickPrerequisiteComponent(USkyLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RequiresGameThreadEndOfFrameRecreate(USkyLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RequiresGameThreadEndOfFrameUpdates(USkyLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SendRenderDynamicData_Concurrent(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SendRenderTransform_Concurrent(USkyLightComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetActive(USkyLightComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetAutoActivate(USkyLightComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetComponentTickEnabled(USkyLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetComponentTickEnabledAsync(USkyLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ShouldActivate(USkyLightComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USkyLightComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ShouldCreatePhysicsState(USkyLightComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ToggleActive(USkyLightComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UninitializeComponent(USkyLightComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_AreNativePropertiesIdenticalTo(USkyLightComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CheckDefaultSubobjectsInternal(USkyLightComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_FinishDestroy(USkyLightComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetDesc(USkyLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USkyLightComponent_GetDetailedInfoInternal(USkyLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsAsset(USkyLightComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsFullNameStableForNetworking(USkyLightComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsLocalizedResource(USkyLightComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsPostLoadThreadSafe(USkyLightComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsReadyForFinishDestroy(USkyLightComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsSafeForRootSet(USkyLightComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_Modify(USkyLightComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_NotifyObjectReferenceEliminated(USkyLightComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostCDOContruct(USkyLightComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostEditImport(USkyLightComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PostSaveRoot(USkyLightComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_PreDestroyFromReplication(USkyLightComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_ShutdownAfterError(USkyLightComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_AddToCluster(USkyLightComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CanBeClusterRoot(USkyLightComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CanBeInCluster(USkyLightComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_CreateCluster(USkyLightComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_OnClusterMarkedAsPendingKill(USkyLightComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
