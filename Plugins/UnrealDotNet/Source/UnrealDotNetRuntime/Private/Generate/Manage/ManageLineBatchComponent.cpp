#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageLineBatchComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

FString UManageLineBatchComponent::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void UManageLineBatchComponent::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void UManageLineBatchComponent::AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulse(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddAngularImpulse", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddAngularImpulseInRadians(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddAngularImpulseInRadians", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddForce(FVector Force, FName BoneName, bool bAccelChange)
{
	Super::AddForce(Force, BoneName, bAccelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForce", Force, BoneName, bAccelChange);
}

void UManageLineBatchComponent::AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocation(Force, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForceAtLocation", Force, Location, BoneName);
}

void UManageLineBatchComponent::AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
{
	Super::AddForceAtLocationLocal(Force, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForceAtLocationLocal", Force, Location, BoneName);
}

void UManageLineBatchComponent::AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
{
	Super::AddImpulse(Impulse, BoneName, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulse", Impulse, BoneName, bVelChange);
}

void UManageLineBatchComponent::AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
{
	Super::AddImpulseAtLocation(Impulse, Location, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulseAtLocation", Impulse, Location, BoneName);
}

void UManageLineBatchComponent::AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff, bAccelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff, bAccelChange);
}

void UManageLineBatchComponent::AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageLineBatchComponent::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void UManageLineBatchComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManageLineBatchComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageLineBatchComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageLineBatchComponent::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void UManageLineBatchComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageLineBatchComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageLineBatchComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnAttachmentChanged");
}

void UManageLineBatchComponent::OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCollisionSettingsChanged");
}

void UManageLineBatchComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageLineBatchComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageLineBatchComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageLineBatchComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManageLineBatchComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManageLineBatchComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageLineBatchComponent::PostDuplicate(bool bDuplicateForPIE)
{
	Super::PostDuplicate(bDuplicateForPIE);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostDuplicate", bDuplicateForPIE);
}

void UManageLineBatchComponent::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void UManageLineBatchComponent::PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PutAllRigidBodiesToSleep");
}

void UManageLineBatchComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageLineBatchComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageLineBatchComponent::SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllMassScale", InMassScale);
}

void UManageLineBatchComponent::SetAllPhysicsAngularVelocity(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocity(NewAngVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsAngularVelocity", NewAngVel, bAddToCurrent);
}

void UManageLineBatchComponent::SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsAngularVelocityInRadians(NewAngVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsAngularVelocityInRadians", NewAngVel, bAddToCurrent);
}

void UManageLineBatchComponent::SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
{
	Super::SetAllPhysicsLinearVelocity(NewVel, bAddToCurrent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsLinearVelocity", NewVel, bAddToCurrent);
}

void UManageLineBatchComponent::SetAllPhysicsPosition(FVector NewPos)
{
	Super::SetAllPhysicsPosition(NewPos);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllPhysicsPosition", NewPos);
}

void UManageLineBatchComponent::SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAllUseCCD", InUseCCD);
}

void UManageLineBatchComponent::SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAngularDamping", InDamping);
}

void UManageLineBatchComponent::SetCollisionObjectType(ECollisionChannel Channel)
{
	Super::SetCollisionObjectType(Channel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionObjectType", Channel);
}

void UManageLineBatchComponent::SetCollisionProfileName(FName InCollisionProfileName)
{
	Super::SetCollisionProfileName(InCollisionProfileName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionProfileName", InCollisionProfileName);
}

void UManageLineBatchComponent::SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToAllChannels(NewResponse);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToAllChannels", NewResponse);
}

void UManageLineBatchComponent::SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
{
	Super::SetCollisionResponseToChannel(Channel, NewResponse);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToChannel", Channel, NewResponse);
}

void UManageLineBatchComponent::SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses)
{
	Super::SetCollisionResponseToChannels(NewReponses);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetCollisionResponseToChannels", NewReponses);
}

void UManageLineBatchComponent::SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
}

void UManageLineBatchComponent::SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLinearDamping", InDamping);
}

void UManageLineBatchComponent::SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
{
	Super::SetMassOverrideInKg(BoneName, MassInKg, bOverrideMass);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMassOverrideInKg", BoneName, MassInKg, bOverrideMass);
}

void UManageLineBatchComponent::SetMassScale(FName BoneName, float InMassScale)
{
	Super::SetMassScale(BoneName, InMassScale);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMassScale", BoneName, InMassScale);
}

void UManageLineBatchComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
}

void UManageLineBatchComponent::SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetSimulatePhysics", bSimulate);
}

void UManageLineBatchComponent::SetUseCCD(bool InUseCCD, FName BoneName)
{
	Super::SetUseCCD(InUseCCD, BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetUseCCD", InUseCCD, BoneName);
}

void UManageLineBatchComponent::UnWeldChildren()
{
	Super::UnWeldChildren();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnWeldChildren");
}

void UManageLineBatchComponent::UnWeldFromParent()
{
	Super::UnWeldFromParent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnWeldFromParent");
}

void UManageLineBatchComponent::UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsToRBChannels");
}

void UManageLineBatchComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

void UManageLineBatchComponent::WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WakeAllRigidBodies");
}

void UManageLineBatchComponent::WakeRigidBody(FName BoneName)
{
	Super::WakeRigidBody(BoneName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WakeRigidBody", BoneName);
}

void UManageLineBatchComponent::WeldTo(USceneComponent* InParent, FName InSocketName)
{
	Super::WeldTo(InParent, InSocketName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WeldTo", InParent, InSocketName);
}

void UManageLineBatchComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageLineBatchComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageLineBatchComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageLineBatchComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageLineBatchComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageLineBatchComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageLineBatchComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageLineBatchComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnVisibilityChanged");
}

void UManageLineBatchComponent::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void UManageLineBatchComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void UManageLineBatchComponent::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void UManageLineBatchComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageLineBatchComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageLineBatchComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManageLineBatchComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageLineBatchComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageLineBatchComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManageLineBatchComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManageLineBatchComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageLineBatchComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManageLineBatchComponent::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void UManageLineBatchComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageLineBatchComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageLineBatchComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageLineBatchComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageLineBatchComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageLineBatchComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageLineBatchComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageLineBatchComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageLineBatchComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManageLineBatchComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManageLineBatchComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void UManageLineBatchComponent::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void UManageLineBatchComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageLineBatchComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageLineBatchComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void UManageLineBatchComponent::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void UManageLineBatchComponent::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void UManageLineBatchComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
