#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Core/Public/Math/ScalarRegister.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\ScalarRegister.h:26

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ScalarRegister_Value_GET(ScalarRegister* Ptr) { return (INT_PTR)&(Ptr->Value); }
	DOTNET_EXPORT void E_PROP_ScalarRegister_Value_SET(ScalarRegister* Ptr, INT_PTR Value) { Ptr->Value = *(VectorRegister*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ScalarRegister(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ScalarRegister>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
