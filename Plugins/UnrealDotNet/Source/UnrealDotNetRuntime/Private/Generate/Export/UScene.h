#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/Scene.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:1741

extern "C"
{
	DOTNET_EXPORT auto E_UScene_AreNativePropertiesIdenticalTo(UScene* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UScene_BeginDestroy(UScene* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UScene_CheckDefaultSubobjectsInternal(UScene* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UScene_FinishDestroy(UScene* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UScene_GetDesc(UScene* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UScene_GetDetailedInfoInternal(UScene* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UScene_GetWorld(UScene* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UScene_IsAsset(UScene* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UScene_IsEditorOnly(UScene* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UScene_IsFullNameStableForNetworking(UScene* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UScene_IsLocalizedResource(UScene* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UScene_IsNameStableForNetworking(UScene* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UScene_IsPostLoadThreadSafe(UScene* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UScene_IsReadyForFinishDestroy(UScene* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UScene_IsSafeForRootSet(UScene* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UScene_IsSupportedForNetworking(UScene* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UScene_MarkAsEditorOnlySubobject(UScene* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UScene_Modify(UScene* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UScene_NeedsLoadForClient(UScene* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UScene_NeedsLoadForEditorGame(UScene* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UScene_NeedsLoadForServer(UScene* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UScene_NotifyObjectReferenceEliminated(UScene* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UScene_PostCDOContruct(UScene* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UScene_PostEditImport(UScene* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UScene_PostInitProperties(UScene* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UScene_PostLoad(UScene* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UScene_PostNetReceive(UScene* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UScene_PostRename(UScene* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UScene_PostRepNotifies(UScene* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UScene_PostSaveRoot(UScene* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UScene_PreDestroyFromReplication(UScene* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UScene_PreNetReceive(UScene* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UScene_ShutdownAfterError(UScene* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UScene_AddToCluster(UScene* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UScene_CanBeClusterRoot(UScene* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UScene_CanBeInCluster(UScene* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UScene_CreateCluster(UScene* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UScene_OnClusterMarkedAsPendingKill(UScene* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
