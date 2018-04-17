#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/SaveGame.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SaveGame.h:19

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USaveGame(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USaveGame>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USaveGame_AreNativePropertiesIdenticalTo(USaveGame* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USaveGame_BeginDestroy(USaveGame* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USaveGame_CheckDefaultSubobjectsInternal(USaveGame* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USaveGame_FinishDestroy(USaveGame* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USaveGame_GetDesc(USaveGame* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USaveGame_GetDetailedInfoInternal(USaveGame* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USaveGame_GetWorld(USaveGame* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_USaveGame_IsAsset(USaveGame* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USaveGame_IsEditorOnly(USaveGame* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USaveGame_IsFullNameStableForNetworking(USaveGame* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USaveGame_IsLocalizedResource(USaveGame* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USaveGame_IsNameStableForNetworking(USaveGame* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USaveGame_IsPostLoadThreadSafe(USaveGame* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USaveGame_IsReadyForFinishDestroy(USaveGame* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USaveGame_IsSafeForRootSet(USaveGame* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USaveGame_IsSupportedForNetworking(USaveGame* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USaveGame_MarkAsEditorOnlySubobject(USaveGame* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USaveGame_Modify(USaveGame* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USaveGame_NeedsLoadForClient(USaveGame* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USaveGame_NeedsLoadForEditorGame(USaveGame* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USaveGame_NeedsLoadForServer(USaveGame* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USaveGame_NotifyObjectReferenceEliminated(USaveGame* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USaveGame_PostCDOContruct(USaveGame* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USaveGame_PostEditImport(USaveGame* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USaveGame_PostInitProperties(USaveGame* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USaveGame_PostLoad(USaveGame* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USaveGame_PostNetReceive(USaveGame* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USaveGame_PostRename(USaveGame* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USaveGame_PostRepNotifies(USaveGame* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USaveGame_PostSaveRoot(USaveGame* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USaveGame_PreDestroyFromReplication(USaveGame* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USaveGame_PreNetReceive(USaveGame* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USaveGame_ShutdownAfterError(USaveGame* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USaveGame_AddToCluster(USaveGame* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USaveGame_CanBeClusterRoot(USaveGame* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USaveGame_CanBeInCluster(USaveGame* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USaveGame_CreateCluster(USaveGame* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USaveGame_OnClusterMarkedAsPendingKill(USaveGame* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
