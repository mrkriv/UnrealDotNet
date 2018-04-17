#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PlanarReflectionComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PlanarReflectionComponent.h:16

class E_PROTECTED_WRAP_UPlanarReflectionComponent : protected UPlanarReflectionComponent
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
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_GET(UPlanarReflectionComponent* Ptr) { return Ptr->AngleFromPlaneFadeEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->AngleFromPlaneFadeEnd = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_GET(UPlanarReflectionComponent* Ptr) { return Ptr->AngleFromPlaneFadeStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->AngleFromPlaneFadeStart = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_GET(UPlanarReflectionComponent* Ptr) { return Ptr->bRenderSceneTwoSided; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_SET(UPlanarReflectionComponent* Ptr, bool Value) { Ptr->bRenderSceneTwoSided = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeEnd_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeEnd_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeoutEnd; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeoutEnd = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeoutStart; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeoutStart = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_GET(UPlanarReflectionComponent* Ptr) { return Ptr->DistanceFromPlaneFadeStart_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->DistanceFromPlaneFadeStart_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_ExtraFOV_GET(UPlanarReflectionComponent* Ptr) { return Ptr->ExtraFOV; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ExtraFOV_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->ExtraFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_GET(UPlanarReflectionComponent* Ptr) { return Ptr->NormalDistortionStrength; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->NormalDistortionStrength = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_PrefilterRoughness_GET(UPlanarReflectionComponent* Ptr) { return Ptr->PrefilterRoughness; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughness_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->PrefilterRoughness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_GET(UPlanarReflectionComponent* Ptr) { return Ptr->PrefilterRoughnessDistance; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_SET(UPlanarReflectionComponent* Ptr, float Value) { Ptr->PrefilterRoughnessDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlanarReflectionComponent_ScreenPercentage_GET(UPlanarReflectionComponent* Ptr) { return Ptr->ScreenPercentage; }
	DOTNET_EXPORT void E_PROP_UPlanarReflectionComponent_ScreenPercentage_SET(UPlanarReflectionComponent* Ptr, int32 Value) { Ptr->ScreenPercentage = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlanarReflectionComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlanarReflectionComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_BeginDestroy(UPlanarReflectionComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CreateRenderState_Concurrent(UPlanarReflectionComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_DestroyRenderState_Concurrent(UPlanarReflectionComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_FinishDestroy(UPlanarReflectionComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetPlanarReflectionId(UPlanarReflectionComponent* Self)
	{
		return Self->GetPlanarReflectionId();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsReadyForFinishDestroy(UPlanarReflectionComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SendRenderTransform_Concurrent(UPlanarReflectionComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnRegister(UPlanarReflectionComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnUnregister(UPlanarReflectionComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ApplyWorldOffset(UPlanarReflectionComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CalcBoundingCylinder(UPlanarReflectionComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CanAttachAsChild(UPlanarReflectionComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_DestroyComponent(UPlanarReflectionComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_DetachFromComponent(UPlanarReflectionComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_DetachFromParent(UPlanarReflectionComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_DoesSocketExist(UPlanarReflectionComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetCollisionObjectType(UPlanarReflectionComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetCollisionResponseToChannel(UPlanarReflectionComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetComponentVelocity(UPlanarReflectionComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetSocketLocation(UPlanarReflectionComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetSocketQuaternion(UPlanarReflectionComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetSocketRotation(UPlanarReflectionComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetSocketTransform(UPlanarReflectionComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_HasAnySockets(UPlanarReflectionComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsAnySimulatingPhysics(UPlanarReflectionComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsPrecomputedLightingValid(UPlanarReflectionComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsSimulatingPhysics(UPlanarReflectionComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsVisible(UPlanarReflectionComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsVisibleInEditor(UPlanarReflectionComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsWorldGeometry(UPlanarReflectionComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_MoveComponentImpl(UPlanarReflectionComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnAttachmentChanged(UPlanarReflectionComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnChildAttached(UPlanarReflectionComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnChildDetached(UPlanarReflectionComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnComponentDestroyed(UPlanarReflectionComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnHiddenInGameChanged(UPlanarReflectionComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnUpdateTransform(UPlanarReflectionComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnVisibilityChanged(UPlanarReflectionComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostNetReceive(UPlanarReflectionComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostRepNotifies(UPlanarReflectionComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PreNetReceive(UPlanarReflectionComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PropagateLightingScenarioChange(UPlanarReflectionComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SetRelativeScale3D(UPlanarReflectionComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ShouldCollideWhenPlacing(UPlanarReflectionComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ShouldCreateRenderState(UPlanarReflectionComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_UpdatePhysicsVolume(UPlanarReflectionComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_Activate(UPlanarReflectionComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_AddTickPrerequisiteActor(UPlanarReflectionComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_AddTickPrerequisiteComponent(UPlanarReflectionComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_BeginPlay(UPlanarReflectionComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_Deactivate(UPlanarReflectionComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetComponentClassCanReplicate(UPlanarReflectionComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetReadableName(UPlanarReflectionComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_HasValidPhysicsState(UPlanarReflectionComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_InitializeComponent(UPlanarReflectionComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_InvalidateLightingCacheDetailed(UPlanarReflectionComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsActive(UPlanarReflectionComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsEditorOnly(UPlanarReflectionComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsNameStableForNetworking(UPlanarReflectionComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsNavigationRelevant(UPlanarReflectionComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsReadyForOwnerToAutoDestroy(UPlanarReflectionComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsSupportedForNetworking(UPlanarReflectionComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_MarkAsEditorOnlySubobject(UPlanarReflectionComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_NeedsLoadForClient(UPlanarReflectionComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_NeedsLoadForEditorGame(UPlanarReflectionComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_NeedsLoadForServer(UPlanarReflectionComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnActorEnableCollisionChanged(UPlanarReflectionComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnComponentCreated(UPlanarReflectionComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnCreatePhysicsState(UPlanarReflectionComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnDestroyPhysicsState(UPlanarReflectionComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostInitProperties(UPlanarReflectionComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostLoad(UPlanarReflectionComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostRename(UPlanarReflectionComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_RegisterComponentTickFunctions(UPlanarReflectionComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_RemoveTickPrerequisiteActor(UPlanarReflectionComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_RemoveTickPrerequisiteComponent(UPlanarReflectionComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_RequiresGameThreadEndOfFrameRecreate(UPlanarReflectionComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_RequiresGameThreadEndOfFrameUpdates(UPlanarReflectionComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SendRenderDynamicData_Concurrent(UPlanarReflectionComponent* Self)
	{
		((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SetActive(UPlanarReflectionComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SetAutoActivate(UPlanarReflectionComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SetComponentTickEnabled(UPlanarReflectionComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_SetComponentTickEnabledAsync(UPlanarReflectionComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ShouldActivate(UPlanarReflectionComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPlanarReflectionComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ShouldCreatePhysicsState(UPlanarReflectionComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ToggleActive(UPlanarReflectionComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_UninitializeComponent(UPlanarReflectionComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_AreNativePropertiesIdenticalTo(UPlanarReflectionComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CheckDefaultSubobjectsInternal(UPlanarReflectionComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetDesc(UPlanarReflectionComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_GetDetailedInfoInternal(UPlanarReflectionComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsAsset(UPlanarReflectionComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsFullNameStableForNetworking(UPlanarReflectionComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsLocalizedResource(UPlanarReflectionComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsPostLoadThreadSafe(UPlanarReflectionComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_IsSafeForRootSet(UPlanarReflectionComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_Modify(UPlanarReflectionComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_NotifyObjectReferenceEliminated(UPlanarReflectionComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostCDOContruct(UPlanarReflectionComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostEditImport(UPlanarReflectionComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PostSaveRoot(UPlanarReflectionComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_PreDestroyFromReplication(UPlanarReflectionComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_ShutdownAfterError(UPlanarReflectionComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_AddToCluster(UPlanarReflectionComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CanBeClusterRoot(UPlanarReflectionComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CanBeInCluster(UPlanarReflectionComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_CreateCluster(UPlanarReflectionComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPlanarReflectionComponent_OnClusterMarkedAsPendingKill(UPlanarReflectionComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
