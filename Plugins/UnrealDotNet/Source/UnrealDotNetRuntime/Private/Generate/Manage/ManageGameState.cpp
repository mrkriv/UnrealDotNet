// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

AManageGameState::AManageGameState(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageGameState::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageGameState::DefaultTimer()
{
	Super::DefaultTimer();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DefaultTimer");
}

void AManageGameState::HandleLeavingMap()
{
	Super::HandleLeavingMap();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleLeavingMap");
}

void AManageGameState::HandleMatchHasEnded()
{
	Super::HandleMatchHasEnded();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasEnded");
}

void AManageGameState::HandleMatchHasStarted()
{
	Super::HandleMatchHasStarted();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasStarted");
}

void AManageGameState::HandleMatchIsWaitingToStart()
{
	Super::HandleMatchIsWaitingToStart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchIsWaitingToStart");
}

void AManageGameState::OnRep_ElapsedTime()
{
	Super::OnRep_ElapsedTime();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ElapsedTime");
}

void AManageGameState::OnRep_MatchState()
{
	Super::OnRep_MatchState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_MatchState");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
