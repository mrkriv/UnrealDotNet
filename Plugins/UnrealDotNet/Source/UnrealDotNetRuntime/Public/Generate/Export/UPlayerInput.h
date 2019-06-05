#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePlayerInput.h"
#include "Runtime/Engine/Classes/GameFramework/PlayerInput.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:270

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlayerInput(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlayerInput>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_BeginDestroy(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_FinishDestroy(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostCDOContruct(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostEditImport(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostInitProperties(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostLoad(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostNetReceive(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostRepNotifies(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePlayerInput*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_PreNetReceive(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_ShutdownAfterError(UObject* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPlayerInput_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePlayerInput*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
