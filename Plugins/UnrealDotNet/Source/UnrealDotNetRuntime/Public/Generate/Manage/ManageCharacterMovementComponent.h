#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/CharacterMovementComponent.h"
#include "ManageCharacterMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:159

UCLASS()
class UNREALDOTNETRUNTIME_API UManageCharacterMovementComponent : public UCharacterMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddForce(FVector Force) override;
	virtual void AddImpulse(FVector Impulse, bool bVelocityChange) override;
	virtual void AdjustFloorHeight() override;
	virtual void AdjustProxyCapsuleSize() override;
	virtual void ApplyAccumulatedForces(float DeltaSeconds) override;
	virtual void ApplyDownwardForce(float DeltaSeconds) override;
	virtual void ApplyImpactPhysicsForces(const FHitResult& Impact, const FVector& ImpactAcceleration, const FVector& ImpactVelocity) override;
	virtual void ApplyNetworkMovementMode(const uint8 ReceivedMode) override;
	virtual void ApplyRepulsionForce(float DeltaSeconds) override;
	virtual void ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration) override;
	virtual void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration) override;
	virtual void CallMovementUpdateDelegate(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity) override;
	virtual void CapsuleTouched(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult) override;
	virtual void ClearAccumulatedForces() override;
	virtual void ClientAckGoodMove(float TimeStamp) override;
	virtual void ClientAckGoodMove_Implementation(float TimeStamp) override;
	virtual void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode) override;
	virtual void ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode) override;
	virtual void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode) override;
	virtual void ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode) override;
	virtual void Crouch(bool bClientSimulation) override;
	virtual void DisableMovement() override;
	virtual void ForceReplicationUpdate() override;
	virtual void HandleSwimmingWallHit(const FHitResult& Hit, float DeltaTime) override;
	virtual void HandleWalkingOffLedge(const FVector& PreviousFloorImpactNormal, const FVector& PreviousFloorContactNormal, const FVector& PreviousLocation, float TimeDelta) override;
	virtual void JumpOff(AActor* MovementBaseActor) override;
	virtual void JumpOutOfWater(FVector WallNormal) override;
	virtual void Launch(const FVector& LaunchVel) override;
	virtual void MaintainHorizontalGroundVelocity() override;
	virtual void MaybeSaveBaseLocation() override;
	virtual void MaybeUpdateBasedMovement(float DeltaSeconds) override;
	virtual void MoveAutonomous(float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, const FVector& NewAccel) override;
	virtual void NotifyJumpApex() override;
	virtual void OnCharacterStuckInGeometry(const FHitResult* Hit) override;
	virtual void OnClientTimeStampResetDetected() override;
	virtual void OnMovementModeChanged(EMovementMode PreviousMovementMode, uint8 PreviousCustomMode) override;
	virtual void OnMovementUpdated(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity) override;
	virtual void OnRootMotionSourceBeingApplied(const FRootMotionSource* Source) override;
	virtual void OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError) override;
	virtual void OnUnableToFollowBaseMove(const FVector& DeltaPosition, const FVector& OldLocation, const FHitResult& MoveOnBaseHit) override;
	virtual void PerformAirControlForPathFollowing(FVector Direction, float ZDiff) override;
	virtual void PerformMovement(float DeltaTime) override;
	virtual void PhysCustom(float deltaTime, int32 Iterations) override;
	virtual void PhysFalling(float deltaTime, int32 Iterations) override;
	virtual void PhysFlying(float deltaTime, int32 Iterations) override;
	virtual void PhysicsRotation(float DeltaTime) override;
	virtual void PhysNavWalking(float deltaTime, int32 Iterations) override;
	virtual void PhysSwimming(float deltaTime, int32 Iterations) override;
	virtual void PhysWalking(float deltaTime, int32 Iterations) override;
	virtual void ProcessLanded(const FHitResult& Hit, float remainingTime, int32 Iterations) override;
	virtual void ReplicateMoveToServer(float DeltaTime, const FVector& NewAcceleration) override;
	virtual void SaveBaseLocation() override;
	virtual void ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode) override;
	virtual void SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor) override;
	virtual void SetDefaultMovementMode() override;
	virtual void SetMovementMode(EMovementMode NewMovementMode, uint8 NewCustomMode) override;
	virtual void SetNavWalkingPhysics(bool bEnable) override;
	virtual void SetPostLandedPhysics(const FHitResult& Hit) override;
	virtual void SimulateMovement(float DeltaTime) override;
	virtual void SmoothClientPosition(float DeltaSeconds) override;
	virtual void StartFalling(int32 Iterations, float remainingTime, float timeTick, const FVector& Delta, const FVector& subLoc) override;
	virtual void StartNewPhysics(float deltaTime, int32 Iterations) override;
	virtual void UnCrouch(bool bClientSimulation) override;
	virtual void UpdateBasedMovement(float DeltaSeconds) override;
	virtual void UpdateBasedRotation(FRotator& FinalRotation, const FRotator& ReducedRotation) override;
	virtual void UpdateCharacterStateAfterMovement(float DeltaSeconds) override;
	virtual void UpdateCharacterStateBeforeMovement(float DeltaSeconds) override;
	virtual void UpdateFloorFromAdjustment() override;
	virtual void UpdateFromCompressedFlags(uint8 Flags) override;
	virtual void UpdateProxyAcceleration() override;
	virtual void AddInputVector(FVector WorldVector, bool bForce) override;
	virtual void NotifyBumpedPawn(APawn* BumpedPawn) override;
	virtual void RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed) override;
	virtual void RequestPathMove(const FVector& MoveInput) override;
	virtual void StopActiveMovement() override;
	virtual void AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff) override;
	virtual void AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) override;
	virtual void HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta) override;
	virtual void OnTeleported() override;
	virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) override;
	virtual void SetPlaneConstraintEnabled(bool bEnabled) override;
	virtual void SetPlaneConstraintFromVectors(FVector Forward, FVector Up) override;
	virtual void SetPlaneConstraintNormal(FVector PlaneNormal) override;
	virtual void SetPlaneConstraintOrigin(FVector PlaneOrigin) override;
	virtual void SetUpdatedComponent(USceneComponent* NewUpdatedComponent) override;
	virtual void SnapUpdatedComponentToPlane() override;
	virtual void StopMovementImmediately() override;
	virtual void UpdateComponentVelocity() override;
	virtual void UpdateTickRegistration() override;
	virtual void Activate(bool bReset) override;
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	virtual void BeginPlay() override;
	virtual void CreateRenderState_Concurrent() override;
	virtual void Deactivate() override;
	virtual void DestroyComponent(bool bPromoteChildren) override;
	virtual void DestroyRenderState_Concurrent() override;
	virtual void InitializeComponent() override;
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	virtual void OnActorEnableCollisionChanged() override;
	virtual void OnComponentCreated() override;
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	virtual void OnCreatePhysicsState() override;
	virtual void OnDestroyPhysicsState() override;
	virtual void OnRegister() override;
	virtual void OnRep_IsActive() override;
	virtual void OnUnregister() override;
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void SendRenderDynamicData_Concurrent() override;
	virtual void SendRenderTransform_Concurrent() override;
	virtual void SetActive(bool bNewActive, bool bReset) override;
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	virtual void ToggleActive() override;
	virtual void UninitializeComponent() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void OverridePerObjectConfigSection(FString& SectionName) override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
