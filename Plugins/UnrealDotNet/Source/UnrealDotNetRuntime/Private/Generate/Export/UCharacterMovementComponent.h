#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/CharacterMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:157

class E_PROTECTED_WRAP_UCharacterMovementComponent : protected UCharacterMovementComponent
{
public:
	void AdjustProxyCapsuleSize_WRAP()
	{
		AdjustProxyCapsuleSize();
	}

	void ApplyImpactPhysicsForces_WRAP(const FHitResult& Impact, const FVector& ImpactAcceleration, const FVector& ImpactVelocity)
	{
		ApplyImpactPhysicsForces(Impact, ImpactAcceleration, ImpactVelocity);
	}

	void ApplyVelocityBraking_WRAP(float DeltaTime, float Friction, float BrakingDeceleration)
	{
		ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
	}

	float BoostAirControl_WRAP(float DeltaTime, float TickAirControl, const FVector& FallAcceleration)
	{
		return BoostAirControl(DeltaTime, TickAirControl, FallAcceleration);
	}

	void CallMovementUpdateDelegate_WRAP(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
	{
		CallMovementUpdateDelegate(DeltaSeconds, OldLocation, OldVelocity);
	}

	void CapsuleTouched_WRAP(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult)
	{
		CapsuleTouched(OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
	}

	bool ClientUpdatePositionAfterServerUpdate_WRAP()
	{
		return ClientUpdatePositionAfterServerUpdate();
	}

	float ComputeAnalogInputModifier_WRAP()
	{
		return ComputeAnalogInputModifier();
	}

	FVector ComputeGroundMovementDelta_WRAP(const FVector& Delta, const FHitResult& RampHit, const bool bHitFromLineTrace)
	{
		return ComputeGroundMovementDelta(Delta, RampHit, bHitFromLineTrace);
	}

	FVector ConstrainInputAcceleration_WRAP(const FVector& InputAcceleration)
	{
		return ConstrainInputAcceleration(InputAcceleration);
	}

	void FindBestNavMeshLocation_WRAP(const FVector& TraceStart, const FVector& TraceEnd, const FVector& CurrentFeetLocation, const FVector& TargetNavLocation, FHitResult& OutHitResult)
	{
		FindBestNavMeshLocation(TraceStart, TraceEnd, CurrentFeetLocation, TargetNavLocation, OutHitResult);
	}

	FVector HandleSlopeBoosting_WRAP(const FVector& SlideResult, const FVector& Delta, const float Time, const FVector& Normal, const FHitResult& Hit)
	{
		return HandleSlopeBoosting(SlideResult, Delta, Time, Normal, Hit);
	}

	void HandleSwimmingWallHit_WRAP(const FHitResult& Hit, float DeltaTime)
	{
		HandleSwimmingWallHit(Hit, DeltaTime);
	}

	FVector LimitAirControl_WRAP(float DeltaTime, const FVector& FallAcceleration, const FHitResult& HitResult, bool bCheckForValidLandingSpot)
	{
		return LimitAirControl(DeltaTime, FallAcceleration, HitResult, bCheckForValidLandingSpot);
	}

	void MaintainHorizontalGroundVelocity_WRAP()
	{
		MaintainHorizontalGroundVelocity();
	}

	void MoveAutonomous_WRAP(float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, const FVector& NewAccel)
	{
		MoveAutonomous(ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
	}

	void OnCharacterStuckInGeometry_WRAP(const FHitResult* Hit)
	{
		OnCharacterStuckInGeometry(Hit);
	}

	void OnClientTimeStampResetDetected_WRAP()
	{
		OnClientTimeStampResetDetected();
	}

	void OnMovementModeChanged_WRAP(EMovementMode PreviousMovementMode, uint8 PreviousCustomMode)
	{
		OnMovementModeChanged(PreviousMovementMode, PreviousCustomMode);
	}

	void OnMovementUpdated_WRAP(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
	{
		OnMovementUpdated(DeltaSeconds, OldLocation, OldVelocity);
	}

	void OnTimeDiscrepancyDetected_WRAP(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
	{
		OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
	}

	void OnUnableToFollowBaseMove_WRAP(const FVector& DeltaPosition, const FVector& OldLocation, const FHitResult& MoveOnBaseHit)
	{
		OnUnableToFollowBaseMove(DeltaPosition, OldLocation, MoveOnBaseHit);
	}

	void PerformMovement_WRAP(float DeltaTime)
	{
		PerformMovement(DeltaTime);
	}

	void PhysCustom_WRAP(float deltaTime, int32 Iterations)
	{
		PhysCustom(deltaTime, Iterations);
	}

	void PhysFlying_WRAP(float deltaTime, int32 Iterations)
	{
		PhysFlying(deltaTime, Iterations);
	}

	void PhysNavWalking_WRAP(float deltaTime, int32 Iterations)
	{
		PhysNavWalking(deltaTime, Iterations);
	}

	void PhysSwimming_WRAP(float deltaTime, int32 Iterations)
	{
		PhysSwimming(deltaTime, Iterations);
	}

	void PhysWalking_WRAP(float deltaTime, int32 Iterations)
	{
		PhysWalking(deltaTime, Iterations);
	}

	void ProcessLanded_WRAP(const FHitResult& Hit, float remainingTime, int32 Iterations)
	{
		ProcessLanded(Hit, remainingTime, Iterations);
	}

	FVector ProjectLocationFromNavMesh_WRAP(float DeltaSeconds, const FVector& CurrentFeetLocation, const FVector& TargetNavLocation, float UpOffset, float DownOffset)
	{
		return ProjectLocationFromNavMesh(DeltaSeconds, CurrentFeetLocation, TargetNavLocation, UpOffset, DownOffset);
	}

	void ReplicateMoveToServer_WRAP(float DeltaTime, const FVector& NewAcceleration)
	{
		ReplicateMoveToServer(DeltaTime, NewAcceleration);
	}

	FVector ScaleInputAcceleration_WRAP(const FVector& InputAcceleration)
	{
		return ScaleInputAcceleration(InputAcceleration);
	}

	bool ServerCheckClientError_WRAP(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& ClientWorldLocation, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode)
	{
		return ServerCheckClientError(ClientTimeStamp, DeltaTime, Accel, ClientWorldLocation, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
	}

	void ServerMoveHandleClientError_WRAP(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode)
	{
		ServerMoveHandleClientError(ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
	}

	void SetNavWalkingPhysics_WRAP(bool bEnable)
	{
		SetNavWalkingPhysics(bEnable);
	}

	void SetPostLandedPhysics_WRAP(const FHitResult& Hit)
	{
		SetPostLandedPhysics(Hit);
	}

	bool ShouldCancelAdaptiveReplication_WRAP()
	{
		return ShouldCancelAdaptiveReplication();
	}

	void SimulatedTick_WRAP(float DeltaSeconds)
	{
		SimulatedTick(DeltaSeconds);
	}

	void SimulateMovement_WRAP(float DeltaTime)
	{
		SimulateMovement(DeltaTime);
	}

	void SmoothClientPosition_WRAP(float DeltaSeconds)
	{
		SmoothClientPosition(DeltaSeconds);
	}

	void SmoothClientPosition_Interpolate_WRAP(float DeltaSeconds)
	{
		SmoothClientPosition_Interpolate(DeltaSeconds);
	}

	void SmoothClientPosition_UpdateVisuals_WRAP()
	{
		SmoothClientPosition_UpdateVisuals();
	}

	void TickCharacterPose_WRAP(float DeltaTime)
	{
		TickCharacterPose(DeltaTime);
	}

	bool TryToLeaveNavWalking_WRAP()
	{
		return TryToLeaveNavWalking();
	}

	void UpdateFromCompressedFlags_WRAP(uint8 Flags)
	{
		UpdateFromCompressedFlags(Flags);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AirControl_GET(UCharacterMovementComponent* Ptr) { return Ptr->AirControl; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AirControl_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->AirControl = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_GET(UCharacterMovementComponent* Ptr) { return Ptr->AirControlBoostMultiplier; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->AirControlBoostMultiplier = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_GET(UCharacterMovementComponent* Ptr) { return Ptr->AirControlBoostVelocityThreshold; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->AirControlBoostVelocityThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_GET(UCharacterMovementComponent* Ptr) { return Ptr->AvoidanceConsiderationRadius; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->AvoidanceConsiderationRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AvoidanceUID_GET(UCharacterMovementComponent* Ptr) { return Ptr->AvoidanceUID; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AvoidanceUID_SET(UCharacterMovementComponent* Ptr, int32 Value) { Ptr->AvoidanceUID = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_AvoidanceWeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->AvoidanceWeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_AvoidanceWeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->AvoidanceWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_GET(UCharacterMovementComponent* Ptr) { return Ptr->bEnablePhysicsInteraction; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_SET(UCharacterMovementComponent* Ptr, bool Value) { Ptr->bEnablePhysicsInteraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_GET(UCharacterMovementComponent* Ptr) { return Ptr->bPushForceScaledToMass; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_SET(UCharacterMovementComponent* Ptr, bool Value) { Ptr->bPushForceScaledToMass = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_GET(UCharacterMovementComponent* Ptr) { return Ptr->bPushForceUsingZOffset; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_SET(UCharacterMovementComponent* Ptr, bool Value) { Ptr->bPushForceUsingZOffset = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingDecelerationFalling; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingDecelerationFalling = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingDecelerationFlying; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingDecelerationFlying = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingDecelerationSwimming; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingDecelerationSwimming = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingDecelerationWalking; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingDecelerationWalking = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingFriction_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingFriction; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingFriction_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingFriction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->BrakingFrictionFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->BrakingFrictionFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_GET(UCharacterMovementComponent* Ptr) { return Ptr->bScalePushForceToVelocity; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_SET(UCharacterMovementComponent* Ptr, bool Value) { Ptr->bScalePushForceToVelocity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_GET(UCharacterMovementComponent* Ptr) { return Ptr->bTouchForceScaledToMass; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_SET(UCharacterMovementComponent* Ptr, bool Value) { Ptr->bTouchForceScaledToMass = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_Buoyancy_GET(UCharacterMovementComponent* Ptr) { return Ptr->Buoyancy; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_Buoyancy_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->Buoyancy = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->CachedProjectedNavMeshHitResult); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->CachedProjectedNavMeshHitResult = *(FHitResult*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->CrouchedHalfHeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->CrouchedHalfHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_GET(UCharacterMovementComponent* Ptr) { return Ptr->CrouchedSpeedMultiplier_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->CrouchedSpeedMultiplier_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_CurrentFloor_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->CurrentFloor); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_CurrentFloor_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->CurrentFloor = *(FFindFloorResult*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_CustomMovementMode_GET(UCharacterMovementComponent* Ptr) { return Ptr->CustomMovementMode; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_CustomMovementMode_SET(UCharacterMovementComponent* Ptr, uint8 Value) { Ptr->CustomMovementMode = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_GET(UCharacterMovementComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->DeferredUpdatedMoveComponent); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_SET(UCharacterMovementComponent* Ptr, USceneComponent* Value) { Ptr->DeferredUpdatedMoveComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_FallingLateralFriction_GET(UCharacterMovementComponent* Ptr) { return Ptr->FallingLateralFriction; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_FallingLateralFriction_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->FallingLateralFriction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_GravityScale_GET(UCharacterMovementComponent* Ptr) { return Ptr->GravityScale; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_GravityScale_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->GravityScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_GroundFriction_GET(UCharacterMovementComponent* Ptr) { return Ptr->GroundFriction; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_GroundFriction_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->GroundFriction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_InitialPushForceFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->InitialPushForceFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_InitialPushForceFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->InitialPushForceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->JumpOffJumpZFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->JumpOffJumpZFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_GET(UCharacterMovementComponent* Ptr) { return Ptr->JumpOutOfWaterPitch; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->JumpOutOfWaterPitch = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_JumpZVelocity_GET(UCharacterMovementComponent* Ptr) { return Ptr->JumpZVelocity; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_JumpZVelocity_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->JumpZVelocity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_GET(UCharacterMovementComponent* Ptr) { return Ptr->LedgeCheckThreshold; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->LedgeCheckThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_GET(UCharacterMovementComponent* Ptr) { return Ptr->ListenServerNetworkSimulatedSmoothLocationTime; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->ListenServerNetworkSimulatedSmoothLocationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_GET(UCharacterMovementComponent* Ptr) { return Ptr->ListenServerNetworkSimulatedSmoothRotationTime; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->ListenServerNetworkSimulatedSmoothRotationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_Mass_GET(UCharacterMovementComponent* Ptr) { return Ptr->Mass; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_Mass_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->Mass = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxAcceleration_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxAcceleration; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxAcceleration_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxAcceleration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxCustomMovementSpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxCustomMovementSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxDepenetrationWithGeometry; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxDepenetrationWithGeometry = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxDepenetrationWithGeometryAsProxy; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxDepenetrationWithGeometryAsProxy = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxDepenetrationWithPawn; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxDepenetrationWithPawn = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxDepenetrationWithPawnAsProxy; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxDepenetrationWithPawnAsProxy = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxFlySpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxFlySpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxFlySpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxFlySpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxOutOfWaterStepHeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxOutOfWaterStepHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxSimulationIterations_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxSimulationIterations; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxSimulationIterations_SET(UCharacterMovementComponent* Ptr, int32 Value) { Ptr->MaxSimulationIterations = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxSimulationTimeStep; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxSimulationTimeStep = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxStepHeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxStepHeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxStepHeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxStepHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxSwimSpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxSwimSpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxSwimSpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxSwimSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxTouchForce_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxTouchForce; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxTouchForce_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxTouchForce = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxWalkSpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxWalkSpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxWalkSpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxWalkSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_GET(UCharacterMovementComponent* Ptr) { return Ptr->MaxWalkSpeedCrouched; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MaxWalkSpeedCrouched = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->MinAnalogWalkSpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MinAnalogWalkSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_GET(UCharacterMovementComponent* Ptr) { return Ptr->MinTimeBetweenTimeStampResets; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MinTimeBetweenTimeStampResets = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_MinTouchForce_GET(UCharacterMovementComponent* Ptr) { return Ptr->MinTouchForce; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_MinTouchForce_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->MinTouchForce = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavMeshProjectionHeightScaleDown; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavMeshProjectionHeightScaleDown = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavMeshProjectionHeightScaleUp; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavMeshProjectionHeightScaleUp = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavMeshProjectionInterpSpeed; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavMeshProjectionInterpSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavMeshProjectionInterval; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavMeshProjectionInterval = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavMeshProjectionTimer; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavMeshProjectionTimer = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_GET(UCharacterMovementComponent* Ptr) { return Ptr->NavWalkingFloorDistTolerance; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NavWalkingFloorDistTolerance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetProxyShrinkHalfHeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetProxyShrinkHalfHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetProxyShrinkRadius; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetProxyShrinkRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkLargeClientCorrectionDistance; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkLargeClientCorrectionDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkMaxSmoothUpdateDistance; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkMaxSmoothUpdateDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkMinTimeBetweenClientAckGoodMoves; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkMinTimeBetweenClientAckGoodMoves = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkMinTimeBetweenClientAdjustments; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkMinTimeBetweenClientAdjustments = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkMinTimeBetweenClientAdjustmentsLargeCorrection; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkMinTimeBetweenClientAdjustmentsLargeCorrection = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkNoSmoothUpdateDistance; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkNoSmoothUpdateDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkSimulatedSmoothLocationTime; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkSimulatedSmoothLocationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkSimulatedSmoothRotationTime; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->NetworkSimulatedSmoothRotationTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_GET(UCharacterMovementComponent* Ptr) { return Ptr->NetworkSmoothingMode; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_SET(UCharacterMovementComponent* Ptr, ENetworkSmoothingMode Value) { Ptr->NetworkSmoothingMode = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_OldBaseLocation_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->OldBaseLocation); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_OldBaseLocation_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->OldBaseLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_OldBaseQuat_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->OldBaseQuat); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_OldBaseQuat_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->OldBaseQuat = *(FQuat*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_OutofWaterZ_GET(UCharacterMovementComponent* Ptr) { return Ptr->OutofWaterZ; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_OutofWaterZ_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->OutofWaterZ = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->PendingLaunchVelocity); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->PendingLaunchVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_GET(UCharacterMovementComponent* Ptr) { return Ptr->PerchAdditionalHeight; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->PerchAdditionalHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_GET(UCharacterMovementComponent* Ptr) { return Ptr->PerchRadiusThreshold; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->PerchRadiusThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_PushForceFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->PushForceFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_PushForceFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->PushForceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->PushForcePointZOffsetFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->PushForcePointZOffsetFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_RepulsionForce_GET(UCharacterMovementComponent* Ptr) { return Ptr->RepulsionForce; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_RepulsionForce_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->RepulsionForce = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_RequestedVelocity_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->RequestedVelocity); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_RequestedVelocity_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->RequestedVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_RotationRate_GET(UCharacterMovementComponent* Ptr) { return (INT_PTR)&(Ptr->RotationRate); }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_RotationRate_SET(UCharacterMovementComponent* Ptr, INT_PTR Value) { Ptr->RotationRate = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_GET(UCharacterMovementComponent* Ptr) { return Ptr->StandingDownwardForceScale; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->StandingDownwardForceScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_TouchForceFactor_GET(UCharacterMovementComponent* Ptr) { return Ptr->TouchForceFactor; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_TouchForceFactor_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->TouchForceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_GET(UCharacterMovementComponent* Ptr) { return Ptr->UpperImpactNormalScale_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_SET(UCharacterMovementComponent* Ptr, float Value) { Ptr->UpperImpactNormalScale_DEPRECATED = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCharacterMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCharacterMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_AddForce(UCharacterMovementComponent* Self, INT_PTR Force)
	{
		auto _p0 = *(FVector*)Force;
		Self->AddForce(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_AddImpulse(UCharacterMovementComponent* Self, INT_PTR Impulse, bool bVelocityChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = bVelocityChange;
		Self->AddImpulse(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_AdjustFloorHeight(UCharacterMovementComponent* Self)
	{
		Self->AdjustFloorHeight();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_AdjustProxyCapsuleSize(UCharacterMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->AdjustProxyCapsuleSize_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyAccumulatedForces(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->ApplyAccumulatedForces(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyDownwardForce(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->ApplyDownwardForce(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyImpactPhysicsForces(UCharacterMovementComponent* Self, INT_PTR Impact, INT_PTR ImpactAcceleration, INT_PTR ImpactVelocity)
	{
		auto _p0 = *(FHitResult*)Impact;
		auto _p1 = *(FVector*)ImpactAcceleration;
		auto _p2 = *(FVector*)ImpactVelocity;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ApplyImpactPhysicsForces_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyNetworkMovementMode(UCharacterMovementComponent* Self, uint8 ReceivedMode)
	{
		auto _p0 = ReceivedMode;
		Self->ApplyNetworkMovementMode(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyRepulsionForce(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->ApplyRepulsionForce(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyRequestedMove(UCharacterMovementComponent* Self, float DeltaTime, float MaxAccel, float MaxSpeed, float Friction, float BrakingDeceleration, INT_PTR OutAcceleration, float OutRequestedSpeed)
	{
		auto _p0 = DeltaTime;
		auto _p1 = MaxAccel;
		auto _p2 = MaxSpeed;
		auto _p3 = Friction;
		auto _p4 = BrakingDeceleration;
		auto _p5 = *(FVector*)OutAcceleration;
		auto _p6 = OutRequestedSpeed;
		return Self->ApplyRequestedMove(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ApplyVelocityBraking(UCharacterMovementComponent* Self, float DeltaTime, float Friction, float BrakingDeceleration)
	{
		auto _p0 = DeltaTime;
		auto _p1 = Friction;
		auto _p2 = BrakingDeceleration;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ApplyVelocityBraking_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_BoostAirControl(UCharacterMovementComponent* Self, float DeltaTime, float TickAirControl, INT_PTR FallAcceleration)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickAirControl;
		auto _p2 = *(FVector*)FallAcceleration;
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->BoostAirControl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CalcVelocity(UCharacterMovementComponent* Self, float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
	{
		auto _p0 = DeltaTime;
		auto _p1 = Friction;
		auto _p2 = bFluid;
		auto _p3 = BrakingDeceleration;
		Self->CalcVelocity(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CallMovementUpdateDelegate(UCharacterMovementComponent* Self, float DeltaSeconds, INT_PTR OldLocation, INT_PTR OldVelocity)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = *(FVector*)OldLocation;
		auto _p2 = *(FVector*)OldVelocity;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->CallMovementUpdateDelegate_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CanCrouchInCurrentState(UCharacterMovementComponent* Self)
	{
		return Self->CanCrouchInCurrentState();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CanStepUp(UCharacterMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return Self->CanStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CanWalkOffLedges(UCharacterMovementComponent* Self)
	{
		return Self->CanWalkOffLedges();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CapsuleTouched(UCharacterMovementComponent* Self, UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, INT_PTR SweepResult)
	{
		auto _p0 = OverlappedComp;
		auto _p1 = Other;
		auto _p2 = OtherComp;
		auto _p3 = OtherBodyIndex;
		auto _p4 = bFromSweep;
		auto _p5 = *(FHitResult*)SweepResult;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->CapsuleTouched_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CheckFall(UCharacterMovementComponent* Self, INT_PTR OldFloor, INT_PTR Hit, INT_PTR Delta, INT_PTR OldLocation, float remainingTime, float timeTick, int32 Iterations, bool bMustJump)
	{
		auto _p0 = *(FFindFloorResult*)OldFloor;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)Delta;
		auto _p3 = *(FVector*)OldLocation;
		auto _p4 = remainingTime;
		auto _p5 = timeTick;
		auto _p6 = Iterations;
		auto _p7 = bMustJump;
		return Self->CheckFall(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CheckLedgeDirection(UCharacterMovementComponent* Self, INT_PTR OldLocation, INT_PTR SideStep, INT_PTR GravDir)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FVector*)SideStep;
		auto _p2 = *(FVector*)GravDir;
		return Self->CheckLedgeDirection(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_CheckWaterJump(UCharacterMovementComponent* Self, INT_PTR CheckPoint, INT_PTR WallNormal)
	{
		auto _p0 = *(FVector*)CheckPoint;
		auto _p1 = *(FVector*)WallNormal;
		return Self->CheckWaterJump(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClearAccumulatedForces(UCharacterMovementComponent* Self)
	{
		Self->ClearAccumulatedForces();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientAckGoodMove(UCharacterMovementComponent* Self, float TimeStamp)
	{
		auto _p0 = TimeStamp;
		Self->ClientAckGoodMove(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(UCharacterMovementComponent* Self, float TimeStamp)
	{
		auto _p0 = TimeStamp;
		Self->ClientAckGoodMove_Implementation(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientAdjustPosition(UCharacterMovementComponent* Self, float TimeStamp, INT_PTR NewLoc, INT_PTR NewVel, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = *(FVector*)NewVel;
		auto _p3 = NewBase;
		auto _p4 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p5 = bHasBase;
		auto _p6 = bBaseRelativePosition;
		auto _p7 = ServerMovementMode;
		Self->ClientAdjustPosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(UCharacterMovementComponent* Self, float TimeStamp, INT_PTR NewLoc, INT_PTR NewVel, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = *(FVector*)NewVel;
		auto _p3 = NewBase;
		auto _p4 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p5 = bHasBase;
		auto _p6 = bBaseRelativePosition;
		auto _p7 = ServerMovementMode;
		Self->ClientAdjustPosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(UCharacterMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ClientUpdatePositionAfterServerUpdate_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(UCharacterMovementComponent* Self, float TimeStamp, INT_PTR NewLoc, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = NewBase;
		auto _p3 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p4 = bHasBase;
		auto _p5 = bBaseRelativePosition;
		auto _p6 = ServerMovementMode;
		Self->ClientVeryShortAdjustPosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(UCharacterMovementComponent* Self, float TimeStamp, INT_PTR NewLoc, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = NewBase;
		auto _p3 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p4 = bHasBase;
		auto _p5 = bBaseRelativePosition;
		auto _p6 = ServerMovementMode;
		Self->ClientVeryShortAdjustPosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ComputeAnalogInputModifier(UCharacterMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ComputeAnalogInputModifier_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ComputeFloorDist(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, float LineDistance, float SweepDistance, INT_PTR OutFloorResult, float SweepRadius, INT_PTR DownwardSweepResult)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = LineDistance;
		auto _p2 = SweepDistance;
		auto _p3 = *(FFindFloorResult*)OutFloorResult;
		auto _p4 = SweepRadius;
		auto _p5 = (FHitResult*)DownwardSweepResult;
		Self->ComputeFloorDist(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ComputeGroundMovementDelta(UCharacterMovementComponent* Self, INT_PTR Delta, INT_PTR RampHit, bool bHitFromLineTrace)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)RampHit;
		auto _p2 = bHitFromLineTrace;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ComputeGroundMovementDelta_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ComputeOrientToMovementRotation(UCharacterMovementComponent* Self, INT_PTR CurrentRotation, float DeltaTime, INT_PTR DeltaRotation)
	{
		auto _p0 = *(FRotator*)CurrentRotation;
		auto _p1 = DeltaTime;
		auto _p2 = *(FRotator*)DeltaRotation;
		return (INT_PTR) new FRotator(Self->ComputeOrientToMovementRotation(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ComputePerchResult(UCharacterMovementComponent* Self, float TestRadius, INT_PTR InHit, float InMaxFloorDist, INT_PTR OutPerchFloorResult)
	{
		auto _p0 = TestRadius;
		auto _p1 = *(FHitResult*)InHit;
		auto _p2 = InMaxFloorDist;
		auto _p3 = *(FFindFloorResult*)OutPerchFloorResult;
		return Self->ComputePerchResult(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ConstrainInputAcceleration(UCharacterMovementComponent* Self, INT_PTR InputAcceleration)
	{
		auto _p0 = *(FVector*)InputAcceleration;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ConstrainInputAcceleration_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_Crouch(UCharacterMovementComponent* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->Crouch(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_DisableMovement(UCharacterMovementComponent* Self)
	{
		Self->DisableMovement();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_DoJump(UCharacterMovementComponent* Self, bool bReplayingMoves)
	{
		auto _p0 = bReplayingMoves;
		return Self->DoJump(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_FindBestNavMeshLocation(UCharacterMovementComponent* Self, INT_PTR TraceStart, INT_PTR TraceEnd, INT_PTR CurrentFeetLocation, INT_PTR TargetNavLocation, INT_PTR OutHitResult)
	{
		auto _p0 = *(FVector*)TraceStart;
		auto _p1 = *(FVector*)TraceEnd;
		auto _p2 = *(FVector*)CurrentFeetLocation;
		auto _p3 = *(FVector*)TargetNavLocation;
		auto _p4 = *(FHitResult*)OutHitResult;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->FindBestNavMeshLocation_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_FindFloor(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, INT_PTR OutFloorResult, bool bZeroDelta, INT_PTR DownwardSweepResult)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = *(FFindFloorResult*)OutFloorResult;
		auto _p2 = bZeroDelta;
		auto _p3 = (FHitResult*)DownwardSweepResult;
		Self->FindFloor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_FindWaterLine(UCharacterMovementComponent* Self, INT_PTR Start, INT_PTR End)
	{
		auto _p0 = *(FVector*)Start;
		auto _p1 = *(FVector*)End;
		return (INT_PTR) new FVector(Self->FindWaterLine(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ForceClientAdjustment(UCharacterMovementComponent* Self)
	{
		Self->ForceClientAdjustment();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ForceReplicationUpdate(UCharacterMovementComponent* Self)
	{
		Self->ForceReplicationUpdate();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetAirControl(UCharacterMovementComponent* Self, float DeltaTime, float TickAirControl, INT_PTR FallAcceleration)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickAirControl;
		auto _p2 = *(FVector*)FallAcceleration;
		return (INT_PTR) new FVector(Self->GetAirControl(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetAnalogInputModifier(UCharacterMovementComponent* Self)
	{
		return Self->GetAnalogInputModifier();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetBestDirectionOffActor(UCharacterMovementComponent* Self, AActor* BaseActor)
	{
		auto _p0 = BaseActor;
		return (INT_PTR) new FVector(Self->GetBestDirectionOffActor(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetCharacterOwner(UCharacterMovementComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCharacterOwner());
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetCurrentAcceleration(UCharacterMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetCurrentAcceleration());
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetDeltaRotation(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return (INT_PTR) new FRotator(Self->GetDeltaRotation(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetFallingLateralAcceleration(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return (INT_PTR) new FVector(Self->GetFallingLateralAcceleration(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetGroundMovementMode(UCharacterMovementComponent* Self)
	{
		return Self->GetGroundMovementMode();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetImpartedMovementBaseVelocity(UCharacterMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetImpartedMovementBaseVelocity());
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetLedgeMove(UCharacterMovementComponent* Self, INT_PTR OldLocation, INT_PTR Delta, INT_PTR GravDir)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FVector*)Delta;
		auto _p2 = *(FVector*)GravDir;
		return (INT_PTR) new FVector(Self->GetLedgeMove(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMaxAcceleration(UCharacterMovementComponent* Self)
	{
		return Self->GetMaxAcceleration();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMaxBrakingDeceleration(UCharacterMovementComponent* Self)
	{
		return Self->GetMaxBrakingDeceleration();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMaxJumpHeight(UCharacterMovementComponent* Self)
	{
		return Self->GetMaxJumpHeight();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMaxJumpHeightWithJumpTime(UCharacterMovementComponent* Self)
	{
		return Self->GetMaxJumpHeightWithJumpTime();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMinAnalogSpeed(UCharacterMovementComponent* Self)
	{
		return Self->GetMinAnalogSpeed();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetModifiedMaxAcceleration(UCharacterMovementComponent* Self)
	{
		return Self->GetModifiedMaxAcceleration();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMovementBase(UCharacterMovementComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetMovementName(UCharacterMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetMovementName());
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetNetworkSafeRandomAngleDegrees(UCharacterMovementComponent* Self)
	{
		return Self->GetNetworkSafeRandomAngleDegrees();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetPerchRadiusThreshold(UCharacterMovementComponent* Self)
	{
		return Self->GetPerchRadiusThreshold();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetServerLastTransformUpdateTimeStamp(UCharacterMovementComponent* Self)
	{
		return Self->GetServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetSimulationTimeStep(UCharacterMovementComponent* Self, float RemainingTime, int32 Iterations)
	{
		auto _p0 = RemainingTime;
		auto _p1 = Iterations;
		return Self->GetSimulationTimeStep(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetValidPerchRadius(UCharacterMovementComponent* Self)
	{
		return Self->GetValidPerchRadius();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetWalkableFloorAngle(UCharacterMovementComponent* Self)
	{
		return Self->GetWalkableFloorAngle();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_GetWalkableFloorZ(UCharacterMovementComponent* Self)
	{
		return Self->GetWalkableFloorZ();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_HandlePendingLaunch(UCharacterMovementComponent* Self)
	{
		return Self->HandlePendingLaunch();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_HandleSlopeBoosting(UCharacterMovementComponent* Self, INT_PTR SlideResult, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)SlideResult;
		auto _p1 = *(FVector*)Delta;
		auto _p2 = Time;
		auto _p3 = *(FVector*)Normal;
		auto _p4 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->HandleSlopeBoosting_WRAP(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_HandleSwimmingWallHit(UCharacterMovementComponent* Self, INT_PTR Hit, float DeltaTime)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = DeltaTime;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->HandleSwimmingWallHit_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_HasRootMotionSources(UCharacterMovementComponent* Self)
	{
		return Self->HasRootMotionSources();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_HasValidData(UCharacterMovementComponent* Self)
	{
		return Self->HasValidData();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ImmersionDepth(UCharacterMovementComponent* Self)
	{
		return Self->ImmersionDepth();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_IsMovementInProgress(UCharacterMovementComponent* Self)
	{
		return Self->IsMovementInProgress();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_IsValidLandingSpot(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = *(FHitResult*)Hit;
		return Self->IsValidLandingSpot(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_IsWalkable(UCharacterMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return Self->IsWalkable(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_IsWalking(UCharacterMovementComponent* Self)
	{
		return Self->IsWalking();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_IsWithinEdgeTolerance(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, INT_PTR TestImpactPoint, float CapsuleRadius)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = *(FVector*)TestImpactPoint;
		auto _p2 = CapsuleRadius;
		return Self->IsWithinEdgeTolerance(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_JumpOff(UCharacterMovementComponent* Self, AActor* MovementBaseActor)
	{
		auto _p0 = MovementBaseActor;
		Self->JumpOff(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_JumpOutOfWater(UCharacterMovementComponent* Self, INT_PTR WallNormal)
	{
		auto _p0 = *(FVector*)WallNormal;
		Self->JumpOutOfWater(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_K2_ComputeFloorDist(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, INT_PTR FloorResult)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = LineDistance;
		auto _p2 = SweepDistance;
		auto _p3 = SweepRadius;
		auto _p4 = *(FFindFloorResult*)FloorResult;
		Self->K2_ComputeFloorDist(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_K2_FindFloor(UCharacterMovementComponent* Self, INT_PTR CapsuleLocation, INT_PTR FloorResult)
	{
		auto _p0 = *(FVector*)CapsuleLocation;
		auto _p1 = *(FFindFloorResult*)FloorResult;
		Self->K2_FindFloor(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_K2_GetModifiedMaxAcceleration(UCharacterMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxAcceleration();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_K2_GetWalkableFloorAngle(UCharacterMovementComponent* Self)
	{
		return Self->K2_GetWalkableFloorAngle();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_K2_GetWalkableFloorZ(UCharacterMovementComponent* Self)
	{
		return Self->K2_GetWalkableFloorZ();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_Launch(UCharacterMovementComponent* Self, INT_PTR LaunchVel)
	{
		auto _p0 = *(FVector*)LaunchVel;
		Self->Launch(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_LimitAirControl(UCharacterMovementComponent* Self, float DeltaTime, INT_PTR FallAcceleration, INT_PTR HitResult, bool bCheckForValidLandingSpot)
	{
		auto _p0 = DeltaTime;
		auto _p1 = *(FVector*)FallAcceleration;
		auto _p2 = *(FHitResult*)HitResult;
		auto _p3 = bCheckForValidLandingSpot;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->LimitAirControl_WRAP(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_MaintainHorizontalGroundVelocity(UCharacterMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->MaintainHorizontalGroundVelocity_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_MaybeSaveBaseLocation(UCharacterMovementComponent* Self)
	{
		Self->MaybeSaveBaseLocation();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_MaybeUpdateBasedMovement(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->MaybeUpdateBasedMovement(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_MoveAutonomous(UCharacterMovementComponent* Self, float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, INT_PTR NewAccel)
	{
		auto _p0 = ClientTimeStamp;
		auto _p1 = DeltaTime;
		auto _p2 = CompressedFlags;
		auto _p3 = *(FVector*)NewAccel;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->MoveAutonomous_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_NewFallVelocity(UCharacterMovementComponent* Self, INT_PTR InitialVelocity, INT_PTR Gravity, float DeltaTime)
	{
		auto _p0 = *(FVector*)InitialVelocity;
		auto _p1 = *(FVector*)Gravity;
		auto _p2 = DeltaTime;
		return (INT_PTR) new FVector(Self->NewFallVelocity(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_NotifyJumpApex(UCharacterMovementComponent* Self)
	{
		Self->NotifyJumpApex();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnCharacterStuckInGeometry(UCharacterMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = (FHitResult*)Hit;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnCharacterStuckInGeometry_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnClientTimeStampResetDetected(UCharacterMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnClientTimeStampResetDetected_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnMovementModeChanged(UCharacterMovementComponent* Self, EMovementMode PreviousMovementMode, uint8 PreviousCustomMode)
	{
		auto _p0 = PreviousMovementMode;
		auto _p1 = PreviousCustomMode;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnMovementModeChanged_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnMovementUpdated(UCharacterMovementComponent* Self, float DeltaSeconds, INT_PTR OldLocation, INT_PTR OldVelocity)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = *(FVector*)OldLocation;
		auto _p2 = *(FVector*)OldVelocity;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnMovementUpdated_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(UCharacterMovementComponent* Self, float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
	{
		auto _p0 = CurrentTimeDiscrepancy;
		auto _p1 = LifetimeRawTimeDiscrepancy;
		auto _p2 = Lifetime;
		auto _p3 = CurrentMoveError;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnTimeDiscrepancyDetected_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_OnUnableToFollowBaseMove(UCharacterMovementComponent* Self, INT_PTR DeltaPosition, INT_PTR OldLocation, INT_PTR MoveOnBaseHit)
	{
		auto _p0 = *(FVector*)DeltaPosition;
		auto _p1 = *(FVector*)OldLocation;
		auto _p2 = *(FHitResult*)MoveOnBaseHit;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->OnUnableToFollowBaseMove_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PackNetworkMovementMode(UCharacterMovementComponent* Self)
	{
		return Self->PackNetworkMovementMode();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PerformAirControlForPathFollowing(UCharacterMovementComponent* Self, INT_PTR Direction, float ZDiff)
	{
		auto _p0 = *(FVector*)Direction;
		auto _p1 = ZDiff;
		Self->PerformAirControlForPathFollowing(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PerformMovement(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PerformMovement_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysCustom(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PhysCustom_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysFalling(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		Self->PhysFalling(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysFlying(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PhysFlying_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysicsRotation(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->PhysicsRotation(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysNavWalking(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PhysNavWalking_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysSwimming(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PhysSwimming_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_PhysWalking(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->PhysWalking_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ProcessLanded(UCharacterMovementComponent* Self, INT_PTR Hit, float remainingTime, int32 Iterations)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = remainingTime;
		auto _p2 = Iterations;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ProcessLanded_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ProjectLocationFromNavMesh(UCharacterMovementComponent* Self, float DeltaSeconds, INT_PTR CurrentFeetLocation, INT_PTR TargetNavLocation, float UpOffset, float DownOffset)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = *(FVector*)CurrentFeetLocation;
		auto _p2 = *(FVector*)TargetNavLocation;
		auto _p3 = UpOffset;
		auto _p4 = DownOffset;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ProjectLocationFromNavMesh_WRAP(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_RemoveRootMotionSource(UCharacterMovementComponent* Self, char* InstanceName)
	{
		auto _p0 = ConvertFromManage_FName(InstanceName);
		Self->RemoveRootMotionSource(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ReplicateMoveToServer(UCharacterMovementComponent* Self, float DeltaTime, INT_PTR NewAcceleration)
	{
		auto _p0 = DeltaTime;
		auto _p1 = *(FVector*)NewAcceleration;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ReplicateMoveToServer_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_RevertMove(UCharacterMovementComponent* Self, INT_PTR OldLocation, UPrimitiveComponent* OldBase, INT_PTR InOldBaseLocation, INT_PTR OldFloor, bool bFailMove)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = OldBase;
		auto _p2 = *(FVector*)InOldBaseLocation;
		auto _p3 = *(FFindFloorResult*)OldFloor;
		auto _p4 = bFailMove;
		Self->RevertMove(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_RoundAcceleration(UCharacterMovementComponent* Self, INT_PTR InAccel)
	{
		auto _p0 = *(FVector*)InAccel;
		return (INT_PTR) new FVector(Self->RoundAcceleration(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SaveBaseLocation(UCharacterMovementComponent* Self)
	{
		Self->SaveBaseLocation();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ScaleInputAcceleration(UCharacterMovementComponent* Self, INT_PTR InputAcceleration)
	{
		auto _p0 = *(FVector*)InputAcceleration;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ScaleInputAcceleration_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ServerCheckClientError(UCharacterMovementComponent* Self, float ClientTimeStamp, float DeltaTime, INT_PTR Accel, INT_PTR ClientWorldLocation, INT_PTR RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, char* ClientBaseBoneName, uint8 ClientMovementMode)
	{
		auto _p0 = ClientTimeStamp;
		auto _p1 = DeltaTime;
		auto _p2 = *(FVector*)Accel;
		auto _p3 = *(FVector*)ClientWorldLocation;
		auto _p4 = *(FVector*)RelativeClientLocation;
		auto _p5 = ClientMovementBase;
		auto _p6 = ConvertFromManage_FName(ClientBaseBoneName);
		auto _p7 = ClientMovementMode;
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ServerCheckClientError_WRAP(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ServerMoveHandleClientError(UCharacterMovementComponent* Self, float ClientTimeStamp, float DeltaTime, INT_PTR Accel, INT_PTR RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, char* ClientBaseBoneName, uint8 ClientMovementMode)
	{
		auto _p0 = ClientTimeStamp;
		auto _p1 = DeltaTime;
		auto _p2 = *(FVector*)Accel;
		auto _p3 = *(FVector*)RelativeClientLocation;
		auto _p4 = ClientMovementBase;
		auto _p5 = ConvertFromManage_FName(ClientBaseBoneName);
		auto _p6 = ClientMovementMode;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ServerMoveHandleClientError_WRAP(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetAvoidanceEnabled(UCharacterMovementComponent* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetAvoidanceEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetAvoidanceGroup(UCharacterMovementComponent* Self, int32 GroupFlags)
	{
		auto _p0 = GroupFlags;
		Self->SetAvoidanceGroup(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetBase(UCharacterMovementComponent* Self, UPrimitiveComponent* NewBase, char* BoneName, bool bNotifyActor)
	{
		auto _p0 = NewBase;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bNotifyActor;
		Self->SetBase(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetBaseFromFloor(UCharacterMovementComponent* Self, INT_PTR FloorResult)
	{
		auto _p0 = *(FFindFloorResult*)FloorResult;
		Self->SetBaseFromFloor(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetDefaultMovementMode(UCharacterMovementComponent* Self)
	{
		Self->SetDefaultMovementMode();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetGroundMovementMode(UCharacterMovementComponent* Self, EMovementMode NewGroundMovementMode)
	{
		auto _p0 = NewGroundMovementMode;
		Self->SetGroundMovementMode(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetGroupsToAvoid(UCharacterMovementComponent* Self, int32 GroupFlags)
	{
		auto _p0 = GroupFlags;
		Self->SetGroupsToAvoid(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetGroupsToIgnore(UCharacterMovementComponent* Self, int32 GroupFlags)
	{
		auto _p0 = GroupFlags;
		Self->SetGroupsToIgnore(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetMovementMode(UCharacterMovementComponent* Self, EMovementMode NewMovementMode, uint8 NewCustomMode)
	{
		auto _p0 = NewMovementMode;
		auto _p1 = NewCustomMode;
		Self->SetMovementMode(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetNavWalkingPhysics(UCharacterMovementComponent* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SetNavWalkingPhysics_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetPostLandedPhysics(UCharacterMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SetPostLandedPhysics_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetWalkableFloorAngle(UCharacterMovementComponent* Self, float InWalkableFloorAngle)
	{
		auto _p0 = InWalkableFloorAngle;
		Self->SetWalkableFloorAngle(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SetWalkableFloorZ(UCharacterMovementComponent* Self, float InWalkableFloorZ)
	{
		auto _p0 = InWalkableFloorZ;
		Self->SetWalkableFloorZ(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldCancelAdaptiveReplication(UCharacterMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->ShouldCancelAdaptiveReplication_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldCatchAir(UCharacterMovementComponent* Self, INT_PTR OldFloor, INT_PTR NewFloor)
	{
		auto _p0 = *(FFindFloorResult*)OldFloor;
		auto _p1 = *(FFindFloorResult*)NewFloor;
		return Self->ShouldCatchAir(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(UCharacterMovementComponent* Self, float DeltaTime, INT_PTR Delta, INT_PTR Hit)
	{
		auto _p0 = DeltaTime;
		auto _p1 = *(FVector*)Delta;
		auto _p2 = *(FHitResult*)Hit;
		return Self->ShouldCheckForValidLandingSpot(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldComputePerchResult(UCharacterMovementComponent* Self, INT_PTR InHit, bool bCheckRadius)
	{
		auto _p0 = *(FHitResult*)InHit;
		auto _p1 = bCheckRadius;
		return Self->ShouldComputePerchResult(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldJumpOutOfWater(UCharacterMovementComponent* Self, INT_PTR JumpDir)
	{
		auto _p0 = *(FVector*)JumpDir;
		return Self->ShouldJumpOutOfWater(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_ShouldRemainVertical(UCharacterMovementComponent* Self)
	{
		return Self->ShouldRemainVertical();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SimulatedTick(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SimulatedTick_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SimulateMovement(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SimulateMovement_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SmoothClientPosition(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SmoothClientPosition_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SmoothClientPosition_Interpolate_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(UCharacterMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->SmoothClientPosition_UpdateVisuals_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_StartFalling(UCharacterMovementComponent* Self, int32 Iterations, float remainingTime, float timeTick, INT_PTR Delta, INT_PTR subLoc)
	{
		auto _p0 = Iterations;
		auto _p1 = remainingTime;
		auto _p2 = timeTick;
		auto _p3 = *(FVector*)Delta;
		auto _p4 = *(FVector*)subLoc;
		Self->StartFalling(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_StartNewPhysics(UCharacterMovementComponent* Self, float deltaTime, int32 Iterations)
	{
		auto _p0 = deltaTime;
		auto _p1 = Iterations;
		Self->StartNewPhysics(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_StartSwimming(UCharacterMovementComponent* Self, INT_PTR OldLocation, INT_PTR OldVelocity, float timeTick, float remainingTime, int32 Iterations)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FVector*)OldVelocity;
		auto _p2 = timeTick;
		auto _p3 = remainingTime;
		auto _p4 = Iterations;
		Self->StartSwimming(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_Swim(UCharacterMovementComponent* Self, INT_PTR Delta, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		return Self->Swim(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_TickCharacterPose(UCharacterMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->TickCharacterPose_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_TryToLeaveNavWalking(UCharacterMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->TryToLeaveNavWalking_WRAP();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UnCrouch(UCharacterMovementComponent* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->UnCrouch(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateBasedMovement(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->UpdateBasedMovement(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateBasedRotation(UCharacterMovementComponent* Self, INT_PTR FinalRotation, INT_PTR ReducedRotation)
	{
		auto _p0 = *(FRotator*)FinalRotation;
		auto _p1 = *(FRotator*)ReducedRotation;
		Self->UpdateBasedRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->UpdateCharacterStateAfterMovement(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(UCharacterMovementComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->UpdateCharacterStateBeforeMovement(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateFloorFromAdjustment(UCharacterMovementComponent* Self)
	{
		Self->UpdateFloorFromAdjustment();
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_UpdateFromCompressedFlags(UCharacterMovementComponent* Self, uint8 Flags)
	{
		auto _p0 = Flags;
		((E_PROTECTED_WRAP_UCharacterMovementComponent*)Self)->UpdateFromCompressedFlags_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCharacterMovementComponent_VisualizeMovement(UCharacterMovementComponent* Self)
	{
		Self->VisualizeMovement();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
