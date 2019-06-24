// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSpectatorPawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

AManageSpectatorPawn::AManageSpectatorPawn(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManageSpectatorPawn::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManageSpectatorPawn::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageSpectatorPawn::LookUpAtRate(float Rate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LookUpAtRate", Rate);
	else
		Super::LookUpAtRate(Rate);
}

void AManageSpectatorPawn::_Supper__LookUpAtRate(float Rate)
{
	Super::LookUpAtRate(Rate);
}

void AManageSpectatorPawn::MoveForward(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveForward", Val);
	else
		Super::MoveForward(Val);
}

void AManageSpectatorPawn::_Supper__MoveForward(float Val)
{
	Super::MoveForward(Val);
}

void AManageSpectatorPawn::MoveRight(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveRight", Val);
	else
		Super::MoveRight(Val);
}

void AManageSpectatorPawn::_Supper__MoveRight(float Val)
{
	Super::MoveRight(Val);
}

void AManageSpectatorPawn::MoveUp_World(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveUp_World", Val);
	else
		Super::MoveUp_World(Val);
}

void AManageSpectatorPawn::_Supper__MoveUp_World(float Val)
{
	Super::MoveUp_World(Val);
}

void AManageSpectatorPawn::TurnAtRate(float Rate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnAtRate", Rate);
	else
		Super::TurnAtRate(Rate);
}

void AManageSpectatorPawn::_Supper__TurnAtRate(float Rate)
{
	Super::TurnAtRate(Rate);
}

void AManageSpectatorPawn::AddControllerPitchInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
	else
		Super::AddControllerPitchInput(Val);
}

void AManageSpectatorPawn::_Supper__AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
}

void AManageSpectatorPawn::AddControllerRollInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
	else
		Super::AddControllerRollInput(Val);
}

void AManageSpectatorPawn::_Supper__AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
}

void AManageSpectatorPawn::AddControllerYawInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
	else
		Super::AddControllerYawInput(Val);
}

void AManageSpectatorPawn::_Supper__AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
}

void AManageSpectatorPawn::DestroyPlayerInputComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
	else
		Super::DestroyPlayerInputComponent();
}

void AManageSpectatorPawn::_Supper__DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
}

void AManageSpectatorPawn::DetachFromControllerPendingDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
	else
		Super::DetachFromControllerPendingDestroy();
}

void AManageSpectatorPawn::_Supper__DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
}

void AManageSpectatorPawn::OnRep_Controller()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
	else
		Super::OnRep_Controller();
}

void AManageSpectatorPawn::_Supper__OnRep_Controller()
{
	Super::OnRep_Controller();
}

void AManageSpectatorPawn::OnRep_PlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
	else
		Super::OnRep_PlayerState();
}

void AManageSpectatorPawn::_Supper__OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
}

void AManageSpectatorPawn::PawnClientRestart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
	else
		Super::PawnClientRestart();
}

void AManageSpectatorPawn::_Supper__PawnClientRestart()
{
	Super::PawnClientRestart();
}

void AManageSpectatorPawn::PawnStartFire(uint8 FireModeNum)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
	else
		Super::PawnStartFire(FireModeNum);
}

void AManageSpectatorPawn::_Supper__PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
}

void AManageSpectatorPawn::RecalculateBaseEyeHeight()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
	else
		Super::RecalculateBaseEyeHeight();
}

void AManageSpectatorPawn::_Supper__RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
}

void AManageSpectatorPawn::Restart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
	else
		Super::Restart();
}

void AManageSpectatorPawn::_Supper__Restart()
{
	Super::Restart();
}

void AManageSpectatorPawn::SetPlayerDefaults()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
	else
		Super::SetPlayerDefaults();
}

void AManageSpectatorPawn::_Supper__SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
}

void AManageSpectatorPawn::SpawnDefaultController()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
	else
		Super::SpawnDefaultController();
}

void AManageSpectatorPawn::_Supper__SpawnDefaultController()
{
	Super::SpawnDefaultController();
}

void AManageSpectatorPawn::TurnOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
	else
		Super::TurnOff();
}

