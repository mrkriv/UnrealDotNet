#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePawnMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

void UManagePawnMovementComponent::AddInputVector(FVector WorldVector, bool bForce)
{
	Super::AddInputVector(WorldVector, bForce);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddInputVector", WorldVector, bForce);
}

void UManagePawnMovementComponent::NotifyBumpedPawn(APawn* BumpedPawn)
{
	Super::NotifyBumpedPawn(BumpedPawn);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyBumpedPawn", BumpedPawn);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
