#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Math/Range.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Math\Range.h:48

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_TRange(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<TRange>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_TRange_All(TRange* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->All());
	}

	DOTNET_EXPORT auto E_TRange_Empty(TRange* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->Empty());
	}

	DOTNET_EXPORT auto E_TRange_HasLowerBound(TRange* Self)
	{
		return Self->HasLowerBound();
	}

	DOTNET_EXPORT auto E_TRange_HasUpperBound(TRange* Self)
	{
		return Self->HasUpperBound();
	}

	DOTNET_EXPORT auto E_TRange_IsDegenerate(TRange* Self)
	{
		return Self->IsDegenerate();
	}

	DOTNET_EXPORT auto E_TRange_IsEmpty(TRange* Self)
	{
		return Self->IsEmpty();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
