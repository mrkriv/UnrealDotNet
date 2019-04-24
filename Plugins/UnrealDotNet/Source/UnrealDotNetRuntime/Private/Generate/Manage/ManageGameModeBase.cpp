// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameModeBase.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:46

AManageGameModeBase::AManageGameModeBase(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageGameModeBase::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageGameModeBase::ChangeName(AController* Controller, const FString& NewName, bool bNameChange)
{
	Super::ChangeName(Controller, NewName, bNameChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ChangeName", Controller, NewName, bNameChange);
}

void AManageGameModeBase::FinishRestartPlayer(AController* NewPlayer, const FRotator& StartRotation)
{
	Super::FinishRestartPlayer(NewPlayer, StartRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishRestartPlayer", NewPlayer, StartRotation);
}

void AManageGameModeBase::GenericPlayerInitialization(AController* C)
{
	Super::GenericPlayerInitialization(C);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GenericPlayerInitialization", C);
}

void AManageGameModeBase::GetSeamlessTravelActorList(bool bToTransition, TArray<AActor*>& ActorList)
{
	Super::GetSeamlessTravelActorList(bToTransition, ActorList);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GetSeamlessTravelActorList", bToTransition, ActorList);
}

void AManageGameModeBase::InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage)
{
	Super::InitGame(MapName, Options, ErrorMessage);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitGame", MapName, Options, ErrorMessage);
}

void AManageGameModeBase::InitGameState()
{
	Super::InitGameState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitGameState");
}

void AManageGameModeBase::InitSeamlessTravelPlayer(AController* NewController)
{
	Super::InitSeamlessTravelPlayer(NewController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitSeamlessTravelPlayer", NewController);
}

void AManageGameModeBase::Logout(AController* Exiting)
{
	Super::Logout(Exiting);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Logout", Exiting);
}

void AManageGameModeBase::PostLogin(APlayerController* NewPlayer)
{
	Super::PostLogin(NewPlayer);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLogin", NewPlayer);
}

void AManageGameModeBase::PostSeamlessTravel()
{
	Super::PostSeamlessTravel();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSeamlessTravel");
}

void AManageGameModeBase::ProcessServerTravel(const FString& URL, bool bAbsolute)
{
	Super::ProcessServerTravel(URL, bAbsolute);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ProcessServerTravel", URL, bAbsolute);
}

void AManageGameModeBase::ReplicateStreamingStatus(APlayerController* PC)
{
	Super::ReplicateStreamingStatus(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReplicateStreamingStatus", PC);
}

void AManageGameModeBase::ResetLevel()
{
	Super::ResetLevel();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetLevel");
}

void AManageGameModeBase::RestartPlayer(AController* NewPlayer)
{
	Super::RestartPlayer(NewPlayer);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartPlayer", NewPlayer);
}

void AManageGameModeBase::RestartPlayerAtPlayerStart(AController* NewPlayer, AActor* StartSpot)
{
	Super::RestartPlayerAtPlayerStart(NewPlayer, StartSpot);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartPlayerAtPlayerStart", NewPlayer, StartSpot);
}

void AManageGameModeBase::RestartPlayerAtTransform(AController* NewPlayer, const FTransform& SpawnTransform)
{
	Super::RestartPlayerAtTransform(NewPlayer, SpawnTransform);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartPlayerAtTransform", NewPlayer, SpawnTransform);
}

void AManageGameModeBase::ReturnToMainMenuHost()
{
	Super::ReturnToMainMenuHost();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReturnToMainMenuHost");
}

void AManageGameModeBase::SetPlayerDefaults(APawn* PlayerPawn)
{
	Super::SetPlayerDefaults(PlayerPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults", PlayerPawn);
}

void AManageGameModeBase::StartPlay()
{
	Super::StartPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartPlay");
}

void AManageGameModeBase::StartToLeaveMap()
{
	Super::StartToLeaveMap();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartToLeaveMap");
}

void AManageGameModeBase::SwapPlayerControllers(APlayerController* OldPC, APlayerController* NewPC)
{
	Super::SwapPlayerControllers(OldPC, NewPC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SwapPlayerControllers", OldPC, NewPC);
}

void AManageGameModeBase::UpdateGameplayMuteList(APlayerController* aPlayer)
{
	Super::UpdateGameplayMuteList(aPlayer);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateGameplayMuteList", aPlayer);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
