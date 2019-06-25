#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageProjectileMovementComponent.h"
#include "Runtime/Engine/Classes/GameFramework/ProjectileMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

class E_PROTECTED_WRAP_UProjectileMovementComponent : protected UProjectileMovementComponent
{
public:
	FVector ComputeAcceleration_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeAcceleration(InVelocity, DeltaTime);
	}

	FVector ComputeBounceResult_WRAP(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
	{
		return ComputeBounceResult(Hit, TimeSlice, MoveDelta);
	}

	FVector ComputeHomingAcceleration_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeHomingAcceleration(InVelocity, DeltaTime);
	}

	FVector ComputeMoveDelta_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeMoveDelta(InVelocity, DeltaTime);
	}

	EHandleBlockingHitResult HandleBlockingHit_WRAP(const FHitResult& Hit, float TimeTick, const FVector& MoveDelta, float& SubTickTimeRemaining)
	{
		return HandleBlockingHit(Hit, TimeTick, MoveDelta, SubTickTimeRemaining);
	}

	bool HandleSliding_WRAP(FHitResult& Hit, float& SubTickTimeRemaining)
	{
		return HandleSliding(Hit, SubTickTimeRemaining);
	}

	FVector LimitVelocity_WRAP(FVector NewVelocity)
	{
		return LimitVelocity(NewVelocity);
	}

	void TickInterpolation_WRAP(float DeltaTime)
	{
		TickInterpolation(DeltaTime);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_GET(UProjectileMovementComponent* Ptr) { return Ptr->bBounceAngleAffectsFriction; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bBounceAngleAffectsFriction_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bBounceAngleAffectsFriction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bForceSubStepping_GET(UProjectileMovementComponent* Ptr) { return Ptr->bForceSubStepping; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bForceSubStepping_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bForceSubStepping = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_GET(UProjectileMovementComponent* Ptr) { return Ptr->bInitialVelocityInLocalSpace; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bInitialVelocityInLocalSpace_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bInitialVelocityInLocalSpace = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bInterpMovement_GET(UProjectileMovementComponent* Ptr) { return Ptr->bInterpMovement; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bInterpMovement_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bInterpMovement = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bInterpRotation_GET(UProjectileMovementComponent* Ptr) { return Ptr->bInterpRotation; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bInterpRotation_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bInterpRotation = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bIsHomingProjectile_GET(UProjectileMovementComponent* Ptr) { return Ptr->bIsHomingProjectile; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bIsHomingProjectile_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bIsHomingProjectile = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bIsSliding_GET(UProjectileMovementComponent* Ptr) { return Ptr->bIsSliding; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bIsSliding_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bIsSliding = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_GET(UProjectileMovementComponent* Ptr) { return Ptr->BounceAdditionalIterations; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_BounceAdditionalIterations_SET(UProjectileMovementComponent* Ptr, int32 Value) { Ptr->BounceAdditionalIterations = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_GET(UProjectileMovementComponent* Ptr) { return Ptr->BounceVelocityStopSimulatingThreshold; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_BounceVelocityStopSimulatingThreshold_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->BounceVelocityStopSimulatingThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_Bounciness_GET(UProjectileMovementComponent* Ptr) { return Ptr->Bounciness; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_Bounciness_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->Bounciness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_GET(UProjectileMovementComponent* Ptr) { return Ptr->bRotationFollowsVelocity; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bRotationFollowsVelocity_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bRotationFollowsVelocity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bShouldBounce_GET(UProjectileMovementComponent* Ptr) { return Ptr->bShouldBounce; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bShouldBounce_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bShouldBounce = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bSimulationEnabled_GET(UProjectileMovementComponent* Ptr) { return Ptr->bSimulationEnabled; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bSimulationEnabled_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bSimulationEnabled = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_bSweepCollision_GET(UProjectileMovementComponent* Ptr) { return Ptr->bSweepCollision; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_bSweepCollision_SET(UProjectileMovementComponent* Ptr, uint8 Value) { Ptr->bSweepCollision = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_Buoyancy_GET(UProjectileMovementComponent* Ptr) { return Ptr->Buoyancy; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_Buoyancy_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->Buoyancy = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_Friction_GET(UProjectileMovementComponent* Ptr) { return Ptr->Friction; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_Friction_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->Friction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_GET(UProjectileMovementComponent* Ptr) { return Ptr->HomingAccelerationMagnitude; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_HomingAccelerationMagnitude_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->HomingAccelerationMagnitude = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_InitialSpeed_GET(UProjectileMovementComponent* Ptr) { return Ptr->InitialSpeed; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_InitialSpeed_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->InitialSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_GET(UProjectileMovementComponent* Ptr) { return Ptr->InterpLocationMaxLagDistance; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_InterpLocationMaxLagDistance_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->InterpLocationMaxLagDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_GET(UProjectileMovementComponent* Ptr) { return Ptr->InterpLocationSnapToTargetDistance; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_InterpLocationSnapToTargetDistance_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->InterpLocationSnapToTargetDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_InterpLocationTime_GET(UProjectileMovementComponent* Ptr) { return Ptr->InterpLocationTime; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_InterpLocationTime_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->InterpLocationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_InterpRotationTime_GET(UProjectileMovementComponent* Ptr) { return Ptr->InterpRotationTime; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_InterpRotationTime_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->InterpRotationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_MaxSimulationIterations_GET(UProjectileMovementComponent* Ptr) { return Ptr->MaxSimulationIterations; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_MaxSimulationIterations_SET(UProjectileMovementComponent* Ptr, int32 Value) { Ptr->MaxSimulationIterations = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_GET(UProjectileMovementComponent* Ptr) { return Ptr->MaxSimulationTimeStep; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_MaxSimulationTimeStep_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->MaxSimulationTimeStep = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_MaxSpeed_GET(UProjectileMovementComponent* Ptr) { return Ptr->MaxSpeed; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_MaxSpeed_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->MaxSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_MinFrictionFraction_GET(UProjectileMovementComponent* Ptr) { return Ptr->MinFrictionFraction; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_MinFrictionFraction_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->MinFrictionFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_PreviousHitNormal_GET(UProjectileMovementComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousHitNormal); }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_PreviousHitNormal_SET(UProjectileMovementComponent* Ptr, INT_PTR Value) { Ptr->PreviousHitNormal = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_PreviousHitTime_GET(UProjectileMovementComponent* Ptr) { return Ptr->PreviousHitTime; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_PreviousHitTime_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->PreviousHitTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UProjectileMovementComponent_ProjectileGravityScale_GET(UProjectileMovementComponent* Ptr) { return Ptr->ProjectileGravityScale; }
	DOTNET_EXPORT void E_PROP_UProjectileMovementComponent_ProjectileGravityScale_SET(UProjectileMovementComponent* Ptr, float Value) { Ptr->ProjectileGravityScale = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UProjectileMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UProjectileMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CheckStillInWorld(UProjectileMovementComponent* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeAcceleration(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto& _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeAcceleration_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeBounceResult(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto& _p2 = *(FVector*)MoveDelta;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeBounceResult_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeHomingAcceleration(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto& _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeHomingAcceleration_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeMoveDelta(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto& _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeMoveDelta_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeVelocity(UProjectileMovementComponent* Self, INT_PTR InitialVelocity, float DeltaTime)
	{
		auto _p0 = *(FVector*)InitialVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(Self->ComputeVelocity(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetBuoyancy(UProjectileMovementComponent* Self)
	{
		return Self->GetBuoyancy();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetInterpolatedComponent(UProjectileMovementComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetInterpolatedComponent());
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetSimulationTimeStep(UProjectileMovementComponent* Self, float RemainingTime, int32 Iterations)
	{
		auto _p0 = RemainingTime;
		auto _p1 = Iterations;
		return Self->GetSimulationTimeStep(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleBlockingHit(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta, float SubTickTimeRemaining)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto& _p2 = *(FVector*)MoveDelta;
		auto& _p3 = SubTickTimeRemaining;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->HandleBlockingHit_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleSliding(UProjectileMovementComponent* Self, INT_PTR Hit, float SubTickTimeRemaining)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto& _p1 = SubTickTimeRemaining;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->HandleSliding_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HasStoppedSimulation(UProjectileMovementComponent* Self)
	{
		return Self->HasStoppedSimulation();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsInterpolationComplete(UProjectileMovementComponent* Self)
	{
		return Self->IsInterpolationComplete();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsVelocityUnderSimulationThreshold(UProjectileMovementComponent* Self)
	{
		return Self->IsVelocityUnderSimulationThreshold();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_LimitVelocity(UProjectileMovementComponent* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->LimitVelocity_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_MoveInterpolationTarget(UProjectileMovementComponent* Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)NewLocation;
		auto& _p1 = *(FRotator*)NewRotation;
		Self->MoveInterpolationTarget(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ResetInterpolation(UProjectileMovementComponent* Self)
	{
		Self->ResetInterpolation();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetInterpolatedComponent(UProjectileMovementComponent* Self, USceneComponent* Component)
	{
		auto _p0 = Component;
		Self->SetInterpolatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetVelocityInLocalSpace(UProjectileMovementComponent* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->SetVelocityInLocalSpace(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldApplyGravity(UProjectileMovementComponent* Self)
	{
		return Self->ShouldApplyGravity();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldUseSubStepping(UProjectileMovementComponent* Self)
	{
		return Self->ShouldUseSubStepping();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_StopSimulating(UProjectileMovementComponent* Self, INT_PTR HitResult)
	{
		auto& _p0 = *(FHitResult*)HitResult;
		Self->StopSimulating(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_TickInterpolation(UProjectileMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->TickInterpolation_WRAP(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_ResetInterpolation(UProjectileMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__ResetInterpolation();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_TickInterpolation(UProjectileMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageProjectileMovementComponent*)Self)->_Supper__TickInterpolation(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnTeleported(UMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnTeleported();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageProjectileMovementComponent*)Self)->_Supper__SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_StopMovementImmediately(UMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__StopMovementImmediately();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_UpdateComponentVelocity(UMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_UpdateTickRegistration(UMovementComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageProjectileMovementComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_Deactivate(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageProjectileMovementComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageProjectileMovementComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageProjectileMovementComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnRegister(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageProjectileMovementComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageProjectileMovementComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageProjectileMovementComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageProjectileMovementComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageProjectileMovementComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_BeginDestroy(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_FinishDestroy(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostCDOContruct(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostEditImport(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostInitProperties(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostLoad(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostNetReceive(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostRepNotifies(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageProjectileMovementComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_PreNetReceive(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UProjectileMovementComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageProjectileMovementComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
