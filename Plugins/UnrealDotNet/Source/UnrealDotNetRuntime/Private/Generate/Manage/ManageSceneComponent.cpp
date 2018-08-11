#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSceneComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:103

void UManageSceneComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageSceneComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageSceneComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
}

void UManageSceneComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageSceneComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageSceneComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageSceneComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageSceneComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
}

void UManageSceneComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageSceneComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageSceneComponent::UpdateBounds()
{
	Super::UpdateBounds();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
}

void UManageSceneComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
