// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

bool UManageMovementComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageMovementComponent::AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff);
}

void UManageMovementComponent::AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageMovementComponent::HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
{
	Super::HandleImpact(Hit, TimeSlice, MoveDelta);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleImpact", Hit, TimeSlice, MoveDelta);
}

void UManageMovementComponent::OnTeleported()
{
	Super::OnTeleported();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTeleported");
}

void UManageMovementComponent::SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
{
	Super::SetPlaneConstraintAxisSetting(NewAxisSetting);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintAxisSetting", NewAxisSetting);
}

void UManageMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
}

void UManageMovementComponent::SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
{
	Super::SetPlaneConstraintFromVectors(Forward, Up);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintFromVectors", Forward, Up);
}

void UManageMovementComponent::SetPlaneConstraintNormal(FVector PlaneNormal)
{
	Super::SetPlaneConstraintNormal(PlaneNormal);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintNormal", PlaneNormal);
}

void UManageMovementComponent::SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	Super::SetPlaneConstraintOrigin(PlaneOrigin);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintOrigin", PlaneOrigin);
}

void UManageMovementComponent::SetUpdatedComponent(USceneComponent* NewUpdatedComponent)
{
	Super::SetUpdatedComponent(NewUpdatedComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUpdatedComponent", NewUpdatedComponent);
}

void UManageMovementComponent::SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SnapUpdatedComponentToPlane");
}

void UManageMovementComponent::StopMovementImmediately()
{
	Super::StopMovementImmediately();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovementImmediately");
}

void UManageMovementComponent::UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateComponentVelocity");
}

void UManageMovementComponent::UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateTickRegistration");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
