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

PRAGMA_ENABLE_DEPRECATION_WARNINGS
