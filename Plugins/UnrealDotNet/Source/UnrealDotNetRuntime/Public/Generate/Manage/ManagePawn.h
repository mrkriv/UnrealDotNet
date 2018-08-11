#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "ManagePawn.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

UCLASS()
class UNREALDOTNETRUNTIME_API AManagePawn : public APawn
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void AddControllerPitchInput(float Val) override;
	
	virtual void AddControllerRollInput(float Val) override;
	
	virtual void AddControllerYawInput(float Val) override;
	
	virtual void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce) override;
	
	virtual void DetachFromControllerPendingDestroy() override;
	
	virtual void FaceRotation(FRotator NewControlRotation, float DeltaTime) override;
	
	virtual void OnRep_Controller() override;
	
	virtual void OnRep_PlayerState() override;
	
	virtual void PawnClientRestart() override;
	
	virtual void PawnStartFire(uint8 FireModeNum) override;
	
	virtual void RecalculateBaseEyeHeight() override;
	
	virtual void Restart() override;
	
	virtual void SetPlayerDefaults() override;
	
	virtual void SpawnDefaultController() override;
	
	virtual void TurnOff() override;
	
	virtual void UnPossessed() override;
	
	virtual void UpdateNavigationRelevance() override;
	
protected:
	
	virtual void DestroyPlayerInputComponent() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
