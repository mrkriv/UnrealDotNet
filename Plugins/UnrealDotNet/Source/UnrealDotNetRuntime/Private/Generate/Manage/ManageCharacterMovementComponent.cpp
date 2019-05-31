// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacterMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:159

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

void UManageCharacterMovementComponent::AddForce(FVector Force)
{
	Super::AddForce(Force);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForce", Force);
}

void UManageCharacterMovementComponent::AddImpulse(FVector Impulse, bool bVelocityChange)
{
	Super::AddImpulse(Impulse, bVelocityChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulse", Impulse, bVelocityChange);
}

void UManageCharacterMovementComponent::AdjustFloorHeight()
{
	Super::AdjustFloorHeight();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AdjustFloorHeight");
}

void UManageCharacterMovementComponent::AdjustProxyCapsuleSize()
{
	Super::AdjustProxyCapsuleSize();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AdjustProxyCapsuleSize");
}

void UManageCharacterMovementComponent::ApplyAccumulatedForces(float DeltaSeconds)
{
	Super::ApplyAccumulatedForces(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyAccumulatedForces", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyDownwardForce(float DeltaSeconds)
{
	Super::ApplyDownwardForce(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyDownwardForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyImpactPhysicsForces(const FHitResult& Impact, const FVector& ImpactAcceleration, const FVector& ImpactVelocity)
{
	Super::ApplyImpactPhysicsForces(Impact, ImpactAcceleration, ImpactVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyImpactPhysicsForces", Impact, ImpactAcceleration, ImpactVelocity);
}

void UManageCharacterMovementComponent::ApplyNetworkMovementMode(const uint8 ReceivedMode)
{
	Super::ApplyNetworkMovementMode(ReceivedMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyNetworkMovementMode", ReceivedMode);
}

void UManageCharacterMovementComponent::ApplyRepulsionForce(float DeltaSeconds)
{
	Super::ApplyRepulsionForce(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyRepulsionForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
{
	Super::ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyVelocityBraking", DeltaTime, Friction, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
{
	Super::CalcVelocity(DeltaTime, Friction, bFluid, BrakingDeceleration);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CalcVelocity", DeltaTime, Friction, bFluid, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CallMovementUpdateDelegate(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::CallMovementUpdateDelegate(DeltaSeconds, OldLocation, OldVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CallMovementUpdateDelegate", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::CapsuleTouched(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult)
{
	Super::CapsuleTouched(OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CapsuleTouched", OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
}

void UManageCharacterMovementComponent::ClearAccumulatedForces()
{
	Super::ClearAccumulatedForces();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearAccumulatedForces");
}

void UManageCharacterMovementComponent::ClientAckGoodMove(float TimeStamp)
{
	Super::ClientAckGoodMove(TimeStamp);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAckGoodMove", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAckGoodMove_Implementation(float TimeStamp)
{
	Super::ClientAckGoodMove_Implementation(TimeStamp);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAckGoodMove_Implementation", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAdjustPosition", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition_Implementation(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientAdjustPosition_Implementation", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientVeryShortAdjustPosition", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition_Implementation(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientVeryShortAdjustPosition_Implementation", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Crouch", bClientSimulation);
}

void UManageCharacterMovementComponent::DisableMovement()
{
	Super::DisableMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableMovement");
}

void UManageCharacterMovementComponent::ForceReplicationUpdate()
{
	Super::ForceReplicationUpdate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceReplicationUpdate");
}

void UManageCharacterMovementComponent::HandleSwimmingWallHit(const FHitResult& Hit, float DeltaTime)
{
	Super::HandleSwimmingWallHit(Hit, DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleSwimmingWallHit", Hit, DeltaTime);
}

void UManageCharacterMovementComponent::HandleWalkingOffLedge(const FVector& PreviousFloorImpactNormal, const FVector& PreviousFloorContactNormal, const FVector& PreviousLocation, float TimeDelta)
{
	Super::HandleWalkingOffLedge(PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleWalkingOffLedge", PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
}

void UManageCharacterMovementComponent::JumpOff(AActor* MovementBaseActor)
{
	Super::JumpOff(MovementBaseActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "JumpOff", MovementBaseActor);
}

void UManageCharacterMovementComponent::JumpOutOfWater(FVector WallNormal)
{
	Super::JumpOutOfWater(WallNormal);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "JumpOutOfWater", WallNormal);
}

void UManageCharacterMovementComponent::Launch(const FVector& LaunchVel)
{
	Super::Launch(LaunchVel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Launch", LaunchVel);
}

void UManageCharacterMovementComponent::MaintainHorizontalGroundVelocity()
{
	Super::MaintainHorizontalGroundVelocity();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaintainHorizontalGroundVelocity");
}

void UManageCharacterMovementComponent::MaybeSaveBaseLocation()
{
	Super::MaybeSaveBaseLocation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaybeSaveBaseLocation");
}

void UManageCharacterMovementComponent::MaybeUpdateBasedMovement(float DeltaSeconds)
{
	Super::MaybeUpdateBasedMovement(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MaybeUpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::MoveAutonomous(float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, const FVector& NewAccel)
{
	Super::MoveAutonomous(ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveAutonomous", ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
}

void UManageCharacterMovementComponent::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyJumpApex");
}

void UManageCharacterMovementComponent::OnCharacterStuckInGeometry(const FHitResult* Hit)
{
	Super::OnCharacterStuckInGeometry(Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCharacterStuckInGeometry", Hit);
}

void UManageCharacterMovementComponent::OnClientTimeStampResetDetected()
{
	Super::OnClientTimeStampResetDetected();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClientTimeStampResetDetected");
}

void UManageCharacterMovementComponent::OnMovementModeChanged(EMovementMode PreviousMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PreviousMovementMode, PreviousCustomMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnMovementModeChanged", PreviousMovementMode, PreviousCustomMode);
}

void UManageCharacterMovementComponent::OnMovementUpdated(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::OnMovementUpdated(DeltaSeconds, OldLocation, OldVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnMovementUpdated", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::OnRootMotionSourceBeingApplied(const FRootMotionSource* Source)
{
	Super::OnRootMotionSourceBeingApplied(Source);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRootMotionSourceBeingApplied", Source);
}

void UManageCharacterMovementComponent::OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
{
	Super::OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTimeDiscrepancyDetected", CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
}

void UManageCharacterMovementComponent::OnUnableToFollowBaseMove(const FVector& DeltaPosition, const FVector& OldLocation, const FHitResult& MoveOnBaseHit)
{
	Super::OnUnableToFollowBaseMove(DeltaPosition, OldLocation, MoveOnBaseHit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnableToFollowBaseMove", DeltaPosition, OldLocation, MoveOnBaseHit);
}

void UManageCharacterMovementComponent::PerformAirControlForPathFollowing(FVector Direction, float ZDiff)
{
	Super::PerformAirControlForPathFollowing(Direction, ZDiff);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PerformAirControlForPathFollowing", Direction, ZDiff);
}

void UManageCharacterMovementComponent::PerformMovement(float DeltaTime)
{
	Super::PerformMovement(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PerformMovement", DeltaTime);
}

void UManageCharacterMovementComponent::PhysCustom(float deltaTime, int32 Iterations)
{
	Super::PhysCustom(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysCustom", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFalling(float deltaTime, int32 Iterations)
{
	Super::PhysFalling(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysFalling", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFlying(float deltaTime, int32 Iterations)
{
	Super::PhysFlying(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysFlying", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysicsRotation(float DeltaTime)
{
	Super::PhysicsRotation(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysicsRotation", DeltaTime);
}

void UManageCharacterMovementComponent::PhysNavWalking(float deltaTime, int32 Iterations)
{
	Super::PhysNavWalking(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysNavWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysSwimming(float deltaTime, int32 Iterations)
{
	Super::PhysSwimming(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysSwimming", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysWalking(float deltaTime, int32 Iterations)
{
	Super::PhysWalking(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PhysWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::ProcessLanded(const FHitResult& Hit, float remainingTime, int32 Iterations)
{
	Super::ProcessLanded(Hit, remainingTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ProcessLanded", Hit, remainingTime, Iterations);
}

void UManageCharacterMovementComponent::ReplicateMoveToServer(float DeltaTime, const FVector& NewAcceleration)
{
	Super::ReplicateMoveToServer(DeltaTime, NewAcceleration);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReplicateMoveToServer", DeltaTime, NewAcceleration);
}

void UManageCharacterMovementComponent::SaveBaseLocation()
{
	Super::SaveBaseLocation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SaveBaseLocation");
}

void UManageCharacterMovementComponent::ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode)
{
	Super::ServerMoveHandleClientError(ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ServerMoveHandleClientError", ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
}

void UManageCharacterMovementComponent::SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor)
{
	Super::SetBase(NewBase, BoneName, bNotifyActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetBase", NewBase, BoneName, bNotifyActor);
}

void UManageCharacterMovementComponent::SetDefaultMovementMode()
{
	Super::SetDefaultMovementMode();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetDefaultMovementMode");
}

void UManageCharacterMovementComponent::SetMovementMode(EMovementMode NewMovementMode, uint8 NewCustomMode)
{
	Super::SetMovementMode(NewMovementMode, NewCustomMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMovementMode", NewMovementMode, NewCustomMode);
}

void UManageCharacterMovementComponent::SetNavWalkingPhysics(bool bEnable)
{
	Super::SetNavWalkingPhysics(bEnable);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNavWalkingPhysics", bEnable);
}

void UManageCharacterMovementComponent::SetPostLandedPhysics(const FHitResult& Hit)
{
	Super::SetPostLandedPhysics(Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPostLandedPhysics", Hit);
}

void UManageCharacterMovementComponent::SimulateMovement(float DeltaTime)
{
	Super::SimulateMovement(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SimulateMovement", DeltaTime);
}

void UManageCharacterMovementComponent::SmoothClientPosition(float DeltaSeconds)
{
	Super::SmoothClientPosition(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SmoothClientPosition", DeltaSeconds);
}

void UManageCharacterMovementComponent::StartFalling(int32 Iterations, float remainingTime, float timeTick, const FVector& Delta, const FVector& subLoc)
{
	Super::StartFalling(Iterations, remainingTime, timeTick, Delta, subLoc);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartFalling", Iterations, remainingTime, timeTick, Delta, subLoc);
}

void UManageCharacterMovementComponent::StartNewPhysics(float deltaTime, int32 Iterations)
{
	Super::StartNewPhysics(deltaTime, Iterations);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartNewPhysics", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void UManageCharacterMovementComponent::UpdateBasedMovement(float DeltaSeconds)
{
	Super::UpdateBasedMovement(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateBasedRotation(FRotator& FinalRotation, const FRotator& ReducedRotation)
{
	Super::UpdateBasedRotation(FinalRotation, ReducedRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBasedRotation", FinalRotation, ReducedRotation);
}

void UManageCharacterMovementComponent::UpdateCharacterStateAfterMovement(float DeltaSeconds)
{
	Super::UpdateCharacterStateAfterMovement(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateCharacterStateAfterMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateCharacterStateBeforeMovement(float DeltaSeconds)
{
	Super::UpdateCharacterStateBeforeMovement(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateCharacterStateBeforeMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateFloorFromAdjustment()
{
	Super::UpdateFloorFromAdjustment();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateFloorFromAdjustment");
}

void UManageCharacterMovementComponent::UpdateFromCompressedFlags(uint8 Flags)
{
	Super::UpdateFromCompressedFlags(Flags);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateFromCompressedFlags", Flags);
}

void UManageCharacterMovementComponent::UpdateProxyAcceleration()
{
	Super::UpdateProxyAcceleration();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateProxyAcceleration");
}

void UManageCharacterMovementComponent::AddInputVector(FVector WorldVector, bool bForce)
{
	Super::AddInputVector(WorldVector, bForce);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddInputVector", WorldVector, bForce);
}

void UManageCharacterMovementComponent::NotifyBumpedPawn(APawn* BumpedPawn)
{
	Super::NotifyBumpedPawn(BumpedPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyBumpedPawn", BumpedPawn);
}

void UManageCharacterMovementComponent::RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed)
{
	Super::RequestDirectMove(MoveVelocity, bForceMaxSpeed);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RequestDirectMove", MoveVelocity, bForceMaxSpeed);
}

void UManageCharacterMovementComponent::RequestPathMove(const FVector& MoveInput)
{
	Super::RequestPathMove(MoveInput);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RequestPathMove", MoveInput);
}

void UManageCharacterMovementComponent::StopActiveMovement()
{
	Super::StopActiveMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopActiveMovement");
}

void UManageCharacterMovementComponent::AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff);
}

void UManageCharacterMovementComponent::AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageCharacterMovementComponent::HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
{
	Super::HandleImpact(Hit, TimeSlice, MoveDelta);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleImpact", Hit, TimeSlice, MoveDelta);
}

void UManageCharacterMovementComponent::OnTeleported()
{
	Super::OnTeleported();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTeleported");
}

void UManageCharacterMovementComponent::SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
{
	Super::SetPlaneConstraintAxisSetting(NewAxisSetting);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintAxisSetting", NewAxisSetting);
}

void UManageCharacterMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
}

void UManageCharacterMovementComponent::SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
{
	Super::SetPlaneConstraintFromVectors(Forward, Up);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintFromVectors", Forward, Up);
}

void UManageCharacterMovementComponent::SetPlaneConstraintNormal(FVector PlaneNormal)
{
	Super::SetPlaneConstraintNormal(PlaneNormal);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintNormal", PlaneNormal);
}

void UManageCharacterMovementComponent::SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	Super::SetPlaneConstraintOrigin(PlaneOrigin);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintOrigin", PlaneOrigin);
}

void UManageCharacterMovementComponent::SetUpdatedComponent(USceneComponent* NewUpdatedComponent)
{
	Super::SetUpdatedComponent(NewUpdatedComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUpdatedComponent", NewUpdatedComponent);
}

void UManageCharacterMovementComponent::SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SnapUpdatedComponentToPlane");
}

void UManageCharacterMovementComponent::StopMovementImmediately()
{
	Super::StopMovementImmediately();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovementImmediately");
}

void UManageCharacterMovementComponent::UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateComponentVelocity");
}

void UManageCharacterMovementComponent::UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateTickRegistration");
}

void UManageCharacterMovementComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
}

void UManageCharacterMovementComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCharacterMovementComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCharacterMovementComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageCharacterMovementComponent::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void UManageCharacterMovementComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageCharacterMovementComponent::Deactivate()
{
	Super::Deactivate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
}

void UManageCharacterMovementComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageCharacterMovementComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageCharacterMovementComponent::InitializeComponent()
{
	Super::InitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
}

void UManageCharacterMovementComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageCharacterMovementComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageCharacterMovementComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
}

void UManageCharacterMovementComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageCharacterMovementComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageCharacterMovementComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageCharacterMovementComponent::OnRegister()
{
	Super::OnRegister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
}

void UManageCharacterMovementComponent::OnRep_IsActive()
{
	Super::OnRep_IsActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
}

void UManageCharacterMovementComponent::OnUnregister()
{
	Super::OnUnregister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
}

void UManageCharacterMovementComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageCharacterMovementComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCharacterMovementComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCharacterMovementComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageCharacterMovementComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageCharacterMovementComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageCharacterMovementComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageCharacterMovementComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageCharacterMovementComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageCharacterMovementComponent::ToggleActive()
{
	Super::ToggleActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
}

void UManageCharacterMovementComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
}

void UManageCharacterMovementComponent::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void UManageCharacterMovementComponent::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void UManageCharacterMovementComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageCharacterMovementComponent::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void UManageCharacterMovementComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void UManageCharacterMovementComponent::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void UManageCharacterMovementComponent::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void UManageCharacterMovementComponent::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void UManageCharacterMovementComponent::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void UManageCharacterMovementComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageCharacterMovementComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void UManageCharacterMovementComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageCharacterMovementComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageCharacterMovementComponent::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void UManageCharacterMovementComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void UManageCharacterMovementComponent::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void UManageCharacterMovementComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
