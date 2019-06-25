#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/Controller.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Controller.h:40

class E_PROTECTED_WRAP_AController : protected AController
{
public:
	void AddPawnTickDependency_WRAP(APawn* NewPawn)
	{
		AddPawnTickDependency(NewPawn);
	}

	void AttachToPawn_WRAP(APawn* InPawn)
	{
		AttachToPawn(InPawn);
	}

	void BeginInactiveState_WRAP()
	{
		BeginInactiveState();
	}

	void DetachFromPawn_WRAP()
	{
		DetachFromPawn();
	}

	void EndInactiveState_WRAP()
	{
		EndInactiveState();
	}

	USceneComponent* GetTransformComponent_WRAP()
	{
		return GetTransformComponent();
	}

	void OnPossess_WRAP(APawn* InPawn)
	{
		OnPossess(InPawn);
	}

	void OnUnPossess_WRAP()
	{
		OnUnPossess();
	}

	void ReceivePossess_WRAP(APawn* PossessedPawn)
	{
		ReceivePossess(PossessedPawn);
	}

	void ReceiveUnPossess_WRAP(APawn* UnpossessedPawn)
	{
		ReceiveUnPossess(UnpossessedPawn);
	}

	void RemovePawnTickDependency_WRAP(APawn* InOldPawn)
	{
		RemovePawnTickDependency(InOldPawn);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AController_PlayerState_GET(AController* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PlayerState); }
	DOTNET_EXPORT void E_PROP_AController_PlayerState_SET(AController* Ptr, APlayerState* Value) { Ptr->PlayerState = Value; }
	
	DOTNET_EXPORT auto E_PROP_AController_StateName_GET(AController* Ptr) { return ConvertToManage_StringWrapper(Ptr->StateName); }
	DOTNET_EXPORT void E_PROP_AController_StateName_SET(AController* Ptr, char* Value) { Ptr->StateName = ConvertFromManage_FName(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AController(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AController>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AController_AddPawnTickDependency(AController* Self, APawn* NewPawn)
	{
		auto _p0 = NewPawn;
		((E_PROTECTED_WRAP_AController*)Self)->AddPawnTickDependency_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_AttachToPawn(AController* Self, APawn* InPawn)
	{
		auto _p0 = InPawn;
		((E_PROTECTED_WRAP_AController*)Self)->AttachToPawn_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_BeginInactiveState(AController* Self)
	{
		((E_PROTECTED_WRAP_AController*)Self)->BeginInactiveState_WRAP();
	}

	DOTNET_EXPORT auto E_AController_CastToPlayerController(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->CastToPlayerController());
	}

	DOTNET_EXPORT auto E_AController_ChangeState(AController* Self, char* NewState)
	{
		auto _p0 = ConvertFromManage_FName(NewState);
		Self->ChangeState(_p0);
	}

	DOTNET_EXPORT auto E_AController_CleanupPlayerState(AController* Self)
	{
		Self->CleanupPlayerState();
	}

	DOTNET_EXPORT auto E_AController_ClientSetLocation(AController* Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		Self->ClientSetLocation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AController_ClientSetRotation(AController* Self, INT_PTR NewRotation, bool bResetCamera)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bResetCamera;
		Self->ClientSetRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AController_CurrentLevelUnloaded(AController* Self)
	{
		Self->CurrentLevelUnloaded();
	}

	DOTNET_EXPORT auto E_AController_DetachFromPawn(AController* Self)
	{
		((E_PROTECTED_WRAP_AController*)Self)->DetachFromPawn_WRAP();
	}

	DOTNET_EXPORT auto E_AController_EndInactiveState(AController* Self)
	{
		((E_PROTECTED_WRAP_AController*)Self)->EndInactiveState_WRAP();
	}

	DOTNET_EXPORT auto E_AController_FailedToSpawnPawn(AController* Self)
	{
		Self->FailedToSpawnPawn();
	}

	DOTNET_EXPORT auto E_AController_GameHasEnded(AController* Self, AActor* EndGameFocus, bool bIsWinner)
	{
		auto _p0 = EndGameFocus;
		auto _p1 = bIsWinner;
		Self->GameHasEnded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AController_GetCharacter(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCharacter());
	}

	DOTNET_EXPORT auto E_AController_GetControlRotation(AController* Self)
	{
		return (INT_PTR) new FRotator(Self->GetControlRotation());
	}

	DOTNET_EXPORT auto E_AController_GetDesiredRotation(AController* Self)
	{
		return (INT_PTR) new FRotator(Self->GetDesiredRotation());
	}

	DOTNET_EXPORT auto E_AController_GetPawn(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawn());
	}

	DOTNET_EXPORT auto E_AController_GetPlayerViewPoint(AController* Self, INT_PTR Location, INT_PTR Rotation)
	{
		auto& _p0 = *(FVector*)Location;
		auto& _p1 = *(FRotator*)Rotation;
		Self->GetPlayerViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AController_GetStateName(AController* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetStateName());
	}

	DOTNET_EXPORT auto E_AController_GetTransformComponent(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_AController*)Self)->GetTransformComponent_WRAP());
	}

	DOTNET_EXPORT auto E_AController_GetViewTarget(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetViewTarget());
	}

