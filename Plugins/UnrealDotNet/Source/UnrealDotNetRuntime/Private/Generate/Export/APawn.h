#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/Pawn.h"

class E_PROTECTED_WRAP_APawn : protected APawn
{
public:
	void DestroyPlayerInputComponent_WRAP()
	{
		DestroyPlayerInputComponent();
	}

}
;

extern "C"
{
	DOTNET_EXPORT float E_PROP_APawn_AllowedYawError_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->AllowedYawError; }
	DOTNET_EXPORT void E_PROP_APawn_AllowedYawError_SET(INT_PTR Ptr, float Value) { ((APawn*)Ptr)->AllowedYawError = Value; }
	
	DOTNET_EXPORT float E_PROP_APawn_BaseEyeHeight_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->BaseEyeHeight; }
	DOTNET_EXPORT void E_PROP_APawn_BaseEyeHeight_SET(INT_PTR Ptr, float Value) { ((APawn*)Ptr)->BaseEyeHeight = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_APawn_RemoteViewPitch_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->RemoteViewPitch; }
	DOTNET_EXPORT void E_PROP_APawn_RemoteViewPitch_SET(INT_PTR Ptr, uint8 Value) { ((APawn*)Ptr)->RemoteViewPitch = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_APawn_AddControllerPitchInput(INT_PTR Self, float Val)
	{
		auto _p0 = Val;
		((APawn*)Self)->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddControllerRollInput(INT_PTR Self, float Val)
	{
		auto _p0 = Val;
		((APawn*)Self)->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddControllerYawInput(INT_PTR Self, float Val)
	{
		auto _p0 = Val;
		((APawn*)Self)->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddMovementInput(INT_PTR Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		((APawn*)Self)->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_APawn_ClientSetRotation(INT_PTR Self, INT_PTR NewRotation)
	{
		auto _p0 = *(FRotator*)NewRotation;
		((APawn*)Self)->ClientSetRotation(_p0);
	}

	DOTNET_EXPORT void E_APawn_DestroyPlayerInputComponent(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_APawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT void E_APawn_DetachFromControllerPendingDestroy(INT_PTR Self)
	{
		((APawn*)Self)->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT void E_APawn_FaceRotation(INT_PTR Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		((APawn*)Self)->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetControlRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((APawn*)Self)->GetControlRotation());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetGravityDirection(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->GetGravityDirection());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetLastMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->GetLastMovementInputVector());
	}

	DOTNET_EXPORT AActor* E_APawn_GetMovementBaseActor(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return ((APawn*)Self)->GetMovementBaseActor(_p0);
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->GetMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetPendingMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->GetPendingMovementInputVector());
	}

	DOTNET_EXPORT bool E_APawn_InputEnabled(INT_PTR Self)
	{
		return ((APawn*)Self)->InputEnabled();
	}

	DOTNET_EXPORT void E_APawn_Internal_AddMovementInput(INT_PTR Self, INT_PTR WorldAccel, bool bForce)
	{
		auto _p0 = *(FVector*)WorldAccel;
		auto _p1 = bForce;
		((APawn*)Self)->Internal_AddMovementInput(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_ConsumeMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->Internal_ConsumeMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetLastMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->Internal_GetLastMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->Internal_GetMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetPendingMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->Internal_GetPendingMovementInputVector());
	}

	DOTNET_EXPORT bool E_APawn_IsControlled(INT_PTR Self)
	{
		return ((APawn*)Self)->IsControlled();
	}

	DOTNET_EXPORT INT_PTR E_APawn_K2_GetMovementInputVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((APawn*)Self)->K2_GetMovementInputVector());
	}

	DOTNET_EXPORT void E_APawn_LaunchPawn(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((APawn*)Self)->LaunchPawn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_APawn_MoveIgnoreActorAdd(INT_PTR Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		((APawn*)Self)->MoveIgnoreActorAdd(_p0);
	}

	DOTNET_EXPORT void E_APawn_MoveIgnoreActorRemove(INT_PTR Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		((APawn*)Self)->MoveIgnoreActorRemove(_p0);
	}

	DOTNET_EXPORT void E_APawn_OnRep_Controller(INT_PTR Self)
	{
		((APawn*)Self)->OnRep_Controller();
	}

	DOTNET_EXPORT void E_APawn_OnRep_PlayerState(INT_PTR Self)
	{
		((APawn*)Self)->OnRep_PlayerState();
	}

	DOTNET_EXPORT void E_APawn_PawnClientRestart(INT_PTR Self)
	{
		((APawn*)Self)->PawnClientRestart();
	}

	DOTNET_EXPORT void E_APawn_PawnMakeNoise(INT_PTR Self, float Loudness, INT_PTR NoiseLocation, bool bUseNoiseMakerLocation, AActor* NoiseMaker)
	{
		auto _p0 = Loudness;
		auto _p1 = *(FVector*)NoiseLocation;
		auto _p2 = bUseNoiseMakerLocation;
		auto _p3 = NoiseMaker;
		((APawn*)Self)->PawnMakeNoise(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_APawn_PawnStartFire(INT_PTR Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((APawn*)Self)->PawnStartFire(_p0);
	}

	DOTNET_EXPORT void E_APawn_RecalculateBaseEyeHeight(INT_PTR Self)
	{
		((APawn*)Self)->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT void E_APawn_Restart(INT_PTR Self)
	{
		((APawn*)Self)->Restart();
	}

	DOTNET_EXPORT void E_APawn_SetCanAffectNavigationGeneration(INT_PTR Self, bool bNewValue, bool bForceUpdate)
	{
		auto _p0 = bNewValue;
		auto _p1 = bForceUpdate;
		((APawn*)Self)->SetCanAffectNavigationGeneration(_p0, _p1);
	}

	DOTNET_EXPORT void E_APawn_SetPlayerDefaults(INT_PTR Self)
	{
		((APawn*)Self)->SetPlayerDefaults();
	}

	DOTNET_EXPORT void E_APawn_SetRemoteViewPitch(INT_PTR Self, float NewRemoteViewPitch)
	{
		auto _p0 = NewRemoteViewPitch;
		((APawn*)Self)->SetRemoteViewPitch(_p0);
	}

	DOTNET_EXPORT void E_APawn_SpawnDefaultController(INT_PTR Self)
	{
		((APawn*)Self)->SpawnDefaultController();
	}

	DOTNET_EXPORT void E_APawn_TurnOff(INT_PTR Self)
	{
		((APawn*)Self)->TurnOff();
	}

	DOTNET_EXPORT void E_APawn_UnPossessed(INT_PTR Self)
	{
		((APawn*)Self)->UnPossessed();
	}

	DOTNET_EXPORT void E_APawn_UpdateNavAgent(INT_PTR Self)
	{
		((APawn*)Self)->UpdateNavAgent();
	}

	DOTNET_EXPORT void E_APawn_UpdateNavigationRelevance(INT_PTR Self)
	{
		((APawn*)Self)->UpdateNavigationRelevance();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
