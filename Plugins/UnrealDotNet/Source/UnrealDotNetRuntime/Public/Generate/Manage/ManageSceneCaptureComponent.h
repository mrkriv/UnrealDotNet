#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/SceneCaptureComponent.h"
#include "ManageSceneCaptureComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneCaptureComponent.h:59

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSceneCaptureComponent : public USceneCaptureComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
