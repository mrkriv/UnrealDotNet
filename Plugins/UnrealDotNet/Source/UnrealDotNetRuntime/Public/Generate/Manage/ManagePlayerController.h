#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/GameFramework/PlayerController.h"
#include "ManagePlayerController.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:237

UCLASS()
class UNREALDOTNETRUNTIME_API AManagePlayerController : public APlayerController, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddPitchInput(float Val) override;
	virtual void AddRollInput(float Val) override;
	virtual void AddYawInput(float Val) override;
	virtual void BeginPlayingState() override;
	virtual void ClientClearCameraLensEffects() override;
	virtual void ClientEnableNetworkVoice(bool bEnable) override;
	virtual void ClientVoiceHandshakeComplete() override;
	virtual void DelayedPrepareMapChange() override;
	virtual void EnableCheats() override;
	virtual void EndPlayingState() override;
	virtual void FOV(float NewFOV) override;
	virtual void Pause() override;
	virtual void PlayerTick(float DeltaTime) override;
	virtual void PostProcessInput(const float DeltaTime, const bool bGamePaused) override;
	virtual void PostSeamlessTravel() override;
	virtual void PreProcessInput(const float DeltaTime, const bool bGamePaused) override;
	virtual void RestartLevel() override;
	virtual void SafeRetryClientRestart() override;
	virtual void SafeServerCheckClientPossession() override;
	virtual void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning) override;
	virtual void SetDisableHaptics(bool bNewDisabled) override;
	virtual void SetVirtualJoystickVisibility(bool bVisible) override;
	virtual void StartFire(uint8 FireModeNum) override;
	virtual void ToggleSpeaking(bool bInSpeaking) override;
	virtual void UnFreeze() override;
	virtual void UpdateRotation(float DeltaTime) override;
	virtual void BeginInactiveState() override;
	virtual void CleanupPlayerState() override;
	virtual void CurrentLevelUnloaded() override;
	virtual void DetachFromPawn() override;
	virtual void EndInactiveState() override;
	virtual void FailedToSpawnPawn() override;
	virtual void InitPlayerState() override;
	virtual void OnRep_Pawn() override;
	virtual void OnRep_PlayerState() override;
	virtual void OnUnPossess() override;
	virtual void ResetIgnoreInputFlags() override;
	virtual void ResetIgnoreLookInput() override;
	virtual void ResetIgnoreMoveInput() override;
	virtual void SetIgnoreLookInput(bool bNewLookInput) override;
	virtual void SetIgnoreMoveInput(bool bNewMoveInput) override;
	virtual void StopMovement() override;
	virtual void UpdateNavigationComponents() override;
	virtual void BeginPlay() override;
	virtual void ClearCrossLevelReferences() override;
	virtual void Destroyed() override;
	virtual void ForceNetRelevant() override;
	virtual void ForceNetUpdate() override;
	virtual void GatherCurrentMovement() override;
	virtual void InvalidateLightingCacheDetailed(bool bTranslationOnly) override;
	virtual void K2_DestroyActor() override;
	virtual void LifeSpanExpired() override;
	virtual void MarkComponentsAsPendingKill() override;
	virtual void NotifyActorBeginCursorOver() override;
	virtual void NotifyActorEndCursorOver() override;
	virtual void OnRep_AttachmentReplication() override;
	virtual void OnRep_Instigator() override;
	virtual void OnRep_Owner() override;
	virtual void OnRep_ReplicatedMovement() override;
	virtual void OnRep_ReplicateMovement() override;
	virtual void OnReplicationPausedChanged(bool bIsReplicationPaused) override;
	virtual void OutsideWorldBounds() override;
	virtual void PostActorCreated() override;
	virtual void PostInitializeComponents() override;
	virtual void PostNetInit() override;
	virtual void PostNetReceiveLocationAndRotation() override;
	virtual void PostNetReceivePhysicState() override;
	virtual void PostNetReceiveRole() override;
	virtual void PostRegisterAllComponents() override;
	virtual void PostUnregisterAllComponents() override;
	virtual void PreInitializeComponents() override;
	virtual void PreRegisterAllComponents() override;
	virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups) override;
	virtual void RegisterActorTickFunctions(bool bRegister) override;
	virtual void RegisterAllComponents() override;
	virtual void ReregisterAllComponents() override;
	virtual void RerunConstructionScripts() override;
	virtual void Reset() override;
	virtual void RewindForReplay() override;
	virtual void SetActorHiddenInGame(bool bNewHidden) override;
	virtual void SetLifeSpan(float InLifespan) override;
	virtual void SetReplicateMovement(bool bInReplicateMovement) override;
	virtual void TearOff() override;
	virtual void TeleportSucceeded(bool bIsATest) override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void TornOff() override;
	virtual void UnregisterAllComponents(bool bForReregister) override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__AddPitchInput(float Val);
	void _Supper__AddRollInput(float Val);
	void _Supper__AddYawInput(float Val);
	void _Supper__BeginPlayingState();
	void _Supper__ClientClearCameraLensEffects();
	void _Supper__ClientEnableNetworkVoice(bool bEnable);
	void _Supper__ClientVoiceHandshakeComplete();
	void _Supper__DelayedPrepareMapChange();
	void _Supper__EnableCheats();
	void _Supper__EndPlayingState();
	void _Supper__FOV(float NewFOV);
	void _Supper__Pause();
	void _Supper__PlayerTick(float DeltaTime);
	void _Supper__PostProcessInput(const float DeltaTime, const bool bGamePaused);
	void _Supper__PostSeamlessTravel();
	void _Supper__PreProcessInput(const float DeltaTime, const bool bGamePaused);
	void _Supper__RestartLevel();
	void _Supper__SafeRetryClientRestart();
	void _Supper__SafeServerCheckClientPossession();
	void _Supper__SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning);
	void _Supper__SetDisableHaptics(bool bNewDisabled);
	void _Supper__SetVirtualJoystickVisibility(bool bVisible);
	void _Supper__StartFire(uint8 FireModeNum);
	void _Supper__ToggleSpeaking(bool bInSpeaking);
	void _Supper__UnFreeze();
	void _Supper__UpdateRotation(float DeltaTime);
	void _Supper__BeginInactiveState();
	void _Supper__CleanupPlayerState();
	void _Supper__CurrentLevelUnloaded();
	void _Supper__DetachFromPawn();
	void _Supper__EndInactiveState();
	void _Supper__FailedToSpawnPawn();
	void _Supper__InitPlayerState();
	void _Supper__OnRep_Pawn();
	void _Supper__OnRep_PlayerState();
	void _Supper__OnUnPossess();
	void _Supper__ResetIgnoreInputFlags();
	void _Supper__ResetIgnoreLookInput();
	void _Supper__ResetIgnoreMoveInput();
	void _Supper__SetIgnoreLookInput(bool bNewLookInput);
	void _Supper__SetIgnoreMoveInput(bool bNewMoveInput);
	void _Supper__StopMovement();
	void _Supper__UpdateNavigationComponents();
	void _Supper__BeginPlay();
	void _Supper__ClearCrossLevelReferences();
	void _Supper__Destroyed();
	void _Supper__ForceNetRelevant();
	void _Supper__ForceNetUpdate();
	void _Supper__GatherCurrentMovement();
	void _Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly);
	void _Supper__K2_DestroyActor();
	void _Supper__LifeSpanExpired();
	void _Supper__MarkComponentsAsPendingKill();
	void _Supper__NotifyActorBeginCursorOver();
	void _Supper__NotifyActorEndCursorOver();
	void _Supper__OnRep_AttachmentReplication();
	void _Supper__OnRep_Instigator();
	void _Supper__OnRep_Owner();
	void _Supper__OnRep_ReplicatedMovement();
	void _Supper__OnRep_ReplicateMovement();
	void _Supper__OnReplicationPausedChanged(bool bIsReplicationPaused);
	void _Supper__OutsideWorldBounds();
	void _Supper__PostActorCreated();
	void _Supper__PostInitializeComponents();
	void _Supper__PostNetInit();
	void _Supper__PostNetReceiveLocationAndRotation();
	void _Supper__PostNetReceivePhysicState();
	void _Supper__PostNetReceiveRole();
	void _Supper__PostRegisterAllComponents();
	void _Supper__PostUnregisterAllComponents();
	void _Supper__PreInitializeComponents();
	void _Supper__PreRegisterAllComponents();
	void _Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups);
	void _Supper__RegisterActorTickFunctions(bool bRegister);
	void _Supper__RegisterAllComponents();
	void _Supper__ReregisterAllComponents();
	void _Supper__RerunConstructionScripts();
	void _Supper__Reset();
	void _Supper__RewindForReplay();
	void _Supper__SetActorHiddenInGame(bool bNewHidden);
	void _Supper__SetLifeSpan(float InLifespan);
	void _Supper__SetReplicateMovement(bool bInReplicateMovement);
	void _Supper__TearOff();
	void _Supper__TeleportSucceeded(bool bIsATest);
	void _Supper__Tick(float DeltaSeconds);
	void _Supper__TornOff();
	void _Supper__UnregisterAllComponents(bool bForReregister);
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
