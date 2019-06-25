#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageAIDataProvider.h"
#include "Runtime/AIModule/Classes/DataProviders/AIDataProvider.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:138

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAIDataProvider(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAIDataProvider>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UAIDataProvider_BindData(UAIDataProvider* Self, UObject& Owner, int32 RequestId)
	{
		auto& _p0 = Owner;
		auto _p1 = RequestId;
		Self->BindData(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAIDataProvider_ToString(UAIDataProvider* Self, char* PropName)
	{
		auto _p0 = ConvertFromManage_FName(PropName);
		return ConvertToManage_StringWrapper(Self->ToString(_p0));
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_BeginDestroy(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_FinishDestroy(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostCDOContruct(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostEditImport(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostInitProperties(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostLoad(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostNetReceive(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostRepNotifies(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageAIDataProvider*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PreDestroyFromReplication(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_PreNetReceive(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_ShutdownAfterError(UObject* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageAIDataProvider*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
