// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePlayerController.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:237

AManagePlayerController::AManagePlayerController(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManagePlayerController::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManagePlayerController::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManagePlayerController::AddPitchInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddPitchInput", Val);
	else
		Super::AddPitchInput(Val);
}

void AManagePlayerController::_Supper__AddPitchInput(float Val)
{
	Super::AddPitchInput(Val);
}

void AManagePlayerController::AddRollInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRollInput", Val);
	else
		Super::AddRollInput(Val);
}

void AManagePlayerController::_Supper__AddRollInput(float Val)
{
	Super::AddRollInput(Val);
}

void AManagePlayerController::AddYawInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddYawInput", Val);
	else
		Super::AddYawInput(Val);
}

void AManagePlayerController::_Supper__AddYawInput(float Val)
{
	Super::AddYawInput(Val);
}

void AManagePlayerController::BeginPlayingState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlayingState");
	else
		Super::BeginPlayingState();
}

void AManagePlayerController::_Supper__BeginPlayingState()
{
	Super::BeginPlayingState();
}

void AManagePlayerController::ClientClearCameraLensEffects()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientClearCameraLensEffects");
	else
		Super::ClientClearCameraLensEffects();
}

void AManagePlayerController::_Supper__ClientClearCameraLensEffects()
{
	Super::ClientClearCameraLensEffects();
}

void AManagePlayerController::ClientEnableNetworkVoice(bool bEnable)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientEnableNetworkVoice", bEnable);
	else
		Super::ClientEnableNetworkVoice(bEnable);
}

void AManagePlayerController::_Supper__ClientEnableNetworkVoice(bool bEnable)
{
	Super::ClientEnableNetworkVoice(bEnable);
}

void AManagePlayerController::ClientVoiceHandshakeComplete()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientVoiceHandshakeComplete");
	else
		Super::ClientVoiceHandshakeComplete();
}

void AManagePlayerController::_Supper__ClientVoiceHandshakeComplete()
{
	Super::ClientVoiceHandshakeComplete();
}

void AManagePlayerController::DelayedPrepareMapChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DelayedPrepareMapChange");
	else
		Super::DelayedPrepareMapChange();
}

void AManagePlayerController::_Supper__DelayedPrepareMapChange()
{
	Super::DelayedPrepareMapChange();
}

void AManagePlayerController::EnableCheats()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableCheats");
	else
		Super::EnableCheats();
}

void AManagePlayerController::_Supper__EnableCheats()
{
	Super::EnableCheats();
}

void AManagePlayerController::EndPlayingState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndPlayingState");
	else
		Super::EndPlayingState();
}

void AManagePlayerController::_Supper__EndPlayingState()
{
	Super::EndPlayingState();
}

void AManagePlayerController::FOV(float NewFOV)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FOV", NewFOV);
	else
		Super::FOV(NewFOV);
}

void AManagePlayerController::_Supper__FOV(float NewFOV)
{
	Super::FOV(NewFOV);
}

void AManagePlayerController::Pause()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Pause");
	else
		Super::Pause();
}

void AManagePlayerController::_Supper__Pause()
{
	Super::Pause();
}

void AManagePlayerController::PlayerTick(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PlayerTick", DeltaTime);
	else
		Super::PlayerTick(DeltaTime);
}

void AManagePlayerController::_Supper__PlayerTick(float DeltaTime)
{
	Super::PlayerTick(DeltaTime);
}

void AManagePlayerController::PostProcessInput(const float DeltaTime, const bool bGamePaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostProcessInput", DeltaTime, bGamePaused);
	else
		Super::PostProcessInput(DeltaTime, bGamePaused);
}

void AManagePlayerController::_Supper__PostProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PostProcessInput(DeltaTime, bGamePaused);
}

void AManagePlayerController::PostSeamlessTravel()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSeamlessTravel");
	else
		Super::PostSeamlessTravel();
}

void AManagePlayerController::_Supper__PostSeamlessTravel()
{
	Super::PostSeamlessTravel();
}

void AManagePlayerController::PreProcessInput(const float DeltaTime, const bool bGamePaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreProcessInput", DeltaTime, bGamePaused);
	else
		Super::PreProcessInput(DeltaTime, bGamePaused);
}

void AManagePlayerController::_Supper__PreProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PreProcessInput(DeltaTime, bGamePaused);
}

void AManagePlayerController::RestartLevel()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartLevel");
	else
		Super::RestartLevel();
}

void AManagePlayerController::_Supper__RestartLevel()
{
	Super::RestartLevel();
}

void AManagePlayerController::SafeRetryClientRestart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SafeRetryClientRestart");
	else
		Super::SafeRetryClientRestart();
}

void AManagePlayerController::_Supper__SafeRetryClientRestart()
{
	Super::SafeRetryClientRestart();
}

void AManagePlayerController::SafeServerCheckClientPossession()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SafeServerCheckClientPossession");
	else
		Super::SafeServerCheckClientPossession();
}

