#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Pawn.h"

extern "C"
{
	DOTNET_EXPORT void E_APawn_PawnMakeNoise(INT_PTR Self, float Loudness, INT_PTR NoiseLocation, bool bUseNoiseMakerLocation, AActor* NoiseMaker)
	{
		auto _p0 = Loudness;
		auto _p1 = *(FVector*)NoiseLocation;
		auto _p2 = bUseNoiseMakerLocation;
		auto _p3 = NoiseMaker;
		((APawn*)Self)->PawnMakeNoise(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_APawn_TurnOff(INT_PTR Self)
	{
		((APawn*)Self)->TurnOff();
	}

	DOTNET_EXPORT void E_APawn_PawnStartFire(INT_PTR Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((APawn*)Self)->PawnStartFire(_p0);
	}

	DOTNET_EXPORT void E_APawn_SetRemoteViewPitch(INT_PTR Self, float NewRemoteViewPitch)
	{
		auto _p0 = NewRemoteViewPitch;
		((APawn*)Self)->SetRemoteViewPitch(_p0);
	}

	DOTNET_EXPORT AActor* E_APawn_GetMovementBaseActor(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return ((APawn*)Self)->GetMovementBaseActor(_p0);
	}

	DOTNET_EXPORT bool E_APawn_ReachedDesiredRotation(INT_PTR Self)
	{
		return ((APawn*)Self)->ReachedDesiredRotation();
	}

	DOTNET_EXPORT float E_APawn_GetDefaultHalfHeight(INT_PTR Self)
	{
		return ((APawn*)Self)->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT bool E_APawn_IsControlled(INT_PTR Self)
	{
		return ((APawn*)Self)->IsControlled();
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetControlRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((APawn*)Self)->GetControlRotation());
	}

	DOTNET_EXPORT void E_APawn_SetCanAffectNavigationGeneration(INT_PTR Self, bool bNewValue, bool bForceUpdate)
	{
		auto _p0 = bNewValue;
		auto _p1 = bForceUpdate;
		((APawn*)Self)->SetCanAffectNavigationGeneration(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetGravityDirection(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->GetGravityDirection());
	}

	DOTNET_EXPORT void E_APawn_FaceRotation(INT_PTR Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		((APawn*)Self)->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT void E_APawn_AddMovementInput(INT_PTR Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		((APawn*)Self)->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_APawn_Internal_AddMovementInput(INT_PTR Self, INT_PTR WorldAccel, bool bForce)
	{
		auto _p0 = *(FVector*)WorldAccel;
		auto _p1 = bForce;
		((APawn*)Self)->Internal_AddMovementInput(_p0, _p1);
	}

	DOTNET_EXPORT void E_APawn_MoveIgnoreActorAdd(INT_PTR Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		((APawn*)Self)->MoveIgnoreActorAdd(_p0);
	}

	DOTNET_EXPORT void E_APawn_ClientSetRotation(INT_PTR Self, INT_PTR NewRotation)
	{
		auto _p0 = *(FRotator*)NewRotation;
		((APawn*)Self)->ClientSetRotation(_p0);
	}

	DOTNET_EXPORT void E_APawn_LaunchPawn(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((APawn*)Self)->LaunchPawn(_p0, _p1, _p2);
	}

}
