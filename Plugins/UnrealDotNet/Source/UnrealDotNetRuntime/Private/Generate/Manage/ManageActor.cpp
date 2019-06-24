// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageActor.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:109

AManageActor::AManageActor(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManageActor::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManageActor::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageActor::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageActor::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageActor::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageActor::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageActor::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageActor::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageActor::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageActor::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageActor::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageActor::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageActor::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageActor::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageActor::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageActor::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageActor::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageActor::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageActor::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageActor::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageActor::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageActor::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageActor::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageActor::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageActor::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageActor::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageActor::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageActor::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageActor::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageActor::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageActor::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageActor::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageActor::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageActor::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageActor::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageActor::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageActor::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageActor::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageActor::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageActor::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageActor::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageActor::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageActor::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageActor::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageActor::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageActor::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageActor::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageActor::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageActor::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageActor::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageActor::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageActor::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageActor::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageActor::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageActor::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageActor::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageActor::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageActor::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageActor::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageActor::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageActor::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageActor::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageActor::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageActor::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageActor::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageActor::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageActor::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageActor::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageActor::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageActor::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageActor::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageActor::_Supper__Reset()
{
	Super::Reset();
}

void AManageActor::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageActor::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageActor::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageActor::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageActor::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageActor::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageActor::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageActor::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageActor::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageActor::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageActor::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageActor::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageActor::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageActor::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageActor::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageActor::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageActor::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageActor::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageActor::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageActor::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageActor::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageActor::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageActor::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageActor::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageActor::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageActor::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageActor::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageActor::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageActor::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageActor::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageActor::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageActor::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageActor::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageActor::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageActor::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageActor::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageActor::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageActor::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageActor::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageActor::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageActor::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageActor::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageActor::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageActor::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageActor::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageActor::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageActor::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageActor::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
