#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageCharacter.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API AManageCharacter : public ACharacter
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation) override;
	
	virtual void CheckJumpInput(float DeltaTime) override;
	
	virtual void ClearJumpInput() override;
	
	virtual void ClientCheatFly_Implementation() override;
	
	virtual void ClientCheatGhost_Implementation() override;
	
	virtual void ClientCheatWalk_Implementation() override;
	
	virtual void Crouch(bool bClientSimulation) override;
	
	virtual void Falling() override;
	
	virtual void Jump() override;
	
	virtual void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride) override;
	
	virtual void NotifyJumpApex() override;
	
	virtual void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) override;
	
	virtual void OnJumped_Implementation() override;
	
	virtual void OnRep_IsCrouched() override;
	
	virtual void OnRep_ReplicatedBasedMovement() override;
	
	virtual void OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) override;
	
	virtual void OnUpdateSimulatedPosition(const FVector& OldLocation, const FQuat& OldRotation) override;
	
	virtual void RootMotionDebugClientPrintOnScreen_Implementation(const FString& InString) override;
	
	virtual void SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor) override;
	
	virtual void StopJumping() override;
	
	virtual void UnCrouch(bool bClientSimulation) override;
	
	virtual void UpdateFromCompressedFlags(uint8 Flags) override;
	
	virtual void UpdateSimulatedPosition(const FVector& Location, const FRotator& NewRotation) override;
	
protected:
	
	virtual void BaseChange() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
