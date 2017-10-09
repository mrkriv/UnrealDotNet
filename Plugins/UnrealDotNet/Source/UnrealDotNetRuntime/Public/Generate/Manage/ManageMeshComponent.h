#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/MeshComponent.h"
#include "ManageMeshComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\MeshComponent.h:20

UCLASS()
class UNREALDOTNETRUNTIME_API UManageMeshComponent : public UMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
