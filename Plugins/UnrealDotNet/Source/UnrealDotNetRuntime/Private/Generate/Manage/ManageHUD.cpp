#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageHUD.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:35

FString AManageHUD::GetProperty(const FString& Property)
{
	return bIsManageAttach ? UCoreShell::GetProperty(this, Property) : "";
}

void AManageHUD::SetProperty(const FString& Property, const FString& Value)
{
	if (bIsManageAttach) UCoreShell::SetProperty(this, Property, Value);
}

void AManageHUD::AddPostRenderedActor(AActor* A)
{
	Super::AddPostRenderedActor(A);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddPostRenderedActor", A);
}

void AManageHUD::DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
{
	Super::DrawActorOverlays(Viewpoint, ViewRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawActorOverlays", Viewpoint, ViewRotation);
}

void AManageHUD::DrawHUD()
{
	Super::DrawHUD();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawHUD");
}

void AManageHUD::DrawSafeZoneOverlay()
{
	Super::DrawSafeZoneOverlay();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DrawSafeZoneOverlay");
}

void AManageHUD::HandleBugScreenShot()
{
	Super::HandleBugScreenShot();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleBugScreenShot");
}

void AManageHUD::NextDebugTarget()
{
	Super::NextDebugTarget();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NextDebugTarget");
}

void AManageHUD::NotifyBindPostProcessEffects()
{
	Super::NotifyBindPostProcessEffects();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyBindPostProcessEffects");
}

void AManageHUD::NotifyHitBoxBeginCursorOver(FName BoxName)
{
	Super::NotifyHitBoxBeginCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxBeginCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxClick(FName BoxName)
{
	Super::NotifyHitBoxClick(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxClick", BoxName);
}

void AManageHUD::NotifyHitBoxEndCursorOver(FName BoxName)
{
	Super::NotifyHitBoxEndCursorOver(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxEndCursorOver", BoxName);
}

void AManageHUD::NotifyHitBoxRelease(FName BoxName)
{
	Super::NotifyHitBoxRelease(BoxName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHitBoxRelease", BoxName);
}

void AManageHUD::OnLostFocusPause(bool bEnable)
{
	Super::OnLostFocusPause(bEnable);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnLostFocusPause", bEnable);
}

void AManageHUD::PostInitializeComponents()
{
	Super::PostInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitializeComponents");
}

void AManageHUD::PostRender()
{
	Super::PostRender();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRender");
}

void AManageHUD::PreviousDebugTarget()
{
	Super::PreviousDebugTarget();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreviousDebugTarget");
}

void AManageHUD::RemovePostRenderedActor(AActor* A)
{
	Super::RemovePostRenderedActor(A);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemovePostRenderedActor", A);
}

void AManageHUD::ShowDebug(FName DebugType)
{
	Super::ShowDebug(DebugType);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowDebug", DebugType);
}

void AManageHUD::ShowDebugInfo(float& YL, float& YPos)
{
	Super::ShowDebugInfo(YL, YPos);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowDebugInfo", YL, YPos);
}

void AManageHUD::ShowHUD()
{
	Super::ShowHUD();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShowHUD");
}

void AManageHUD::AddTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::AddTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteActor", PrerequisiteActor);
}

void AManageHUD::AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::AddTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageHUD::ApplyWorldOffset(const FVector& InOffset, bool bWorldShift)
{
	Super::ApplyWorldOffset(InOffset, bWorldShift);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyWorldOffset", InOffset, bWorldShift);
}

void AManageHUD::BeginDestroy()
{
	Super::BeginDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginDestroy");
}

void AManageHUD::BeginPlay()
{
	if (!ManageClassName.FullName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName.PackJSON()));
	}

	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "BeginPlay");
	Super::BeginPlay();
}

void AManageHUD::ClearCrossLevelReferences()
{
	Super::ClearCrossLevelReferences();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearCrossLevelReferences");
}

void AManageHUD::Destroyed()
{
	Super::Destroyed();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Destroyed");
}

void AManageHUD::ForceNetRelevant()
{
	Super::ForceNetRelevant();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetRelevant");
}

void AManageHUD::ForceNetUpdate()
{
	Super::ForceNetUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceNetUpdate");
}

void AManageHUD::GatherCurrentMovement()
{
	Super::GatherCurrentMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "GatherCurrentMovement");
}

