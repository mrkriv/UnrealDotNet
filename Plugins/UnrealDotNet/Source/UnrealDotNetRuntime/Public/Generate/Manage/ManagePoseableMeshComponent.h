#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/PoseableMeshComponent.h"
#include "ManagePoseableMeshComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePoseableMeshComponent : public UPoseableMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
