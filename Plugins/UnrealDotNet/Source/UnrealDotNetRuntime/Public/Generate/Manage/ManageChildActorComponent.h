#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/Components/ChildActorComponent.h"
#include "ManageChildActorComponent.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:44

UCLASS()
class UNREALDOTNETRUNTIME_API UManageChildActorComponent : public UChildActorComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
