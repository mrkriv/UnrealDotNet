#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/ProjectileMovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

class E_PROTECTED_WRAP_UProjectileMovementComponent : protected UProjectileMovementComponent
{
public:
	FVector ComputeAcceleration_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeAcceleration(InVelocity, DeltaTime);
	}

	FVector ComputeBounceResult_WRAP(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta)
	{
		return ComputeBounceResult(Hit, TimeSlice, MoveDelta);
	}

	FVector ComputeHomingAcceleration_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeHomingAcceleration(InVelocity, DeltaTime);
	}

	FVector ComputeMoveDelta_WRAP(const FVector& InVelocity, float DeltaTime)
	{
		return ComputeMoveDelta(InVelocity, DeltaTime);
	}

	EHandleBlockingHitResult HandleBlockingHit_WRAP(const FHitResult& Hit, float TimeTick, const FVector& MoveDelta, float& SubTickTimeRemaining)
	{
		return HandleBlockingHit(Hit, TimeTick, MoveDelta, SubTickTimeRemaining);
	}

	bool HandleSliding_WRAP(FHitResult& Hit, float& SubTickTimeRemaining)
	{
		return HandleSliding(Hit, SubTickTimeRemaining);
	}

	FVector LimitVelocity_WRAP(FVector NewVelocity)
	{
		return LimitVelocity(NewVelocity);
	}

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UProjectileMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UProjectileMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeAcceleration(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeAcceleration_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeBounceResult(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeBounceResult_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeHomingAcceleration(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeHomingAcceleration_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeMoveDelta(UProjectileMovementComponent* Self, INT_PTR InVelocity, float DeltaTime)
	{
		auto _p0 = *(FVector*)InVelocity;
		auto _p1 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ComputeMoveDelta_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetGravityZ(UProjectileMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleBlockingHit(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta, float SubTickTimeRemaining)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto _p2 = *(FVector*)MoveDelta;
		auto _p3 = SubTickTimeRemaining;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->HandleBlockingHit_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleImpact(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleSliding(UProjectileMovementComponent* Self, INT_PTR Hit, float SubTickTimeRemaining)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = SubTickTimeRemaining;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->HandleSliding_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_LimitVelocity(UProjectileMovementComponent* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->LimitVelocity_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AddRadialForce(UProjectileMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AddRadialImpulse(UProjectileMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ComputeSlideVector(UProjectileMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ConstrainDirectionToPlane(UProjectileMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ConstrainLocationToPlane(UProjectileMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ConstrainNormalToPlane(UProjectileMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_Deactivate(UProjectileMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetMaxSpeed(UProjectileMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetMaxSpeedModifier(UProjectileMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetModifiedMaxSpeed(UProjectileMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetPenetrationAdjustment(UProjectileMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_InitializeComponent(UProjectileMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsExceedingMaxSpeed(UProjectileMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsInWater(UProjectileMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_K2_GetMaxSpeedModifier(UProjectileMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_K2_GetModifiedMaxSpeed(UProjectileMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_MoveUpdatedComponentImpl(UProjectileMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnRegister(UProjectileMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnTeleported(UProjectileMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostLoad(UProjectileMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_RegisterComponentTickFunctions(UProjectileMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ResolvePenetrationImpl(UProjectileMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetPlaneConstraintAxisSetting(UProjectileMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetPlaneConstraintEnabled(UProjectileMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetPlaneConstraintFromVectors(UProjectileMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetPlaneConstraintNormal(UProjectileMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetPlaneConstraintOrigin(UProjectileMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetUpdatedComponent(UProjectileMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldSkipUpdate(UProjectileMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SlideAlongSurface(UProjectileMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SnapUpdatedComponentToPlane(UProjectileMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_StopMovementImmediately(UProjectileMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_TwoWallAdjust(UProjectileMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_UpdateComponentVelocity(UProjectileMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_UpdateTickRegistration(UProjectileMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_Activate(UProjectileMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AddTickPrerequisiteActor(UProjectileMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AddTickPrerequisiteComponent(UProjectileMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ApplyWorldOffset(UProjectileMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_BeginDestroy(UProjectileMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_BeginPlay(UProjectileMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CreateRenderState_Concurrent(UProjectileMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_DestroyComponent(UProjectileMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_DestroyRenderState_Concurrent(UProjectileMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetComponentClassCanReplicate(UProjectileMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetReadableName(UProjectileMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HasValidPhysicsState(UProjectileMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_InvalidateLightingCacheDetailed(UProjectileMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsActive(UProjectileMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsEditorOnly(UProjectileMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsNameStableForNetworking(UProjectileMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsNavigationRelevant(UProjectileMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsReadyForOwnerToAutoDestroy(UProjectileMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsSupportedForNetworking(UProjectileMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_MarkAsEditorOnlySubobject(UProjectileMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_NeedsLoadForClient(UProjectileMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_NeedsLoadForEditorGame(UProjectileMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_NeedsLoadForServer(UProjectileMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnActorEnableCollisionChanged(UProjectileMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnComponentCreated(UProjectileMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnComponentDestroyed(UProjectileMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnCreatePhysicsState(UProjectileMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnDestroyPhysicsState(UProjectileMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnUnregister(UProjectileMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostInitProperties(UProjectileMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostNetReceive(UProjectileMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostRename(UProjectileMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PreNetReceive(UProjectileMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_RemoveTickPrerequisiteActor(UProjectileMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_RemoveTickPrerequisiteComponent(UProjectileMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_RequiresGameThreadEndOfFrameRecreate(UProjectileMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_RequiresGameThreadEndOfFrameUpdates(UProjectileMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SendRenderDynamicData_Concurrent(UProjectileMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SendRenderTransform_Concurrent(UProjectileMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetActive(UProjectileMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetAutoActivate(UProjectileMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetComponentTickEnabled(UProjectileMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_SetComponentTickEnabledAsync(UProjectileMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldActivate(UProjectileMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldCreatePhysicsState(UProjectileMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShouldCreateRenderState(UProjectileMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ToggleActive(UProjectileMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_UninitializeComponent(UProjectileMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_UpdateComponentToWorld(UProjectileMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AreNativePropertiesIdenticalTo(UProjectileMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CheckDefaultSubobjectsInternal(UProjectileMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_FinishDestroy(UProjectileMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetDesc(UProjectileMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_GetDetailedInfoInternal(UProjectileMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsAsset(UProjectileMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsFullNameStableForNetworking(UProjectileMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsLocalizedResource(UProjectileMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsPostLoadThreadSafe(UProjectileMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsReadyForFinishDestroy(UProjectileMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_IsSafeForRootSet(UProjectileMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_Modify(UProjectileMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_NotifyObjectReferenceEliminated(UProjectileMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostCDOContruct(UProjectileMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostEditImport(UProjectileMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostRepNotifies(UProjectileMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PostSaveRoot(UProjectileMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_PreDestroyFromReplication(UProjectileMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_ShutdownAfterError(UProjectileMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_AddToCluster(UProjectileMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CanBeClusterRoot(UProjectileMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CanBeInCluster(UProjectileMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_CreateCluster(UProjectileMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UProjectileMovementComponent_OnClusterMarkedAsPendingKill(UProjectileMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
