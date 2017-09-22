#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/ShapeComponent.h"
#include "ManageShapeComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageShapeComponent : public UShapeComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void UpdateBodySetup() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
