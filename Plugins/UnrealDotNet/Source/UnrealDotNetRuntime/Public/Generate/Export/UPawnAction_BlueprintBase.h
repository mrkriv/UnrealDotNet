#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction_BlueprintBase.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_BlueprintBase.h:13

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction_BlueprintBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction_BlueprintBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_BlueprintBase_ActionPause(UPawnAction_BlueprintBase* Self, APawn* ControlledPawn)
	{
		auto _p0 = ControlledPawn;
		Self->ActionPause(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_BlueprintBase_ActionResume(UPawnAction_BlueprintBase* Self, APawn* ControlledPawn)
	{
		auto _p0 = ControlledPawn;
		Self->ActionResume(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_BlueprintBase_ActionStart(UPawnAction_BlueprintBase* Self, APawn* ControlledPawn)
	{
		auto _p0 = ControlledPawn;
		Self->ActionStart(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_BlueprintBase_ActionTick(UPawnAction_BlueprintBase* Self, APawn* ControlledPawn, float DeltaSeconds)
	{
		auto _p0 = ControlledPawn;
		auto _p1 = DeltaSeconds;
		Self->ActionTick(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
