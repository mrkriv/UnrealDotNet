#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageActor.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void AManageActor::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageActor::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageActor::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

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

void AManageActor::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageActor::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageActor::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageActor::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnConstruction", Transform);
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

void AManageActor::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageActor::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
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

void AManageActor::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
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

void AManageActor::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterAllComponents");
}

void AManageActor::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageActor::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
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

void AManageActor::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetOwner", NewOwner);
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

void AManageActor::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
