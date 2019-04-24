// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameStateBase.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

AManageGameStateBase::AManageGameStateBase(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageGameStateBase::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageGameStateBase::AddPlayerState(APlayerState* PlayerState)
{
	Super::AddPlayerState(PlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddPlayerState", PlayerState);
}

void AManageGameStateBase::AsyncPackageLoaded(UObject* Package)
{
	Super::AsyncPackageLoaded(Package);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AsyncPackageLoaded", Package);
}

void AManageGameStateBase::HandleBeginPlay()
{
	Super::HandleBeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleBeginPlay");
}

void AManageGameStateBase::OnRep_GameModeClass()
{
	Super::OnRep_GameModeClass();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_GameModeClass");
}

void AManageGameStateBase::OnRep_ReplicatedHasBegunPlay()
{
	Super::OnRep_ReplicatedHasBegunPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedHasBegunPlay");
}

void AManageGameStateBase::OnRep_ReplicatedWorldTimeSeconds()
{
	Super::OnRep_ReplicatedWorldTimeSeconds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedWorldTimeSeconds");
}

void AManageGameStateBase::OnRep_SpectatorClass()
{
	Super::OnRep_SpectatorClass();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_SpectatorClass");
}

void AManageGameStateBase::ReceivedGameModeClass()
{
	Super::ReceivedGameModeClass();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceivedGameModeClass");
}

void AManageGameStateBase::ReceivedSpectatorClass()
{
	Super::ReceivedSpectatorClass();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceivedSpectatorClass");
}

void AManageGameStateBase::RemovePlayerState(APlayerState* PlayerState)
{
	Super::RemovePlayerState(PlayerState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemovePlayerState", PlayerState);
}

void AManageGameStateBase::SeamlessTravelTransitionCheckpoint(bool bToTransitionMap)
{
	Super::SeamlessTravelTransitionCheckpoint(bToTransitionMap);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SeamlessTravelTransitionCheckpoint", bToTransitionMap);
}

void AManageGameStateBase::UpdateServerTimeSeconds()
{
	Super::UpdateServerTimeSeconds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateServerTimeSeconds");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
