#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageOnlineSession.h"
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

	DOTNET_EXPORT auto E__Supper__UOnlineSession_ClearOnlineDelegates(UOnlineSession* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__ClearOnlineDelegates();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_RegisterOnlineDelegates(UOnlineSession* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__RegisterOnlineDelegates();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_BeginDestroy(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_FinishDestroy(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostCDOContruct(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostEditImport(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostInitProperties(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostLoad(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostNetReceive(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostRepNotifies(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageOnlineSession*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PreDestroyFromReplication(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_PreNetReceive(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_ShutdownAfterError(UObject* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UOnlineSession_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageOnlineSession*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
