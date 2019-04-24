#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameState.h"
#include "ManageGameState.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameState : public AGameState, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void DefaultTimer() override;
	virtual void OnRep_ElapsedTime() override;
	virtual void OnRep_MatchState() override;
	
protected:
	virtual void HandleLeavingMap() override;
	virtual void HandleMatchHasEnded() override;
	virtual void HandleMatchHasStarted() override;
	virtual void HandleMatchIsWaitingToStart() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
