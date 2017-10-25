#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageController.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\Controller.h:41

void AManageController::AddPawnTickDependency(APawn* NewPawn)
{
	Super::AddPawnTickDependency(NewPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddPawnTickDependency", NewPawn);
}

void AManageController::AttachToPawn(APawn* InPawn)
{
	Super::AttachToPawn(InPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AttachToPawn", InPawn);
}

void AManageController::BeginInactiveState()
{
	Super::BeginInactiveState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginInactiveState");
}

void AManageController::ChangeState(FName NewState)
{
	Super::ChangeState(NewState);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ChangeState", NewState);
}

void AManageController::CleanupPlayerState()
{
	Super::CleanupPlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CleanupPlayerState");
}

void AManageController::CurrentLevelUnloaded()
{
	Super::CurrentLevelUnloaded();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CurrentLevelUnloaded");
}

void AManageController::DetachFromPawn()
{
	Super::DetachFromPawn();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromPawn");
}

void AManageController::EndInactiveState()
{
	Super::EndInactiveState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "EndInactiveState");
}

void AManageController::FailedToSpawnPawn()
{
	Super::FailedToSpawnPawn();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FailedToSpawnPawn");
}

void AManageController::GameHasEnded(AActor* EndGameFocus, bool bIsWinner)
{
	Super::GameHasEnded(EndGameFocus, bIsWinner);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GameHasEnded", EndGameFocus, bIsWinner);
}

void AManageController::InitPlayerState()
{
	Super::InitPlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitPlayerState");
}

void AManageController::OnRep_Pawn()
{
	Super::OnRep_Pawn();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Pawn");
}

void AManageController::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_PlayerState");
}

void AManageController::PawnPendingDestroy(APawn* inPawn)
{
	Super::PawnPendingDestroy(inPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnPendingDestroy", inPawn);
}

void AManageController::Possess(APawn* InPawn)
{
	Super::Possess(InPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Possess", InPawn);
}

void AManageController::RemovePawnTickDependency(APawn* InOldPawn)
{
	Super::RemovePawnTickDependency(InOldPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemovePawnTickDependency", InOldPawn);
}

void AManageController::ResetIgnoreInputFlags()
{
	Super::ResetIgnoreInputFlags();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetIgnoreInputFlags");
}

void AManageController::ResetIgnoreLookInput()
{
	Super::ResetIgnoreLookInput();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetIgnoreLookInput");
}

void AManageController::ResetIgnoreMoveInput()
{
	Super::ResetIgnoreMoveInput();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetIgnoreMoveInput");
}

void AManageController::SetControlRotation(const FRotator& NewRotation)
{
	Super::SetControlRotation(NewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetControlRotation", NewRotation);
}

void AManageController::SetIgnoreLookInput(bool bNewLookInput)
{
	Super::SetIgnoreLookInput(bNewLookInput);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetIgnoreLookInput", bNewLookInput);
}

void AManageController::SetIgnoreMoveInput(bool bNewMoveInput)
{
	Super::SetIgnoreMoveInput(bNewMoveInput);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetIgnoreMoveInput", bNewMoveInput);
}

void AManageController::SetInitialLocationAndRotation(const FVector& NewLocation, const FRotator& NewRotation)
{
	Super::SetInitialLocationAndRotation(NewLocation, NewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetInitialLocationAndRotation", NewLocation, NewRotation);
}

void AManageController::SetPawn(APawn* InPawn)
{
	Super::SetPawn(InPawn);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPawn", InPawn);
}

void AManageController::StopMovement()
{
	Super::StopMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopMovement");
}

void AManageController::UnPossess()
{
	Super::UnPossess();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnPossess");
}

void AManageController::UpdateNavigationComponents()
{
	Super::UpdateNavigationComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateNavigationComponents");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
