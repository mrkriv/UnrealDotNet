#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePrimitiveComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:170

FString UManagePrimitiveComponent::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void UManagePrimitiveComponent::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void UManagePrimitiveComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManagePrimitiveComponent::AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulseInRadians(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddAngularImpulseInRadians", Impulse, BoneName, bVelChange);
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

void UManagePrimitiveComponent::AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff, bAccelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff, bAccelChange);
}

void UManagePrimitiveComponent::AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManagePrimitiveComponent::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void UManagePrimitiveComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManagePrimitiveComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManagePrimitiveComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManagePrimitiveComponent::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void UManagePrimitiveComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManagePrimitiveComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManagePrimitiveComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnAttachmentChanged");
}

void UManagePrimitiveComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManagePrimitiveComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManagePrimitiveComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManagePrimitiveComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManagePrimitiveComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManagePrimitiveComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManagePrimitiveComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManagePrimitiveComponent::PostDuplicate(bool bDuplicateForPIE)
{
	Super::PostDuplicate(bDuplicateForPIE);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostDuplicate", bDuplicateForPIE);
}

void UManagePrimitiveComponent::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void UManagePrimitiveComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManagePrimitiveComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManagePrimitiveComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
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

void UManagePrimitiveComponent::SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent);
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

void UManagePrimitiveComponent::SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllUseCCD", InUseCCD);
}

void UManagePrimitiveComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManagePrimitiveComponent::SetCollisionObjectType(ECollisionChannel Channel)
{
	Super::SetCollisionObjectType(Channel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionObjectType", Channel);
}

void UManagePrimitiveComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManagePrimitiveComponent::SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToAllChannels(NewResponse);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToAllChannels", NewResponse);
}

void UManagePrimitiveComponent::SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToChannel(Channel, NewResponse);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToChannel", Channel, NewResponse);
}

void UManagePrimitiveComponent::SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses)
{
	Super::SetCollisionResponseToChannels(NewReponses);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToChannels", NewReponses);
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

void UManagePrimitiveComponent::SetUseCCD(bool InUseCCD, FName BoneName)
{
	Super::SetUseCCD(InUseCCD, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetUseCCD", InUseCCD, BoneName);
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

void UManagePrimitiveComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
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

void UManagePrimitiveComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManagePrimitiveComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManagePrimitiveComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManagePrimitiveComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManagePrimitiveComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManagePrimitiveComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManagePrimitiveComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManagePrimitiveComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnVisibilityChanged");
}

void UManagePrimitiveComponent::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void UManagePrimitiveComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void UManagePrimitiveComponent::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void UManagePrimitiveComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManagePrimitiveComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManagePrimitiveComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManagePrimitiveComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManagePrimitiveComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManagePrimitiveComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManagePrimitiveComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManagePrimitiveComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManagePrimitiveComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManagePrimitiveComponent::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void UManagePrimitiveComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManagePrimitiveComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManagePrimitiveComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManagePrimitiveComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManagePrimitiveComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManagePrimitiveComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManagePrimitiveComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManagePrimitiveComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManagePrimitiveComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManagePrimitiveComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManagePrimitiveComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void UManagePrimitiveComponent::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void UManagePrimitiveComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManagePrimitiveComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void UManagePrimitiveComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void UManagePrimitiveComponent::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void UManagePrimitiveComponent::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void UManagePrimitiveComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
