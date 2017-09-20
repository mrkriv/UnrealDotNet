#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectBase.h"

class E_PROTECTED_WRAP_UObjectBase : protected UObjectBase
{
public:
	void LowLevelRename_WRAP(FName NewName, UObject* NewOuter)
	{
		LowLevelRename(NewName, NewOuter);
	}

	void RegisterDependencies_WRAP()
	{
		RegisterDependencies();
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_UObjectBase_GetFName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UObjectBase*)Self)->GetFName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT ObjectPointerDescription E_UObjectBase_GetOuter(INT_PTR Self)
	{
		return MakePrtDesc(((UObjectBase*)Self)->GetOuter());
	}

	DOTNET_EXPORT bool E_UObjectBase_IsValidLowLevel(INT_PTR Self)
	{
		return ((UObjectBase*)Self)->IsValidLowLevel();
	}

	DOTNET_EXPORT bool E_UObjectBase_IsValidLowLevelFast(INT_PTR Self, bool bRecursive)
	{
		auto _p0 = bRecursive;
		return ((UObjectBase*)Self)->IsValidLowLevelFast(_p0);
	}

	DOTNET_EXPORT void E_UObjectBase_LowLevelRename(INT_PTR Self, char* NewName, UObject* NewOuter)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(NewName));
		auto _p1 = NewOuter;
		((E_PROTECTED_WRAP_UObjectBase*)Self)->LowLevelRename_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObjectBase_RegisterDependencies(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UObjectBase*)Self)->RegisterDependencies_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
