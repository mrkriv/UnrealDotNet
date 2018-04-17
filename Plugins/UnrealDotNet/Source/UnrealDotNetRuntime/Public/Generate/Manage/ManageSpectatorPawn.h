#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"
#include "ManageSpectatorPawn.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API AManageSpectatorPawn : public ASpectatorPawn
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
	
	virtual void AddControllerPitchInput(float Val) override;
	
	virtual void AddControllerRollInput(float Val) override;
	
	virtual void AddControllerYawInput(float Val) override;
	
	virtual void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce) override;
	
	virtual void Destroyed() override;
	
	virtual void DetachFromControllerPendingDestroy() override;
	
	virtual void FaceRotation(FRotator NewControlRotation, float DeltaTime) override;
	
	virtual void OnRep_Controller() override;
	
	virtual void OnRep_PlayerState() override;
	
	virtual void OutsideWorldBounds() override;
	
	virtual void PawnClientRestart() override;
	
	virtual void PawnStartFire(uint8 FireModeNum) override;
	
	virtual void PostInitializeComponents() override;
	
	virtual void PostLoad() override;
	
	virtual void PostNetReceiveLocationAndRotation() override;
	
	virtual void PostNetReceiveVelocity(const FVector& NewVelocity) override;
	
	virtual void PostRegisterAllComponents() override;
	
	virtual void PreInitializeComponents() override;
	
	virtual void RecalculateBaseEyeHeight() override;
	
	virtual void Reset() override;
	
	virtual void Restart() override;
	
	virtual void SetPlayerDefaults() override;
	
	virtual void SpawnDefaultController() override;
	
	virtual void TeleportSucceeded(bool bIsATest) override;
	
	virtual void TurnOff() override;
	
	virtual void UnPossessed() override;
	
	virtual void UpdateNavigationRelevance() override;
	
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	
	virtual void BeginDestroy() override;
	
	virtual void BeginPlay() override;
	
	virtual void ClearCrossLevelReferences() override;
	
	virtual void ForceNetRelevant() override;
	
	virtual void ForceNetUpdate() override;
	
	virtual void GatherCurrentMovement() override;
	
	virtual void InvalidateLightingCacheDetailed(bool bTranslationOnly) override;
	
	virtual void K2_DestroyActor() override;
	
	virtual void LifeSpanExpired() override;
	
	virtual void MarkComponentsAsPendingKill() override;
	
	virtual void NotifyActorBeginCursorOver() override;
	
	virtual void NotifyActorBeginOverlap(AActor* OtherActor) override;
	
	virtual void NotifyActorEndCursorOver() override;
	
	virtual void NotifyActorEndOverlap(AActor* OtherActor) override;
	
	virtual void NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit) override;
	
	virtual void OnConstruction(const FTransform& Transform) override;
	
	virtual void OnRep_AttachmentReplication() override;
	
	virtual void OnRep_Instigator() override;
	
	virtual void OnRep_ReplicatedMovement() override;
	
	virtual void OnRep_ReplicateMovement() override;
	
	virtual void OnReplicationPausedChanged(bool bIsReplicationPaused) override;
	
	virtual void OnSubobjectCreatedFromReplication(UObject* NewSubobject) override;
	
	virtual void OnSubobjectDestroyFromReplication(UObject* Subobject) override;
	
	virtual void PostActorCreated() override;
	
	virtual void PostInitProperties() override;
	
	virtual void PostNetInit() override;
	
	virtual void PostNetReceive() override;
	
	virtual void PostNetReceivePhysicState() override;
	
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	
	virtual void PostUnregisterAllComponents() override;
	
	virtual void PreNetReceive() override;
	
	virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups) override;
	
	virtual void RegisterAllComponents() override;
	
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void ReregisterAllComponents() override;
	
	virtual void RerunConstructionScripts() override;
	
	virtual void SetActorHiddenInGame(bool bNewHidden) override;
	
	virtual void SetLifeSpan(float InLifespan) override;
	
	virtual void SetOwner(AActor* NewOwner) override;
	
	virtual void SetReplicateMovement(bool bInReplicateMovement) override;
	
	virtual void TearOff() override;
	
	virtual void Tick(float DeltaSeconds) override;
	
	virtual void TornOff() override;
	
	virtual void UnregisterAllComponents(bool bForReregister) override;
	
	virtual void FinishDestroy() override;
	
	virtual void MarkAsEditorOnlySubobject() override;
	
	virtual void PostCDOContruct() override;
	
	virtual void PostEditImport() override;
	
	virtual void PostRepNotifies() override;
	
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	
	virtual void PreDestroyFromReplication() override;
	
	virtual void ShutdownAfterError() override;
	
	virtual void AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) override;
	
	virtual void CreateCluster() override;
	
	virtual void OnClusterMarkedAsPendingKill() override;
	
protected:
	
	virtual void DestroyPlayerInputComponent() override;
	
	virtual void OnRep_Owner() override;
	
	virtual void RegisterActorTickFunctions(bool bRegister) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
