#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"

extern "C"
{
	DOTNET_EXPORT void E_ACharacter_CacheInitialMeshOffset(INT_PTR Self, INT_PTR MeshRelativeLocation, INT_PTR MeshRelativeRotation)
	{
		auto _p0 = *(FVector*)MeshRelativeLocation;
		auto _p1 = *(FRotator*)MeshRelativeRotation;
		((ACharacter*)Self)->CacheInitialMeshOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_ReplicatedBasedMovement(INT_PTR Self)
	{
		((ACharacter*)Self)->OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT void E_ACharacter_SaveRelativeBasedMovement(INT_PTR Self, INT_PTR NewRelativeLocation, INT_PTR NewRotation, bool bRelativeRotation)
	{
		auto _p0 = *(FVector*)NewRelativeLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		((ACharacter*)Self)->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT uint8 E_ACharacter_GetReplicatedMovementMode(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseTranslationOffset(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((ACharacter*)Self)->GetBaseTranslationOffset());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffset(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((ACharacter*)Self)->GetBaseRotationOffset());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffsetRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((ACharacter*)Self)->GetBaseRotationOffsetRotator());
	}

	DOTNET_EXPORT bool E_ACharacter_CanJump(INT_PTR Self)
	{
		return ((ACharacter*)Self)->CanJump();
	}

	DOTNET_EXPORT void E_ACharacter_LaunchCharacter(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((ACharacter*)Self)->LaunchCharacter(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_OnWalkingOffLedge(INT_PTR Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto _p1 = *(FVector*)PreviousFloorContactNormal;
		auto _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		((ACharacter*)Self)->OnWalkingOffLedge(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_ACharacter_CanCrouch(INT_PTR Self)
	{
		return ((ACharacter*)Self)->CanCrouch();
	}

	DOTNET_EXPORT void E_ACharacter_OnEndCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_UpdateCustomMovement(INT_PTR Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((ACharacter*)Self)->K2_UpdateCustomMovement(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateFromCompressedFlags(INT_PTR Self, uint8 Flags)
	{
		auto _p0 = Flags;
		((ACharacter*)Self)->UpdateFromCompressedFlags(_p0);
	}

	DOTNET_EXPORT bool E_ACharacter_RestoreReplicatedMove(INT_PTR Self, INT_PTR RootMotionRepMove)
	{
		auto _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
		return ((ACharacter*)Self)->RestoreReplicatedMove(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateSimulatedPosition(INT_PTR Self, INT_PTR Location, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)NewRotation;
		((ACharacter*)Self)->UpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnUpdateSimulatedPosition(INT_PTR Self, INT_PTR OldLocation, INT_PTR OldRotation)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FQuat*)OldRotation;
		((ACharacter*)Self)->OnUpdateSimulatedPosition(_p0, _p1);
	}

}
