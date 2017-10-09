#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageHUD.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void AManageHUD::DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
{
	Super::DrawActorOverlays(Viewpoint, ViewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawActorOverlays", Viewpoint, ViewRotation);
}

void AManageHUD::DrawHUD()
{
	Super::DrawHUD();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawHUD");
}

void AManageHUD::DrawSafeZoneOverlay()
{
	Super::DrawSafeZoneOverlay();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawSafeZoneOverlay");
}

void AManageHUD::HandleBugScreenShot()
{
	Super::HandleBugScreenShot();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleBugScreenShot");
}

void AManageHUD::NotifyBindPostProcessEffects()
{
	Super::NotifyBindPostProcessEffects();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyBindPostProcessEffects");
}

void AManageHUD::NotifyHitBoxBeginCursorOver(FName BoxName)
{
	Super::NotifyHitBoxBeginCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxBeginCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxClick(FName BoxName)
{
	Super::NotifyHitBoxClick(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxClick", BoxName);
}

void AManageHUD::NotifyHitBoxEndCursorOver(FName BoxName)
{
	Super::NotifyHitBoxEndCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxEndCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxRelease(FName BoxName)
{
	Super::NotifyHitBoxRelease(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxRelease", BoxName);
}

void AManageHUD::OnLostFocusPause(bool bEnable)
{
	Super::OnLostFocusPause(bEnable);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnLostFocusPause", bEnable);
}

void AManageHUD::PostRender()
{
	Super::PostRender();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRender");
}

void AManageHUD::ShowDebug(FName DebugType)
{
	Super::ShowDebug(DebugType);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowDebug", DebugType);
}

void AManageHUD::ShowDebugInfo(float& YL, float& YPos)
{
	Super::ShowDebugInfo(YL, YPos);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowDebugInfo", YL, YPos);
}

void AManageHUD::ShowHUD()
{
	Super::ShowHUD();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowHUD");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
