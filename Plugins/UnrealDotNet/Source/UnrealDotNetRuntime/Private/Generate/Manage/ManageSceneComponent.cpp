#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageSceneComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManageSceneComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageSceneComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageSceneComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnAttachmentChanged");
}

void UManageSceneComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageSceneComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageSceneComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageSceneComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnVisibilityChanged");
}

void UManageSceneComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageSceneComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageSceneComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
