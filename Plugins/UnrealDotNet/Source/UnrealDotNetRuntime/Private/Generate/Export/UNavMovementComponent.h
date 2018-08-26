#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/NavMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UNavMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UNavMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverCrouch(UNavMovementComponent* Self)
	{
		return Self->CanEverCrouch();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverFly(UNavMovementComponent* Self)
	{
		return Self->CanEverFly();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverJump(UNavMovementComponent* Self)
	{
		return Self->CanEverJump();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverMoveOnGround(UNavMovementComponent* Self)
	{
		return Self->CanEverMoveOnGround();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanEverSwim(UNavMovementComponent* Self)
	{
		return Self->CanEverSwim();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanStartPathFollowing(UNavMovementComponent* Self)
	{
		return Self->CanStartPathFollowing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_CanStopPathFollowing(UNavMovementComponent* Self)
	{
		return Self->CanStopPathFollowing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ClearFixedBrakingDistance(UNavMovementComponent* Self)
	{
		Self->ClearFixedBrakingDistance();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorFeetLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorFeetLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorFeetLocationBased(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FBasedPosition(Self->GetActorFeetLocationBased());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetActorNavLocation(UNavMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorNavLocation());
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_GetPathFollowingBrakingDistance(UNavMovementComponent* Self, float MaxSpeed)
	{
		auto _p0 = MaxSpeed;
		return Self->GetPathFollowingBrakingDistance(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsCrouching(UNavMovementComponent* Self)
	{
		return Self->IsCrouching();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsFalling(UNavMovementComponent* Self)
	{
		return Self->IsFalling();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsFlying(UNavMovementComponent* Self)
	{
		return Self->IsFlying();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsJumpAllowed(UNavMovementComponent* Self)
	{
		return Self->IsJumpAllowed();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsMovingOnGround(UNavMovementComponent* Self)
	{
		return Self->IsMovingOnGround();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_IsSwimming(UNavMovementComponent* Self)
	{
		return Self->IsSwimming();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequestDirectMove(UNavMovementComponent* Self, INT_PTR MoveVelocity, bool bForceMaxSpeed)
	{
		auto& _p0 = *(FVector*)MoveVelocity;
		auto _p1 = bForceMaxSpeed;
		Self->RequestDirectMove(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_RequestPathMove(UNavMovementComponent* Self, INT_PTR MoveInput)
	{
		auto& _p0 = *(FVector*)MoveInput;
		Self->RequestPathMove(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ResetMoveState(UNavMovementComponent* Self)
	{
		Self->ResetMoveState();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetFixedBrakingDistance(UNavMovementComponent* Self, float DistanceToEndOfPath)
	{
		auto _p0 = DistanceToEndOfPath;
		Self->SetFixedBrakingDistance(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetJumpAllowed(UNavMovementComponent* Self, bool bAllowed)
	{
		auto _p0 = bAllowed;
		Self->SetJumpAllowed(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(UNavMovementComponent* Self, bool bUpdateWithOwner)
	{
		auto _p0 = bUpdateWithOwner;
		Self->SetUpdateNavAgentWithOwnersCollisions(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(UNavMovementComponent* Self)
	{
		return Self->ShouldUpdateNavAgentWithOwnersCollision();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_StopActiveMovement(UNavMovementComponent* Self)
	{
		Self->StopActiveMovement();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_StopMovementKeepPathing(UNavMovementComponent* Self)
	{
		Self->StopMovementKeepPathing();
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UpdateNavAgent(UNavMovementComponent* Self, AActor& InOwner)
	{
		auto& _p0 = InOwner;
		Self->UpdateNavAgent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UpdateNavAgent_o1(UNavMovementComponent* Self, UCapsuleComponent& CapsuleComponent)
	{
		auto& _p0 = CapsuleComponent;
		Self->UpdateNavAgent(_p0);
	}

	DOTNET_EXPORT auto E_UNavMovementComponent_UseAccelerationForPathFollowing(UNavMovementComponent* Self)
	{
		return Self->UseAccelerationForPathFollowing();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
