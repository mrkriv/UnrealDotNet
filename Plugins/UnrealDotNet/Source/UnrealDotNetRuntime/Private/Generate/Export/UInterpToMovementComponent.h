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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
