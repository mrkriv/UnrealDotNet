// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacterMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:159

void UManageCharacterMovementComponent::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageCharacterMovementComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageCharacterMovementComponent::AdjustFloorHeight()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AdjustFloorHeight");
	else
		Super::AdjustFloorHeight();
}

void UManageCharacterMovementComponent::_Supper__AdjustFloorHeight()
{
	Super::AdjustFloorHeight();
}

void UManageCharacterMovementComponent::AdjustProxyCapsuleSize()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AdjustProxyCapsuleSize");
	else
		Super::AdjustProxyCapsuleSize();
}

void UManageCharacterMovementComponent::_Supper__AdjustProxyCapsuleSize()
{
	Super::AdjustProxyCapsuleSize();
}

void UManageCharacterMovementComponent::ApplyAccumulatedForces(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyAccumulatedForces", DeltaSeconds);
	else
		Super::ApplyAccumulatedForces(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__ApplyAccumulatedForces(float DeltaSeconds)
{
	Super::ApplyAccumulatedForces(DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyDownwardForce(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyDownwardForce", DeltaSeconds);
	else
		Super::ApplyDownwardForce(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__ApplyDownwardForce(float DeltaSeconds)
{
	Super::ApplyDownwardForce(DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyNetworkMovementMode(const uint8 ReceivedMode)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyNetworkMovementMode", ReceivedMode);
	else
		Super::ApplyNetworkMovementMode(ReceivedMode);
}

void UManageCharacterMovementComponent::_Supper__ApplyNetworkMovementMode(const uint8 ReceivedMode)
{
	Super::ApplyNetworkMovementMode(ReceivedMode);
}

void UManageCharacterMovementComponent::ApplyRepulsionForce(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyRepulsionForce", DeltaSeconds);
	else
		Super::ApplyRepulsionForce(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__ApplyRepulsionForce(float DeltaSeconds)
{
	Super::ApplyRepulsionForce(DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyVelocityBraking", DeltaTime, Friction, BrakingDeceleration);
	else
		Super::ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
}

void UManageCharacterMovementComponent::_Supper__ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
{
	Super::ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CalcVelocity", DeltaTime, Friction, bFluid, BrakingDeceleration);
	else
		Super::CalcVelocity(DeltaTime, Friction, bFluid, BrakingDeceleration);
}

void UManageCharacterMovementComponent::_Supper__CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
{
	Super::CalcVelocity(DeltaTime, Friction, bFluid, BrakingDeceleration);
}

void UManageCharacterMovementComponent::ClearAccumulatedForces()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearAccumulatedForces");
	else
		Super::ClearAccumulatedForces();
}

void UManageCharacterMovementComponent::_Supper__ClearAccumulatedForces()
{
	Super::ClearAccumulatedForces();
}

void UManageCharacterMovementComponent::ClientAckGoodMove(float TimeStamp)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAckGoodMove", TimeStamp);
	else
		Super::ClientAckGoodMove(TimeStamp);
}

void UManageCharacterMovementComponent::_Supper__ClientAckGoodMove(float TimeStamp)
{
	Super::ClientAckGoodMove(TimeStamp);
}

void UManageCharacterMovementComponent::ClientAckGoodMove_Implementation(float TimeStamp)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAckGoodMove_Implementation", TimeStamp);
	else
		Super::ClientAckGoodMove_Implementation(TimeStamp);
}

void UManageCharacterMovementComponent::_Supper__ClientAckGoodMove_Implementation(float TimeStamp)
{
	Super::ClientAckGoodMove_Implementation(TimeStamp);
}

void UManageCharacterMovementComponent::Crouch(bool bClientSimulation)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Crouch", bClientSimulation);
	else
		Super::Crouch(bClientSimulation);
}

void UManageCharacterMovementComponent::_Supper__Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
}

void UManageCharacterMovementComponent::DisableMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableMovement");
	else
		Super::DisableMovement();
}

void UManageCharacterMovementComponent::_Supper__DisableMovement()
{
	Super::DisableMovement();
}

void UManageCharacterMovementComponent::ForceReplicationUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceReplicationUpdate");
	else
		Super::ForceReplicationUpdate();
}

void UManageCharacterMovementComponent::_Supper__ForceReplicationUpdate()
{
	Super::ForceReplicationUpdate();
}

void UManageCharacterMovementComponent::MaintainHorizontalGroundVelocity()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaintainHorizontalGroundVelocity");
	else
		Super::MaintainHorizontalGroundVelocity();
}

void UManageCharacterMovementComponent::_Supper__MaintainHorizontalGroundVelocity()
{
	Super::MaintainHorizontalGroundVelocity();
}

void UManageCharacterMovementComponent::MaybeSaveBaseLocation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaybeSaveBaseLocation");
	else
		Super::MaybeSaveBaseLocation();
}

void UManageCharacterMovementComponent::_Supper__MaybeSaveBaseLocation()
{
	Super::MaybeSaveBaseLocation();
}

void UManageCharacterMovementComponent::MaybeUpdateBasedMovement(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaybeUpdateBasedMovement", DeltaSeconds);
	else
		Super::MaybeUpdateBasedMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__MaybeUpdateBasedMovement(float DeltaSeconds)
{
	Super::MaybeUpdateBasedMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::NotifyJumpApex()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyJumpApex");
	else
		Super::NotifyJumpApex();
}

void UManageCharacterMovementComponent::_Supper__NotifyJumpApex()
{
	Super::NotifyJumpApex();
}

void UManageCharacterMovementComponent::OnClientTimeStampResetDetected()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClientTimeStampResetDetected");
	else
		Super::OnClientTimeStampResetDetected();
}

void UManageCharacterMovementComponent::_Supper__OnClientTimeStampResetDetected()
{
	Super::OnClientTimeStampResetDetected();
}

void UManageCharacterMovementComponent::OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTimeDiscrepancyDetected", CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
	else
		Super::OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
}

