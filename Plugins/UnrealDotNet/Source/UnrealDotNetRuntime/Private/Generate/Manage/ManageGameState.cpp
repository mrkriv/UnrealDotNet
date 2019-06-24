// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

AManageGameState::AManageGameState(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManageGameState::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManageGameState::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageGameState::DefaultTimer()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DefaultTimer");
	else
		Super::DefaultTimer();
}

void AManageGameState::_Supper__DefaultTimer()
{
	Super::DefaultTimer();
}

void AManageGameState::HandleLeavingMap()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleLeavingMap");
	else
		Super::HandleLeavingMap();
}

void AManageGameState::_Supper__HandleLeavingMap()
{
	Super::HandleLeavingMap();
}

void AManageGameState::HandleMatchHasEnded()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasEnded");
	else
		Super::HandleMatchHasEnded();
}

void AManageGameState::_Supper__HandleMatchHasEnded()
{
	Super::HandleMatchHasEnded();
}

void AManageGameState::HandleMatchHasStarted()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchHasStarted");
	else
		Super::HandleMatchHasStarted();
}

void AManageGameState::_Supper__HandleMatchHasStarted()
{
	Super::HandleMatchHasStarted();
}

void AManageGameState::HandleMatchIsWaitingToStart()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleMatchIsWaitingToStart");
	else
		Super::HandleMatchIsWaitingToStart();
}

void AManageGameState::_Supper__HandleMatchIsWaitingToStart()
{
	Super::HandleMatchIsWaitingToStart();
}

void AManageGameState::OnRep_ElapsedTime()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ElapsedTime");
	else
		Super::OnRep_ElapsedTime();
}

void AManageGameState::_Supper__OnRep_ElapsedTime()
{
	Super::OnRep_ElapsedTime();
}

void AManageGameState::OnRep_MatchState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_MatchState");
	else
		Super::OnRep_MatchState();
}

void AManageGameState::_Supper__OnRep_MatchState()
{
	Super::OnRep_MatchState();
}

void AManageGameState::HandleBeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleBeginPlay");
	else
		Super::HandleBeginPlay();
}

void AManageGameState::_Supper__HandleBeginPlay()
{
	Super::HandleBeginPlay();
}

void AManageGameState::OnRep_GameModeClass()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_GameModeClass");
	else
		Super::OnRep_GameModeClass();
}

void AManageGameState::_Supper__OnRep_GameModeClass()
{
	Super::OnRep_GameModeClass();
}

void AManageGameState::OnRep_ReplicatedHasBegunPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedHasBegunPlay");
	else
		Super::OnRep_ReplicatedHasBegunPlay();
}

void AManageGameState::_Supper__OnRep_ReplicatedHasBegunPlay()
{
	Super::OnRep_ReplicatedHasBegunPlay();
}

void AManageGameState::OnRep_ReplicatedWorldTimeSeconds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedWorldTimeSeconds");
	else
		Super::OnRep_ReplicatedWorldTimeSeconds();
}

void AManageGameState::_Supper__OnRep_ReplicatedWorldTimeSeconds()
{
	Super::OnRep_ReplicatedWorldTimeSeconds();
}

void AManageGameState::OnRep_SpectatorClass()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_SpectatorClass");
	else
		Super::OnRep_SpectatorClass();
}

void AManageGameState::_Supper__OnRep_SpectatorClass()
{
	Super::OnRep_SpectatorClass();
}

void AManageGameState::ReceivedGameModeClass()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceivedGameModeClass");
	else
		Super::ReceivedGameModeClass();
}

void AManageGameState::_Supper__ReceivedGameModeClass()
{
	Super::ReceivedGameModeClass();
}

void AManageGameState::ReceivedSpectatorClass()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReceivedSpectatorClass");
	else
		Super::ReceivedSpectatorClass();
}

void AManageGameState::_Supper__ReceivedSpectatorClass()
{
	Super::ReceivedSpectatorClass();
}

void AManageGameState::SeamlessTravelTransitionCheckpoint(bool bToTransitionMap)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SeamlessTravelTransitionCheckpoint", bToTransitionMap);
	else
		Super::SeamlessTravelTransitionCheckpoint(bToTransitionMap);
}

void AManageGameState::_Supper__SeamlessTravelTransitionCheckpoint(bool bToTransitionMap)
{
	Super::SeamlessTravelTransitionCheckpoint(bToTransitionMap);
}

void AManageGameState::UpdateServerTimeSeconds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateServerTimeSeconds");
	else
		Super::UpdateServerTimeSeconds();
}

void AManageGameState::_Supper__UpdateServerTimeSeconds()
{
	Super::UpdateServerTimeSeconds();
}

void AManageGameState::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageGameState::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageGameState::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageGameState::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageGameState::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageGameState::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageGameState::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageGameState::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageGameState::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageGameState::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageGameState::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageGameState::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageGameState::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageGameState::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageGameState::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageGameState::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageGameState::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageGameState::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageGameState::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageGameState::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageGameState::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageGameState::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageGameState::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageGameState::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageGameState::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageGameState::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageGameState::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageGameState::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageGameState::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageGameState::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageGameState::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageGameState::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageGameState::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageGameState::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageGameState::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageGameState::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageGameState::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageGameState::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageGameState::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageGameState::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageGameState::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageGameState::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageGameState::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageGameState::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageGameState::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageGameState::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageGameState::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageGameState::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageGameState::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageGameState::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageGameState::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageGameState::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageGameState::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageGameState::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageGameState::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageGameState::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageGameState::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageGameState::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageGameState::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageGameState::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageGameState::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageGameState::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageGameState::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageGameState::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageGameState::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageGameState::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageGameState::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageGameState::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageGameState::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageGameState::_Supper__Reset()
{
	Super::Reset();
}

void AManageGameState::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageGameState::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageGameState::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageGameState::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageGameState::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageGameState::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageGameState::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageGameState::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageGameState::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageGameState::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageGameState::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageGameState::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageGameState::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageGameState::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageGameState::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageGameState::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageGameState::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageGameState::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageGameState::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageGameState::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageGameState::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageGameState::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageGameState::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageGameState::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageGameState::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageGameState::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageGameState::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageGameState::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageGameState::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageGameState::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageGameState::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageGameState::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageGameState::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageGameState::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageGameState::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageGameState::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageGameState::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageGameState::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageGameState::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageGameState::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageGameState::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageGameState::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageGameState::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageGameState::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageGameState::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageGameState::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageGameState::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageGameState::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
