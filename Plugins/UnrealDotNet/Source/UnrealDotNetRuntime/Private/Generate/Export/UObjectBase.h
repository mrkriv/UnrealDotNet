#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "UObject/UObjectBase.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\UObject\UObjectBase.h:16

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
	DOTNET_EXPORT auto E_UObjectBase_GetFName(UObjectBase* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetFName());
	}

	DOTNET_EXPORT auto E_UObjectBase_GetOuter(UObjectBase* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetOuter());
	}

	DOTNET_EXPORT auto E_UObjectBase_IsValidLowLevel(UObjectBase* Self)
	{
		return Self->IsValidLowLevel();
	}

	DOTNET_EXPORT auto E_UObjectBase_IsValidLowLevelFast(UObjectBase* Self, bool bRecursive)
	{
		auto _p0 = bRecursive;
		return Self->IsValidLowLevelFast(_p0);
	}

	DOTNET_EXPORT auto E_UObjectBase_LowLevelRename(UObjectBase* Self, char* NewName, UObject* NewOuter)
	{
		auto _p0 = ConvertFromManage_FName(NewName);
		auto _p1 = NewOuter;
		((E_PROTECTED_WRAP_UObjectBase*)Self)->LowLevelRename_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UObjectBase_RegisterDependencies(UObjectBase* Self)
	{
		((E_PROTECTED_WRAP_UObjectBase*)Self)->RegisterDependencies_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
