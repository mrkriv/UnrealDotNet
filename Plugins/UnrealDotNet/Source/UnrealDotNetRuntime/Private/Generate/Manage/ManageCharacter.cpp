#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageCharacter.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\Character.h:239

void AManageCharacter::BaseChange()
{
	Super::BaseChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BaseChange");
}

void AManageCharacter::CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
{
	Super::CacheInitialMeshOffset(MeshRelativeLocation, MeshRelativeRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CacheInitialMeshOffset", MeshRelativeLocation, MeshRelativeRotation);
}

void AManageCharacter::CheckJumpInput(float DeltaTime)
{
	Super::CheckJumpInput(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CheckJumpInput", DeltaTime);
}

void AManageCharacter::ClearJumpInput()
{
	Super::ClearJumpInput();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearJumpInput");
}

void AManageCharacter::ClientCheatFly_Implementation()
{
	Super::ClientCheatFly_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatFly_Implementation");
}

void AManageCharacter::ClientCheatGhost_Implementation()
{
	Super::ClientCheatGhost_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatGhost_Implementation");
}

void AManageCharacter::ClientCheatWalk_Implementation()
{
	Super::ClientCheatWalk_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatWalk_Implementation");
}

void AManageCharacter::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Crouch", bClientSimulation);
}

void AManageCharacter::Falling()
{
	Super::Falling();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Falling");
}

void AManageCharacter::Jump()
{
	Super::Jump();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Jump");
}

void AManageCharacter::LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
{
	Super::LaunchCharacter(LaunchVelocity, bXYOverride, bZOverride);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LaunchCharacter", LaunchVelocity, bXYOverride, bZOverride);
}

void AManageCharacter::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyJumpApex");
}

void AManageCharacter::OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnEndCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnEndCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnJumped_Implementation()
{
	Super::OnJumped_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnJumped_Implementation");
}

void AManageCharacter::OnMovementModeChanged(EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PrevMovementMode, PreviousCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementModeChanged", PrevMovementMode, PreviousCustomMode);
}

void AManageCharacter::OnRep_IsCrouched()
{
	Super::OnRep_IsCrouched();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_IsCrouched");
}

void AManageCharacter::OnRep_ReplicatedBasedMovement()
{
	Super::OnRep_ReplicatedBasedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedBasedMovement");
}

void AManageCharacter::OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnStartCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnStartCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::RootMotionDebugClientPrintOnScreen_Implementation(const FString& InString)
{
	Super::RootMotionDebugClientPrintOnScreen_Implementation(InString);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RootMotionDebugClientPrintOnScreen_Implementation", InString);
}

void AManageCharacter::StopJumping()
{
	Super::StopJumping();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopJumping");
}

void AManageCharacter::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void AManageCharacter::UpdateFromCompressedFlags(uint8 Flags)
{
	Super::UpdateFromCompressedFlags(Flags);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateFromCompressedFlags", Flags);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
