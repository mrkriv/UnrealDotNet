#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PlaneReflectionCaptureComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PlaneReflectionCaptureComponent.h:13

class E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent : protected UPlaneReflectionCaptureComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlaneReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlaneReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetInfluenceBoundingRadius(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->GetInfluenceBoundingRadius();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_UpdatePreviewShape(UPlaneReflectionCaptureComponent* Self)
	{
		Self->UpdatePreviewShape();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ApplyWorldOffset(UPlaneReflectionCaptureComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_BeginDestroy(UPlaneReflectionCaptureComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CalcBoundingCylinder(UPlaneReflectionCaptureComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CanAttachAsChild(UPlaneReflectionCaptureComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_DestroyComponent(UPlaneReflectionCaptureComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_DetachFromComponent(UPlaneReflectionCaptureComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_DetachFromParent(UPlaneReflectionCaptureComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_DoesSocketExist(UPlaneReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetCollisionObjectType(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetCollisionResponseToChannel(UPlaneReflectionCaptureComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetComponentVelocity(UPlaneReflectionCaptureComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetSocketLocation(UPlaneReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetSocketQuaternion(UPlaneReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetSocketRotation(UPlaneReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetSocketTransform(UPlaneReflectionCaptureComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_HasAnySockets(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsAnySimulatingPhysics(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsPrecomputedLightingValid(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsSimulatingPhysics(UPlaneReflectionCaptureComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsVisible(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsVisibleInEditor(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsWorldGeometry(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_MoveComponentImpl(UPlaneReflectionCaptureComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnAttachmentChanged(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnChildAttached(UPlaneReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnChildDetached(UPlaneReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnComponentDestroyed(UPlaneReflectionCaptureComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnHiddenInGameChanged(UPlaneReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnRegister(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnUnregister(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnUpdateTransform(UPlaneReflectionCaptureComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnVisibilityChanged(UPlaneReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostNetReceive(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostRepNotifies(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PreNetReceive(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PropagateLightingScenarioChange(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SetRelativeScale3D(UPlaneReflectionCaptureComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ShouldCollideWhenPlacing(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ShouldCreateRenderState(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_UpdatePhysicsVolume(UPlaneReflectionCaptureComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_Activate(UPlaneReflectionCaptureComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_AddTickPrerequisiteActor(UPlaneReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_AddTickPrerequisiteComponent(UPlaneReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_BeginPlay(UPlaneReflectionCaptureComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CreateRenderState_Concurrent(UPlaneReflectionCaptureComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_Deactivate(UPlaneReflectionCaptureComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_DestroyRenderState_Concurrent(UPlaneReflectionCaptureComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetComponentClassCanReplicate(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetReadableName(UPlaneReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_HasValidPhysicsState(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_InitializeComponent(UPlaneReflectionCaptureComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_InvalidateLightingCacheDetailed(UPlaneReflectionCaptureComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsActive(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsEditorOnly(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsNameStableForNetworking(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsNavigationRelevant(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsReadyForOwnerToAutoDestroy(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsSupportedForNetworking(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_MarkAsEditorOnlySubobject(UPlaneReflectionCaptureComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_NeedsLoadForClient(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_NeedsLoadForEditorGame(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_NeedsLoadForServer(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnActorEnableCollisionChanged(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnComponentCreated(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnCreatePhysicsState(UPlaneReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnDestroyPhysicsState(UPlaneReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostInitProperties(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostLoad(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostRename(UPlaneReflectionCaptureComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_RegisterComponentTickFunctions(UPlaneReflectionCaptureComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_RemoveTickPrerequisiteActor(UPlaneReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_RemoveTickPrerequisiteComponent(UPlaneReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_RequiresGameThreadEndOfFrameRecreate(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_RequiresGameThreadEndOfFrameUpdates(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SendRenderDynamicData_Concurrent(UPlaneReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SendRenderTransform_Concurrent(UPlaneReflectionCaptureComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SetActive(UPlaneReflectionCaptureComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SetAutoActivate(UPlaneReflectionCaptureComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SetComponentTickEnabled(UPlaneReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_SetComponentTickEnabledAsync(UPlaneReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ShouldActivate(UPlaneReflectionCaptureComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPlaneReflectionCaptureComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ShouldCreatePhysicsState(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ToggleActive(UPlaneReflectionCaptureComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_UninitializeComponent(UPlaneReflectionCaptureComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_AreNativePropertiesIdenticalTo(UPlaneReflectionCaptureComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CheckDefaultSubobjectsInternal(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_FinishDestroy(UPlaneReflectionCaptureComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetDesc(UPlaneReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_GetDetailedInfoInternal(UPlaneReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsAsset(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsFullNameStableForNetworking(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsLocalizedResource(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsPostLoadThreadSafe(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsReadyForFinishDestroy(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_IsSafeForRootSet(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_Modify(UPlaneReflectionCaptureComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_NotifyObjectReferenceEliminated(UPlaneReflectionCaptureComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostCDOContruct(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostEditImport(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PostSaveRoot(UPlaneReflectionCaptureComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_PreDestroyFromReplication(UPlaneReflectionCaptureComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_ShutdownAfterError(UPlaneReflectionCaptureComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_AddToCluster(UPlaneReflectionCaptureComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CanBeClusterRoot(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CanBeInCluster(UPlaneReflectionCaptureComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_CreateCluster(UPlaneReflectionCaptureComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPlaneReflectionCaptureComponent_OnClusterMarkedAsPendingKill(UPlaneReflectionCaptureComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
