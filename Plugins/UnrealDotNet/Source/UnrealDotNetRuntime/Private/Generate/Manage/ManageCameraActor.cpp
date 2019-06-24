// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCameraActor.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraActor.h:18

AManageCameraActor::AManageCameraActor(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

void AManageCameraActor::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool AManageCameraActor::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageCameraActor::NotifyCameraCut()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyCameraCut");
	else
		Super::NotifyCameraCut();
}

void AManageCameraActor::_Supper__NotifyCameraCut()
{
	Super::NotifyCameraCut();
}

void AManageCameraActor::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void AManageCameraActor::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void AManageCameraActor::ClearCrossLevelReferences()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
	else
		Super::ClearCrossLevelReferences();
}

void AManageCameraActor::_Supper__ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
}

void AManageCameraActor::Destroyed()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
	else
		Super::Destroyed();
}

void AManageCameraActor::_Supper__Destroyed()
{
	Super::Destroyed();
}

void AManageCameraActor::ForceNetRelevant()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
	else
		Super::ForceNetRelevant();
}

void AManageCameraActor::_Supper__ForceNetRelevant()
{
	Super::ForceNetRelevant();
}

void AManageCameraActor::ForceNetUpdate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
	else
		Super::ForceNetUpdate();
}

void AManageCameraActor::_Supper__ForceNetUpdate()
{
	Super::ForceNetUpdate();
}

void AManageCameraActor::GatherCurrentMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
	else
		Super::GatherCurrentMovement();
}

void AManageCameraActor::_Supper__GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
}

void AManageCameraActor::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageCameraActor::_Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
}

void AManageCameraActor::K2_DestroyActor()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
	else
		Super::K2_DestroyActor();
}

void AManageCameraActor::_Supper__K2_DestroyActor()
{
	Super::K2_DestroyActor();
}

void AManageCameraActor::LifeSpanExpired()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
	else
		Super::LifeSpanExpired();
}

void AManageCameraActor::_Supper__LifeSpanExpired()
{
	Super::LifeSpanExpired();
}

void AManageCameraActor::MarkComponentsAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
	else
		Super::MarkComponentsAsPendingKill();
}

void AManageCameraActor::_Supper__MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
}

void AManageCameraActor::NotifyActorBeginCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
	else
		Super::NotifyActorBeginCursorOver();
}

void AManageCameraActor::_Supper__NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
}

void AManageCameraActor::NotifyActorEndCursorOver()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
	else
		Super::NotifyActorEndCursorOver();
}

void AManageCameraActor::_Supper__NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
}

void AManageCameraActor::OnRep_AttachmentReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
	else
		Super::OnRep_AttachmentReplication();
}

void AManageCameraActor::_Supper__OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
}

void AManageCameraActor::OnRep_Instigator()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
	else
		Super::OnRep_Instigator();
}

void AManageCameraActor::_Supper__OnRep_Instigator()
{
	Super::OnRep_Instigator();
}

void AManageCameraActor::OnRep_Owner()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
	else
		Super::OnRep_Owner();
}

void AManageCameraActor::_Supper__OnRep_Owner()
{
	Super::OnRep_Owner();
}

void AManageCameraActor::OnRep_ReplicatedMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
	else
		Super::OnRep_ReplicatedMovement();
}

void AManageCameraActor::_Supper__OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
}

void AManageCameraActor::OnRep_ReplicateMovement()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
	else
		Super::OnRep_ReplicateMovement();
}

void AManageCameraActor::_Supper__OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
}

void AManageCameraActor::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
	else
		Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageCameraActor::_Supper__OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
}

void AManageCameraActor::OutsideWorldBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
	else
		Super::OutsideWorldBounds();
}

void AManageCameraActor::_Supper__OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
}

void AManageCameraActor::PostActorCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
	else
		Super::PostActorCreated();
}

void AManageCameraActor::_Supper__PostActorCreated()
{
	Super::PostActorCreated();
}

void AManageCameraActor::PostInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
	else
		Super::PostInitializeComponents();
}

void AManageCameraActor::_Supper__PostInitializeComponents()
{
	Super::PostInitializeComponents();
}

void AManageCameraActor::PostNetInit()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
	else
		Super::PostNetInit();
}

void AManageCameraActor::_Supper__PostNetInit()
{
	Super::PostNetInit();
}

void AManageCameraActor::PostNetReceiveLocationAndRotation()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
	else
		Super::PostNetReceiveLocationAndRotation();
}

