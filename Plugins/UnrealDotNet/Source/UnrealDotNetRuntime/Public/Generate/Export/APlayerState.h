#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/PlayerState.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

class E_PROTECTED_WRAP_APlayerState : protected APlayerState
{
public:
	void CopyProperties_WRAP(APlayerState* PlayerState)
	{
		CopyProperties(PlayerState);
	}

	void HandleWelcomeMessage_WRAP()
	{
		HandleWelcomeMessage();
	}

	void OverrideWith_WRAP(APlayerState* PlayerState)
	{
		OverrideWith(PlayerState);
	}

	void ReceiveCopyProperties_WRAP(APlayerState* NewPlayerState)
	{
		ReceiveCopyProperties(NewPlayerState);
	}

	void ReceiveOverrideWith_WRAP(APlayerState* OldPlayerState)
	{
		ReceiveOverrideWith(OldPlayerState);
	}

	void SetShouldUpdateReplicatedPing_WRAP(bool bInShouldUpdateReplicatedPing)
	{
		SetShouldUpdateReplicatedPing(bInShouldUpdateReplicatedPing);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_APlayerState_bFromPreviousLevel_GET(APlayerState* Ptr) { return Ptr->bFromPreviousLevel; }
	DOTNET_EXPORT void E_PROP_APlayerState_bFromPreviousLevel_SET(APlayerState* Ptr, uint8 Value) { Ptr->bFromPreviousLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bHasBeenWelcomed_GET(APlayerState* Ptr) { return Ptr->bHasBeenWelcomed; }
	DOTNET_EXPORT void E_PROP_APlayerState_bHasBeenWelcomed_SET(APlayerState* Ptr, uint8 Value) { Ptr->bHasBeenWelcomed = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bIsABot_GET(APlayerState* Ptr) { return Ptr->bIsABot; }
	DOTNET_EXPORT void E_PROP_APlayerState_bIsABot_SET(APlayerState* Ptr, uint8 Value) { Ptr->bIsABot = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bIsInactive_GET(APlayerState* Ptr) { return Ptr->bIsInactive; }
	DOTNET_EXPORT void E_PROP_APlayerState_bIsInactive_SET(APlayerState* Ptr, uint8 Value) { Ptr->bIsInactive = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bIsSpectator_GET(APlayerState* Ptr) { return Ptr->bIsSpectator; }
	DOTNET_EXPORT void E_PROP_APlayerState_bIsSpectator_SET(APlayerState* Ptr, uint8 Value) { Ptr->bIsSpectator = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bOnlySpectator_GET(APlayerState* Ptr) { return Ptr->bOnlySpectator; }
	DOTNET_EXPORT void E_PROP_APlayerState_bOnlySpectator_SET(APlayerState* Ptr, uint8 Value) { Ptr->bOnlySpectator = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_bUseCustomPlayerNames_GET(APlayerState* Ptr) { return Ptr->bUseCustomPlayerNames; }
	DOTNET_EXPORT void E_PROP_APlayerState_bUseCustomPlayerNames_SET(APlayerState* Ptr, uint8 Value) { Ptr->bUseCustomPlayerNames = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_ExactPing_GET(APlayerState* Ptr) { return Ptr->ExactPing; }
	DOTNET_EXPORT void E_PROP_APlayerState_ExactPing_SET(APlayerState* Ptr, float Value) { Ptr->ExactPing = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_ExactPingV2_GET(APlayerState* Ptr) { return Ptr->ExactPingV2; }
	DOTNET_EXPORT void E_PROP_APlayerState_ExactPingV2_SET(APlayerState* Ptr, float Value) { Ptr->ExactPingV2 = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_OldName_GET(APlayerState* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldName); }
	DOTNET_EXPORT void E_PROP_APlayerState_OldName_SET(APlayerState* Ptr, char* Value) { Ptr->OldName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_Ping_GET(APlayerState* Ptr) { return Ptr->Ping; }
	DOTNET_EXPORT void E_PROP_APlayerState_Ping_SET(APlayerState* Ptr, uint8 Value) { Ptr->Ping = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_PlayerId_GET(APlayerState* Ptr) { return Ptr->PlayerId; }
	DOTNET_EXPORT void E_PROP_APlayerState_PlayerId_SET(APlayerState* Ptr, int32 Value) { Ptr->PlayerId = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_PlayerName_GET(APlayerState* Ptr) { return ConvertToManage_StringWrapper(Ptr->PlayerName); }
	DOTNET_EXPORT void E_PROP_APlayerState_PlayerName_SET(APlayerState* Ptr, char* Value) { Ptr->PlayerName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_SavedNetworkAddress_GET(APlayerState* Ptr) { return ConvertToManage_StringWrapper(Ptr->SavedNetworkAddress); }
	DOTNET_EXPORT void E_PROP_APlayerState_SavedNetworkAddress_SET(APlayerState* Ptr, char* Value) { Ptr->SavedNetworkAddress = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_Score_GET(APlayerState* Ptr) { return Ptr->Score; }
	DOTNET_EXPORT void E_PROP_APlayerState_Score_SET(APlayerState* Ptr, float Value) { Ptr->Score = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_SessionName_GET(APlayerState* Ptr) { return ConvertToManage_StringWrapper(Ptr->SessionName); }
	DOTNET_EXPORT void E_PROP_APlayerState_SessionName_SET(APlayerState* Ptr, char* Value) { Ptr->SessionName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_APlayerState_StartTime_GET(APlayerState* Ptr) { return Ptr->StartTime; }
	DOTNET_EXPORT void E_PROP_APlayerState_StartTime_SET(APlayerState* Ptr, int32 Value) { Ptr->StartTime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APlayerState(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APlayerState>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_APlayerState_ClientInitialize(APlayerState* Self, AController* C)
	{
		auto _p0 = C;
		Self->APlayerState::ClientInitialize(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_CopyProperties(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->APlayerState::CopyProperties_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_DispatchCopyProperties(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->DispatchCopyProperties(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_DispatchOverrideWith(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		Self->DispatchOverrideWith(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_Duplicate(APlayerState* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->Duplicate());
	}

	DOTNET_EXPORT auto E_APlayerState_GetOldPlayerName(APlayerState* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetOldPlayerName());
	}

	DOTNET_EXPORT auto E_APlayerState_GetPawn(APlayerState* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawn());
	}

	DOTNET_EXPORT auto E_APlayerState_GetPlayerName(APlayerState* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetPlayerName());
	}

	DOTNET_EXPORT auto E_APlayerState_GetPlayerNameCustom(APlayerState* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetPlayerNameCustom());
	}

	DOTNET_EXPORT auto E_APlayerState_HandleWelcomeMessage(APlayerState* Self)
	{
		((E_PROTECTED_WRAP_APlayerState*)Self)->APlayerState::HandleWelcomeMessage_WRAP();
	}

	DOTNET_EXPORT auto E_APlayerState_IsPrimaryPlayer(APlayerState* Self)
	{
		return Self->IsPrimaryPlayer();
	}

	DOTNET_EXPORT auto E_APlayerState_OnDeactivated(APlayerState* Self)
	{
		Self->APlayerState::OnDeactivated();
	}

	DOTNET_EXPORT auto E_APlayerState_OnReactivated(APlayerState* Self)
	{
		Self->APlayerState::OnReactivated();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_bIsInactive(APlayerState* Self)
	{
		Self->APlayerState::OnRep_bIsInactive();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_PlayerId(APlayerState* Self)
	{
		Self->APlayerState::OnRep_PlayerId();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_PlayerName(APlayerState* Self)
	{
		Self->APlayerState::OnRep_PlayerName();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_Score(APlayerState* Self)
	{
		Self->APlayerState::OnRep_Score();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_UniqueId(APlayerState* Self)
	{
		Self->APlayerState::OnRep_UniqueId();
	}

	DOTNET_EXPORT auto E_APlayerState_OverrideWith(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->APlayerState::OverrideWith_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_RecalculateAvgPing(APlayerState* Self)
	{
		Self->APlayerState::RecalculateAvgPing();
	}

	DOTNET_EXPORT auto E_APlayerState_ReceiveCopyProperties(APlayerState* Self, APlayerState* NewPlayerState)
	{
		auto _p0 = NewPlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->ReceiveCopyProperties_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_ReceiveOverrideWith(APlayerState* Self, APlayerState* OldPlayerState)
	{
		auto _p0 = OldPlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->ReceiveOverrideWith_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_RegisterPlayerWithSession(APlayerState* Self, bool bWasFromInvite)
	{
		auto _p0 = bWasFromInvite;
		Self->APlayerState::RegisterPlayerWithSession(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SeamlessTravelTo(APlayerState* Self, APlayerState* NewPlayerState)
	{
		auto _p0 = NewPlayerState;
		Self->APlayerState::SeamlessTravelTo(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetOldPlayerName(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->APlayerState::SetOldPlayerName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetPlayerName(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->APlayerState::SetPlayerName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetPlayerNameInternal(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->APlayerState::SetPlayerNameInternal(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetShouldUpdateReplicatedPing(APlayerState* Self, bool bInShouldUpdateReplicatedPing)
	{
		auto _p0 = bInShouldUpdateReplicatedPing;
		((E_PROTECTED_WRAP_APlayerState*)Self)->SetShouldUpdateReplicatedPing_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_ShouldBroadCastWelcomeMessage(APlayerState* Self, bool bExiting)
	{
		auto _p0 = bExiting;
		return Self->ShouldBroadCastWelcomeMessage(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_UnregisterPlayerWithSession(APlayerState* Self)
	{
		Self->APlayerState::UnregisterPlayerWithSession();
	}

	DOTNET_EXPORT auto E_APlayerState_UpdatePing(APlayerState* Self, float InPing)
	{
		auto _p0 = InPing;
		Self->APlayerState::UpdatePing(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
