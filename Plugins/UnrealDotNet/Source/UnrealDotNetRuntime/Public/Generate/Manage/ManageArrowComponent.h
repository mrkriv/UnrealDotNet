#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/ArrowComponent.h"
#include "ManageArrowComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ArrowComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManageArrowComponent : public UArrowComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
