#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/PawnMovementComponent.h"
#include "ManagePawnMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnMovementComponent : public UPawnMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	virtual void AddInputVector(FVector WorldVector, bool bForce) override;
	virtual void NotifyBumpedPawn(APawn* BumpedPawn) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
