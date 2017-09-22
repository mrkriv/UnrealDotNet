#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/ExponentialHeightFogComponent.h"
#include "ManageExponentialHeightFogComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageExponentialHeightFogComponent : public UExponentialHeightFogComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
