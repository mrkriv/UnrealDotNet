// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSpectatorPawnMovement.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawnMovement.h:15

void UManageSpectatorPawnMovement::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageSpectatorPawnMovement::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageSpectatorPawnMovement::ApplyControlInputToVelocity(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyControlInputToVelocity", DeltaTime);
	else
		Super::ApplyControlInputToVelocity(DeltaTime);
}

void UManageSpectatorPawnMovement::_Supper__ApplyControlInputToVelocity(float DeltaTime)
{
	Super::ApplyControlInputToVelocity(DeltaTime);
}

void UManageSpectatorPawnMovement::StopActiveMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopActiveMovement");
	else
		Super::StopActiveMovement();
}

void UManageSpectatorPawnMovement::_Supper__StopActiveMovement()
{
	Super::StopActiveMovement();
}

void UManageSpectatorPawnMovement::OnTeleported()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnTeleported");
	else
		Super::OnTeleported();
}

void UManageSpectatorPawnMovement::_Supper__OnTeleported()
{
	Super::OnTeleported();
}

void UManageSpectatorPawnMovement::SetPlaneConstraintEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
	else
		Super::SetPlaneConstraintEnabled(bEnabled);
}

void UManageSpectatorPawnMovement::_Supper__SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
}

void UManageSpectatorPawnMovement::SnapUpdatedComponentToPlane()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SnapUpdatedComponentToPlane");
	else
		Super::SnapUpdatedComponentToPlane();
}

void UManageSpectatorPawnMovement::_Supper__SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
}

void UManageSpectatorPawnMovement::StopMovementImmediately()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopMovementImmediately");
	else
		Super::StopMovementImmediately();
}

void UManageSpectatorPawnMovement::_Supper__StopMovementImmediately()
{
	Super::StopMovementImmediately();
}

void UManageSpectatorPawnMovement::UpdateComponentVelocity()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateComponentVelocity");
	else
		Super::UpdateComponentVelocity();
}

void UManageSpectatorPawnMovement::_Supper__UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
}

void UManageSpectatorPawnMovement::UpdateTickRegistration()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateTickRegistration");
	else
		Super::UpdateTickRegistration();
}

void UManageSpectatorPawnMovement::_Supper__UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
}

void UManageSpectatorPawnMovement::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageSpectatorPawnMovement::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageSpectatorPawnMovement::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageSpectatorPawnMovement::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageSpectatorPawnMovement::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageSpectatorPawnMovement::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageSpectatorPawnMovement::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageSpectatorPawnMovement::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageSpectatorPawnMovement::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageSpectatorPawnMovement::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageSpectatorPawnMovement::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageSpectatorPawnMovement::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageSpectatorPawnMovement::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageSpectatorPawnMovement::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageSpectatorPawnMovement::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageSpectatorPawnMovement::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageSpectatorPawnMovement::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageSpectatorPawnMovement::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageSpectatorPawnMovement::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageSpectatorPawnMovement::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageSpectatorPawnMovement::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageSpectatorPawnMovement::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageSpectatorPawnMovement::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageSpectatorPawnMovement::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageSpectatorPawnMovement::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageSpectatorPawnMovement::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageSpectatorPawnMovement::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageSpectatorPawnMovement::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageSpectatorPawnMovement::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageSpectatorPawnMovement::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageSpectatorPawnMovement::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageSpectatorPawnMovement::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageSpectatorPawnMovement::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageSpectatorPawnMovement::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageSpectatorPawnMovement::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageSpectatorPawnMovement::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageSpectatorPawnMovement::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageSpectatorPawnMovement::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageSpectatorPawnMovement::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageSpectatorPawnMovement::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageSpectatorPawnMovement::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageSpectatorPawnMovement::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageSpectatorPawnMovement::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageSpectatorPawnMovement::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageSpectatorPawnMovement::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageSpectatorPawnMovement::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageSpectatorPawnMovement::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageSpectatorPawnMovement::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageSpectatorPawnMovement::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageSpectatorPawnMovement::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageSpectatorPawnMovement::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageSpectatorPawnMovement::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageSpectatorPawnMovement::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageSpectatorPawnMovement::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageSpectatorPawnMovement::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageSpectatorPawnMovement::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageSpectatorPawnMovement::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageSpectatorPawnMovement::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageSpectatorPawnMovement::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageSpectatorPawnMovement::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageSpectatorPawnMovement::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageSpectatorPawnMovement::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageSpectatorPawnMovement::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageSpectatorPawnMovement::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageSpectatorPawnMovement::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageSpectatorPawnMovement::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageSpectatorPawnMovement::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageSpectatorPawnMovement::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageSpectatorPawnMovement::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageSpectatorPawnMovement::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageSpectatorPawnMovement::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageSpectatorPawnMovement::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageSpectatorPawnMovement::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageSpectatorPawnMovement::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageSpectatorPawnMovement::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageSpectatorPawnMovement::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageSpectatorPawnMovement::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageSpectatorPawnMovement::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageSpectatorPawnMovement::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageSpectatorPawnMovement::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
