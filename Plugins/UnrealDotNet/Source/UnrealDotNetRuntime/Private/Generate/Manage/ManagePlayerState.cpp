// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePlayerState.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

AManagePlayerState::AManagePlayerState(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManagePlayerState::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManagePlayerState::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManagePlayerState::HandleWelcomeMessage()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "HandleWelcomeMessage");
	else
		Super::HandleWelcomeMessage();
}

void AManagePlayerState::_Supper__HandleWelcomeMessage()
{
	Super::HandleWelcomeMessage();
}

void AManagePlayerState::OnDeactivated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDeactivated");
	else
		Super::OnDeactivated();
}

void AManagePlayerState::_Supper__OnDeactivated()
{
	Super::OnDeactivated();
}

void AManagePlayerState::OnReactivated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReactivated");
	else
		Super::OnReactivated();
}

void AManagePlayerState::_Supper__OnReactivated()
{
	Super::OnReactivated();
}

void AManagePlayerState::OnRep_bIsInactive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_bIsInactive");
	else
		Super::OnRep_bIsInactive();
}

void AManagePlayerState::_Supper__OnRep_bIsInactive()
{
	Super::OnRep_bIsInactive();
}

void AManagePlayerState::OnRep_PlayerId()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerId");
	else
		Super::OnRep_PlayerId();
}

void AManagePlayerState::_Supper__OnRep_PlayerId()
{
	Super::OnRep_PlayerId();
}

void AManagePlayerState::OnRep_PlayerName()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerName");
	else
		Super::OnRep_PlayerName();
}

void AManagePlayerState::_Supper__OnRep_PlayerName()
{
	Super::OnRep_PlayerName();
}

void AManagePlayerState::OnRep_Score()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Score");
	else
		Super::OnRep_Score();
}

void AManagePlayerState::_Supper__OnRep_Score()
{
	Super::OnRep_Score();
}

void AManagePlayerState::OnRep_UniqueId()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_UniqueId");
	else
		Super::OnRep_UniqueId();
}

void AManagePlayerState::_Supper__OnRep_UniqueId()
{
	Super::OnRep_UniqueId();
}

void AManagePlayerState::RecalculateAvgPing()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateAvgPing");
	else
		Super::RecalculateAvgPing();
}

void AManagePlayerState::_Supper__RecalculateAvgPing()
{
	Super::RecalculateAvgPing();
}

void AManagePlayerState::RegisterPlayerWithSession(bool bWasFromInvite)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterPlayerWithSession", bWasFromInvite);
	else
		Super::RegisterPlayerWithSession(bWasFromInvite);
}

void AManagePlayerState::_Supper__RegisterPlayerWithSession(bool bWasFromInvite)
{
	Super::RegisterPlayerWithSession(bWasFromInvite);
}

void AManagePlayerState::UnregisterPlayerWithSession()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterPlayerWithSession");
	else
		Super::UnregisterPlayerWithSession();
}

void AManagePlayerState::_Supper__UnregisterPlayerWithSession()
{
	Super::UnregisterPlayerWithSession();
}

void AManagePlayerState::UpdatePing(float InPing)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePing", InPing);
	else
		Super::UpdatePing(InPing);
}

void AManagePlayerState::_Supper__UpdatePing(float InPing)
{
	Super::UpdatePing(InPing);
}

void AManagePlayerState::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManagePlayerState::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManagePlayerState::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManagePlayerState::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManagePlayerState::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManagePlayerState::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManagePlayerState::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManagePlayerState::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManagePlayerState::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManagePlayerState::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManagePlayerState::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManagePlayerState::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManagePlayerState::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManagePlayerState::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManagePlayerState::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManagePlayerState::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManagePlayerState::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManagePlayerState::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManagePlayerState::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManagePlayerState::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManagePlayerState::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManagePlayerState::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManagePlayerState::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManagePlayerState::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManagePlayerState::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManagePlayerState::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManagePlayerState::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManagePlayerState::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManagePlayerState::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManagePlayerState::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManagePlayerState::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManagePlayerState::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManagePlayerState::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManagePlayerState::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManagePlayerState::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManagePlayerState::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManagePlayerState::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManagePlayerState::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManagePlayerState::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManagePlayerState::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManagePlayerState::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManagePlayerState::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManagePlayerState::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManagePlayerState::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManagePlayerState::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManagePlayerState::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManagePlayerState::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManagePlayerState::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManagePlayerState::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManagePlayerState::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManagePlayerState::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManagePlayerState::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManagePlayerState::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManagePlayerState::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManagePlayerState::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManagePlayerState::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManagePlayerState::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManagePlayerState::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManagePlayerState::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManagePlayerState::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManagePlayerState::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManagePlayerState::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManagePlayerState::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManagePlayerState::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManagePlayerState::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManagePlayerState::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManagePlayerState::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManagePlayerState::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManagePlayerState::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManagePlayerState::_Supper__Reset()
{
	Super::Reset();
}

void AManagePlayerState::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManagePlayerState::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManagePlayerState::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManagePlayerState::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManagePlayerState::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManagePlayerState::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManagePlayerState::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManagePlayerState::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManagePlayerState::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManagePlayerState::_Supper__TearOff()
{
	Super::TearOff();
}

void AManagePlayerState::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManagePlayerState::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManagePlayerState::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManagePlayerState::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManagePlayerState::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManagePlayerState::_Supper__TornOff()
{
	Super::TornOff();
}

void AManagePlayerState::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManagePlayerState::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManagePlayerState::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManagePlayerState::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManagePlayerState::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManagePlayerState::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManagePlayerState::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManagePlayerState::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManagePlayerState::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManagePlayerState::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManagePlayerState::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManagePlayerState::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManagePlayerState::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManagePlayerState::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManagePlayerState::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManagePlayerState::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManagePlayerState::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManagePlayerState::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManagePlayerState::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManagePlayerState::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManagePlayerState::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManagePlayerState::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManagePlayerState::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManagePlayerState::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManagePlayerState::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManagePlayerState::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManagePlayerState::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManagePlayerState::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManagePlayerState::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManagePlayerState::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManagePlayerState::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManagePlayerState::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
