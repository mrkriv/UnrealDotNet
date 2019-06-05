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

void AManageCharacter::BaseChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BaseChange");
	else
		Super::BaseChange();
}

void AManageCharacter::_Supper__BaseChange()
{
	Super::BaseChange();
}

void AManageCharacter::CheckJumpInput(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CheckJumpInput", DeltaTime);
	else
		Super::CheckJumpInput(DeltaTime);
}

void AManageCharacter::_Supper__CheckJumpInput(float DeltaTime)
{
	Super::CheckJumpInput(DeltaTime);
}

void AManageCharacter::ClearJumpInput(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearJumpInput", DeltaTime);
	else
		Super::ClearJumpInput(DeltaTime);
}

void AManageCharacter::_Supper__ClearJumpInput(float DeltaTime)
{
	Super::ClearJumpInput(DeltaTime);
}

void AManageCharacter::ClientCheatFly_Implementation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatFly_Implementation");
	else
		Super::ClientCheatFly_Implementation();
}

void AManageCharacter::_Supper__ClientCheatFly_Implementation()
{
	Super::ClientCheatFly_Implementation();
}

void AManageCharacter::ClientCheatGhost_Implementation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatGhost_Implementation");
	else
		Super::ClientCheatGhost_Implementation();
}

void AManageCharacter::_Supper__ClientCheatGhost_Implementation()
{
	Super::ClientCheatGhost_Implementation();
}

void AManageCharacter::ClientCheatWalk_Implementation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClientCheatWalk_Implementation");
	else
		Super::ClientCheatWalk_Implementation();
}

void AManageCharacter::_Supper__ClientCheatWalk_Implementation()
{
	Super::ClientCheatWalk_Implementation();
}

void AManageCharacter::Crouch(bool bClientSimulation)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Crouch", bClientSimulation);
	else
		Super::Crouch(bClientSimulation);
}

void AManageCharacter::_Supper__Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
}

void AManageCharacter::Falling()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Falling");
	else
		Super::Falling();
}

void AManageCharacter::_Supper__Falling()
{
	Super::Falling();
}

void AManageCharacter::Jump()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Jump");
	else
		Super::Jump();
}

void AManageCharacter::_Supper__Jump()
{
	Super::Jump();
}

void AManageCharacter::NotifyJumpApex()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyJumpApex");
	else
		Super::NotifyJumpApex();
}

void AManageCharacter::_Supper__NotifyJumpApex()
{
	Super::NotifyJumpApex();
}

void AManageCharacter::OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnEndCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
	else
		Super::OnEndCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::_Supper__OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnEndCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::OnJumped_Implementation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnJumped_Implementation");
	else
		Super::OnJumped_Implementation();
}

void AManageCharacter::_Supper__OnJumped_Implementation()
{
	Super::OnJumped_Implementation();
}

void AManageCharacter::OnRep_IsCrouched()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsCrouched");
	else
		Super::OnRep_IsCrouched();
}

void AManageCharacter::_Supper__OnRep_IsCrouched()
{
	Super::OnRep_IsCrouched();
}

void AManageCharacter::OnRep_ReplicatedBasedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedBasedMovement");
	else
		Super::OnRep_ReplicatedBasedMovement();
}

void AManageCharacter::_Supper__OnRep_ReplicatedBasedMovement()
{
	Super::OnRep_ReplicatedBasedMovement();
}

void AManageCharacter::OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnStartCrouch", HalfHeightAdjust, ScaledHalfHeightAdjust);
	else
		Super::OnStartCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::_Supper__OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
{
	Super::OnStartCrouch(HalfHeightAdjust, ScaledHalfHeightAdjust);
}

void AManageCharacter::ResetJumpState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetJumpState");
	else
		Super::ResetJumpState();
}

void AManageCharacter::_Supper__ResetJumpState()
{
	Super::ResetJumpState();
}

void AManageCharacter::StopJumping()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StopJumping");
	else
		Super::StopJumping();
}

void AManageCharacter::_Supper__StopJumping()
{
	Super::StopJumping();
}

void AManageCharacter::UnCrouch(bool bClientSimulation)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnCrouch", bClientSimulation);
	else
		Super::UnCrouch(bClientSimulation);
}

void AManageCharacter::_Supper__UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
}

void AManageCharacter::AddControllerPitchInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
	else
		Super::AddControllerPitchInput(Val);
}

void AManageCharacter::_Supper__AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
}

void AManageCharacter::AddControllerRollInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
	else
		Super::AddControllerRollInput(Val);
}

void AManageCharacter::_Supper__AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
}

void AManageCharacter::AddControllerYawInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
	else
		Super::AddControllerYawInput(Val);
}

void AManageCharacter::_Supper__AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
}

