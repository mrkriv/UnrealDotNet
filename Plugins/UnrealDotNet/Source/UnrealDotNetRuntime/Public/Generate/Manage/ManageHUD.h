#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/HUD.h"
#include "ManageHUD.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

UCLASS()
class UNREALDOTNETRUNTIME_API AManageHUD : public AHUD, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddPostRenderedActor(AActor* A) override;
	virtual void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation) override;
	virtual void DrawHUD() override;
	virtual void DrawSafeZoneOverlay() override;
	virtual void GetDebugActorList(TArray<AActor*>& InOutList) override;
	virtual void HandleBugScreenShot() override;
	virtual void NextDebugTarget() override;
	virtual void NotifyBindPostProcessEffects() override;
	virtual void NotifyHitBoxBeginCursorOver(FName BoxName) override;
	virtual void NotifyHitBoxClick(FName BoxName) override;
	virtual void NotifyHitBoxEndCursorOver(FName BoxName) override;
	virtual void NotifyHitBoxRelease(FName BoxName) override;
	virtual void OnLostFocusPause(bool bEnable) override;
	virtual void PostRender() override;
	virtual void PreviousDebugTarget() override;
	virtual void RemovePostRenderedActor(AActor* A) override;
	virtual void ShowDebug(FName DebugType) override;
	virtual void ShowDebugInfo(float& YL, float& YPos) override;
	virtual void ShowHUD() override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
