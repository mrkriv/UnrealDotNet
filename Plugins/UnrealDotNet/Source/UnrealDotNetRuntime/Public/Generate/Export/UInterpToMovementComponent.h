#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/InterpToMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:61

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

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_BehaviourType_GET(UInterpToMovementComponent* Ptr) { return Ptr->BehaviourType; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_BehaviourType_SET(UInterpToMovementComponent* Ptr, EInterpToBehaviourType Value) { Ptr->BehaviourType = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_Duration_GET(UInterpToMovementComponent* Ptr) { return Ptr->Duration; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_Duration_SET(UInterpToMovementComponent* Ptr, float Value) { Ptr->Duration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_MaxSimulationIterations_GET(UInterpToMovementComponent* Ptr) { return Ptr->MaxSimulationIterations; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_MaxSimulationIterations_SET(UInterpToMovementComponent* Ptr, int32 Value) { Ptr->MaxSimulationIterations = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_GET(UInterpToMovementComponent* Ptr) { return Ptr->MaxSimulationTimeStep; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_SET(UInterpToMovementComponent* Ptr, float Value) { Ptr->MaxSimulationTimeStep = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInterpToMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInterpToMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddControlPointPosition(UInterpToMovementComponent* Self, INT_PTR Pos, bool bPositionIsRelative)
	{
		auto _p0 = *(FVector*)Pos;
		auto _p1 = bPositionIsRelative;
		Self->UInterpToMovementComponent::AddControlPointPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CalculateNewTime(UInterpToMovementComponent* Self, float TimeNow, float Delta, INT_PTR HitResult, bool InBroadcastEvent, bool OutStopped, float OutTimeRemainder)
	{
		auto _p0 = TimeNow;
		auto _p1 = Delta;
		auto& _p2 = *(FHitResult*)HitResult;
		auto _p3 = InBroadcastEvent;
		auto& _p4 = OutStopped;
		auto& _p5 = OutTimeRemainder;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->CalculateNewTime_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CheckStillInWorld(UInterpToMovementComponent* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ComputeMoveDelta(UInterpToMovementComponent* Self, float Time)
	{
		auto _p0 = Time;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ComputeMoveDelta_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_FinaliseControlPoints(UInterpToMovementComponent* Self)
	{
		Self->FinaliseControlPoints();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetSimulationTimeStep(UInterpToMovementComponent* Self, float RemainingTime, int32 Iterations)
	{
		auto _p0 = RemainingTime;
		auto _p1 = Iterations;
		return Self->GetSimulationTimeStep(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HandleHitWall(UInterpToMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto& _p2 = *(FVector*)MoveDelta;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->HandleHitWall_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HasStoppedSimulation(UInterpToMovementComponent* Self)
	{
		return Self->HasStoppedSimulation();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ResetControlPoints(UInterpToMovementComponent* Self)
	{
		Self->ResetControlPoints();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RestartMovement(UInterpToMovementComponent* Self, float InitialDirection)
	{
		auto _p0 = InitialDirection;
		Self->RestartMovement(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ReverseDirection(UInterpToMovementComponent* Self, INT_PTR Hit, float Time, bool InBroadcastEvent)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = Time;
		auto _p2 = InBroadcastEvent;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ReverseDirection_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldUseSubStepping(UInterpToMovementComponent* Self)
	{
		return Self->ShouldUseSubStepping();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_StopSimulating(UInterpToMovementComponent* Self, INT_PTR HitResult)
	{
		auto& _p0 = *(FHitResult*)HitResult;
		Self->StopSimulating(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateControlPoints(UInterpToMovementComponent* Self, bool InForceUpdate)
	{
		auto _p0 = InForceUpdate;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->UInterpToMovementComponent::UpdateControlPoints_WRAP(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
