#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageAudioComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

FString UManageAudioComponent::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void UManageAudioComponent::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void UManageAudioComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManageAudioComponent::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void UManageAudioComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManageAudioComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManageAudioComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManageAudioComponent::OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::OnUpdateTransform(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUpdateTransform", UpdateTransformFlags, Teleport);
}

void UManageAudioComponent::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void UManageAudioComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageAudioComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageAudioComponent::DetachFromComponent(const FDetachmentTransformRules& DetachmentRules)
{
	Super::DetachFromComponent(DetachmentRules);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromComponent", DetachmentRules);
}

void UManageAudioComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
}

void UManageAudioComponent::OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnAttachmentChanged");
}

void UManageAudioComponent::OnChildAttached(USceneComponent* ChildComponent)
{
	Super::OnChildAttached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildAttached", ChildComponent);
}

void UManageAudioComponent::OnChildDetached(USceneComponent* ChildComponent)
{
	Super::OnChildDetached(ChildComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnChildDetached", ChildComponent);
}

void UManageAudioComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageAudioComponent::OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnHiddenInGameChanged");
}

void UManageAudioComponent::OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnVisibilityChanged");
}

void UManageAudioComponent::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void UManageAudioComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void UManageAudioComponent::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void UManageAudioComponent::PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PropagateLightingScenarioChange");
}

void UManageAudioComponent::SetRelativeScale3D(FVector NewScale3D)
{
	Super::SetRelativeScale3D(NewScale3D);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetRelativeScale3D", NewScale3D);
}

void UManageAudioComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
}

void UManageAudioComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageAudioComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageAudioComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManageAudioComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageAudioComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageAudioComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManageAudioComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageAudioComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageAudioComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageAudioComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManageAudioComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageAudioComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageAudioComponent::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void UManageAudioComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageAudioComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageAudioComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageAudioComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageAudioComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageAudioComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageAudioComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageAudioComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageAudioComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageAudioComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageAudioComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManageAudioComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManageAudioComponent::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void UManageAudioComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void UManageAudioComponent::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void UManageAudioComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageAudioComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageAudioComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void UManageAudioComponent::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void UManageAudioComponent::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void UManageAudioComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
