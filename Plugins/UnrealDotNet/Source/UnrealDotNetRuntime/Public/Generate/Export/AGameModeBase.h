#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameModeBase.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:46

class E_PROTECTED_WRAP_AGameModeBase : protected AGameModeBase
{
public:
	void FinishRestartPlayer_WRAP(AController* NewPlayer, const FRotator& StartRotation)
	{
		FinishRestartPlayer(NewPlayer, StartRotation);
	}

	void GenericPlayerInitialization_WRAP(AController* C)
	{
		GenericPlayerInitialization(C);
	}

	void InitializeHUDForPlayer_WRAP(APlayerController* NewPlayer)
	{
		InitializeHUDForPlayer(NewPlayer);
	}

	void InitSeamlessTravelPlayer_WRAP(AController* NewController)
	{
		InitSeamlessTravelPlayer(NewController);
	}

	void K2_OnSwapPlayerControllers_WRAP(APlayerController* OldPC, APlayerController* NewPC)
	{
		K2_OnSwapPlayerControllers(OldPC, NewPC);
	}

	void ReplicateStreamingStatus_WRAP(APlayerController* PC)
	{
		ReplicateStreamingStatus(PC);
	}

	bool ShouldSpawnAtStartSpot_WRAP(AController* Player)
	{
		return ShouldSpawnAtStartSpot(Player);
	}

	bool ShouldStartInCinematicMode_WRAP(APlayerController* Player, bool& OutHidePlayer, bool& OutHideHud, bool& OutDisableMovement, bool& OutDisableTurning)
	{
		return ShouldStartInCinematicMode(Player, OutHidePlayer, OutHideHud, OutDisableMovement, OutDisableTurning);
	}

