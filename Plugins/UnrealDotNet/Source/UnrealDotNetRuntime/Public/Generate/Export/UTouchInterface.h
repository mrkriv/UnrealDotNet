#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageTouchInterface.h"
#include "Runtime/Engine/Classes/GameFramework/TouchInterface.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:56

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UTouchInterface_ActivationDelay_GET(UTouchInterface* Ptr) { return Ptr->ActivationDelay; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_ActivationDelay_SET(UTouchInterface* Ptr, float Value) { Ptr->ActivationDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_ActiveOpacity_GET(UTouchInterface* Ptr) { return Ptr->ActiveOpacity; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_ActiveOpacity_SET(UTouchInterface* Ptr, float Value) { Ptr->ActiveOpacity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_bPreventRecenter_GET(UTouchInterface* Ptr) { return Ptr->bPreventRecenter; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_bPreventRecenter_SET(UTouchInterface* Ptr, bool Value) { Ptr->bPreventRecenter = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_InactiveOpacity_GET(UTouchInterface* Ptr) { return Ptr->InactiveOpacity; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_InactiveOpacity_SET(UTouchInterface* Ptr, float Value) { Ptr->InactiveOpacity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_StartupDelay_GET(UTouchInterface* Ptr) { return Ptr->StartupDelay; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_StartupDelay_SET(UTouchInterface* Ptr, float Value) { Ptr->StartupDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_TimeUntilDeactive_GET(UTouchInterface* Ptr) { return Ptr->TimeUntilDeactive; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_TimeUntilDeactive_SET(UTouchInterface* Ptr, float Value) { Ptr->TimeUntilDeactive = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_TimeUntilReset_GET(UTouchInterface* Ptr) { return Ptr->TimeUntilReset; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_TimeUntilReset_SET(UTouchInterface* Ptr, float Value) { Ptr->TimeUntilReset = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTouchInterface(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTouchInterface>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_BeginDestroy(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_FinishDestroy(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostCDOContruct(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostEditImport(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostInitProperties(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostLoad(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostNetReceive(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostRepNotifies(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageTouchInterface*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PreDestroyFromReplication(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_PreNetReceive(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_ShutdownAfterError(UObject* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UTouchInterface_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageTouchInterface*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
