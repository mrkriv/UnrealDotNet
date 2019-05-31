// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCapsuleComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

bool UManageCapsuleComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageCapsuleComponent::UpdateBodySetup()
{
	Super::UpdateBodySetup();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBodySetup");
}

void UManageCapsuleComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManageCapsuleComponent::AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulseInRadians(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulseInRadians", Impulse, BoneName, bVelChange);
}

void UManageCapsuleComponent::AddForce(FVector Force, FName BoneName, bool bAccelChange)
{
	Super::AddForce(Force, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForce", Force, BoneName, bAccelChange);
}

void UManageCapsuleComponent::AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocation(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocation", Force, Location, BoneName);
}

void UManageCapsuleComponent::AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocationLocal(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocationLocal", Force, Location, BoneName);
}

void UManageCapsuleComponent::AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulse", Impulse, BoneName, bVelChange);
}

void UManageCapsuleComponent::AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
{
	Super::AddImpulseAtLocation(Impulse, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulseAtLocation", Impulse, Location, BoneName);
}

void UManageCapsuleComponent::AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff, bAccelChange);
}

void UManageCapsuleComponent::AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageCapsuleComponent::AddTorqueInRadians(FVector Torque, FName BoneName, bool bAccelChange)
{
	Super::AddTorqueInRadians(Torque, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTorqueInRadians", Torque, BoneName, bAccelChange);
}

void UManageCapsuleComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManageCapsuleComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManageCapsuleComponent::ReceiveComponentDamage(float DamageAmount, const FDamageEvent& DamageEvent, AController* EventInstigator, AActor* DamageCauser)
{
	Super::ReceiveComponentDamage(DamageAmount, DamageEvent, EventInstigator, DamageCauser);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceiveComponentDamage", DamageAmount, DamageEvent, EventInstigator, DamageCauser);
}

void UManageCapsuleComponent::SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
}

void UManageCapsuleComponent::SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent);
}

void UManageCapsuleComponent::SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsLinearVelocity(NewVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsLinearVelocity", NewVel, bAddToCurrent);
}

void UManageCapsuleComponent::SetAllPhysicsPosition(FVector NewPos)
{
	Super::SetAllPhysicsPosition(NewPos);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsPosition", NewPos);
}

void UManageCapsuleComponent::SetAllPhysicsRotation(FRotator NewRot)
{
	Super::SetAllPhysicsRotation(NewRot);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsRotation", NewRot);
}

void UManageCapsuleComponent::SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
}

void UManageCapsuleComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManageCapsuleComponent::SetCollisionObjectType(ECollisionChannel Channel)
{
	Super::SetCollisionObjectType(Channel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionObjectType", Channel);
}

void UManageCapsuleComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManageCapsuleComponent::SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToAllChannels(NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToAllChannels", NewResponse);
}

void UManageCapsuleComponent::SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToChannel(Channel, NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannel", Channel, NewResponse);
}

void UManageCapsuleComponent::SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses)
{
	Super::SetCollisionResponseToChannels(NewReponses);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannels", NewReponses);
}

void UManageCapsuleComponent::SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
}

void UManageCapsuleComponent::SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
}

void UManageCapsuleComponent::SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
{
	Super::SetMassOverrideInKg(BoneName, MassInKg, bOverrideMass);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassOverrideInKg", BoneName, MassInKg, bOverrideMass);
}

void UManageCapsuleComponent::SetMassScale(FName BoneName, float InMassScale)
{
	Super::SetMassScale(BoneName, InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassScale", BoneName, InMassScale);
}

void UManageCapsuleComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
}

void UManageCapsuleComponent::SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent, BoneName);
}

void UManageCapsuleComponent::SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsLinearVelocity(NewVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsLinearVelocity", NewVel, bAddToCurrent, BoneName);
}

void UManageCapsuleComponent::SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
}

void UManageCapsuleComponent::SetUseCCD(bool InUseCCD, FName BoneName)
{
	Super::SetUseCCD(InUseCCD, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUseCCD", InUseCCD, BoneName);
}

void UManageCapsuleComponent::UnWeldChildren()
{
	Super::UnWeldChildren();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
}

void UManageCapsuleComponent::UnWeldFromParent()
{
	Super::UnWeldFromParent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
}

void UManageCapsuleComponent::UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
}

void UManageCapsuleComponent::WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
}

void UManageCapsuleComponent::WakeRigidBody(FName BoneName)
{
	Super::WakeRigidBody(BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeRigidBody", BoneName);
}

void UManageCapsuleComponent::WeldTo(USceneComponent* InParent, FName InSocketName)
{
	Super::WeldTo(InParent, InSocketName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WeldTo", InParent, InSocketName);
}

void UManageCapsuleComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageCapsuleComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageCapsuleComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
}

void UManageCapsuleComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageCapsuleComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageCapsuleComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageCapsuleComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageCapsuleComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
}

void UManageCapsuleComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageCapsuleComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageCapsuleComponent::UpdateBounds()
{
	Super::UpdateBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
}

void UManageCapsuleComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

void UManageCapsuleComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
}

void UManageCapsuleComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCapsuleComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCapsuleComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageCapsuleComponent::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void UManageCapsuleComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageCapsuleComponent::Deactivate()
{
	Super::Deactivate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
}

void UManageCapsuleComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageCapsuleComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageCapsuleComponent::InitializeComponent()
{
	Super::InitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
}

void UManageCapsuleComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageCapsuleComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageCapsuleComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
}

void UManageCapsuleComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageCapsuleComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageCapsuleComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageCapsuleComponent::OnRegister()
{
	Super::OnRegister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
}

void UManageCapsuleComponent::OnRep_IsActive()
{
	Super::OnRep_IsActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
}

void UManageCapsuleComponent::OnUnregister()
{
	Super::OnUnregister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
}

void UManageCapsuleComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageCapsuleComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageCapsuleComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageCapsuleComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageCapsuleComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageCapsuleComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageCapsuleComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageCapsuleComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageCapsuleComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageCapsuleComponent::ToggleActive()
{
	Super::ToggleActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
}

void UManageCapsuleComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
}

void UManageCapsuleComponent::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void UManageCapsuleComponent::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void UManageCapsuleComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageCapsuleComponent::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void UManageCapsuleComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void UManageCapsuleComponent::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void UManageCapsuleComponent::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void UManageCapsuleComponent::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void UManageCapsuleComponent::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void UManageCapsuleComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageCapsuleComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void UManageCapsuleComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageCapsuleComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageCapsuleComponent::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void UManageCapsuleComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void UManageCapsuleComponent::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void UManageCapsuleComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
