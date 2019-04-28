#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameSession.h"
#include "ManageGameSession.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameSession : public AGameSession, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddAdmin(APlayerController* AdminPlayer) override;
	virtual void DumpSessionState() override;
	virtual void HandleMatchHasEnded() override;
	virtual void HandleMatchHasStarted() override;
	virtual void HandleMatchIsWaitingToStart() override;
	virtual void InitOptions(const FString& Options) override;
	virtual void NotifyLogout(const APlayerController* PC) override;
	virtual void OnAutoLoginComplete(int32 LocalUserNum, bool bWasSuccessful, const FString& Error) override;
	virtual void PostLogin(APlayerController* NewPlayer) override;
	virtual void PostSeamlessTravel() override;
	virtual void RegisterServer() override;
	virtual void RegisterServerFailed() override;
	virtual void RemoveAdmin(APlayerController* AdminPlayer) override;
	virtual void Restart() override;
	virtual void ReturnToMainMenuHost() override;
	virtual void UnregisterPlayer(const APlayerController* ExitingPlayer) override;
	virtual void UpdateSessionJoinability(FName InSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
