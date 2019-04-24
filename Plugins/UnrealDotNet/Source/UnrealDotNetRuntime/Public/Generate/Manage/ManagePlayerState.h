#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/PlayerState.h"
#include "ManagePlayerState.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

UCLASS()
class UNREALDOTNETRUNTIME_API AManagePlayerState : public APlayerState, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void ClientInitialize(AController* C) override;
	virtual void OnDeactivated() override;
	virtual void OnReactivated() override;
	virtual void OnRep_bIsInactive() override;
	virtual void OnRep_PlayerId() override;
	virtual void OnRep_PlayerName() override;
	virtual void OnRep_Score() override;
	virtual void OnRep_UniqueId() override;
	virtual void RecalculateAvgPing() override;
	virtual void RegisterPlayerWithSession(bool bWasFromInvite) override;
	virtual void SeamlessTravelTo(APlayerState* NewPlayerState) override;
	virtual void SetOldPlayerName(const FString& S) override;
	virtual void SetPlayerName(const FString& S) override;
	virtual void SetPlayerNameInternal(const FString& S) override;
	virtual void UnregisterPlayerWithSession() override;
	virtual void UpdatePing(float InPing) override;
	
protected:
	virtual void CopyProperties(APlayerState* PlayerState) override;
	virtual void HandleWelcomeMessage() override;
	virtual void OverrideWith(APlayerState* PlayerState) override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
