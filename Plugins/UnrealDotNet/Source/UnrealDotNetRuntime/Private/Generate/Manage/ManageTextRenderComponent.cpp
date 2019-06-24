// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageTextRenderComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

void UManageTextRenderComponent::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageTextRenderComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageTextRenderComponent::OnComponentCollisionSettingsChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
	else
		Super::OnComponentCollisionSettingsChanged();
}

void UManageTextRenderComponent::_Supper__OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
}

void UManageTextRenderComponent::PutAllRigidBodiesToSleep()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
	else
		Super::PutAllRigidBodiesToSleep();
}

void UManageTextRenderComponent::_Supper__PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
}

void UManageTextRenderComponent::SetAllMassScale(float InMassScale)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
	else
		Super::SetAllMassScale(InMassScale);
}

void UManageTextRenderComponent::_Supper__SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
}

void UManageTextRenderComponent::SetAllUseCCD(bool InUseCCD)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
	else
		Super::SetAllUseCCD(InUseCCD);
}

void UManageTextRenderComponent::_Supper__SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
}

void UManageTextRenderComponent::SetAngularDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
	else
		Super::SetAngularDamping(InDamping);
}

void UManageTextRenderComponent::_Supper__SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
}

void UManageTextRenderComponent::SetEnableGravity(bool bGravityEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
	else
		Super::SetEnableGravity(bGravityEnabled);
}

void UManageTextRenderComponent::_Supper__SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
}

void UManageTextRenderComponent::SetLinearDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
	else
		Super::SetLinearDamping(InDamping);
}

void UManageTextRenderComponent::_Supper__SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
}

void UManageTextRenderComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
	else
		Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageTextRenderComponent::_Supper__SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageTextRenderComponent::SetSimulatePhysics(bool bSimulate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
	else
		Super::SetSimulatePhysics(bSimulate);
}

void UManageTextRenderComponent::_Supper__SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
}

void UManageTextRenderComponent::UnWeldChildren()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
	else
		Super::UnWeldChildren();
}

void UManageTextRenderComponent::_Supper__UnWeldChildren()
{
	Super::UnWeldChildren();
}

void UManageTextRenderComponent::UnWeldFromParent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
	else
		Super::UnWeldFromParent();
}

void UManageTextRenderComponent::_Supper__UnWeldFromParent()
{
	Super::UnWeldFromParent();
}

void UManageTextRenderComponent::UpdatePhysicsToRBChannels()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
	else
		Super::UpdatePhysicsToRBChannels();
}

void UManageTextRenderComponent::_Supper__UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
}

void UManageTextRenderComponent::WakeAllRigidBodies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
	else
		Super::WakeAllRigidBodies();
}

void UManageTextRenderComponent::_Supper__WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
}

void UManageTextRenderComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
	else
		Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageTextRenderComponent::_Supper__DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageTextRenderComponent::OnAttachmentChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
	else
		Super::OnAttachmentChanged();
}

void UManageTextRenderComponent::_Supper__OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
}

void UManageTextRenderComponent::OnHiddenInGameChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
	else
		Super::OnHiddenInGameChanged();
}

void UManageTextRenderComponent::_Supper__OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
}

void UManageTextRenderComponent::OnVisibilityChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
	else
		Super::OnVisibilityChanged();
}

void UManageTextRenderComponent::_Supper__OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
}

void UManageTextRenderComponent::PropagateLightingScenarioChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
	else
		Super::PropagateLightingScenarioChange();
}

void UManageTextRenderComponent::_Supper__PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
}

void UManageTextRenderComponent::UpdateBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
	else
		Super::UpdateBounds();
}

void UManageTextRenderComponent::_Supper__UpdateBounds()
{
	Super::UpdateBounds();
}

void UManageTextRenderComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
	else
		Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageTextRenderComponent::_Supper__UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageTextRenderComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageTextRenderComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageTextRenderComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageTextRenderComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageTextRenderComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageTextRenderComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageTextRenderComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageTextRenderComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageTextRenderComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageTextRenderComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageTextRenderComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageTextRenderComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageTextRenderComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageTextRenderComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageTextRenderComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageTextRenderComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageTextRenderComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageTextRenderComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageTextRenderComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageTextRenderComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageTextRenderComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageTextRenderComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageTextRenderComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageTextRenderComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageTextRenderComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageTextRenderComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageTextRenderComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageTextRenderComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageTextRenderComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageTextRenderComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageTextRenderComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageTextRenderComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageTextRenderComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageTextRenderComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageTextRenderComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageTextRenderComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageTextRenderComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageTextRenderComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageTextRenderComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageTextRenderComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageTextRenderComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageTextRenderComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageTextRenderComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageTextRenderComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageTextRenderComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageTextRenderComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageTextRenderComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageTextRenderComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageTextRenderComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageTextRenderComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageTextRenderComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageTextRenderComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageTextRenderComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageTextRenderComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageTextRenderComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageTextRenderComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageTextRenderComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageTextRenderComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageTextRenderComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageTextRenderComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageTextRenderComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageTextRenderComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageTextRenderComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageTextRenderComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageTextRenderComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageTextRenderComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageTextRenderComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageTextRenderComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageTextRenderComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageTextRenderComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageTextRenderComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageTextRenderComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageTextRenderComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageTextRenderComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageTextRenderComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageTextRenderComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageTextRenderComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageTextRenderComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageTextRenderComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageTextRenderComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
