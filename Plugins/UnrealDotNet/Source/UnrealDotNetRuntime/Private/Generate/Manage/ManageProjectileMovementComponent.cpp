// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageProjectileMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

bool UManageProjectileMovementComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageProjectileMovementComponent::MoveInterpolationTarget(const FVector& NewLocation, const FRotator& NewRotation)
{
	Super::MoveInterpolationTarget(NewLocation, NewRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveInterpolationTarget", NewLocation, NewRotation);
}

void UManageProjectileMovementComponent::ResetInterpolation()
{
	Super::ResetInterpolation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetInterpolation");
}

void UManageProjectileMovementComponent::SetInterpolatedComponent(USceneComponent* Component)
{
	Super::SetInterpolatedComponent(Component);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetInterpolatedComponent", Component);
}

void UManageProjectileMovementComponent::SetVelocityInLocalSpace(FVector NewVelocity)
{
	Super::SetVelocityInLocalSpace(NewVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetVelocityInLocalSpace", NewVelocity);
}

void UManageProjectileMovementComponent::StopSimulating(const FHitResult& HitResult)
{
	Super::StopSimulating(HitResult);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopSimulating", HitResult);
}

void UManageProjectileMovementComponent::TickInterpolation(float DeltaTime)
{
	Super::TickInterpolation(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TickInterpolation", DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
