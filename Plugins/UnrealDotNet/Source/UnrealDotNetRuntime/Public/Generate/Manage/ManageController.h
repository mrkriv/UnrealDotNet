#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/Controller.h"
#include "ManageController.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\Controller.h:41

UCLASS()
class UNREALDOTNETRUNTIME_API AManageController : public AController
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void ChangeState(FName NewState) override;
	
	virtual void CleanupPlayerState() override;
	
	virtual void CurrentLevelUnloaded() override;
	
	virtual void FailedToSpawnPawn() override;
	
	virtual void GameHasEnded(AActor* EndGameFocus, bool bIsWinner) override;
	
	virtual void InitPlayerState() override;
	
	virtual void OnRep_Pawn() override;
	
	virtual void OnRep_PlayerState() override;
	
	virtual void PawnPendingDestroy(APawn* inPawn) override;
	
	virtual void Possess(APawn* InPawn) override;
	
	virtual void ResetIgnoreInputFlags() override;
	
	virtual void ResetIgnoreLookInput() override;
	
	virtual void ResetIgnoreMoveInput() override;
	
	virtual void SetControlRotation(const FRotator& NewRotation) override;
	
	virtual void SetIgnoreLookInput(bool bNewLookInput) override;
	
	virtual void SetIgnoreMoveInput(bool bNewMoveInput) override;
	
	virtual void SetInitialLocationAndRotation(const FVector& NewLocation, const FRotator& NewRotation) override;
	
	virtual void SetPawn(APawn* InPawn) override;
	
	virtual void StopMovement() override;
	
	virtual void UnPossess() override;
	
	virtual void UpdateNavigationComponents() override;
	
protected:
	
	virtual void AddPawnTickDependency(APawn* NewPawn) override;
	
	virtual void AttachToPawn(APawn* InPawn) override;
	
	virtual void BeginInactiveState() override;
	
	virtual void DetachFromPawn() override;
	
	virtual void EndInactiveState() override;
	
	virtual void RemovePawnTickDependency(APawn* InOldPawn) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
