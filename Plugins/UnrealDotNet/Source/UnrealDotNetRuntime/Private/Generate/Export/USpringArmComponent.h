#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/SpringArmComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

class E_PROTECTED_WRAP_USpringArmComponent : protected USpringArmComponent
{
public:
	FVector BlendLocations_WRAP(const FVector& DesiredArmLocation, const FVector& TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		return BlendLocations(DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
	}

	void UpdateDesiredArmLocation_WRAP(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpringArmComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpringArmComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BlendLocations(USpringArmComponent* Self, INT_PTR DesiredArmLocation, INT_PTR TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		auto _p0 = *(FVector*)DesiredArmLocation;
		auto _p1 = *(FVector*)TraceHitLocation;
		auto _p2 = bHitSomething;
		auto _p3 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_USpringArmComponent*)Self)->BlendLocations_WRAP(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ApplyWorldOffset(USpringArmComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BeginDestroy(USpringArmComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CalcBoundingCylinder(USpringArmComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CanAttachAsChild(USpringArmComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_DestroyComponent(USpringArmComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_DetachFromComponent(USpringArmComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_DetachFromParent(USpringArmComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_DoesSocketExist(USpringArmComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetCollisionObjectType(USpringArmComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetCollisionResponseToChannel(USpringArmComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetComponentVelocity(USpringArmComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetSocketLocation(USpringArmComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetSocketQuaternion(USpringArmComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetSocketRotation(USpringArmComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetSocketTransform(USpringArmComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_HasAnySockets(USpringArmComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsAnySimulatingPhysics(USpringArmComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsPrecomputedLightingValid(USpringArmComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsSimulatingPhysics(USpringArmComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsVisible(USpringArmComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsVisibleInEditor(USpringArmComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsWorldGeometry(USpringArmComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_MoveComponentImpl(USpringArmComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USpringArmComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnAttachmentChanged(USpringArmComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnChildAttached(USpringArmComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnChildDetached(USpringArmComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnComponentDestroyed(USpringArmComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnHiddenInGameChanged(USpringArmComponent* Self)
	{
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnRegister(USpringArmComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnUnregister(USpringArmComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnUpdateTransform(USpringArmComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnVisibilityChanged(USpringArmComponent* Self)
	{
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostNetReceive(USpringArmComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostRepNotifies(USpringArmComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PreNetReceive(USpringArmComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PropagateLightingScenarioChange(USpringArmComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SetRelativeScale3D(USpringArmComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ShouldCollideWhenPlacing(USpringArmComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ShouldCreateRenderState(USpringArmComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UpdatePhysicsVolume(USpringArmComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_Activate(USpringArmComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_AddTickPrerequisiteActor(USpringArmComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_AddTickPrerequisiteComponent(USpringArmComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BeginPlay(USpringArmComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CreateRenderState_Concurrent(USpringArmComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_Deactivate(USpringArmComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_DestroyRenderState_Concurrent(USpringArmComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetComponentClassCanReplicate(USpringArmComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetReadableName(USpringArmComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_HasValidPhysicsState(USpringArmComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_InitializeComponent(USpringArmComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_InvalidateLightingCacheDetailed(USpringArmComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsActive(USpringArmComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsEditorOnly(USpringArmComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsNameStableForNetworking(USpringArmComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsNavigationRelevant(USpringArmComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsReadyForOwnerToAutoDestroy(USpringArmComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsSupportedForNetworking(USpringArmComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_MarkAsEditorOnlySubobject(USpringArmComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_NeedsLoadForClient(USpringArmComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_NeedsLoadForEditorGame(USpringArmComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_NeedsLoadForServer(USpringArmComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnActorEnableCollisionChanged(USpringArmComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnComponentCreated(USpringArmComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnCreatePhysicsState(USpringArmComponent* Self)
	{
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnDestroyPhysicsState(USpringArmComponent* Self)
	{
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostInitProperties(USpringArmComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostLoad(USpringArmComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostRename(USpringArmComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_RegisterComponentTickFunctions(USpringArmComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_RemoveTickPrerequisiteActor(USpringArmComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_RemoveTickPrerequisiteComponent(USpringArmComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_RequiresGameThreadEndOfFrameRecreate(USpringArmComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_RequiresGameThreadEndOfFrameUpdates(USpringArmComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SendRenderDynamicData_Concurrent(USpringArmComponent* Self)
	{
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SendRenderTransform_Concurrent(USpringArmComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SetActive(USpringArmComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SetAutoActivate(USpringArmComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SetComponentTickEnabled(USpringArmComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_SetComponentTickEnabledAsync(USpringArmComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ShouldActivate(USpringArmComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USpringArmComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ShouldCreatePhysicsState(USpringArmComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ToggleActive(USpringArmComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UninitializeComponent(USpringArmComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_AreNativePropertiesIdenticalTo(USpringArmComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CheckDefaultSubobjectsInternal(USpringArmComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_FinishDestroy(USpringArmComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetDesc(USpringArmComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetDetailedInfoInternal(USpringArmComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsAsset(USpringArmComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsFullNameStableForNetworking(USpringArmComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsLocalizedResource(USpringArmComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsPostLoadThreadSafe(USpringArmComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsReadyForFinishDestroy(USpringArmComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsSafeForRootSet(USpringArmComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_Modify(USpringArmComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_NotifyObjectReferenceEliminated(USpringArmComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostCDOContruct(USpringArmComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostEditImport(USpringArmComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PostSaveRoot(USpringArmComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_PreDestroyFromReplication(USpringArmComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_ShutdownAfterError(USpringArmComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_AddToCluster(USpringArmComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CanBeClusterRoot(USpringArmComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CanBeInCluster(USpringArmComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_CreateCluster(USpringArmComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_OnClusterMarkedAsPendingKill(USpringArmComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
