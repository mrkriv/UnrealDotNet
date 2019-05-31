// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

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

void AManagePlayerController::ActivateTouchInterface(UTouchInterface* NewTouchInterface)
{
	Super::ActivateTouchInterface(NewTouchInterface);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ActivateTouchInterface", NewTouchInterface);
}

void AManagePlayerController::AddPitchInput(float Val)
{
	Super::AddPitchInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddPitchInput", Val);
}

void AManagePlayerController::AddRollInput(float Val)
{
	Super::AddRollInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRollInput", Val);
}

void AManagePlayerController::AddYawInput(float Val)
{
	Super::AddYawInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddYawInput", Val);
}

void AManagePlayerController::BeginPlayingState()
{
	Super::BeginPlayingState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlayingState");
}

void AManagePlayerController::Camera(FName NewMode)
{
	Super::Camera(NewMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Camera", NewMode);
}

void AManagePlayerController::ClientClearCameraLensEffects()
{
	Super::ClientClearCameraLensEffects();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientClearCameraLensEffects");
}

void AManagePlayerController::ClientEnableNetworkVoice(bool bEnable)
{
	Super::ClientEnableNetworkVoice(bEnable);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientEnableNetworkVoice", bEnable);
}

void AManagePlayerController::ClientRepObjRef(UObject* Object)
{
	Super::ClientRepObjRef(Object);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientRepObjRef", Object);
}

void AManagePlayerController::ClientReturnToMainMenu(const FString& ReturnReason)
{
	Super::ClientReturnToMainMenu(ReturnReason);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientReturnToMainMenu", ReturnReason);
}

void AManagePlayerController::ClientReturnToMainMenuWithTextReason(const FText& ReturnReason)
{
	Super::ClientReturnToMainMenuWithTextReason(ReturnReason);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientReturnToMainMenuWithTextReason", ReturnReason);
}

void AManagePlayerController::ClientVoiceHandshakeComplete()
{
	Super::ClientVoiceHandshakeComplete();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientVoiceHandshakeComplete");
}

void AManagePlayerController::DelayedPrepareMapChange()
{
	Super::DelayedPrepareMapChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DelayedPrepareMapChange");
}

void AManagePlayerController::EnableCheats()
{
	Super::EnableCheats();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableCheats");
}

void AManagePlayerController::EndPlayingState()
{
	Super::EndPlayingState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndPlayingState");
}

void AManagePlayerController::FOV(float NewFOV)
{
	Super::FOV(NewFOV);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FOV", NewFOV);
}

void AManagePlayerController::LocalTravel(const FString& URL)
{
	Super::LocalTravel(URL);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LocalTravel", URL);
}

void AManagePlayerController::NotifyLoadedWorld(FName WorldPackageName, bool bFinalDest)
{
	Super::NotifyLoadedWorld(WorldPackageName, bFinalDest);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyLoadedWorld", WorldPackageName, bFinalDest);
}

void AManagePlayerController::Pause()
{
	Super::Pause();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Pause");
}

void AManagePlayerController::PlayerTick(float DeltaTime)
{
	Super::PlayerTick(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PlayerTick", DeltaTime);
}

void AManagePlayerController::PostProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PostProcessInput(DeltaTime, bGamePaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostProcessInput", DeltaTime, bGamePaused);
}

void AManagePlayerController::PostSeamlessTravel()
{
	Super::PostSeamlessTravel();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSeamlessTravel");
}

void AManagePlayerController::PreProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PreProcessInput(DeltaTime, bGamePaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreProcessInput", DeltaTime, bGamePaused);
}

void AManagePlayerController::RestartLevel()
{
	Super::RestartLevel();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RestartLevel");
}

void AManagePlayerController::SafeRetryClientRestart()
{
	Super::SafeRetryClientRestart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SafeRetryClientRestart");
}

void AManagePlayerController::SafeServerCheckClientPossession()
{
	Super::SafeServerCheckClientPossession();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SafeServerCheckClientPossession");
}

void AManagePlayerController::SeamlessTravelFrom(APlayerController* OldPC)
{
	Super::SeamlessTravelFrom(OldPC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SeamlessTravelFrom", OldPC);
}

void AManagePlayerController::SeamlessTravelTo(APlayerController* NewPC)
{
	Super::SeamlessTravelTo(NewPC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SeamlessTravelTo", NewPC);
}

void AManagePlayerController::SendToConsole(const FString& Command)
{
	Super::SendToConsole(Command);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendToConsole", Command);
}

void AManagePlayerController::SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
{
	Super::SetCinematicMode(bInCinematicMode, bAffectsMovement, bAffectsTurning);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCinematicMode", bInCinematicMode, bAffectsMovement, bAffectsTurning);
}

void AManagePlayerController::SetDisableHaptics(bool bNewDisabled)
{
	Super::SetDisableHaptics(bNewDisabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetDisableHaptics", bNewDisabled);
}

void AManagePlayerController::SetName(const FString& S)
{
	Super::SetName(S);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetName", S);
}

void AManagePlayerController::SetVirtualJoystickVisibility(bool bVisible)
{
	Super::SetVirtualJoystickVisibility(bVisible);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetVirtualJoystickVisibility", bVisible);
}

void AManagePlayerController::StartFire(uint8 FireModeNum)
{
	Super::StartFire(FireModeNum);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartFire", FireModeNum);
}

void AManagePlayerController::SwitchLevel(const FString& URL)
{
	Super::SwitchLevel(URL);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SwitchLevel", URL);
}

void AManagePlayerController::ToggleSpeaking(bool bInSpeaking)
{
	Super::ToggleSpeaking(bInSpeaking);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleSpeaking", bInSpeaking);
}

void AManagePlayerController::UnFreeze()
{
	Super::UnFreeze();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnFreeze");
}

void AManagePlayerController::UpdateRotation(float DeltaTime)
{
	Super::UpdateRotation(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateRotation", DeltaTime);
}

void AManagePlayerController::AddPawnTickDependency(APawn* NewPawn)
{
	Super::AddPawnTickDependency(NewPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddPawnTickDependency", NewPawn);
}

void AManagePlayerController::AttachToPawn(APawn* InPawn)
{
	Super::AttachToPawn(InPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AttachToPawn", InPawn);
}

void AManagePlayerController::BeginInactiveState()
{
	Super::BeginInactiveState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginInactiveState");
}

void AManagePlayerController::ChangeState(FName NewState)
{
	Super::ChangeState(NewState);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ChangeState", NewState);
}

void AManagePlayerController::CleanupPlayerState()
{
	Super::CleanupPlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CleanupPlayerState");
}

void AManagePlayerController::CurrentLevelUnloaded()
{
	Super::CurrentLevelUnloaded();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CurrentLevelUnloaded");
}

void AManagePlayerController::DetachFromPawn()
{
	Super::DetachFromPawn();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromPawn");
}

void AManagePlayerController::EndInactiveState()
{
	Super::EndInactiveState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndInactiveState");
}

void AManagePlayerController::FailedToSpawnPawn()
{
	Super::FailedToSpawnPawn();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FailedToSpawnPawn");
}

void AManagePlayerController::GameHasEnded(AActor* EndGameFocus, bool bIsWinner)
{
	Super::GameHasEnded(EndGameFocus, bIsWinner);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GameHasEnded", EndGameFocus, bIsWinner);
}

void AManagePlayerController::InitPlayerState()
{
	Super::InitPlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitPlayerState");
}

void AManagePlayerController::OnPossess(APawn* InPawn)
{
	Super::OnPossess(InPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnPossess", InPawn);
}

void AManagePlayerController::OnRep_Pawn()
{
	Super::OnRep_Pawn();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Pawn");
}

void AManagePlayerController::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
}

void AManagePlayerController::OnUnPossess()
{
	Super::OnUnPossess();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnPossess");
}

void AManagePlayerController::PawnPendingDestroy(APawn* inPawn)
{
	Super::PawnPendingDestroy(inPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnPendingDestroy", inPawn);
}

void AManagePlayerController::RemovePawnTickDependency(APawn* InOldPawn)
{
	Super::RemovePawnTickDependency(InOldPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemovePawnTickDependency", InOldPawn);
}

void AManagePlayerController::ResetIgnoreInputFlags()
{
	Super::ResetIgnoreInputFlags();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreInputFlags");
}

void AManagePlayerController::ResetIgnoreLookInput()
{
	Super::ResetIgnoreLookInput();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreLookInput");
}

void AManagePlayerController::ResetIgnoreMoveInput()
{
	Super::ResetIgnoreMoveInput();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetIgnoreMoveInput");
}

void AManagePlayerController::SetControlRotation(const FRotator& NewRotation)
{
	Super::SetControlRotation(NewRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetControlRotation", NewRotation);
}

void AManagePlayerController::SetIgnoreLookInput(bool bNewLookInput)
{
	Super::SetIgnoreLookInput(bNewLookInput);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetIgnoreLookInput", bNewLookInput);
}

void AManagePlayerController::SetIgnoreMoveInput(bool bNewMoveInput)
{
	Super::SetIgnoreMoveInput(bNewMoveInput);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetIgnoreMoveInput", bNewMoveInput);
}

void AManagePlayerController::SetInitialLocationAndRotation(const FVector& NewLocation, const FRotator& NewRotation)
{
	Super::SetInitialLocationAndRotation(NewLocation, NewRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetInitialLocationAndRotation", NewLocation, NewRotation);
}

void AManagePlayerController::SetPawn(APawn* InPawn)
{
	Super::SetPawn(InPawn);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPawn", InPawn);
}

void AManagePlayerController::StopMovement()
{
	Super::StopMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovement");
}

void AManagePlayerController::UpdateNavigationComponents()
{
	Super::UpdateNavigationComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationComponents");
}

void AManagePlayerController::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManagePlayerController::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManagePlayerController::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManagePlayerController::BecomeViewTarget(APlayerController* PC)
{
	Super::BecomeViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BecomeViewTarget", PC);
}

void AManagePlayerController::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void AManagePlayerController::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManagePlayerController::Destroyed()
{
	Super::Destroyed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
}

void AManagePlayerController::DisableInput(APlayerController* PlayerController)
{
	Super::DisableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableInput", PlayerController);
}

void AManagePlayerController::EnableInput(APlayerController* PlayerController)
{
	Super::EnableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableInput", PlayerController);
}

void AManagePlayerController::EndViewTarget(APlayerController* PC)
{
	Super::EndViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndViewTarget", PC);
}

void AManagePlayerController::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
}

void AManagePlayerController::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
}

void AManagePlayerController::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
}

void AManagePlayerController::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManagePlayerController::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
}

void AManagePlayerController::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
}

void AManagePlayerController::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManagePlayerController::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManagePlayerController::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManagePlayerController::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManagePlayerController::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManagePlayerController::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManagePlayerController::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnConstruction", Transform);
}

void AManagePlayerController::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManagePlayerController::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
}

void AManagePlayerController::OnRep_Owner()
{
	Super::OnRep_Owner();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
}

void AManagePlayerController::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManagePlayerController::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManagePlayerController::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManagePlayerController::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManagePlayerController::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManagePlayerController::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
}

void AManagePlayerController::PostActorCreated()
{
	Super::PostActorCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
}

void AManagePlayerController::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
}

void AManagePlayerController::PostNetInit()
{
	Super::PostNetInit();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
}

void AManagePlayerController::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManagePlayerController::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManagePlayerController::PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
}

void AManagePlayerController::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManagePlayerController::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
}

void AManagePlayerController::PostRenderFor(APlayerController* PC, UCanvas* Canvas, FVector CameraPosition, FVector CameraDir)
{
	Super::PostRenderFor(PC, Canvas, CameraPosition, CameraDir);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRenderFor", PC, Canvas, CameraPosition, CameraDir);
}

void AManagePlayerController::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManagePlayerController::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
}

void AManagePlayerController::PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
}

void AManagePlayerController::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManagePlayerController::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManagePlayerController::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
}

void AManagePlayerController::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManagePlayerController::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManagePlayerController::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
}

void AManagePlayerController::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
}

void AManagePlayerController::Reset()
{
	Super::Reset();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
}

void AManagePlayerController::RewindForReplay()
{
	Super::RewindForReplay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
}

void AManagePlayerController::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManagePlayerController::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManagePlayerController::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOwner", NewOwner);
}

void AManagePlayerController::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManagePlayerController::TearOff()
{
	Super::TearOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
}

void AManagePlayerController::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManagePlayerController::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManagePlayerController::TornOff()
{
	Super::TornOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
}

void AManagePlayerController::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManagePlayerController::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void AManagePlayerController::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void AManagePlayerController::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManagePlayerController::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void AManagePlayerController::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void AManagePlayerController::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void AManagePlayerController::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void AManagePlayerController::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void AManagePlayerController::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void AManagePlayerController::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManagePlayerController::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void AManagePlayerController::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManagePlayerController::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void AManagePlayerController::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void AManagePlayerController::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void AManagePlayerController::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void AManagePlayerController::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
