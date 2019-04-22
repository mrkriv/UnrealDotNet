#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/CoreUObject/Public/UObject/UObjectBaseUtility.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectBaseUtility.h:25

class E_PROTECTED_WRAP_UObjectBaseUtility : protected UObjectBaseUtility
{
public:
	void GetPathName_WRAP(const UObject* StopOuter, FString& ResultString)
	{
		GetPathName(StopOuter, ResultString);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_UObjectBaseUtility_AddToCluster(UObjectBaseUtility* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

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

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetFullName(UObjectBaseUtility* Self, UObject* StopOuter)
	{
		auto _p0 = StopOuter;
		return ConvertToManage_StringWrapper(Self->GetFullName(_p0));
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

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetName(UObjectBaseUtility* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetName());
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetName_o1(UObjectBaseUtility* Self, char* ResultString)
	{
		auto _p0 = ConvertFromManage_FString(ResultString);
		Self->GetName(_p0);
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetPathName(UObjectBaseUtility* Self, UObject* StopOuter)
	{
		auto _p0 = StopOuter;
		return ConvertToManage_StringWrapper(Self->GetPathName(_p0));
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetPathName_o1(UObjectBaseUtility* Self, UObject* StopOuter, char* ResultString)
	{
		auto _p0 = StopOuter;
		auto _p1 = ConvertFromManage_FString(ResultString);
		((E_PROTECTED_WRAP_UObjectBaseUtility*)Self)->GetPathName_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsDefaultSubobject(UObjectBaseUtility* Self)
	{
		return Self->IsDefaultSubobject();
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsIn(UObjectBaseUtility* Self, UObject* SomeOuter)
	{
		auto _p0 = SomeOuter;
		return Self->IsIn(_p0);
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
