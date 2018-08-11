#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageHUD.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

void AManageHUD::AddPostRenderedActor(AActor* A)
{
	Super::AddPostRenderedActor(A);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddPostRenderedActor", A);
}

void AManageHUD::DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
{
	Super::DrawActorOverlays(Viewpoint, ViewRotation);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "DrawActorOverlays", Viewpoint, ViewRotation);
}

void AManageHUD::DrawHUD()
{
	Super::DrawHUD();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "DrawHUD");
}

void AManageHUD::DrawSafeZoneOverlay()
{
	Super::DrawSafeZoneOverlay();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "DrawSafeZoneOverlay");
}

void AManageHUD::HandleBugScreenShot()
{
	Super::HandleBugScreenShot();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "HandleBugScreenShot");
}

void AManageHUD::NextDebugTarget()
{
	Super::NextDebugTarget();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NextDebugTarget");
}

void AManageHUD::NotifyBindPostProcessEffects()
{
	Super::NotifyBindPostProcessEffects();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyBindPostProcessEffects");
}

void AManageHUD::NotifyHitBoxBeginCursorOver(FName BoxName)
{
	Super::NotifyHitBoxBeginCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHitBoxBeginCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxClick(FName BoxName)
{
	Super::NotifyHitBoxClick(BoxName);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHitBoxClick", BoxName);
}

void AManageHUD::NotifyHitBoxEndCursorOver(FName BoxName)
{
	Super::NotifyHitBoxEndCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHitBoxEndCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxRelease(FName BoxName)
{
	Super::NotifyHitBoxRelease(BoxName);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHitBoxRelease", BoxName);
}

void AManageHUD::OnLostFocusPause(bool bEnable)
{
	Super::OnLostFocusPause(bEnable);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnLostFocusPause", bEnable);
}

void AManageHUD::PostRender()
{
	Super::PostRender();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostRender");
}

void AManageHUD::PreviousDebugTarget()
{
	Super::PreviousDebugTarget();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PreviousDebugTarget");
}

void AManageHUD::RemovePostRenderedActor(AActor* A)
{
	Super::RemovePostRenderedActor(A);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RemovePostRenderedActor", A);
}

void AManageHUD::ShowDebug(FName DebugType)
{
	Super::ShowDebug(DebugType);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ShowDebug", DebugType);
}

void AManageHUD::ShowDebugInfo(float& YL, float& YPos)
{
	Super::ShowDebugInfo(YL, YPos);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ShowDebugInfo", YL, YPos);
}

void AManageHUD::ShowHUD()
{
	Super::ShowHUD();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ShowHUD");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
