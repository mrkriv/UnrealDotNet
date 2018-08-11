#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageNavMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

void UManageNavMovementComponent::RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed)
{
	Super::RequestDirectMove(MoveVelocity, bForceMaxSpeed);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RequestDirectMove", MoveVelocity, bForceMaxSpeed);
}

void UManageNavMovementComponent::RequestPathMove(const FVector& MoveInput)
{
	Super::RequestPathMove(MoveInput);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RequestPathMove", MoveInput);
}

void UManageNavMovementComponent::StopActiveMovement()
{
	Super::StopActiveMovement();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "StopActiveMovement");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
