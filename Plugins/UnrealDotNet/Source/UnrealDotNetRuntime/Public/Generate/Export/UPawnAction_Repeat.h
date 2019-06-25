#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnAction_Repeat.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction_Repeat.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Repeat.h:11

class E_PROTECTED_WRAP_UPawnAction_Repeat : protected UPawnAction_Repeat
{
public:
	bool PushSubAction_WRAP()
	{
		return PushSubAction();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPawnAction_Repeat_ActionToRepeat_GET(UPawnAction_Repeat* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->ActionToRepeat); }
	DOTNET_EXPORT void E_PROP_UPawnAction_Repeat_ActionToRepeat_SET(UPawnAction_Repeat* Ptr, UPawnAction* Value) { Ptr->ActionToRepeat = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPawnAction_Repeat_RecentActionCopy_GET(UPawnAction_Repeat* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->RecentActionCopy); }
	DOTNET_EXPORT void E_PROP_UPawnAction_Repeat_RecentActionCopy_SET(UPawnAction_Repeat* Ptr, UPawnAction* Value) { Ptr->RecentActionCopy = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPawnAction_Repeat_RepeatsLeft_GET(UPawnAction_Repeat* Ptr) { return Ptr->RepeatsLeft; }
	DOTNET_EXPORT void E_PROP_UPawnAction_Repeat_RepeatsLeft_SET(UPawnAction_Repeat* Ptr, int32 Value) { Ptr->RepeatsLeft = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction_Repeat(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction_Repeat>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_Repeat_PushSubAction(UPawnAction_Repeat* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction_Repeat*)Self)->PushSubAction_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_Tick(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManagePawnAction_Repeat*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_BeginDestroy(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_FinishDestroy(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostCDOContruct(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostEditImport(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostInitProperties(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostLoad(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostNetReceive(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostRepNotifies(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnAction_Repeat*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_PreNetReceive(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Repeat_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Repeat*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
