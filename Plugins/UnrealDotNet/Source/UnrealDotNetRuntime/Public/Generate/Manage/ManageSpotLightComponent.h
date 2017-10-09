#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/SpotLightComponent.h"
#include "ManageSpotLightComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SpotLightComponent.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSpotLightComponent : public USpotLightComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
