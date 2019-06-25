#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageForceFeedbackAttenuation.h"
#include "Runtime/Engine/Classes/GameFramework/ForceFeedbackAttenuation.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackAttenuation.h:20

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UForceFeedbackAttenuation(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UForceFeedbackAttenuation>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_BeginDestroy(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_FinishDestroy(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostCDOContruct(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostEditImport(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostInitProperties(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostLoad(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostNetReceive(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostRepNotifies(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PreDestroyFromReplication(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_PreNetReceive(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_ShutdownAfterError(UObject* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UForceFeedbackAttenuation_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageForceFeedbackAttenuation*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
