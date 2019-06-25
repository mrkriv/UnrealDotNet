#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePathFollowingManager.h"
#include "Runtime/AIModule/Classes/Navigation/PathFollowingManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\PathFollowingManager.h:13

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPathFollowingManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPathFollowingManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPathFollowingManager_IsFollowingAPath(UPathFollowingManager* Self, AController& Controller)
	{
		auto& _p0 = Controller;
		return Self->IsFollowingAPath(_p0);
	}

	DOTNET_EXPORT auto E_UPathFollowingManager_StopMovement(UPathFollowingManager* Self, AController& Controller)
	{
		auto& _p0 = Controller;
		Self->StopMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_BeginDestroy(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_FinishDestroy(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostCDOContruct(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostEditImport(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostInitProperties(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostLoad(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostNetReceive(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostRepNotifies(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePathFollowingManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_PreNetReceive(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_ShutdownAfterError(UObject* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPathFollowingManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePathFollowingManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
