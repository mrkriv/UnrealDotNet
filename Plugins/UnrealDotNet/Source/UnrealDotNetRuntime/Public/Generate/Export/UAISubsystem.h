#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageAISubsystem.h"
#include "Runtime/AIModule/Classes/AISubsystem.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AISubsystem.h:15

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAISubsystem(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAISubsystem>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UAISubsystem_GetWorldFast(UAISubsystem* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorldFast());
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_BeginDestroy(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_FinishDestroy(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostCDOContruct(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostEditImport(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostInitProperties(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostLoad(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostNetReceive(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostRepNotifies(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageAISubsystem*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PreDestroyFromReplication(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_PreNetReceive(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_ShutdownAfterError(UObject* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UAISubsystem_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageAISubsystem*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
