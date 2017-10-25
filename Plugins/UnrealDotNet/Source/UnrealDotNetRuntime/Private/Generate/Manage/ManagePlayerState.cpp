#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePlayerState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:39

void AManagePlayerState::ClientInitialize(AController* C)
{
	Super::ClientInitialize(C);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientInitialize", C);
}

void AManagePlayerState::CopyProperties(APlayerState* PlayerState)
{
	Super::CopyProperties(PlayerState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CopyProperties", PlayerState);
}

void AManagePlayerState::OnDeactivated()
{
	Super::OnDeactivated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDeactivated");
}

void AManagePlayerState::OnReactivated()
{
	Super::OnReactivated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnReactivated");
}

void AManagePlayerState::OnRep_bIsInactive()
{
	Super::OnRep_bIsInactive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_bIsInactive");
}

void AManagePlayerState::OnRep_PlayerName()
{
	Super::OnRep_PlayerName();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_PlayerName");
}

void AManagePlayerState::OnRep_Score()
{
	Super::OnRep_Score();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Score");
}

void AManagePlayerState::OnRep_UniqueId()
{
	Super::OnRep_UniqueId();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_UniqueId");
}

void AManagePlayerState::OverrideWith(APlayerState* PlayerState)
{
	Super::OverrideWith(PlayerState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OverrideWith", PlayerState);
}

void AManagePlayerState::RecalculateAvgPing()
{
	Super::RecalculateAvgPing();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RecalculateAvgPing");
}

void AManagePlayerState::RegisterPlayerWithSession(bool bWasFromInvite)
{
	Super::RegisterPlayerWithSession(bWasFromInvite);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterPlayerWithSession", bWasFromInvite);
}

void AManagePlayerState::SeamlessTravelTo(APlayerState* NewPlayerState)
{
	Super::SeamlessTravelTo(NewPlayerState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SeamlessTravelTo", NewPlayerState);
}

void AManagePlayerState::SetPlayerName(const FString& S)
{
	Super::SetPlayerName(S);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlayerName", S);
}

void AManagePlayerState::UnregisterPlayerWithSession()
{
	Super::UnregisterPlayerWithSession();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterPlayerWithSession");
}

void AManagePlayerState::UpdatePing(float InPing)
{
	Super::UpdatePing(InPing);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePing", InPing);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
