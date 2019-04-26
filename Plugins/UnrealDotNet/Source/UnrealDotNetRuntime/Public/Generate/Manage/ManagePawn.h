#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "ManagePawn.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

UCLASS()
class UNREALDOTNETRUNTIME_API AManagePawn : public APawn, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
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
	virtual void PossessedBy(AController* NewController) override;
	virtual void RecalculateBaseEyeHeight() override;
	virtual void Restart() override;
	virtual void SetPlayerDefaults() override;
	virtual void SpawnDefaultController() override;
	virtual void TurnOff() override;
	virtual void UnPossessed() override;
	virtual void UpdateNavigationRelevance() override;
	
protected:
	virtual void DestroyPlayerInputComponent() override;
	virtual void SetupPlayerInputComponent(UInputComponent* PlayerInputComponent) override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
