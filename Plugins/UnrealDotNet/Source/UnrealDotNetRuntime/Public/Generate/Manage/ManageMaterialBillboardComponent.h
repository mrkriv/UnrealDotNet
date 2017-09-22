#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/MaterialBillboardComponent.h"
#include "ManageMaterialBillboardComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageMaterialBillboardComponent : public UMaterialBillboardComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
