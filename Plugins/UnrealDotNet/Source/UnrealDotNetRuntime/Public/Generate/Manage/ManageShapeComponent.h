#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/ShapeComponent.h"
#include "ManageShapeComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:24

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
