#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/RotatingMovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

class E_PROTECTED_WRAP_URotatingMovementComponent : protected URotatingMovementComponent
{
public:
	bool MoveUpdatedComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, ETeleportType Teleport)
	{
		return MoveUpdatedComponentImpl(Delta, NewRotation, bSweep, OutHit, Teleport);
	}

	bool ResolvePenetrationImpl_WRAP(const FVector& Adjustment, const FHitResult& Hit, const FQuat& NewRotation)
	{
		return ResolvePenetrationImpl(Adjustment, Hit, NewRotation);
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_URotatingMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URotatingMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AddRadialForce(URotatingMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AddRadialImpulse(URotatingMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ComputeSlideVector(URotatingMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ConstrainDirectionToPlane(URotatingMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ConstrainLocationToPlane(URotatingMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ConstrainNormalToPlane(URotatingMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_Deactivate(URotatingMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetGravityZ(URotatingMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetMaxSpeed(URotatingMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetMaxSpeedModifier(URotatingMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetModifiedMaxSpeed(URotatingMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetPenetrationAdjustment(URotatingMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_HandleImpact(URotatingMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_InitializeComponent(URotatingMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsExceedingMaxSpeed(URotatingMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsInWater(URotatingMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_K2_GetMaxSpeedModifier(URotatingMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_K2_GetModifiedMaxSpeed(URotatingMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_MoveUpdatedComponentImpl(URotatingMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnRegister(URotatingMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnTeleported(URotatingMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostLoad(URotatingMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_RegisterComponentTickFunctions(URotatingMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ResolvePenetrationImpl(URotatingMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetPlaneConstraintAxisSetting(URotatingMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetPlaneConstraintEnabled(URotatingMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetPlaneConstraintFromVectors(URotatingMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetPlaneConstraintNormal(URotatingMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetPlaneConstraintOrigin(URotatingMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetUpdatedComponent(URotatingMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ShouldSkipUpdate(URotatingMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SlideAlongSurface(URotatingMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SnapUpdatedComponentToPlane(URotatingMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_StopMovementImmediately(URotatingMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_TwoWallAdjust(URotatingMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_UpdateComponentVelocity(URotatingMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_UpdateTickRegistration(URotatingMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_Activate(URotatingMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AddTickPrerequisiteActor(URotatingMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AddTickPrerequisiteComponent(URotatingMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ApplyWorldOffset(URotatingMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_BeginDestroy(URotatingMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_BeginPlay(URotatingMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_CreateRenderState_Concurrent(URotatingMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_DestroyComponent(URotatingMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_DestroyRenderState_Concurrent(URotatingMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetComponentClassCanReplicate(URotatingMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetReadableName(URotatingMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_HasValidPhysicsState(URotatingMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_InvalidateLightingCacheDetailed(URotatingMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsActive(URotatingMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsEditorOnly(URotatingMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsNameStableForNetworking(URotatingMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsNavigationRelevant(URotatingMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsReadyForOwnerToAutoDestroy(URotatingMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsSupportedForNetworking(URotatingMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_MarkAsEditorOnlySubobject(URotatingMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_NeedsLoadForClient(URotatingMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_NeedsLoadForEditorGame(URotatingMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_NeedsLoadForServer(URotatingMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnActorEnableCollisionChanged(URotatingMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnComponentCreated(URotatingMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnComponentDestroyed(URotatingMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnCreatePhysicsState(URotatingMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnDestroyPhysicsState(URotatingMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnUnregister(URotatingMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostInitProperties(URotatingMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostNetReceive(URotatingMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostRename(URotatingMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PreNetReceive(URotatingMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_RemoveTickPrerequisiteActor(URotatingMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_RemoveTickPrerequisiteComponent(URotatingMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_RequiresGameThreadEndOfFrameRecreate(URotatingMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_RequiresGameThreadEndOfFrameUpdates(URotatingMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SendRenderDynamicData_Concurrent(URotatingMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SendRenderTransform_Concurrent(URotatingMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetActive(URotatingMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetAutoActivate(URotatingMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetComponentTickEnabled(URotatingMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_SetComponentTickEnabledAsync(URotatingMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ShouldActivate(URotatingMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_URotatingMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ShouldCreatePhysicsState(URotatingMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ShouldCreateRenderState(URotatingMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ToggleActive(URotatingMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_UninitializeComponent(URotatingMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_UpdateComponentToWorld(URotatingMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AreNativePropertiesIdenticalTo(URotatingMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_CheckDefaultSubobjectsInternal(URotatingMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_FinishDestroy(URotatingMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetDesc(URotatingMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_GetDetailedInfoInternal(URotatingMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsAsset(URotatingMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsFullNameStableForNetworking(URotatingMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsLocalizedResource(URotatingMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsPostLoadThreadSafe(URotatingMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsReadyForFinishDestroy(URotatingMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_IsSafeForRootSet(URotatingMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_Modify(URotatingMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_NotifyObjectReferenceEliminated(URotatingMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostCDOContruct(URotatingMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostEditImport(URotatingMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostRepNotifies(URotatingMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PostSaveRoot(URotatingMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_PreDestroyFromReplication(URotatingMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_ShutdownAfterError(URotatingMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_AddToCluster(URotatingMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_CanBeClusterRoot(URotatingMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_CanBeInCluster(URotatingMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_CreateCluster(URotatingMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_URotatingMovementComponent_OnClusterMarkedAsPendingKill(URotatingMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
