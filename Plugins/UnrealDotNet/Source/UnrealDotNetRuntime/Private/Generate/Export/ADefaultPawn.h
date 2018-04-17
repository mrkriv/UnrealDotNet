#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/DefaultPawn.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

class E_PROTECTED_WRAP_ADefaultPawn : protected ADefaultPawn
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
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_CollisionComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::CollisionComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MeshComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MeshComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MovementComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MovementComponentName); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ADefaultPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ADefaultPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetCollisionComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCollisionComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMeshComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMeshComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddControllerPitchInput(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddControllerRollInput(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddControllerYawInput(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddMovementInput(ADefaultPawn* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		Self->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CanBeBaseForCharacter(ADefaultPawn* Self, APawn* APawn)
	{
		auto _p0 = APawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ConsumeMovementInputVector(ADefaultPawn* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_Destroyed(ADefaultPawn* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_DestroyPlayerInputComponent(ADefaultPawn* Self)
	{
		((E_PROTECTED_WRAP_ADefaultPawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_DetachFromControllerPendingDestroy(ADefaultPawn* Self)
	{
		Self->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_FaceRotation(ADefaultPawn* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		Self->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetActorEyesViewPoint(ADefaultPawn* Self, INT_PTR Location, INT_PTR Rotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)Rotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetBaseAimRotation(ADefaultPawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseAimRotation());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetDefaultHalfHeight(ADefaultPawn* Self)
	{
		return Self->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetHumanReadableName(ADefaultPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMoveGoalReachTest(ADefaultPawn* Self, AActor* MovingActor, INT_PTR MoveOffset, INT_PTR GoalOffset, float GoalRadius, float GoalHalfHeight)
	{
		auto _p0 = MovingActor;
		auto _p1 = *(FVector*)MoveOffset;
		auto _p2 = *(FVector*)GoalOffset;
		auto _p3 = GoalRadius;
		auto _p4 = GoalHalfHeight;
		Self->GetMoveGoalReachTest(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMovementBase(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMovementComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetNavAgentLocation(ADefaultPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetNavAgentLocation());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetNetOwningPlayer(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetPawnNoiseEmitterComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnNoiseEmitterComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetPawnViewLocation(ADefaultPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPawnViewLocation());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetVelocity(ADefaultPawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetViewRotation(ADefaultPawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetViewRotation());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_InFreeCam(ADefaultPawn* Self)
	{
		return Self->InFreeCam();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsBasedOnActor(ADefaultPawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsLocallyControlled(ADefaultPawn* Self)
	{
		return Self->IsLocallyControlled();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsMoveInputIgnored(ADefaultPawn* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsNetRelevantFor(ADefaultPawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsPlayerControlled(ADefaultPawn* Self)
	{
		return Self->IsPlayerControlled();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_Controller(ADefaultPawn* Self)
	{
		Self->OnRep_Controller();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_PlayerState(ADefaultPawn* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OutsideWorldBounds(ADefaultPawn* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PawnClientRestart(ADefaultPawn* Self)
	{
		Self->PawnClientRestart();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PawnStartFire(ADefaultPawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostInitializeComponents(ADefaultPawn* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostLoad(ADefaultPawn* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostNetReceiveLocationAndRotation(ADefaultPawn* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostNetReceiveVelocity(ADefaultPawn* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostRegisterAllComponents(ADefaultPawn* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PreInitializeComponents(ADefaultPawn* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ReachedDesiredRotation(ADefaultPawn* Self)
	{
		return Self->ReachedDesiredRotation();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RecalculateBaseEyeHeight(ADefaultPawn* Self)
	{
		Self->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_Reset(ADefaultPawn* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_Restart(ADefaultPawn* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SetPlayerDefaults(ADefaultPawn* Self)
	{
		Self->SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ShouldTickIfViewportsOnly(ADefaultPawn* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SpawnDefaultController(ADefaultPawn* Self)
	{
		Self->SpawnDefaultController();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TeleportSucceeded(ADefaultPawn* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TurnOff(ADefaultPawn* Self)
	{
		Self->TurnOff();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_UnPossessed(ADefaultPawn* Self)
	{
		Self->UnPossessed();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_UpdateNavigationRelevance(ADefaultPawn* Self)
	{
		Self->UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddTickPrerequisiteActor(ADefaultPawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddTickPrerequisiteComponent(ADefaultPawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ApplyWorldOffset(ADefaultPawn* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_BeginDestroy(ADefaultPawn* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_BeginPlay(ADefaultPawn* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CalculateComponentsBoundingBoxInLocalSpace(ADefaultPawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CanBeInCluster(ADefaultPawn* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CheckDefaultSubobjectsInternal(ADefaultPawn* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CheckStillInWorld(ADefaultPawn* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ClearCrossLevelReferences(ADefaultPawn* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_DestroyNetworkActorHandled(ADefaultPawn* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ForceNetRelevant(ADefaultPawn* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ForceNetUpdate(ADefaultPawn* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GatherCurrentMovement(ADefaultPawn* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetComponentsBoundingBox(ADefaultPawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetComponentsBoundingCylinder(ADefaultPawn* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetComponentsCollisionResponseToChannel(ADefaultPawn* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetDefaultAttachComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetLastRenderTime(ADefaultPawn* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetLifeSpan(ADefaultPawn* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetSimpleCollisionCylinder(ADefaultPawn* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetTargetLocation(ADefaultPawn* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetWorld(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_HasActiveCameraComponent(ADefaultPawn* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_HasActivePawnControlCameraComponent(ADefaultPawn* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_HasNetOwner(ADefaultPawn* Self)
	{
		return ((E_PROTECTED_WRAP_ADefaultPawn*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_InvalidateLightingCacheDetailed(ADefaultPawn* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsAttachedTo(ADefaultPawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsComponentRelevantForNavigation(ADefaultPawn* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsLevelBoundsRelevant(ADefaultPawn* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsNameStableForNetworking(ADefaultPawn* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsReadyForFinishDestroy(ADefaultPawn* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsRelevancyOwnerFor(ADefaultPawn* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsReplayRelevantFor(ADefaultPawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsRootComponentCollisionRegistered(ADefaultPawn* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsSupportedForNetworking(ADefaultPawn* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_K2_DestroyActor(ADefaultPawn* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_LifeSpanExpired(ADefaultPawn* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MarkComponentsAsPendingKill(ADefaultPawn* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_Modify(ADefaultPawn* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyActorBeginCursorOver(ADefaultPawn* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyActorBeginOverlap(ADefaultPawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyActorEndCursorOver(ADefaultPawn* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyActorEndOverlap(ADefaultPawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyHit(ADefaultPawn* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
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

	DOTNET_EXPORT auto E_ADefaultPawn_OnConstruction(ADefaultPawn* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_AttachmentReplication(ADefaultPawn* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_Instigator(ADefaultPawn* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_Owner(ADefaultPawn* Self)
	{
		((E_PROTECTED_WRAP_ADefaultPawn*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_ReplicatedMovement(ADefaultPawn* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnRep_ReplicateMovement(ADefaultPawn* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnReplicationPausedChanged(ADefaultPawn* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnSubobjectCreatedFromReplication(ADefaultPawn* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnSubobjectDestroyFromReplication(ADefaultPawn* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostActorCreated(ADefaultPawn* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostInitProperties(ADefaultPawn* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostNetInit(ADefaultPawn* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostNetReceive(ADefaultPawn* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostNetReceivePhysicState(ADefaultPawn* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostRename(ADefaultPawn* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostUnregisterAllComponents(ADefaultPawn* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PreNetReceive(ADefaultPawn* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PrestreamTextures(ADefaultPawn* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RegisterActorTickFunctions(ADefaultPawn* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_ADefaultPawn*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RegisterAllComponents(ADefaultPawn* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RemoveTickPrerequisiteActor(ADefaultPawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RemoveTickPrerequisiteComponent(ADefaultPawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ReregisterAllComponents(ADefaultPawn* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_RerunConstructionScripts(ADefaultPawn* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SetActorHiddenInGame(ADefaultPawn* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SetLifeSpan(ADefaultPawn* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SetOwner(ADefaultPawn* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_SetReplicateMovement(ADefaultPawn* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TearOff(ADefaultPawn* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TeleportTo(ADefaultPawn* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_Tick(ADefaultPawn* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TickActor(ADefaultPawn* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TornOff(ADefaultPawn* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_UnregisterAllComponents(ADefaultPawn* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_UseShortConnectTimeout(ADefaultPawn* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AreNativePropertiesIdenticalTo(ADefaultPawn* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_FinishDestroy(ADefaultPawn* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetDesc(ADefaultPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetDetailedInfoInternal(ADefaultPawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsAsset(ADefaultPawn* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsEditorOnly(ADefaultPawn* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsFullNameStableForNetworking(ADefaultPawn* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsLocalizedResource(ADefaultPawn* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsPostLoadThreadSafe(ADefaultPawn* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_IsSafeForRootSet(ADefaultPawn* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MarkAsEditorOnlySubobject(ADefaultPawn* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NeedsLoadForClient(ADefaultPawn* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NeedsLoadForEditorGame(ADefaultPawn* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NeedsLoadForServer(ADefaultPawn* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_NotifyObjectReferenceEliminated(ADefaultPawn* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostCDOContruct(ADefaultPawn* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostEditImport(ADefaultPawn* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostRepNotifies(ADefaultPawn* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PostSaveRoot(ADefaultPawn* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_PreDestroyFromReplication(ADefaultPawn* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_ShutdownAfterError(ADefaultPawn* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_AddToCluster(ADefaultPawn* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CanBeClusterRoot(ADefaultPawn* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_CreateCluster(ADefaultPawn* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ADefaultPawn_OnClusterMarkedAsPendingKill(ADefaultPawn* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
