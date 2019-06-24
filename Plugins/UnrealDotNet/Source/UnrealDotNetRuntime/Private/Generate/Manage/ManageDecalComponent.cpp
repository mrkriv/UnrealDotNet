// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageDecalComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

void UManageDecalComponent::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageDecalComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageDecalComponent::LifeSpanCallback()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanCallback");
	else
		Super::LifeSpanCallback();
}

void UManageDecalComponent::_Supper__LifeSpanCallback()
{
	Super::LifeSpanCallback();
}

void UManageDecalComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
	else
		Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageDecalComponent::_Supper__DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageDecalComponent::OnAttachmentChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
	else
		Super::OnAttachmentChanged();
}

void UManageDecalComponent::_Supper__OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
}

void UManageDecalComponent::OnHiddenInGameChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
	else
		Super::OnHiddenInGameChanged();
}

void UManageDecalComponent::_Supper__OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
}

void UManageDecalComponent::OnVisibilityChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
	else
		Super::OnVisibilityChanged();
}

void UManageDecalComponent::_Supper__OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
}

void UManageDecalComponent::PropagateLightingScenarioChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
	else
		Super::PropagateLightingScenarioChange();
}

void UManageDecalComponent::_Supper__PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
}

void UManageDecalComponent::UpdateBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
	else
		Super::UpdateBounds();
}

void UManageDecalComponent::_Supper__UpdateBounds()
{
	Super::UpdateBounds();
}

void UManageDecalComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
	else
		Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageDecalComponent::_Supper__UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageDecalComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageDecalComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageDecalComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageDecalComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageDecalComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageDecalComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageDecalComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageDecalComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageDecalComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageDecalComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageDecalComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageDecalComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageDecalComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageDecalComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageDecalComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageDecalComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageDecalComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageDecalComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageDecalComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageDecalComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageDecalComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageDecalComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageDecalComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageDecalComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageDecalComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageDecalComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageDecalComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageDecalComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageDecalComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageDecalComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageDecalComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageDecalComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageDecalComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageDecalComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageDecalComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageDecalComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageDecalComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageDecalComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageDecalComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageDecalComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageDecalComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageDecalComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageDecalComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageDecalComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageDecalComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageDecalComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageDecalComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageDecalComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageDecalComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageDecalComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageDecalComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageDecalComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageDecalComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageDecalComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageDecalComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageDecalComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageDecalComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageDecalComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageDecalComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageDecalComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageDecalComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageDecalComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageDecalComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageDecalComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageDecalComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageDecalComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageDecalComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageDecalComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageDecalComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageDecalComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageDecalComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageDecalComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageDecalComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageDecalComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageDecalComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageDecalComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageDecalComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageDecalComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageDecalComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageDecalComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
