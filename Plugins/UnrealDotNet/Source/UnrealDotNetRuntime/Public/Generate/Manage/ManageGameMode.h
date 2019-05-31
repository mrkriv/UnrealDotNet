#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameMode.h"
#include "ManageGameMode.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

UCLASS()
class UNREALDOTNETRUNTIME_API AManageGameMode : public AGameMode, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void AbortMatch() override;
	virtual void AddInactivePlayer(APlayerState* PlayerState, APlayerController* PC) override;
	virtual void Broadcast(AActor* Sender, const FString& Msg, FName Type) override;
	virtual void EndMatch() override;
	virtual void HandleLeavingMap() override;
	virtual void HandleMatchAborted() override;
	virtual void HandleMatchHasEnded() override;
	virtual void HandleMatchHasStarted() override;
	virtual void HandleMatchIsWaitingToStart() override;
	virtual void MatineeCancelled() override;
	virtual void OnMatchStateSet() override;
	virtual void OverridePlayerState(APlayerController* PC, APlayerState* OldPlayerState) override;
	virtual void PostCommitMapChange() override;
	virtual void PreCommitMapChange(const FString& PreviousMapName, const FString& NextMapName) override;
	virtual void RestartGame() override;
	virtual void Say(const FString& Msg) override;
	virtual void SendPlayer(APlayerController* aPlayer, const FString& URL) override;
	virtual void SetBandwidthLimit(float AsyncIOBandwidthLimit) override;
	virtual void SetMatchState(FName NewState) override;
	virtual void SetSeamlessTravelViewTarget(APlayerController* PC) override;
	virtual void StartMatch() override;
	virtual void StartNewPlayer(APlayerController* NewPlayer) override;
	virtual void ChangeName(AController* Controller, const FString& NewName, bool bNameChange) override;
	virtual void FinishRestartPlayer(AController* NewPlayer, const FRotator& StartRotation) override;
	virtual void GenericPlayerInitialization(AController* C) override;
	virtual void InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage) override;
	virtual void InitGameState() override;
	virtual void InitSeamlessTravelPlayer(AController* NewController) override;
	virtual void Logout(AController* Exiting) override;
	virtual void PostLogin(APlayerController* NewPlayer) override;
	virtual void PostSeamlessTravel() override;
	virtual void ProcessServerTravel(const FString& URL, bool bAbsolute) override;
	virtual void ReplicateStreamingStatus(APlayerController* PC) override;
	virtual void ResetLevel() override;
	virtual void RestartPlayer(AController* NewPlayer) override;
	virtual void RestartPlayerAtPlayerStart(AController* NewPlayer, AActor* StartSpot) override;
	virtual void RestartPlayerAtTransform(AController* NewPlayer, const FTransform& SpawnTransform) override;
	virtual void ReturnToMainMenuHost() override;
	virtual void SetPlayerDefaults(APawn* PlayerPawn) override;
	virtual void StartPlay() override;
	virtual void StartToLeaveMap() override;
	virtual void SwapPlayerControllers(APlayerController* OldPC, APlayerController* NewPC) override;
	virtual void UpdateGameplayMuteList(APlayerController* aPlayer) override;
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	virtual void BecomeViewTarget(APlayerController* PC) override;
	virtual void BeginPlay() override;
	virtual void ClearCrossLevelReferences() override;
	virtual void Destroyed() override;
	virtual void DisableInput(APlayerController* PlayerController) override;
	virtual void EnableInput(APlayerController* PlayerController) override;
	virtual void EndViewTarget(APlayerController* PC) override;
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
	virtual void OnRep_Owner() override;
	virtual void OnRep_ReplicatedMovement() override;
	virtual void OnRep_ReplicateMovement() override;
	virtual void OnReplicationPausedChanged(bool bIsReplicationPaused) override;
	virtual void OnSubobjectCreatedFromReplication(UObject* NewSubobject) override;
	virtual void OnSubobjectDestroyFromReplication(UObject* Subobject) override;
	virtual void OutsideWorldBounds() override;
	virtual void PostActorCreated() override;
	virtual void PostInitializeComponents() override;
	virtual void PostNetInit() override;
	virtual void PostNetReceiveLocationAndRotation() override;
	virtual void PostNetReceivePhysicState() override;
	virtual void PostNetReceiveRole() override;
	virtual void PostNetReceiveVelocity(const FVector& NewVelocity) override;
	virtual void PostRegisterAllComponents() override;
	virtual void PostRenderFor(APlayerController* PC, UCanvas* Canvas, FVector CameraPosition, FVector CameraDir) override;
	virtual void PostUnregisterAllComponents() override;
	virtual void PreInitializeComponents() override;
	virtual void PreRegisterAllComponents() override;
	virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups) override;
	virtual void RegisterActorTickFunctions(bool bRegister) override;
	virtual void RegisterAllComponents() override;
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void ReregisterAllComponents() override;
	virtual void RerunConstructionScripts() override;
	virtual void Reset() override;
	virtual void RewindForReplay() override;
	virtual void SetActorHiddenInGame(bool bNewHidden) override;
	virtual void SetLifeSpan(float InLifespan) override;
	virtual void SetOwner(AActor* NewOwner) override;
	virtual void SetReplicateMovement(bool bInReplicateMovement) override;
	virtual void TearOff() override;
	virtual void TeleportSucceeded(bool bIsATest) override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void TornOff() override;
	virtual void UnregisterAllComponents(bool bForReregister) override;
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
