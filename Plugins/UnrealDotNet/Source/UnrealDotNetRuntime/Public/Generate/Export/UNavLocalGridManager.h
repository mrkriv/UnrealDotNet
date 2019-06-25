#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageNavLocalGridManager.h"
#include "Runtime/AIModule/Classes/Navigation/NavLocalGridManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\NavLocalGridManager.h:27

class E_PROTECTED_WRAP_UNavLocalGridManager : protected UNavLocalGridManager
{
public:
	bool UpdateSourceGrids_WRAP()
	{
		return UpdateSourceGrids();
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UNavLocalGridManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UNavLocalGridManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetCellSize(UNavLocalGridManager* Self)
	{
		return Self->GetCellSize();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetCurrent(UNavLocalGridManager* Self, UWorld* World)
	{
		auto _p0 = World;
		return ConvertToManage_ObjectPointerDescription(Self->GetCurrent(_p0));
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetCurrent_o1(UNavLocalGridManager* Self, UObject* WorldContextObject)
	{
		auto _p0 = WorldContextObject;
		return ConvertToManage_ObjectPointerDescription(Self->GetCurrent(_p0));
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetGridIndex(UNavLocalGridManager* Self, INT_PTR WorldLocation)
	{
		auto& _p0 = *(FVector*)WorldLocation;
		return Self->GetGridIndex(_p0);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetGridValueAt(UNavLocalGridManager* Self, INT_PTR WorldLocation)
	{
		auto& _p0 = *(FVector*)WorldLocation;
		return Self->GetGridValueAt(_p0);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetMaxActiveSources(UNavLocalGridManager* Self)
	{
		return Self->GetMaxActiveSources();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetNumGrids(UNavLocalGridManager* Self)
	{
		return Self->GetNumGrids();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetNumSources(UNavLocalGridManager* Self)
	{
		return Self->GetNumSources();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_GetVersion(UNavLocalGridManager* Self)
	{
		return Self->GetVersion();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_HasSourceGridLimit(UNavLocalGridManager* Self)
	{
		return Self->HasSourceGridLimit();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_RebuildGrids(UNavLocalGridManager* Self)
	{
		Self->RebuildGrids();
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_RemoveGridData(UNavLocalGridManager* Self, int32 GridId, bool bUpdate)
	{
		auto _p0 = GridId;
		auto _p1 = bUpdate;
		Self->RemoveGridData(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_RemoveLocalNavigationGrid(UNavLocalGridManager* Self, UObject* WorldContextObject, int32 GridId, bool bRebuildGrids)
	{
		auto _p0 = WorldContextObject;
		auto _p1 = GridId;
		auto _p2 = bRebuildGrids;
		Self->RemoveLocalNavigationGrid(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_SetCellSize(UNavLocalGridManager* Self, float CellSize)
	{
		auto _p0 = CellSize;
		return Self->SetCellSize(_p0);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_SetLocalNavigationGridDensity(UNavLocalGridManager* Self, UObject* WorldContextObject, float CellSize)
	{
		auto _p0 = WorldContextObject;
		auto _p1 = CellSize;
		return Self->SetLocalNavigationGridDensity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_SetMaxActiveSources(UNavLocalGridManager* Self, int32 NumActiveSources)
	{
		auto _p0 = NumActiveSources;
		Self->SetMaxActiveSources(_p0);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_UpdateAccessTime(UNavLocalGridManager* Self, int32 CombinedGridIdx)
	{
		auto _p0 = CombinedGridIdx;
		Self->UpdateAccessTime(_p0);
	}

	DOTNET_EXPORT auto E_UNavLocalGridManager_UpdateSourceGrids(UNavLocalGridManager* Self)
	{
		return ((E_PROTECTED_WRAP_UNavLocalGridManager*)Self)->UpdateSourceGrids_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_BeginDestroy(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_FinishDestroy(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostCDOContruct(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostEditImport(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostInitProperties(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostLoad(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostNetReceive(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostRepNotifies(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageNavLocalGridManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PreDestroyFromReplication(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_PreNetReceive(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_ShutdownAfterError(UObject* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UNavLocalGridManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageNavLocalGridManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
