#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponentCube.h"
#include "ManageSceneCaptureComponentCube.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSceneCaptureComponentCube : public USceneCaptureComponentCube
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
