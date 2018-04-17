#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/MovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

class E_PROTECTED_WRAP_UMovementComponent : protected UMovementComponent
{
public:
	FVector GetPlaneConstraintNormalFromAxisSetting_WRAP(EPlaneConstraintAxisSetting AxisSetting)
	{
		return GetPlaneConstraintNormalFromAxisSetting(AxisSetting);
	}

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddRadialForce(UMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddRadialImpulse(UMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ComputeSlideVector(UMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainDirectionToPlane(UMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainLocationToPlane(UMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainNormalToPlane(UMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_Deactivate(UMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetGravityZ(UMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetMaxSpeed(UMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetMaxSpeedModifier(UMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetModifiedMaxSpeed(UMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPenetrationAdjustment(UMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintAxisSetting(UMovementComponent* Self)
	{
		return Self->GetPlaneConstraintAxisSetting();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(UMovementComponent* Self, EPlaneConstraintAxisSetting AxisSetting)
	{
		auto _p0 = AxisSetting;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UMovementComponent*)Self)->GetPlaneConstraintNormalFromAxisSetting_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_HandleImpact(UMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_InitializeComponent(UMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsExceedingMaxSpeed(UMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsInWater(UMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_GetMaxSpeedModifier(UMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_GetModifiedMaxSpeed(UMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_MoveUpdatedComponent(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, INT_PTR OutHit, bool bSweep, bool bTeleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = *(FHitResult*)OutHit;
		auto _p3 = bSweep;
		auto _p4 = bTeleport;
		return Self->K2_MoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_MoveUpdatedComponentImpl(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnRegister(UMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnTeleported(UMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostLoad(UMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UMovementComponent_RegisterComponentTickFunctions(UMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ResolvePenetrationImpl(UMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintAxisSetting(UMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintFromVectors(UMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintNormal(UMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintOrigin(UMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetUpdatedComponent(UMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShouldSkipUpdate(UMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SlideAlongSurface(UMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UMovementComponent_StopMovementImmediately(UMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UMovementComponent_TwoWallAdjust(UMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_UpdateComponentVelocity(UMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UMovementComponent_UpdateTickRegistration(UMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_UMovementComponent_Activate(UMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddTickPrerequisiteActor(UMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddTickPrerequisiteComponent(UMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ApplyWorldOffset(UMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_BeginDestroy(UMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UMovementComponent_BeginPlay(UMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UMovementComponent_CreateRenderState_Concurrent(UMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMovementComponent_DestroyComponent(UMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_DestroyRenderState_Concurrent(UMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetComponentClassCanReplicate(UMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetReadableName(UMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UMovementComponent_HasValidPhysicsState(UMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UMovementComponent_InvalidateLightingCacheDetailed(UMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsActive(UMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsEditorOnly(UMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsNameStableForNetworking(UMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsNavigationRelevant(UMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsReadyForOwnerToAutoDestroy(UMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsSupportedForNetworking(UMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UMovementComponent_MarkAsEditorOnlySubobject(UMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UMovementComponent_NeedsLoadForClient(UMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UMovementComponent_NeedsLoadForEditorGame(UMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UMovementComponent_NeedsLoadForServer(UMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnActorEnableCollisionChanged(UMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnComponentCreated(UMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnComponentDestroyed(UMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnCreatePhysicsState(UMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnDestroyPhysicsState(UMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnUnregister(UMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostInitProperties(UMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostNetReceive(UMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostRename(UMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_PreNetReceive(UMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UMovementComponent_RemoveTickPrerequisiteActor(UMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_RemoveTickPrerequisiteComponent(UMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_RequiresGameThreadEndOfFrameRecreate(UMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UMovementComponent_RequiresGameThreadEndOfFrameUpdates(UMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UMovementComponent_SendRenderDynamicData_Concurrent(UMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UMovementComponent_SendRenderTransform_Concurrent(UMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetActive(UMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetAutoActivate(UMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetComponentTickEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetComponentTickEnabledAsync(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShouldActivate(UMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShouldCreatePhysicsState(UMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShouldCreateRenderState(UMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UMovementComponent_ToggleActive(UMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UMovementComponent_UninitializeComponent(UMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UMovementComponent_UpdateComponentToWorld(UMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_AreNativePropertiesIdenticalTo(UMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_CheckDefaultSubobjectsInternal(UMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UMovementComponent_FinishDestroy(UMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetDesc(UMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetDetailedInfoInternal(UMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsAsset(UMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsFullNameStableForNetworking(UMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsLocalizedResource(UMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsPostLoadThreadSafe(UMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsReadyForFinishDestroy(UMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsSafeForRootSet(UMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UMovementComponent_Modify(UMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_NotifyObjectReferenceEliminated(UMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostCDOContruct(UMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostEditImport(UMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostRepNotifies(UMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UMovementComponent_PostSaveRoot(UMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_PreDestroyFromReplication(UMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShutdownAfterError(UMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddToCluster(UMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_CanBeClusterRoot(UMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UMovementComponent_CanBeInCluster(UMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UMovementComponent_CreateCluster(UMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnClusterMarkedAsPendingKill(UMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
