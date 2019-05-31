// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacter.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

AManageCharacter::AManageCharacter(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageCharacter::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageCharacter::ApplyDamageMomentum(float DamageTaken, const FDamageEvent& DamageEvent, APawn* PawnInstigator, AActor* DamageCauser)
{
	Super::ApplyDamageMomentum(DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyDamageMomentum", DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
}

void AManageCharacter::BaseChange()
{
	Super::BaseChange();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BaseChange");
}

void AManageCharacter::CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
{
	Super::CacheInitialMeshOffset(MeshRelativeLocation, MeshRelativeRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CacheInitialMeshOffset", MeshRelativeLocation, MeshRelativeRotation);
}

void AManageCharacter::CheckJumpInput(float DeltaTime)
{
	Super::CheckJumpInput(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CheckJumpInput", DeltaTime);
}

void AManageCharacter::ClearJumpInput(float DeltaTime)
{
	Super::ClearJumpInput(DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearJumpInput", DeltaTime);
}

void AManageCharacter::ClientCheatFly_Implementation()
{
	Super::ClientCheatFly_Implementation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatFly_Implementation");
}

void AManageCharacter::ClientCheatGhost_Implementation()
{
	Super::ClientCheatGhost_Implementation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatGhost_Implementation");
}

void AManageCharacter::ClientCheatWalk_Implementation()
{
	Super::ClientCheatWalk_Implementation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatWalk_Implementation");
}

void AManageCharacter::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Crouch", bClientSimulation);
}

void AManageCharacter::Falling()
{
	Super::Falling();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Falling");
}

void AManageCharacter::Jump()
{
	Super::Jump();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Jump");
}

void AManageCharacter::Landed(const FHitResult& Hit)
{
	Super::Landed(Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Landed", Hit);
}

void AManageCharacter::LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
{
	Super::LaunchCharacter(LaunchVelocity, bXYOverride, bZOverride);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LaunchCharacter", LaunchVelocity, bXYOverride, bZOverride);
}

void AManageCharacter::MoveBlockedBy(const FHitResult& Impact)
{
	Super::MoveBlockedBy(Impact);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveBlockedBy", Impact);
}

void AManageCharacter::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageCharacter::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageCharacter::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyJumpApex");
}

void AManageCharacter::OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnEndCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnEndCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnJumped_Implementation()
{
	Super::OnJumped_Implementation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnJumped_Implementation");
}

void AManageCharacter::OnMovementModeChanged(EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PrevMovementMode, PreviousCustomMode);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnMovementModeChanged", PrevMovementMode, PreviousCustomMode);
}

void AManageCharacter::OnRep_IsCrouched()
{
	Super::OnRep_IsCrouched();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsCrouched");
}

void AManageCharacter::OnRep_ReplicatedBasedMovement()
{
	Super::OnRep_ReplicatedBasedMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedBasedMovement");
}

void AManageCharacter::OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnStartCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnStartCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnUpdateSimulatedPosition(const FVector& OldLocation, const FQuat& OldRotation)
{
	Super::OnUpdateSimulatedPosition(OldLocation, OldRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUpdateSimulatedPosition", OldLocation, OldRotation);
}

void AManageCharacter::OnWalkingOffLedge_Implementation(const FVector& PreviousFloorImpactNormal, const FVector& PreviousFloorContactNormal, const FVector& PreviousLocation, float TimeDelta)
{
	Super::OnWalkingOffLedge_Implementation(PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnWalkingOffLedge_Implementation", PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
}

void AManageCharacter::ResetJumpState()
{
	Super::ResetJumpState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetJumpState");
}

void AManageCharacter::RootMotionDebugClientPrintOnScreen_Implementation(const FString& InString)
{
	Super::RootMotionDebugClientPrintOnScreen_Implementation(InString);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RootMotionDebugClientPrintOnScreen_Implementation", InString);
}

void AManageCharacter::SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor)
{
	Super::SetBase(NewBase, BoneName, bNotifyActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetBase", NewBase, BoneName, bNotifyActor);
}

void AManageCharacter::StopJumping()
{
	Super::StopJumping();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopJumping");
}

void AManageCharacter::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void AManageCharacter::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManageCharacter::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManageCharacter::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManageCharacter::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManageCharacter::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManageCharacter::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManageCharacter::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManageCharacter::OnRep_Controller()
{
	Super::OnRep_Controller();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
}

void AManageCharacter::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
}

void AManageCharacter::PawnClientRestart()
{
	Super::PawnClientRestart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
}

void AManageCharacter::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManageCharacter::PossessedBy(AController* NewController)
{
	Super::PossessedBy(NewController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PossessedBy", NewController);
}

void AManageCharacter::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManageCharacter::Restart()
{
	Super::Restart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
}

void AManageCharacter::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
}

void AManageCharacter::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetupPlayerInputComponent", PlayerInputComponent);
}

void AManageCharacter::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
}

void AManageCharacter::TurnOff()
{
	Super::TurnOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
}

void AManageCharacter::UnPossessed()
{
	Super::UnPossessed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
}

void AManageCharacter::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
}

void AManageCharacter::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageCharacter::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageCharacter::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageCharacter::BecomeViewTarget(APlayerController* PC)
{
	Super::BecomeViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BecomeViewTarget", PC);
}

void AManageCharacter::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void AManageCharacter::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageCharacter::Destroyed()
{
	Super::Destroyed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
}

void AManageCharacter::DisableInput(APlayerController* PlayerController)
{
	Super::DisableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableInput", PlayerController);
}

void AManageCharacter::EnableInput(APlayerController* PlayerController)
{
	Super::EnableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableInput", PlayerController);
}

void AManageCharacter::EndViewTarget(APlayerController* PC)
{
	Super::EndViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndViewTarget", PC);
}

void AManageCharacter::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
}

