#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/LightComponent.h"
#include "ManageLightComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\LightComponent.h:40

UCLASS()
class UNREALDOTNETRUNTIME_API UManageLightComponent : public ULightComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
