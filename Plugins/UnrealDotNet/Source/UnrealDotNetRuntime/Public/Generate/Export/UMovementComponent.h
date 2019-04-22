#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/MovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

class E_PROTECTED_WRAP_UMovementComponent : protected UMovementComponent
{
public:
	FVector GetPlaneConstraintNormalFromAxisSetting_WRAP(EPlaneConstraintAxisSetting AxisSetting)
	{
		return GetPlaneConstraintNormalFromAxisSetting(AxisSetting);
	}

	bool MoveUpdatedComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, ETeleportType Teleport)
	{
		return MoveUpdatedComponentImpl(Delta, NewRotation, bSweep, OutHit, Teleport);
	}

	bool ResolvePenetrationImpl_WRAP(const FVector& Adjustment, const FHitResult& Hit, const FQuat& NewRotation)
	{
		return ResolvePenetrationImpl(Adjustment, Hit, NewRotation);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_GET(UMovementComponent* Ptr) { return Ptr->bAutoRegisterPhysicsVolumeUpdates; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bAutoRegisterPhysicsVolumeUpdates_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bAutoRegisterPhysicsVolumeUpdates = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_GET(UMovementComponent* Ptr) { return Ptr->bAutoRegisterUpdatedComponent; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bAutoRegisterUpdatedComponent_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bAutoRegisterUpdatedComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bAutoUpdateTickRegistration_GET(UMovementComponent* Ptr) { return Ptr->bAutoUpdateTickRegistration; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bAutoUpdateTickRegistration_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bAutoUpdateTickRegistration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_GET(UMovementComponent* Ptr) { return Ptr->bComponentShouldUpdatePhysicsVolume; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bComponentShouldUpdatePhysicsVolume_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bComponentShouldUpdatePhysicsVolume = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bConstrainToPlane_GET(UMovementComponent* Ptr) { return Ptr->bConstrainToPlane; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bConstrainToPlane_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bConstrainToPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bSnapToPlaneAtStart_GET(UMovementComponent* Ptr) { return Ptr->bSnapToPlaneAtStart; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bSnapToPlaneAtStart_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bSnapToPlaneAtStart = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bTickBeforeOwner_GET(UMovementComponent* Ptr) { return Ptr->bTickBeforeOwner; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bTickBeforeOwner_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bTickBeforeOwner = Value; }
	
	DOTNET_EXPORT auto E_PROP_UMovementComponent_bUpdateOnlyIfRendered_GET(UMovementComponent* Ptr) { return Ptr->bUpdateOnlyIfRendered; }
	DOTNET_EXPORT void E_PROP_UMovementComponent_bUpdateOnlyIfRendered_SET(UMovementComponent* Ptr, uint8 Value) { Ptr->bUpdateOnlyIfRendered = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddRadialForce(UMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
	{
		auto& _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		Self->AddRadialForce(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UMovementComponent_AddRadialImpulse(UMovementComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto& _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ComputeSlideVector(UMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit)
	{
		auto& _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto& _p2 = *(FVector*)Normal;
		auto& _p3 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->ComputeSlideVector(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainDirectionToPlane(UMovementComponent* Self, INT_PTR Direction)
	{
		auto _p0 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->ConstrainDirectionToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainLocationToPlane(UMovementComponent* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->ConstrainLocationToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_ConstrainNormalToPlane(UMovementComponent* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ConstrainNormalToPlane(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetGravityZ(UMovementComponent* Self)
	{
		return Self->GetGravityZ();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetMaxSpeed(UMovementComponent* Self)
	{
		return Self->GetMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetMaxSpeedModifier(UMovementComponent* Self)
	{
		return Self->GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetModifiedMaxSpeed(UMovementComponent* Self)
	{
		return Self->GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPenetrationAdjustment(UMovementComponent* Self, INT_PTR Hit)
	{
		auto& _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FVector(Self->GetPenetrationAdjustment(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintAxisSetting(UMovementComponent* Self)
	{
		return Self->GetPlaneConstraintAxisSetting();
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintNormal(UMovementComponent* Self)
	{
		return (INT_PTR) const_cast<FVector*>(&(Self->GetPlaneConstraintNormal()));
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintNormalFromAxisSetting(UMovementComponent* Self, EPlaneConstraintAxisSetting AxisSetting)
	{
		auto _p0 = AxisSetting;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UMovementComponent*)Self)->GetPlaneConstraintNormalFromAxisSetting_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UMovementComponent_GetPlaneConstraintOrigin(UMovementComponent* Self)
	{
		return (INT_PTR) const_cast<FVector*>(&(Self->GetPlaneConstraintOrigin()));
	}

	DOTNET_EXPORT auto E_UMovementComponent_HandleImpact(UMovementComponent* Self, INT_PTR Hit, float TimeSlice, INT_PTR MoveDelta)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeSlice;
		auto& _p2 = *(FVector*)MoveDelta;
		Self->HandleImpact(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsExceedingMaxSpeed(UMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->IsExceedingMaxSpeed(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_IsInWater(UMovementComponent* Self)
	{
		return Self->IsInWater();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_GetMaxSpeedModifier(UMovementComponent* Self)
	{
		return Self->K2_GetMaxSpeedModifier();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_GetModifiedMaxSpeed(UMovementComponent* Self)
	{
		return Self->K2_GetModifiedMaxSpeed();
	}

	DOTNET_EXPORT auto E_UMovementComponent_K2_MoveUpdatedComponent(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, INT_PTR OutHit, bool bSweep, bool bTeleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FRotator*)NewRotation;
		auto& _p2 = *(FHitResult*)OutHit;
		auto _p3 = bSweep;
		auto _p4 = bTeleport;
		return Self->K2_MoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_MoveUpdatedComponent(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return Self->MoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_MoveUpdatedComponent_o1(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FRotator*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return Self->MoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_MoveUpdatedComponentImpl(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = Teleport;
		return ((E_PROTECTED_WRAP_UMovementComponent*)Self)->MoveUpdatedComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_OnTeleported(UMovementComponent* Self)
	{
		Self->OnTeleported();
	}

	DOTNET_EXPORT auto E_UMovementComponent_ResolvePenetration(UMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)Adjustment;
		auto& _p1 = *(FHitResult*)Hit;
		auto& _p2 = *(FQuat*)NewRotation;
		return Self->ResolvePenetration(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ResolvePenetration_o1(UMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)Adjustment;
		auto& _p1 = *(FHitResult*)Hit;
		auto& _p2 = *(FRotator*)NewRotation;
		return Self->ResolvePenetration(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ResolvePenetrationImpl(UMovementComponent* Self, INT_PTR Adjustment, INT_PTR Hit, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)Adjustment;
		auto& _p1 = *(FHitResult*)Hit;
		auto& _p2 = *(FQuat*)NewRotation;
		return ((E_PROTECTED_WRAP_UMovementComponent*)Self)->ResolvePenetrationImpl_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SafeMoveUpdatedComponent(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto& _p3 = *(FHitResult*)OutHit;
		auto _p4 = Teleport;
		return Self->SafeMoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SafeMoveUpdatedComponent_o1(UMovementComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, ETeleportType Teleport)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FRotator*)NewRotation;
		auto _p2 = bSweep;
		auto& _p3 = *(FHitResult*)OutHit;
		auto _p4 = Teleport;
		return Self->SafeMoveUpdatedComponent(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintAxisSetting(UMovementComponent* Self, EPlaneConstraintAxisSetting NewAxisSetting)
	{
		auto _p0 = NewAxisSetting;
		Self->SetPlaneConstraintAxisSetting(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintFromVectors(UMovementComponent* Self, INT_PTR Forward, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Up;
		Self->SetPlaneConstraintFromVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintNormal(UMovementComponent* Self, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)PlaneNormal;
		Self->SetPlaneConstraintNormal(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetPlaneConstraintOrigin(UMovementComponent* Self, INT_PTR PlaneOrigin)
	{
		auto _p0 = *(FVector*)PlaneOrigin;
		Self->SetPlaneConstraintOrigin(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SetUpdatedComponent(UMovementComponent* Self, USceneComponent* NewUpdatedComponent)
	{
		auto _p0 = NewUpdatedComponent;
		Self->SetUpdatedComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_ShouldSkipUpdate(UMovementComponent* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		return Self->ShouldSkipUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SlideAlongSurface(UMovementComponent* Self, INT_PTR Delta, float Time, INT_PTR Normal, INT_PTR Hit, bool bHandleImpact)
	{
		auto& _p0 = *(FVector*)Delta;
		auto _p1 = Time;
		auto& _p2 = *(FVector*)Normal;
		auto& _p3 = *(FHitResult*)Hit;
		auto _p4 = bHandleImpact;
		return Self->SlideAlongSurface(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMovementComponent_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		Self->SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E_UMovementComponent_StopMovementImmediately(UMovementComponent* Self)
	{
		Self->StopMovementImmediately();
	}

	DOTNET_EXPORT auto E_UMovementComponent_TwoWallAdjust(UMovementComponent* Self, INT_PTR Delta, INT_PTR Hit, INT_PTR OldHitNormal)
	{
		auto& _p0 = *(FVector*)Delta;
		auto& _p1 = *(FHitResult*)Hit;
		auto& _p2 = *(FVector*)OldHitNormal;
		Self->TwoWallAdjust(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMovementComponent_UpdateComponentVelocity(UMovementComponent* Self)
	{
		Self->UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E_UMovementComponent_UpdateTickRegistration(UMovementComponent* Self)
	{
		Self->UpdateTickRegistration();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
