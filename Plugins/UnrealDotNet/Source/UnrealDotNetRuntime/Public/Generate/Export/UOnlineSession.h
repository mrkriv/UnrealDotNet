#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/OnlineSession.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UOnlineSession(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UOnlineSession>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UOnlineSession_ClearOnlineDelegates(UOnlineSession* Self)
	{
		Self->ClearOnlineDelegates();
	}

	DOTNET_EXPORT auto E_UOnlineSession_EndOnlineSession(UOnlineSession* Self, char* SessionName)
	{
		auto _p0 = ConvertFromManage_FName(SessionName);
		Self->EndOnlineSession(_p0);
	}

	DOTNET_EXPORT auto E_UOnlineSession_RegisterOnlineDelegates(UOnlineSession* Self)
	{
		Self->RegisterOnlineDelegates();
	}

	DOTNET_EXPORT auto E_UOnlineSession_StartOnlineSession(UOnlineSession* Self, char* SessionName)
	{
		auto _p0 = ConvertFromManage_FName(SessionName);
		Self->StartOnlineSession(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
