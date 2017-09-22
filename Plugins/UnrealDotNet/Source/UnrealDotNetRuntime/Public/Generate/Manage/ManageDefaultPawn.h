#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "GameFramework/DefaultPawn.h"
#include "ManageDefaultPawn.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API AManageDefaultPawn : public ADefaultPawn
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