void AManageSpectatorPawn::_Supper__TurnOff()
{
	Super::TurnOff();
}

void AManageSpectatorPawn::UnPossessed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
	else
		Super::UnPossessed();
}

void AManageSpectatorPawn::_Supper__UnPossessed()
{
	Super::UnPossessed();
}

void AManageSpectatorPawn::UpdateNavigationRelevance()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
	else
		Super::UpdateNavigationRelevance();
}

void AManageSpectatorPawn::_Supper__UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
}

void AManageSpectatorPawn::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageSpectatorPawn::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageSpectatorPawn::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageSpectatorPawn::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageSpectatorPawn::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageSpectatorPawn::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageSpectatorPawn::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageSpectatorPawn::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageSpectatorPawn::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageSpectatorPawn::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageSpectatorPawn::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageSpectatorPawn::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageSpectatorPawn::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageSpectatorPawn::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageSpectatorPawn::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageSpectatorPawn::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageSpectatorPawn::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageSpectatorPawn::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageSpectatorPawn::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageSpectatorPawn::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageSpectatorPawn::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageSpectatorPawn::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageSpectatorPawn::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageSpectatorPawn::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageSpectatorPawn::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageSpectatorPawn::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageSpectatorPawn::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageSpectatorPawn::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageSpectatorPawn::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageSpectatorPawn::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageSpectatorPawn::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageSpectatorPawn::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageSpectatorPawn::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageSpectatorPawn::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageSpectatorPawn::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageSpectatorPawn::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageSpectatorPawn::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageSpectatorPawn::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageSpectatorPawn::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageSpectatorPawn::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageSpectatorPawn::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageSpectatorPawn::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageSpectatorPawn::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageSpectatorPawn::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageSpectatorPawn::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageSpectatorPawn::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageSpectatorPawn::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageSpectatorPawn::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageSpectatorPawn::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageSpectatorPawn::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageSpectatorPawn::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageSpectatorPawn::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageSpectatorPawn::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageSpectatorPawn::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageSpectatorPawn::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageSpectatorPawn::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageSpectatorPawn::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageSpectatorPawn::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageSpectatorPawn::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageSpectatorPawn::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageSpectatorPawn::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageSpectatorPawn::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageSpectatorPawn::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageSpectatorPawn::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageSpectatorPawn::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageSpectatorPawn::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageSpectatorPawn::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageSpectatorPawn::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageSpectatorPawn::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageSpectatorPawn::_Supper__Reset()
{
	Super::Reset();
}

void AManageSpectatorPawn::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageSpectatorPawn::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageSpectatorPawn::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageSpectatorPawn::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageSpectatorPawn::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageSpectatorPawn::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageSpectatorPawn::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageSpectatorPawn::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageSpectatorPawn::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageSpectatorPawn::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageSpectatorPawn::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageSpectatorPawn::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageSpectatorPawn::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageSpectatorPawn::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageSpectatorPawn::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageSpectatorPawn::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageSpectatorPawn::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageSpectatorPawn::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageSpectatorPawn::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageSpectatorPawn::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageSpectatorPawn::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageSpectatorPawn::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageSpectatorPawn::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageSpectatorPawn::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageSpectatorPawn::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageSpectatorPawn::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageSpectatorPawn::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageSpectatorPawn::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageSpectatorPawn::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageSpectatorPawn::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageSpectatorPawn::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageSpectatorPawn::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageSpectatorPawn::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageSpectatorPawn::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageSpectatorPawn::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageSpectatorPawn::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageSpectatorPawn::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageSpectatorPawn::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageSpectatorPawn::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageSpectatorPawn::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageSpectatorPawn::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageSpectatorPawn::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageSpectatorPawn::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageSpectatorPawn::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageSpectatorPawn::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageSpectatorPawn::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageSpectatorPawn::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageSpectatorPawn::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
