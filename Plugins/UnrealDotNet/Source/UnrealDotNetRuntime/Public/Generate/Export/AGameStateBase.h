#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameStateBase.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

class E_PROTECTED_WRAP_AGameStateBase : protected AGameStateBase
{
public:
	void OnRep_GameModeClass_WRAP()
	{
		OnRep_GameModeClass();
	}

	void OnRep_ReplicatedHasBegunPlay_WRAP()
	{
		OnRep_ReplicatedHasBegunPlay();
	}

	void OnRep_ReplicatedWorldTimeSeconds_WRAP()
	{
		OnRep_ReplicatedWorldTimeSeconds();
	}

	void OnRep_SpectatorClass_WRAP()
	{
		OnRep_SpectatorClass();
	}

	void UpdateServerTimeSeconds_WRAP()
	{
		UpdateServerTimeSeconds();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameStateBase_AuthorityGameMode_GET(AGameStateBase* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AuthorityGameMode); }
	DOTNET_EXPORT void E_PROP_AGameStateBase_AuthorityGameMode_SET(AGameStateBase* Ptr, AGameModeBase* Value) { Ptr->AuthorityGameMode = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameStateBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameStateBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameStateBase_AddPlayerState(AGameStateBase* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->AddPlayerState(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_AsyncPackageLoaded(AGameStateBase* Self, UObject* Package)
	{
		auto _p0 = Package;
		Self->AsyncPackageLoaded(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetDefaultGameMode(AGameStateBase* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultGameMode());
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetPlayerRespawnDelay(AGameStateBase* Self, AController* Controller)
	{
		auto _p0 = Controller;
		return Self->GetPlayerRespawnDelay(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetPlayerStartTime(AGameStateBase* Self, AController* Controller)
	{
		auto _p0 = Controller;
		return Self->GetPlayerStartTime(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_GetServerWorldTimeSeconds(AGameStateBase* Self)
	{
		return Self->GetServerWorldTimeSeconds();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HandleBeginPlay(AGameStateBase* Self)
	{
		Self->HandleBeginPlay();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HasBegunPlay(AGameStateBase* Self)
	{
		return Self->HasBegunPlay();
	}

	DOTNET_EXPORT auto E_AGameStateBase_HasMatchStarted(AGameStateBase* Self)
	{
		return Self->HasMatchStarted();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_GameModeClass(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_GameModeClass_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_ReplicatedHasBegunPlay(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_ReplicatedHasBegunPlay_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_ReplicatedWorldTimeSeconds(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_ReplicatedWorldTimeSeconds_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_OnRep_SpectatorClass(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->OnRep_SpectatorClass_WRAP();
	}

	DOTNET_EXPORT auto E_AGameStateBase_ReceivedGameModeClass(AGameStateBase* Self)
	{
		Self->ReceivedGameModeClass();
	}

	DOTNET_EXPORT auto E_AGameStateBase_ReceivedSpectatorClass(AGameStateBase* Self)
	{
		Self->ReceivedSpectatorClass();
	}

	DOTNET_EXPORT auto E_AGameStateBase_RemovePlayerState(AGameStateBase* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->RemovePlayerState(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_SeamlessTravelTransitionCheckpoint(AGameStateBase* Self, bool bToTransitionMap)
	{
		auto _p0 = bToTransitionMap;
		Self->SeamlessTravelTransitionCheckpoint(_p0);
	}

	DOTNET_EXPORT auto E_AGameStateBase_UpdateServerTimeSeconds(AGameStateBase* Self)
	{
		((E_PROTECTED_WRAP_AGameStateBase*)Self)->UpdateServerTimeSeconds_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
