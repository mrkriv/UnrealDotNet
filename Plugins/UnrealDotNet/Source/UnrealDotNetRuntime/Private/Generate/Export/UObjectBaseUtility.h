#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectBaseUtility.h"

extern "C"
{
	DOTNET_EXPORT void E_UObjectBaseUtility_AddToCluster(INT_PTR Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		((UObjectBaseUtility*)Self)->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_AddToRoot(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->AddToRoot();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_AppendName(INT_PTR Self, char* ResultString)
	{
		auto _p0 = FString(ResultString);
		((UObjectBaseUtility*)Self)->AppendName(_p0);
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_ClearPendingKill(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->ClearPendingKill();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_CreateCluster(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->CreateCluster();
	}

	DOTNET_EXPORT char* E_UObjectBaseUtility_GetFullGroupName(INT_PTR Self, bool bStartWithOuter, int& ResultStringLen)
	{
		auto _p0 = bStartWithOuter;
		auto _result = ((UObjectBaseUtility*)Self)->GetFullGroupName(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_UObjectBaseUtility_GetFullName(INT_PTR Self, UObject* StopOuter, int& ResultStringLen)
	{
		auto _p0 = StopOuter;
		auto _result = ((UObjectBaseUtility*)Self)->GetFullName(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerIndex(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerIndex();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerLicenseeUE4Version();
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerUE4Version(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerUE4Version();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsDefaultSubobject(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsDefaultSubobject();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsIn(INT_PTR Self, UObject* SomeOuter)
	{
		auto _p0 = SomeOuter;
		return ((UObjectBaseUtility*)Self)->IsIn(_p0);
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsNative(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsNative();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsPendingKill(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsPendingKill();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsPendingKillOrUnreachable(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsPendingKillOrUnreachable();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsRooted(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsRooted();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsUnreachable(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsUnreachable();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_MarkPackageDirty(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->MarkPackageDirty();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_MarkPendingKill(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->MarkPendingKill();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->OnClusterMarkedAsPendingKill();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_RemoveFromRoot(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->RemoveFromRoot();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->ThisThreadAtomicallyClearedRFUnreachable();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
