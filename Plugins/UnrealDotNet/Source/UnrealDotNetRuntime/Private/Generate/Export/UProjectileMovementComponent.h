#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/ProjectileMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

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

};


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

	DOTNET_EXPORT auto E_UProjectileMovementComponent_HandleBlockingHit(UProjectileMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta, float SubTickTimeRemaining)
	{
		auto _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto _p2 = *(FVector*)MoveDelta;
		auto _p3 = SubTickTimeRemaining;
		return ((E_PROTECTED_WRAP_UProjectileMovementComponent*)Self)->HandleBlockingHit_WRAP(_p0, _p1, _p2, _p3);
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