	DOTNET_EXPORT auto E_AController_InitPlayerState(AController* Self)
	{
		Self->InitPlayerState();
	}

	DOTNET_EXPORT auto E_AController_IsInState(AController* Self, char* InStateName)
	{
		auto _p0 = ConvertFromManage_FName(InStateName);
		return Self->IsInState(_p0);
	}

	DOTNET_EXPORT auto E_AController_IsLocalController(AController* Self)
	{
		return Self->IsLocalController();
	}

	DOTNET_EXPORT auto E_AController_IsLocalPlayerController(AController* Self)
	{
		return Self->IsLocalPlayerController();
	}

	DOTNET_EXPORT auto E_AController_IsLookInputIgnored(AController* Self)
	{
		return Self->IsLookInputIgnored();
	}

	DOTNET_EXPORT auto E_AController_IsMoveInputIgnored(AController* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_AController_IsPlayerController(AController* Self)
	{
		return Self->IsPlayerController();
	}

	DOTNET_EXPORT auto E_AController_K2_GetPawn(AController* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->K2_GetPawn());
	}

	DOTNET_EXPORT auto E_AController_LineOfSightTo(AController* Self, AActor* Other, INT_PTR ViewPoint, bool bAlternateChecks)
	{
		auto _p0 = Other;
		auto _p1 = *(FVector*)ViewPoint;
		auto _p2 = bAlternateChecks;
		return Self->LineOfSightTo(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AController_OnPossess(AController* Self, APawn* InPawn)
	{
		auto _p0 = InPawn;
		((E_PROTECTED_WRAP_AController*)Self)->OnPossess_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_OnRep_Pawn(AController* Self)
	{
		Self->OnRep_Pawn();
	}

	DOTNET_EXPORT auto E_AController_OnRep_PlayerState(AController* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_AController_OnUnPossess(AController* Self)
	{
		((E_PROTECTED_WRAP_AController*)Self)->OnUnPossess_WRAP();
	}

	DOTNET_EXPORT auto E_AController_PawnPendingDestroy(AController* Self, APawn* inPawn)
	{
		auto _p0 = inPawn;
		Self->PawnPendingDestroy(_p0);
	}

	DOTNET_EXPORT auto E_AController_Possess(AController* Self, APawn* InPawn)
	{
		auto _p0 = InPawn;
		Self->Possess(_p0);
	}

	DOTNET_EXPORT auto E_AController_ReceivePossess(AController* Self, APawn* PossessedPawn)
	{
		auto _p0 = PossessedPawn;
		((E_PROTECTED_WRAP_AController*)Self)->ReceivePossess_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_ReceiveUnPossess(AController* Self, APawn* UnpossessedPawn)
	{
		auto _p0 = UnpossessedPawn;
		((E_PROTECTED_WRAP_AController*)Self)->ReceiveUnPossess_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_RemovePawnTickDependency(AController* Self, APawn* InOldPawn)
	{
		auto _p0 = InOldPawn;
		((E_PROTECTED_WRAP_AController*)Self)->RemovePawnTickDependency_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AController_ResetIgnoreInputFlags(AController* Self)
	{
		Self->ResetIgnoreInputFlags();
	}

	DOTNET_EXPORT auto E_AController_ResetIgnoreLookInput(AController* Self)
	{
		Self->ResetIgnoreLookInput();
	}

	DOTNET_EXPORT auto E_AController_ResetIgnoreMoveInput(AController* Self)
	{
		Self->ResetIgnoreMoveInput();
	}

	DOTNET_EXPORT auto E_AController_SetControlRotation(AController* Self, INT_PTR NewRotation)
	{
		auto& _p0 = *(FRotator*)NewRotation;
		Self->SetControlRotation(_p0);
	}

	DOTNET_EXPORT auto E_AController_SetIgnoreLookInput(AController* Self, bool bNewLookInput)
	{
		auto _p0 = bNewLookInput;
		Self->SetIgnoreLookInput(_p0);
	}

	DOTNET_EXPORT auto E_AController_SetIgnoreMoveInput(AController* Self, bool bNewMoveInput)
	{
		auto _p0 = bNewMoveInput;
		Self->SetIgnoreMoveInput(_p0);
	}

	DOTNET_EXPORT auto E_AController_SetInitialLocationAndRotation(AController* Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto& _p0 = *(FVector*)NewLocation;
		auto& _p1 = *(FRotator*)NewRotation;
		Self->SetInitialLocationAndRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AController_SetPawn(AController* Self, APawn* InPawn)
	{
		auto _p0 = InPawn;
		Self->SetPawn(_p0);
	}

	DOTNET_EXPORT auto E_AController_SetPawnFromRep(AController* Self, APawn* InPawn)
	{
		auto _p0 = InPawn;
		Self->SetPawnFromRep(_p0);
	}

	DOTNET_EXPORT auto E_AController_StopMovement(AController* Self)
	{
		Self->StopMovement();
	}

	DOTNET_EXPORT auto E_AController_UnPossess(AController* Self)
	{
		Self->UnPossess();
	}

	DOTNET_EXPORT auto E_AController_UpdateNavigationComponents(AController* Self)
	{
		Self->UpdateNavigationComponents();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
