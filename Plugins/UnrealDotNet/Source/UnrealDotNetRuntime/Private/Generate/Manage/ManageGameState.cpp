#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageGameState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

void AManageGameState::DefaultTimer()
{
	Super::DefaultTimer();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DefaultTimer");
}

void AManageGameState::HandleLeavingMap()
{
	Super::HandleLeavingMap();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleLeavingMap");
}

void AManageGameState::HandleMatchHasEnded()
{
	Super::HandleMatchHasEnded();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchHasEnded");
}

void AManageGameState::HandleMatchHasStarted()
{
	Super::HandleMatchHasStarted();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchHasStarted");
}

void AManageGameState::HandleMatchIsWaitingToStart()
{
	Super::HandleMatchIsWaitingToStart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleMatchIsWaitingToStart");
}

void AManageGameState::OnRep_ElapsedTime()
{
	Super::OnRep_ElapsedTime();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ElapsedTime");
}

void AManageGameState::OnRep_MatchState()
{
	Super::OnRep_MatchState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_MatchState");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
