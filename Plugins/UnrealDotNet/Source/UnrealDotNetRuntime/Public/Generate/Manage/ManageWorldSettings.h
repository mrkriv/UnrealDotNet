#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/WorldSettings.h"
#include "ManageWorldSettings.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:278

UCLASS()
class UNREALDOTNETRUNTIME_API AManageWorldSettings : public AWorldSettings
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void NotifyBeginPlay() override;
	
	virtual void NotifyMatchStarted() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
