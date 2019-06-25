#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePlayerState.h"
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
		Self->ClientInitialize(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_CopyProperties(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->CopyProperties_WRAP(_p0);
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
		((E_PROTECTED_WRAP_APlayerState*)Self)->HandleWelcomeMessage_WRAP();
	}

	DOTNET_EXPORT auto E_APlayerState_IsPrimaryPlayer(APlayerState* Self)
	{
		return Self->IsPrimaryPlayer();
	}

	DOTNET_EXPORT auto E_APlayerState_OnDeactivated(APlayerState* Self)
	{
		Self->OnDeactivated();
	}

	DOTNET_EXPORT auto E_APlayerState_OnReactivated(APlayerState* Self)
	{
		Self->OnReactivated();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_bIsInactive(APlayerState* Self)
	{
		Self->OnRep_bIsInactive();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_PlayerId(APlayerState* Self)
	{
		Self->OnRep_PlayerId();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_PlayerName(APlayerState* Self)
	{
		Self->OnRep_PlayerName();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_Score(APlayerState* Self)
	{
		Self->OnRep_Score();
	}

	DOTNET_EXPORT auto E_APlayerState_OnRep_UniqueId(APlayerState* Self)
	{
		Self->OnRep_UniqueId();
	}

	DOTNET_EXPORT auto E_APlayerState_OverrideWith(APlayerState* Self, APlayerState* PlayerState)
	{
		auto _p0 = PlayerState;
		((E_PROTECTED_WRAP_APlayerState*)Self)->OverrideWith_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_RecalculateAvgPing(APlayerState* Self)
	{
		Self->RecalculateAvgPing();
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
		Self->RegisterPlayerWithSession(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SeamlessTravelTo(APlayerState* Self, APlayerState* NewPlayerState)
	{
		auto _p0 = NewPlayerState;
		Self->SeamlessTravelTo(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetOldPlayerName(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->SetOldPlayerName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetPlayerName(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->SetPlayerName(_p0);
	}

	DOTNET_EXPORT auto E_APlayerState_SetPlayerNameInternal(APlayerState* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->SetPlayerNameInternal(_p0);
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
		Self->UnregisterPlayerWithSession();
	}

	DOTNET_EXPORT auto E_APlayerState_UpdatePing(APlayerState* Self, float InPing)
	{
		auto _p0 = InPing;
		Self->UpdatePing(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_HandleWelcomeMessage(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__HandleWelcomeMessage();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnDeactivated(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnDeactivated();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnReactivated(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnReactivated();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_bIsInactive(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_bIsInactive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_PlayerId(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_PlayerId();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_PlayerName(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_PlayerName();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_Score(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_Score();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_UniqueId(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_UniqueId();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RecalculateAvgPing(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__RecalculateAvgPing();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RegisterPlayerWithSession(APlayerState* Self, bool bWasFromInvite)
	{
		auto _p0 = bWasFromInvite;
		((AManagePlayerState*)Self)->_Supper__RegisterPlayerWithSession(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_UnregisterPlayerWithSession(APlayerState* Self)
	{
		((AManagePlayerState*)Self)->_Supper__UnregisterPlayerWithSession();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_UpdatePing(APlayerState* Self, float InPing)
	{
		auto _p0 = InPing;
		((AManagePlayerState*)Self)->_Supper__UpdatePing(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_BeginPlay(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_ClearCrossLevelReferences(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_Destroyed(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_ForceNetRelevant(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_ForceNetUpdate(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_GatherCurrentMovement(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManagePlayerState*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_K2_DestroyActor(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_LifeSpanExpired(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_Instigator(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_Owner(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManagePlayerState*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OutsideWorldBounds(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostActorCreated(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostInitializeComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostNetInit(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostNetReceivePhysicState(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostNetReceiveRole(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostUnregisterAllComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PreInitializeComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PreRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManagePlayerState*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManagePlayerState*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RegisterAllComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_ReregisterAllComponents(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RerunConstructionScripts(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_Reset(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_RewindForReplay(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManagePlayerState*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManagePlayerState*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManagePlayerState*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_TearOff(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManagePlayerState*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManagePlayerState*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_TornOff(AActor* Self)
	{
		((AManagePlayerState*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManagePlayerState*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_BeginDestroy(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_FinishDestroy(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostCDOContruct(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostEditImport(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostInitProperties(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostLoad(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostNetReceive(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostRepNotifies(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManagePlayerState*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PreDestroyFromReplication(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_PreNetReceive(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_ShutdownAfterError(UObject* Self)
	{
		((AManagePlayerState*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManagePlayerState*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__APlayerState_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManagePlayerState*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
