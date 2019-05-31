// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageMaterialBillboardComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

bool UManageMaterialBillboardComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageMaterialBillboardComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManageMaterialBillboardComponent::AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulseInRadians(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulseInRadians", Impulse, BoneName, bVelChange);
}

void UManageMaterialBillboardComponent::AddForce(FVector Force, FName BoneName, bool bAccelChange)
{
	Super::AddForce(Force, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForce", Force, BoneName, bAccelChange);
}

void UManageMaterialBillboardComponent::AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocation(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocation", Force, Location, BoneName);
}

void UManageMaterialBillboardComponent::AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocationLocal(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocationLocal", Force, Location, BoneName);
}

void UManageMaterialBillboardComponent::AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulse", Impulse, BoneName, bVelChange);
}

void UManageMaterialBillboardComponent::AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
{
	Super::AddImpulseAtLocation(Impulse, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulseAtLocation", Impulse, Location, BoneName);
}

void UManageMaterialBillboardComponent::AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff, bAccelChange);
}

void UManageMaterialBillboardComponent::AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageMaterialBillboardComponent::AddTorqueInRadians(FVector Torque, FName BoneName, bool bAccelChange)
{
	Super::AddTorqueInRadians(Torque, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTorqueInRadians", Torque, BoneName, bAccelChange);
}

void UManageMaterialBillboardComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManageMaterialBillboardComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManageMaterialBillboardComponent::ReceiveComponentDamage(float DamageAmount, const FDamageEvent& DamageEvent, AController* EventInstigator, AActor* DamageCauser)
{
	Super::ReceiveComponentDamage(DamageAmount, DamageEvent, EventInstigator, DamageCauser);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceiveComponentDamage", DamageAmount, DamageEvent, EventInstigator, DamageCauser);
}

void UManageMaterialBillboardComponent::SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
}

void UManageMaterialBillboardComponent::SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent);
}

void UManageMaterialBillboardComponent::SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsLinearVelocity(NewVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsLinearVelocity", NewVel, bAddToCurrent);
}

void UManageMaterialBillboardComponent::SetAllPhysicsPosition(FVector NewPos)
{
	Super::SetAllPhysicsPosition(NewPos);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsPosition", NewPos);
}

void UManageMaterialBillboardComponent::SetAllPhysicsRotation(FRotator NewRot)
{
	Super::SetAllPhysicsRotation(NewRot);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsRotation", NewRot);
}

void UManageMaterialBillboardComponent::SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
}

void UManageMaterialBillboardComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManageMaterialBillboardComponent::SetCollisionObjectType(ECollisionChannel Channel)
{
	Super::SetCollisionObjectType(Channel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionObjectType", Channel);
}

void UManageMaterialBillboardComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManageMaterialBillboardComponent::SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToAllChannels(NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToAllChannels", NewResponse);
}

void UManageMaterialBillboardComponent::SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToChannel(Channel, NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannel", Channel, NewResponse);
}

void UManageMaterialBillboardComponent::SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses)
{
	Super::SetCollisionResponseToChannels(NewReponses);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannels", NewReponses);
}

void UManageMaterialBillboardComponent::SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
}

void UManageMaterialBillboardComponent::SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
}

void UManageMaterialBillboardComponent::SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
{
	Super::SetMassOverrideInKg(BoneName, MassInKg, bOverrideMass);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassOverrideInKg", BoneName, MassInKg, bOverrideMass);
}

void UManageMaterialBillboardComponent::SetMassScale(FName BoneName, float InMassScale)
{
	Super::SetMassScale(BoneName, InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassScale", BoneName, InMassScale);
}

void UManageMaterialBillboardComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
}

void UManageMaterialBillboardComponent::SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent, BoneName);
}

void UManageMaterialBillboardComponent::SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsLinearVelocity(NewVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsLinearVelocity", NewVel, bAddToCurrent, BoneName);
}

void UManageMaterialBillboardComponent::SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
}

void UManageMaterialBillboardComponent::SetUseCCD(bool InUseCCD, FName BoneName)
{
	Super::SetUseCCD(InUseCCD, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUseCCD", InUseCCD, BoneName);
}

void UManageMaterialBillboardComponent::UnWeldChildren()
{
	Super::UnWeldChildren();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
}

void UManageMaterialBillboardComponent::UnWeldFromParent()
{
	Super::UnWeldFromParent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
}

void UManageMaterialBillboardComponent::UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
}

void UManageMaterialBillboardComponent::WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
}

void UManageMaterialBillboardComponent::WakeRigidBody(FName BoneName)
{
	Super::WakeRigidBody(BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeRigidBody", BoneName);
}

void UManageMaterialBillboardComponent::WeldTo(USceneComponent* InParent, FName InSocketName)
{
	Super::WeldTo(InParent, InSocketName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WeldTo", InParent, InSocketName);
}

void UManageMaterialBillboardComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageMaterialBillboardComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageMaterialBillboardComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
}

void UManageMaterialBillboardComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageMaterialBillboardComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageMaterialBillboardComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageMaterialBillboardComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageMaterialBillboardComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
}

void UManageMaterialBillboardComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageMaterialBillboardComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageMaterialBillboardComponent::UpdateBounds()
{
	Super::UpdateBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
}

void UManageMaterialBillboardComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

void UManageMaterialBillboardComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
}

void UManageMaterialBillboardComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageMaterialBillboardComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageMaterialBillboardComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageMaterialBillboardComponent::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void UManageMaterialBillboardComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageMaterialBillboardComponent::Deactivate()
{
	Super::Deactivate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
}

void UManageMaterialBillboardComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageMaterialBillboardComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageMaterialBillboardComponent::InitializeComponent()
{
	Super::InitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
}

void UManageMaterialBillboardComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageMaterialBillboardComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageMaterialBillboardComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
}

void UManageMaterialBillboardComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageMaterialBillboardComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageMaterialBillboardComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageMaterialBillboardComponent::OnRegister()
{
	Super::OnRegister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
}

void UManageMaterialBillboardComponent::OnRep_IsActive()
{
	Super::OnRep_IsActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
}

void UManageMaterialBillboardComponent::OnUnregister()
{
	Super::OnUnregister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
}

void UManageMaterialBillboardComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageMaterialBillboardComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageMaterialBillboardComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageMaterialBillboardComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageMaterialBillboardComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageMaterialBillboardComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageMaterialBillboardComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageMaterialBillboardComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageMaterialBillboardComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageMaterialBillboardComponent::ToggleActive()
{
	Super::ToggleActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
}

void UManageMaterialBillboardComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
}

void UManageMaterialBillboardComponent::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void UManageMaterialBillboardComponent::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void UManageMaterialBillboardComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageMaterialBillboardComponent::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void UManageMaterialBillboardComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void UManageMaterialBillboardComponent::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void UManageMaterialBillboardComponent::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void UManageMaterialBillboardComponent::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void UManageMaterialBillboardComponent::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void UManageMaterialBillboardComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageMaterialBillboardComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void UManageMaterialBillboardComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageMaterialBillboardComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageMaterialBillboardComponent::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void UManageMaterialBillboardComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void UManageMaterialBillboardComponent::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void UManageMaterialBillboardComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
