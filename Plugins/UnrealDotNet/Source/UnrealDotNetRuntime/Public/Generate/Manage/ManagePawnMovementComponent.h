#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/PawnMovementComponent.h"
#include "ManagePawnMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnMovementComponent : public UPawnMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddInputVector(FVector WorldVector, bool bForce) override;
	virtual void NotifyBumpedPawn(APawn* BumpedPawn) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
