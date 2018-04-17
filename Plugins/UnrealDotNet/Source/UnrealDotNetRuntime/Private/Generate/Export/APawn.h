#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

class E_PROTECTED_WRAP_APawn : protected APawn
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
	DOTNET_EXPORT auto E_PROP_APawn_AllowedYawError_GET(APawn* Ptr) { return Ptr->AllowedYawError; }
	DOTNET_EXPORT void E_PROP_APawn_AllowedYawError_SET(APawn* Ptr, float Value) { Ptr->AllowedYawError = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_AutoPossessAI_GET(APawn* Ptr) { return Ptr->AutoPossessAI; }
	DOTNET_EXPORT void E_PROP_APawn_AutoPossessAI_SET(APawn* Ptr, EAutoPossessAI Value) { Ptr->AutoPossessAI = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_BaseEyeHeight_GET(APawn* Ptr) { return Ptr->BaseEyeHeight; }
	DOTNET_EXPORT void E_PROP_APawn_BaseEyeHeight_SET(APawn* Ptr, float Value) { Ptr->BaseEyeHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_RemoteViewPitch_GET(APawn* Ptr) { return Ptr->RemoteViewPitch; }
	DOTNET_EXPORT void E_PROP_APawn_RemoteViewPitch_SET(APawn* Ptr, uint8 Value) { Ptr->RemoteViewPitch = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_APawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddMovementInput(APawn* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		Self->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_CanBeBaseForCharacter(APawn* Self, APawn* APawn)
	{
		auto _p0 = APawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ConsumeMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_Destroyed(APawn* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_APawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((E_PROTECTED_WRAP_APawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT auto E_APawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		Self->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E_APawn_FaceRotation(APawn* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		Self->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_GetActorEyesViewPoint(APawn* Self, INT_PTR Location, INT_PTR Rotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)Rotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_GetBaseAimRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseAimRotation());
	}

	DOTNET_EXPORT auto E_APawn_GetControlRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetControlRotation());
	}

	DOTNET_EXPORT auto E_APawn_GetDefaultHalfHeight(APawn* Self)
	{
		return Self->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT auto E_APawn_GetGravityDirection(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetGravityDirection());
	}

	DOTNET_EXPORT auto E_APawn_GetHumanReadableName(APawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_APawn_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetLastMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_GetMoveGoalReachTest(APawn* Self, AActor* MovingActor, INT_PTR MoveOffset, INT_PTR GoalOffset, float GoalRadius, float GoalHalfHeight)
	{
		auto _p0 = MovingActor;
		auto _p1 = *(FVector*)MoveOffset;
		auto _p2 = *(FVector*)GoalOffset;
		auto _p3 = GoalRadius;
		auto _p4 = GoalHalfHeight;
		Self->GetMoveGoalReachTest(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_APawn_GetMovementBase(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_APawn_GetMovementBaseActor(APawn* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBaseActor(_p0));
	}

	DOTNET_EXPORT auto E_APawn_GetMovementComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementComponent());
	}

	DOTNET_EXPORT auto E_APawn_GetNavAgentLocation(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetNavAgentLocation());
	}

	DOTNET_EXPORT auto E_APawn_GetNetOwningPlayer(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_APawn_GetPawnNoiseEmitterComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnNoiseEmitterComponent());
	}

	DOTNET_EXPORT auto E_APawn_GetPawnViewLocation(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPawnViewLocation());
	}

	DOTNET_EXPORT auto E_APawn_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPendingMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_GetVelocity(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_APawn_GetViewRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetViewRotation());
	}

	DOTNET_EXPORT auto E_APawn_InFreeCam(APawn* Self)
	{
		return Self->InFreeCam();
	}

	DOTNET_EXPORT auto E_APawn_InputEnabled(APawn* Self)
	{
		return Self->InputEnabled();
	}

	DOTNET_EXPORT auto E_APawn_Internal_AddMovementInput(APawn* Self, INT_PTR WorldAccel, bool bForce)
	{
		auto _p0 = *(FVector*)WorldAccel;
		auto _p1 = bForce;
		Self->Internal_AddMovementInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_Internal_ConsumeMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_Internal_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_GetLastMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_Internal_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_GetPendingMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_IsBasedOnActor(APawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_APawn_IsControlled(APawn* Self)
	{
		return Self->IsControlled();
	}

	DOTNET_EXPORT auto E_APawn_IsLocallyControlled(APawn* Self)
	{
		return Self->IsLocallyControlled();
	}

	DOTNET_EXPORT auto E_APawn_IsMoveInputIgnored(APawn* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_APawn_IsNetRelevantFor(APawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_IsPlayerControlled(APawn* Self)
	{
		return Self->IsPlayerControlled();
	}

	DOTNET_EXPORT auto E_APawn_K2_GetMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_LaunchPawn(APawn* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		Self->LaunchPawn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_MoveIgnoreActorAdd(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		Self->MoveIgnoreActorAdd(_p0);
	}

	DOTNET_EXPORT auto E_APawn_MoveIgnoreActorRemove(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		Self->MoveIgnoreActorRemove(_p0);
	}

	DOTNET_EXPORT auto E_APawn_OnRep_Controller(APawn* Self)
	{
		Self->OnRep_Controller();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_PlayerState(APawn* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_APawn_OutsideWorldBounds(APawn* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_APawn_PawnClientRestart(APawn* Self)
	{
		Self->PawnClientRestart();
	}

	DOTNET_EXPORT auto E_APawn_PawnMakeNoise(APawn* Self, float Loudness, INT_PTR NoiseLocation, bool bUseNoiseMakerLocation, AActor* NoiseMaker)
	{
		auto _p0 = Loudness;
		auto _p1 = *(FVector*)NoiseLocation;
		auto _p2 = bUseNoiseMakerLocation;
		auto _p3 = NoiseMaker;
		Self->PawnMakeNoise(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E_APawn_PostInitializeComponents(APawn* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_APawn_PostLoad(APawn* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_APawn_PostNetReceiveLocationAndRotation(APawn* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_APawn_PostNetReceiveVelocity(APawn* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_APawn_PostRegisterAllComponents(APawn* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_APawn_PreInitializeComponents(APawn* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_APawn_ReachedDesiredRotation(APawn* Self)
	{
		return Self->ReachedDesiredRotation();
	}

	DOTNET_EXPORT auto E_APawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		Self->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E_APawn_Reset(APawn* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_APawn_Restart(APawn* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_APawn_SetCanAffectNavigationGeneration(APawn* Self, bool bNewValue, bool bForceUpdate)
	{
		auto _p0 = bNewValue;
		auto _p1 = bForceUpdate;
		Self->SetCanAffectNavigationGeneration(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_SetPlayerDefaults(APawn* Self)
	{
		Self->SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E_APawn_SetRemoteViewPitch(APawn* Self, float NewRemoteViewPitch)
	{
		auto _p0 = NewRemoteViewPitch;
		Self->SetRemoteViewPitch(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ShouldTickIfViewportsOnly(APawn* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_APawn_SpawnDefaultController(APawn* Self)
	{
		Self->SpawnDefaultController();
	}

	DOTNET_EXPORT auto E_APawn_TeleportSucceeded(APawn* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_APawn_TurnOff(APawn* Self)
	{
		Self->TurnOff();
	}

	DOTNET_EXPORT auto E_APawn_UnPossessed(APawn* Self)
	{
		Self->UnPossessed();
	}

	DOTNET_EXPORT auto E_APawn_UpdateNavAgent(APawn* Self)
	{
		Self->UpdateNavAgent();
	}

	DOTNET_EXPORT auto E_APawn_UpdateNavigationRelevance(APawn* Self)
	{
		Self->UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E_APawn_AddTickPrerequisiteActor(APawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddTickPrerequisiteComponent(APawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ApplyWorldOffset(APawn* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_BeginDestroy(APawn* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_APawn_BeginPlay(APawn* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_APawn_CalculateComponentsBoundingBoxInLocalSpace(APawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_APawn_CanBeInCluster(APawn* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_APawn_CheckDefaultSubobjectsInternal(APawn* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_APawn_CheckStillInWorld(APawn* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_APawn_ClearCrossLevelReferences(APawn* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_APawn_DestroyNetworkActorHandled(APawn* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_APawn_ForceNetRelevant(APawn* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_APawn_ForceNetUpdate(APawn* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_APawn_GatherCurrentMovement(APawn* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_APawn_GetComponentsBoundingBox(APawn* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_APawn_GetComponentsBoundingCylinder(APawn* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_GetComponentsCollisionResponseToChannel(APawn* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_APawn_GetDefaultAttachComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_APawn_GetLastRenderTime(APawn* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_APawn_GetLifeSpan(APawn* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_APawn_GetSimpleCollisionCylinder(APawn* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_GetTargetLocation(APawn* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_APawn_GetWorld(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_APawn_HasActiveCameraComponent(APawn* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_APawn_HasActivePawnControlCameraComponent(APawn* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_APawn_HasNetOwner(APawn* Self)
	{
		return ((E_PROTECTED_WRAP_APawn*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_APawn_InvalidateLightingCacheDetailed(APawn* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_APawn_IsAttachedTo(APawn* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_APawn_IsComponentRelevantForNavigation(APawn* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_APawn_IsLevelBoundsRelevant(APawn* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_APawn_IsNameStableForNetworking(APawn* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_APawn_IsReadyForFinishDestroy(APawn* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_APawn_IsRelevancyOwnerFor(APawn* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_IsReplayRelevantFor(APawn* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APawn_IsRootComponentCollisionRegistered(APawn* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_APawn_IsSupportedForNetworking(APawn* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_APawn_K2_DestroyActor(APawn* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_APawn_LifeSpanExpired(APawn* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_APawn_MarkComponentsAsPendingKill(APawn* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_APawn_Modify(APawn* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_APawn_NotifyActorBeginCursorOver(APawn* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_APawn_NotifyActorBeginOverlap(APawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_APawn_NotifyActorEndCursorOver(APawn* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_APawn_NotifyActorEndOverlap(APawn* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_APawn_NotifyHit(APawn* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
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

	DOTNET_EXPORT auto E_APawn_OnConstruction(APawn* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_APawn_OnRep_AttachmentReplication(APawn* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_Instigator(APawn* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_Owner(APawn* Self)
	{
		((E_PROTECTED_WRAP_APawn*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_ReplicatedMovement(APawn* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_ReplicateMovement(APawn* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_APawn_OnReplicationPausedChanged(APawn* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_APawn_OnSubobjectCreatedFromReplication(APawn* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_APawn_OnSubobjectDestroyFromReplication(APawn* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_APawn_PostActorCreated(APawn* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_APawn_PostInitProperties(APawn* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_APawn_PostNetInit(APawn* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_APawn_PostNetReceive(APawn* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_APawn_PostNetReceivePhysicState(APawn* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_APawn_PostRename(APawn* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_PostUnregisterAllComponents(APawn* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_APawn_PreNetReceive(APawn* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_APawn_PrestreamTextures(APawn* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_RegisterActorTickFunctions(APawn* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_APawn*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APawn_RegisterAllComponents(APawn* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_APawn_RemoveTickPrerequisiteActor(APawn* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_APawn_RemoveTickPrerequisiteComponent(APawn* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ReregisterAllComponents(APawn* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_APawn_RerunConstructionScripts(APawn* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_APawn_SetActorHiddenInGame(APawn* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_APawn_SetLifeSpan(APawn* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_APawn_SetOwner(APawn* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_APawn_SetReplicateMovement(APawn* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_APawn_TearOff(APawn* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_APawn_TeleportTo(APawn* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APawn_Tick(APawn* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_APawn_TickActor(APawn* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_TornOff(APawn* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_APawn_UnregisterAllComponents(APawn* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_APawn_UseShortConnectTimeout(APawn* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_APawn_AreNativePropertiesIdenticalTo(APawn* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_APawn_FinishDestroy(APawn* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_APawn_GetDesc(APawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_APawn_GetDetailedInfoInternal(APawn* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_APawn_IsAsset(APawn* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_APawn_IsEditorOnly(APawn* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_APawn_IsFullNameStableForNetworking(APawn* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_APawn_IsLocalizedResource(APawn* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_APawn_IsPostLoadThreadSafe(APawn* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_APawn_IsSafeForRootSet(APawn* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_APawn_MarkAsEditorOnlySubobject(APawn* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_APawn_NeedsLoadForClient(APawn* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_APawn_NeedsLoadForEditorGame(APawn* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_APawn_NeedsLoadForServer(APawn* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_APawn_NotifyObjectReferenceEliminated(APawn* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_APawn_PostCDOContruct(APawn* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_APawn_PostEditImport(APawn* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_APawn_PostRepNotifies(APawn* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_APawn_PostSaveRoot(APawn* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_APawn_PreDestroyFromReplication(APawn* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_APawn_ShutdownAfterError(APawn* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_APawn_AddToCluster(APawn* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_CanBeClusterRoot(APawn* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_APawn_CreateCluster(APawn* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_APawn_OnClusterMarkedAsPendingKill(APawn* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
