#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/PlayerState.h"
#include "ManagePlayerState.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:39

UCLASS()
class UNREALDOTNETRUNTIME_API AManagePlayerState : public APlayerState
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void ClientInitialize(AController* C) override;
	
	virtual void OnDeactivated() override;
	
	virtual void OnReactivated() override;
	
	virtual void OnRep_bIsInactive() override;
	
	virtual void OnRep_PlayerName() override;
	
	virtual void OnRep_Score() override;
	
	virtual void OnRep_UniqueId() override;
	
	virtual void RecalculateAvgPing() override;
	
	virtual void RegisterPlayerWithSession(bool bWasFromInvite) override;
	
	virtual void SeamlessTravelTo(APlayerState* NewPlayerState) override;
	
	virtual void SetPlayerName(const FString& S) override;
	
	virtual void UnregisterPlayerWithSession() override;
	
	virtual void UpdatePing(float InPing) override;
	
protected:
	
	virtual void CopyProperties(APlayerState* PlayerState) override;
	
	virtual void OverrideWith(APlayerState* PlayerState) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
