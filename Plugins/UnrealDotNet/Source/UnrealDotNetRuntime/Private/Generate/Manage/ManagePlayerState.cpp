// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePlayerState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

AManagePlayerState::AManagePlayerState(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManagePlayerState::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManagePlayerState::ClientInitialize(AController* C)
{
	Super::ClientInitialize(C);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientInitialize", C);
}

void AManagePlayerState::CopyProperties(APlayerState* PlayerState)
{
	Super::CopyProperties(PlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CopyProperties", PlayerState);
}

void AManagePlayerState::HandleWelcomeMessage()
{
	Super::HandleWelcomeMessage();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleWelcomeMessage");
}

void AManagePlayerState::OnDeactivated()
{
	Super::OnDeactivated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDeactivated");
}

void AManagePlayerState::OnReactivated()
{
	Super::OnReactivated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReactivated");
}

void AManagePlayerState::OnRep_bIsInactive()
{
	Super::OnRep_bIsInactive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_bIsInactive");
}

void AManagePlayerState::OnRep_PlayerId()
{
	Super::OnRep_PlayerId();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerId");
}

void AManagePlayerState::OnRep_PlayerName()
{
	Super::OnRep_PlayerName();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerName");
}

void AManagePlayerState::OnRep_Score()
{
	Super::OnRep_Score();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Score");
}

void AManagePlayerState::OnRep_UniqueId()
{
	Super::OnRep_UniqueId();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_UniqueId");
}

void AManagePlayerState::OverrideWith(APlayerState* PlayerState)
{
	Super::OverrideWith(PlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverrideWith", PlayerState);
}

void AManagePlayerState::RecalculateAvgPing()
{
	Super::RecalculateAvgPing();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateAvgPing");
}

void AManagePlayerState::RegisterPlayerWithSession(bool bWasFromInvite)
{
	Super::RegisterPlayerWithSession(bWasFromInvite);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterPlayerWithSession", bWasFromInvite);
}

void AManagePlayerState::SeamlessTravelTo(APlayerState* NewPlayerState)
{
	Super::SeamlessTravelTo(NewPlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SeamlessTravelTo", NewPlayerState);
}

void AManagePlayerState::SetOldPlayerName(const FString& S)
{
	Super::SetOldPlayerName(S);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOldPlayerName", S);
}

void AManagePlayerState::SetPlayerName(const FString& S)
{
	Super::SetPlayerName(S);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerName", S);
}

void AManagePlayerState::SetPlayerNameInternal(const FString& S)
{
	Super::SetPlayerNameInternal(S);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerNameInternal", S);
}

void AManagePlayerState::UnregisterPlayerWithSession()
{
	Super::UnregisterPlayerWithSession();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterPlayerWithSession");
}

void AManagePlayerState::UpdatePing(float InPing)
{
	Super::UpdatePing(InPing);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePing", InPing);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
