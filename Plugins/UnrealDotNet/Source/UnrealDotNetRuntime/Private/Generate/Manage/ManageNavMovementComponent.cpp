#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageNavMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

FString UManageNavMovementComponent::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void UManageNavMovementComponent::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void UManageNavMovementComponent::RequestDirectMove(const FVector& MoveVelocity, bool bForceMaxSpeed)
{
	Super::RequestDirectMove(MoveVelocity, bForceMaxSpeed);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestDirectMove", MoveVelocity, bForceMaxSpeed);
}

void UManageNavMovementComponent::RequestPathMove(const FVector& MoveInput)
{
	Super::RequestPathMove(MoveInput);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RequestPathMove", MoveInput);
}

void UManageNavMovementComponent::StopActiveMovement()
{
	Super::StopActiveMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopActiveMovement");
}

void UManageNavMovementComponent::StopMovementImmediately()
{
	Super::StopMovementImmediately();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopMovementImmediately");
}

void UManageNavMovementComponent::AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
{
	Super::AddRadialForce(Origin, Radius, Strength, Falloff);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialForce", Origin, Radius, Strength, Falloff);
}

void UManageNavMovementComponent::AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
{
	Super::AddRadialImpulse(Origin, Radius, Strength, Falloff, bVelChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddRadialImpulse", Origin, Radius, Strength, Falloff, bVelChange);
}

void UManageNavMovementComponent::Deactivate()
{
	Super::Deactivate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Deactivate");
}

void UManageNavMovementComponent::HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
{
	Super::HandleImpact(Hit, TimeSlice, MoveDelta);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleImpact", Hit, TimeSlice, MoveDelta);
}

void UManageNavMovementComponent::InitializeComponent()
{
	Super::InitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InitializeComponent");
}

void UManageNavMovementComponent::OnRegister()
{
	Super::OnRegister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRegister");
}

void UManageNavMovementComponent::OnTeleported()
{
	Super::OnTeleported();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnTeleported");
}

void UManageNavMovementComponent::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void UManageNavMovementComponent::RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
}

void UManageNavMovementComponent::SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
{
	Super::SetPlaneConstraintAxisSetting(NewAxisSetting);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintAxisSetting", NewAxisSetting);
}

void UManageNavMovementComponent::SetPlaneConstraintEnabled(bool bEnabled)
{
	Super::SetPlaneConstraintEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintEnabled", bEnabled);
}

void UManageNavMovementComponent::SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
{
	Super::SetPlaneConstraintFromVectors(Forward, Up);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintFromVectors", Forward, Up);
}

void UManageNavMovementComponent::SetPlaneConstraintNormal(FVector PlaneNormal)
{
	Super::SetPlaneConstraintNormal(PlaneNormal);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintNormal", PlaneNormal);
}

void UManageNavMovementComponent::SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	Super::SetPlaneConstraintOrigin(PlaneOrigin);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlaneConstraintOrigin", PlaneOrigin);
}

void UManageNavMovementComponent::SetUpdatedComponent(USceneComponent* NewUpdatedComponent)
{
	Super::SetUpdatedComponent(NewUpdatedComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetUpdatedComponent", NewUpdatedComponent);
}

void UManageNavMovementComponent::SnapUpdatedComponentToPlane()
{
	Super::SnapUpdatedComponentToPlane();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SnapUpdatedComponentToPlane");
}

void UManageNavMovementComponent::UpdateComponentVelocity()
{
	Super::UpdateComponentVelocity();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateComponentVelocity");
}

void UManageNavMovementComponent::UpdateTickRegistration()
{
	Super::UpdateTickRegistration();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateTickRegistration");
}

void UManageNavMovementComponent::Activate(bool bReset)
{
	Super::Activate(bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Activate", bReset);
}

void UManageNavMovementComponent::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void UManageNavMovementComponent::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageNavMovementComponent::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void UManageNavMovementComponent::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void UManageNavMovementComponent::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void UManageNavMovementComponent::CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateRenderState_Concurrent");
}

void UManageNavMovementComponent::DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyComponent", bPromoteChildren);
}

void UManageNavMovementComponent::DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyRenderState_Concurrent");
}

void UManageNavMovementComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageNavMovementComponent::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageNavMovementComponent::OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnActorEnableCollisionChanged");
}

void UManageNavMovementComponent::OnComponentCreated()
{
	Super::OnComponentCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentCreated");
}

void UManageNavMovementComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
}

void UManageNavMovementComponent::OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCreatePhysicsState");
}

void UManageNavMovementComponent::OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnDestroyPhysicsState");
}

void UManageNavMovementComponent::OnUnregister()
{
	Super::OnUnregister();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnregister");
}

void UManageNavMovementComponent::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void UManageNavMovementComponent::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void UManageNavMovementComponent::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageNavMovementComponent::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void UManageNavMovementComponent::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void UManageNavMovementComponent::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void UManageNavMovementComponent::SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderDynamicData_Concurrent");
}

void UManageNavMovementComponent::SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SendRenderTransform_Concurrent");
}

void UManageNavMovementComponent::SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActive", bNewActive, bReset);
}

void UManageNavMovementComponent::SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
}

void UManageNavMovementComponent::SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
}

void UManageNavMovementComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
}

void UManageNavMovementComponent::ToggleActive()
{
	Super::ToggleActive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ToggleActive");
}

void UManageNavMovementComponent::UninitializeComponent()
{
	Super::UninitializeComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UninitializeComponent");
}

void UManageNavMovementComponent::UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
{
	Super::UpdateComponentToWorld(UpdateTransformFlags, Teleport);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateComponentToWorld", UpdateTransformFlags, Teleport);
}

void UManageNavMovementComponent::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void UManageNavMovementComponent::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void UManageNavMovementComponent::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void UManageNavMovementComponent::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void UManageNavMovementComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageNavMovementComponent::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageNavMovementComponent::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void UManageNavMovementComponent::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void UManageNavMovementComponent::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void UManageNavMovementComponent::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
