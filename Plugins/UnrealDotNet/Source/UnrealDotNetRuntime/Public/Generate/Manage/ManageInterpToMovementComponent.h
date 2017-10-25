#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/Components/InterpToMovementComponent.h"
#include "ManageInterpToMovementComponent.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

UCLASS()
class UNREALDOTNETRUNTIME_API UManageInterpToMovementComponent : public UInterpToMovementComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void UpdateControlPoints(bool InForceUpdate) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
