#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePlayerController.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:197

void AManagePlayerController::ActivateTouchInterface(UTouchInterface* NewTouchInterface)
{
	Super::ActivateTouchInterface(NewTouchInterface);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ActivateTouchInterface", NewTouchInterface);
}

void AManagePlayerController::AddPitchInput(float Val)
{
	Super::AddPitchInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddPitchInput", Val);
}

void AManagePlayerController::AddRollInput(float Val)
{
	Super::AddRollInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRollInput", Val);
}

void AManagePlayerController::AddYawInput(float Val)
{
	Super::AddYawInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddYawInput", Val);
}

void AManagePlayerController::BeginPlayingState()
{
	Super::BeginPlayingState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlayingState");
}

void AManagePlayerController::Camera(FName NewMode)
{
	Super::Camera(NewMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Camera", NewMode);
}

void AManagePlayerController::ClientClearCameraLensEffects()
{
	Super::ClientClearCameraLensEffects();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientClearCameraLensEffects");
}

void AManagePlayerController::ClientEnableNetworkVoice(bool bEnable)
{
	Super::ClientEnableNetworkVoice(bEnable);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientEnableNetworkVoice", bEnable);
}

void AManagePlayerController::ClientRepObjRef(UObject* Object)
{
	Super::ClientRepObjRef(Object);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientRepObjRef", Object);
}

void AManagePlayerController::ClientReturnToMainMenu(const FString& ReturnReason)
{
	Super::ClientReturnToMainMenu(ReturnReason);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientReturnToMainMenu", ReturnReason);
}

void AManagePlayerController::ClientVoiceHandshakeComplete()
{
	Super::ClientVoiceHandshakeComplete();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientVoiceHandshakeComplete");
}

void AManagePlayerController::DelayedPrepareMapChange()
{
	Super::DelayedPrepareMapChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DelayedPrepareMapChange");
}

void AManagePlayerController::EnableCheats()
{
	Super::EnableCheats();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "EnableCheats");
}

void AManagePlayerController::EndPlayingState()
{
	Super::EndPlayingState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "EndPlayingState");
}

void AManagePlayerController::FOV(float NewFOV)
{
	Super::FOV(NewFOV);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FOV", NewFOV);
}

void AManagePlayerController::LocalTravel(const FString& URL)
{
	Super::LocalTravel(URL);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LocalTravel", URL);
}

void AManagePlayerController::NotifyLoadedWorld(FName WorldPackageName, bool bFinalDest)
{
	Super::NotifyLoadedWorld(WorldPackageName, bFinalDest);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyLoadedWorld", WorldPackageName, bFinalDest);
}

void AManagePlayerController::Pause()
{
	Super::Pause();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Pause");
}

void AManagePlayerController::PlayerTick(float DeltaTime)
{
	Super::PlayerTick(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PlayerTick", DeltaTime);
}

void AManagePlayerController::PostProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PostProcessInput(DeltaTime, bGamePaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostProcessInput", DeltaTime, bGamePaused);
}

void AManagePlayerController::PostSeamlessTravel()
{
	Super::PostSeamlessTravel();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSeamlessTravel");
}

void AManagePlayerController::PreProcessInput(const float DeltaTime, const bool bGamePaused)
{
	Super::PreProcessInput(DeltaTime, bGamePaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreProcessInput", DeltaTime, bGamePaused);
}

void AManagePlayerController::RestartLevel()
{
	Super::RestartLevel();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RestartLevel");
}

void AManagePlayerController::SafeRetryClientRestart()
{
	Super::SafeRetryClientRestart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SafeRetryClientRestart");
}

void AManagePlayerController::SafeServerCheckClientPossession()
{
	Super::SafeServerCheckClientPossession();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SafeServerCheckClientPossession");
}

void AManagePlayerController::SeamlessTravelFrom(APlayerController* OldPC)
{
	Super::SeamlessTravelFrom(OldPC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SeamlessTravelFrom", OldPC);
}

void AManagePlayerController::SeamlessTravelTo(APlayerController* NewPC)
{
	Super::SeamlessTravelTo(NewPC);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SeamlessTravelTo", NewPC);
}

void AManagePlayerController::SendToConsole(const FString& Command)
{
	Super::SendToConsole(Command);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendToConsole", Command);
}

void AManagePlayerController::SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning)
{
	Super::SetCinematicMode(bInCinematicMode, bAffectsMovement, bAffectsTurning);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCinematicMode", bInCinematicMode, bAffectsMovement, bAffectsTurning);
}

void AManagePlayerController::SetInputMode(const FInputModeDataBase& InData)
{
	Super::SetInputMode(InData);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetInputMode", InData);
}

void AManagePlayerController::SetName(const FString& S)
{
	Super::SetName(S);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetName", S);
}

void AManagePlayerController::SetVirtualJoystickVisibility(bool bVisible)
{
	Super::SetVirtualJoystickVisibility(bVisible);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetVirtualJoystickVisibility", bVisible);
}

void AManagePlayerController::StartFire(uint8 FireModeNum)
{
	Super::StartFire(FireModeNum);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartFire", FireModeNum);
}

void AManagePlayerController::SwitchLevel(const FString& URL)
{
	Super::SwitchLevel(URL);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SwitchLevel", URL);
}

void AManagePlayerController::ToggleSpeaking(bool bInSpeaking)
{
	Super::ToggleSpeaking(bInSpeaking);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleSpeaking", bInSpeaking);
}

void AManagePlayerController::UnFreeze()
{
	Super::UnFreeze();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnFreeze");
}

void AManagePlayerController::UpdateRotation(float DeltaTime)
{
	Super::UpdateRotation(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateRotation", DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
