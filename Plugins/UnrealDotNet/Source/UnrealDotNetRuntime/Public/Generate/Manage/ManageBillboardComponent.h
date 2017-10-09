#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/BillboardComponent.h"
#include "ManageBillboardComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\BillboardComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManageBillboardComponent : public UBillboardComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
