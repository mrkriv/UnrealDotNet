#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void AManagePawn::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManagePawn::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManagePawn::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManagePawn::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManagePawn::ClientSetRotation(FRotator NewRotation)
{
	Super::ClientSetRotation(NewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientSetRotation", NewRotation);
}

void AManagePawn::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManagePawn::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManagePawn::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManagePawn::OnRep_Controller()
{
	Super::OnRep_Controller();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Controller");
}

void AManagePawn::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_PlayerState");
}

void AManagePawn::PawnClientRestart()
{
	Super::PawnClientRestart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnClientRestart");
}

void AManagePawn::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManagePawn::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManagePawn::Restart()
{
	Super::Restart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Restart");
}

void AManagePawn::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlayerDefaults");
}

void AManagePawn::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SpawnDefaultController");
}

void AManagePawn::TurnOff()
{
	Super::TurnOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TurnOff");
}

void AManagePawn::UnPossessed()
{
	Super::UnPossessed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnPossessed");
}

void AManagePawn::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateNavigationRelevance");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
