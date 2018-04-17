#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacterMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:156

FString UManageCharacterMovementComponent::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void UManageCharacterMovementComponent::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void UManageCharacterMovementComponent::AddForce(FVector Force)
{
	Super::AddForce(Force);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForce", Force);
}

void UManageCharacterMovementComponent::AddImpulse(FVector Impulse, bool bVelocityChange)
{
	Super::AddImpulse(Impulse, bVelocityChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulse", Impulse, bVelocityChange);
}

void UManageCharacterMovementComponent::AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff);
}

void UManageCharacterMovementComponent::AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageCharacterMovementComponent::AdjustFloorHeight()
{
	Super::AdjustFloorHeight();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AdjustFloorHeight");
}

void UManageCharacterMovementComponent::AdjustProxyCapsuleSize()
{
	Super::AdjustProxyCapsuleSize();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AdjustProxyCapsuleSize");
}

void UManageCharacterMovementComponent::ApplyAccumulatedForces(float DeltaSeconds)
{
	Super::ApplyAccumulatedForces(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyAccumulatedForces", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyDownwardForce(float DeltaSeconds)
{
	Super::ApplyDownwardForce(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyDownwardForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyImpactPhysicsForces(const FHitResult& Impact, const FVector& ImpactAcceleration, const FVector& ImpactVelocity)
{
	Super::ApplyImpactPhysicsForces(Impact, ImpactAcceleration, ImpactVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyImpactPhysicsForces", Impact, ImpactAcceleration, ImpactVelocity);
}

void UManageCharacterMovementComponent::ApplyNetworkMovementMode(const uint8 ReceivedMode)
{
	Super::ApplyNetworkMovementMode(ReceivedMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyNetworkMovementMode", ReceivedMode);
}

void UManageCharacterMovementComponent::ApplyRepulsionForce(float DeltaSeconds)
{
	Super::ApplyRepulsionForce(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyRepulsionForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
{
	Super::ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyVelocityBraking", DeltaTime, Friction, BrakingDeceleration);
}

void UManageCharacterMovementComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageCharacterMovementComponent::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void UManageCharacterMovementComponent::CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
{
	Super::CalcVelocity(DeltaTime, Friction, bFluid, BrakingDeceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CalcVelocity", DeltaTime, Friction, bFluid, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CallMovementUpdateDelegate(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::CallMovementUpdateDelegate(DeltaSeconds, OldLocation, OldVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CallMovementUpdateDelegate", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::CapsuleTouched(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult)
{
	Super::CapsuleTouched(OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CapsuleTouched", OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
}

void UManageCharacterMovementComponent::ClearAccumulatedForces()
{
	Super::ClearAccumulatedForces();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearAccumulatedForces");
}

void UManageCharacterMovementComponent::ClientAckGoodMove(float TimeStamp)
{
	Super::ClientAckGoodMove(TimeStamp);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAckGoodMove", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAckGoodMove_Implementation(float TimeStamp)
{
	Super::ClientAckGoodMove_Implementation(TimeStamp);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAckGoodMove_Implementation", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAdjustPosition", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition_Implementation(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAdjustPosition_Implementation", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientVeryShortAdjustPosition", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition_Implementation(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientVeryShortAdjustPosition_Implementation", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Crouch", bClientSimulation);
}

void UManageCharacterMovementComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManageCharacterMovementComponent::DisableMovement()
{
	Super::DisableMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DisableMovement");
}

void UManageCharacterMovementComponent::ForcePositionUpdate(float DeltaTime)
{
	Super::ForcePositionUpdate(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForcePositionUpdate", DeltaTime);
}

void UManageCharacterMovementComponent::ForceReplicationUpdate()
{
	Super::ForceReplicationUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceReplicationUpdate");
}

void UManageCharacterMovementComponent::HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
{
	Super::HandleImpact(Hit, TimeSlice, MoveDelta);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleImpact", Hit, TimeSlice, MoveDelta);
}

void UManageCharacterMovementComponent::HandleSwimmingWallHit(const FHitResult& Hit, float DeltaTime)
{
	Super::HandleSwimmingWallHit(Hit, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleSwimmingWallHit", Hit, DeltaTime);
}

void UManageCharacterMovementComponent::JumpOff(AActor* MovementBaseActor)
{
	Super::JumpOff(MovementBaseActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "JumpOff", MovementBaseActor);
}

void UManageCharacterMovementComponent::JumpOutOfWater(FVector WallNormal)
{
	Super::JumpOutOfWater(WallNormal);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "JumpOutOfWater", WallNormal);
}

void UManageCharacterMovementComponent::Launch(const FVector& LaunchVel)
{
	Super::Launch(LaunchVel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Launch", LaunchVel);
}

void UManageCharacterMovementComponent::MaintainHorizontalGroundVelocity()
{
	Super::MaintainHorizontalGroundVelocity();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaintainHorizontalGroundVelocity");
}

void UManageCharacterMovementComponent::MaybeSaveBaseLocation()
{
	Super::MaybeSaveBaseLocation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaybeSaveBaseLocation");
}

void UManageCharacterMovementComponent::MaybeUpdateBasedMovement(float DeltaSeconds)
{
	Super::MaybeUpdateBasedMovement(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaybeUpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::MoveAutonomous(float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, const FVector& NewAccel)
{
	Super::MoveAutonomous(ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MoveAutonomous", ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
}

void UManageCharacterMovementComponent::NotifyBumpedPawn(APawn* BumpedPawn)
{
	Super::NotifyBumpedPawn(BumpedPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyBumpedPawn", BumpedPawn);
}

void UManageCharacterMovementComponent::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyJumpApex");
}

void UManageCharacterMovementComponent::OnCharacterStuckInGeometry(const FHitResult* Hit)
{
	Super::OnCharacterStuckInGeometry(Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCharacterStuckInGeometry", Hit);
}

void UManageCharacterMovementComponent::OnClientTimeStampResetDetected()
{
	Super::OnClientTimeStampResetDetected();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClientTimeStampResetDetected");
}

void UManageCharacterMovementComponent::OnMovementModeChanged(EMovementMode PreviousMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PreviousMovementMode, PreviousCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementModeChanged", PreviousMovementMode, PreviousCustomMode);
}

void UManageCharacterMovementComponent::OnMovementUpdated(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::OnMovementUpdated(DeltaSeconds, OldLocation, OldVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementUpdated", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManageCharacterMovementComponent::OnTeleported()
{
	Super::OnTeleported();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnTeleported");
}

void UManageCharacterMovementComponent::OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
{
	Super::OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnTimeDiscrepancyDetected", CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
}

void UManageCharacterMovementComponent::OnUnableToFollowBaseMove(const FVector& DeltaPosition, const FVector& OldLocation, const FHitResult& MoveOnBaseHit)
{
	Super::OnUnableToFollowBaseMove(DeltaPosition, OldLocation, MoveOnBaseHit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnableToFollowBaseMove", DeltaPosition, OldLocation, MoveOnBaseHit);
}

void UManageCharacterMovementComponent::PerformAirControlForPathFollowing(FVector Direction, float ZDiff)
{
	Super::PerformAirControlForPathFollowing(Direction, ZDiff);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PerformAirControlForPathFollowing", Direction, ZDiff);
}

void UManageCharacterMovementComponent::PerformMovement(float DeltaTime)
{
	Super::PerformMovement(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PerformMovement", DeltaTime);
}

void UManageCharacterMovementComponent::PhysCustom(float deltaTime, int32 Iterations)
{
	Super::PhysCustom(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysCustom", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFalling(float deltaTime, int32 Iterations)
{
	Super::PhysFalling(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysFalling", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFlying(float deltaTime, int32 Iterations)
{
	Super::PhysFlying(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysFlying", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysicsRotation(float DeltaTime)
{
	Super::PhysicsRotation(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysicsRotation", DeltaTime);
}

void UManageCharacterMovementComponent::PhysNavWalking(float deltaTime, int32 Iterations)
{
	Super::PhysNavWalking(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysNavWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysSwimming(float deltaTime, int32 Iterations)
{
	Super::PhysSwimming(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysSwimming", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysWalking(float deltaTime, int32 Iterations)
{
	Super::PhysWalking(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void UManageCharacterMovementComponent::ProcessLanded(const FHitResult& Hit, float remainingTime, int32 Iterations)
{
	Super::ProcessLanded(Hit, remainingTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ProcessLanded", Hit, remainingTime, Iterations);
}

void UManageCharacterMovementComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageCharacterMovementComponent::ReplicateMoveToServer(float DeltaTime, const FVector& NewAcceleration)
{
	Super::ReplicateMoveToServer(DeltaTime, NewAcceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReplicateMoveToServer", DeltaTime, NewAcceleration);
}

void UManageCharacterMovementComponent::RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed)
{
	Super::RequestDirectMove(MoveVelocity, bForceMaxSpeed);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestDirectMove", MoveVelocity, bForceMaxSpeed);
}

void UManageCharacterMovementComponent::RequestPathMove(const FVector& MoveInput)
{
	Super::RequestPathMove(MoveInput);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestPathMove", MoveInput);
}

void UManageCharacterMovementComponent::ResetPredictionData_Client()
{
	Super::ResetPredictionData_Client();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetPredictionData_Client");
}

void UManageCharacterMovementComponent::ResetPredictionData_Server()
{
	Super::ResetPredictionData_Server();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetPredictionData_Server");
}

void UManageCharacterMovementComponent::SaveBaseLocation()
{
	Super::SaveBaseLocation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SaveBaseLocation");
}

void UManageCharacterMovementComponent::SendClientAdjustment()
{
	Super::SendClientAdjustment();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendClientAdjustment");
}

void UManageCharacterMovementComponent::ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode)
{
	Super::ServerMoveHandleClientError(ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ServerMoveHandleClientError", ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
}

void UManageCharacterMovementComponent::SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor)
{
	Super::SetBase(NewBase, BoneName, bNotifyActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetBase", NewBase, BoneName, bNotifyActor);
}

void UManageCharacterMovementComponent::SetDefaultMovementMode()
{
	Super::SetDefaultMovementMode();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetDefaultMovementMode");
}

void UManageCharacterMovementComponent::SetMovementMode(EMovementMode NewMovementMode, uint8 NewCustomMode)
{
	Super::SetMovementMode(NewMovementMode, NewCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMovementMode", NewMovementMode, NewCustomMode);
}

void UManageCharacterMovementComponent::SetNavWalkingPhysics(bool bEnable)
{
	Super::SetNavWalkingPhysics(bEnable);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetNavWalkingPhysics", bEnable);
}

void UManageCharacterMovementComponent::SetPostLandedPhysics(const FHitResult& Hit)
{
	Super::SetPostLandedPhysics(Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPostLandedPhysics", Hit);
}

void UManageCharacterMovementComponent::SetUpdatedComponent(USceneComponent* NewUpdatedComponent)
{
	Super::SetUpdatedComponent(NewUpdatedComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetUpdatedComponent", NewUpdatedComponent);
}

void UManageCharacterMovementComponent::SimulateMovement(float DeltaTime)
{
	Super::SimulateMovement(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SimulateMovement", DeltaTime);
}

void UManageCharacterMovementComponent::SmoothClientPosition(float DeltaSeconds)
{
	Super::SmoothClientPosition(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SmoothClientPosition", DeltaSeconds);
}

void UManageCharacterMovementComponent::SmoothCorrection(const FVector& OldLocation, const FQuat& OldRotation, const FVector& NewLocation, const FQuat& NewRotation)
{
	Super::SmoothCorrection(OldLocation, OldRotation, NewLocation, NewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SmoothCorrection", OldLocation, OldRotation, NewLocation, NewRotation);
}

void UManageCharacterMovementComponent::StartFalling(int32 Iterations, float remainingTime, float timeTick, const FVector& Delta, const FVector& subLoc)
{
	Super::StartFalling(Iterations, remainingTime, timeTick, Delta, subLoc);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartFalling", Iterations, remainingTime, timeTick, Delta, subLoc);
}

void UManageCharacterMovementComponent::StartNewPhysics(float deltaTime, int32 Iterations)
{
	Super::StartNewPhysics(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartNewPhysics", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::StopActiveMovement()
{
	Super::StopActiveMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopActiveMovement");
}

void UManageCharacterMovementComponent::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void UManageCharacterMovementComponent::UpdateBasedMovement(float DeltaSeconds)
{
	Super::UpdateBasedMovement(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateBasedRotation(FRotator& FinalRotation, const FRotator& ReducedRotation)
{
	Super::UpdateBasedRotation(FinalRotation, ReducedRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateBasedRotation", FinalRotation, ReducedRotation);
}

void UManageCharacterMovementComponent::UpdateCharacterStateAfterMovement()
{
	Super::UpdateCharacterStateAfterMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateCharacterStateAfterMovement");
}

void UManageCharacterMovementComponent::UpdateCharacterStateBeforeMovement()
{
	Super::UpdateCharacterStateBeforeMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateCharacterStateBeforeMovement");
}

void UManageCharacterMovementComponent::UpdateFloorFromAdjustment()
{
	Super::UpdateFloorFromAdjustment();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateFloorFromAdjustment");
}

void UManageCharacterMovementComponent::UpdateFromCompressedFlags(uint8 Flags)
{
	Super::UpdateFromCompressedFlags(Flags);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateFromCompressedFlags", Flags);
}

void UManageCharacterMovementComponent::AddInputVector(FVector WorldVector, bool bForce)
{
	Super::AddInputVector(WorldVector, bForce);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddInputVector", WorldVector, bForce);
}

void UManageCharacterMovementComponent::StopMovementImmediately()
{
	Super::StopMovementImmediately();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopMovementImmediately");
}

void UManageCharacterMovementComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManageCharacterMovementComponent::SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
{
	Super::SetPlaneConstraintAxisSetting(NewAxisSetting);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintAxisSetting", NewAxisSetting);
}

void UManageCharacterMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
}

void UManageCharacterMovementComponent::SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
{
	Super::SetPlaneConstraintFromVectors(Forward, Up);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintFromVectors", Forward, Up);
}

void UManageCharacterMovementComponent::SetPlaneConstraintNormal(FVector PlaneNormal)
{
	Super::SetPlaneConstraintNormal(PlaneNormal);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintNormal", PlaneNormal);
}

void UManageCharacterMovementComponent::SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	Super::SetPlaneConstraintOrigin(PlaneOrigin);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintOrigin", PlaneOrigin);
}

void UManageCharacterMovementComponent::SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SnapUpdatedComponentToPlane");
}

void UManageCharacterMovementComponent::UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateComponentVelocity");
}

void UManageCharacterMovementComponent::UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateTickRegistration");
}

void UManageCharacterMovementComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManageCharacterMovementComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCharacterMovementComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCharacterMovementComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManageCharacterMovementComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageCharacterMovementComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageCharacterMovementComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageCharacterMovementComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageCharacterMovementComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageCharacterMovementComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageCharacterMovementComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManageCharacterMovementComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageCharacterMovementComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageCharacterMovementComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageCharacterMovementComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManageCharacterMovementComponent::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void UManageCharacterMovementComponent::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void UManageCharacterMovementComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageCharacterMovementComponent::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void UManageCharacterMovementComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCharacterMovementComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCharacterMovementComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageCharacterMovementComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageCharacterMovementComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageCharacterMovementComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageCharacterMovementComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageCharacterMovementComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageCharacterMovementComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManageCharacterMovementComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManageCharacterMovementComponent::UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::UpdateComponentToWorld(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateComponentToWorld", UpdateTransformFlags, Teleport);
}

void UManageCharacterMovementComponent::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void UManageCharacterMovementComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void UManageCharacterMovementComponent::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void UManageCharacterMovementComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void UManageCharacterMovementComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageCharacterMovementComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageCharacterMovementComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void UManageCharacterMovementComponent::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void UManageCharacterMovementComponent::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void UManageCharacterMovementComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
