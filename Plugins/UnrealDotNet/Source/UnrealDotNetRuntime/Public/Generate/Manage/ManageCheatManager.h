#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/CheatManager.h"
#include "ManageCheatManager.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

UCLASS()
class UNREALDOTNETRUNTIME_API UManageCheatManager : public UCheatManager
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void DisableDebugCamera() override;
	
	virtual void EnableDebugCamera() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
