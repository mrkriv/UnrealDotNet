// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSkeletalMeshComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:279

void UManageSkeletalMeshComponent::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageSkeletalMeshComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageSkeletalMeshComponent::PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);
}

void UManageSkeletalMeshComponent::_Supper__PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);
}

void UManageSkeletalMeshComponent::SetTextureForceResidentFlag(bool bForceMiplevelsToBeResident)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetTextureForceResidentFlag", bForceMiplevelsToBeResident);
	else
		Super::SetTextureForceResidentFlag(bForceMiplevelsToBeResident);
}

void UManageSkeletalMeshComponent::_Supper__SetTextureForceResidentFlag(bool bForceMiplevelsToBeResident)
{
	Super::SetTextureForceResidentFlag(bForceMiplevelsToBeResident);
}

void UManageSkeletalMeshComponent::OnComponentCollisionSettingsChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
	else
		Super::OnComponentCollisionSettingsChanged();
}

void UManageSkeletalMeshComponent::_Supper__OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
}

void UManageSkeletalMeshComponent::PutAllRigidBodiesToSleep()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
	else
		Super::PutAllRigidBodiesToSleep();
}

void UManageSkeletalMeshComponent::_Supper__PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
}

void UManageSkeletalMeshComponent::SetAllMassScale(float InMassScale)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
	else
		Super::SetAllMassScale(InMassScale);
}

void UManageSkeletalMeshComponent::_Supper__SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
}

void UManageSkeletalMeshComponent::SetAllUseCCD(bool InUseCCD)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
	else
		Super::SetAllUseCCD(InUseCCD);
}

void UManageSkeletalMeshComponent::_Supper__SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
}

void UManageSkeletalMeshComponent::SetAngularDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
	else
		Super::SetAngularDamping(InDamping);
}

void UManageSkeletalMeshComponent::_Supper__SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
}

void UManageSkeletalMeshComponent::SetEnableGravity(bool bGravityEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
	else
		Super::SetEnableGravity(bGravityEnabled);
}

void UManageSkeletalMeshComponent::_Supper__SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
}

void UManageSkeletalMeshComponent::SetLinearDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
	else
		Super::SetLinearDamping(InDamping);
}

void UManageSkeletalMeshComponent::_Supper__SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
}

void UManageSkeletalMeshComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
	else
		Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageSkeletalMeshComponent::_Supper__SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageSkeletalMeshComponent::SetSimulatePhysics(bool bSimulate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
	else
		Super::SetSimulatePhysics(bSimulate);
}

void UManageSkeletalMeshComponent::_Supper__SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
}

void UManageSkeletalMeshComponent::UnWeldChildren()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
	else
		Super::UnWeldChildren();
}

void UManageSkeletalMeshComponent::_Supper__UnWeldChildren()
{
	Super::UnWeldChildren();
}

void UManageSkeletalMeshComponent::UnWeldFromParent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
	else
		Super::UnWeldFromParent();
}

void UManageSkeletalMeshComponent::_Supper__UnWeldFromParent()
{
	Super::UnWeldFromParent();
}

void UManageSkeletalMeshComponent::UpdatePhysicsToRBChannels()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
	else
		Super::UpdatePhysicsToRBChannels();
}

void UManageSkeletalMeshComponent::_Supper__UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
}

void UManageSkeletalMeshComponent::WakeAllRigidBodies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
	else
		Super::WakeAllRigidBodies();
}

void UManageSkeletalMeshComponent::_Supper__WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
}

void UManageSkeletalMeshComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
	else
		Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageSkeletalMeshComponent::_Supper__DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageSkeletalMeshComponent::OnAttachmentChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
	else
		Super::OnAttachmentChanged();
}

void UManageSkeletalMeshComponent::_Supper__OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
}

void UManageSkeletalMeshComponent::OnHiddenInGameChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
	else
		Super::OnHiddenInGameChanged();
}

void UManageSkeletalMeshComponent::_Supper__OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
}

void UManageSkeletalMeshComponent::OnVisibilityChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
	else
		Super::OnVisibilityChanged();
}

void UManageSkeletalMeshComponent::_Supper__OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
}

void UManageSkeletalMeshComponent::PropagateLightingScenarioChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
	else
		Super::PropagateLightingScenarioChange();
}

void UManageSkeletalMeshComponent::_Supper__PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
}

void UManageSkeletalMeshComponent::UpdateBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
	else
		Super::UpdateBounds();
}

void UManageSkeletalMeshComponent::_Supper__UpdateBounds()
{
	Super::UpdateBounds();
}

void UManageSkeletalMeshComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
	else
		Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageSkeletalMeshComponent::_Supper__UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageSkeletalMeshComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageSkeletalMeshComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageSkeletalMeshComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageSkeletalMeshComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageSkeletalMeshComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageSkeletalMeshComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageSkeletalMeshComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageSkeletalMeshComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageSkeletalMeshComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageSkeletalMeshComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageSkeletalMeshComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageSkeletalMeshComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageSkeletalMeshComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageSkeletalMeshComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageSkeletalMeshComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageSkeletalMeshComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageSkeletalMeshComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageSkeletalMeshComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageSkeletalMeshComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageSkeletalMeshComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageSkeletalMeshComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageSkeletalMeshComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageSkeletalMeshComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageSkeletalMeshComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageSkeletalMeshComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageSkeletalMeshComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageSkeletalMeshComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageSkeletalMeshComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageSkeletalMeshComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageSkeletalMeshComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageSkeletalMeshComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageSkeletalMeshComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageSkeletalMeshComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageSkeletalMeshComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageSkeletalMeshComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageSkeletalMeshComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageSkeletalMeshComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageSkeletalMeshComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageSkeletalMeshComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageSkeletalMeshComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageSkeletalMeshComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageSkeletalMeshComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageSkeletalMeshComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageSkeletalMeshComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageSkeletalMeshComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageSkeletalMeshComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageSkeletalMeshComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageSkeletalMeshComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageSkeletalMeshComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageSkeletalMeshComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageSkeletalMeshComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageSkeletalMeshComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageSkeletalMeshComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageSkeletalMeshComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageSkeletalMeshComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageSkeletalMeshComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageSkeletalMeshComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageSkeletalMeshComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageSkeletalMeshComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageSkeletalMeshComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageSkeletalMeshComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageSkeletalMeshComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageSkeletalMeshComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageSkeletalMeshComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageSkeletalMeshComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageSkeletalMeshComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageSkeletalMeshComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageSkeletalMeshComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageSkeletalMeshComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageSkeletalMeshComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageSkeletalMeshComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageSkeletalMeshComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageSkeletalMeshComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageSkeletalMeshComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageSkeletalMeshComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageSkeletalMeshComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageSkeletalMeshComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageSkeletalMeshComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageSkeletalMeshComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageSkeletalMeshComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
