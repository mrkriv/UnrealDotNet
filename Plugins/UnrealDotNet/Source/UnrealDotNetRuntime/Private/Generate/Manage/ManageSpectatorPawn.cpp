// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSpectatorPawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

AManageSpectatorPawn::AManageSpectatorPawn(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManageSpectatorPawn::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManageSpectatorPawn::LookUpAtRate(float Rate)
{
	Super::LookUpAtRate(Rate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LookUpAtRate", Rate);
}

void AManageSpectatorPawn::MoveForward(float Val)
{
	Super::MoveForward(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveForward", Val);
}

void AManageSpectatorPawn::MoveRight(float Val)
{
	Super::MoveRight(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveRight", Val);
}

void AManageSpectatorPawn::MoveUp_World(float Val)
{
	Super::MoveUp_World(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MoveUp_World", Val);
}

void AManageSpectatorPawn::TurnAtRate(float Rate)
{
	Super::TurnAtRate(Rate);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnAtRate", Rate);
}

void AManageSpectatorPawn::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManageSpectatorPawn::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManageSpectatorPawn::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManageSpectatorPawn::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManageSpectatorPawn::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManageSpectatorPawn::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManageSpectatorPawn::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManageSpectatorPawn::OnRep_Controller()
{
	Super::OnRep_Controller();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
}

void AManageSpectatorPawn::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
}

void AManageSpectatorPawn::PawnClientRestart()
{
	Super::PawnClientRestart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
}

void AManageSpectatorPawn::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManageSpectatorPawn::PossessedBy(AController* NewController)
{
	Super::PossessedBy(NewController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PossessedBy", NewController);
}

void AManageSpectatorPawn::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManageSpectatorPawn::Restart()
{
	Super::Restart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
}

void AManageSpectatorPawn::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
}

void AManageSpectatorPawn::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetupPlayerInputComponent", PlayerInputComponent);
}

void AManageSpectatorPawn::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
}

void AManageSpectatorPawn::TurnOff()
{
	Super::TurnOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
}

void AManageSpectatorPawn::UnPossessed()
{
	Super::UnPossessed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
}

void AManageSpectatorPawn::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
}

void AManageSpectatorPawn::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageSpectatorPawn::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageSpectatorPawn::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageSpectatorPawn::BecomeViewTarget(APlayerController* PC)
{
	Super::BecomeViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BecomeViewTarget", PC);
}

void AManageSpectatorPawn::BeginPlay()
{
	Super::BeginPlay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
}

void AManageSpectatorPawn::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageSpectatorPawn::Destroyed()
{
	Super::Destroyed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Destroyed");
}

void AManageSpectatorPawn::DisableInput(APlayerController* PlayerController)
{
	Super::DisableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableInput", PlayerController);
}

void AManageSpectatorPawn::EnableInput(APlayerController* PlayerController)
{
	Super::EnableInput(PlayerController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableInput", PlayerController);
}

void AManageSpectatorPawn::EndViewTarget(APlayerController* PC)
{
	Super::EndViewTarget(PC);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndViewTarget", PC);
}

void AManageSpectatorPawn::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetRelevant");
}

void AManageSpectatorPawn::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ForceNetUpdate");
}

void AManageSpectatorPawn::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "GatherCurrentMovement");
}

void AManageSpectatorPawn::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageSpectatorPawn::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "K2_DestroyActor");
}

void AManageSpectatorPawn::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanExpired");
}

void AManageSpectatorPawn::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageSpectatorPawn::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageSpectatorPawn::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageSpectatorPawn::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageSpectatorPawn::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageSpectatorPawn::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageSpectatorPawn::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnConstruction", Transform);
}

void AManageSpectatorPawn::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageSpectatorPawn::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Instigator");
}

void AManageSpectatorPawn::OnRep_Owner()
{
	Super::OnRep_Owner();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Owner");
}

void AManageSpectatorPawn::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageSpectatorPawn::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageSpectatorPawn::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageSpectatorPawn::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageSpectatorPawn::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageSpectatorPawn::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OutsideWorldBounds");
}

void AManageSpectatorPawn::PostActorCreated()
{
	Super::PostActorCreated();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostActorCreated");
}

void AManageSpectatorPawn::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitializeComponents");
}

void AManageSpectatorPawn::PostNetInit()
{
	Super::PostNetInit();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetInit");
}

void AManageSpectatorPawn::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageSpectatorPawn::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageSpectatorPawn::PostNetReceiveRole()
{
	Super::PostNetReceiveRole();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveRole");
}

void AManageSpectatorPawn::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageSpectatorPawn::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageSpectatorPawn::PostRenderFor(APlayerController* PC, UCanvas* Canvas, FVector CameraPosition, FVector CameraDir)
{
	Super::PostRenderFor(PC, Canvas, CameraPosition, CameraDir);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRenderFor", PC, Canvas, CameraPosition, CameraDir);
}

void AManageSpectatorPawn::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageSpectatorPawn::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreInitializeComponents");
}

void AManageSpectatorPawn::PreRegisterAllComponents()
{
	Super::PreRegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreRegisterAllComponents");
}

void AManageSpectatorPawn::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageSpectatorPawn::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageSpectatorPawn::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterAllComponents");
}

void AManageSpectatorPawn::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageSpectatorPawn::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageSpectatorPawn::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ReregisterAllComponents");
}

void AManageSpectatorPawn::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RerunConstructionScripts");
}

void AManageSpectatorPawn::Reset()
{
	Super::Reset();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Reset");
}

void AManageSpectatorPawn::RewindForReplay()
{
	Super::RewindForReplay();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RewindForReplay");
}

void AManageSpectatorPawn::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageSpectatorPawn::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageSpectatorPawn::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageSpectatorPawn::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageSpectatorPawn::TearOff()
{
	Super::TearOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TearOff");
}

void AManageSpectatorPawn::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageSpectatorPawn::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageSpectatorPawn::TornOff()
{
	Super::TornOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TornOff");
}

void AManageSpectatorPawn::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageSpectatorPawn::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void AManageSpectatorPawn::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void AManageSpectatorPawn::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageSpectatorPawn::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void AManageSpectatorPawn::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void AManageSpectatorPawn::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void AManageSpectatorPawn::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void AManageSpectatorPawn::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void AManageSpectatorPawn::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void AManageSpectatorPawn::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageSpectatorPawn::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void AManageSpectatorPawn::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageSpectatorPawn::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageSpectatorPawn::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void AManageSpectatorPawn::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void AManageSpectatorPawn::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void AManageSpectatorPawn::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
