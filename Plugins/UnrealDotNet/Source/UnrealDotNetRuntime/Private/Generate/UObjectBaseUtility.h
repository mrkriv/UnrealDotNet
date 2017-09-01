#pragma once

#include "CoreMinimal.h"
#include "UObject/UObjectBaseUtility.h"

class E_PROTECTED_WRAP_UObjectBaseUtility : protected UObjectBaseUtility
{
	public:
	void GetPathName_WRAP(const UObject* StopOuter, FString& ResultString)
	{
		GetPathName(StopOuter, ResultString);
	}

}
;

extern "C"
{
	DOTNET_EXPORT bool E_UObjectBaseUtility_IsPendingKill(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsPendingKill();
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_MarkPendingKill(INT_PTR Self)
	{
		((UObjectBaseUtility*)Self)->MarkPendingKill();
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsRooted(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->IsRooted();
	}

	DOTNET_EXPORT char* E_UObjectBaseUtility_GetFullName(INT_PTR Self, UObject* StopOuter, int& ResultStringLen)
	{
		auto _p0 = StopOuter;
		auto _result = ((UObjectBaseUtility*)Self)->GetFullName(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_AddToCluster(INT_PTR Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		((UObjectBaseUtility*)Self)->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObjectBaseUtility_GetPathName(INT_PTR Self, UObject* StopOuter, char* ResultString)
	{
		auto _p0 = StopOuter;
		auto _p1 = FString(ResultString);
		((E_PROTECTED_WRAP_UObjectBaseUtility*)Self)->GetPathName_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT char* E_UObjectBaseUtility_GetFullGroupName(INT_PTR Self, bool bStartWithOuter, int& ResultStringLen)
	{
		auto _p0 = bStartWithOuter;
		auto _result = ((UObjectBaseUtility*)Self)->GetFullGroupName(_p0);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT bool E_UObjectBaseUtility_IsIn(INT_PTR Self, UObject* SomeOuter)
	{
		auto _p0 = SomeOuter;
		return ((UObjectBaseUtility*)Self)->IsIn(_p0);
	}

	DOTNET_EXPORT int32 E_UObjectBaseUtility_GetLinkerIndex(INT_PTR Self)
	{
		return ((UObjectBaseUtility*)Self)->GetLinkerIndex();
	}

}
