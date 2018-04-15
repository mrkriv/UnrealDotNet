#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/GameFramework/PawnMovementComponent.h"
#include "ManagePawnMovementComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnMovementComponent : public UPawnMovementComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void AddInputVector(FVector WorldVector, bool bForce) override;
	
	virtual void NotifyBumpedPawn(APawn* BumpedPawn) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
