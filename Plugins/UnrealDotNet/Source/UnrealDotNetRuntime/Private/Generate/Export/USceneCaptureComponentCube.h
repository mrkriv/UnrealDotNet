#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponentCube.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

class E_PROTECTED_WRAP_USceneCaptureComponentCube : protected USceneCaptureComponentCube
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponentCube(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponentCube>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CaptureScene(USceneCaptureComponentCube* Self)
	{
		Self->CaptureScene();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CaptureSceneDeferred(USceneCaptureComponentCube* Self)
	{
		Self->CaptureSceneDeferred();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnRegister(USceneCaptureComponentCube* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SendRenderTransform_Concurrent(USceneCaptureComponentCube* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_UpdateContent(USceneCaptureComponentCube* Self)
	{
		Self->UpdateContent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnUnregister(USceneCaptureComponentCube* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ApplyWorldOffset(USceneCaptureComponentCube* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_BeginDestroy(USceneCaptureComponentCube* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CalcBoundingCylinder(USceneCaptureComponentCube* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CanAttachAsChild(USceneCaptureComponentCube* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_DestroyComponent(USceneCaptureComponentCube* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_DetachFromComponent(USceneCaptureComponentCube* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_DetachFromParent(USceneCaptureComponentCube* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_DoesSocketExist(USceneCaptureComponentCube* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetCollisionObjectType(USceneCaptureComponentCube* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetCollisionResponseToChannel(USceneCaptureComponentCube* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetComponentVelocity(USceneCaptureComponentCube* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetSocketLocation(USceneCaptureComponentCube* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetSocketQuaternion(USceneCaptureComponentCube* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetSocketRotation(USceneCaptureComponentCube* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetSocketTransform(USceneCaptureComponentCube* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_HasAnySockets(USceneCaptureComponentCube* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsAnySimulatingPhysics(USceneCaptureComponentCube* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsPrecomputedLightingValid(USceneCaptureComponentCube* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsSimulatingPhysics(USceneCaptureComponentCube* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsVisible(USceneCaptureComponentCube* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsVisibleInEditor(USceneCaptureComponentCube* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsWorldGeometry(USceneCaptureComponentCube* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_MoveComponentImpl(USceneCaptureComponentCube* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnAttachmentChanged(USceneCaptureComponentCube* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnChildAttached(USceneCaptureComponentCube* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnChildDetached(USceneCaptureComponentCube* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnComponentDestroyed(USceneCaptureComponentCube* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnHiddenInGameChanged(USceneCaptureComponentCube* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnUpdateTransform(USceneCaptureComponentCube* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnVisibilityChanged(USceneCaptureComponentCube* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostNetReceive(USceneCaptureComponentCube* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostRepNotifies(USceneCaptureComponentCube* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PreNetReceive(USceneCaptureComponentCube* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PropagateLightingScenarioChange(USceneCaptureComponentCube* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SetRelativeScale3D(USceneCaptureComponentCube* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ShouldCollideWhenPlacing(USceneCaptureComponentCube* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ShouldCreateRenderState(USceneCaptureComponentCube* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_UpdatePhysicsVolume(USceneCaptureComponentCube* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_Activate(USceneCaptureComponentCube* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_AddTickPrerequisiteActor(USceneCaptureComponentCube* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_AddTickPrerequisiteComponent(USceneCaptureComponentCube* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_BeginPlay(USceneCaptureComponentCube* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CreateRenderState_Concurrent(USceneCaptureComponentCube* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_Deactivate(USceneCaptureComponentCube* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_DestroyRenderState_Concurrent(USceneCaptureComponentCube* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetComponentClassCanReplicate(USceneCaptureComponentCube* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetReadableName(USceneCaptureComponentCube* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_HasValidPhysicsState(USceneCaptureComponentCube* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_InitializeComponent(USceneCaptureComponentCube* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_InvalidateLightingCacheDetailed(USceneCaptureComponentCube* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsActive(USceneCaptureComponentCube* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsEditorOnly(USceneCaptureComponentCube* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsNameStableForNetworking(USceneCaptureComponentCube* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsNavigationRelevant(USceneCaptureComponentCube* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsReadyForOwnerToAutoDestroy(USceneCaptureComponentCube* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsSupportedForNetworking(USceneCaptureComponentCube* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_MarkAsEditorOnlySubobject(USceneCaptureComponentCube* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_NeedsLoadForClient(USceneCaptureComponentCube* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_NeedsLoadForEditorGame(USceneCaptureComponentCube* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_NeedsLoadForServer(USceneCaptureComponentCube* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnActorEnableCollisionChanged(USceneCaptureComponentCube* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnComponentCreated(USceneCaptureComponentCube* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnCreatePhysicsState(USceneCaptureComponentCube* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnDestroyPhysicsState(USceneCaptureComponentCube* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostInitProperties(USceneCaptureComponentCube* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostLoad(USceneCaptureComponentCube* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostRename(USceneCaptureComponentCube* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_RegisterComponentTickFunctions(USceneCaptureComponentCube* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_RemoveTickPrerequisiteActor(USceneCaptureComponentCube* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_RemoveTickPrerequisiteComponent(USceneCaptureComponentCube* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_RequiresGameThreadEndOfFrameRecreate(USceneCaptureComponentCube* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_RequiresGameThreadEndOfFrameUpdates(USceneCaptureComponentCube* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SendRenderDynamicData_Concurrent(USceneCaptureComponentCube* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SetActive(USceneCaptureComponentCube* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SetAutoActivate(USceneCaptureComponentCube* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SetComponentTickEnabled(USceneCaptureComponentCube* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_SetComponentTickEnabledAsync(USceneCaptureComponentCube* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ShouldActivate(USceneCaptureComponentCube* Self)
	{
		return ((E_PROTECTED_WRAP_USceneCaptureComponentCube*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ShouldCreatePhysicsState(USceneCaptureComponentCube* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ToggleActive(USceneCaptureComponentCube* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_UninitializeComponent(USceneCaptureComponentCube* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_AreNativePropertiesIdenticalTo(USceneCaptureComponentCube* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CheckDefaultSubobjectsInternal(USceneCaptureComponentCube* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_FinishDestroy(USceneCaptureComponentCube* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetDesc(USceneCaptureComponentCube* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_GetDetailedInfoInternal(USceneCaptureComponentCube* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsAsset(USceneCaptureComponentCube* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsFullNameStableForNetworking(USceneCaptureComponentCube* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsLocalizedResource(USceneCaptureComponentCube* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsPostLoadThreadSafe(USceneCaptureComponentCube* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsReadyForFinishDestroy(USceneCaptureComponentCube* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_IsSafeForRootSet(USceneCaptureComponentCube* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_Modify(USceneCaptureComponentCube* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_NotifyObjectReferenceEliminated(USceneCaptureComponentCube* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostCDOContruct(USceneCaptureComponentCube* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostEditImport(USceneCaptureComponentCube* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PostSaveRoot(USceneCaptureComponentCube* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_PreDestroyFromReplication(USceneCaptureComponentCube* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_ShutdownAfterError(USceneCaptureComponentCube* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_AddToCluster(USceneCaptureComponentCube* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CanBeClusterRoot(USceneCaptureComponentCube* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CanBeInCluster(USceneCaptureComponentCube* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_CreateCluster(USceneCaptureComponentCube* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponentCube_OnClusterMarkedAsPendingKill(USceneCaptureComponentCube* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
