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

void UManageMaterialBillboardComponent::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

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

void UManageMaterialBillboardComponent::OnComponentCollisionSettingsChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
	else
		Super::OnComponentCollisionSettingsChanged();
}

void UManageMaterialBillboardComponent::_Supper__OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
}

void UManageMaterialBillboardComponent::PutAllRigidBodiesToSleep()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
	else
		Super::PutAllRigidBodiesToSleep();
}

void UManageMaterialBillboardComponent::_Supper__PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
}

void UManageMaterialBillboardComponent::SetAllMassScale(float InMassScale)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
	else
		Super::SetAllMassScale(InMassScale);
}

void UManageMaterialBillboardComponent::_Supper__SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
}

void UManageMaterialBillboardComponent::SetAllUseCCD(bool InUseCCD)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
	else
		Super::SetAllUseCCD(InUseCCD);
}

void UManageMaterialBillboardComponent::_Supper__SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
}

void UManageMaterialBillboardComponent::SetAngularDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
	else
		Super::SetAngularDamping(InDamping);
}

void UManageMaterialBillboardComponent::_Supper__SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
}

void UManageMaterialBillboardComponent::SetEnableGravity(bool bGravityEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
	else
		Super::SetEnableGravity(bGravityEnabled);
}

void UManageMaterialBillboardComponent::_Supper__SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
}

void UManageMaterialBillboardComponent::SetLinearDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
	else
		Super::SetLinearDamping(InDamping);
}

void UManageMaterialBillboardComponent::_Supper__SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
}

void UManageMaterialBillboardComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
	else
		Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageMaterialBillboardComponent::_Supper__SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageMaterialBillboardComponent::SetSimulatePhysics(bool bSimulate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
	else
		Super::SetSimulatePhysics(bSimulate);
}

void UManageMaterialBillboardComponent::_Supper__SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
}

void UManageMaterialBillboardComponent::UnWeldChildren()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
	else
		Super::UnWeldChildren();
}

void UManageMaterialBillboardComponent::_Supper__UnWeldChildren()
{
	Super::UnWeldChildren();
}

void UManageMaterialBillboardComponent::UnWeldFromParent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
	else
		Super::UnWeldFromParent();
}

void UManageMaterialBillboardComponent::_Supper__UnWeldFromParent()
{
	Super::UnWeldFromParent();
}

void UManageMaterialBillboardComponent::UpdatePhysicsToRBChannels()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
	else
		Super::UpdatePhysicsToRBChannels();
}

void UManageMaterialBillboardComponent::_Supper__UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
}

void UManageMaterialBillboardComponent::WakeAllRigidBodies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
	else
		Super::WakeAllRigidBodies();
}

void UManageMaterialBillboardComponent::_Supper__WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
}

void UManageMaterialBillboardComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
	else
		Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageMaterialBillboardComponent::_Supper__DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageMaterialBillboardComponent::OnAttachmentChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
	else
		Super::OnAttachmentChanged();
}

void UManageMaterialBillboardComponent::_Supper__OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
}

void UManageMaterialBillboardComponent::OnHiddenInGameChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
	else
		Super::OnHiddenInGameChanged();
}

void UManageMaterialBillboardComponent::_Supper__OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
}

void UManageMaterialBillboardComponent::OnVisibilityChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
	else
		Super::OnVisibilityChanged();
}

void UManageMaterialBillboardComponent::_Supper__OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
}

void UManageMaterialBillboardComponent::PropagateLightingScenarioChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
	else
		Super::PropagateLightingScenarioChange();
}

void UManageMaterialBillboardComponent::_Supper__PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
}

void UManageMaterialBillboardComponent::UpdateBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
	else
		Super::UpdateBounds();
}

void UManageMaterialBillboardComponent::_Supper__UpdateBounds()
{
	Super::UpdateBounds();
}

void UManageMaterialBillboardComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
	else
		Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageMaterialBillboardComponent::_Supper__UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageMaterialBillboardComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageMaterialBillboardComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageMaterialBillboardComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageMaterialBillboardComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageMaterialBillboardComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageMaterialBillboardComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageMaterialBillboardComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageMaterialBillboardComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageMaterialBillboardComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageMaterialBillboardComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageMaterialBillboardComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageMaterialBillboardComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageMaterialBillboardComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageMaterialBillboardComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageMaterialBillboardComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageMaterialBillboardComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageMaterialBillboardComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageMaterialBillboardComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageMaterialBillboardComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageMaterialBillboardComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageMaterialBillboardComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageMaterialBillboardComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageMaterialBillboardComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageMaterialBillboardComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageMaterialBillboardComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageMaterialBillboardComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageMaterialBillboardComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageMaterialBillboardComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageMaterialBillboardComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageMaterialBillboardComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageMaterialBillboardComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageMaterialBillboardComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageMaterialBillboardComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageMaterialBillboardComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageMaterialBillboardComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageMaterialBillboardComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageMaterialBillboardComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageMaterialBillboardComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageMaterialBillboardComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageMaterialBillboardComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageMaterialBillboardComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageMaterialBillboardComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageMaterialBillboardComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageMaterialBillboardComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageMaterialBillboardComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageMaterialBillboardComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageMaterialBillboardComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageMaterialBillboardComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageMaterialBillboardComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageMaterialBillboardComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageMaterialBillboardComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageMaterialBillboardComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageMaterialBillboardComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageMaterialBillboardComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageMaterialBillboardComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageMaterialBillboardComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageMaterialBillboardComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageMaterialBillboardComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageMaterialBillboardComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageMaterialBillboardComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageMaterialBillboardComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageMaterialBillboardComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageMaterialBillboardComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageMaterialBillboardComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageMaterialBillboardComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageMaterialBillboardComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageMaterialBillboardComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageMaterialBillboardComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageMaterialBillboardComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageMaterialBillboardComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageMaterialBillboardComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageMaterialBillboardComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageMaterialBillboardComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageMaterialBillboardComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageMaterialBillboardComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageMaterialBillboardComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageMaterialBillboardComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageMaterialBillboardComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageMaterialBillboardComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageMaterialBillboardComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
