#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageGameMode.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

void AManageGameMode::AddInactivePlayer(APlayerState* PlayerState, APlayerController* PC)
{
	Super::AddInactivePlayer(PlayerState, PC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddInactivePlayer", PlayerState, PC);
}

void AManageGameMode::Broadcast(AActor* Sender, const FString& Msg, FName Type)
{
	Super::Broadcast(Sender, Msg, Type);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Broadcast", Sender, Msg, Type);
}

void AManageGameMode::HandleLeavingMap()
{
	Super::HandleLeavingMap();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleLeavingMap");
}

void AManageGameMode::HandleMatchAborted()
{
	Super::HandleMatchAborted();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchAborted");
}

void AManageGameMode::HandleMatchHasEnded()
{
	Super::HandleMatchHasEnded();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchHasEnded");
}

void AManageGameMode::HandleMatchHasStarted()
{
	Super::HandleMatchHasStarted();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchHasStarted");
}

void AManageGameMode::HandleMatchIsWaitingToStart()
{
	Super::HandleMatchIsWaitingToStart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchIsWaitingToStart");
}

void AManageGameMode::MatineeCancelled()
{
	Super::MatineeCancelled();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MatineeCancelled");
}

void AManageGameMode::NotifyPendingConnectionLost()
{
	Super::NotifyPendingConnectionLost();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyPendingConnectionLost");
}

void AManageGameMode::OnMatchStateSet()
{
	Super::OnMatchStateSet();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMatchStateSet");
}

void AManageGameMode::OverridePlayerState(APlayerController* PC, APlayerState* OldPlayerState)
{
	Super::OverridePlayerState(PC, OldPlayerState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OverridePlayerState", PC, OldPlayerState);
}

void AManageGameMode::PostCommitMapChange()
{
	Super::PostCommitMapChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCommitMapChange");
}

void AManageGameMode::PreCommitMapChange(const FString& PreviousMapName, const FString& NextMapName)
{
	Super::PreCommitMapChange(PreviousMapName, NextMapName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreCommitMapChange", PreviousMapName, NextMapName);
}

void AManageGameMode::Say(const FString& Msg)
{
	Super::Say(Msg);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Say", Msg);
}

void AManageGameMode::SendPlayer(APlayerController* aPlayer, const FString& URL)
{
	Super::SendPlayer(aPlayer, URL);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendPlayer", aPlayer, URL);
}

void AManageGameMode::SetBandwidthLimit(float AsyncIOBandwidthLimit)
{
	Super::SetBandwidthLimit(AsyncIOBandwidthLimit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetBandwidthLimit", AsyncIOBandwidthLimit);
}

void AManageGameMode::SetMatchState(FName NewState)
{
	Super::SetMatchState(NewState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMatchState", NewState);
}

void AManageGameMode::SetSeamlessTravelViewTarget(APlayerController* PC)
{
	Super::SetSeamlessTravelViewTarget(PC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetSeamlessTravelViewTarget", PC);
}

void AManageGameMode::StartNewPlayer(APlayerController* NewPlayer)
{
	Super::StartNewPlayer(NewPlayer);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartNewPlayer", NewPlayer);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
