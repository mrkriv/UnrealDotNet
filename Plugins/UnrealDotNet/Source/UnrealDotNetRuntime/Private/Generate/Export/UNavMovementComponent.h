#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/NavMovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

class E_PROTECTED_WRAP_UNavMovementComponent : protected UNavMovementComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UNavMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UNavMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverCrouch(UNavMovementComponent* Self)
	{
		return Self->CanEverCrouch();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverFly(UNavMovementComponent* Self)
	{
		return Self->CanEverFly();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverJump(UNavMovementComponent* Self)
	{
		return Self->CanEverJump();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverMoveOnGround(UNavMovementComponent* Self)
	{
		return Self->CanEverMoveOnGround();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverSwim(UNavMovementComponent* Self)
	{
		return Self->CanEverSwim();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanStartPathFollowing(UNavMovementComponent* Self)
	{
		return Self->CanStartPathFollowing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanStopPathFollowing(UNavMovementComponent* Self)
	{
		return Self->CanStopPathFollowing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ClearFixedBrakingDistance(UNavMovementComponent* Self)
	{
		Self->ClearFixedBrakingDistance();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorFeetLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorFeetLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorFeetLocationBased(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FBasedPosition(Self->GetActorFeetLocationBased());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorNavLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorNavLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetPathFollowingBrakingDistance(UNavMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->GetPathFollowingBrakingDistance(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsCrouching(UNavMovementComponent* Self)
	{
		return Self->IsCrouching();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsFalling(UNavMovementComponent* Self)
	{
		return Self->IsFalling();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsFlying(UNavMovementComponent* Self)
	{
		return Self->IsFlying();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsJumpAllowed(UNavMovementComponent* Self)
	{
		return Self->IsJumpAllowed();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsMovingOnGround(UNavMovementComponent* Self)
	{
		return Self->IsMovingOnGround();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsSwimming(UNavMovementComponent* Self)
	{
		return Self->IsSwimming();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequestDirectMove(UNavMovementComponent* Self, INT_PTR MoveVelocity, bool bForceMaxSpeed)
	{
		auto _p0 = *(FVector*)MoveVelocity;
		auto _p1 = bForceMaxSpeed;
		Self->RequestDirectMove(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequestPathMove(UNavMovementComponent* Self, INT_PTR MoveInput)
	{
		auto _p0 = *(FVector*)MoveInput;
		Self->RequestPathMove(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ResetMoveState(UNavMovementComponent* Self)
	{
		Self->ResetMoveState();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetFixedBrakingDistance(UNavMovementComponent* Self, float DistanceToEndOfPath)
	{
		auto _p0 = DistanceToEndOfPath;
		Self->SetFixedBrakingDistance(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetJumpAllowed(UNavMovementComponent* Self, bool bAllowed)
	{
		auto _p0 = bAllowed;
		Self->SetJumpAllowed(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(UNavMovementComponent* Self, bool bUpdateWithOwner)
	{
		auto _p0 = bUpdateWithOwner;
		Self->SetUpdateNavAgentWithOwnersCollisions(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(UNavMovementComponent* Self)
	{
		return Self->ShouldUpdateNavAgentWithOwnersCollision();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_StopActiveMovement(UNavMovementComponent* Self)
	{
		Self->StopActiveMovement();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_StopMovementImmediately(UNavMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_StopMovementKeepPathing(UNavMovementComponent* Self)
	{
		Self->StopMovementKeepPathing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UseAccelerationForPathFollowing(UNavMovementComponent* Self)
	{
		return Self->UseAccelerationForPathFollowing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AddRadialForce(UNavMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AddRadialImpulse(UNavMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ComputeSlideVector(UNavMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ConstrainDirectionToPlane(UNavMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ConstrainLocationToPlane(UNavMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ConstrainNormalToPlane(UNavMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_Deactivate(UNavMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetGravityZ(UNavMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetMaxSpeed(UNavMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetMaxSpeedModifier(UNavMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetModifiedMaxSpeed(UNavMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetPenetrationAdjustment(UNavMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_HandleImpact(UNavMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_InitializeComponent(UNavMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsExceedingMaxSpeed(UNavMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsInWater(UNavMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_K2_GetMaxSpeedModifier(UNavMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_K2_GetModifiedMaxSpeed(UNavMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_MoveUpdatedComponentImpl(UNavMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnRegister(UNavMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnTeleported(UNavMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostLoad(UNavMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RegisterComponentTickFunctions(UNavMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ResolvePenetrationImpl(UNavMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetPlaneConstraintAxisSetting(UNavMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetPlaneConstraintEnabled(UNavMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetPlaneConstraintFromVectors(UNavMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetPlaneConstraintNormal(UNavMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetPlaneConstraintOrigin(UNavMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetUpdatedComponent(UNavMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldSkipUpdate(UNavMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SlideAlongSurface(UNavMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SnapUpdatedComponentToPlane(UNavMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_TwoWallAdjust(UNavMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UpdateComponentVelocity(UNavMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UpdateTickRegistration(UNavMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_Activate(UNavMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AddTickPrerequisiteActor(UNavMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AddTickPrerequisiteComponent(UNavMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ApplyWorldOffset(UNavMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_BeginDestroy(UNavMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_BeginPlay(UNavMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CreateRenderState_Concurrent(UNavMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_DestroyComponent(UNavMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_DestroyRenderState_Concurrent(UNavMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetComponentClassCanReplicate(UNavMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetReadableName(UNavMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_HasValidPhysicsState(UNavMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_InvalidateLightingCacheDetailed(UNavMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsActive(UNavMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsEditorOnly(UNavMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsNameStableForNetworking(UNavMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsNavigationRelevant(UNavMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsReadyForOwnerToAutoDestroy(UNavMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsSupportedForNetworking(UNavMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_MarkAsEditorOnlySubobject(UNavMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_NeedsLoadForClient(UNavMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_NeedsLoadForEditorGame(UNavMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_NeedsLoadForServer(UNavMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnActorEnableCollisionChanged(UNavMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnComponentCreated(UNavMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnComponentDestroyed(UNavMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnCreatePhysicsState(UNavMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnDestroyPhysicsState(UNavMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnUnregister(UNavMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostInitProperties(UNavMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostNetReceive(UNavMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostRename(UNavMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PreNetReceive(UNavMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RemoveTickPrerequisiteActor(UNavMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RemoveTickPrerequisiteComponent(UNavMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequiresGameThreadEndOfFrameRecreate(UNavMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequiresGameThreadEndOfFrameUpdates(UNavMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SendRenderDynamicData_Concurrent(UNavMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SendRenderTransform_Concurrent(UNavMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetActive(UNavMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetAutoActivate(UNavMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetComponentTickEnabled(UNavMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetComponentTickEnabledAsync(UNavMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldActivate(UNavMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UNavMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldCreatePhysicsState(UNavMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldCreateRenderState(UNavMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ToggleActive(UNavMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UninitializeComponent(UNavMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UpdateComponentToWorld(UNavMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AreNativePropertiesIdenticalTo(UNavMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CheckDefaultSubobjectsInternal(UNavMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_FinishDestroy(UNavMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetDesc(UNavMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetDetailedInfoInternal(UNavMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsAsset(UNavMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsFullNameStableForNetworking(UNavMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsLocalizedResource(UNavMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsPostLoadThreadSafe(UNavMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsReadyForFinishDestroy(UNavMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsSafeForRootSet(UNavMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_Modify(UNavMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_NotifyObjectReferenceEliminated(UNavMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostCDOContruct(UNavMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostEditImport(UNavMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostRepNotifies(UNavMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PostSaveRoot(UNavMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_PreDestroyFromReplication(UNavMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShutdownAfterError(UNavMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_AddToCluster(UNavMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanBeClusterRoot(UNavMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanBeInCluster(UNavMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CreateCluster(UNavMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_OnClusterMarkedAsPendingKill(UNavMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
