#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/GameStateBase.h"
#include "ManageGameStateBase.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameStateBase : public AGameStateBase
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void OnRep_GameModeClass() override;
	
	virtual void OnRep_ReplicatedHasBegunPlay() override;
	
	virtual void OnRep_ReplicatedWorldTimeSeconds() override;
	
	virtual void OnRep_SpectatorClass() override;
	
	virtual void UpdateServerTimeSeconds() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
