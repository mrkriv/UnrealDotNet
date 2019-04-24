#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/FloatingPawnMovement.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

class E_PROTECTED_WRAP_UFloatingPawnMovement : protected UFloatingPawnMovement
{
public:
	void ApplyControlInputToVelocity_WRAP(float DeltaTime)
	{
		ApplyControlInputToVelocity(DeltaTime);
	}

	bool LimitWorldBounds_WRAP()
	{
		return LimitWorldBounds();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_Acceleration_GET(UFloatingPawnMovement* Ptr) { return Ptr->Acceleration; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_Acceleration_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->Acceleration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_Deceleration_GET(UFloatingPawnMovement* Ptr) { return Ptr->Deceleration; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_Deceleration_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->Deceleration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_MaxSpeed_GET(UFloatingPawnMovement* Ptr) { return Ptr->MaxSpeed; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_MaxSpeed_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->MaxSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_TurningBoost_GET(UFloatingPawnMovement* Ptr) { return Ptr->TurningBoost; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_TurningBoost_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->TurningBoost = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UFloatingPawnMovement(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UFloatingPawnMovement>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UFloatingPawnMovement_ApplyControlInputToVelocity(UFloatingPawnMovement* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UFloatingPawnMovement*)Self)->ApplyControlInputToVelocity_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UFloatingPawnMovement_LimitWorldBounds(UFloatingPawnMovement* Self)
	{
		return ((E_PROTECTED_WRAP_UFloatingPawnMovement*)Self)->LimitWorldBounds_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