	void UpdateGameplayMuteList_WRAP(APlayerController* aPlayer)
	{
		UpdateGameplayMuteList(aPlayer);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameModeBase_DefaultPlayerName_GET(AGameModeBase* Ptr) { return ConvertToManage_StringWrapper(Ptr->DefaultPlayerName); }
	DOTNET_EXPORT void E_PROP_AGameModeBase_DefaultPlayerName_SET(AGameModeBase* Ptr, char* Value) { Ptr->DefaultPlayerName = ConvertFromManage_FText(Value); }
	
	DOTNET_EXPORT auto E_PROP_AGameModeBase_GameSession_GET(AGameModeBase* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->GameSession); }
	DOTNET_EXPORT void E_PROP_AGameModeBase_GameSession_SET(AGameModeBase* Ptr, AGameSession* Value) { Ptr->GameSession = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameModeBase_GameState_GET(AGameModeBase* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->GameState); }
	DOTNET_EXPORT void E_PROP_AGameModeBase_GameState_SET(AGameModeBase* Ptr, AGameStateBase* Value) { Ptr->GameState = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameModeBase_OptionsString_GET(AGameModeBase* Ptr) { return ConvertToManage_StringWrapper(Ptr->OptionsString); }
	DOTNET_EXPORT void E_PROP_AGameModeBase_OptionsString_SET(AGameModeBase* Ptr, char* Value) { Ptr->OptionsString = ConvertFromManage_FString(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameModeBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameModeBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameModeBase_AllowCheats(AGameModeBase* Self, APlayerController* P)
	{
		auto _p0 = P;
		return Self->AllowCheats(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_AllowPausing(AGameModeBase* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		return Self->AllowPausing(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_CanServerTravel(AGameModeBase* Self, char* URL, bool bAbsolute)
	{
		auto _p0 = ConvertFromManage_FString(URL);
		auto _p1 = bAbsolute;
		return Self->CanServerTravel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_CanSpectate(AGameModeBase* Self, APlayerController* Viewer, APlayerState* ViewTarget)
	{
		auto _p0 = Viewer;
		auto _p1 = ViewTarget;
		return Self->CanSpectate(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ChangeName(AGameModeBase* Self, AController* Controller, char* NewName, bool bNameChange)
	{
		auto _p0 = Controller;
		auto _p1 = ConvertFromManage_FString(NewName);
		auto _p2 = bNameChange;
		Self->ChangeName(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ChoosePlayerStart(AGameModeBase* Self, AController* Player)
	{
		auto _p0 = Player;
		return ConvertToManage_ObjectPointerDescription(Self->ChoosePlayerStart(_p0));
	}

	DOTNET_EXPORT auto E_AGameModeBase_ClearPause(AGameModeBase* Self)
	{
		return Self->ClearPause();
	}

	DOTNET_EXPORT auto E_AGameModeBase_FindPlayerStart(AGameModeBase* Self, AController* Player, char* IncomingName)
	{
		auto _p0 = Player;
		auto _p1 = ConvertFromManage_FString(IncomingName);
		return ConvertToManage_ObjectPointerDescription(Self->FindPlayerStart(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AGameModeBase_FinishRestartPlayer(AGameModeBase* Self, AController* NewPlayer, INT_PTR StartRotation)
	{
		auto _p0 = NewPlayer;
		auto& _p1 = *(FRotator*)StartRotation;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->FinishRestartPlayer_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ForceClearUnpauseDelegates(AGameModeBase* Self, AActor* PauseActor)
	{
		auto _p0 = PauseActor;
		Self->ForceClearUnpauseDelegates(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_GenericPlayerInitialization(AGameModeBase* Self, AController* C)
	{
		auto _p0 = C;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->GenericPlayerInitialization_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_GetNumPlayers(AGameModeBase* Self)
	{
		return Self->GetNumPlayers();
	}

	DOTNET_EXPORT auto E_AGameModeBase_GetNumSpectators(AGameModeBase* Self)
	{
		return Self->GetNumSpectators();
	}

	DOTNET_EXPORT auto E_AGameModeBase_HandleStartingNewPlayer(AGameModeBase* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->HandleStartingNewPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_HasMatchStarted(AGameModeBase* Self)
	{
		return Self->HasMatchStarted();
	}

	DOTNET_EXPORT auto E_AGameModeBase_InitGame(AGameModeBase* Self, char* MapName, char* Options, char* ErrorMessage)
	{
		auto _p0 = ConvertFromManage_FString(MapName);
		auto _p1 = ConvertFromManage_FString(Options);
		auto _p2 = ConvertFromManage_FString(ErrorMessage);
		Self->InitGame(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameModeBase_InitGameState(AGameModeBase* Self)
	{
		Self->InitGameState();
	}

	DOTNET_EXPORT auto E_AGameModeBase_InitializeHUDForPlayer(AGameModeBase* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->InitializeHUDForPlayer_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_InitSeamlessTravelPlayer(AGameModeBase* Self, AController* NewController)
	{
		auto _p0 = NewController;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->InitSeamlessTravelPlayer_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_InitStartSpot(AGameModeBase* Self, AActor* StartSpot, AController* NewPlayer)
	{
		auto _p0 = StartSpot;
		auto _p1 = NewPlayer;
		Self->InitStartSpot(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_IsHandlingReplays(AGameModeBase* Self)
	{
		return Self->IsHandlingReplays();
	}

	DOTNET_EXPORT auto E_AGameModeBase_IsPaused(AGameModeBase* Self)
	{
		return Self->IsPaused();
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_FindPlayerStart(AGameModeBase* Self, AController* Player, char* IncomingName)
	{
		auto _p0 = Player;
		auto _p1 = ConvertFromManage_FString(IncomingName);
		return ConvertToManage_ObjectPointerDescription(Self->K2_FindPlayerStart(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_OnChangeName(AGameModeBase* Self, AController* Other, char* NewName, bool bNameChange)
	{
		auto _p0 = Other;
		auto _p1 = ConvertFromManage_FString(NewName);
		auto _p2 = bNameChange;
		Self->K2_OnChangeName(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_OnLogout(AGameModeBase* Self, AController* ExitingController)
	{
		auto _p0 = ExitingController;
		Self->K2_OnLogout(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_OnRestartPlayer(AGameModeBase* Self, AController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->K2_OnRestartPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_OnSwapPlayerControllers(AGameModeBase* Self, APlayerController* OldPC, APlayerController* NewPC)
	{
		auto _p0 = OldPC;
		auto _p1 = NewPC;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->K2_OnSwapPlayerControllers_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_K2_PostLogin(AGameModeBase* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->K2_PostLogin(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_Logout(AGameModeBase* Self, AController* Exiting)
	{
		auto _p0 = Exiting;
		Self->Logout(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_MustSpectate(AGameModeBase* Self, APlayerController* NewPlayerController)
	{
		auto _p0 = NewPlayerController;
		return Self->MustSpectate(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_PlayerCanRestart(AGameModeBase* Self, APlayerController* Player)
	{
		auto _p0 = Player;
		return Self->PlayerCanRestart(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_PostLogin(AGameModeBase* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->PostLogin(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_PostSeamlessTravel(AGameModeBase* Self)
	{
		Self->PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E_AGameModeBase_ProcessServerTravel(AGameModeBase* Self, char* URL, bool bAbsolute)
	{
		auto _p0 = ConvertFromManage_FString(URL);
		auto _p1 = bAbsolute;
		Self->ProcessServerTravel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ReplicateStreamingStatus(AGameModeBase* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->ReplicateStreamingStatus_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ResetLevel(AGameModeBase* Self)
	{
		Self->ResetLevel();
	}

	DOTNET_EXPORT auto E_AGameModeBase_RestartPlayer(AGameModeBase* Self, AController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->RestartPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_RestartPlayerAtPlayerStart(AGameModeBase* Self, AController* NewPlayer, AActor* StartSpot)
	{
		auto _p0 = NewPlayer;
		auto _p1 = StartSpot;
		Self->RestartPlayerAtPlayerStart(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_RestartPlayerAtTransform(AGameModeBase* Self, AController* NewPlayer, INT_PTR SpawnTransform)
	{
		auto _p0 = NewPlayer;
		auto& _p1 = *(FTransform*)SpawnTransform;
		Self->RestartPlayerAtTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ReturnToMainMenuHost(AGameModeBase* Self)
	{
		Self->ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E_AGameModeBase_SetPlayerDefaults(AGameModeBase* Self, APawn* PlayerPawn)
	{
		auto _p0 = PlayerPawn;
		Self->SetPlayerDefaults(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ShouldReset(AGameModeBase* Self, AActor* ActorToReset)
	{
		auto _p0 = ActorToReset;
		return Self->ShouldReset(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ShouldSpawnAtStartSpot(AGameModeBase* Self, AController* Player)
	{
		auto _p0 = Player;
		return ((E_PROTECTED_WRAP_AGameModeBase*)Self)->ShouldSpawnAtStartSpot_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameModeBase_ShouldStartInCinematicMode(AGameModeBase* Self, APlayerController* Player, bool OutHidePlayer, bool OutHideHud, bool OutDisableMovement, bool OutDisableTurning)
	{
		auto _p0 = Player;
		auto& _p1 = OutHidePlayer;
		auto& _p2 = OutHideHud;
		auto& _p3 = OutDisableMovement;
		auto& _p4 = OutDisableTurning;
		return ((E_PROTECTED_WRAP_AGameModeBase*)Self)->ShouldStartInCinematicMode_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnDefaultPawnAtTransform(AGameModeBase* Self, AController* NewPlayer, INT_PTR SpawnTransform)
	{
		auto _p0 = NewPlayer;
		auto& _p1 = *(FTransform*)SpawnTransform;
		return ConvertToManage_ObjectPointerDescription(Self->SpawnDefaultPawnAtTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnDefaultPawnFor(AGameModeBase* Self, AController* NewPlayer, AActor* StartSpot)
	{
		auto _p0 = NewPlayer;
		auto _p1 = StartSpot;
		return ConvertToManage_ObjectPointerDescription(Self->SpawnDefaultPawnFor(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnPlayerController(AGameModeBase* Self, ENetRole InRemoteRole, char* Options)
	{
		auto _p0 = InRemoteRole;
		auto _p1 = ConvertFromManage_FString(Options);
		return ConvertToManage_ObjectPointerDescription(Self->SpawnPlayerController(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnPlayerController_o1(AGameModeBase* Self, ENetRole InRemoteRole, INT_PTR SpawnLocation, INT_PTR SpawnRotation)
	{
		auto _p0 = InRemoteRole;
		auto& _p1 = *(FVector*)SpawnLocation;
		auto& _p2 = *(FRotator*)SpawnRotation;
		return ConvertToManage_ObjectPointerDescription(Self->SpawnPlayerController(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnPlayerFromSimulate(AGameModeBase* Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)NewLocation;
		auto& _p1 = *(FRotator*)NewRotation;
		return Self->SpawnPlayerFromSimulate(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_SpawnReplayPlayerController(AGameModeBase* Self, ENetRole InRemoteRole, INT_PTR SpawnLocation, INT_PTR SpawnRotation)
	{
		auto _p0 = InRemoteRole;
		auto& _p1 = *(FVector*)SpawnLocation;
		auto& _p2 = *(FRotator*)SpawnRotation;
		return ConvertToManage_ObjectPointerDescription(Self->SpawnReplayPlayerController(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_AGameModeBase_StartPlay(AGameModeBase* Self)
	{
		Self->StartPlay();
	}

	DOTNET_EXPORT auto E_AGameModeBase_StartToLeaveMap(AGameModeBase* Self)
	{
		Self->StartToLeaveMap();
	}

	DOTNET_EXPORT auto E_AGameModeBase_SwapPlayerControllers(AGameModeBase* Self, APlayerController* OldPC, APlayerController* NewPC)
	{
		auto _p0 = OldPC;
		auto _p1 = NewPC;
		Self->SwapPlayerControllers(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameModeBase_UpdateGameplayMuteList(AGameModeBase* Self, APlayerController* aPlayer)
	{
		auto _p0 = aPlayer;
		((E_PROTECTED_WRAP_AGameModeBase*)Self)->UpdateGameplayMuteList_WRAP(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
