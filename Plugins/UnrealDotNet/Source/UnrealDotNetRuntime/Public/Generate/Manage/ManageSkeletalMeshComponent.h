#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/SkeletalMeshComponent.h"
#include "ManageSkeletalMeshComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:254

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSkeletalMeshComponent : public USkeletalMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	UFUNCTION(BlueprintCallable, Category = "C#")
	FString GetProperty(const FString& Property);
	
	UFUNCTION(BlueprintCallable, Category = "C#")
	void SetProperty(const FString& Property, const FString& Value);
	
	
public:
	
	virtual void BeginDestroy() override;
	
	virtual void ClearRefPoseOverride() override;
	
	virtual void CreateRenderState_Concurrent() override;
	
	virtual void DestroyRenderState_Concurrent() override;
	
	virtual void OnRegister() override;
	
	virtual void OnUnregister() override;
	
	virtual void AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	
	virtual void AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange) override;
	
	virtual void AddForce(FVector Force, FName BoneName, bool bAccelChange) override;
	
	virtual void AddForceAtLocation(FVector Force, FVector Location, FName BoneName) override;
	
	virtual void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName) override;
	
	virtual void AddImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	
	virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName) override;
	
	virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange) override;
	
	virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) override;
	
	virtual void BeginPlay() override;
	
	virtual void FinishDestroy() override;
	
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	
	virtual void OnActorEnableCollisionChanged() override;
	
	virtual void OnAttachmentChanged() override;
	
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	
	virtual void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) override;
	
	virtual void PostDuplicate(bool bDuplicateForPIE) override;
	
	virtual void PostLoad() override;
	
	virtual void PutAllRigidBodiesToSleep() override;
	
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	
	virtual void SendRenderTransform_Concurrent() override;
	
	virtual void SetAllMassScale(float InMassScale) override;
	
	virtual void SetAllPhysicsAngularVelocity(const FVector& NewAngVel, bool bAddToCurrent) override;
	
	virtual void SetAllPhysicsAngularVelocityInRadians(const FVector& NewAngVel, bool bAddToCurrent) override;
	
	virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent) override;
	
	virtual void SetAllPhysicsPosition(FVector NewPos) override;
	
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
	
	virtual void SetSimulatePhysics(bool bSimulate) override;
	
	virtual void SetUseCCD(bool InUseCCD, FName BoneName) override;
	
	virtual void UnWeldChildren() override;
	
	virtual void UnWeldFromParent() override;
	
	virtual void UpdatePhysicsVolume(bool bTriggerNotifiers) override;
	
	virtual void WakeAllRigidBodies() override;
	
	virtual void WakeRigidBody(FName BoneName) override;
	
	virtual void WeldTo(USceneComponent* InParent, FName InSocketName) override;
	
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	
	virtual void DestroyComponent(bool bPromoteChildren) override;
	
	virtual void DetachFromComponent(const FDetachmentTransformRules& DetachmentRules) override;
	
	virtual void DetachFromParent(bool bMaintainWorldPosition, bool bCallModify) override;
	
	virtual void PostNetReceive() override;
	
	virtual void PostRepNotifies() override;
	
	virtual void PreNetReceive() override;
	
	virtual void PropagateLightingScenarioChange() override;
	
	virtual void SetRelativeScale3D(FVector NewScale3D) override;
	
	virtual void Activate(bool bReset) override;
	
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void Deactivate() override;
	
	virtual void InitializeComponent() override;
	
	virtual void MarkAsEditorOnlySubobject() override;
	
	virtual void OnComponentCreated() override;
	
	virtual void PostInitProperties() override;
	
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void SetActive(bool bNewActive, bool bReset) override;
	
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	
	virtual void ToggleActive() override;
	
	virtual void UninitializeComponent() override;
	
	virtual void PostCDOContruct() override;
	
	virtual void PostEditImport() override;
	
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	
	virtual void PreDestroyFromReplication() override;
	
	virtual void ShutdownAfterError() override;
	
	virtual void AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) override;
	
	virtual void CreateCluster() override;
	
	virtual void OnClusterMarkedAsPendingKill() override;
	
protected:
	
	virtual void SendRenderDynamicData_Concurrent() override;
	
	virtual void OnComponentCollisionSettingsChanged() override;
	
	virtual void OnCreatePhysicsState() override;
	
	virtual void OnDestroyPhysicsState() override;
	
	virtual void UpdatePhysicsToRBChannels() override;
	
	virtual void OnChildAttached(USceneComponent* ChildComponent) override;
	
	virtual void OnChildDetached(USceneComponent* ChildComponent) override;
	
	virtual void OnHiddenInGameChanged() override;
	
	virtual void OnVisibilityChanged() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
