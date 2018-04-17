#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/EngineBaseTypes.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:999

extern "C"
{
	DOTNET_EXPORT auto E_UEngineBaseTypes_AreNativePropertiesIdenticalTo(UEngineBaseTypes* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_BeginDestroy(UEngineBaseTypes* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_CheckDefaultSubobjectsInternal(UEngineBaseTypes* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_FinishDestroy(UEngineBaseTypes* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_GetDesc(UEngineBaseTypes* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_GetDetailedInfoInternal(UEngineBaseTypes* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_GetWorld(UEngineBaseTypes* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsAsset(UEngineBaseTypes* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsEditorOnly(UEngineBaseTypes* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsFullNameStableForNetworking(UEngineBaseTypes* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsLocalizedResource(UEngineBaseTypes* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsNameStableForNetworking(UEngineBaseTypes* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsPostLoadThreadSafe(UEngineBaseTypes* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsReadyForFinishDestroy(UEngineBaseTypes* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsSafeForRootSet(UEngineBaseTypes* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_IsSupportedForNetworking(UEngineBaseTypes* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_MarkAsEditorOnlySubobject(UEngineBaseTypes* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_Modify(UEngineBaseTypes* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_NeedsLoadForClient(UEngineBaseTypes* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_NeedsLoadForEditorGame(UEngineBaseTypes* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_NeedsLoadForServer(UEngineBaseTypes* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_NotifyObjectReferenceEliminated(UEngineBaseTypes* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostCDOContruct(UEngineBaseTypes* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostEditImport(UEngineBaseTypes* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostInitProperties(UEngineBaseTypes* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostLoad(UEngineBaseTypes* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostNetReceive(UEngineBaseTypes* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostRename(UEngineBaseTypes* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostRepNotifies(UEngineBaseTypes* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PostSaveRoot(UEngineBaseTypes* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PreDestroyFromReplication(UEngineBaseTypes* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_PreNetReceive(UEngineBaseTypes* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_ShutdownAfterError(UEngineBaseTypes* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_AddToCluster(UEngineBaseTypes* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_CanBeClusterRoot(UEngineBaseTypes* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_CanBeInCluster(UEngineBaseTypes* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_CreateCluster(UEngineBaseTypes* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UEngineBaseTypes_OnClusterMarkedAsPendingKill(UEngineBaseTypes* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
