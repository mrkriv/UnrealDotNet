#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacter.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

FString AManageCharacter::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void AManageCharacter::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void AManageCharacter::ApplyDamageMomentum(float DamageTaken, const FDamageEvent& DamageEvent, APawn* PawnInstigator, AActor* DamageCauser)
{
	Super::ApplyDamageMomentum(DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyDamageMomentum", DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
}

void AManageCharacter::BaseChange()
{
	Super::BaseChange();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BaseChange");
}

void AManageCharacter::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void AManageCharacter::CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
{
	Super::CacheInitialMeshOffset(MeshRelativeLocation, MeshRelativeRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CacheInitialMeshOffset", MeshRelativeLocation, MeshRelativeRotation);
}

void AManageCharacter::CheckJumpInput(float DeltaTime)
{
	Super::CheckJumpInput(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CheckJumpInput", DeltaTime);
}

void AManageCharacter::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageCharacter::ClearJumpInput()
{
	Super::ClearJumpInput();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearJumpInput");
}

void AManageCharacter::ClientCheatFly_Implementation()
{
	Super::ClientCheatFly_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatFly_Implementation");
}

void AManageCharacter::ClientCheatGhost_Implementation()
{
	Super::ClientCheatGhost_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatGhost_Implementation");
}

void AManageCharacter::ClientCheatWalk_Implementation()
{
	Super::ClientCheatWalk_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientCheatWalk_Implementation");
}

void AManageCharacter::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Crouch", bClientSimulation);
}

void AManageCharacter::Falling()
{
	Super::Falling();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Falling");
}

void AManageCharacter::Jump()
{
	Super::Jump();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Jump");
}

void AManageCharacter::Landed(const FHitResult& Hit)
{
	Super::Landed(Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Landed", Hit);
}

void AManageCharacter::LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
{
	Super::LaunchCharacter(LaunchVelocity, bXYOverride, bZOverride);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LaunchCharacter", LaunchVelocity, bXYOverride, bZOverride);
}

void AManageCharacter::MoveBlockedBy(const FHitResult& Impact)
{
	Super::MoveBlockedBy(Impact);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MoveBlockedBy", Impact);
}

void AManageCharacter::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyJumpApex");
}

void AManageCharacter::OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnEndCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnEndCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnJumped_Implementation()
{
	Super::OnJumped_Implementation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnJumped_Implementation");
}

void AManageCharacter::OnMovementModeChanged(EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PrevMovementMode, PreviousCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementModeChanged", PrevMovementMode, PreviousCustomMode);
}

void AManageCharacter::OnRep_IsCrouched()
{
	Super::OnRep_IsCrouched();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_IsCrouched");
}

void AManageCharacter::OnRep_ReplicatedBasedMovement()
{
	Super::OnRep_ReplicatedBasedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedBasedMovement");
}

void AManageCharacter::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageCharacter::OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnStartCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnStartCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnUpdateSimulatedPosition(const FVector& OldLocation, const FQuat& OldRotation)
{
	Super::OnUpdateSimulatedPosition(OldLocation, OldRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUpdateSimulatedPosition", OldLocation, OldRotation);
}

void AManageCharacter::OnWalkingOffLedge_Implementation(const FVector& PreviousFloorImpactNormal, const FVector& PreviousFloorContactNormal, const FVector& PreviousLocation, float TimeDelta)
{
	Super::OnWalkingOffLedge_Implementation(PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnWalkingOffLedge_Implementation", PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
}

void AManageCharacter::PawnClientRestart()
{
	Super::PawnClientRestart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnClientRestart");
}

void AManageCharacter::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitializeComponents");
}

void AManageCharacter::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void AManageCharacter::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageCharacter::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void AManageCharacter::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManageCharacter::Restart()
{
	Super::Restart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Restart");
}

void AManageCharacter::RootMotionDebugClientPrintOnScreen_Implementation(const FString& InString)
{
	Super::RootMotionDebugClientPrintOnScreen_Implementation(InString);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RootMotionDebugClientPrintOnScreen_Implementation", InString);
}

void AManageCharacter::SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor)
{
	Super::SetBase(NewBase, BoneName, bNotifyActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetBase", NewBase, BoneName, bNotifyActor);
}

void AManageCharacter::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageCharacter::StopJumping()
{
	Super::StopJumping();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StopJumping");
}

void AManageCharacter::TornOff()
{
	Super::TornOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TornOff");
}

void AManageCharacter::TurnOff()
{
	Super::TurnOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TurnOff");
}

void AManageCharacter::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void AManageCharacter::UnPossessed()
{
	Super::UnPossessed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnPossessed");
}

void AManageCharacter::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateNavigationRelevance");
}

void AManageCharacter::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManageCharacter::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManageCharacter::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManageCharacter::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManageCharacter::Destroyed()
{
	Super::Destroyed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Destroyed");
}

void AManageCharacter::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManageCharacter::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManageCharacter::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManageCharacter::OnRep_Controller()
{
	Super::OnRep_Controller();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Controller");
}

void AManageCharacter::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_PlayerState");
}

void AManageCharacter::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OutsideWorldBounds");
}

void AManageCharacter::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManageCharacter::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void AManageCharacter::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageCharacter::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageCharacter::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreInitializeComponents");
}

void AManageCharacter::Reset()
{
	Super::Reset();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Reset");
}

void AManageCharacter::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlayerDefaults");
}

void AManageCharacter::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SpawnDefaultController");
}

void AManageCharacter::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageCharacter::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageCharacter::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageCharacter::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageCharacter::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void AManageCharacter::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetRelevant");
}

void AManageCharacter::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetUpdate");
}

void AManageCharacter::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GatherCurrentMovement");
}

void AManageCharacter::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageCharacter::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "K2_DestroyActor");
}

void AManageCharacter::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LifeSpanExpired");
}

void AManageCharacter::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageCharacter::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageCharacter::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageCharacter::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageCharacter::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageCharacter::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageCharacter::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnConstruction", Transform);
}

void AManageCharacter::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageCharacter::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Instigator");
}

void AManageCharacter::OnRep_Owner()
{
	Super::OnRep_Owner();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Owner");
}

void AManageCharacter::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageCharacter::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageCharacter::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageCharacter::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageCharacter::PostActorCreated()
{
	Super::PostActorCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostActorCreated");
}

void AManageCharacter::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void AManageCharacter::PostNetInit()
{
	Super::PostNetInit();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetInit");
}

void AManageCharacter::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageCharacter::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageCharacter::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageCharacter::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCharacter::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageCharacter::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterAllComponents");
}

void AManageCharacter::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageCharacter::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageCharacter::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReregisterAllComponents");
}

void AManageCharacter::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RerunConstructionScripts");
}

void AManageCharacter::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageCharacter::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageCharacter::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageCharacter::TearOff()
{
	Super::TearOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TearOff");
}

void AManageCharacter::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageCharacter::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageCharacter::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void AManageCharacter::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageCharacter::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void AManageCharacter::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void AManageCharacter::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void AManageCharacter::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageCharacter::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageCharacter::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void AManageCharacter::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void AManageCharacter::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void AManageCharacter::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
