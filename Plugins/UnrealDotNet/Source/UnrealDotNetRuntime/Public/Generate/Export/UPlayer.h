#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePlayer.h"
#include "Runtime/Engine/Classes/Engine/Player.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPlayer_ConfiguredInternetSpeed_GET(UPlayer* Ptr) { return Ptr->ConfiguredInternetSpeed; }
	DOTNET_EXPORT void E_PROP_UPlayer_ConfiguredInternetSpeed_SET(UPlayer* Ptr, int32 Value) { Ptr->ConfiguredInternetSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlayer_ConfiguredLanSpeed_GET(UPlayer* Ptr) { return Ptr->ConfiguredLanSpeed; }
	DOTNET_EXPORT void E_PROP_UPlayer_ConfiguredLanSpeed_SET(UPlayer* Ptr, int32 Value) { Ptr->ConfiguredLanSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlayer_CurrentNetSpeed_GET(UPlayer* Ptr) { return Ptr->CurrentNetSpeed; }
	DOTNET_EXPORT void E_PROP_UPlayer_CurrentNetSpeed_SET(UPlayer* Ptr, int32 Value) { Ptr->CurrentNetSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPlayer_PlayerController_GET(UPlayer* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PlayerController); }
	DOTNET_EXPORT void E_PROP_UPlayer_PlayerController_SET(UPlayer* Ptr, APlayerController* Value) { Ptr->PlayerController = Value; }
	
	
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

	DOTNET_EXPORT auto E_UPlayer_GetPlayerController(UPlayer* Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		return ConvertToManage_ObjectPointerDescription(Self->GetPlayerController(_p0));
	}

	DOTNET_EXPORT auto E_UPlayer_SwitchController(UPlayer* Self, APlayerController* PC)
	{
		auto _p0 = PC;
		Self->SwitchController(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_BeginDestroy(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_FinishDestroy(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostCDOContruct(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostEditImport(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostInitProperties(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostLoad(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostNetReceive(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostRepNotifies(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePlayer*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_PreNetReceive(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_ShutdownAfterError(UObject* Self)
	{
		((UManagePlayer*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePlayer*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPlayer_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePlayer*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
