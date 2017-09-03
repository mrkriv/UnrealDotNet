#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePrimitiveComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManagePrimitiveComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManagePrimitiveComponent::AddForce(FVector Force, FName BoneName, bool bAccelChange)
{
	Super::AddForce(Force, BoneName, bAccelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForce", Force, BoneName, bAccelChange);
}

void UManagePrimitiveComponent::AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocation(Force, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForceAtLocation", Force, Location, BoneName);
}

void UManagePrimitiveComponent::AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocationLocal(Force, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForceAtLocationLocal", Force, Location, BoneName);
}

void UManagePrimitiveComponent::AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddImpulse(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulse", Impulse, BoneName, bVelChange);
}

void UManagePrimitiveComponent::AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
{
	Super::AddImpulseAtLocation(Impulse, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulseAtLocation", Impulse, Location, BoneName);
}

void UManagePrimitiveComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManagePrimitiveComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManagePrimitiveComponent::SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllMassScale", InMassScale);
}

void UManagePrimitiveComponent::SetAllPhysicsAngularVelocity(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocity(NewAngVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsAngularVelocity", NewAngVel, bAddToCurrent);
}

void UManagePrimitiveComponent::SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsLinearVelocity(NewVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsLinearVelocity", NewVel, bAddToCurrent);
}

void UManagePrimitiveComponent::SetAllPhysicsPosition(FVector NewPos)
{
	Super::SetAllPhysicsPosition(NewPos);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsPosition", NewPos);
}

void UManagePrimitiveComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManagePrimitiveComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManagePrimitiveComponent::SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
}

void UManagePrimitiveComponent::SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLinearDamping", InDamping);
}

void UManagePrimitiveComponent::SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
{
	Super::SetMassOverrideInKg(BoneName, MassInKg, bOverrideMass);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMassOverrideInKg", BoneName, MassInKg, bOverrideMass);
}

void UManagePrimitiveComponent::SetMassScale(FName BoneName, float InMassScale)
{
	Super::SetMassScale(BoneName, InMassScale);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMassScale", BoneName, InMassScale);
}

void UManagePrimitiveComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
}

void UManagePrimitiveComponent::SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetSimulatePhysics", bSimulate);
}

void UManagePrimitiveComponent::UnWeldChildren()
{
	Super::UnWeldChildren();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnWeldChildren");
}

void UManagePrimitiveComponent::UnWeldFromParent()
{
	Super::UnWeldFromParent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnWeldFromParent");
}

void UManagePrimitiveComponent::UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsToRBChannels");
}

void UManagePrimitiveComponent::WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WakeAllRigidBodies");
}

void UManagePrimitiveComponent::WakeRigidBody(FName BoneName)
{
	Super::WakeRigidBody(BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WakeRigidBody", BoneName);
}

void UManagePrimitiveComponent::WeldTo(USceneComponent* InParent, FName InSocketName)
{
	Super::WeldTo(InParent, InSocketName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WeldTo", InParent, InSocketName);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