void AManageHUD::InvalidateLightingCacheDetailed(bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bTranslationOnly);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "InvalidateLightingCacheDetailed", bTranslationOnly);
}

void AManageHUD::K2_DestroyActor()
{
	Super::K2_DestroyActor();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "K2_DestroyActor");
}

void AManageHUD::LifeSpanExpired()
{
	Super::LifeSpanExpired();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LifeSpanExpired");
}

void AManageHUD::MarkComponentsAsPendingKill()
{
	Super::MarkComponentsAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkComponentsAsPendingKill");
}

void AManageHUD::NotifyActorBeginCursorOver()
{
	Super::NotifyActorBeginCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginCursorOver");
}

void AManageHUD::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorBeginOverlap", OtherActor);
}

void AManageHUD::NotifyActorEndCursorOver()
{
	Super::NotifyActorEndCursorOver();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndCursorOver");
}

void AManageHUD::NotifyActorEndOverlap(AActor* OtherActor)
{
	Super::NotifyActorEndOverlap(OtherActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyActorEndOverlap", OtherActor);
}

void AManageHUD::NotifyHit(UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, const FHitResult& Hit)
{
	Super::NotifyHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyHit", MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
}

void AManageHUD::OnConstruction(const FTransform& Transform)
{
	Super::OnConstruction(Transform);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnConstruction", Transform);
}

void AManageHUD::OnRep_AttachmentReplication()
{
	Super::OnRep_AttachmentReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_AttachmentReplication");
}

void AManageHUD::OnRep_Instigator()
{
	Super::OnRep_Instigator();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Instigator");
}

void AManageHUD::OnRep_Owner()
{
	Super::OnRep_Owner();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_Owner");
}

void AManageHUD::OnRep_ReplicatedMovement()
{
	Super::OnRep_ReplicatedMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicatedMovement");
}

void AManageHUD::OnRep_ReplicateMovement()
{
	Super::OnRep_ReplicateMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_ReplicateMovement");
}

void AManageHUD::OnReplicationPausedChanged(bool bIsReplicationPaused)
{
	Super::OnReplicationPausedChanged(bIsReplicationPaused);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnReplicationPausedChanged", bIsReplicationPaused);
}

void AManageHUD::OnSubobjectCreatedFromReplication(UObject* NewSubobject)
{
	Super::OnSubobjectCreatedFromReplication(NewSubobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectCreatedFromReplication", NewSubobject);
}

void AManageHUD::OnSubobjectDestroyFromReplication(UObject* Subobject)
{
	Super::OnSubobjectDestroyFromReplication(Subobject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnSubobjectDestroyFromReplication", Subobject);
}

void AManageHUD::OutsideWorldBounds()
{
	Super::OutsideWorldBounds();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OutsideWorldBounds");
}

void AManageHUD::PostActorCreated()
{
	Super::PostActorCreated();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostActorCreated");
}

void AManageHUD::PostInitProperties()
{
	Super::PostInitProperties();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostInitProperties");
}

void AManageHUD::PostLoad()
{
	Super::PostLoad();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostLoad");
}

void AManageHUD::PostNetInit()
{
	Super::PostNetInit();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetInit");
}

void AManageHUD::PostNetReceive()
{
	Super::PostNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceive");
}

void AManageHUD::PostNetReceiveLocationAndRotation()
{
	Super::PostNetReceiveLocationAndRotation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveLocationAndRotation");
}

void AManageHUD::PostNetReceivePhysicState()
{
	Super::PostNetReceivePhysicState();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceivePhysicState");
}

void AManageHUD::PostNetReceiveVelocity(const FVector& NewVelocity)
{
	Super::PostNetReceiveVelocity(NewVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostNetReceiveVelocity", NewVelocity);
}

void AManageHUD::PostRegisterAllComponents()
{
	Super::PostRegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRegisterAllComponents");
}

void AManageHUD::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void AManageHUD::PostUnregisterAllComponents()
{
	Super::PostUnregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostUnregisterAllComponents");
}

void AManageHUD::PreInitializeComponents()
{
	Super::PreInitializeComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreInitializeComponents");
}

void AManageHUD::PreNetReceive()
{
	Super::PreNetReceive();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreNetReceive");
}

void AManageHUD::PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
{
	Super::PrestreamTextures(Seconds, bEnableStreaming, CinematicTextureGroups);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PrestreamTextures", Seconds, bEnableStreaming, CinematicTextureGroups);
}

void AManageHUD::RegisterActorTickFunctions(bool bRegister)
{
	Super::RegisterActorTickFunctions(bRegister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterActorTickFunctions", bRegister);
}

void AManageHUD::RegisterAllComponents()
{
	Super::RegisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterAllComponents");
}

void AManageHUD::RemoveTickPrerequisiteActor(AActor* PrerequisiteActor)
{
	Super::RemoveTickPrerequisiteActor(PrerequisiteActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteActor", PrerequisiteActor);
}

void AManageHUD::RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent)
{
	Super::RemoveTickPrerequisiteComponent(PrerequisiteComponent);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RemoveTickPrerequisiteComponent", PrerequisiteComponent);
}

void AManageHUD::ReregisterAllComponents()
{
	Super::ReregisterAllComponents();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReregisterAllComponents");
}

void AManageHUD::RerunConstructionScripts()
{
	Super::RerunConstructionScripts();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RerunConstructionScripts");
}

void AManageHUD::Reset()
{
	Super::Reset();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Reset");
}

void AManageHUD::SetActorHiddenInGame(bool bNewHidden)
{
	Super::SetActorHiddenInGame(bNewHidden);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetActorHiddenInGame", bNewHidden);
}

void AManageHUD::SetLifeSpan(float InLifespan)
{
	Super::SetLifeSpan(InLifespan);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetLifeSpan", InLifespan);
}

void AManageHUD::SetOwner(AActor* NewOwner)
{
	Super::SetOwner(NewOwner);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetOwner", NewOwner);
}

void AManageHUD::SetReplicateMovement(bool bInReplicateMovement)
{
	Super::SetReplicateMovement(bInReplicateMovement);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetReplicateMovement", bInReplicateMovement);
}

void AManageHUD::TearOff()
{
	Super::TearOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TearOff");
}

void AManageHUD::TeleportSucceeded(bool bIsATest)
{
	Super::TeleportSucceeded(bIsATest);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TeleportSucceeded", bIsATest);
}

void AManageHUD::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Tick", DeltaSeconds);
}

void AManageHUD::TornOff()
{
	Super::TornOff();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "TornOff");
}

void AManageHUD::UnregisterAllComponents(bool bForReregister)
{
	Super::UnregisterAllComponents(bForReregister);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnregisterAllComponents", bForReregister);
}

void AManageHUD::FinishDestroy()
{
	Super::FinishDestroy();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "FinishDestroy");
}

void AManageHUD::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void AManageHUD::PostCDOContruct()
{
	Super::PostCDOContruct();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostCDOContruct");
}

void AManageHUD::PostEditImport()
{
	Super::PostEditImport();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostEditImport");
}

void AManageHUD::PostRepNotifies()
{
	Super::PostRepNotifies();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostRepNotifies");
}

void AManageHUD::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void AManageHUD::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreDestroyFromReplication");
}

void AManageHUD::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAfterError");
}

void AManageHUD::AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
{
	Super::AddToCluster(ClusterRootOrObjectFromCluster, bAddAsMutableObject);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddToCluster", ClusterRootOrObjectFromCluster, bAddAsMutableObject);
}

void AManageHUD::CreateCluster()
{
	Super::CreateCluster();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CreateCluster");
}

void AManageHUD::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
