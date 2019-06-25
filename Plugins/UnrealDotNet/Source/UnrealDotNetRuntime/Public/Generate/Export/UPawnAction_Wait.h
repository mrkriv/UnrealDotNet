#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnAction_Wait.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction_Wait.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Wait.h:13

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPawnAction_Wait_FinishTimeStamp_GET(UPawnAction_Wait* Ptr) { return Ptr->FinishTimeStamp; }
	DOTNET_EXPORT void E_PROP_UPawnAction_Wait_FinishTimeStamp_SET(UPawnAction_Wait* Ptr, float Value) { Ptr->FinishTimeStamp = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPawnAction_Wait_TimeToWait_GET(UPawnAction_Wait* Ptr) { return Ptr->TimeToWait; }
	DOTNET_EXPORT void E_PROP_UPawnAction_Wait_TimeToWait_SET(UPawnAction_Wait* Ptr, float Value) { Ptr->TimeToWait = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction_Wait(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction_Wait>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_Wait_CreateAction(UPawnAction_Wait* Self, UWorld& World, float InTimeToWait)
	{
		auto& _p0 = World;
		auto _p1 = InTimeToWait;
		return ConvertToManage_ObjectPointerDescription(Self->CreateAction(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPawnAction_Wait_TimerDone(UPawnAction_Wait* Self)
	{
		Self->TimerDone();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_Tick(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManagePawnAction_Wait*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_BeginDestroy(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_FinishDestroy(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostCDOContruct(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostEditImport(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostInitProperties(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostLoad(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostNetReceive(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostRepNotifies(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnAction_Wait*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_PreNetReceive(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Wait_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Wait*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
