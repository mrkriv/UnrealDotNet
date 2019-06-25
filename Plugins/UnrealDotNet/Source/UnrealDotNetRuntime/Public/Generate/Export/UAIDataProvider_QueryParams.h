#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageAIDataProvider_QueryParams.h"
#include "Runtime/AIModule/Classes/DataProviders/AIDataProvider_QueryParams.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider_QueryParams.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UAIDataProvider_QueryParams_BoolValue_GET(UAIDataProvider_QueryParams* Ptr) { return Ptr->BoolValue; }
	DOTNET_EXPORT void E_PROP_UAIDataProvider_QueryParams_BoolValue_SET(UAIDataProvider_QueryParams* Ptr, bool Value) { Ptr->BoolValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAIDataProvider_QueryParams_FloatValue_GET(UAIDataProvider_QueryParams* Ptr) { return Ptr->FloatValue; }
	DOTNET_EXPORT void E_PROP_UAIDataProvider_QueryParams_FloatValue_SET(UAIDataProvider_QueryParams* Ptr, float Value) { Ptr->FloatValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAIDataProvider_QueryParams_IntValue_GET(UAIDataProvider_QueryParams* Ptr) { return Ptr->IntValue; }
	DOTNET_EXPORT void E_PROP_UAIDataProvider_QueryParams_IntValue_SET(UAIDataProvider_QueryParams* Ptr, int32 Value) { Ptr->IntValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAIDataProvider_QueryParams_ParamName_GET(UAIDataProvider_QueryParams* Ptr) { return ConvertToManage_StringWrapper(Ptr->ParamName); }
	DOTNET_EXPORT void E_PROP_UAIDataProvider_QueryParams_ParamName_SET(UAIDataProvider_QueryParams* Ptr, char* Value) { Ptr->ParamName = ConvertFromManage_FName(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAIDataProvider_QueryParams(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAIDataProvider_QueryParams>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_BeginDestroy(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_FinishDestroy(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostCDOContruct(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostEditImport(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostInitProperties(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostLoad(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostNetReceive(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostRepNotifies(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PreDestroyFromReplication(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_PreNetReceive(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_ShutdownAfterError(UObject* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UAIDataProvider_QueryParams_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageAIDataProvider_QueryParams*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
