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

PRAGMA_ENABLE_DEPRECATION_WARNINGS
