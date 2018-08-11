#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

void UManageMovementComponent::AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff);
}

void UManageMovementComponent::AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageMovementComponent::HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
{
	Super::HandleImpact(Hit, TimeSlice, MoveDelta);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "HandleImpact", Hit, TimeSlice, MoveDelta);
}

void UManageMovementComponent::OnTeleported()
{
	Super::OnTeleported();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnTeleported");
}

void UManageMovementComponent::SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
{
	Super::SetPlaneConstraintAxisSetting(NewAxisSetting);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintAxisSetting", NewAxisSetting);
}

void UManageMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
}

void UManageMovementComponent::SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
{
	Super::SetPlaneConstraintFromVectors(Forward, Up);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintFromVectors", Forward, Up);
}

void UManageMovementComponent::SetPlaneConstraintNormal(FVector PlaneNormal)
{
	Super::SetPlaneConstraintNormal(PlaneNormal);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintNormal", PlaneNormal);
}

void UManageMovementComponent::SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	Super::SetPlaneConstraintOrigin(PlaneOrigin);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintOrigin", PlaneOrigin);
}

void UManageMovementComponent::SetUpdatedComponent(USceneComponent* NewUpdatedComponent)
{
	Super::SetUpdatedComponent(NewUpdatedComponent);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetUpdatedComponent", NewUpdatedComponent);
}

void UManageMovementComponent::SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SnapUpdatedComponentToPlane");
}

void UManageMovementComponent::StopMovementImmediately()
{
	Super::StopMovementImmediately();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "StopMovementImmediately");
}

void UManageMovementComponent::UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UpdateComponentVelocity");
}

void UManageMovementComponent::UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UpdateTickRegistration");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
