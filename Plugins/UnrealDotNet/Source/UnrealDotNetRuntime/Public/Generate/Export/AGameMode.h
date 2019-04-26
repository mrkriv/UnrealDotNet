#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameMode.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

class E_PROTECTED_WRAP_AGameMode : protected AGameMode
{
public:
	void HandleLeavingMap_WRAP()
	{
		HandleLeavingMap();
	}

	void HandleMatchAborted_WRAP()
	{
		HandleMatchAborted();
	}

	void HandleMatchHasEnded_WRAP()
	{
		HandleMatchHasEnded();
	}

	void HandleMatchHasStarted_WRAP()
	{
		HandleMatchHasStarted();
	}

	void HandleMatchIsWaitingToStart_WRAP()
	{
		HandleMatchIsWaitingToStart();
	}

	void K2_OnSetMatchState_WRAP(FName NewState)
	{
		K2_OnSetMatchState(NewState);
	}

	void OnMatchStateSet_WRAP()
	{
		OnMatchStateSet();
	}

	bool ReadyToEndMatch_WRAP()
	{
		return ReadyToEndMatch();
	}

	bool ReadyToStartMatch_WRAP()
	{
		return ReadyToStartMatch();
	}

	void SetMatchState_WRAP(FName NewState)
	{
		SetMatchState(NewState);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameMode_MinRespawnDelay_GET(AGameMode* Ptr) { return Ptr->MinRespawnDelay; }
	DOTNET_EXPORT void E_PROP_AGameMode_MinRespawnDelay_SET(AGameMode* Ptr, float Value) { Ptr->MinRespawnDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumBots_GET(AGameMode* Ptr) { return Ptr->NumBots; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumBots_SET(AGameMode* Ptr, int32 Value) { Ptr->NumBots = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumPlayers_GET(AGameMode* Ptr) { return Ptr->NumPlayers; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumPlayers_SET(AGameMode* Ptr, int32 Value) { Ptr->NumPlayers = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumSpectators_GET(AGameMode* Ptr) { return Ptr->NumSpectators; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumSpectators_SET(AGameMode* Ptr, int32 Value) { Ptr->NumSpectators = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameMode_NumTravellingPlayers_GET(AGameMode* Ptr) { return Ptr->NumTravellingPlayers; }
	DOTNET_EXPORT void E_PROP_AGameMode_NumTravellingPlayers_SET(AGameMode* Ptr, int32 Value) { Ptr->NumTravellingPlayers = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameMode(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameMode>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameMode_AddInactivePlayer(AGameMode* Self, APlayerState* PlayerState, APlayerController* PC)
	{
		auto _p0 = PlayerState;
		auto _p1 = PC;
		Self->AddInactivePlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_Broadcast(AGameMode* Self, AActor* Sender, char* Msg, char* Type)
	{
		auto _p0 = Sender;
		auto _p1 = ConvertFromManage_FString(Msg);
		auto _p2 = ConvertFromManage_FName(Type);
		Self->Broadcast(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameMode_FindInactivePlayer(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		return Self->FindInactivePlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_GetDefaultGameClassPath(AGameMode* Self, char* MapName, char* Options, char* Portal)
	{
		auto _p0 = ConvertFromManage_FString(MapName);
		auto _p1 = ConvertFromManage_FString(Options);
		auto _p2 = ConvertFromManage_FString(Portal);
		return ConvertToManage_StringWrapper(Self->GetDefaultGameClassPath(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_AGameMode_GetNetworkNumber(AGameMode* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetNetworkNumber());
	}

	DOTNET_EXPORT auto E_AGameMode_GetTravelType(AGameMode* Self)
	{
		return Self->GetTravelType();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleLeavingMap(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleLeavingMap_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchAborted(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchAborted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchHasEnded(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchHasEnded_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchHasStarted(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchHasStarted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_HandleMatchIsWaitingToStart(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->HandleMatchIsWaitingToStart_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_K2_OnSetMatchState(AGameMode* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		((E_PROTECTED_WRAP_AGameMode*)Self)->K2_OnSetMatchState_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_MatineeCancelled(AGameMode* Self)
	{
		Self->MatineeCancelled();
	}

	DOTNET_EXPORT auto E_AGameMode_OnMatchStateSet(AGameMode* Self)
	{
		((E_PROTECTED_WRAP_AGameMode*)Self)->OnMatchStateSet_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_OverridePlayerState(AGameMode* Self, APlayerController* PC, APlayerState* OldPlayerState)
	{
		auto _p0 = PC;
		auto _p1 = OldPlayerState;
		Self->OverridePlayerState(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_PlayerSwitchedToSpectatorOnly(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->PlayerSwitchedToSpectatorOnly(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_PostCommitMapChange(AGameMode* Self)
	{
		Self->PostCommitMapChange();
	}

	DOTNET_EXPORT auto E_AGameMode_PreCommitMapChange(AGameMode* Self, char* PreviousMapName, char* NextMapName)
	{
		auto _p0 = ConvertFromManage_FString(PreviousMapName);
		auto _p1 = ConvertFromManage_FString(NextMapName);
		Self->PreCommitMapChange(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_ReadyToEndMatch(AGameMode* Self)
	{
		return ((E_PROTECTED_WRAP_AGameMode*)Self)->ReadyToEndMatch_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_ReadyToStartMatch(AGameMode* Self)
	{
		return ((E_PROTECTED_WRAP_AGameMode*)Self)->ReadyToStartMatch_WRAP();
	}

	DOTNET_EXPORT auto E_AGameMode_RemovePlayerControllerFromPlayerCount(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->RemovePlayerControllerFromPlayerCount(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_Say(AGameMode* Self, char* Msg)
	{
		auto _p0 = ConvertFromManage_FString(Msg);
		Self->Say(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SendPlayer(AGameMode* Self, APlayerController* aPlayer, char* URL)
	{
		auto _p0 = aPlayer;
		auto _p1 = ConvertFromManage_FString(URL);
		Self->SendPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameMode_SetBandwidthLimit(AGameMode* Self, float AsyncIOBandwidthLimit)
	{
		auto _p0 = AsyncIOBandwidthLimit;
		Self->SetBandwidthLimit(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SetMatchState(AGameMode* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		((E_PROTECTED_WRAP_AGameMode*)Self)->SetMatchState_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_SetSeamlessTravelViewTarget(AGameMode* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->SetSeamlessTravelViewTarget(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_StartNewPlayer(AGameMode* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->StartNewPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameMode_StaticGetFullGameClassName(AGameMode* Self, char* Str)
	{
		auto _p0 = ConvertFromManage_FString(Str);
		return ConvertToManage_StringWrapper(Self->StaticGetFullGameClassName(_p0));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
