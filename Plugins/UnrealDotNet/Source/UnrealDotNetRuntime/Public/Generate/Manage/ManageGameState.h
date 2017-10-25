#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/GameState.h"
#include "ManageGameState.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameState : public AGameState
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void DefaultTimer() override;
	
	virtual void OnRep_ElapsedTime() override;
	
	virtual void OnRep_MatchState() override;
	
protected:
	
	virtual void HandleLeavingMap() override;
	
	virtual void HandleMatchHasEnded() override;
	
	virtual void HandleMatchHasStarted() override;
	
	virtual void HandleMatchIsWaitingToStart() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