void AManageCharacter::DestroyPlayerInputComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
	else
		Super::DestroyPlayerInputComponent();
}

void AManageCharacter::_Supper__DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
}

void AManageCharacter::DetachFromControllerPendingDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
	else
		Super::DetachFromControllerPendingDestroy();
}

void AManageCharacter::_Supper__DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
}

void AManageCharacter::OnRep_Controller()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
	else
		Super::OnRep_Controller();
}

void AManageCharacter::_Supper__OnRep_Controller()
{
	Super::OnRep_Controller();
}

void AManageCharacter::OnRep_PlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
	else
		Super::OnRep_PlayerState();
}

void AManageCharacter::_Supper__OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
}

void AManageCharacter::PawnClientRestart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
	else
		Super::PawnClientRestart();
}

void AManageCharacter::_Supper__PawnClientRestart()
{
	Super::PawnClientRestart();
}

void AManageCharacter::PawnStartFire(uint8 FireModeNum)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
	else
		Super::PawnStartFire(FireModeNum);
}

void AManageCharacter::_Supper__PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
}

void AManageCharacter::RecalculateBaseEyeHeight()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
	else
		Super::RecalculateBaseEyeHeight();
}

void AManageCharacter::_Supper__RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
}

void AManageCharacter::Restart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
	else
		Super::Restart();
}

void AManageCharacter::_Supper__Restart()
{
	Super::Restart();
}

void AManageCharacter::SetPlayerDefaults()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
	else
		Super::SetPlayerDefaults();
}

void AManageCharacter::_Supper__SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
}

void AManageCharacter::SpawnDefaultController()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
	else
		Super::SpawnDefaultController();
}

void AManageCharacter::_Supper__SpawnDefaultController()
{
	Super::SpawnDefaultController();
}

void AManageCharacter::TurnOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
	else
		Super::TurnOff();
}

void AManageCharacter::_Supper__TurnOff()
{
	Super::TurnOff();
}

void AManageCharacter::UnPossessed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
	else
		Super::UnPossessed();
}

void AManageCharacter::_Supper__UnPossessed()
{
	Super::UnPossessed();
}

void AManageCharacter::UpdateNavigationRelevance()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
	else
		Super::UpdateNavigationRelevance();
}

void AManageCharacter::_Supper__UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
}

void AManageCharacter::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageCharacter::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageCharacter::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageCharacter::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageCharacter::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageCharacter::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageCharacter::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageCharacter::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageCharacter::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageCharacter::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageCharacter::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageCharacter::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageCharacter::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageCharacter::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageCharacter::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageCharacter::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageCharacter::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageCharacter::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageCharacter::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageCharacter::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageCharacter::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageCharacter::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageCharacter::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageCharacter::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageCharacter::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageCharacter::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageCharacter::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageCharacter::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageCharacter::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageCharacter::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageCharacter::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageCharacter::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageCharacter::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageCharacter::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageCharacter::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageCharacter::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageCharacter::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageCharacter::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageCharacter::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageCharacter::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageCharacter::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageCharacter::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageCharacter::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageCharacter::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageCharacter::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageCharacter::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageCharacter::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageCharacter::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageCharacter::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageCharacter::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageCharacter::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageCharacter::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageCharacter::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageCharacter::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageCharacter::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageCharacter::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageCharacter::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageCharacter::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageCharacter::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCharacter::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCharacter::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageCharacter::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageCharacter::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageCharacter::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageCharacter::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageCharacter::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageCharacter::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageCharacter::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageCharacter::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageCharacter::_Supper__Reset()
{
	Super::Reset();
}

void AManageCharacter::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageCharacter::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageCharacter::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageCharacter::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageCharacter::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageCharacter::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageCharacter::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageCharacter::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageCharacter::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageCharacter::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageCharacter::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageCharacter::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageCharacter::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageCharacter::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageCharacter::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageCharacter::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageCharacter::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageCharacter::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageCharacter::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageCharacter::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageCharacter::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageCharacter::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageCharacter::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageCharacter::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageCharacter::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageCharacter::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageCharacter::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageCharacter::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageCharacter::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageCharacter::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageCharacter::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageCharacter::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageCharacter::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageCharacter::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageCharacter::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageCharacter::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageCharacter::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageCharacter::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageCharacter::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageCharacter::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageCharacter::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageCharacter::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageCharacter::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageCharacter::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageCharacter::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageCharacter::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageCharacter::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageCharacter::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
