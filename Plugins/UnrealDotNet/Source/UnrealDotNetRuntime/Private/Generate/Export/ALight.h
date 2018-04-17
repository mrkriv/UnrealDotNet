#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/Light.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

class E_PROTECTED_WRAP_ALight : protected ALight
{
public:
	bool HasNetOwner_WRAP()
	{
		return HasNetOwner();
	}

	void OnRep_Owner_WRAP()
	{
		OnRep_Owner();
	}

	void RegisterActorTickFunctions_WRAP(bool bRegister)
	{
		RegisterActorTickFunctions(bRegister);
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ALight(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ALight>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ALight_Destroyed(ALight* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_ALight_GetBrightness(ALight* Self)
	{
		return Self->GetBrightness();
	}

	DOTNET_EXPORT auto E_ALight_GetLightComponent(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetLightComponent());
	}

	DOTNET_EXPORT auto E_ALight_IsEnabled(ALight* Self)
	{
		return Self->IsEnabled();
	}

	DOTNET_EXPORT auto E_ALight_IsLevelBoundsRelevant(ALight* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_ALight_IsToggleable(ALight* Self)
	{
		return Self->IsToggleable();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_bEnabled(ALight* Self)
	{
		Self->OnRep_bEnabled();
	}

	DOTNET_EXPORT auto E_ALight_SetAffectTranslucentLighting(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetBrightness(ALight* Self, float NewBrightness)
	{
		auto _p0 = NewBrightness;
		Self->SetBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetCastShadows(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastShadows(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetEnabled(ALight* Self, bool bSetEnabled)
	{
		auto _p0 = bSetEnabled;
		Self->SetEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionFadeDistance(ALight* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionScale(ALight* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ToggleEnabled(ALight* Self)
	{
		Self->ToggleEnabled();
	}

	DOTNET_EXPORT auto E_ALight_AddTickPrerequisiteActor(ALight* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ALight_AddTickPrerequisiteComponent(ALight* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ApplyWorldOffset(ALight* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ALight_BeginDestroy(ALight* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ALight_BeginPlay(ALight* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ALight_CalculateComponentsBoundingBoxInLocalSpace(ALight* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_ALight_CanBeBaseForCharacter(ALight* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_ALight_CanBeInCluster(ALight* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ALight_CheckDefaultSubobjectsInternal(ALight* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ALight_CheckStillInWorld(ALight* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_ALight_ClearCrossLevelReferences(ALight* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_ALight_DestroyNetworkActorHandled(ALight* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_ALight_ForceNetRelevant(ALight* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_ALight_ForceNetUpdate(ALight* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_ALight_GatherCurrentMovement(ALight* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_ALight_GetActorEyesViewPoint(ALight* Self, INT_PTR OutLocation, INT_PTR OutRotation)
	{
		auto _p0 = *(FVector*)OutLocation;
		auto _p1 = *(FRotator*)OutRotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ALight_GetComponentsBoundingBox(ALight* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_ALight_GetComponentsBoundingCylinder(ALight* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ALight_GetComponentsCollisionResponseToChannel(ALight* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ALight_GetDefaultAttachComponent(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_ALight_GetHumanReadableName(ALight* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_ALight_GetLastRenderTime(ALight* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_ALight_GetLifeSpan(ALight* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_ALight_GetNetOwningPlayer(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_ALight_GetSimpleCollisionCylinder(ALight* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ALight_GetTargetLocation(ALight* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_ALight_GetVelocity(ALight* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_ALight_GetWorld(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_ALight_HasActiveCameraComponent(ALight* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_ALight_HasActivePawnControlCameraComponent(ALight* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_ALight_HasNetOwner(ALight* Self)
	{
		return ((E_PROTECTED_WRAP_ALight*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_ALight_InvalidateLightingCacheDetailed(ALight* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_ALight_IsAttachedTo(ALight* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_ALight_IsBasedOnActor(ALight* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_ALight_IsComponentRelevantForNavigation(ALight* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_ALight_IsNameStableForNetworking(ALight* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ALight_IsNetRelevantFor(ALight* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ALight_IsReadyForFinishDestroy(ALight* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ALight_IsRelevancyOwnerFor(ALight* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ALight_IsReplayRelevantFor(ALight* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ALight_IsRootComponentCollisionRegistered(ALight* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_ALight_IsSupportedForNetworking(ALight* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ALight_K2_DestroyActor(ALight* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_ALight_LifeSpanExpired(ALight* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_ALight_MarkComponentsAsPendingKill(ALight* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_ALight_Modify(ALight* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ALight_NotifyActorBeginCursorOver(ALight* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_ALight_NotifyActorBeginOverlap(ALight* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ALight_NotifyActorEndCursorOver(ALight* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_ALight_NotifyActorEndOverlap(ALight* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ALight_NotifyHit(ALight* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
	{
		auto _p0 = MyComp;
		auto _p1 = Other;
		auto _p2 = OtherComp;
		auto _p3 = bSelfMoved;
		auto _p4 = *(FVector*)HitLocation;
		auto _p5 = *(FVector*)HitNormal;
		auto _p6 = *(FVector*)NormalImpulse;
		auto _p7 = *(FHitResult*)Hit;
		Self->NotifyHit(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_ALight_OnConstruction(ALight* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_ALight_OnRep_AttachmentReplication(ALight* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_Instigator(ALight* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_Owner(ALight* Self)
	{
		((E_PROTECTED_WRAP_ALight*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_ReplicatedMovement(ALight* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_ReplicateMovement(ALight* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_ALight_OnReplicationPausedChanged(ALight* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_ALight_OnSubobjectCreatedFromReplication(ALight* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ALight_OnSubobjectDestroyFromReplication(ALight* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ALight_OutsideWorldBounds(ALight* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_ALight_PostActorCreated(ALight* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_ALight_PostInitializeComponents(ALight* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_ALight_PostInitProperties(ALight* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ALight_PostLoad(ALight* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ALight_PostNetInit(ALight* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_ALight_PostNetReceive(ALight* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ALight_PostNetReceiveLocationAndRotation(ALight* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_ALight_PostNetReceivePhysicState(ALight* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_ALight_PostNetReceiveVelocity(ALight* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_ALight_PostRegisterAllComponents(ALight* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ALight_PostRename(ALight* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ALight_PostUnregisterAllComponents(ALight* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ALight_PreInitializeComponents(ALight* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_ALight_PreNetReceive(ALight* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ALight_PrestreamTextures(ALight* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ALight_RegisterActorTickFunctions(ALight* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_ALight*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ALight_RegisterAllComponents(ALight* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ALight_RemoveTickPrerequisiteActor(ALight* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ALight_RemoveTickPrerequisiteComponent(ALight* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ReregisterAllComponents(ALight* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ALight_RerunConstructionScripts(ALight* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_ALight_Reset(ALight* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_ALight_SetActorHiddenInGame(ALight* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLifeSpan(ALight* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetOwner(ALight* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetReplicateMovement(ALight* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ShouldTickIfViewportsOnly(ALight* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_ALight_TearOff(ALight* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_ALight_TeleportSucceeded(ALight* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_ALight_TeleportTo(ALight* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ALight_Tick(ALight* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_ALight_TickActor(ALight* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ALight_TornOff(ALight* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_ALight_UnregisterAllComponents(ALight* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_ALight_UseShortConnectTimeout(ALight* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_ALight_AreNativePropertiesIdenticalTo(ALight* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ALight_FinishDestroy(ALight* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ALight_GetDesc(ALight* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ALight_GetDetailedInfoInternal(ALight* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ALight_IsAsset(ALight* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ALight_IsEditorOnly(ALight* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ALight_IsFullNameStableForNetworking(ALight* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ALight_IsLocalizedResource(ALight* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ALight_IsPostLoadThreadSafe(ALight* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ALight_IsSafeForRootSet(ALight* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ALight_MarkAsEditorOnlySubobject(ALight* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ALight_NeedsLoadForClient(ALight* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ALight_NeedsLoadForEditorGame(ALight* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ALight_NeedsLoadForServer(ALight* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ALight_NotifyObjectReferenceEliminated(ALight* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ALight_PostCDOContruct(ALight* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ALight_PostEditImport(ALight* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ALight_PostRepNotifies(ALight* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ALight_PostSaveRoot(ALight* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ALight_PreDestroyFromReplication(ALight* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ALight_ShutdownAfterError(ALight* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ALight_AddToCluster(ALight* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ALight_CanBeClusterRoot(ALight* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ALight_CreateCluster(ALight* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ALight_OnClusterMarkedAsPendingKill(ALight* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
