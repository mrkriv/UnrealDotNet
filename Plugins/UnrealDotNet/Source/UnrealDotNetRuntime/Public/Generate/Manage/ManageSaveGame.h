#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "GameFramework/SaveGame.h"
#include "ManageSaveGame.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\SaveGame.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSaveGame : public USaveGame
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
