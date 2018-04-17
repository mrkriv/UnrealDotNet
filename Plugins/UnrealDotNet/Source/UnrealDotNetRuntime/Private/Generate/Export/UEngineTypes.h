#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Engine/EngineTypes.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3430

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UEngineTypes(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UEngineTypes>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UEngineTypes_ConvertToObjectType(UEngineTypes* Self, ECollisionChannel CollisionChannel)
	{
		auto _p0 = CollisionChannel;
		return Self->ConvertToObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_ConvertToTraceType(UEngineTypes* Self, ECollisionChannel CollisionChannel)
	{
		auto _p0 = CollisionChannel;
		return Self->ConvertToTraceType(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_AreNativePropertiesIdenticalTo(UEngineTypes* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_BeginDestroy(UEngineTypes* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UEngineTypes_CheckDefaultSubobjectsInternal(UEngineTypes* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UEngineTypes_FinishDestroy(UEngineTypes* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UEngineTypes_GetDesc(UEngineTypes* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UEngineTypes_GetDetailedInfoInternal(UEngineTypes* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UEngineTypes_GetWorld(UEngineTypes* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsAsset(UEngineTypes* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsEditorOnly(UEngineTypes* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsFullNameStableForNetworking(UEngineTypes* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsLocalizedResource(UEngineTypes* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsNameStableForNetworking(UEngineTypes* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsPostLoadThreadSafe(UEngineTypes* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsReadyForFinishDestroy(UEngineTypes* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsSafeForRootSet(UEngineTypes* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UEngineTypes_IsSupportedForNetworking(UEngineTypes* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UEngineTypes_MarkAsEditorOnlySubobject(UEngineTypes* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UEngineTypes_Modify(UEngineTypes* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_NeedsLoadForClient(UEngineTypes* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UEngineTypes_NeedsLoadForEditorGame(UEngineTypes* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UEngineTypes_NeedsLoadForServer(UEngineTypes* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UEngineTypes_NotifyObjectReferenceEliminated(UEngineTypes* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostCDOContruct(UEngineTypes* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostEditImport(UEngineTypes* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostInitProperties(UEngineTypes* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostLoad(UEngineTypes* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostNetReceive(UEngineTypes* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostRename(UEngineTypes* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostRepNotifies(UEngineTypes* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PostSaveRoot(UEngineTypes* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UEngineTypes_PreDestroyFromReplication(UEngineTypes* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UEngineTypes_PreNetReceive(UEngineTypes* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UEngineTypes_ShutdownAfterError(UEngineTypes* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UEngineTypes_AddToCluster(UEngineTypes* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngineTypes_CanBeClusterRoot(UEngineTypes* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UEngineTypes_CanBeInCluster(UEngineTypes* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UEngineTypes_CreateCluster(UEngineTypes* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UEngineTypes_OnClusterMarkedAsPendingKill(UEngineTypes* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
