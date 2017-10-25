#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageGameStateBase.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

void AManageGameStateBase::OnRep_GameModeClass()
{
	Super::OnRep_GameModeClass();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_GameModeClass");
}

void AManageGameStateBase::OnRep_ReplicatedHasBegunPlay()
{
	Super::OnRep_ReplicatedHasBegunPlay();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedHasBegunPlay");
}

void AManageGameStateBase::OnRep_ReplicatedWorldTimeSeconds()
{
	Super::OnRep_ReplicatedWorldTimeSeconds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedWorldTimeSeconds");
}

void AManageGameStateBase::OnRep_SpectatorClass()
{
	Super::OnRep_SpectatorClass();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_SpectatorClass");
}

void AManageGameStateBase::UpdateServerTimeSeconds()
{
	Super::UpdateServerTimeSeconds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateServerTimeSeconds");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
