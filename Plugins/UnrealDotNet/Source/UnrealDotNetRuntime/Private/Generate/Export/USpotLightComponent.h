#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SpotLightComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

class E_PROTECTED_WRAP_USpotLightComponent : protected USpotLightComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpotLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpotLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ComputeLightBrightness(USpotLightComponent* Self)
	{
		return Self->ComputeLightBrightness();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetBoundingBox(USpotLightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetLightmassSettings(USpotLightComponent* Self)
	{
		return (INT_PTR) new FLightmassLightSettings(Self->GetLightmassSettings());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetLightPosition(USpotLightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetUniformPenumbraSize(USpotLightComponent* Self)
	{
		return Self->GetUniformPenumbraSize();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SendRenderTransform_Concurrent(USpotLightComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ApplyWorldOffset(USpotLightComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_BeginDestroy(USpotLightComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CalcBoundingCylinder(USpotLightComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CanAttachAsChild(USpotLightComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_DestroyComponent(USpotLightComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_DetachFromComponent(USpotLightComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_DetachFromParent(USpotLightComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_DoesSocketExist(USpotLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetCollisionObjectType(USpotLightComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetCollisionResponseToChannel(USpotLightComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetComponentVelocity(USpotLightComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetSocketLocation(USpotLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetSocketQuaternion(USpotLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetSocketRotation(USpotLightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetSocketTransform(USpotLightComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_HasAnySockets(USpotLightComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsAnySimulatingPhysics(USpotLightComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsPrecomputedLightingValid(USpotLightComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsSimulatingPhysics(USpotLightComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsVisible(USpotLightComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsVisibleInEditor(USpotLightComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsWorldGeometry(USpotLightComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_MoveComponentImpl(USpotLightComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USpotLightComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnAttachmentChanged(USpotLightComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnChildAttached(USpotLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnChildDetached(USpotLightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnComponentDestroyed(USpotLightComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnHiddenInGameChanged(USpotLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnRegister(USpotLightComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnUnregister(USpotLightComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnUpdateTransform(USpotLightComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnVisibilityChanged(USpotLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostNetReceive(USpotLightComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostRepNotifies(USpotLightComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PreNetReceive(USpotLightComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PropagateLightingScenarioChange(USpotLightComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetRelativeScale3D(USpotLightComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ShouldCollideWhenPlacing(USpotLightComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ShouldCreateRenderState(USpotLightComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_UpdatePhysicsVolume(USpotLightComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_Activate(USpotLightComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_AddTickPrerequisiteActor(USpotLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_AddTickPrerequisiteComponent(USpotLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_BeginPlay(USpotLightComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CreateRenderState_Concurrent(USpotLightComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_Deactivate(USpotLightComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_DestroyRenderState_Concurrent(USpotLightComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetComponentClassCanReplicate(USpotLightComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetReadableName(USpotLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_HasValidPhysicsState(USpotLightComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_InitializeComponent(USpotLightComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_InvalidateLightingCacheDetailed(USpotLightComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsActive(USpotLightComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsEditorOnly(USpotLightComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsNameStableForNetworking(USpotLightComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsNavigationRelevant(USpotLightComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsReadyForOwnerToAutoDestroy(USpotLightComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsSupportedForNetworking(USpotLightComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_MarkAsEditorOnlySubobject(USpotLightComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_NeedsLoadForClient(USpotLightComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_NeedsLoadForEditorGame(USpotLightComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_NeedsLoadForServer(USpotLightComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnActorEnableCollisionChanged(USpotLightComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnComponentCreated(USpotLightComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnCreatePhysicsState(USpotLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnDestroyPhysicsState(USpotLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostInitProperties(USpotLightComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostLoad(USpotLightComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostRename(USpotLightComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_RegisterComponentTickFunctions(USpotLightComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_RemoveTickPrerequisiteActor(USpotLightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_RemoveTickPrerequisiteComponent(USpotLightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_RequiresGameThreadEndOfFrameRecreate(USpotLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_RequiresGameThreadEndOfFrameUpdates(USpotLightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SendRenderDynamicData_Concurrent(USpotLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USpotLightComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetActive(USpotLightComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetAutoActivate(USpotLightComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetComponentTickEnabled(USpotLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetComponentTickEnabledAsync(USpotLightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ShouldActivate(USpotLightComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USpotLightComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ShouldCreatePhysicsState(USpotLightComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ToggleActive(USpotLightComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_UninitializeComponent(USpotLightComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_AreNativePropertiesIdenticalTo(USpotLightComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CheckDefaultSubobjectsInternal(USpotLightComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_FinishDestroy(USpotLightComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetDesc(USpotLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetDetailedInfoInternal(USpotLightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsAsset(USpotLightComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsFullNameStableForNetworking(USpotLightComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsLocalizedResource(USpotLightComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsPostLoadThreadSafe(USpotLightComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsReadyForFinishDestroy(USpotLightComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_IsSafeForRootSet(USpotLightComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_Modify(USpotLightComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_NotifyObjectReferenceEliminated(USpotLightComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostCDOContruct(USpotLightComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostEditImport(USpotLightComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PostSaveRoot(USpotLightComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_PreDestroyFromReplication(USpotLightComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_ShutdownAfterError(USpotLightComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_AddToCluster(USpotLightComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CanBeClusterRoot(USpotLightComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CanBeInCluster(USpotLightComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_CreateCluster(USpotLightComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_OnClusterMarkedAsPendingKill(USpotLightComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
