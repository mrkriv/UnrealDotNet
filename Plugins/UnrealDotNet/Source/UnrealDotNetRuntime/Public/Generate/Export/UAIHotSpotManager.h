#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageAIHotSpotManager.h"
#include "Runtime/AIModule/Classes/HotSpots/AIHotSpotManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\HotSpots\AIHotSpotManager.h:10

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAIHotSpotManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAIHotSpotManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_BeginDestroy(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_FinishDestroy(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostCDOContruct(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostEditImport(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostInitProperties(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostLoad(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostNetReceive(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostRepNotifies(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageAIHotSpotManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PreDestroyFromReplication(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_PreNetReceive(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_ShutdownAfterError(UObject* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UAIHotSpotManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageAIHotSpotManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
