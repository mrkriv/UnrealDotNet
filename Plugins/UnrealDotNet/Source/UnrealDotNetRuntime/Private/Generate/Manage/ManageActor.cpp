#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageActor.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void AManageActor::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void AManageActor::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageActor::Destroyed()
{
	Super::Destroyed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Destroyed");
}

void AManageActor::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetRelevant");
}

void AManageActor::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetUpdate");
}

void AManageActor::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GatherCurrentMovement");
}

void AManageActor::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageActor::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "K2_DestroyActor");
}

void AManageActor::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LifeSpanExpired");
}

void AManageActor::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageActor::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageActor::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageActor::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageActor::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Instigator");
}

void AManageActor::OnRep_Owner()
{
	Super::OnRep_Owner();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Owner");
}

void AManageActor::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageActor::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageActor::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageActor::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OutsideWorldBounds");
}

void AManageActor::PostActorCreated()
{
	Super::PostActorCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostActorCreated");
}

void AManageActor::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitializeComponents");
}

void AManageActor::PostNetInit()
{
	Super::PostNetInit();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetInit");
}

void AManageActor::PostNetReceiveLocation()
{
	Super::PostNetReceiveLocation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveLocation");
}

void AManageActor::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageActor::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageActor::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageActor::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageActor::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreInitializeComponents");
}

void AManageActor::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageActor::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageActor::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterAllComponents");
}

void AManageActor::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReregisterAllComponents");
}

void AManageActor::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RerunConstructionScripts");
}

void AManageActor::Reset()
{
	Super::Reset();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Reset");
}

void AManageActor::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageActor::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageActor::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageActor::TearOff()
{
	Super::TearOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TearOff");
}

void AManageActor::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageActor::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageActor::TornOff()
{
	Super::TornOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TornOff");
}

void AManageActor::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
