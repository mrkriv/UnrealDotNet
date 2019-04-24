#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameState.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

class E_PROTECTED_WRAP_AGameState : protected AGameState
{
public:
	void HandleLeavingMap_WRAP()
	{
		HandleLeavingMap();
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

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AGameState_ElapsedTime_GET(AGameState* Ptr) { return Ptr->ElapsedTime; }
	DOTNET_EXPORT void E_PROP_AGameState_ElapsedTime_SET(AGameState* Ptr, int32 Value) { Ptr->ElapsedTime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AGameState(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AGameState>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AGameState_DefaultTimer(AGameState* Self)
	{
		Self->DefaultTimer();
	}

	DOTNET_EXPORT auto E_AGameState_HandleLeavingMap(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleLeavingMap_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchHasEnded(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchHasEnded_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchHasStarted(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchHasStarted_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_HandleMatchIsWaitingToStart(AGameState* Self)
	{
		((E_PROTECTED_WRAP_AGameState*)Self)->HandleMatchIsWaitingToStart_WRAP();
	}

	DOTNET_EXPORT auto E_AGameState_OnRep_ElapsedTime(AGameState* Self)
	{
		Self->OnRep_ElapsedTime();
	}

	DOTNET_EXPORT auto E_AGameState_OnRep_MatchState(AGameState* Self)
	{
		Self->OnRep_MatchState();
	}

	DOTNET_EXPORT auto E_AGameState_ShouldShowGore(AGameState* Self)
	{
		return Self->ShouldShowGore();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
