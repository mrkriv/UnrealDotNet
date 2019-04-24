#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameModeBase.h"
#include "ManageGameModeBase.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:46

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameModeBase : public AGameModeBase, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void ChangeName(AController* Controller, const FString& NewName, bool bNameChange) override;
	virtual void GetSeamlessTravelActorList(bool bToTransition, TArray<AActor*>& ActorList) override;
	virtual void InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage) override;
	virtual void InitGameState() override;
	virtual void Logout(AController* Exiting) override;
	virtual void PostLogin(APlayerController* NewPlayer) override;
	virtual void PostSeamlessTravel() override;
	virtual void ProcessServerTravel(const FString& URL, bool bAbsolute) override;
	virtual void ResetLevel() override;
	virtual void RestartPlayer(AController* NewPlayer) override;
	virtual void RestartPlayerAtPlayerStart(AController* NewPlayer, AActor* StartSpot) override;
	virtual void RestartPlayerAtTransform(AController* NewPlayer, const FTransform& SpawnTransform) override;
	virtual void ReturnToMainMenuHost() override;
	virtual void SetPlayerDefaults(APawn* PlayerPawn) override;
	virtual void StartPlay() override;
	virtual void StartToLeaveMap() override;
	virtual void SwapPlayerControllers(APlayerController* OldPC, APlayerController* NewPC) override;
	
protected:
	virtual void FinishRestartPlayer(AController* NewPlayer, const FRotator& StartRotation) override;
	virtual void GenericPlayerInitialization(AController* C) override;
	virtual void InitSeamlessTravelPlayer(AController* NewController) override;
	virtual void ReplicateStreamingStatus(APlayerController* PC) override;
	virtual void UpdateGameplayMuteList(APlayerController* aPlayer) override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
