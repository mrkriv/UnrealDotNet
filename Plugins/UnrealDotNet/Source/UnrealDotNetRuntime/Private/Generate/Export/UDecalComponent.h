#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/DecalComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

class E_PROTECTED_WRAP_UDecalComponent : protected UDecalComponent
{
public:
	void LifeSpanCallback_WRAP()
	{
		LifeSpanCallback();
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
	DOTNET_EXPORT auto E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(UDecalComponent* Ptr) { return Ptr->bDestroyOwnerAfterFade; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(UDecalComponent* Ptr, uint8 Value) { Ptr->bDestroyOwnerAfterFade = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_DecalSize_GET(UDecalComponent* Ptr) { return (INT_PTR)&(Ptr->DecalSize); }
	DOTNET_EXPORT void E_PROP_UDecalComponent_DecalSize_SET(UDecalComponent* Ptr, INT_PTR Value) { Ptr->DecalSize = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeDuration_GET(UDecalComponent* Ptr) { return Ptr->FadeDuration; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeDuration_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeScreenSize_GET(UDecalComponent* Ptr) { return Ptr->FadeScreenSize; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeScreenSize_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeScreenSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeStartDelay_GET(UDecalComponent* Ptr) { return Ptr->FadeStartDelay; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeStartDelay_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeStartDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_SortOrder_GET(UDecalComponent* Ptr) { return Ptr->SortOrder; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_SortOrder_SET(UDecalComponent* Ptr, int32 Value) { Ptr->SortOrder = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDecalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDecalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDecalComponent_BeginPlay(UDecalComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_CreateRenderState_Concurrent(UDecalComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDecalComponent_DestroyRenderState_Concurrent(UDecalComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeDuration(UDecalComponent* Self)
	{
		return Self->GetFadeDuration();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeStartDelay(UDecalComponent* Self)
	{
		return Self->GetFadeStartDelay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetNumMaterials(UDecalComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetTransformIncludingDecalSize(UDecalComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetTransformIncludingDecalSize());
	}

	DOTNET_EXPORT auto E_UDecalComponent_LifeSpanCallback(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->LifeSpanCallback_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PushSelectionToProxy(UDecalComponent* Self)
	{
		Self->PushSelectionToProxy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SendRenderTransform_Concurrent(UDecalComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeOut(UDecalComponent* Self, float StartDelay, float Duration, bool DestroyOwnerAfterFade)
	{
		auto _p0 = StartDelay;
		auto _p1 = Duration;
		auto _p2 = DestroyOwnerAfterFade;
		Self->SetFadeOut(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeScreenSize(UDecalComponent* Self, float NewFadeScreenSize)
	{
		auto _p0 = NewFadeScreenSize;
		Self->SetFadeScreenSize(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetLifeSpan(UDecalComponent* Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetSortOrder(UDecalComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetSortOrder(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_ApplyWorldOffset(UDecalComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_BeginDestroy(UDecalComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_CalcBoundingCylinder(UDecalComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_CanAttachAsChild(UDecalComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_DestroyComponent(UDecalComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_DetachFromComponent(UDecalComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_DetachFromParent(UDecalComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_DoesSocketExist(UDecalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetCollisionObjectType(UDecalComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetCollisionResponseToChannel(UDecalComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetComponentVelocity(UDecalComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetSocketLocation(UDecalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetSocketQuaternion(UDecalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetSocketRotation(UDecalComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetSocketTransform(UDecalComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDecalComponent_HasAnySockets(UDecalComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsAnySimulatingPhysics(UDecalComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsPrecomputedLightingValid(UDecalComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsSimulatingPhysics(UDecalComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsVisible(UDecalComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsVisibleInEditor(UDecalComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsWorldGeometry(UDecalComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UDecalComponent_MoveComponentImpl(UDecalComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UDecalComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnAttachmentChanged(UDecalComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnChildAttached(UDecalComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnChildDetached(UDecalComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnComponentDestroyed(UDecalComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnHiddenInGameChanged(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnRegister(UDecalComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnUnregister(UDecalComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnUpdateTransform(UDecalComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnVisibilityChanged(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostNetReceive(UDecalComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostRepNotifies(UDecalComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PreNetReceive(UDecalComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PropagateLightingScenarioChange(UDecalComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetRelativeScale3D(UDecalComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_ShouldCollideWhenPlacing(UDecalComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UDecalComponent_ShouldCreateRenderState(UDecalComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UDecalComponent_UpdatePhysicsVolume(UDecalComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_Activate(UDecalComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_AddTickPrerequisiteActor(UDecalComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_AddTickPrerequisiteComponent(UDecalComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_Deactivate(UDecalComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetComponentClassCanReplicate(UDecalComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetReadableName(UDecalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UDecalComponent_HasValidPhysicsState(UDecalComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UDecalComponent_InitializeComponent(UDecalComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UDecalComponent_InvalidateLightingCacheDetailed(UDecalComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsActive(UDecalComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsEditorOnly(UDecalComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsNameStableForNetworking(UDecalComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsNavigationRelevant(UDecalComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsReadyForOwnerToAutoDestroy(UDecalComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsSupportedForNetworking(UDecalComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UDecalComponent_MarkAsEditorOnlySubobject(UDecalComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UDecalComponent_NeedsLoadForClient(UDecalComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UDecalComponent_NeedsLoadForEditorGame(UDecalComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UDecalComponent_NeedsLoadForServer(UDecalComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnActorEnableCollisionChanged(UDecalComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnComponentCreated(UDecalComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnCreatePhysicsState(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnDestroyPhysicsState(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostInitProperties(UDecalComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostLoad(UDecalComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostRename(UDecalComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_RegisterComponentTickFunctions(UDecalComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_RemoveTickPrerequisiteActor(UDecalComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_RemoveTickPrerequisiteComponent(UDecalComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_RequiresGameThreadEndOfFrameRecreate(UDecalComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UDecalComponent_RequiresGameThreadEndOfFrameUpdates(UDecalComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SendRenderDynamicData_Concurrent(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetActive(UDecalComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetAutoActivate(UDecalComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetComponentTickEnabled(UDecalComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetComponentTickEnabledAsync(UDecalComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_ShouldActivate(UDecalComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDecalComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_ShouldCreatePhysicsState(UDecalComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UDecalComponent_ToggleActive(UDecalComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UDecalComponent_UninitializeComponent(UDecalComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UDecalComponent_AreNativePropertiesIdenticalTo(UDecalComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_CheckDefaultSubobjectsInternal(UDecalComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UDecalComponent_FinishDestroy(UDecalComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetDesc(UDecalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetDetailedInfoInternal(UDecalComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsAsset(UDecalComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsFullNameStableForNetworking(UDecalComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsLocalizedResource(UDecalComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsPostLoadThreadSafe(UDecalComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsReadyForFinishDestroy(UDecalComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_IsSafeForRootSet(UDecalComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UDecalComponent_Modify(UDecalComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_NotifyObjectReferenceEliminated(UDecalComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostCDOContruct(UDecalComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostEditImport(UDecalComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PostSaveRoot(UDecalComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_PreDestroyFromReplication(UDecalComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UDecalComponent_ShutdownAfterError(UDecalComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UDecalComponent_AddToCluster(UDecalComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_CanBeClusterRoot(UDecalComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UDecalComponent_CanBeInCluster(UDecalComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UDecalComponent_CreateCluster(UDecalComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UDecalComponent_OnClusterMarkedAsPendingKill(UDecalComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
