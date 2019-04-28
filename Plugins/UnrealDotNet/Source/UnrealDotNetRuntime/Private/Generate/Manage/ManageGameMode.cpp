// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameMode.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

AManageGameMode::AManageGameMode(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageGameMode::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageGameMode::AbortMatch()
{
	Super::AbortMatch();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AbortMatch");
}

void AManageGameMode::AddInactivePlayer(APlayerState* PlayerState, APlayerController* PC)
{
	Super::AddInactivePlayer(PlayerState, PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddInactivePlayer", PlayerState, PC);
}

void AManageGameMode::Broadcast(AActor* Sender, const FString& Msg, FName Type)
{
	Super::Broadcast(Sender, Msg, Type);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Broadcast", Sender, Msg, Type);
}

void AManageGameMode::EndMatch()
{
	Super::EndMatch();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndMatch");
}

void AManageGameMode::HandleLeavingMap()
{
	Super::HandleLeavingMap();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleLeavingMap");
}

void AManageGameMode::HandleMatchAborted()
{
	Super::HandleMatchAborted();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchAborted");
}

void AManageGameMode::HandleMatchHasEnded()
{
	Super::HandleMatchHasEnded();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasEnded");
}

void AManageGameMode::HandleMatchHasStarted()
{
	Super::HandleMatchHasStarted();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasStarted");
}

void AManageGameMode::HandleMatchIsWaitingToStart()
{
	Super::HandleMatchIsWaitingToStart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchIsWaitingToStart");
}

void AManageGameMode::MatineeCancelled()
{
	Super::MatineeCancelled();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MatineeCancelled");
}

void AManageGameMode::OnMatchStateSet()
{
	Super::OnMatchStateSet();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnMatchStateSet");
}

void AManageGameMode::OverridePlayerState(APlayerController* PC, APlayerState* OldPlayerState)
{
	Super::OverridePlayerState(PC, OldPlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePlayerState", PC, OldPlayerState);
}

void AManageGameMode::PostCommitMapChange()
{
	Super::PostCommitMapChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCommitMapChange");
}

void AManageGameMode::PreCommitMapChange(const FString& PreviousMapName, const FString& NextMapName)
{
	Super::PreCommitMapChange(PreviousMapName, NextMapName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreCommitMapChange", PreviousMapName, NextMapName);
}

void AManageGameMode::RestartGame()
{
	Super::RestartGame();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartGame");
}

void AManageGameMode::Say(const FString& Msg)
{
	Super::Say(Msg);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Say", Msg);
}

void AManageGameMode::SendPlayer(APlayerController* aPlayer, const FString& URL)
{
	Super::SendPlayer(aPlayer, URL);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendPlayer", aPlayer, URL);
}

void AManageGameMode::SetBandwidthLimit(float AsyncIOBandwidthLimit)
{
	Super::SetBandwidthLimit(AsyncIOBandwidthLimit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetBandwidthLimit", AsyncIOBandwidthLimit);
}

void AManageGameMode::SetMatchState(FName NewState)
{
	Super::SetMatchState(NewState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMatchState", NewState);
}

void AManageGameMode::SetSeamlessTravelViewTarget(APlayerController* PC)
{
	Super::SetSeamlessTravelViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSeamlessTravelViewTarget", PC);
}

void AManageGameMode::StartMatch()
{
	Super::StartMatch();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartMatch");
}

void AManageGameMode::StartNewPlayer(APlayerController* NewPlayer)
{
	Super::StartNewPlayer(NewPlayer);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartNewPlayer", NewPlayer);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
