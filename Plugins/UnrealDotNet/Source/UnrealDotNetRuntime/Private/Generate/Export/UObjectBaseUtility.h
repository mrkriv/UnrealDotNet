#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "UObject/UObjectBaseUtility.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\UObject\UObjectBaseUtility.h:23

extern "C"
{
	DOTNET_EXPORT auto E_UObjectBaseUtility_AddToRoot(UObjectBaseUtility* Self)
	{
		Self->AddToRoot();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_AppendName(UObjectBaseUtility* Self, char* ResultString)
	{
		auto _p0 = ConvertFromManage_FString(ResultString);
		Self->AppendName(_p0);
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_CanBeClusterRoot(UObjectBaseUtility* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_CanBeInCluster(UObjectBaseUtility* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_ClearPendingKill(UObjectBaseUtility* Self)
	{
		Self->ClearPendingKill();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_CreateCluster(UObjectBaseUtility* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetFullGroupName(UObjectBaseUtility* Self, bool bStartWithOuter)
	{
		auto _p0 = bStartWithOuter;
		return ConvertToManage_StringWrapper(Self->GetFullGroupName(_p0));
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerIndex(UObjectBaseUtility* Self)
	{
		return Self->GetLinkerIndex();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(UObjectBaseUtility* Self)
	{
		return Self->GetLinkerLicenseeUE4Version();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerUE4Version(UObjectBaseUtility* Self)
	{
		return Self->GetLinkerUE4Version();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsDefaultSubobject(UObjectBaseUtility* Self)
	{
		return Self->IsDefaultSubobject();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsNative(UObjectBaseUtility* Self)
	{
		return Self->IsNative();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsPendingKill(UObjectBaseUtility* Self)
	{
		return Self->IsPendingKill();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsPendingKillOrUnreachable(UObjectBaseUtility* Self)
	{
		return Self->IsPendingKillOrUnreachable();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsRooted(UObjectBaseUtility* Self)
	{
		return Self->IsRooted();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsUnreachable(UObjectBaseUtility* Self)
	{
		return Self->IsUnreachable();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_MarkPackageDirty(UObjectBaseUtility* Self)
	{
		return Self->MarkPackageDirty();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_MarkPendingKill(UObjectBaseUtility* Self)
	{
		Self->MarkPendingKill();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_RemoveFromRoot(UObjectBaseUtility* Self)
	{
		Self->RemoveFromRoot();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(UObjectBaseUtility* Self)
	{
		return Self->ThisThreadAtomicallyClearedRFUnreachable();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
