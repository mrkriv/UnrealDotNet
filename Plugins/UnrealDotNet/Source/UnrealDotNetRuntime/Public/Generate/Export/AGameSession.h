#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameSession.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameSession_bRequiresPushToTalk_GET(AGameSession* Ptr) { return Ptr->bRequiresPushToTalk; }
	DOTNET_EXPORT void E_PROP_AGameSession_bRequiresPushToTalk_SET(AGameSession* Ptr, bool Value) { Ptr->bRequiresPushToTalk = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxPartySize_GET(AGameSession* Ptr) { return Ptr->MaxPartySize; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxPartySize_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxPartySize = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxPlayers_GET(AGameSession* Ptr) { return Ptr->MaxPlayers; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxPlayers_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxPlayers = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxSpectators_GET(AGameSession* Ptr) { return Ptr->MaxSpectators; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxSpectators_SET(AGameSession* Ptr, int32 Value) { Ptr->MaxSpectators = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_MaxSplitscreensPerConnection_GET(AGameSession* Ptr) { return Ptr->MaxSplitscreensPerConnection; }
	DOTNET_EXPORT void E_PROP_AGameSession_MaxSplitscreensPerConnection_SET(AGameSession* Ptr, uint8 Value) { Ptr->MaxSplitscreensPerConnection = Value; }
	
	DOTNET_EXPORT auto E_PROP_AGameSession_SessionName_GET(AGameSession* Ptr) { return ConvertToManage_StringWrapper(Ptr->SessionName); }
	DOTNET_EXPORT void E_PROP_AGameSession_SessionName_SET(AGameSession* Ptr, char* Value) { Ptr->SessionName = ConvertFromManage_FName(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameSession(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameSession>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameSession_AddAdmin(AGameSession* Self, APlayerController* AdminPlayer)
	{
		auto _p0 = AdminPlayer;
		Self->AGameSession::AddAdmin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_ApproveLogin(AGameSession* Self, char* Options)
	{
		auto _p0 = ConvertFromManage_FString(Options);
		return ConvertToManage_StringWrapper(Self->ApproveLogin(_p0));
	}

	DOTNET_EXPORT auto E_AGameSession_AtCapacity(AGameSession* Self, bool bSpectator)
	{
		auto _p0 = bSpectator;
		return Self->AtCapacity(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_BanPlayer(AGameSession* Self, APlayerController* BannedPlayer, char* BanReason)
	{
		auto _p0 = BannedPlayer;
		auto _p1 = ConvertFromManage_FText(BanReason);
		return Self->BanPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameSession_CanRestartGame(AGameSession* Self)
	{
		return Self->CanRestartGame();
	}

	DOTNET_EXPORT auto E_AGameSession_DumpSessionState(AGameSession* Self)
	{
		Self->AGameSession::DumpSessionState();
	}

	DOTNET_EXPORT auto E_AGameSession_GetNextPlayerID(AGameSession* Self)
	{
		return Self->GetNextPlayerID();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchHasEnded(AGameSession* Self)
	{
		Self->AGameSession::HandleMatchHasEnded();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchHasStarted(AGameSession* Self)
	{
		Self->AGameSession::HandleMatchHasStarted();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleMatchIsWaitingToStart(AGameSession* Self)
	{
		Self->AGameSession::HandleMatchIsWaitingToStart();
	}

	DOTNET_EXPORT auto E_AGameSession_HandleStartMatchRequest(AGameSession* Self)
	{
		return Self->HandleStartMatchRequest();
	}

	DOTNET_EXPORT auto E_AGameSession_InitOptions(AGameSession* Self, char* Options)
	{
		auto _p0 = ConvertFromManage_FString(Options);
		Self->AGameSession::InitOptions(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_KickPlayer(AGameSession* Self, APlayerController* KickedPlayer, char* KickReason)
	{
		auto _p0 = KickedPlayer;
		auto _p1 = ConvertFromManage_FText(KickReason);
		return Self->KickPlayer(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AGameSession_NotifyLogout(AGameSession* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->AGameSession::NotifyLogout(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_OnAutoLoginComplete(AGameSession* Self, int32 LocalUserNum, bool bWasSuccessful, char* Error)
	{
		auto _p0 = LocalUserNum;
		auto _p1 = bWasSuccessful;
		auto _p2 = ConvertFromManage_FString(Error);
		Self->AGameSession::OnAutoLoginComplete(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AGameSession_PostLogin(AGameSession* Self, APlayerController* NewPlayer)
	{
		auto _p0 = NewPlayer;
		Self->AGameSession::PostLogin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_PostSeamlessTravel(AGameSession* Self)
	{
		Self->AGameSession::PostSeamlessTravel();
	}

	DOTNET_EXPORT auto E_AGameSession_ProcessAutoLogin(AGameSession* Self)
	{
		return Self->ProcessAutoLogin();
	}

	DOTNET_EXPORT auto E_AGameSession_RegisterServer(AGameSession* Self)
	{
		Self->AGameSession::RegisterServer();
	}

	DOTNET_EXPORT auto E_AGameSession_RegisterServerFailed(AGameSession* Self)
	{
		Self->AGameSession::RegisterServerFailed();
	}

	DOTNET_EXPORT auto E_AGameSession_RemoveAdmin(AGameSession* Self, APlayerController* AdminPlayer)
	{
		auto _p0 = AdminPlayer;
		Self->AGameSession::RemoveAdmin(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_RequiresPushToTalk(AGameSession* Self)
	{
		return Self->RequiresPushToTalk();
	}

	DOTNET_EXPORT auto E_AGameSession_Restart(AGameSession* Self)
	{
		Self->AGameSession::Restart();
	}

	DOTNET_EXPORT auto E_AGameSession_ReturnToMainMenuHost(AGameSession* Self)
	{
		Self->AGameSession::ReturnToMainMenuHost();
	}

	DOTNET_EXPORT auto E_AGameSession_UnregisterPlayer(AGameSession* Self, APlayerController* ExitingPlayer)
	{
		auto _p0 = ExitingPlayer;
		Self->AGameSession::UnregisterPlayer(_p0);
	}

	DOTNET_EXPORT auto E_AGameSession_UpdateSessionJoinability(AGameSession* Self, char* InSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly)
	{
		auto _p0 = ConvertFromManage_FName(InSessionName);
		auto _p1 = bPublicSearchable;
		auto _p2 = bAllowInvites;
		auto _p3 = bJoinViaPresence;
		auto _p4 = bJoinViaPresenceFriendsOnly;
		Self->AGameSession::UpdateSessionJoinability(_p0, _p1, _p2, _p3, _p4);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
