#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Player.h"
#include "ManagePlayer.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Player.h:17

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePlayer : public UPlayer
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
