#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageDefaultPawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

FString AManageDefaultPawn::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void AManageDefaultPawn::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void AManageDefaultPawn::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManageDefaultPawn::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManageDefaultPawn::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManageDefaultPawn::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManageDefaultPawn::Destroyed()
{
	Super::Destroyed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Destroyed");
}

void AManageDefaultPawn::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManageDefaultPawn::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManageDefaultPawn::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManageDefaultPawn::OnRep_Controller()
{
	Super::OnRep_Controller();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Controller");
}

void AManageDefaultPawn::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_PlayerState");
}

void AManageDefaultPawn::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OutsideWorldBounds");
}

void AManageDefaultPawn::PawnClientRestart()
{
	Super::PawnClientRestart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnClientRestart");
}

void AManageDefaultPawn::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManageDefaultPawn::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitializeComponents");
}

void AManageDefaultPawn::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void AManageDefaultPawn::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageDefaultPawn::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageDefaultPawn::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageDefaultPawn::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreInitializeComponents");
}

void AManageDefaultPawn::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManageDefaultPawn::Reset()
{
	Super::Reset();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Reset");
}

void AManageDefaultPawn::Restart()
{
	Super::Restart();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Restart");
}

void AManageDefaultPawn::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPlayerDefaults");
}

void AManageDefaultPawn::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SpawnDefaultController");
}

void AManageDefaultPawn::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageDefaultPawn::TurnOff()
{
	Super::TurnOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TurnOff");
}

void AManageDefaultPawn::UnPossessed()
{
	Super::UnPossessed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnPossessed");
}

void AManageDefaultPawn::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateNavigationRelevance");
}

void AManageDefaultPawn::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageDefaultPawn::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageDefaultPawn::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageDefaultPawn::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void AManageDefaultPawn::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void AManageDefaultPawn::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageDefaultPawn::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetRelevant");
}

void AManageDefaultPawn::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetUpdate");
}

void AManageDefaultPawn::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GatherCurrentMovement");
}

void AManageDefaultPawn::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageDefaultPawn::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "K2_DestroyActor");
}

void AManageDefaultPawn::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LifeSpanExpired");
}

void AManageDefaultPawn::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageDefaultPawn::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageDefaultPawn::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageDefaultPawn::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageDefaultPawn::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageDefaultPawn::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageDefaultPawn::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnConstruction", Transform);
}

void AManageDefaultPawn::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageDefaultPawn::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Instigator");
}

void AManageDefaultPawn::OnRep_Owner()
{
	Super::OnRep_Owner();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Owner");
}

void AManageDefaultPawn::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageDefaultPawn::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageDefaultPawn::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageDefaultPawn::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageDefaultPawn::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageDefaultPawn::PostActorCreated()
{
	Super::PostActorCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostActorCreated");
}

void AManageDefaultPawn::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void AManageDefaultPawn::PostNetInit()
{
	Super::PostNetInit();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetInit");
}

void AManageDefaultPawn::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void AManageDefaultPawn::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageDefaultPawn::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageDefaultPawn::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageDefaultPawn::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void AManageDefaultPawn::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageDefaultPawn::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageDefaultPawn::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterAllComponents");
}

void AManageDefaultPawn::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageDefaultPawn::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageDefaultPawn::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReregisterAllComponents");
}

void AManageDefaultPawn::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RerunConstructionScripts");
}

void AManageDefaultPawn::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageDefaultPawn::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageDefaultPawn::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageDefaultPawn::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageDefaultPawn::TearOff()
{
	Super::TearOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TearOff");
}

void AManageDefaultPawn::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageDefaultPawn::TornOff()
{
	Super::TornOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TornOff");
}

void AManageDefaultPawn::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageDefaultPawn::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void AManageDefaultPawn::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageDefaultPawn::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void AManageDefaultPawn::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void AManageDefaultPawn::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void AManageDefaultPawn::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageDefaultPawn::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageDefaultPawn::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void AManageDefaultPawn::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void AManageDefaultPawn::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void AManageDefaultPawn::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
