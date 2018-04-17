#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Engine/Light.h"
#include "ManageLight.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

UCLASS()
class UNREALDOTNETRUNTIME_API AManageLight : public ALight
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
	
	virtual void OnRep_bEnabled() override;
	
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
	
	virtual void OutsideWorldBounds() override;
	
	virtual void PostActorCreated() override;
	
	virtual void PostInitializeComponents() override;
	
	virtual void PostInitProperties() override;
	
	virtual void PostLoad() override;
	
	virtual void PostNetInit() override;
	
	virtual void PostNetReceive() override;
	
	virtual void PostNetReceiveLocationAndRotation() override;
	
	virtual void PostNetReceivePhysicState() override;
	
	virtual void PostNetReceiveVelocity(const FVector& NewVelocity) override;
	
	virtual void PostRegisterAllComponents() override;
	
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	
	virtual void PostUnregisterAllComponents() override;
	
	virtual void PreInitializeComponents() override;
	
	virtual void PreNetReceive() override;
	
	virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups) override;
	
	virtual void RegisterAllComponents() override;
	
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void ReregisterAllComponents() override;
	
	virtual void RerunConstructionScripts() override;
	
	virtual void Reset() override;
	
	virtual void SetActorHiddenInGame(bool bNewHidden) override;
	
	virtual void SetLifeSpan(float InLifespan) override;
	
	virtual void SetOwner(AActor* NewOwner) override;
	
	virtual void SetReplicateMovement(bool bInReplicateMovement) override;
	
	virtual void TearOff() override;
	
	virtual void TeleportSucceeded(bool bIsATest) override;
	
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
	
	virtual void OnRep_Owner() override;
	
	virtual void RegisterActorTickFunctions(bool bRegister) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
