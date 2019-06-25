#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageVisualLoggerExtension.h"
#include "Runtime/AIModule/Classes/VisualLoggerExtension.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\VisualLoggerExtension.h:48

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UVisualLoggerExtension(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UVisualLoggerExtension>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_BeginDestroy(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_FinishDestroy(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostCDOContruct(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostEditImport(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostInitProperties(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostLoad(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostNetReceive(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostRepNotifies(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageVisualLoggerExtension*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PreDestroyFromReplication(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_PreNetReceive(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_ShutdownAfterError(UObject* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UVisualLoggerExtension_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageVisualLoggerExtension*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
