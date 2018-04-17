#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SphereReflectionCaptureComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

class E_PROTECTED_WRAP_USphereReflectionCaptureComponent : protected USphereReflectionCaptureComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereReflectionCaptureComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereReflectionCaptureComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetInfluenceBoundingRadius(USphereReflectionCaptureComponent* Self)
	{
		return Self->GetInfluenceBoundingRadius();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_UpdatePreviewShape(USphereReflectionCaptureComponent* Self)
	{
		Self->UpdatePreviewShape();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ApplyWorldOffset(USphereReflectionCaptureComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_BeginDestroy(USphereReflectionCaptureComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CalcBoundingCylinder(USphereReflectionCaptureComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CanAttachAsChild(USphereReflectionCaptureComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_DestroyComponent(USphereReflectionCaptureComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_DetachFromComponent(USphereReflectionCaptureComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_DetachFromParent(USphereReflectionCaptureComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_DoesSocketExist(USphereReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetCollisionObjectType(USphereReflectionCaptureComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetCollisionResponseToChannel(USphereReflectionCaptureComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetComponentVelocity(USphereReflectionCaptureComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetSocketLocation(USphereReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetSocketQuaternion(USphereReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetSocketRotation(USphereReflectionCaptureComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetSocketTransform(USphereReflectionCaptureComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_HasAnySockets(USphereReflectionCaptureComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsAnySimulatingPhysics(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsPrecomputedLightingValid(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsSimulatingPhysics(USphereReflectionCaptureComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsVisible(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsVisibleInEditor(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsWorldGeometry(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_MoveComponentImpl(USphereReflectionCaptureComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnAttachmentChanged(USphereReflectionCaptureComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnChildAttached(USphereReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnChildDetached(USphereReflectionCaptureComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnComponentDestroyed(USphereReflectionCaptureComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnHiddenInGameChanged(USphereReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnRegister(USphereReflectionCaptureComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnUnregister(USphereReflectionCaptureComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnUpdateTransform(USphereReflectionCaptureComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnVisibilityChanged(USphereReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostNetReceive(USphereReflectionCaptureComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostRepNotifies(USphereReflectionCaptureComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PreNetReceive(USphereReflectionCaptureComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PropagateLightingScenarioChange(USphereReflectionCaptureComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SetRelativeScale3D(USphereReflectionCaptureComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ShouldCollideWhenPlacing(USphereReflectionCaptureComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ShouldCreateRenderState(USphereReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_UpdatePhysicsVolume(USphereReflectionCaptureComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_Activate(USphereReflectionCaptureComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_AddTickPrerequisiteActor(USphereReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_AddTickPrerequisiteComponent(USphereReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_BeginPlay(USphereReflectionCaptureComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CreateRenderState_Concurrent(USphereReflectionCaptureComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_Deactivate(USphereReflectionCaptureComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_DestroyRenderState_Concurrent(USphereReflectionCaptureComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetComponentClassCanReplicate(USphereReflectionCaptureComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetReadableName(USphereReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_HasValidPhysicsState(USphereReflectionCaptureComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_InitializeComponent(USphereReflectionCaptureComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_InvalidateLightingCacheDetailed(USphereReflectionCaptureComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsActive(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsEditorOnly(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsNameStableForNetworking(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsNavigationRelevant(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsReadyForOwnerToAutoDestroy(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsSupportedForNetworking(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_MarkAsEditorOnlySubobject(USphereReflectionCaptureComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_NeedsLoadForClient(USphereReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_NeedsLoadForEditorGame(USphereReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_NeedsLoadForServer(USphereReflectionCaptureComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnActorEnableCollisionChanged(USphereReflectionCaptureComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnComponentCreated(USphereReflectionCaptureComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnCreatePhysicsState(USphereReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnDestroyPhysicsState(USphereReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostInitProperties(USphereReflectionCaptureComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostLoad(USphereReflectionCaptureComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostRename(USphereReflectionCaptureComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_RegisterComponentTickFunctions(USphereReflectionCaptureComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_RemoveTickPrerequisiteActor(USphereReflectionCaptureComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_RemoveTickPrerequisiteComponent(USphereReflectionCaptureComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_RequiresGameThreadEndOfFrameRecreate(USphereReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_RequiresGameThreadEndOfFrameUpdates(USphereReflectionCaptureComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SendRenderDynamicData_Concurrent(USphereReflectionCaptureComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SendRenderTransform_Concurrent(USphereReflectionCaptureComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SetActive(USphereReflectionCaptureComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SetAutoActivate(USphereReflectionCaptureComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SetComponentTickEnabled(USphereReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_SetComponentTickEnabledAsync(USphereReflectionCaptureComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ShouldActivate(USphereReflectionCaptureComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USphereReflectionCaptureComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ShouldCreatePhysicsState(USphereReflectionCaptureComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ToggleActive(USphereReflectionCaptureComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_UninitializeComponent(USphereReflectionCaptureComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_AreNativePropertiesIdenticalTo(USphereReflectionCaptureComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CheckDefaultSubobjectsInternal(USphereReflectionCaptureComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_FinishDestroy(USphereReflectionCaptureComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetDesc(USphereReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_GetDetailedInfoInternal(USphereReflectionCaptureComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsAsset(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsFullNameStableForNetworking(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsLocalizedResource(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsPostLoadThreadSafe(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsReadyForFinishDestroy(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_IsSafeForRootSet(USphereReflectionCaptureComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_Modify(USphereReflectionCaptureComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_NotifyObjectReferenceEliminated(USphereReflectionCaptureComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostCDOContruct(USphereReflectionCaptureComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostEditImport(USphereReflectionCaptureComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PostSaveRoot(USphereReflectionCaptureComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_PreDestroyFromReplication(USphereReflectionCaptureComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_ShutdownAfterError(USphereReflectionCaptureComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_AddToCluster(USphereReflectionCaptureComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CanBeClusterRoot(USphereReflectionCaptureComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CanBeInCluster(USphereReflectionCaptureComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_CreateCluster(USphereReflectionCaptureComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USphereReflectionCaptureComponent_OnClusterMarkedAsPendingKill(USphereReflectionCaptureComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
