#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/PawnMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

class E_PROTECTED_WRAP_UPawnMovementComponent : protected UPawnMovementComponent
{
public:
	void MarkForClientCameraUpdate_WRAP()
	{
		MarkForClientCameraUpdate();
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_AddInputVector(UPawnMovementComponent* Self, INT_PTR WorldVector, bool bForce)
	{
		auto _p0 = *(FVector*)WorldVector;
		auto _p1 = bForce;
		Self->AddInputVector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_ConsumeInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetLastInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetLastInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPawnOwner(UPawnMovementComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnOwner());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_GetPendingInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetPendingInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_IsMoveInputIgnored(UPawnMovementComponent* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_K2_GetInputVector(UPawnMovementComponent* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetInputVector());
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_MarkForClientCameraUpdate(UPawnMovementComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnMovementComponent*)Self)->MarkForClientCameraUpdate_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnMovementComponent_NotifyBumpedPawn(UPawnMovementComponent* Self, APawn* BumpedPawn)
	{
		auto _p0 = BumpedPawn;
		Self->NotifyBumpedPawn(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
