#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/EngineTypes.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3473

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UEngineTypes(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UEngineTypes>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UEngineTypes_ConvertToObjectType(UEngineTypes* Self, ECollisionChannel CollisionChannel)
	{
		auto _p0 = CollisionChannel;
		return Self->ConvertToObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_ConvertToTraceType(UEngineTypes* Self, ECollisionChannel CollisionChannel)
	{
		auto _p0 = CollisionChannel;
		return Self->ConvertToTraceType(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