void AManagePlayerController::_Supper__SafeServerCheckClientPossession()
{
	Super::SafeServerCheckClientPossession();
}

void AManagePlayerController::SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCinematicMode", bInCinematicMode, bAffectsMovement, bAffectsTurning);
	else
		Super::SetCinematicMode(bInCinematicMode, bAffectsMovement, bAffectsTurning);
}

void AManagePlayerController::_Supper__SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
{
	Super::SetCinematicMode(bInCinematicMode, bAffectsMovement, bAffectsTurning);
}

void AManagePlayerController::SetDisableHaptics(bool bNewDisabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetDisableHaptics", bNewDisabled);
	else
		Super::SetDisableHaptics(bNewDisabled);
}

void AManagePlayerController::_Supper__SetDisableHaptics(bool bNewDisabled)
{
	Super::SetDisableHaptics(bNewDisabled);
}

void AManagePlayerController::SetVirtualJoystickVisibility(bool bVisible)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetVirtualJoystickVisibility", bVisible);
	else
		Super::SetVirtualJoystickVisibility(bVisible);
}

void AManagePlayerController::_Supper__SetVirtualJoystickVisibility(bool bVisible)
{
	Super::SetVirtualJoystickVisibility(bVisible);
}

void AManagePlayerController::StartFire(uint8 FireModeNum)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartFire", FireModeNum);
	else
		Super::StartFire(FireModeNum);
}

void AManagePlayerController::_Supper__StartFire(uint8 FireModeNum)
{
	Super::StartFire(FireModeNum);
}

void AManagePlayerController::ToggleSpeaking(bool bInSpeaking)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleSpeaking", bInSpeaking);
	else
		Super::ToggleSpeaking(bInSpeaking);
}

void AManagePlayerController::_Supper__ToggleSpeaking(bool bInSpeaking)
{
	Super::ToggleSpeaking(bInSpeaking);
}

void AManagePlayerController::UnFreeze()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnFreeze");
	else
		Super::UnFreeze();
}

void AManagePlayerController::_Supper__UnFreeze()
{
	Super::UnFreeze();
}

void AManagePlayerController::UpdateRotation(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateRotation", DeltaTime);
	else
		Super::UpdateRotation(DeltaTime);
}

void AManagePlayerController::_Supper__UpdateRotation(float DeltaTime)
{
	Super::UpdateRotation(DeltaTime);
}

void AManagePlayerController::BeginInactiveState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginInactiveState");
	else
		Super::BeginInactiveState();
}

void AManagePlayerController::_Supper__BeginInactiveState()
{
	Super::BeginInactiveState();
}

void AManagePlayerController::CleanupPlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CleanupPlayerState");
	else
		Super::CleanupPlayerState();
}

void AManagePlayerController::_Supper__CleanupPlayerState()
{
	Super::CleanupPlayerState();
}

void AManagePlayerController::CurrentLevelUnloaded()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CurrentLevelUnloaded");
	else
		Super::CurrentLevelUnloaded();
}

void AManagePlayerController::_Supper__CurrentLevelUnloaded()
{
	Super::CurrentLevelUnloaded();
}

void AManagePlayerController::DetachFromPawn()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromPawn");
	else
		Super::DetachFromPawn();
}

void AManagePlayerController::_Supper__DetachFromPawn()
{
	Super::DetachFromPawn();
}

void AManagePlayerController::EndInactiveState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndInactiveState");
	else
		Super::EndInactiveState();
}

void AManagePlayerController::_Supper__EndInactiveState()
{
	Super::EndInactiveState();
}

void AManagePlayerController::FailedToSpawnPawn()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FailedToSpawnPawn");
	else
		Super::FailedToSpawnPawn();
}

void AManagePlayerController::_Supper__FailedToSpawnPawn()
{
	Super::FailedToSpawnPawn();
}

void AManagePlayerController::InitPlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitPlayerState");
	else
		Super::InitPlayerState();
}

void AManagePlayerController::_Supper__InitPlayerState()
{
	Super::InitPlayerState();
}

void AManagePlayerController::OnRep_Pawn()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Pawn");
	else
		Super::OnRep_Pawn();
}

void AManagePlayerController::_Supper__OnRep_Pawn()
{
	Super::OnRep_Pawn();
}

void AManagePlayerController::OnRep_PlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
	else
		Super::OnRep_PlayerState();
}

void AManagePlayerController::_Supper__OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
}

void AManagePlayerController::OnUnPossess()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnPossess");
	else
		Super::OnUnPossess();
}

void AManagePlayerController::_Supper__OnUnPossess()
{
	Super::OnUnPossess();
}

void AManagePlayerController::ResetIgnoreInputFlags()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreInputFlags");
	else
		Super::ResetIgnoreInputFlags();
}

void AManagePlayerController::_Supper__ResetIgnoreInputFlags()
{
	Super::ResetIgnoreInputFlags();
}

