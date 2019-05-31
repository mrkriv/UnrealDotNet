#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/MaterialBillboardComponent.h"
#include "ManageMaterialBillboardComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

UCLASS()
class UNREALDOTNETRUNTIME_API UManageMaterialBillboardComponent : public UMaterialBillboardComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	virtual void AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange) override;
	virtual void AddForce(FVector Force, FName BoneName, bool bAccelChange) override;
	virtual void AddForceAtLocation(FVector Force, FVector Location, FName BoneName) override;
	virtual void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName) override;
	virtual void AddImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName) override;
	virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange) override;
	virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) override;
	virtual void AddTorqueInRadians(FVector Torque, FName BoneName, bool bAccelChange) override;
	virtual void OnComponentCollisionSettingsChanged() override;
	virtual void PutAllRigidBodiesToSleep() override;
	virtual void ReceiveComponentDamage(float DamageAmount, const FDamageEvent& DamageEvent, AController* EventInstigator, AActor* DamageCauser) override;
	virtual void SetAllMassScale(float InMassScale) override;
	virtual void SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent) override;
	virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent) override;
	virtual void SetAllPhysicsPosition(FVector NewPos) override;
	virtual void SetAllPhysicsRotation(FRotator NewRot) override;
	virtual void SetAllUseCCD(bool InUseCCD) override;
	virtual void SetAngularDamping(float InDamping) override;
	virtual void SetCollisionObjectType(ECollisionChannel Channel) override;
	virtual void SetCollisionProfileName(FName InCollisionProfileName) override;
	virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse) override;
	virtual void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse) override;
	virtual void SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses) override;
	virtual void SetEnableGravity(bool bGravityEnabled) override;
	virtual void SetLinearDamping(float InDamping) override;
	virtual void SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass) override;
	virtual void SetMassScale(FName BoneName, float InMassScale) override;
	virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision) override;
	virtual void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, FName BoneName) override;
	virtual void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, FName BoneName) override;
	virtual void SetSimulatePhysics(bool bSimulate) override;
	virtual void SetUseCCD(bool InUseCCD, FName BoneName) override;
	virtual void UnWeldChildren() override;
	virtual void UnWeldFromParent() override;
	virtual void UpdatePhysicsToRBChannels() override;
	virtual void WakeAllRigidBodies() override;
	virtual void WakeRigidBody(FName BoneName) override;
	virtual void WeldTo(USceneComponent* InParent, FName InSocketName) override;
	virtual void DetachFromComponent(const FDetachmentTransformRules& DetachmentRules) override;
	virtual void DetachFromParent(bool bMaintainWorldPosition, bool bCallModify) override;
	virtual void OnAttachmentChanged() override;
	virtual void OnChildAttached(USceneComponent* ChildComponent) override;
	virtual void OnChildDetached(USceneComponent* ChildComponent) override;
	virtual void OnHiddenInGameChanged() override;
	virtual void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) override;
	virtual void OnVisibilityChanged() override;
	virtual void PropagateLightingScenarioChange() override;
	virtual void SetRelativeScale3D(FVector NewScale3D) override;
	virtual void UpdateBounds() override;
	virtual void UpdatePhysicsVolume(bool bTriggerNotifiers) override;
	virtual void Activate(bool bReset) override;
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	virtual void BeginPlay() override;
	virtual void CreateRenderState_Concurrent() override;
	virtual void Deactivate() override;
	virtual void DestroyComponent(bool bPromoteChildren) override;
	virtual void DestroyRenderState_Concurrent() override;
	virtual void InitializeComponent() override;
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	virtual void OnActorEnableCollisionChanged() override;
	virtual void OnComponentCreated() override;
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	virtual void OnCreatePhysicsState() override;
	virtual void OnDestroyPhysicsState() override;
	virtual void OnRegister() override;
	virtual void OnRep_IsActive() override;
	virtual void OnUnregister() override;
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void SendRenderDynamicData_Concurrent() override;
	virtual void SendRenderTransform_Concurrent() override;
	virtual void SetActive(bool bNewActive, bool bReset) override;
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	virtual void ToggleActive() override;
	virtual void UninitializeComponent() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void OverridePerObjectConfigSection(FString& SectionName) override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
