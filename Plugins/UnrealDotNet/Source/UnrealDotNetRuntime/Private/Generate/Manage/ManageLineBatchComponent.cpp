// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageLineBatchComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

bool UManageLineBatchComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageLineBatchComponent::DrawLine(const FVector& Start, const FVector& End, const FLinearColor& Color, uint8 DepthPriority, float Thickness, float LifeTime)
{
	Super::DrawLine(Start, End, Color, DepthPriority, Thickness, LifeTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DrawLine", Start, End, Color, DepthPriority, Thickness, LifeTime);
}

void UManageLineBatchComponent::DrawPoint(const FVector& Position, const FLinearColor& Color, float PointSize, uint8 DepthPriority, float LifeTime)
{
	Super::DrawPoint(Position, Color, PointSize, DepthPriority, LifeTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DrawPoint", Position, Color, PointSize, DepthPriority, LifeTime);
}

void UManageLineBatchComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulseInRadians(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddAngularImpulseInRadians", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddForce(FVector Force, FName BoneName, bool bAccelChange)
{
	Super::AddForce(Force, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForce", Force, BoneName, bAccelChange);
}

void UManageLineBatchComponent::AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocation(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocation", Force, Location, BoneName);
}

void UManageLineBatchComponent::AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocationLocal(Force, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddForceAtLocationLocal", Force, Location, BoneName);
}

void UManageLineBatchComponent::AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddImpulse(Impulse, BoneName, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulse", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
{
	Super::AddImpulseAtLocation(Impulse, Location, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddImpulseAtLocation", Impulse, Location, BoneName);
}

void UManageLineBatchComponent::AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff, bAccelChange);
}

void UManageLineBatchComponent::AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageLineBatchComponent::AddTorqueInRadians(FVector Torque, FName BoneName, bool bAccelChange)
{
	Super::AddTorqueInRadians(Torque, BoneName, bAccelChange);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTorqueInRadians", Torque, BoneName, bAccelChange);
}

void UManageLineBatchComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManageLineBatchComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManageLineBatchComponent::ReceiveComponentDamage(float DamageAmount, const FDamageEvent& DamageEvent, AController* EventInstigator, AActor* DamageCauser)
{
	Super::ReceiveComponentDamage(DamageAmount, DamageEvent, EventInstigator, DamageCauser);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceiveComponentDamage", DamageAmount, DamageEvent, EventInstigator, DamageCauser);
}

void UManageLineBatchComponent::SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
}

void UManageLineBatchComponent::SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent);
}

void UManageLineBatchComponent::SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsLinearVelocity(NewVel, bAddToCurrent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsLinearVelocity", NewVel, bAddToCurrent);
}

void UManageLineBatchComponent::SetAllPhysicsPosition(FVector NewPos)
{
	Super::SetAllPhysicsPosition(NewPos);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsPosition", NewPos);
}

void UManageLineBatchComponent::SetAllPhysicsRotation(FRotator NewRot)
{
	Super::SetAllPhysicsRotation(NewRot);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllPhysicsRotation", NewRot);
}

void UManageLineBatchComponent::SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
}

void UManageLineBatchComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManageLineBatchComponent::SetCollisionObjectType(ECollisionChannel Channel)
{
	Super::SetCollisionObjectType(Channel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionObjectType", Channel);
}

void UManageLineBatchComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManageLineBatchComponent::SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToAllChannels(NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToAllChannels", NewResponse);
}

void UManageLineBatchComponent::SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToChannel(Channel, NewResponse);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannel", Channel, NewResponse);
}

void UManageLineBatchComponent::SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses)
{
	Super::SetCollisionResponseToChannels(NewReponses);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetCollisionResponseToChannels", NewReponses);
}

void UManageLineBatchComponent::SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
}

void UManageLineBatchComponent::SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
}

void UManageLineBatchComponent::SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
{
	Super::SetMassOverrideInKg(BoneName, MassInKg, bOverrideMass);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassOverrideInKg", BoneName, MassInKg, bOverrideMass);
}

void UManageLineBatchComponent::SetMassScale(FName BoneName, float InMassScale)
{
	Super::SetMassScale(BoneName, InMassScale);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMassScale", BoneName, InMassScale);
}

void UManageLineBatchComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
}

void UManageLineBatchComponent::SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent, BoneName);
}

void UManageLineBatchComponent::SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, FName BoneName)
{
	Super::SetPhysicsLinearVelocity(NewVel, bAddToCurrent, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPhysicsLinearVelocity", NewVel, bAddToCurrent, BoneName);
}

void UManageLineBatchComponent::SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
}

void UManageLineBatchComponent::SetUseCCD(bool InUseCCD, FName BoneName)
{
	Super::SetUseCCD(InUseCCD, BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUseCCD", InUseCCD, BoneName);
}

void UManageLineBatchComponent::UnWeldChildren()
{
	Super::UnWeldChildren();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
}

void UManageLineBatchComponent::UnWeldFromParent()
{
	Super::UnWeldFromParent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
}

void UManageLineBatchComponent::UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
}

void UManageLineBatchComponent::WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
}

void UManageLineBatchComponent::WakeRigidBody(FName BoneName)
{
	Super::WakeRigidBody(BoneName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeRigidBody", BoneName);
}

void UManageLineBatchComponent::WeldTo(USceneComponent* InParent, FName InSocketName)
{
	Super::WeldTo(InParent, InSocketName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WeldTo", InParent, InSocketName);
}

void UManageLineBatchComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageLineBatchComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageLineBatchComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
}

void UManageLineBatchComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageLineBatchComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageLineBatchComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageLineBatchComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageLineBatchComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
}

void UManageLineBatchComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageLineBatchComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageLineBatchComponent::UpdateBounds()
{
	Super::UpdateBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
}

void UManageLineBatchComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

void UManageLineBatchComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
}

void UManageLineBatchComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageLineBatchComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageLineBatchComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageLineBatchComponent::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void UManageLineBatchComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageLineBatchComponent::Deactivate()
{
	Super::Deactivate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
}

void UManageLineBatchComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageLineBatchComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageLineBatchComponent::InitializeComponent()
{
	Super::InitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
}

void UManageLineBatchComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageLineBatchComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageLineBatchComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
}

void UManageLineBatchComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageLineBatchComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageLineBatchComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageLineBatchComponent::OnRegister()
{
	Super::OnRegister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
}

void UManageLineBatchComponent::OnRep_IsActive()
{
	Super::OnRep_IsActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
}

void UManageLineBatchComponent::OnUnregister()
{
	Super::OnUnregister();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
}

void UManageLineBatchComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageLineBatchComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageLineBatchComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageLineBatchComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageLineBatchComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageLineBatchComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageLineBatchComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageLineBatchComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageLineBatchComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageLineBatchComponent::ToggleActive()
{
	Super::ToggleActive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
}

void UManageLineBatchComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
}

void UManageLineBatchComponent::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void UManageLineBatchComponent::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void UManageLineBatchComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageLineBatchComponent::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void UManageLineBatchComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void UManageLineBatchComponent::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void UManageLineBatchComponent::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void UManageLineBatchComponent::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void UManageLineBatchComponent::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void UManageLineBatchComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageLineBatchComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void UManageLineBatchComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageLineBatchComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageLineBatchComponent::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void UManageLineBatchComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void UManageLineBatchComponent::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void UManageLineBatchComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