void AManagePlayerController::ResetIgnoreLookInput()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreLookInput");
	else
		Super::ResetIgnoreLookInput();
}

void AManagePlayerController::_Supper__ResetIgnoreLookInput()
{
	Super::ResetIgnoreLookInput();
}

void AManagePlayerController::ResetIgnoreMoveInput()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreMoveInput");
	else
		Super::ResetIgnoreMoveInput();
}

void AManagePlayerController::_Supper__ResetIgnoreMoveInput()
{
	Super::ResetIgnoreMoveInput();
}

void AManagePlayerController::SetIgnoreLookInput(bool bNewLookInput)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetIgnoreLookInput", bNewLookInput);
	else
		Super::SetIgnoreLookInput(bNewLookInput);
}

void AManagePlayerController::_Supper__SetIgnoreLookInput(bool bNewLookInput)
{
	Super::SetIgnoreLookInput(bNewLookInput);
}

void AManagePlayerController::SetIgnoreMoveInput(bool bNewMoveInput)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetIgnoreMoveInput", bNewMoveInput);
	else
		Super::SetIgnoreMoveInput(bNewMoveInput);
}

void AManagePlayerController::_Supper__SetIgnoreMoveInput(bool bNewMoveInput)
{
	Super::SetIgnoreMoveInput(bNewMoveInput);
}

void AManagePlayerController::StopMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovement");
	else
		Super::StopMovement();
}

void AManagePlayerController::_Supper__StopMovement()
{
	Super::StopMovement();
}

void AManagePlayerController::UpdateNavigationComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationComponents");
	else
		Super::UpdateNavigationComponents();
}

void AManagePlayerController::_Supper__UpdateNavigationComponents()
{
	Super::UpdateNavigationComponents();
}

void AManagePlayerController::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManagePlayerController::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManagePlayerController::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManagePlayerController::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManagePlayerController::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManagePlayerController::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManagePlayerController::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManagePlayerController::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManagePlayerController::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManagePlayerController::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManagePlayerController::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManagePlayerController::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManagePlayerController::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManagePlayerController::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManagePlayerController::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManagePlayerController::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManagePlayerController::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManagePlayerController::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManagePlayerController::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManagePlayerController::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManagePlayerController::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManagePlayerController::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManagePlayerController::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManagePlayerController::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManagePlayerController::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManagePlayerController::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManagePlayerController::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManagePlayerController::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManagePlayerController::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManagePlayerController::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManagePlayerController::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManagePlayerController::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManagePlayerController::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManagePlayerController::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManagePlayerController::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManagePlayerController::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManagePlayerController::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManagePlayerController::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManagePlayerController::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManagePlayerController::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManagePlayerController::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManagePlayerController::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManagePlayerController::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManagePlayerController::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManagePlayerController::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManagePlayerController::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManagePlayerController::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManagePlayerController::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManagePlayerController::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManagePlayerController::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManagePlayerController::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManagePlayerController::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManagePlayerController::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManagePlayerController::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManagePlayerController::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManagePlayerController::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManagePlayerController::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManagePlayerController::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManagePlayerController::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManagePlayerController::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManagePlayerController::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManagePlayerController::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManagePlayerController::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManagePlayerController::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManagePlayerController::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManagePlayerController::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManagePlayerController::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManagePlayerController::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManagePlayerController::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManagePlayerController::_Supper__Reset()
{
	Super::Reset();
}

void AManagePlayerController::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManagePlayerController::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManagePlayerController::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManagePlayerController::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManagePlayerController::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManagePlayerController::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManagePlayerController::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManagePlayerController::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManagePlayerController::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManagePlayerController::_Supper__TearOff()
{
	Super::TearOff();
}

void AManagePlayerController::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManagePlayerController::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManagePlayerController::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManagePlayerController::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManagePlayerController::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManagePlayerController::_Supper__TornOff()
{
	Super::TornOff();
}

void AManagePlayerController::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManagePlayerController::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManagePlayerController::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManagePlayerController::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManagePlayerController::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManagePlayerController::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManagePlayerController::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManagePlayerController::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManagePlayerController::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManagePlayerController::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManagePlayerController::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManagePlayerController::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManagePlayerController::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManagePlayerController::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManagePlayerController::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManagePlayerController::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManagePlayerController::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManagePlayerController::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManagePlayerController::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManagePlayerController::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManagePlayerController::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManagePlayerController::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManagePlayerController::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManagePlayerController::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManagePlayerController::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManagePlayerController::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManagePlayerController::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManagePlayerController::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManagePlayerController::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManagePlayerController::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManagePlayerController::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManagePlayerController::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
