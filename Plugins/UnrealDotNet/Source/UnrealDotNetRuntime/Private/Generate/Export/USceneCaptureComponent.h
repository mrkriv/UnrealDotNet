#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:59

class E_PROTECTED_WRAP_USceneCaptureComponent : protected USceneCaptureComponent
{
public:
	void UpdateShowFlags_WRAP()
	{
		UpdateShowFlags();
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearHiddenComponents(USceneCaptureComponent* Self)
	{
		Self->ClearHiddenComponents();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ClearShowOnlyComponents(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->ClearShowOnlyComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HideActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->HideActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HideComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->HideComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnRegister(USceneCaptureComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnUnregister(USceneCaptureComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveShowOnlyActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->RemoveShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveShowOnlyComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->RemoveShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetCaptureSortPriority(USceneCaptureComponent* Self, int32 NewCaptureSortPriority)
	{
		auto _p0 = NewCaptureSortPriority;
		Self->SetCaptureSortPriority(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShowOnlyActorComponents(USceneCaptureComponent* Self, AActor* InActor)
	{
		auto _p0 = InActor;
		Self->ShowOnlyActorComponents(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShowOnlyComponent(USceneCaptureComponent* Self, UPrimitiveComponent* InComponent)
	{
		auto _p0 = InComponent;
		Self->ShowOnlyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_UpdateShowFlags(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->UpdateShowFlags_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ApplyWorldOffset(USceneCaptureComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_BeginDestroy(USceneCaptureComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CalcBoundingCylinder(USceneCaptureComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CanAttachAsChild(USceneCaptureComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_DestroyComponent(USceneCaptureComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_DetachFromComponent(USceneCaptureComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_DetachFromParent(USceneCaptureComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_DoesSocketExist(USceneCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetCollisionObjectType(USceneCaptureComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetCollisionResponseToChannel(USceneCaptureComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetComponentVelocity(USceneCaptureComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetSocketLocation(USceneCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetSocketQuaternion(USceneCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetSocketRotation(USceneCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetSocketTransform(USceneCaptureComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HasAnySockets(USceneCaptureComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsAnySimulatingPhysics(USceneCaptureComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsPrecomputedLightingValid(USceneCaptureComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsSimulatingPhysics(USceneCaptureComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsVisible(USceneCaptureComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsVisibleInEditor(USceneCaptureComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsWorldGeometry(USceneCaptureComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_MoveComponentImpl(USceneCaptureComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnAttachmentChanged(USceneCaptureComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnChildAttached(USceneCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnChildDetached(USceneCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnComponentDestroyed(USceneCaptureComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnHiddenInGameChanged(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnUpdateTransform(USceneCaptureComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnVisibilityChanged(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostNetReceive(USceneCaptureComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostRepNotifies(USceneCaptureComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PreNetReceive(USceneCaptureComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PropagateLightingScenarioChange(USceneCaptureComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetRelativeScale3D(USceneCaptureComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShouldCollideWhenPlacing(USceneCaptureComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShouldCreateRenderState(USceneCaptureComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_UpdatePhysicsVolume(USceneCaptureComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_Activate(USceneCaptureComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_AddTickPrerequisiteActor(USceneCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_AddTickPrerequisiteComponent(USceneCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_BeginPlay(USceneCaptureComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CreateRenderState_Concurrent(USceneCaptureComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_Deactivate(USceneCaptureComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_DestroyRenderState_Concurrent(USceneCaptureComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetComponentClassCanReplicate(USceneCaptureComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetReadableName(USceneCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_HasValidPhysicsState(USceneCaptureComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_InitializeComponent(USceneCaptureComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_InvalidateLightingCacheDetailed(USceneCaptureComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsActive(USceneCaptureComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsEditorOnly(USceneCaptureComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsNameStableForNetworking(USceneCaptureComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsNavigationRelevant(USceneCaptureComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsReadyForOwnerToAutoDestroy(USceneCaptureComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsSupportedForNetworking(USceneCaptureComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_MarkAsEditorOnlySubobject(USceneCaptureComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_NeedsLoadForClient(USceneCaptureComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_NeedsLoadForEditorGame(USceneCaptureComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_NeedsLoadForServer(USceneCaptureComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnActorEnableCollisionChanged(USceneCaptureComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnComponentCreated(USceneCaptureComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnCreatePhysicsState(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnDestroyPhysicsState(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostInitProperties(USceneCaptureComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostLoad(USceneCaptureComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostRename(USceneCaptureComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RegisterComponentTickFunctions(USceneCaptureComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveTickPrerequisiteActor(USceneCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RemoveTickPrerequisiteComponent(USceneCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RequiresGameThreadEndOfFrameRecreate(USceneCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_RequiresGameThreadEndOfFrameUpdates(USceneCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SendRenderDynamicData_Concurrent(USceneCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SendRenderTransform_Concurrent(USceneCaptureComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetActive(USceneCaptureComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetAutoActivate(USceneCaptureComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetComponentTickEnabled(USceneCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_SetComponentTickEnabledAsync(USceneCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShouldActivate(USceneCaptureComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USceneCaptureComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShouldCreatePhysicsState(USceneCaptureComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ToggleActive(USceneCaptureComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_UninitializeComponent(USceneCaptureComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_AreNativePropertiesIdenticalTo(USceneCaptureComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CheckDefaultSubobjectsInternal(USceneCaptureComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_FinishDestroy(USceneCaptureComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetDesc(USceneCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_GetDetailedInfoInternal(USceneCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsAsset(USceneCaptureComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsFullNameStableForNetworking(USceneCaptureComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsLocalizedResource(USceneCaptureComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsPostLoadThreadSafe(USceneCaptureComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsReadyForFinishDestroy(USceneCaptureComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_IsSafeForRootSet(USceneCaptureComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_Modify(USceneCaptureComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_NotifyObjectReferenceEliminated(USceneCaptureComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostCDOContruct(USceneCaptureComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostEditImport(USceneCaptureComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PostSaveRoot(USceneCaptureComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_PreDestroyFromReplication(USceneCaptureComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_ShutdownAfterError(USceneCaptureComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_AddToCluster(USceneCaptureComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CanBeClusterRoot(USceneCaptureComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CanBeInCluster(USceneCaptureComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_CreateCluster(USceneCaptureComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USceneCaptureComponent_OnClusterMarkedAsPendingKill(USceneCaptureComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
