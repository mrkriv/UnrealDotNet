#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageHierarchicalLODSetup.h"
#include "Runtime/Engine/Classes/GameFramework/WorldSettings.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:338

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UHierarchicalLODSetup(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UHierarchicalLODSetup>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_BeginDestroy(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_FinishDestroy(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostCDOContruct(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostEditImport(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostInitProperties(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostLoad(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostNetReceive(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostRepNotifies(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageHierarchicalLODSetup*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PreDestroyFromReplication(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_PreNetReceive(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_ShutdownAfterError(UObject* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UHierarchicalLODSetup_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageHierarchicalLODSetup*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
