#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/Player.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlayer(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlayer>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPlayer_ConsoleCommand(UPlayer* Self, char* Cmd, bool bWriteToLog)
	{
		auto _p0 = ConvertFromManage_FString(Cmd);
		auto _p1 = bWriteToLog;
		return ConvertToManage_StringWrapper(Self->ConsoleCommand(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPlayer_AreNativePropertiesIdenticalTo(UPlayer* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPlayer_BeginDestroy(UPlayer* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPlayer_CheckDefaultSubobjectsInternal(UPlayer* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPlayer_FinishDestroy(UPlayer* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlayer_GetDesc(UPlayer* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPlayer_GetDetailedInfoInternal(UPlayer* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPlayer_GetWorld(UPlayer* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UPlayer_IsAsset(UPlayer* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPlayer_IsEditorOnly(UPlayer* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPlayer_IsFullNameStableForNetworking(UPlayer* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlayer_IsLocalizedResource(UPlayer* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPlayer_IsNameStableForNetworking(UPlayer* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPlayer_IsPostLoadThreadSafe(UPlayer* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPlayer_IsReadyForFinishDestroy(UPlayer* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPlayer_IsSafeForRootSet(UPlayer* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPlayer_IsSupportedForNetworking(UPlayer* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPlayer_MarkAsEditorOnlySubobject(UPlayer* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPlayer_Modify(UPlayer* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPlayer_NeedsLoadForClient(UPlayer* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPlayer_NeedsLoadForEditorGame(UPlayer* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPlayer_NeedsLoadForServer(UPlayer* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPlayer_NotifyObjectReferenceEliminated(UPlayer* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPlayer_PostCDOContruct(UPlayer* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPlayer_PostEditImport(UPlayer* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPlayer_PostInitProperties(UPlayer* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPlayer_PostLoad(UPlayer* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPlayer_PostNetReceive(UPlayer* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPlayer_PostRename(UPlayer* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlayer_PostRepNotifies(UPlayer* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPlayer_PostSaveRoot(UPlayer* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPlayer_PreDestroyFromReplication(UPlayer* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPlayer_PreNetReceive(UPlayer* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPlayer_ShutdownAfterError(UPlayer* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPlayer_AddToCluster(UPlayer* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPlayer_CanBeClusterRoot(UPlayer* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPlayer_CanBeInCluster(UPlayer* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPlayer_CreateCluster(UPlayer* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPlayer_OnClusterMarkedAsPendingKill(UPlayer* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
