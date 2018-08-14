#pragma once
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
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	virtual void AddPostRenderedActor(AActor* A) override;
	virtual void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation) override;
	virtual void DrawHUD() override;
	virtual void DrawSafeZoneOverlay() override;
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
