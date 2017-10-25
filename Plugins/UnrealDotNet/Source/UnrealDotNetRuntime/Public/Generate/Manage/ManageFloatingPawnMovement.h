#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/FloatingPawnMovement.h"
#include "ManageFloatingPawnMovement.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManageFloatingPawnMovement : public UFloatingPawnMovement
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void ApplyControlInputToVelocity(float DeltaTime) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
