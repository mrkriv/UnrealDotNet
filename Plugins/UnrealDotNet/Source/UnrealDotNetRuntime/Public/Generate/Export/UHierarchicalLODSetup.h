#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/WorldSettings.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:338

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UHierarchicalLODSetup_HierarchicalLODSetup_GET(UHierarchicalLODSetup* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->HierarchicalLODSetup); }
	DOTNET_EXPORT void E_PROP_UHierarchicalLODSetup_HierarchicalLODSetup_SET(UHierarchicalLODSetup* Ptr, INT_PTR Value) { Ptr->HierarchicalLODSetup = *(TArray<FHierarchicalSimplification>*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UHierarchicalLODSetup(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UHierarchicalLODSetup>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
