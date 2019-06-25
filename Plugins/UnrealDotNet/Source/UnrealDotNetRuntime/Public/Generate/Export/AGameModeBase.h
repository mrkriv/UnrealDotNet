#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameModeBase.h"
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

	DOTNET_EXPORT auto E__Supper__AGameModeBase_InitGameState(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__InitGameState();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostSeamlessTravel(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ResetLevel(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ResetLevel();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ReturnToMainMenuHost(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_StartPlay(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__StartPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_StartToLeaveMap(AGameModeBase* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__StartToLeaveMap();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_BeginPlay(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_Destroyed(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ForceNetRelevant(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ForceNetUpdate(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_GatherCurrentMovement(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageGameModeBase*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_K2_DestroyActor(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_LifeSpanExpired(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnRep_Instigator(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnRep_Owner(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageGameModeBase*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OutsideWorldBounds(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostActorCreated(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostInitializeComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostNetInit(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostNetReceiveRole(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostRegisterAllComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PreInitializeComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PreRegisterAllComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageGameModeBase*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageGameModeBase*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_RegisterAllComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ReregisterAllComponents(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_RerunConstructionScripts(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_Reset(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_RewindForReplay(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageGameModeBase*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageGameModeBase*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageGameModeBase*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_TearOff(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageGameModeBase*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageGameModeBase*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_TornOff(AActor* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageGameModeBase*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_BeginDestroy(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_FinishDestroy(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostCDOContruct(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostEditImport(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostInitProperties(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostLoad(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostNetReceive(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostRepNotifies(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageGameModeBase*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PreDestroyFromReplication(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_PreNetReceive(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_ShutdownAfterError(UObject* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AGameModeBase_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageGameModeBase*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
