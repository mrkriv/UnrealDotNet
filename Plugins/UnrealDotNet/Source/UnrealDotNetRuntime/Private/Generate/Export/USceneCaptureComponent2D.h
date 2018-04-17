#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent2D.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:19

class E_PROTECTED_WRAP_USceneCaptureComponent2D : protected USceneCaptureComponent2D
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent2D(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent2D>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnRegister(USceneCaptureComponent2D* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnUnregister(USceneCaptureComponent2D* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ApplyWorldOffset(USceneCaptureComponent2D* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_BeginDestroy(USceneCaptureComponent2D* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CalcBoundingCylinder(USceneCaptureComponent2D* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CanAttachAsChild(USceneCaptureComponent2D* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_DestroyComponent(USceneCaptureComponent2D* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_DetachFromComponent(USceneCaptureComponent2D* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_DetachFromParent(USceneCaptureComponent2D* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_DoesSocketExist(USceneCaptureComponent2D* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetCollisionObjectType(USceneCaptureComponent2D* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetCollisionResponseToChannel(USceneCaptureComponent2D* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetComponentVelocity(USceneCaptureComponent2D* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetSocketLocation(USceneCaptureComponent2D* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetSocketQuaternion(USceneCaptureComponent2D* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetSocketRotation(USceneCaptureComponent2D* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetSocketTransform(USceneCaptureComponent2D* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_HasAnySockets(USceneCaptureComponent2D* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsAnySimulatingPhysics(USceneCaptureComponent2D* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsPrecomputedLightingValid(USceneCaptureComponent2D* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsSimulatingPhysics(USceneCaptureComponent2D* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsVisible(USceneCaptureComponent2D* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsVisibleInEditor(USceneCaptureComponent2D* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsWorldGeometry(USceneCaptureComponent2D* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_MoveComponentImpl(USceneCaptureComponent2D* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnAttachmentChanged(USceneCaptureComponent2D* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnChildAttached(USceneCaptureComponent2D* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnChildDetached(USceneCaptureComponent2D* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnComponentDestroyed(USceneCaptureComponent2D* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnHiddenInGameChanged(USceneCaptureComponent2D* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnUpdateTransform(USceneCaptureComponent2D* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnVisibilityChanged(USceneCaptureComponent2D* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostNetReceive(USceneCaptureComponent2D* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostRepNotifies(USceneCaptureComponent2D* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PreNetReceive(USceneCaptureComponent2D* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PropagateLightingScenarioChange(USceneCaptureComponent2D* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SetRelativeScale3D(USceneCaptureComponent2D* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ShouldCollideWhenPlacing(USceneCaptureComponent2D* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ShouldCreateRenderState(USceneCaptureComponent2D* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_UpdatePhysicsVolume(USceneCaptureComponent2D* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_Activate(USceneCaptureComponent2D* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_AddTickPrerequisiteActor(USceneCaptureComponent2D* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_AddTickPrerequisiteComponent(USceneCaptureComponent2D* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_BeginPlay(USceneCaptureComponent2D* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CreateRenderState_Concurrent(USceneCaptureComponent2D* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_Deactivate(USceneCaptureComponent2D* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_DestroyRenderState_Concurrent(USceneCaptureComponent2D* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetComponentClassCanReplicate(USceneCaptureComponent2D* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetReadableName(USceneCaptureComponent2D* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_HasValidPhysicsState(USceneCaptureComponent2D* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_InitializeComponent(USceneCaptureComponent2D* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_InvalidateLightingCacheDetailed(USceneCaptureComponent2D* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsActive(USceneCaptureComponent2D* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsEditorOnly(USceneCaptureComponent2D* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsNameStableForNetworking(USceneCaptureComponent2D* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsNavigationRelevant(USceneCaptureComponent2D* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsReadyForOwnerToAutoDestroy(USceneCaptureComponent2D* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsSupportedForNetworking(USceneCaptureComponent2D* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_MarkAsEditorOnlySubobject(USceneCaptureComponent2D* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_NeedsLoadForClient(USceneCaptureComponent2D* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_NeedsLoadForEditorGame(USceneCaptureComponent2D* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_NeedsLoadForServer(USceneCaptureComponent2D* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnActorEnableCollisionChanged(USceneCaptureComponent2D* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnComponentCreated(USceneCaptureComponent2D* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnCreatePhysicsState(USceneCaptureComponent2D* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnDestroyPhysicsState(USceneCaptureComponent2D* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostInitProperties(USceneCaptureComponent2D* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostLoad(USceneCaptureComponent2D* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostRename(USceneCaptureComponent2D* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_RegisterComponentTickFunctions(USceneCaptureComponent2D* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_RemoveTickPrerequisiteActor(USceneCaptureComponent2D* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_RemoveTickPrerequisiteComponent(USceneCaptureComponent2D* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_RequiresGameThreadEndOfFrameRecreate(USceneCaptureComponent2D* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_RequiresGameThreadEndOfFrameUpdates(USceneCaptureComponent2D* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SendRenderDynamicData_Concurrent(USceneCaptureComponent2D* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SendRenderTransform_Concurrent(USceneCaptureComponent2D* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SetActive(USceneCaptureComponent2D* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SetAutoActivate(USceneCaptureComponent2D* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SetComponentTickEnabled(USceneCaptureComponent2D* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_SetComponentTickEnabledAsync(USceneCaptureComponent2D* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ShouldActivate(USceneCaptureComponent2D* Self)
	{
		return ((E_PROTECTED_WRAP_USceneCaptureComponent2D*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ShouldCreatePhysicsState(USceneCaptureComponent2D* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ToggleActive(USceneCaptureComponent2D* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_UninitializeComponent(USceneCaptureComponent2D* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_AreNativePropertiesIdenticalTo(USceneCaptureComponent2D* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CheckDefaultSubobjectsInternal(USceneCaptureComponent2D* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_FinishDestroy(USceneCaptureComponent2D* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetDesc(USceneCaptureComponent2D* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_GetDetailedInfoInternal(USceneCaptureComponent2D* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsAsset(USceneCaptureComponent2D* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsFullNameStableForNetworking(USceneCaptureComponent2D* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsLocalizedResource(USceneCaptureComponent2D* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsPostLoadThreadSafe(USceneCaptureComponent2D* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsReadyForFinishDestroy(USceneCaptureComponent2D* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_IsSafeForRootSet(USceneCaptureComponent2D* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_Modify(USceneCaptureComponent2D* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_NotifyObjectReferenceEliminated(USceneCaptureComponent2D* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostCDOContruct(USceneCaptureComponent2D* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostEditImport(USceneCaptureComponent2D* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PostSaveRoot(USceneCaptureComponent2D* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_PreDestroyFromReplication(USceneCaptureComponent2D* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_ShutdownAfterError(USceneCaptureComponent2D* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_AddToCluster(USceneCaptureComponent2D* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CanBeClusterRoot(USceneCaptureComponent2D* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CanBeInCluster(USceneCaptureComponent2D* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_CreateCluster(USceneCaptureComponent2D* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent2D_OnClusterMarkedAsPendingKill(USceneCaptureComponent2D* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
