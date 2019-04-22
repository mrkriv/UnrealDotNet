#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/Player.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlayer(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlayer>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPlayer_ConsoleCommand(UPlayer* Self, char* Cmd, bool bWriteToLog)
	{
		auto _p0 = ConvertFromManage_FString(Cmd);
		auto _p1 = bWriteToLog;
		return ConvertToManage_StringWrapper(Self->ConsoleCommand(_p0, _p1));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
