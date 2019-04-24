#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameStateBase.h"
#include "ManageGameStateBase.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameStateBase : public AGameStateBase, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddPlayerState(APlayerState* PlayerState) override;
	virtual void AsyncPackageLoaded(UObject* Package) override;
	virtual void HandleBeginPlay() override;
	virtual void ReceivedGameModeClass() override;
	virtual void ReceivedSpectatorClass() override;
	virtual void RemovePlayerState(APlayerState* PlayerState) override;
	virtual void SeamlessTravelTransitionCheckpoint(bool bToTransitionMap) override;
	
protected:
	virtual void OnRep_GameModeClass() override;
	virtual void OnRep_ReplicatedHasBegunPlay() override;
	virtual void OnRep_ReplicatedWorldTimeSeconds() override;
	virtual void OnRep_SpectatorClass() override;
	virtual void UpdateServerTimeSeconds() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
