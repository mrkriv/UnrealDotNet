#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnAction_Sequence.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction_Sequence.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Sequence.h:11

class E_PROTECTED_WRAP_UPawnAction_Sequence : protected UPawnAction_Sequence
{
public:
	bool PushNextActionCopy_WRAP()
	{
		return PushNextActionCopy();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPawnAction_Sequence_RecentActionCopy_GET(UPawnAction_Sequence* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->RecentActionCopy); }
	DOTNET_EXPORT void E_PROP_UPawnAction_Sequence_RecentActionCopy_SET(UPawnAction_Sequence* Ptr, UPawnAction* Value) { Ptr->RecentActionCopy = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction_Sequence(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction_Sequence>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_Sequence_PushNextActionCopy(UPawnAction_Sequence* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction_Sequence*)Self)->PushNextActionCopy_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_Tick(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManagePawnAction_Sequence*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_BeginDestroy(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_FinishDestroy(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostCDOContruct(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostEditImport(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostInitProperties(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostLoad(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostNetReceive(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostRepNotifies(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnAction_Sequence*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_PreNetReceive(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Sequence_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Sequence*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
