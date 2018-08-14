#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/NavMovementComponent.h"
#include "ManageNavMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

UCLASS()
class UNREALDOTNETRUNTIME_API UManageNavMovementComponent : public UNavMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	virtual void RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed) override;
	virtual void RequestPathMove(const FVector& MoveInput) override;
	virtual void StopActiveMovement() override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
