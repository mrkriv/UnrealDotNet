#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/HierarchicalInstancedStaticMeshComponent.h"
#include "ManageHierarchicalInstancedStaticMeshComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\HierarchicalInstancedStaticMeshComponent.h:60

UCLASS()
class UNREALDOTNETRUNTIME_API UManageHierarchicalInstancedStaticMeshComponent : public UHierarchicalInstancedStaticMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
