#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageAIController.h"
#include "Runtime/AIModule/Classes/AIController.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AIController.h:85

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AAIController_bAIIgnorePlayers_GET() { return AAIController::bAIIgnorePlayers; }
	
	DOTNET_EXPORT auto E_PROP_AAIController_BrainComponent_GET(AAIController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->BrainComponent); }
	DOTNET_EXPORT void E_PROP_AAIController_BrainComponent_SET(AAIController* Ptr, UBrainComponent* Value) { Ptr->BrainComponent = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AAIController(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AAIController>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AAIController_AreAIIgnoringPlayers(AAIController* Self)
	{
		return Self->AreAIIgnoringPlayers();
	}

	DOTNET_EXPORT auto E_AAIController_GetActionsComp(AAIController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetActionsComp());
	}

	DOTNET_EXPORT auto E_AAIController_GetBrainComponent(AAIController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetBrainComponent());
	}

	DOTNET_EXPORT auto E_AAIController_GetCurrentMoveRequestID(AAIController* Self)
	{
		return (INT_PTR) new FAIRequestID(Self->GetCurrentMoveRequestID());
	}

	DOTNET_EXPORT auto E_AAIController_GetDebugIcon(AAIController* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDebugIcon());
	}

	DOTNET_EXPORT auto E_AAIController_GetFocalPoint(AAIController* Self)
	{
		return (INT_PTR) new FVector(Self->GetFocalPoint());
	}

	DOTNET_EXPORT auto E_AAIController_GetFocalPointOnActor(AAIController* Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return (INT_PTR) new FVector(Self->GetFocalPointOnActor(_p0));
	}

	DOTNET_EXPORT auto E_AAIController_GetFocusActor(AAIController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetFocusActor());
	}

	DOTNET_EXPORT auto E_AAIController_GetGameplayTaskDefaultPriority(AAIController* Self)
	{
		return Self->GetGameplayTaskDefaultPriority();
	}

	DOTNET_EXPORT auto E_AAIController_GetImmediateMoveDestination(AAIController* Self)
	{
		return (INT_PTR) new FVector(Self->GetImmediateMoveDestination());
	}

	DOTNET_EXPORT auto E_AAIController_HasPartialPath(AAIController* Self)
	{
		return Self->HasPartialPath();
	}

	DOTNET_EXPORT auto E_AAIController_K2_ClearFocus(AAIController* Self)
	{
		Self->K2_ClearFocus();
	}

	DOTNET_EXPORT auto E_AAIController_K2_SetFocalPoint(AAIController* Self, INT_PTR FP)
	{
		auto _p0 = *(FVector*)FP;
		Self->K2_SetFocalPoint(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_K2_SetFocus(AAIController* Self, AActor* NewFocus)
	{
		auto _p0 = NewFocus;
		Self->K2_SetFocus(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_PauseMove(AAIController* Self, INT_PTR RequestToPause)
	{
		auto _p0 = *(FAIRequestID*)RequestToPause;
		return Self->PauseMove(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_ResumeMove(AAIController* Self, INT_PTR RequestToResume)
	{
		auto _p0 = *(FAIRequestID*)RequestToResume;
		return Self->ResumeMove(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_SetFocalPoint(AAIController* Self, INT_PTR NewFocus)
	{
		auto _p0 = *(FVector*)NewFocus;
		Self->SetFocalPoint(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_SetFocus(AAIController* Self, AActor* NewFocus)
	{
		auto _p0 = NewFocus;
		Self->SetFocus(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_SetMoveBlockDetection(AAIController* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetMoveBlockDetection(_p0);
	}

	DOTNET_EXPORT auto E_AAIController_SuggestTossVelocity(AAIController* Self, INT_PTR OutTossVelocity, INT_PTR Start, INT_PTR End, float TossSpeed, bool bPreferHighArc, float CollisionRadius, bool bOnlyTraceUp)
	{
		auto& _p0 = *(FVector*)OutTossVelocity;
		auto _p1 = *(FVector*)Start;
		auto _p2 = *(FVector*)End;
		auto _p3 = TossSpeed;
		auto _p4 = bPreferHighArc;
		auto _p5 = CollisionRadius;
		auto _p6 = bOnlyTraceUp;
		return Self->SuggestTossVelocity(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_AAIController_ToggleAIIgnorePlayers(AAIController* Self)
	{
		Self->ToggleAIIgnorePlayers();
	}

	DOTNET_EXPORT auto E_AAIController_UpdateControlRotation(AAIController* Self, float DeltaTime, bool bUpdatePawn)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bUpdatePawn;
		Self->UpdateControlRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_UpdateControlRotation(AAIController* Self, float DeltaTime, bool bUpdatePawn)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bUpdatePawn;
		((AManageAIController*)Self)->_Supper__UpdateControlRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_BeginInactiveState(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__BeginInactiveState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_CleanupPlayerState(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__CleanupPlayerState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_CurrentLevelUnloaded(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__CurrentLevelUnloaded();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_DetachFromPawn(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__DetachFromPawn();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_EndInactiveState(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__EndInactiveState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_FailedToSpawnPawn(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__FailedToSpawnPawn();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_InitPlayerState(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__InitPlayerState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_Pawn(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_Pawn();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_PlayerState(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnUnPossess(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__OnUnPossess();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ResetIgnoreInputFlags(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__ResetIgnoreInputFlags();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ResetIgnoreLookInput(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__ResetIgnoreLookInput();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ResetIgnoreMoveInput(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__ResetIgnoreMoveInput();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_SetIgnoreLookInput(AController* Self, bool bNewLookInput)
	{
		auto _p0 = bNewLookInput;
		((AManageAIController*)Self)->_Supper__SetIgnoreLookInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_SetIgnoreMoveInput(AController* Self, bool bNewMoveInput)
	{
		auto _p0 = bNewMoveInput;
		((AManageAIController*)Self)->_Supper__SetIgnoreMoveInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_StopMovement(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__StopMovement();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_UpdateNavigationComponents(AController* Self)
	{
		((AManageAIController*)Self)->_Supper__UpdateNavigationComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_BeginPlay(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_Destroyed(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ForceNetRelevant(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ForceNetUpdate(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_GatherCurrentMovement(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageAIController*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_K2_DestroyActor(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_LifeSpanExpired(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_Instigator(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_Owner(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageAIController*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OutsideWorldBounds(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostActorCreated(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostInitializeComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostNetInit(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostNetReceiveRole(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostRegisterAllComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PreInitializeComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PreRegisterAllComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageAIController*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageAIController*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_RegisterAllComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ReregisterAllComponents(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_RerunConstructionScripts(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_Reset(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_RewindForReplay(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageAIController*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageAIController*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageAIController*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_TearOff(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageAIController*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageAIController*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_TornOff(AActor* Self)
	{
		((AManageAIController*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageAIController*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_BeginDestroy(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_FinishDestroy(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostCDOContruct(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostEditImport(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostInitProperties(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostLoad(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostNetReceive(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostRepNotifies(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageAIController*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PreDestroyFromReplication(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_PreNetReceive(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_ShutdownAfterError(UObject* Self)
	{
		((AManageAIController*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageAIController*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AAIController_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageAIController*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
