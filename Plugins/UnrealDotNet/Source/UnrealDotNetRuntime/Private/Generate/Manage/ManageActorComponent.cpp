#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageActorComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManageActorComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManageActorComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageActorComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageActorComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageActorComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManageActorComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageActorComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManageActorComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageActorComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageActorComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManageActorComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageActorComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageActorComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManageActorComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageActorComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageActorComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageActorComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManageActorComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManageActorComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageActorComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageActorComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageActorComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageActorComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageActorComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageActorComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageActorComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageActorComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageActorComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManageActorComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManageActorComponent::UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::UpdateComponentToWorld(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateComponentToWorld", UpdateTransformFlags, Teleport);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
