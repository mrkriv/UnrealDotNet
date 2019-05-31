// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageWorldSettings.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

AManageWorldSettings::AManageWorldSettings(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageWorldSettings::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageWorldSettings::NotifyBeginPlay()
{
	Super::NotifyBeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyBeginPlay");
}

void AManageWorldSettings::NotifyMatchStarted()
{
	Super::NotifyMatchStarted();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyMatchStarted");
}

void AManageWorldSettings::OnRep_WorldGravityZ()
{
	Super::OnRep_WorldGravityZ();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_WorldGravityZ");
}

void AManageWorldSettings::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageWorldSettings::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageWorldSettings::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageWorldSettings::BecomeViewTarget(APlayerController* PC)
{
	Super::BecomeViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BecomeViewTarget", PC);
}

void AManageWorldSettings::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void AManageWorldSettings::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageWorldSettings::Destroyed()
{
	Super::Destroyed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
}

void AManageWorldSettings::DisableInput(APlayerController* PlayerController)
{
	Super::DisableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableInput", PlayerController);
}

void AManageWorldSettings::EnableInput(APlayerController* PlayerController)
{
	Super::EnableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableInput", PlayerController);
}

void AManageWorldSettings::EndViewTarget(APlayerController* PC)
{
	Super::EndViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndViewTarget", PC);
}

void AManageWorldSettings::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
}

void AManageWorldSettings::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
}

void AManageWorldSettings::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
}

void AManageWorldSettings::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageWorldSettings::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
}

void AManageWorldSettings::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
}

void AManageWorldSettings::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageWorldSettings::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageWorldSettings::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageWorldSettings::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageWorldSettings::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageWorldSettings::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageWorldSettings::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnConstruction", Transform);
}

void AManageWorldSettings::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageWorldSettings::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
}

void AManageWorldSettings::OnRep_Owner()
{
	Super::OnRep_Owner();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
}

void AManageWorldSettings::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageWorldSettings::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageWorldSettings::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageWorldSettings::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageWorldSettings::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageWorldSettings::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
}

void AManageWorldSettings::PostActorCreated()
{
	Super::PostActorCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
}

void AManageWorldSettings::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
}

void AManageWorldSettings::PostNetInit()
{
	Super::PostNetInit();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
}

void AManageWorldSettings::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageWorldSettings::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageWorldSettings::PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
}

void AManageWorldSettings::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageWorldSettings::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageWorldSettings::PostRenderFor(APlayerController* PC, UCanvas* Canvas, FVector CameraPosition, FVector CameraDir)
{
	Super::PostRenderFor(PC, Canvas, CameraPosition, CameraDir);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRenderFor", PC, Canvas, CameraPosition, CameraDir);
}

void AManageWorldSettings::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageWorldSettings::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
}

void AManageWorldSettings::PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
}

void AManageWorldSettings::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageWorldSettings::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageWorldSettings::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
}

void AManageWorldSettings::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageWorldSettings::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageWorldSettings::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
}

void AManageWorldSettings::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
}

void AManageWorldSettings::Reset()
{
	Super::Reset();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
}

void AManageWorldSettings::RewindForReplay()
{
	Super::RewindForReplay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
}

void AManageWorldSettings::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageWorldSettings::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageWorldSettings::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageWorldSettings::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageWorldSettings::TearOff()
{
	Super::TearOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
}

void AManageWorldSettings::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageWorldSettings::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageWorldSettings::TornOff()
{
	Super::TornOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
}

void AManageWorldSettings::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageWorldSettings::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void AManageWorldSettings::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void AManageWorldSettings::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageWorldSettings::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void AManageWorldSettings::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void AManageWorldSettings::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void AManageWorldSettings::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void AManageWorldSettings::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void AManageWorldSettings::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void AManageWorldSettings::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageWorldSettings::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void AManageWorldSettings::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageWorldSettings::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageWorldSettings::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void AManageWorldSettings::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void AManageWorldSettings::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void AManageWorldSettings::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
