#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/GameMode.h"
#include "ManageGameMode.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameMode : public AGameMode
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void AddInactivePlayer(APlayerState* PlayerState, APlayerController* PC) override;
	
	virtual void Broadcast(AActor* Sender, const FString& Msg, FName Type) override;
	
	virtual void MatineeCancelled() override;
	
	virtual void NotifyPendingConnectionLost() override;
	
	virtual void OverridePlayerState(APlayerController* PC, APlayerState* OldPlayerState) override;
	
	virtual void PostCommitMapChange() override;
	
	virtual void PreCommitMapChange(const FString& PreviousMapName, const FString& NextMapName) override;
	
	virtual void Say(const FString& Msg) override;
	
	virtual void SendPlayer(APlayerController* aPlayer, const FString& URL) override;
	
	virtual void SetBandwidthLimit(float AsyncIOBandwidthLimit) override;
	
	virtual void SetSeamlessTravelViewTarget(APlayerController* PC) override;
	
	virtual void StartNewPlayer(APlayerController* NewPlayer) override;
	
protected:
	
	virtual void HandleLeavingMap() override;
	
	virtual void HandleMatchAborted() override;
	
	virtual void HandleMatchHasEnded() override;
	
	virtual void HandleMatchHasStarted() override;
	
	virtual void HandleMatchIsWaitingToStart() override;
	
	virtual void OnMatchStateSet() override;
	
	virtual void SetMatchState(FName NewState) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
