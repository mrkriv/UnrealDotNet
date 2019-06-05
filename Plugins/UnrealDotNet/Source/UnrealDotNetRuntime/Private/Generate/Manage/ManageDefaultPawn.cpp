// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageDefaultPawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

AManageDefaultPawn::AManageDefaultPawn(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageDefaultPawn::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageDefaultPawn::LookUpAtRate(float Rate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LookUpAtRate", Rate);
	else
		Super::LookUpAtRate(Rate);
}

void AManageDefaultPawn::_Supper__LookUpAtRate(float Rate)
{
	Super::LookUpAtRate(Rate);
}

void AManageDefaultPawn::MoveForward(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveForward", Val);
	else
		Super::MoveForward(Val);
}

void AManageDefaultPawn::_Supper__MoveForward(float Val)
{
	Super::MoveForward(Val);
}

void AManageDefaultPawn::MoveRight(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveRight", Val);
	else
		Super::MoveRight(Val);
}

void AManageDefaultPawn::_Supper__MoveRight(float Val)
{
	Super::MoveRight(Val);
}

void AManageDefaultPawn::MoveUp_World(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveUp_World", Val);
	else
		Super::MoveUp_World(Val);
}

void AManageDefaultPawn::_Supper__MoveUp_World(float Val)
{
	Super::MoveUp_World(Val);
}

void AManageDefaultPawn::TurnAtRate(float Rate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnAtRate", Rate);
	else
		Super::TurnAtRate(Rate);
}

void AManageDefaultPawn::_Supper__TurnAtRate(float Rate)
{
	Super::TurnAtRate(Rate);
}

void AManageDefaultPawn::AddControllerPitchInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
	else
		Super::AddControllerPitchInput(Val);
}

void AManageDefaultPawn::_Supper__AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
}

void AManageDefaultPawn::AddControllerRollInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
	else
		Super::AddControllerRollInput(Val);
}

void AManageDefaultPawn::_Supper__AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
}

void AManageDefaultPawn::AddControllerYawInput(float Val)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
	else
		Super::AddControllerYawInput(Val);
}

void AManageDefaultPawn::_Supper__AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
}

void AManageDefaultPawn::DestroyPlayerInputComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
	else
		Super::DestroyPlayerInputComponent();
}

void AManageDefaultPawn::_Supper__DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
}

void AManageDefaultPawn::DetachFromControllerPendingDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
	else
		Super::DetachFromControllerPendingDestroy();
}

void AManageDefaultPawn::_Supper__DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
}

void AManageDefaultPawn::OnRep_Controller()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
	else
		Super::OnRep_Controller();
}

void AManageDefaultPawn::_Supper__OnRep_Controller()
{
	Super::OnRep_Controller();
}

void AManageDefaultPawn::OnRep_PlayerState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
	else
		Super::OnRep_PlayerState();
}

void AManageDefaultPawn::_Supper__OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
}

void AManageDefaultPawn::PawnClientRestart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
	else
		Super::PawnClientRestart();
}

void AManageDefaultPawn::_Supper__PawnClientRestart()
{
	Super::PawnClientRestart();
}

void AManageDefaultPawn::PawnStartFire(uint8 FireModeNum)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
	else
		Super::PawnStartFire(FireModeNum);
}

void AManageDefaultPawn::_Supper__PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
}

void AManageDefaultPawn::RecalculateBaseEyeHeight()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
	else
		Super::RecalculateBaseEyeHeight();
}

void AManageDefaultPawn::_Supper__RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
}

void AManageDefaultPawn::Restart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
	else
		Super::Restart();
}

void AManageDefaultPawn::_Supper__Restart()
{
	Super::Restart();
}

void AManageDefaultPawn::SetPlayerDefaults()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
	else
		Super::SetPlayerDefaults();
}

void AManageDefaultPawn::_Supper__SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
}

void AManageDefaultPawn::SpawnDefaultController()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
	else
		Super::SpawnDefaultController();
}

void AManageDefaultPawn::_Supper__SpawnDefaultController()
{
	Super::SpawnDefaultController();
}

void AManageDefaultPawn::TurnOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
	else
		Super::TurnOff();
}

void AManageDefaultPawn::_Supper__TurnOff()
{
	Super::TurnOff();
}

void AManageDefaultPawn::UnPossessed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
	else
		Super::UnPossessed();
}

void AManageDefaultPawn::_Supper__UnPossessed()
{
	Super::UnPossessed();
}

void AManageDefaultPawn::UpdateNavigationRelevance()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
	else
		Super::UpdateNavigationRelevance();
}

void AManageDefaultPawn::_Supper__UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
}

void AManageDefaultPawn::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageDefaultPawn::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageDefaultPawn::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageDefaultPawn::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageDefaultPawn::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageDefaultPawn::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageDefaultPawn::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageDefaultPawn::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageDefaultPawn::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageDefaultPawn::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageDefaultPawn::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageDefaultPawn::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageDefaultPawn::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageDefaultPawn::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageDefaultPawn::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageDefaultPawn::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageDefaultPawn::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageDefaultPawn::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageDefaultPawn::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageDefaultPawn::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageDefaultPawn::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageDefaultPawn::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageDefaultPawn::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageDefaultPawn::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageDefaultPawn::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageDefaultPawn::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageDefaultPawn::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageDefaultPawn::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageDefaultPawn::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageDefaultPawn::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageDefaultPawn::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageDefaultPawn::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageDefaultPawn::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageDefaultPawn::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageDefaultPawn::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageDefaultPawn::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageDefaultPawn::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageDefaultPawn::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageDefaultPawn::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageDefaultPawn::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageDefaultPawn::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageDefaultPawn::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageDefaultPawn::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageDefaultPawn::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageDefaultPawn::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageDefaultPawn::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageDefaultPawn::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageDefaultPawn::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageDefaultPawn::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageDefaultPawn::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageDefaultPawn::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageDefaultPawn::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageDefaultPawn::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageDefaultPawn::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageDefaultPawn::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageDefaultPawn::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageDefaultPawn::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageDefaultPawn::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageDefaultPawn::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageDefaultPawn::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageDefaultPawn::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageDefaultPawn::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageDefaultPawn::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageDefaultPawn::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageDefaultPawn::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageDefaultPawn::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageDefaultPawn::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageDefaultPawn::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageDefaultPawn::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageDefaultPawn::_Supper__Reset()
{
	Super::Reset();
}

void AManageDefaultPawn::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageDefaultPawn::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageDefaultPawn::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageDefaultPawn::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageDefaultPawn::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageDefaultPawn::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageDefaultPawn::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageDefaultPawn::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageDefaultPawn::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageDefaultPawn::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageDefaultPawn::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageDefaultPawn::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageDefaultPawn::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageDefaultPawn::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageDefaultPawn::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageDefaultPawn::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageDefaultPawn::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageDefaultPawn::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageDefaultPawn::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageDefaultPawn::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageDefaultPawn::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageDefaultPawn::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageDefaultPawn::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageDefaultPawn::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageDefaultPawn::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageDefaultPawn::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageDefaultPawn::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageDefaultPawn::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageDefaultPawn::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageDefaultPawn::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageDefaultPawn::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageDefaultPawn::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageDefaultPawn::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageDefaultPawn::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageDefaultPawn::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageDefaultPawn::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageDefaultPawn::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageDefaultPawn::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageDefaultPawn::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageDefaultPawn::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageDefaultPawn::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageDefaultPawn::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageDefaultPawn::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageDefaultPawn::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageDefaultPawn::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageDefaultPawn::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageDefaultPawn::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageDefaultPawn::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
