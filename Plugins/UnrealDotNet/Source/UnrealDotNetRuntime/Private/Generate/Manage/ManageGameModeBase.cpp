#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageGameModeBase.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:45

void AManageGameModeBase::ChangeName(AController* Controller, const FString& NewName, bool bNameChange)
{
	Super::ChangeName(Controller, NewName, bNameChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ChangeName", Controller, NewName, bNameChange);
}

void AManageGameModeBase::FinishRestartPlayer(AController* NewPlayer, const FRotator& StartRotation)
{
	Super::FinishRestartPlayer(NewPlayer, StartRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishRestartPlayer", NewPlayer, StartRotation);
}

void AManageGameModeBase::GenericPlayerInitialization(AController* C)
{
	Super::GenericPlayerInitialization(C);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GenericPlayerInitialization", C);
}

void AManageGameModeBase::InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage)
{
	Super::InitGame(MapName, Options, ErrorMessage);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitGame", MapName, Options, ErrorMessage);
}

void AManageGameModeBase::InitGameState()
{
	Super::InitGameState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitGameState");
}

void AManageGameModeBase::InitSeamlessTravelPlayer(AController* NewController)
{
	Super::InitSeamlessTravelPlayer(NewController);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitSeamlessTravelPlayer", NewController);
}

void AManageGameModeBase::Logout(AController* Exiting)
{
	Super::Logout(Exiting);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Logout", Exiting);
}

void AManageGameModeBase::PostLogin(APlayerController* NewPlayer)
{
	Super::PostLogin(NewPlayer);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLogin", NewPlayer);
}

void AManageGameModeBase::PostSeamlessTravel()
{
	Super::PostSeamlessTravel();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSeamlessTravel");
}

void AManageGameModeBase::ProcessServerTravel(const FString& URL, bool bAbsolute)
{
	Super::ProcessServerTravel(URL, bAbsolute);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ProcessServerTravel", URL, bAbsolute);
}

void AManageGameModeBase::ReplicateStreamingStatus(APlayerController* PC)
{
	Super::ReplicateStreamingStatus(PC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReplicateStreamingStatus", PC);
}

void AManageGameModeBase::ResetLevel()
{
	Super::ResetLevel();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetLevel");
}

void AManageGameModeBase::RestartPlayer(AController* NewPlayer)
{
	Super::RestartPlayer(NewPlayer);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RestartPlayer", NewPlayer);
}

void AManageGameModeBase::RestartPlayerAtPlayerStart(AController* NewPlayer, AActor* StartSpot)
{
	Super::RestartPlayerAtPlayerStart(NewPlayer, StartSpot);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RestartPlayerAtPlayerStart", NewPlayer, StartSpot);
}

void AManageGameModeBase::RestartPlayerAtTransform(AController* NewPlayer, const FTransform& SpawnTransform)
{
	Super::RestartPlayerAtTransform(NewPlayer, SpawnTransform);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RestartPlayerAtTransform", NewPlayer, SpawnTransform);
}

void AManageGameModeBase::ReturnToMainMenuHost()
{
	Super::ReturnToMainMenuHost();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReturnToMainMenuHost");
}

void AManageGameModeBase::SetPlayerDefaults(APawn* PlayerPawn)
{
	Super::SetPlayerDefaults(PlayerPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlayerDefaults", PlayerPawn);
}

void AManageGameModeBase::StartPlay()
{
	Super::StartPlay();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartPlay");
}

void AManageGameModeBase::StartToLeaveMap()
{
	Super::StartToLeaveMap();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartToLeaveMap");
}

void AManageGameModeBase::SwapPlayerControllers(APlayerController* OldPC, APlayerController* NewPC)
{
	Super::SwapPlayerControllers(OldPC, NewPC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SwapPlayerControllers", OldPC, NewPC);
}

void AManageGameModeBase::UpdateGameplayMuteList(APlayerController* aPlayer)
{
	Super::UpdateGameplayMuteList(aPlayer);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateGameplayMuteList", aPlayer);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
