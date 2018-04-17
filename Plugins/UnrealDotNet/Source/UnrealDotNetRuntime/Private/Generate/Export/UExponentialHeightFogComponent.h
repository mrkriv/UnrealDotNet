#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ExponentialHeightFogComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:15

class E_PROTECTED_WRAP_UExponentialHeightFogComponent : protected UExponentialHeightFogComponent
{
public:
	void AddFogIfNeeded_WRAP()
	{
		AddFogIfNeeded();
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UExponentialHeightFogComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UExponentialHeightFogComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddFogIfNeeded(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->AddFogIfNeeded_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CreateRenderState_Concurrent(UExponentialHeightFogComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_DestroyRenderState_Concurrent(UExponentialHeightFogComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SendRenderTransform_Concurrent(UExponentialHeightFogComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringExponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogCutoffDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogCutoffDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogDensity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogDensity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogHeightFalloff(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogHeightFalloff(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogMaxOpacity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogMaxOpacity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFullyDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetInscatteringColorCubemapAngle(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetNonDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFog(UExponentialHeightFogComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetVolumetricFog(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogDistance(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogExtinctionScale(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogScatteringDistribution(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ApplyWorldOffset(UExponentialHeightFogComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_BeginDestroy(UExponentialHeightFogComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CalcBoundingCylinder(UExponentialHeightFogComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CanAttachAsChild(UExponentialHeightFogComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_DestroyComponent(UExponentialHeightFogComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_DetachFromComponent(UExponentialHeightFogComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_DetachFromParent(UExponentialHeightFogComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_DoesSocketExist(UExponentialHeightFogComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetCollisionObjectType(UExponentialHeightFogComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetCollisionResponseToChannel(UExponentialHeightFogComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetComponentVelocity(UExponentialHeightFogComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetSocketLocation(UExponentialHeightFogComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetSocketQuaternion(UExponentialHeightFogComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetSocketRotation(UExponentialHeightFogComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetSocketTransform(UExponentialHeightFogComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_HasAnySockets(UExponentialHeightFogComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsAnySimulatingPhysics(UExponentialHeightFogComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsPrecomputedLightingValid(UExponentialHeightFogComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsSimulatingPhysics(UExponentialHeightFogComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsVisible(UExponentialHeightFogComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsVisibleInEditor(UExponentialHeightFogComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsWorldGeometry(UExponentialHeightFogComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_MoveComponentImpl(UExponentialHeightFogComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnAttachmentChanged(UExponentialHeightFogComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnChildAttached(UExponentialHeightFogComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnChildDetached(UExponentialHeightFogComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnComponentDestroyed(UExponentialHeightFogComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnHiddenInGameChanged(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnRegister(UExponentialHeightFogComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnUnregister(UExponentialHeightFogComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnUpdateTransform(UExponentialHeightFogComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnVisibilityChanged(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostNetReceive(UExponentialHeightFogComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostRepNotifies(UExponentialHeightFogComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PreNetReceive(UExponentialHeightFogComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PropagateLightingScenarioChange(UExponentialHeightFogComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetRelativeScale3D(UExponentialHeightFogComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ShouldCollideWhenPlacing(UExponentialHeightFogComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ShouldCreateRenderState(UExponentialHeightFogComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_UpdatePhysicsVolume(UExponentialHeightFogComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_Activate(UExponentialHeightFogComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddTickPrerequisiteActor(UExponentialHeightFogComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddTickPrerequisiteComponent(UExponentialHeightFogComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_BeginPlay(UExponentialHeightFogComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_Deactivate(UExponentialHeightFogComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetComponentClassCanReplicate(UExponentialHeightFogComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetReadableName(UExponentialHeightFogComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_HasValidPhysicsState(UExponentialHeightFogComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_InitializeComponent(UExponentialHeightFogComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_InvalidateLightingCacheDetailed(UExponentialHeightFogComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsActive(UExponentialHeightFogComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsEditorOnly(UExponentialHeightFogComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsNameStableForNetworking(UExponentialHeightFogComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsNavigationRelevant(UExponentialHeightFogComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsReadyForOwnerToAutoDestroy(UExponentialHeightFogComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsSupportedForNetworking(UExponentialHeightFogComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_MarkAsEditorOnlySubobject(UExponentialHeightFogComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_NeedsLoadForClient(UExponentialHeightFogComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_NeedsLoadForEditorGame(UExponentialHeightFogComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_NeedsLoadForServer(UExponentialHeightFogComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnActorEnableCollisionChanged(UExponentialHeightFogComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnComponentCreated(UExponentialHeightFogComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnCreatePhysicsState(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnDestroyPhysicsState(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostInitProperties(UExponentialHeightFogComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostLoad(UExponentialHeightFogComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostRename(UExponentialHeightFogComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_RegisterComponentTickFunctions(UExponentialHeightFogComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_RemoveTickPrerequisiteActor(UExponentialHeightFogComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_RemoveTickPrerequisiteComponent(UExponentialHeightFogComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_RequiresGameThreadEndOfFrameRecreate(UExponentialHeightFogComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_RequiresGameThreadEndOfFrameUpdates(UExponentialHeightFogComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SendRenderDynamicData_Concurrent(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetActive(UExponentialHeightFogComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetAutoActivate(UExponentialHeightFogComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetComponentTickEnabled(UExponentialHeightFogComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetComponentTickEnabledAsync(UExponentialHeightFogComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ShouldActivate(UExponentialHeightFogComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ShouldCreatePhysicsState(UExponentialHeightFogComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ToggleActive(UExponentialHeightFogComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_UninitializeComponent(UExponentialHeightFogComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AreNativePropertiesIdenticalTo(UExponentialHeightFogComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CheckDefaultSubobjectsInternal(UExponentialHeightFogComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_FinishDestroy(UExponentialHeightFogComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetDesc(UExponentialHeightFogComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_GetDetailedInfoInternal(UExponentialHeightFogComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsAsset(UExponentialHeightFogComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsFullNameStableForNetworking(UExponentialHeightFogComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsLocalizedResource(UExponentialHeightFogComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsPostLoadThreadSafe(UExponentialHeightFogComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsReadyForFinishDestroy(UExponentialHeightFogComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_IsSafeForRootSet(UExponentialHeightFogComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_Modify(UExponentialHeightFogComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_NotifyObjectReferenceEliminated(UExponentialHeightFogComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostCDOContruct(UExponentialHeightFogComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostEditImport(UExponentialHeightFogComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PostSaveRoot(UExponentialHeightFogComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_PreDestroyFromReplication(UExponentialHeightFogComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_ShutdownAfterError(UExponentialHeightFogComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddToCluster(UExponentialHeightFogComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CanBeClusterRoot(UExponentialHeightFogComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CanBeInCluster(UExponentialHeightFogComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_CreateCluster(UExponentialHeightFogComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_OnClusterMarkedAsPendingKill(UExponentialHeightFogComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
