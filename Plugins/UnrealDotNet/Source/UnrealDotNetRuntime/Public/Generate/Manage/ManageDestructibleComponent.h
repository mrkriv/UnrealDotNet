#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/DestructibleComponent.h"
#include "ManageDestructibleComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\DestructibleComponent.h:57

UCLASS()
class UNREALDOTNETRUNTIME_API UManageDestructibleComponent : public UDestructibleComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
