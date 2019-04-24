#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
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
	
	virtual void ActivateTouchInterface(UTouchInterface* NewTouchInterface) override;
	virtual void AddPitchInput(float Val) override;
	virtual void AddRollInput(float Val) override;
	virtual void AddYawInput(float Val) override;
	virtual void Camera(FName NewMode) override;
	virtual void ClientClearCameraLensEffects() override;
	virtual void ClientEnableNetworkVoice(bool bEnable) override;
	virtual void ClientRepObjRef(UObject* Object) override;
	virtual void ClientReturnToMainMenu(const FString& ReturnReason) override;
	virtual void ClientReturnToMainMenuWithTextReason(const FText& ReturnReason) override;
	virtual void ClientVoiceHandshakeComplete() override;
	virtual void DelayedPrepareMapChange() override;
	virtual void EnableCheats() override;
	virtual void FOV(float NewFOV) override;
	virtual void GetSeamlessTravelActorList(bool bToEntry, TArray<AActor*>& ActorList) override;
	virtual void LocalTravel(const FString& URL) override;
	virtual void NotifyLoadedWorld(FName WorldPackageName, bool bFinalDest) override;
	virtual void Pause() override;
	virtual void PlayerTick(float DeltaTime) override;
	virtual void PostProcessInput(const float DeltaTime, const bool bGamePaused) override;
	virtual void PostSeamlessTravel() override;
	virtual void PreProcessInput(const float DeltaTime, const bool bGamePaused) override;
	virtual void RestartLevel() override;
	virtual void SafeRetryClientRestart() override;
	virtual void SafeServerCheckClientPossession() override;
	virtual void SeamlessTravelFrom(APlayerController* OldPC) override;
	virtual void SeamlessTravelTo(APlayerController* NewPC) override;
	virtual void SendToConsole(const FString& Command) override;
	virtual void SetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning) override;
	virtual void SetDisableHaptics(bool bNewDisabled) override;
	virtual void SetName(const FString& S) override;
	virtual void SetVirtualJoystickVisibility(bool bVisible) override;
	virtual void StartFire(uint8 FireModeNum) override;
	virtual void SwitchLevel(const FString& URL) override;
	virtual void ToggleSpeaking(bool bInSpeaking) override;
	virtual void UnFreeze() override;
	virtual void UpdateRotation(float DeltaTime) override;
	
protected:
	virtual void BeginPlayingState() override;
	virtual void EndPlayingState() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
