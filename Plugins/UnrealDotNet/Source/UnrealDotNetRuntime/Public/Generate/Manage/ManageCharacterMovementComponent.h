#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "TypeConvertor.h"
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
	
	virtual void AdjustFloorHeight() override;
	virtual void AdjustProxyCapsuleSize() override;
	virtual void ApplyAccumulatedForces(float DeltaSeconds) override;
	virtual void ApplyDownwardForce(float DeltaSeconds) override;
	virtual void ApplyNetworkMovementMode(const uint8 ReceivedMode) override;
	virtual void ApplyRepulsionForce(float DeltaSeconds) override;
	virtual void ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration) override;
	virtual void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration) override;
	virtual void ClearAccumulatedForces() override;
	virtual void ClientAckGoodMove(float TimeStamp) override;
	virtual void ClientAckGoodMove_Implementation(float TimeStamp) override;
	virtual void Crouch(bool bClientSimulation) override;
	virtual void DisableMovement() override;
	virtual void ForceReplicationUpdate() override;
	virtual void MaintainHorizontalGroundVelocity() override;
	virtual void MaybeSaveBaseLocation() override;
	virtual void MaybeUpdateBasedMovement(float DeltaSeconds) override;
	virtual void NotifyJumpApex() override;
	virtual void OnClientTimeStampResetDetected() override;
	virtual void OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError) override;
	virtual void PerformMovement(float DeltaTime) override;
	virtual void PhysCustom(float deltaTime, int32 Iterations) override;
	virtual void PhysFalling(float deltaTime, int32 Iterations) override;
	virtual void PhysFlying(float deltaTime, int32 Iterations) override;
	virtual void PhysicsRotation(float DeltaTime) override;
	virtual void PhysNavWalking(float deltaTime, int32 Iterations) override;
	virtual void PhysSwimming(float deltaTime, int32 Iterations) override;
	virtual void PhysWalking(float deltaTime, int32 Iterations) override;
	virtual void SaveBaseLocation() override;
	virtual void SetDefaultMovementMode() override;
	virtual void SetNavWalkingPhysics(bool bEnable) override;
	virtual void SimulateMovement(float DeltaTime) override;
	virtual void SmoothClientPosition(float DeltaSeconds) override;
	virtual void StartNewPhysics(float deltaTime, int32 Iterations) override;
	virtual void UnCrouch(bool bClientSimulation) override;
	virtual void UpdateBasedMovement(float DeltaSeconds) override;
	virtual void UpdateCharacterStateAfterMovement(float DeltaSeconds) override;
	virtual void UpdateCharacterStateBeforeMovement(float DeltaSeconds) override;
	virtual void UpdateFloorFromAdjustment() override;
	virtual void UpdateFromCompressedFlags(uint8 Flags) override;
	virtual void UpdateProxyAcceleration() override;
	virtual void StopActiveMovement() override;
	virtual void OnTeleported() override;
	virtual void SetPlaneConstraintEnabled(bool bEnabled) override;
	virtual void SnapUpdatedComponentToPlane() override;
	virtual void StopMovementImmediately() override;
	virtual void UpdateComponentVelocity() override;
	virtual void UpdateTickRegistration() override;
	virtual void Activate(bool bReset) override;
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
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__AdjustFloorHeight();
	void _Supper__AdjustProxyCapsuleSize();
	void _Supper__ApplyAccumulatedForces(float DeltaSeconds);
	void _Supper__ApplyDownwardForce(float DeltaSeconds);
	void _Supper__ApplyNetworkMovementMode(const uint8 ReceivedMode);
	void _Supper__ApplyRepulsionForce(float DeltaSeconds);
	void _Supper__ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration);
	void _Supper__CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration);
	void _Supper__ClearAccumulatedForces();
	void _Supper__ClientAckGoodMove(float TimeStamp);
	void _Supper__ClientAckGoodMove_Implementation(float TimeStamp);
	void _Supper__Crouch(bool bClientSimulation);
	void _Supper__DisableMovement();
	void _Supper__ForceReplicationUpdate();
	void _Supper__MaintainHorizontalGroundVelocity();
	void _Supper__MaybeSaveBaseLocation();
	void _Supper__MaybeUpdateBasedMovement(float DeltaSeconds);
	void _Supper__NotifyJumpApex();
	void _Supper__OnClientTimeStampResetDetected();
	void _Supper__OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError);
	void _Supper__PerformMovement(float DeltaTime);
	void _Supper__PhysCustom(float deltaTime, int32 Iterations);
	void _Supper__PhysFalling(float deltaTime, int32 Iterations);
	void _Supper__PhysFlying(float deltaTime, int32 Iterations);
	void _Supper__PhysicsRotation(float DeltaTime);
	void _Supper__PhysNavWalking(float deltaTime, int32 Iterations);
	void _Supper__PhysSwimming(float deltaTime, int32 Iterations);
	void _Supper__PhysWalking(float deltaTime, int32 Iterations);
	void _Supper__SaveBaseLocation();
	void _Supper__SetDefaultMovementMode();
	void _Supper__SetNavWalkingPhysics(bool bEnable);
	void _Supper__SimulateMovement(float DeltaTime);
	void _Supper__SmoothClientPosition(float DeltaSeconds);
	void _Supper__StartNewPhysics(float deltaTime, int32 Iterations);
	void _Supper__UnCrouch(bool bClientSimulation);
	void _Supper__UpdateBasedMovement(float DeltaSeconds);
	void _Supper__UpdateCharacterStateAfterMovement(float DeltaSeconds);
	void _Supper__UpdateCharacterStateBeforeMovement(float DeltaSeconds);
	void _Supper__UpdateFloorFromAdjustment();
	void _Supper__UpdateFromCompressedFlags(uint8 Flags);
	void _Supper__UpdateProxyAcceleration();
	void _Supper__StopActiveMovement();
	void _Supper__OnTeleported();
	void _Supper__SetPlaneConstraintEnabled(bool bEnabled);
	void _Supper__SnapUpdatedComponentToPlane();
	void _Supper__StopMovementImmediately();
	void _Supper__UpdateComponentVelocity();
	void _Supper__UpdateTickRegistration();
	void _Supper__Activate(bool bReset);
	void _Supper__BeginPlay();
	void _Supper__CreateRenderState_Concurrent();
	void _Supper__Deactivate();
	void _Supper__DestroyComponent(bool bPromoteChildren);
	void _Supper__DestroyRenderState_Concurrent();
	void _Supper__InitializeComponent();
	void _Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
	void _Supper__OnActorEnableCollisionChanged();
	void _Supper__OnComponentCreated();
	void _Supper__OnComponentDestroyed(bool bDestroyingHierarchy);
	void _Supper__OnCreatePhysicsState();
	void _Supper__OnDestroyPhysicsState();
	void _Supper__OnRegister();
	void _Supper__OnRep_IsActive();
	void _Supper__OnUnregister();
	void _Supper__RegisterComponentTickFunctions(bool bRegister);
	void _Supper__SendRenderDynamicData_Concurrent();
	void _Supper__SendRenderTransform_Concurrent();
	void _Supper__SetActive(bool bNewActive, bool bReset);
	void _Supper__SetAutoActivate(bool bNewAutoActivate);
	void _Supper__SetComponentTickEnabled(bool bEnabled);
	void _Supper__SetComponentTickEnabledAsync(bool bEnabled);
	void _Supper__ToggleActive();
	void _Supper__UninitializeComponent();
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
