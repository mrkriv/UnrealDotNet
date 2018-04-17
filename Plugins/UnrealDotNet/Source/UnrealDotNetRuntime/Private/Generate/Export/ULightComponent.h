#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/LightComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

class E_PROTECTED_WRAP_ULightComponent : protected ULightComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightComponent_AffectsPrimitive(ULightComponent* Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return Self->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_GetBoundingBox(ULightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetLightPosition(ULightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectDynamicIndirectLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectTranslucentLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomThreshold(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomThreshold(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetEnableLightShaftBloom(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetEnableLightShaftBloom(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetForceCachedShadowsForMovablePrimitives(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIndirectLightingIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionDisabledBrightness(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetLightFunctionDisabledBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionFadeDistance(ULightComponent* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionScale(ULightComponent* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetShadowBias(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetShadowBias(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetTemperature(ULightComponent* Self, float NewTemperature)
	{
		auto _p0 = NewTemperature;
		Self->SetTemperature(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetVolumetricScatteringIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetVolumetricScatteringIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_ApplyWorldOffset(ULightComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_BeginDestroy(ULightComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponent_CalcBoundingCylinder(ULightComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_CanAttachAsChild(ULightComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_DestroyComponent(ULightComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_DetachFromComponent(ULightComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_DetachFromParent(ULightComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_DoesSocketExist(ULightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_GetCollisionObjectType(ULightComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_ULightComponent_GetCollisionResponseToChannel(ULightComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_GetComponentVelocity(ULightComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetSocketLocation(ULightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponent_GetSocketQuaternion(ULightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponent_GetSocketRotation(ULightComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_ULightComponent_GetSocketTransform(ULightComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_ULightComponent_HasAnySockets(ULightComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsAnySimulatingPhysics(ULightComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsPrecomputedLightingValid(ULightComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsSimulatingPhysics(ULightComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_IsVisible(ULightComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsVisibleInEditor(ULightComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsWorldGeometry(ULightComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_ULightComponent_MoveComponentImpl(ULightComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_ULightComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULightComponent_OnAttachmentChanged(ULightComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnChildAttached(ULightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_OnChildDetached(ULightComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_OnComponentDestroyed(ULightComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_OnHiddenInGameChanged(ULightComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnRegister(ULightComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnUnregister(ULightComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnUpdateTransform(ULightComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_OnVisibilityChanged(ULightComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostNetReceive(ULightComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostRepNotifies(ULightComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ULightComponent_PreNetReceive(ULightComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ULightComponent_PropagateLightingScenarioChange(ULightComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_ULightComponent_SetRelativeScale3D(ULightComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_ShouldCollideWhenPlacing(ULightComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_ULightComponent_ShouldCreateRenderState(ULightComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_ULightComponent_UpdatePhysicsVolume(ULightComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_Activate(ULightComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_AddTickPrerequisiteActor(ULightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_AddTickPrerequisiteComponent(ULightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_BeginPlay(ULightComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ULightComponent_CreateRenderState_Concurrent(ULightComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponent_Deactivate(ULightComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_ULightComponent_DestroyRenderState_Concurrent(ULightComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponent_GetComponentClassCanReplicate(ULightComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_ULightComponent_GetReadableName(ULightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_ULightComponent_HasValidPhysicsState(ULightComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_ULightComponent_InitializeComponent(ULightComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightComponent_InvalidateLightingCacheDetailed(ULightComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_IsActive(ULightComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsEditorOnly(ULightComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsNameStableForNetworking(ULightComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsNavigationRelevant(ULightComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsReadyForOwnerToAutoDestroy(ULightComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsSupportedForNetworking(ULightComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponent_MarkAsEditorOnlySubobject(ULightComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ULightComponent_NeedsLoadForClient(ULightComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ULightComponent_NeedsLoadForEditorGame(ULightComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ULightComponent_NeedsLoadForServer(ULightComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnActorEnableCollisionChanged(ULightComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnComponentCreated(ULightComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnCreatePhysicsState(ULightComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnDestroyPhysicsState(ULightComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostInitProperties(ULightComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostLoad(ULightComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostRename(ULightComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_RegisterComponentTickFunctions(ULightComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_RemoveTickPrerequisiteActor(ULightComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_RemoveTickPrerequisiteComponent(ULightComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_RequiresGameThreadEndOfFrameRecreate(ULightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_ULightComponent_RequiresGameThreadEndOfFrameUpdates(ULightComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_ULightComponent_SendRenderDynamicData_Concurrent(ULightComponent* Self)
	{
		((E_PROTECTED_WRAP_ULightComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_SendRenderTransform_Concurrent(ULightComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_ULightComponent_SetActive(ULightComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAutoActivate(ULightComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetComponentTickEnabled(ULightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetComponentTickEnabledAsync(ULightComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_ShouldActivate(ULightComponent* Self)
	{
		return ((E_PROTECTED_WRAP_ULightComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_ULightComponent_ShouldCreatePhysicsState(ULightComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_ULightComponent_ToggleActive(ULightComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_ULightComponent_UninitializeComponent(ULightComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_ULightComponent_AreNativePropertiesIdenticalTo(ULightComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_CheckDefaultSubobjectsInternal(ULightComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ULightComponent_FinishDestroy(ULightComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponent_GetDesc(ULightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetDetailedInfoInternal(ULightComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ULightComponent_IsAsset(ULightComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsFullNameStableForNetworking(ULightComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsLocalizedResource(ULightComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsPostLoadThreadSafe(ULightComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsReadyForFinishDestroy(ULightComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ULightComponent_IsSafeForRootSet(ULightComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ULightComponent_Modify(ULightComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_NotifyObjectReferenceEliminated(ULightComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostCDOContruct(ULightComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostEditImport(ULightComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ULightComponent_PostSaveRoot(ULightComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_PreDestroyFromReplication(ULightComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ULightComponent_ShutdownAfterError(ULightComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ULightComponent_AddToCluster(ULightComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_CanBeClusterRoot(ULightComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ULightComponent_CanBeInCluster(ULightComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ULightComponent_CreateCluster(ULightComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ULightComponent_OnClusterMarkedAsPendingKill(ULightComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