void UManageCharacterMovementComponent::_Supper__OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
{
	Super::OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
}

void UManageCharacterMovementComponent::PerformMovement(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PerformMovement", DeltaTime);
	else
		Super::PerformMovement(DeltaTime);
}

void UManageCharacterMovementComponent::_Supper__PerformMovement(float DeltaTime)
{
	Super::PerformMovement(DeltaTime);
}

void UManageCharacterMovementComponent::PhysCustom(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysCustom", deltaTime, Iterations);
	else
		Super::PhysCustom(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysCustom(float deltaTime, int32 Iterations)
{
	Super::PhysCustom(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFalling(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysFalling", deltaTime, Iterations);
	else
		Super::PhysFalling(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysFalling(float deltaTime, int32 Iterations)
{
	Super::PhysFalling(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFlying(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysFlying", deltaTime, Iterations);
	else
		Super::PhysFlying(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysFlying(float deltaTime, int32 Iterations)
{
	Super::PhysFlying(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysicsRotation(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysicsRotation", DeltaTime);
	else
		Super::PhysicsRotation(DeltaTime);
}

void UManageCharacterMovementComponent::_Supper__PhysicsRotation(float DeltaTime)
{
	Super::PhysicsRotation(DeltaTime);
}

void UManageCharacterMovementComponent::PhysNavWalking(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysNavWalking", deltaTime, Iterations);
	else
		Super::PhysNavWalking(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysNavWalking(float deltaTime, int32 Iterations)
{
	Super::PhysNavWalking(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysSwimming(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysSwimming", deltaTime, Iterations);
	else
		Super::PhysSwimming(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysSwimming(float deltaTime, int32 Iterations)
{
	Super::PhysSwimming(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysWalking(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysWalking", deltaTime, Iterations);
	else
		Super::PhysWalking(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__PhysWalking(float deltaTime, int32 Iterations)
{
	Super::PhysWalking(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::SaveBaseLocation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SaveBaseLocation");
	else
		Super::SaveBaseLocation();
}

void UManageCharacterMovementComponent::_Supper__SaveBaseLocation()
{
	Super::SaveBaseLocation();
}

void UManageCharacterMovementComponent::SetDefaultMovementMode()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetDefaultMovementMode");
	else
		Super::SetDefaultMovementMode();
}

void UManageCharacterMovementComponent::_Supper__SetDefaultMovementMode()
{
	Super::SetDefaultMovementMode();
}

void UManageCharacterMovementComponent::SetNavWalkingPhysics(bool bEnable)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNavWalkingPhysics", bEnable);
	else
		Super::SetNavWalkingPhysics(bEnable);
}

void UManageCharacterMovementComponent::_Supper__SetNavWalkingPhysics(bool bEnable)
{
	Super::SetNavWalkingPhysics(bEnable);
}

void UManageCharacterMovementComponent::SimulateMovement(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SimulateMovement", DeltaTime);
	else
		Super::SimulateMovement(DeltaTime);
}

void UManageCharacterMovementComponent::_Supper__SimulateMovement(float DeltaTime)
{
	Super::SimulateMovement(DeltaTime);
}

void UManageCharacterMovementComponent::SmoothClientPosition(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SmoothClientPosition", DeltaSeconds);
	else
		Super::SmoothClientPosition(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__SmoothClientPosition(float DeltaSeconds)
{
	Super::SmoothClientPosition(DeltaSeconds);
}

void UManageCharacterMovementComponent::StartNewPhysics(float deltaTime, int32 Iterations)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartNewPhysics", deltaTime, Iterations);
	else
		Super::StartNewPhysics(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::_Supper__StartNewPhysics(float deltaTime, int32 Iterations)
{
	Super::StartNewPhysics(deltaTime, Iterations);
}

void UManageCharacterMovementComponent::UnCrouch(bool bClientSimulation)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnCrouch", bClientSimulation);
	else
		Super::UnCrouch(bClientSimulation);
}

void UManageCharacterMovementComponent::_Supper__UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
}

void UManageCharacterMovementComponent::UpdateBasedMovement(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBasedMovement", DeltaSeconds);
	else
		Super::UpdateBasedMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__UpdateBasedMovement(float DeltaSeconds)
{
	Super::UpdateBasedMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateCharacterStateAfterMovement(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateCharacterStateAfterMovement", DeltaSeconds);
	else
		Super::UpdateCharacterStateAfterMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__UpdateCharacterStateAfterMovement(float DeltaSeconds)
{
	Super::UpdateCharacterStateAfterMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateCharacterStateBeforeMovement(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateCharacterStateBeforeMovement", DeltaSeconds);
	else
		Super::UpdateCharacterStateBeforeMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::_Supper__UpdateCharacterStateBeforeMovement(float DeltaSeconds)
{
	Super::UpdateCharacterStateBeforeMovement(DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateFloorFromAdjustment()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateFloorFromAdjustment");
	else
		Super::UpdateFloorFromAdjustment();
}

void UManageCharacterMovementComponent::_Supper__UpdateFloorFromAdjustment()
{
	Super::UpdateFloorFromAdjustment();
}

void UManageCharacterMovementComponent::UpdateFromCompressedFlags(uint8 Flags)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateFromCompressedFlags", Flags);
	else
		Super::UpdateFromCompressedFlags(Flags);
}

void UManageCharacterMovementComponent::_Supper__UpdateFromCompressedFlags(uint8 Flags)
{
	Super::UpdateFromCompressedFlags(Flags);
}

void UManageCharacterMovementComponent::UpdateProxyAcceleration()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateProxyAcceleration");
	else
		Super::UpdateProxyAcceleration();
}

void UManageCharacterMovementComponent::_Supper__UpdateProxyAcceleration()
{
	Super::UpdateProxyAcceleration();
}

void UManageCharacterMovementComponent::StopActiveMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopActiveMovement");
	else
		Super::StopActiveMovement();
}

void UManageCharacterMovementComponent::_Supper__StopActiveMovement()
{
	Super::StopActiveMovement();
}

void UManageCharacterMovementComponent::OnTeleported()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTeleported");
	else
		Super::OnTeleported();
}

void UManageCharacterMovementComponent::_Supper__OnTeleported()
{
	Super::OnTeleported();
}

void UManageCharacterMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
	else
		Super::SetPlaneConstraintEnabled(bEnabled);
}

void UManageCharacterMovementComponent::_Supper__SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
}

void UManageCharacterMovementComponent::SnapUpdatedComponentToPlane()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SnapUpdatedComponentToPlane");
	else
		Super::SnapUpdatedComponentToPlane();
}

void UManageCharacterMovementComponent::_Supper__SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
}

void UManageCharacterMovementComponent::StopMovementImmediately()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovementImmediately");
	else
		Super::StopMovementImmediately();
}

void UManageCharacterMovementComponent::_Supper__StopMovementImmediately()
{
	Super::StopMovementImmediately();
}

void UManageCharacterMovementComponent::UpdateComponentVelocity()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateComponentVelocity");
	else
		Super::UpdateComponentVelocity();
}

void UManageCharacterMovementComponent::_Supper__UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
}

void UManageCharacterMovementComponent::UpdateTickRegistration()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateTickRegistration");
	else
		Super::UpdateTickRegistration();
}

void UManageCharacterMovementComponent::_Supper__UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
}

void UManageCharacterMovementComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageCharacterMovementComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageCharacterMovementComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageCharacterMovementComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageCharacterMovementComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageCharacterMovementComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageCharacterMovementComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageCharacterMovementComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageCharacterMovementComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageCharacterMovementComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageCharacterMovementComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageCharacterMovementComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageCharacterMovementComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageCharacterMovementComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageCharacterMovementComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageCharacterMovementComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageCharacterMovementComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageCharacterMovementComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageCharacterMovementComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageCharacterMovementComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageCharacterMovementComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageCharacterMovementComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageCharacterMovementComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageCharacterMovementComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageCharacterMovementComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageCharacterMovementComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageCharacterMovementComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageCharacterMovementComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageCharacterMovementComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageCharacterMovementComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageCharacterMovementComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageCharacterMovementComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageCharacterMovementComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageCharacterMovementComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageCharacterMovementComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageCharacterMovementComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageCharacterMovementComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageCharacterMovementComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageCharacterMovementComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageCharacterMovementComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageCharacterMovementComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageCharacterMovementComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageCharacterMovementComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageCharacterMovementComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageCharacterMovementComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageCharacterMovementComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageCharacterMovementComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageCharacterMovementComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageCharacterMovementComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageCharacterMovementComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageCharacterMovementComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageCharacterMovementComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageCharacterMovementComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageCharacterMovementComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageCharacterMovementComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageCharacterMovementComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageCharacterMovementComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageCharacterMovementComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageCharacterMovementComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageCharacterMovementComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageCharacterMovementComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageCharacterMovementComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageCharacterMovementComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageCharacterMovementComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageCharacterMovementComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageCharacterMovementComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageCharacterMovementComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageCharacterMovementComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageCharacterMovementComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCharacterMovementComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCharacterMovementComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageCharacterMovementComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageCharacterMovementComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageCharacterMovementComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageCharacterMovementComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageCharacterMovementComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageCharacterMovementComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageCharacterMovementComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageCharacterMovementComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageCharacterMovementComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
