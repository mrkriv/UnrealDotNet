#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/PointLightComponent.h"
#include "ManagePointLightComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PointLightComponent.h:18

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePointLightComponent : public UPointLightComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
