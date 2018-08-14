#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/InterpToMovementComponent.h"
#include "ManageInterpToMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

UCLASS()
class UNREALDOTNETRUNTIME_API UManageInterpToMovementComponent : public UInterpToMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	
protected:
	virtual void UpdateControlPoints(bool InForceUpdate) override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
