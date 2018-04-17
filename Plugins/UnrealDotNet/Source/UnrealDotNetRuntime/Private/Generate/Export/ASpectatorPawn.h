#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

class E_PROTECTED_WRAP_ASpectatorPawn : protected ASpectatorPawn
{
public:
	void DestroyPlayerInputComponent_WRAP()
	{
		DestroyPlayerInputComponent();
	}

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_ASpectatorPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ASpectatorPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddControllerPitchInput(ASpectatorPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddControllerRollInput(ASpectatorPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddControllerYawInput(ASpectatorPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddMovementInput(ASpectatorPawn* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		Self->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CanBeBaseForCharacter(ASpectatorPawn* Self, APawn* APawn)
	{
		auto _p0 = APawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ConsumeMovementInputVector(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_Destroyed(ASpectatorPawn* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_DestroyPlayerInputComponent(ASpectatorPawn* Self)
	{
		((E_PROTECTED_WRAP_ASpectatorPawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_DetachFromControllerPendingDestroy(ASpectatorPawn* Self)
	{
		Self->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_FaceRotation(ASpectatorPawn* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		Self->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetActorEyesViewPoint(ASpectatorPawn* Self, INT_PTR Location, INT_PTR Rotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)Rotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetBaseAimRotation(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseAimRotation());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetDefaultHalfHeight(ASpectatorPawn* Self)
	{
		return Self->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetHumanReadableName(ASpectatorPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetMoveGoalReachTest(ASpectatorPawn* Self, AActor* MovingActor, INT_PTR MoveOffset, INT_PTR GoalOffset, float GoalRadius, float GoalHalfHeight)
	{
		auto _p0 = MovingActor;
		auto _p1 = *(FVector*)MoveOffset;
		auto _p2 = *(FVector*)GoalOffset;
		auto _p3 = GoalRadius;
		auto _p4 = GoalHalfHeight;
		Self->GetMoveGoalReachTest(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetMovementBase(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetMovementComponent(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementComponent());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetNavAgentLocation(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetNavAgentLocation());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetNetOwningPlayer(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetPawnNoiseEmitterComponent(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnNoiseEmitterComponent());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetPawnViewLocation(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPawnViewLocation());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetVelocity(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetViewRotation(ASpectatorPawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetViewRotation());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_InFreeCam(ASpectatorPawn* Self)
	{
		return Self->InFreeCam();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsBasedOnActor(ASpectatorPawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsLocallyControlled(ASpectatorPawn* Self)
	{
		return Self->IsLocallyControlled();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsMoveInputIgnored(ASpectatorPawn* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsNetRelevantFor(ASpectatorPawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsPlayerControlled(ASpectatorPawn* Self)
	{
		return Self->IsPlayerControlled();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_Controller(ASpectatorPawn* Self)
	{
		Self->OnRep_Controller();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_PlayerState(ASpectatorPawn* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OutsideWorldBounds(ASpectatorPawn* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PawnClientRestart(ASpectatorPawn* Self)
	{
		Self->PawnClientRestart();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PawnStartFire(ASpectatorPawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostInitializeComponents(ASpectatorPawn* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostLoad(ASpectatorPawn* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostNetReceiveLocationAndRotation(ASpectatorPawn* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostNetReceiveVelocity(ASpectatorPawn* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostRegisterAllComponents(ASpectatorPawn* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PreInitializeComponents(ASpectatorPawn* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ReachedDesiredRotation(ASpectatorPawn* Self)
	{
		return Self->ReachedDesiredRotation();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RecalculateBaseEyeHeight(ASpectatorPawn* Self)
	{
		Self->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_Reset(ASpectatorPawn* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_Restart(ASpectatorPawn* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SetPlayerDefaults(ASpectatorPawn* Self)
	{
		Self->SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ShouldTickIfViewportsOnly(ASpectatorPawn* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SpawnDefaultController(ASpectatorPawn* Self)
	{
		Self->SpawnDefaultController();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TeleportSucceeded(ASpectatorPawn* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TurnOff(ASpectatorPawn* Self)
	{
		Self->TurnOff();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_UnPossessed(ASpectatorPawn* Self)
	{
		Self->UnPossessed();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_UpdateNavigationRelevance(ASpectatorPawn* Self)
	{
		Self->UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddTickPrerequisiteActor(ASpectatorPawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddTickPrerequisiteComponent(ASpectatorPawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ApplyWorldOffset(ASpectatorPawn* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_BeginDestroy(ASpectatorPawn* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_BeginPlay(ASpectatorPawn* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CalculateComponentsBoundingBoxInLocalSpace(ASpectatorPawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CanBeInCluster(ASpectatorPawn* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CheckDefaultSubobjectsInternal(ASpectatorPawn* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CheckStillInWorld(ASpectatorPawn* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ClearCrossLevelReferences(ASpectatorPawn* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_DestroyNetworkActorHandled(ASpectatorPawn* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ForceNetRelevant(ASpectatorPawn* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ForceNetUpdate(ASpectatorPawn* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GatherCurrentMovement(ASpectatorPawn* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetComponentsBoundingBox(ASpectatorPawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetComponentsBoundingCylinder(ASpectatorPawn* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetComponentsCollisionResponseToChannel(ASpectatorPawn* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetDefaultAttachComponent(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetLastRenderTime(ASpectatorPawn* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetLifeSpan(ASpectatorPawn* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetSimpleCollisionCylinder(ASpectatorPawn* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetTargetLocation(ASpectatorPawn* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetWorld(ASpectatorPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_HasActiveCameraComponent(ASpectatorPawn* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_HasActivePawnControlCameraComponent(ASpectatorPawn* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_HasNetOwner(ASpectatorPawn* Self)
	{
		return ((E_PROTECTED_WRAP_ASpectatorPawn*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_InvalidateLightingCacheDetailed(ASpectatorPawn* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsAttachedTo(ASpectatorPawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsComponentRelevantForNavigation(ASpectatorPawn* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsLevelBoundsRelevant(ASpectatorPawn* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsNameStableForNetworking(ASpectatorPawn* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsReadyForFinishDestroy(ASpectatorPawn* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsRelevancyOwnerFor(ASpectatorPawn* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsReplayRelevantFor(ASpectatorPawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsRootComponentCollisionRegistered(ASpectatorPawn* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsSupportedForNetworking(ASpectatorPawn* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_K2_DestroyActor(ASpectatorPawn* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_LifeSpanExpired(ASpectatorPawn* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_MarkComponentsAsPendingKill(ASpectatorPawn* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_Modify(ASpectatorPawn* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyActorBeginCursorOver(ASpectatorPawn* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyActorBeginOverlap(ASpectatorPawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyActorEndCursorOver(ASpectatorPawn* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyActorEndOverlap(ASpectatorPawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyHit(ASpectatorPawn* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
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

	DOTNET_EXPORT auto E_ASpectatorPawn_OnConstruction(ASpectatorPawn* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_AttachmentReplication(ASpectatorPawn* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_Instigator(ASpectatorPawn* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_Owner(ASpectatorPawn* Self)
	{
		((E_PROTECTED_WRAP_ASpectatorPawn*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_ReplicatedMovement(ASpectatorPawn* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnRep_ReplicateMovement(ASpectatorPawn* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnReplicationPausedChanged(ASpectatorPawn* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnSubobjectCreatedFromReplication(ASpectatorPawn* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnSubobjectDestroyFromReplication(ASpectatorPawn* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostActorCreated(ASpectatorPawn* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostInitProperties(ASpectatorPawn* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostNetInit(ASpectatorPawn* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostNetReceive(ASpectatorPawn* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostNetReceivePhysicState(ASpectatorPawn* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostRename(ASpectatorPawn* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostUnregisterAllComponents(ASpectatorPawn* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PreNetReceive(ASpectatorPawn* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PrestreamTextures(ASpectatorPawn* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RegisterActorTickFunctions(ASpectatorPawn* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_ASpectatorPawn*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RegisterAllComponents(ASpectatorPawn* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RemoveTickPrerequisiteActor(ASpectatorPawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RemoveTickPrerequisiteComponent(ASpectatorPawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ReregisterAllComponents(ASpectatorPawn* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_RerunConstructionScripts(ASpectatorPawn* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SetActorHiddenInGame(ASpectatorPawn* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SetLifeSpan(ASpectatorPawn* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SetOwner(ASpectatorPawn* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_SetReplicateMovement(ASpectatorPawn* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TearOff(ASpectatorPawn* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TeleportTo(ASpectatorPawn* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_Tick(ASpectatorPawn* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TickActor(ASpectatorPawn* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_TornOff(ASpectatorPawn* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_UnregisterAllComponents(ASpectatorPawn* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_UseShortConnectTimeout(ASpectatorPawn* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AreNativePropertiesIdenticalTo(ASpectatorPawn* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_FinishDestroy(ASpectatorPawn* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetDesc(ASpectatorPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_GetDetailedInfoInternal(ASpectatorPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsAsset(ASpectatorPawn* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsEditorOnly(ASpectatorPawn* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsFullNameStableForNetworking(ASpectatorPawn* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsLocalizedResource(ASpectatorPawn* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsPostLoadThreadSafe(ASpectatorPawn* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_IsSafeForRootSet(ASpectatorPawn* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_MarkAsEditorOnlySubobject(ASpectatorPawn* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NeedsLoadForClient(ASpectatorPawn* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NeedsLoadForEditorGame(ASpectatorPawn* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NeedsLoadForServer(ASpectatorPawn* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_NotifyObjectReferenceEliminated(ASpectatorPawn* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostCDOContruct(ASpectatorPawn* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostEditImport(ASpectatorPawn* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostRepNotifies(ASpectatorPawn* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PostSaveRoot(ASpectatorPawn* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_PreDestroyFromReplication(ASpectatorPawn* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_ShutdownAfterError(ASpectatorPawn* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_AddToCluster(ASpectatorPawn* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CanBeClusterRoot(ASpectatorPawn* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_CreateCluster(ASpectatorPawn* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ASpectatorPawn_OnClusterMarkedAsPendingKill(ASpectatorPawn* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
