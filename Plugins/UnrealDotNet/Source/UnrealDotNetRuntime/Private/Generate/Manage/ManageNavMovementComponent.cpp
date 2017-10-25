#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageNavMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

void UManageNavMovementComponent::RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed)
{
	Super::RequestDirectMove(MoveVelocity, bForceMaxSpeed);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestDirectMove", MoveVelocity, bForceMaxSpeed);
}

void UManageNavMovementComponent::RequestPathMove(const FVector& MoveInput)
{
	Super::RequestPathMove(MoveInput);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestPathMove", MoveInput);
}

void UManageNavMovementComponent::StopActiveMovement()
{
	Super::StopActiveMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopActiveMovement");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