void AManageCameraActor::_Supper__PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
}

void AManageCameraActor::PostNetReceivePhysicState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
	else
		Super::PostNetReceivePhysicState();
}

void AManageCameraActor::_Supper__PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
}

void AManageCameraActor::PostNetReceiveRole()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
	else
		Super::PostNetReceiveRole();
}

void AManageCameraActor::_Supper__PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
}

void AManageCameraActor::PostRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
	else
		Super::PostRegisterAllComponents();
}

void AManageCameraActor::_Supper__PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
}

void AManageCameraActor::PostUnregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
	else
		Super::PostUnregisterAllComponents();
}

void AManageCameraActor::_Supper__PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
}

void AManageCameraActor::PreInitializeComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
	else
		Super::PreInitializeComponents();
}

void AManageCameraActor::_Supper__PreInitializeComponents()
{
	Super::PreInitializeComponents();
}

void AManageCameraActor::PreRegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
	else
		Super::PreRegisterAllComponents();
}

void AManageCameraActor::_Supper__PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
}

void AManageCameraActor::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
	else
		Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCameraActor::_Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageCameraActor::RegisterActorTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
	else
		Super::RegisterActorTickFunctions(bRegister);
}

void AManageCameraActor::_Supper__RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
}

void AManageCameraActor::RegisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
	else
		Super::RegisterAllComponents();
}

void AManageCameraActor::_Supper__RegisterAllComponents()
{
	Super::RegisterAllComponents();
}

void AManageCameraActor::ReregisterAllComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
	else
		Super::ReregisterAllComponents();
}

void AManageCameraActor::_Supper__ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
}

void AManageCameraActor::RerunConstructionScripts()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
	else
		Super::RerunConstructionScripts();
}

void AManageCameraActor::_Supper__RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
}

void AManageCameraActor::Reset()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
	else
		Super::Reset();
}

void AManageCameraActor::_Supper__Reset()
{
	Super::Reset();
}

void AManageCameraActor::RewindForReplay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
	else
		Super::RewindForReplay();
}

void AManageCameraActor::_Supper__RewindForReplay()
{
	Super::RewindForReplay();
}

void AManageCameraActor::SetActorHiddenInGame(bool bNewHidden)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
	else
		Super::SetActorHiddenInGame(bNewHidden);
}

void AManageCameraActor::_Supper__SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
}

void AManageCameraActor::SetLifeSpan(float InLifespan)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
	else
		Super::SetLifeSpan(InLifespan);
}

void AManageCameraActor::_Supper__SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
}

void AManageCameraActor::SetReplicateMovement(bool bInReplicateMovement)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
	else
		Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageCameraActor::_Supper__SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
}

void AManageCameraActor::TearOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
	else
		Super::TearOff();
}

void AManageCameraActor::_Supper__TearOff()
{
	Super::TearOff();
}

void AManageCameraActor::TeleportSucceeded(bool bIsATest)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
	else
		Super::TeleportSucceeded(bIsATest);
}

void AManageCameraActor::_Supper__TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
}

void AManageCameraActor::Tick(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
	else
		Super::Tick(DeltaSeconds);
}

void AManageCameraActor::_Supper__Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

void AManageCameraActor::TornOff()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
	else
		Super::TornOff();
}

void AManageCameraActor::_Supper__TornOff()
{
	Super::TornOff();
}

void AManageCameraActor::UnregisterAllComponents(bool bForReregister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
	else
		Super::UnregisterAllComponents(bForReregister);
}

void AManageCameraActor::_Supper__UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
}

void AManageCameraActor::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void AManageCameraActor::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void AManageCameraActor::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void AManageCameraActor::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void AManageCameraActor::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void AManageCameraActor::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void AManageCameraActor::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void AManageCameraActor::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void AManageCameraActor::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void AManageCameraActor::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void AManageCameraActor::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void AManageCameraActor::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void AManageCameraActor::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void AManageCameraActor::_Supper__PostLoad()
{
	Super::PostLoad();
}

void AManageCameraActor::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void AManageCameraActor::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void AManageCameraActor::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void AManageCameraActor::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void AManageCameraActor::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageCameraActor::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void AManageCameraActor::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void AManageCameraActor::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void AManageCameraActor::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void AManageCameraActor::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void AManageCameraActor::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void AManageCameraActor::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void AManageCameraActor::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void AManageCameraActor::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void AManageCameraActor::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void AManageCameraActor::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
