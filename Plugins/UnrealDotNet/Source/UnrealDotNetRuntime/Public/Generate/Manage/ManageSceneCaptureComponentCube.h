#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/SceneCaptureComponentCube.h"
#include "ManageSceneCaptureComponentCube.generated.h"

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
