#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageActor.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:80

void AManageActor::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageActor::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageActor::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageActor::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::GetInstance()->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void AManageActor::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageActor::Destroyed()
{
	Super::Destroyed();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
}

void AManageActor::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
}

void AManageActor::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
}

void AManageActor::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
}

void AManageActor::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageActor::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
}

void AManageActor::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
}

void AManageActor::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageActor::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageActor::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageActor::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageActor::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageActor::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageActor::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnConstruction", Transform);
}

void AManageActor::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageActor::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
}

void AManageActor::OnRep_Owner()
{
	Super::OnRep_Owner();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
}

void AManageActor::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageActor::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageActor::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageActor::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageActor::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageActor::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
}

void AManageActor::PostActorCreated()
{
	Super::PostActorCreated();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
}

void AManageActor::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
}

void AManageActor::PostNetInit()
{
	Super::PostNetInit();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
}

void AManageActor::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageActor::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageActor::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageActor::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageActor::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageActor::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
}

void AManageActor::PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
}

void AManageActor::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageActor::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageActor::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
}

void AManageActor::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageActor::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageActor::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
}

void AManageActor::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
}

void AManageActor::Reset()
{
	Super::Reset();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
}

void AManageActor::RewindForReplay()
{
	Super::RewindForReplay();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
}

void AManageActor::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageActor::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageActor::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageActor::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageActor::TearOff()
{
	Super::TearOff();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
}

void AManageActor::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageActor::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageActor::TornOff()
{
	Super::TornOff();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
}

void AManageActor::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
