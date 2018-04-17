#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/InterpToMovementComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

class E_PROTECTED_WRAP_UInterpToMovementComponent : protected UInterpToMovementComponent
{
public:
	float CalculateNewTime_WRAP(float TimeNow, float Delta, FHitResult& HitResult, bool InBroadcastEvent, bool& OutStopped, float& OutTimeRemainder)
	{
		return CalculateNewTime(TimeNow, Delta, HitResult, InBroadcastEvent, OutStopped, OutTimeRemainder);
	}

	FVector ComputeMoveDelta_WRAP(float Time)
	{
		return ComputeMoveDelta(Time);
	}

	bool HandleHitWall_WRAP(const FHitResult& Hit, float TimeTick, const FVector& MoveDelta)
	{
		return HandleHitWall(Hit, TimeTick, MoveDelta);
	}

	void ReverseDirection_WRAP(const FHitResult& Hit, float Time, bool InBroadcastEvent)
	{
		ReverseDirection(Hit, Time, InBroadcastEvent);
	}

	void UpdateControlPoints_WRAP(bool InForceUpdate)
	{
		UpdateControlPoints(InForceUpdate);
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInterpToMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInterpToMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CalculateNewTime(UInterpToMovementComponent* Self, float TimeNow, float Delta, INT_PTR HitResult, bool InBroadcastEvent, bool OutStopped, float OutTimeRemainder)
	{
		auto _p0 = TimeNow;
		auto _p1 = Delta;
		auto _p2 = *(FHitResult*)HitResult;
		auto _p3 = InBroadcastEvent;
		auto _p4 = OutStopped;
		auto _p5 = OutTimeRemainder;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->CalculateNewTime_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ComputeMoveDelta(UInterpToMovementComponent* Self, float Time)
	{
		auto _p0 = Time;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ComputeMoveDelta_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HandleHitWall(UInterpToMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto _p2 = *(FVector*)MoveDelta;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->HandleHitWall_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HandleImpact(UInterpToMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ReverseDirection(UInterpToMovementComponent* Self, INT_PTR Hit, float Time, bool InBroadcastEvent)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = Time;
		auto _p2 = InBroadcastEvent;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ReverseDirection_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateControlPoints(UInterpToMovementComponent* Self, bool InForceUpdate)
	{
		auto _p0 = InForceUpdate;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->UpdateControlPoints_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddRadialForce(UInterpToMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddRadialImpulse(UInterpToMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ComputeSlideVector(UInterpToMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ConstrainDirectionToPlane(UInterpToMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ConstrainLocationToPlane(UInterpToMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ConstrainNormalToPlane(UInterpToMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_Deactivate(UInterpToMovementComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetGravityZ(UInterpToMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetMaxSpeed(UInterpToMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetMaxSpeedModifier(UInterpToMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetModifiedMaxSpeed(UInterpToMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetPenetrationAdjustment(UInterpToMovementComponent* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_InitializeComponent(UInterpToMovementComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsExceedingMaxSpeed(UInterpToMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsInWater(UInterpToMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_K2_GetMaxSpeedModifier(UInterpToMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_K2_GetModifiedMaxSpeed(UInterpToMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_MoveUpdatedComponentImpl(UInterpToMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnRegister(UInterpToMovementComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnTeleported(UInterpToMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostLoad(UInterpToMovementComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RegisterComponentTickFunctions(UInterpToMovementComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ResolvePenetrationImpl(UInterpToMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Adjustment;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetPlaneConstraintAxisSetting(UInterpToMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetPlaneConstraintEnabled(UInterpToMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetPlaneConstraintFromVectors(UInterpToMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetPlaneConstraintNormal(UInterpToMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetPlaneConstraintOrigin(UInterpToMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetUpdatedComponent(UInterpToMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldSkipUpdate(UInterpToMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SlideAlongSurface(UInterpToMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto _p2 = *(FVector*)Normal;
		auto _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SnapUpdatedComponentToPlane(UInterpToMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_StopMovementImmediately(UInterpToMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_TwoWallAdjust(UInterpToMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FHitResult*)Hit;
		auto _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateComponentVelocity(UInterpToMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateTickRegistration(UInterpToMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_Activate(UInterpToMovementComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddTickPrerequisiteActor(UInterpToMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddTickPrerequisiteComponent(UInterpToMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ApplyWorldOffset(UInterpToMovementComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_BeginDestroy(UInterpToMovementComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_BeginPlay(UInterpToMovementComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CreateRenderState_Concurrent(UInterpToMovementComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_DestroyComponent(UInterpToMovementComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_DestroyRenderState_Concurrent(UInterpToMovementComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetComponentClassCanReplicate(UInterpToMovementComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetReadableName(UInterpToMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HasValidPhysicsState(UInterpToMovementComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_InvalidateLightingCacheDetailed(UInterpToMovementComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsActive(UInterpToMovementComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsEditorOnly(UInterpToMovementComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsNameStableForNetworking(UInterpToMovementComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsNavigationRelevant(UInterpToMovementComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsReadyForOwnerToAutoDestroy(UInterpToMovementComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsSupportedForNetworking(UInterpToMovementComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_MarkAsEditorOnlySubobject(UInterpToMovementComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_NeedsLoadForClient(UInterpToMovementComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_NeedsLoadForEditorGame(UInterpToMovementComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_NeedsLoadForServer(UInterpToMovementComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnActorEnableCollisionChanged(UInterpToMovementComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnComponentCreated(UInterpToMovementComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnComponentDestroyed(UInterpToMovementComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnCreatePhysicsState(UInterpToMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnDestroyPhysicsState(UInterpToMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnUnregister(UInterpToMovementComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostInitProperties(UInterpToMovementComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostNetReceive(UInterpToMovementComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostRename(UInterpToMovementComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PreNetReceive(UInterpToMovementComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RemoveTickPrerequisiteActor(UInterpToMovementComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RemoveTickPrerequisiteComponent(UInterpToMovementComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RequiresGameThreadEndOfFrameRecreate(UInterpToMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RequiresGameThreadEndOfFrameUpdates(UInterpToMovementComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SendRenderDynamicData_Concurrent(UInterpToMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SendRenderTransform_Concurrent(UInterpToMovementComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetActive(UInterpToMovementComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetAutoActivate(UInterpToMovementComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetComponentTickEnabled(UInterpToMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_SetComponentTickEnabledAsync(UInterpToMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldActivate(UInterpToMovementComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldCreatePhysicsState(UInterpToMovementComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldCreateRenderState(UInterpToMovementComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ToggleActive(UInterpToMovementComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UninitializeComponent(UInterpToMovementComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateComponentToWorld(UInterpToMovementComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AreNativePropertiesIdenticalTo(UInterpToMovementComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CheckDefaultSubobjectsInternal(UInterpToMovementComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_FinishDestroy(UInterpToMovementComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetDesc(UInterpToMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetDetailedInfoInternal(UInterpToMovementComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsAsset(UInterpToMovementComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsFullNameStableForNetworking(UInterpToMovementComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsLocalizedResource(UInterpToMovementComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsPostLoadThreadSafe(UInterpToMovementComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsReadyForFinishDestroy(UInterpToMovementComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_IsSafeForRootSet(UInterpToMovementComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_Modify(UInterpToMovementComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_NotifyObjectReferenceEliminated(UInterpToMovementComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostCDOContruct(UInterpToMovementComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostEditImport(UInterpToMovementComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostRepNotifies(UInterpToMovementComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PostSaveRoot(UInterpToMovementComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_PreDestroyFromReplication(UInterpToMovementComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShutdownAfterError(UInterpToMovementComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddToCluster(UInterpToMovementComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CanBeClusterRoot(UInterpToMovementComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CanBeInCluster(UInterpToMovementComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CreateCluster(UInterpToMovementComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_OnClusterMarkedAsPendingKill(UInterpToMovementComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
