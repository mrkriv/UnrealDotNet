#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/PawnMovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

class E_PROTECTED_WRAP_UPawnMovementComponent : protected UPawnMovementComponent
{
public:
	bool MoveUpdatedComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, ETeleportType Teleport)
	{
		return MoveUpdatedComponentImpl(Delta, NewRotation, bSweep, OutHit, Teleport);
	}

	bool ResolvePenetrationImpl_WRAP(const FVector& Adjustment, const FHitResult& Hit, const FQuat& NewRotation)
	{
		return ResolvePenetrationImpl(Adjustment, Hit, NewRotation);
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddInputVector(UPawnMovementComponent* Self, INT_PTR WorldVector, bool bForce)
	{
		auto _p0 = *(FVector*)WorldVector;
		auto _p1 = bForce;
		Self->AddInputVector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ConsumeInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetLastInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetLastInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPawnOwner(UPawnMovementComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnOwner());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPendingInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetPendingInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsMoveInputIgnored(UPawnMovementComponent* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_K2_GetInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NotifyBumpedPawn(UPawnMovementComponent* Self, APawn* BumpedPawn)
	{
		auto _p0 = BumpedPawn;
		Self->NotifyBumpedPawn(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RequestPathMove(UPawnMovementComponent* Self, INT_PTR MoveInput)
	{
		auto _p0 = *(FVector*)MoveInput;
		Self->RequestPathMove(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetUpdatedComponent(UPawnMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CanStartPathFollowing(UPawnMovementComponent* Self)
	{
		return Self->CanStartPathFollowing();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CanStopPathFollowing(UPawnMovementComponent* Self)
	{
		return Self->CanStopPathFollowing();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetActorFeetLocationBased(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FBasedPosition(Self->GetActorFeetLocationBased());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPathFollowingBrakingDistance(UPawnMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->GetPathFollowingBrakingDistance(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsCrouching(UPawnMovementComponent* Self)
	{
		return Self->IsCrouching();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsFalling(UPawnMovementComponent* Self)
	{
		return Self->IsFalling();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsFlying(UPawnMovementComponent* Self)
	{
		return Self->IsFlying();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsMovingOnGround(UPawnMovementComponent* Self)
	{
		return Self->IsMovingOnGround();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsSwimming(UPawnMovementComponent* Self)
	{
		return Self->IsSwimming();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RequestDirectMove(UPawnMovementComponent* Self, INT_PTR MoveVelocity, bool bForceMaxSpeed)
	{
		auto _p0 = *(FVector*)MoveVelocity;
		auto _p1 = bForceMaxSpeed;
		Self->RequestDirectMove(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_StopActiveMovement(UPawnMovementComponent* Self)
	{
		Self->StopActiveMovement();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_StopMovementImmediately(UPawnMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddRadialForce(UPawnMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddRadialImpulse(UPawnMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ComputeSlideVector(UPawnMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ConstrainDirectionToPlane(UPawnMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ConstrainLocationToPlane(UPawnMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ConstrainNormalToPlane(UPawnMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_Deactivate(UPawnMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetGravityZ(UPawnMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetMaxSpeed(UPawnMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetMaxSpeedModifier(UPawnMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetModifiedMaxSpeed(UPawnMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPenetrationAdjustment(UPawnMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_HandleImpact(UPawnMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_InitializeComponent(UPawnMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsExceedingMaxSpeed(UPawnMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsInWater(UPawnMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_K2_GetMaxSpeedModifier(UPawnMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_K2_GetModifiedMaxSpeed(UPawnMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_MoveUpdatedComponentImpl(UPawnMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnRegister(UPawnMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnTeleported(UPawnMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostLoad(UPawnMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RegisterComponentTickFunctions(UPawnMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ResolvePenetrationImpl(UPawnMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetPlaneConstraintAxisSetting(UPawnMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetPlaneConstraintEnabled(UPawnMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetPlaneConstraintFromVectors(UPawnMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetPlaneConstraintNormal(UPawnMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetPlaneConstraintOrigin(UPawnMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ShouldSkipUpdate(UPawnMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SlideAlongSurface(UPawnMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SnapUpdatedComponentToPlane(UPawnMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_TwoWallAdjust(UPawnMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_UpdateComponentVelocity(UPawnMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_UpdateTickRegistration(UPawnMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_Activate(UPawnMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddTickPrerequisiteActor(UPawnMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddTickPrerequisiteComponent(UPawnMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ApplyWorldOffset(UPawnMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_BeginDestroy(UPawnMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_BeginPlay(UPawnMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CreateRenderState_Concurrent(UPawnMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_DestroyComponent(UPawnMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_DestroyRenderState_Concurrent(UPawnMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetComponentClassCanReplicate(UPawnMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetReadableName(UPawnMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_HasValidPhysicsState(UPawnMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_InvalidateLightingCacheDetailed(UPawnMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsActive(UPawnMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsEditorOnly(UPawnMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsNameStableForNetworking(UPawnMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsNavigationRelevant(UPawnMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsReadyForOwnerToAutoDestroy(UPawnMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsSupportedForNetworking(UPawnMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_MarkAsEditorOnlySubobject(UPawnMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NeedsLoadForClient(UPawnMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NeedsLoadForEditorGame(UPawnMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NeedsLoadForServer(UPawnMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnActorEnableCollisionChanged(UPawnMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnComponentCreated(UPawnMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnComponentDestroyed(UPawnMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnCreatePhysicsState(UPawnMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnDestroyPhysicsState(UPawnMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnUnregister(UPawnMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostInitProperties(UPawnMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostNetReceive(UPawnMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostRename(UPawnMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PreNetReceive(UPawnMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RemoveTickPrerequisiteActor(UPawnMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RemoveTickPrerequisiteComponent(UPawnMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RequiresGameThreadEndOfFrameRecreate(UPawnMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_RequiresGameThreadEndOfFrameUpdates(UPawnMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SendRenderDynamicData_Concurrent(UPawnMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SendRenderTransform_Concurrent(UPawnMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetActive(UPawnMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetAutoActivate(UPawnMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetComponentTickEnabled(UPawnMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_SetComponentTickEnabledAsync(UPawnMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ShouldActivate(UPawnMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ShouldCreatePhysicsState(UPawnMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ShouldCreateRenderState(UPawnMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ToggleActive(UPawnMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_UninitializeComponent(UPawnMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_UpdateComponentToWorld(UPawnMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AreNativePropertiesIdenticalTo(UPawnMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CheckDefaultSubobjectsInternal(UPawnMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_FinishDestroy(UPawnMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetDesc(UPawnMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetDetailedInfoInternal(UPawnMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsAsset(UPawnMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsFullNameStableForNetworking(UPawnMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsLocalizedResource(UPawnMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsPostLoadThreadSafe(UPawnMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsReadyForFinishDestroy(UPawnMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsSafeForRootSet(UPawnMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_Modify(UPawnMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NotifyObjectReferenceEliminated(UPawnMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostCDOContruct(UPawnMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostEditImport(UPawnMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostRepNotifies(UPawnMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PostSaveRoot(UPawnMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_PreDestroyFromReplication(UPawnMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ShutdownAfterError(UPawnMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddToCluster(UPawnMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CanBeClusterRoot(UPawnMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CanBeInCluster(UPawnMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_CreateCluster(UPawnMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_OnClusterMarkedAsPendingKill(UPawnMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