void AManageCharacter::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
}

void AManageCharacter::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
}

void AManageCharacter::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageCharacter::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
}

void AManageCharacter::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
}

void AManageCharacter::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageCharacter::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageCharacter::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageCharacter::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageCharacter::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnConstruction", Transform);
}

void AManageCharacter::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageCharacter::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
}

void AManageCharacter::OnRep_Owner()
{
	Super::OnRep_Owner();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
}

void AManageCharacter::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageCharacter::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageCharacter::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageCharacter::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageCharacter::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageCharacter::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
}

void AManageCharacter::PostActorCreated()
{
	Super::PostActorCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
}

void AManageCharacter::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
}

void AManageCharacter::PostNetInit()
{
	Super::PostNetInit();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
}

void AManageCharacter::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageCharacter::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageCharacter::PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
}

void AManageCharacter::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageCharacter::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageCharacter::PostRenderFor(APlayerController* PC, UCanvas* Canvas, FVector CameraPosition, FVector CameraDir)
{
	Super::PostRenderFor(PC, Canvas, CameraPosition, CameraDir);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRenderFor", PC, Canvas, CameraPosition, CameraDir);
}

void AManageCharacter::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageCharacter::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
}

void AManageCharacter::PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
}

void AManageCharacter::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCharacter::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageCharacter::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
}

void AManageCharacter::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageCharacter::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageCharacter::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
}

void AManageCharacter::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
}

void AManageCharacter::Reset()
{
	Super::Reset();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
}

void AManageCharacter::RewindForReplay()
{
	Super::RewindForReplay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
}

void AManageCharacter::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageCharacter::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageCharacter::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageCharacter::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageCharacter::TearOff()
{
	Super::TearOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
}

void AManageCharacter::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageCharacter::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageCharacter::TornOff()
{
	Super::TornOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
}

void AManageCharacter::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageCharacter::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void AManageCharacter::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void AManageCharacter::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageCharacter::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void AManageCharacter::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void AManageCharacter::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void AManageCharacter::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void AManageCharacter::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void AManageCharacter::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void AManageCharacter::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageCharacter::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void AManageCharacter::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageCharacter::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageCharacter::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void AManageCharacter::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void AManageCharacter::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void AManageCharacter::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
